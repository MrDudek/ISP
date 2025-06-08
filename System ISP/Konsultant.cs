using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace System_ISP
{
    public partial class Konsultant : Form
    {
        public Konsultant()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void logout_Click(object sender, EventArgs e)
        //przycisk do wylogowania
        {
            Form1 loginForm = new Form1();
            loginForm.Show();
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private async void buttonnewfaktura_Click(object sender, EventArgs e)
        //przycisk do wyszukiwania 
        {
            string query = findbox.Text.Trim();

            if (string.IsNullOrEmpty(query))
            {
                MessageBox.Show("Wpisz dane do wyszukania.");
                return;
            }

            try
            {
                using (var client = new HttpClient())
                {
                    string url = $"http://localhost:5180/api/Consultant/search-users?FullName={Uri.EscapeDataString(query)}";
                    var response = await client.GetAsync(url);

                    if (response.IsSuccessStatusCode)
                    {
                        string responseBody = await response.Content.ReadAsStringAsync();
                        var users = JsonSerializer.Deserialize<List<ClientDto>>(responseBody);
                        dataGridView1.DataSource = users;
                    }
                    else
                    {
                        MessageBox.Show("❌ Błąd podczas pobierania danych z serwera.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"❌ Błąd połączenia: {ex.Message}");
            }
        }

        private void Konsultant_Load(object sender, EventArgs e)
        {

        }

        private void findbox_Click(object sender, EventArgs e)
        //miejsce do wpisania np danych do szukania
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        // datagridview do wyswietlania
        {

        }

        private async void refresh_Click(object sender, EventArgs e)
        {
            string query = findbox.Text.Trim();

            if (string.IsNullOrEmpty(query))
            {
                MessageBox.Show("Wpisz dane do wyszukania.");
                return;
            }

            try
            {
                using (var client = new HttpClient())
                {
                    string url = $"http://localhost:5180/api/Consultant/search-clients?FullName={Uri.EscapeDataString(query)}";
                    var response = await client.GetAsync(url);

                    if (response.IsSuccessStatusCode)
                    {
                        string responseBody = await response.Content.ReadAsStringAsync();
                        var users = JsonSerializer.Deserialize<List<ClientDto>>(responseBody);
                        dataGridView1.DataSource = users;
                    }
                    else
                    {
                        MessageBox.Show("❌ Błąd podczas pobierania danych z serwera.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"❌ Błąd połączenia: {ex.Message}");
            }
        }
    }

    public class ClientDto
    {
        public int idKlient { get; set; }
        public string imie { get; set; }
        public string nazwisko { get; set; }
        public string login { get; set; }
        public string email { get; set; }
        public string telefon { get; set; }
    }
}
