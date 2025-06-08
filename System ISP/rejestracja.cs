using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Windows.Forms;

namespace System_ISP
{
    public partial class rejestracja : BaseForm
    {
        private class Usluga
        {
            public int Id { get; set; }
            public string Nazwa { get; set; }

            public override string ToString()
            {
                return Nazwa;
            }
        }

        public rejestracja()
        {
            InitializeComponent();
            EnableDrag(panel1);
            SetupRoleComboBox();
            SetupUslugiComboBox();
        }

        private void SetupRoleComboBox()
        {
            comboBox1.Items.Clear();
            comboBox1.Items.Add("— Wybierz rolę —");
            comboBox1.Items.Add("Admin");
            comboBox1.Items.Add("Konsultant");
            comboBox1.Items.Add("Serwisant");
            comboBox1.Items.Add("Ksiegowy");
            comboBox1.Items.Add("Klient");
            comboBox1.SelectedIndex = 0;
        }

        private void SetupUslugiComboBox()
        {
            comboBox2.Items.Clear();
            comboBox2.Items.Add(new Usluga { Id = 0, Nazwa = "-- Wybierz usługę --" });
            comboBox2.Items.Add(new Usluga { Id = 1, Nazwa = "Internet 100Mb - Standard" });
            comboBox2.Items.Add(new Usluga { Id = 2, Nazwa = "Internet 300Mb - Premium" });
            comboBox2.SelectedIndex = 0;
        }

        private async void materialButton1_Click(object sender, EventArgs e)
        {
            string login = Login.Text.Trim();
            string haslo = materialTextBox21.Text.Trim();
            string imie = materialTextBox22.Text.Trim();
            string nazwisko = materialTextBox23.Text.Trim();
            string mail = materialTextBox24.Text.Trim();
            string tel = materialTextBox25.Text.Trim();
            string pesel = materialTextBox26.Text.Trim(); 
            string rola = comboBox1.SelectedItem?.ToString();
            Usluga usluga = comboBox2.SelectedItem as Usluga;

            if (string.IsNullOrEmpty(rola) || rola == "— Wybierz rolę —"
                || string.IsNullOrEmpty(login) || string.IsNullOrEmpty(haslo)
                || string.IsNullOrEmpty(imie) || string.IsNullOrEmpty(nazwisko)
                || string.IsNullOrEmpty(mail) || string.IsNullOrEmpty(tel) || string.IsNullOrEmpty(pesel))
            {
                MessageBox.Show("⚠️ Uzupełnij wszystkie pola!");
                return;
            }

            int idRola = rola switch
            {
                "Admin" => 1,
                "Konsultant" => 2,
                "Serwisant" => 3,
                "Ksiegowy" => 4,
                "Klient" => 5,
                _ => 0
            };

            int idUsluga = usluga?.Id ?? 0;

            var userData = new
            {
                login = login,
                email = mail,
                pass = haslo,
                imie = imie,
                nazwisko = nazwisko,
                telefon = tel,
                wiek = 0,
                idUsluga = idUsluga,
                idRola = idRola,
                pesel = pesel
            };

            try
            {
                using (var client = new HttpClient())
                {
                    string json = JsonSerializer.Serialize(userData);
                    var content = new StringContent(json, Encoding.UTF8, "application/json");

                    var response = await client.PostAsync("http://localhost:5180/api/RegisterUser", content);
                    if (response.IsSuccessStatusCode)
                    {
                        MessageBox.Show("✅ Rejestracja zakończona sukcesem.");
                        Login.Clear();
                        materialTextBox21.Clear();
                        materialTextBox22.Clear();
                        materialTextBox23.Clear();
                        materialTextBox24.Clear();
                        materialTextBox25.Clear();
                        materialTextBox26.Clear();
                        comboBox1.SelectedIndex = 0;
                        comboBox2.SelectedIndex = 0;
                    }
                    else
                    {
                        string res = await response.Content.ReadAsStringAsync();
                        MessageBox.Show($"❌ Błąd rejestracji ({response.StatusCode}):\n{res}");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("❌ Błąd połączenia z API:\n" + ex.Message);
            }
        }

        // Puste eventy UI
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e) { }
        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e) { }
        private void nazwa_Click(object sender, EventArgs e) { }
        private void login_pass_TextChanged(object sender, EventArgs e) { }
        private void button_login_Click(object sender, EventArgs e) { }
        private void exit_Click(object sender, EventArgs e) { this.Close(); }
        private void login_username_TextChanged(object sender, EventArgs e) { }
        private void name_Click(object sender, EventArgs e) { }
        private void surname_Click(object sender, EventArgs e) { }
        private void Email_Click(object sender, EventArgs e) { }
        private void telefon_Click(object sender, EventArgs e) { }
        private void textBox1_TextChanged(object sender, EventArgs e) { }
        private void textBox2_TextChanged(object sender, EventArgs e) { }
        private void textBox3_TextChanged(object sender, EventArgs e) { }
        private void textBox4_TextChanged(object sender, EventArgs e) { }
        private void nametekst_Click(object sender, EventArgs e) { }
        private void Login_Click(object sender, EventArgs e) { }
        private void materialTextBox21_Click(object sender, EventArgs e) { }
        private void materialTextBox22_Click(object sender, EventArgs e) { }
        private void materialTextBox23_Click(object sender, EventArgs e) { }
        private void materialTextBox24_Click(object sender, EventArgs e) { }
        private void materialTextBox25_Click(object sender, EventArgs e) { }
        private void materialTextBox26_Click(object sender, EventArgs e) { }
        private void materialLabel9_Click(object sender, EventArgs e) { }
    }
}
