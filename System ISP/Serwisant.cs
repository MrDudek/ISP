using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace System_ISP
{
    public partial class Serwisant : BaseForm
    {
        private readonly string baseApiUrl = "http://localhost:5180";
        private List<ZgloszenieDto> _tickets = new();

        public Serwisant()
        {
            InitializeComponent();
            EnableDrag(panel1);

            this.Load += Serwisant_Load;
            this.refresh.Click += new EventHandler(refresh_Click);

            polestatusu.Items.Clear();
            polestatusu.Items.Add("— Wybierz status zgłoszenia —");
            polestatusu.Items.Add("Otwarte");
            polestatusu.Items.Add("W trakcie");
            polestatusu.Items.Add("Zamknięte");
            polestatusu.Items.Add("Oczekujące");
            polestatusu.Items.Add("Anulowane");
            polestatusu.SelectedIndex = 0;
        }

        private async void Serwisant_Load(object sender, EventArgs e)
        {
            await LoadTicketsAsync();
            if (_tickets.Any())
            {
                dataGridView1.ClearSelection();
                dataGridView1.Rows[0].Selected = true;
                WyswietlSzczegoly(_tickets[0]);
            }
        }

        private async void refresh_Click(object sender, EventArgs e)
        {
            await LoadTicketsAsync();
            if (_tickets.Any())
            {
                dataGridView1.ClearSelection();
                dataGridView1.Rows[0].Selected = true;
                WyswietlSzczegoly(_tickets[0]);
            }
        }

        private async Task LoadTicketsAsync()
        {
            try
            {
                using (HttpClient client = new HttpClient())
                {
                    client.BaseAddress = new Uri(baseApiUrl);
                    var response = await client.GetAsync("/api/Ticket/all");

                    if (response.IsSuccessStatusCode)
                    {
                        _tickets = await response.Content.ReadFromJsonAsync<List<ZgloszenieDto>>();
                        dataGridView1.DataSource = _tickets;
                    }
                    else
                    {
                        MessageBox.Show($"Błąd: {response.StatusCode}");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Wystąpił błąd: {ex.Message}");
            }
        }

        private async void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dataGridView1.Rows[e.RowIndex].DataBoundItem is ZgloszenieDto selectedTicket)
            {
                WyswietlSzczegoly(selectedTicket);
            }
        }

        private async void WyswietlSzczegoly(ZgloszenieDto zgloszenie)
        {
            tresczgloszenia.Text = zgloszenie.OpisZgloszenia;
            polestatusu.SelectedIndex = zgloszenie.IdStatus;

            try
            {
                using (HttpClient client = new HttpClient())
                {
                    client.BaseAddress = new Uri(baseApiUrl);
                    var response = await client.GetAsync("/api/Consultant/all-users");

                    if (response.IsSuccessStatusCode)
                    {
                        var wszyscy = await response.Content.ReadFromJsonAsync<List<UzytkownikDto>>();
                        var klient = wszyscy.FirstOrDefault(k => k.Id == zgloszenie.IdKlient);

                        if (klient != null)
                        {
                            textBox1.Text = $"Imię: {klient.Imie}\r\nNazwisko: {klient.Nazwisko}\r\nEmail: {klient.Email}\r\nTelefon: {klient.Telefon}";
                        }
                        else
                        {
                            textBox1.Text = "Aby pozyskać dane klienta skontaktuj sie z Konsultantem.";
                        }
                    }
                    else
                    {
                        textBox1.Text = $"Błąd API: {response.StatusCode}";
                    }
                }
            }
            catch (Exception ex)
            {
                textBox1.Text = $"Wyjątek: {ex.Message}";
            }
        }

    

        private class ZgloszenieDto
        {
            public int IdZgloszenie { get; set; }
            public string OpisZgloszenia { get; set; }
            public int IdTypZgloszenia { get; set; }
            public int IdStatus { get; set; }
            public int IdKlient { get; set; }
            public int IdPracownik { get; set; }
        }

        private class UzytkownikDto
        {
            public int Id { get; set; } 
            public string Imie { get; set; }
            public string Nazwisko { get; set; }
            public string Email { get; set; }
            public string Telefon { get; set; }
            public string Rola { get; set; }
        }

       

        private void tekst_Click(object sender, EventArgs e) { }
        private void listauserow_Click(object sender, EventArgs e) { }
        private void button1_Click(object sender, EventArgs e) { }
        private void szczegoly_Click(object sender, EventArgs e) { }
        private void tresczgloszenia_TextChanged(object sender, EventArgs e) { }
        private void save_Click(object sender, EventArgs e) { }
        private void textBox1_TextChanged(object sender, EventArgs e) { }
        private void polestatusu_SelectedIndexChanged(object sender, EventArgs e) { }
        private void pictureBox1_Click(object sender, EventArgs e) => Application.Exit();
        private void logout_Click(object sender, EventArgs e)
        {
            Form1 loginForm = new Form1();
            loginForm.Show();
            this.Close();
        }
        private void materialButton1_Click(object sender, EventArgs e) { }
    }
}
