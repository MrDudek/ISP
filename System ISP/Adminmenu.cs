using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace System_ISP
{
    public partial class Adminmenu : BaseForm
    {
        public Adminmenu()
        {
            InitializeComponent();
            EnableDrag(panel1);
            _ = WczytajUzytkownikow();
        }

        private void label1_Click(object sender, EventArgs e) { }
        private void data_ValueChanged(object sender, EventArgs e) { }

        private void Ksiegowy_Click(object sender, EventArgs e)
        {
            Ksiegowy ksiegowyForm = new Ksiegowy();
            ksiegowyForm.Show();
            this.Hide();
        }

        private void Adminmenu_Load(object sender, EventArgs e) { }
        private void Home_Click(object sender, EventArgs e) { }
        private void panel3_Paint(object sender, PaintEventArgs e) { }

        private void logout_Click(object sender, EventArgs e)
        {
            Form1 loginForm = new Form1();
            loginForm.Show();
            this.Close();
        }

        private void toolTip1_Popup(object sender, PopupEventArgs e) { }
        private void panel1_Paint(object sender, PaintEventArgs e) { }
        private void button1_Click(object sender, EventArgs e) { }
        private void button4_Click(object sender, EventArgs e) { }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label1_Click_1(object sender, EventArgs e) { }

        private void refresh_Click(object sender, EventArgs e)
        {
            _ = WczytajUzytkownikow();
        }

        private void Rejestracja_Click(object sender, EventArgs e)
        {
            rejestracja rejestracjaOkno = new rejestracja();
            rejestracjaOkno.Show();
        }

        private void Serwisant_Click(object sender, EventArgs e)
        {
            Serwisant serwisantForm = new Serwisant();
            serwisantForm.Show();
            this.Hide();
        }

        private void Konsultant_Click(object sender, EventArgs e)
        {
            Konsultant konsultantForm = new Konsultant();
            konsultantForm.Show();
            this.Hide();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            usuwanieuser oknoUsuwania = new usuwanieuser();
            oknoUsuwania.Show();
        }

        private void label1_Click_2(object sender, EventArgs e) { }

        private void listapracownikowtabela_CellContentClick(object sender, DataGridViewCellEventArgs e) { }

        // pobiera użytkowników z endpointa i rozdziela wg typu
        private async Task WczytajUzytkownikow()
        {
            try
            {
                using (var client = new HttpClient())
                {
                    var response = await client.GetAsync("http://localhost:5180/api/Consultant/all-users");
                    if (response.IsSuccessStatusCode)
                    {
                        var json = await response.Content.ReadAsStringAsync();
                        var wszyscy = JsonSerializer.Deserialize<List<UzytkownikDto>>(json, new JsonSerializerOptions
                        {
                            PropertyNameCaseInsensitive = true
                        });

                        var klienci = new List<UzytkownikDto>();
                        var pracownicy = new List<UzytkownikDto>();

                        foreach (var user in wszyscy)
                        {
                            if (user.Typ == "Klient")
                                klienci.Add(user);
                            else
                                pracownicy.Add(user);
                        }

                        dataGridView1.DataSource = klienci;
                        listapracownikowtabela.DataSource = pracownicy;
                    }
                    else
                    {
                        MessageBox.Show("❌ Błąd podczas pobierania danych z serwera.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("❌ Błąd ładowania danych z API:\n" + ex.Message);
            }
        }

        private void konsultantbutton_Click(object sender, EventArgs e)
        {
            Konsultant konsultantForm = new Konsultant();
            konsultantForm.Show();
            this.Hide();
        }

        private void serwisantbutton_Click(object sender, EventArgs e)
        {
            Serwisant serwisantForm = new Serwisant();
            serwisantForm.Show();
            this.Hide();
        }

        private void ksiegowybutton_Click(object sender, EventArgs e)
        {
            Ksiegowy ksiegowyForm = new Ksiegowy();
            ksiegowyForm.Show();
            this.Hide();
        }

        private void newuserbuttonadd_Click(object sender, EventArgs e)
        {
            rejestracja rejestracjaOkno = new rejestracja();
            rejestracjaOkno.Show();
        }

        private void materialButton1_Click(object sender, EventArgs e)
        {
            usuwanieuser oknoUsuwania = new usuwanieuser();
            oknoUsuwania.Show();
        }

        private void panele_Click(object sender, EventArgs e) { }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                string imie = row.Cells["imie"].Value?.ToString();
                string nazwisko = row.Cells["nazwisko"].Value?.ToString();
                string login = row.Cells["login"].Value?.ToString();
                string email = row.Cells["email"].Value?.ToString();
                string telefon = row.Cells["telefon"].Value?.ToString();

                MessageBox.Show($"Imię: {imie}\n" +
                                $"Nazwisko: {nazwisko}\n" +
                                $"Login: {login}\n" +
                                $"Email: {email}\n" +
                                $"Telefon: {telefon}",
                                "Dane klienta",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
            }
        }

        private void tabelka_Paint(object sender, PaintEventArgs e) { }
        private void label1_Click_3(object sender, EventArgs e) { }
        private void panel2_Paint(object sender, PaintEventArgs e) { }

        private void materialButton2_Click(object sender, EventArgs e)
        {
            user userPanel = new user();
            userPanel.Show();
            this.Hide();
        }

        // DTO dla użytkownika (klient + pracownik)
        public class UzytkownikDto
        {
            public string Login { get; set; }
            public string Imie { get; set; }
            public string Nazwisko { get; set; }
            public int Wiek { get; set; }
            public string Email { get; set; }
            public string Telefon { get; set; }
            public string NazwaUslugi { get; set; }
            public string Rola { get; set; }
            public string Typ { get; set; }
            public string Pesel { get; set; }
        }
    }
}
