using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace System_ISP
{
    public partial class faktury : BaseForm
    {
        private List<UserDto> _users = new();

        public faktury()
        {
            InitializeComponent();

            comboBox3.Items.Clear();
            comboBox3.Items.Add("— Wybierz VAT —");
            comboBox3.Items.Add("23%");
            comboBox3.Items.Add("8%");
            comboBox3.SelectedIndex = 0;

            comboBox2.Items.Clear();
            comboBox2.Items.Add("Internet 100Mb");
            comboBox2.Items.Add("Internet 300Mb");
            comboBox2.SelectedIndex = 0;

            textBox3.ReadOnly = true;

            comboBox3.SelectedIndexChanged += comboBox3_SelectedIndexChanged;
            textBox2.TextChanged += textBox2_TextChanged;

            _ = LoadUsersAsync();
        }

        private async Task LoadUsersAsync()
        {
            try
            {
                using var client = new HttpClient();
                var res = await client.GetAsync("http://localhost:5180/api/Consultant/all-users");
                if (res.IsSuccessStatusCode)
                {
                    var json = await res.Content.ReadAsStringAsync();
                    _users = JsonSerializer.Deserialize<List<UserDto>>(json, new JsonSerializerOptions { PropertyNameCaseInsensitive = true });

                    comboBox1.Items.Clear();
                    comboBox1.DisplayMember = "Text";
                    comboBox1.ValueMember = "Value";

                    foreach (var user in _users)
                    {
                        comboBox1.Items.Add(new ComboBoxItem
                        {
                            Text = $"{user.Imie} {user.Nazwisko} ({user.Login.Trim()})",
                            Value = user
                        });
                    }

                    if (comboBox1.Items.Count > 0)
                        comboBox1.SelectedIndex = 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("❌ Błąd ładowania użytkowników: " + ex.Message);
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e) => PrzeliczBrutto();
        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e) => PrzeliczBrutto();

        private void PrzeliczBrutto()
        {
            if (comboBox3.SelectedIndex <= 0)
            {
                textBox3.Text = "";
                return;
            }

            if (decimal.TryParse(textBox2.Text.Replace(',', '.'), out decimal cenaNetto))
            {
                string selectedVat = comboBox3.SelectedItem.ToString();
                decimal stawkaVat = selectedVat == "23%" ? 0.23m : 0.08m;

                decimal cenaBrutto = cenaNetto * (1 + stawkaVat);
                textBox3.Text = cenaBrutto.ToString("0.00");
            }
            else
            {
                textBox3.Text = "";
            }
        }

        private async void materialButton1_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex < 0 || comboBox2.SelectedIndex < 0 || comboBox3.SelectedIndex <= 0 || string.IsNullOrWhiteSpace(textBox2.Text))
            {
                MessageBox.Show("❌ Wypełnij wszystkie wymagane pola.");
                return;
            }

            if (!decimal.TryParse(textBox3.Text, System.Globalization.NumberStyles.Any, System.Globalization.CultureInfo.GetCultureInfo("pl-PL"), out decimal kwota))
            {
                MessageBox.Show("❌ Błąd w wartości brutto.");
                return;
            }

            if (comboBox1.SelectedItem is not ComboBoxItem selectedItem || selectedItem.Value is not UserDto selectedUser)
            {
                MessageBox.Show("❌ Nieprawidłowy wybór użytkownika.");
                return;
            }

            var request = new FakturaCreateRequest
            {
                IdKlient = selectedUser.IdKlient,
                Imie = selectedUser.Imie,
                Nazwisko = selectedUser.Nazwisko,
                Pesel = selectedUser.Pesel,
                Kwota = kwota,
                PracownikLogin = Session.LoggedInLogin
            };

            try
            {
                using var client = new HttpClient();
                var content = new StringContent(JsonSerializer.Serialize(request), Encoding.UTF8, "application/json");
                var res = await client.PostAsync("http://localhost:5180/api/Faktura/generate", content);
                if (res.IsSuccessStatusCode)
                {
                    MessageBox.Show("✅ Faktura została wygenerowana.");
                    this.Close();
                }
                else
                {
                    string msg = await res.Content.ReadAsStringAsync();
                    MessageBox.Show("❌ Nie udało się wygenerować faktury:\n" + msg);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("❌ Błąd sieci: " + ex.Message);
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e) => textBox3.ReadOnly = true;
        private void pictureBox2_Click(object sender, EventArgs e) => this.Close();

        private class UserDto
        {
            public int IdKlient { get; set; }
            public string Login { get; set; }
            public string Imie { get; set; }
            public string Nazwisko { get; set; }
            public string Email { get; set; }
            public string Telefon { get; set; }
            public string NazwaUslugi { get; set; }
            public string Pesel { get; set; }
        }

        private class FakturaCreateRequest
        {
            public int IdKlient { get; set; }
            public string Imie { get; set; }
            public string Nazwisko { get; set; }
            public string Pesel { get; set; }
            public decimal Kwota { get; set; }
            public string PracownikLogin { get; set; }
        }

        private class ComboBoxItem
        {
            public string Text { get; set; }
            public object Value { get; set; }

            public override string ToString() => Text;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e) { }
        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e) { }
    }
}
