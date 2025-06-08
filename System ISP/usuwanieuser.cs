using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace System_ISP
{
    public partial class usuwanieuser : BaseForm
    {
        public usuwanieuser()
        {
            InitializeComponent();
            EnableDrag(panel1);
            this.Load += usuwanieuser_Load;
        }

        private class User
        {
            public string login { get; set; }
            public string imie { get; set; }
            public string nazwisko { get; set; }
            public string rola { get; set; }
            public string typ { get; set; }

            public override string ToString()
            {
                return $"{imie} {nazwisko} ({login}) [{typ ?? "brak typu"}]";
            }
        }

        private List<User> users = new List<User>();
        private const string ApiBaseUrl = "http://localhost:5180";

        private async void usuwanieuser_Load(object sender, EventArgs e)
        {
            try
            {
                uzytkownicy.Items.Clear();
                uzytkownicy.Items.Add("— Wybierz użytkownika —");

                using (HttpClient client = new HttpClient())
                {
                    string url = $"{ApiBaseUrl}/api/Consultant/all-users";
                    var response = await client.GetAsync(url);
                    string rawJson = await response.Content.ReadAsStringAsync();

                    if (!response.IsSuccessStatusCode)
                    {
                        MessageBox.Show($"❌ Błąd HTTP: {response.StatusCode}");
                        return;
                    }

                    var usersList = JsonSerializer.Deserialize<List<User>>(rawJson, new JsonSerializerOptions
                    {
                        PropertyNameCaseInsensitive = true
                    });

                    if (usersList == null || usersList.Count == 0)
                    {
                        MessageBox.Show("⚠️ Brak użytkowników do wyświetlenia.");
                        return;
                    }

                    users = usersList;

                    foreach (var user in users)
                    {
                        uzytkownicy.Items.Add(user.ToString());
                    }

                    uzytkownicy.SelectedIndex = 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("❌ Błąd pobierania użytkowników:\n" + ex.Message);
            }
        }

        private async void materialButton1_Click(object sender, EventArgs e)
        {
            if (uzytkownicy.SelectedIndex <= 0)
            {
                MessageBox.Show("⚠️ Wybierz użytkownika do usunięcia.");
                return;
            }

            string selectedText = uzytkownicy.SelectedItem.ToString();
            User selectedUser = users.Find(u => selectedText.Contains($"({u.login})"));

            if (selectedUser == null)
            {
                MessageBox.Show("❌ Nie udało się znaleźć użytkownika do usunięcia.");
                return;
            }

            var confirm = MessageBox.Show(
                $"Czy na pewno chcesz usunąć użytkownika {selectedUser.login}?",
                "Potwierdzenie usunięcia",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (confirm != DialogResult.Yes)
                return;

            try
            {
                using (HttpClient client = new HttpClient())
                {
                    string deleteUrl = $"{ApiBaseUrl}/api/RegisterUser/delete/{selectedUser.login.Trim()}";
                    var response = await client.DeleteAsync(deleteUrl);

                    if (response.IsSuccessStatusCode)
                    {
                        MessageBox.Show("✅ Użytkownik został usunięty.");
                        uzytkownicy.Items.Remove(selectedText);
                        users.Remove(selectedUser);
                        uzytkownicy.SelectedIndex = 0;
                    }
                    else
                    {
                        string error = await response.Content.ReadAsStringAsync();
                        MessageBox.Show($"❌ Błąd usuwania użytkownika: {response.StatusCode}\n{error}");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("❌ Wyjątek API:\n" + ex.Message);
            }
        }

        private void exit_Click(object sender, EventArgs e) => this.Close();
        private void uzytkownicy_SelectedIndexChanged(object sender, EventArgs e) { }
        private void materialLabel1_Click(object sender, EventArgs e) { }
        private void label2_Click(object sender, EventArgs e) { }
    }
}
