using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace System_ISP
{
    public partial class dodajzglosznie : BaseForm
    {
        public dodajzglosznie()
        {
            InitializeComponent();
        }

        private async void materialButton1_Click(object sender, EventArgs e)
        {
            string temat = textBox1.Text.Trim();
            string opis = textBox2.Text.Trim();
            string login = Session.LoggedInLogin;

            if (string.IsNullOrWhiteSpace(temat) || string.IsNullOrWhiteSpace(opis))
            {
                MessageBox.Show("Wypełnij wszystkie pola.");
                return;
            }

            try
            {
                using var client = new HttpClient();

                // Pobiera ID klienta na podstawie loginu
                var resUsers = await client.GetAsync("http://localhost:5180/api/Consultant/all-users");
                if (!resUsers.IsSuccessStatusCode)
                {
                    MessageBox.Show("Nie udało się pobrać danych użytkownika.");
                    return;
                }

                var jsonUsers = await resUsers.Content.ReadAsStringAsync();
                var users = JsonSerializer.Deserialize<List<UserDto>>(jsonUsers, new JsonSerializerOptions { PropertyNameCaseInsensitive = true });
                var current = users.FirstOrDefault(u => u.Login?.Trim().Equals(login?.Trim(), StringComparison.OrdinalIgnoreCase) == true);
                if (current == null)
                {
                    MessageBox.Show("Nie znaleziono użytkownika.");
                    return;
                }

                //  dane zgłoszenia
                var requestData = new
                {
                    opisZgloszenia = opis,
                    typZgloszenia = temat,
                    idKlient = current.Id,
                    statusId = 4 // "oczekujące"
                };

                var content = new StringContent(JsonSerializer.Serialize(requestData), Encoding.UTF8, "application/json");
                var response = await client.PostAsync("http://localhost:5180/api/Ticket", content);

                if (response.IsSuccessStatusCode)
                {
                    MessageBox.Show("✅ Zgłoszenie zostało dodane.");
                    this.Close();
                }
                else
                {
                    var error = await response.Content.ReadAsStringAsync();
                    MessageBox.Show("❌ Nie udało się dodać zgłoszenia.\n" + error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("❌ Błąd:\n" + ex.Message);
            }
        }

        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private class UserDto
        {
            public int Id { get; set; }
            public string Login { get; set; }
            public string Imie { get; set; }
            public string Nazwisko { get; set; }
            public string Email { get; set; }
            public string Telefon { get; set; }
            public string NazwaUslugi { get; set; }
        }

        private void textBox1_TextChanged(object sender, EventArgs e) { }
        private void textBox2_TextChanged(object sender, EventArgs e) { }
        private void nazwa_Click(object sender, EventArgs e) { }

        private void materialButton2_Click(object sender, EventArgs e)
        {
            var temat = textBox1.Text.Trim();
            var opis = textBox2.Text.Trim();

            if (string.IsNullOrEmpty(temat) || string.IsNullOrEmpty(opis))
            {
                MessageBox.Show("Uzupełnij temat i opis zgłoszenia.");
                return;
            }

            var lokalneZgloszenie = new TicketDto
            {
                Id = new Random().Next(1000, 9999), 
                Login = Session.LoggedInLogin,
                Opis = $"{temat}: {opis}",
                Status = "Lokalne (testowe)"
            };

            // Dodanie do DataGridView w user.cs 
            foreach (Form f in Application.OpenForms)
            {
                if (f is user userForm)
                {
                    var lista = userForm.dataGridView2.DataSource as List<TicketDto>;
                    if (lista != null)
                    {
                        lista.Add(lokalneZgloszenie);
                        userForm.dataGridView2.DataSource = null;
                        userForm.dataGridView2.DataSource = lista;
                    }
                    break;
                }
            }

            MessageBox.Show("✅ Dodano zgłoszenie lokalne.");
            this.Close();
        }
    }
    public class TicketDto
    {
        public int Id { get; set; }
        public string Login { get; set; }
        public string Opis { get; set; }
        public string Status { get; set; }
    }
}
