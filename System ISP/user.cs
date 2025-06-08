using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace System_ISP
{
    public partial class user : BaseForm
    {
        public user()
        {
            InitializeComponent();
            Load += user_Load;
        }

        private async void user_Load(object sender, EventArgs e)
        {
            string login = Session.LoggedInLogin;

            if (string.IsNullOrWhiteSpace(login))
            {
                MessageBox.Show("Brak loginu. Wróć do logowania.");
                this.Close();
                return;
            }

            try
            {
                using var client = new HttpClient();

                // Pobierz użytkownika
                var res = await client.GetAsync("http://localhost:5180/api/Consultant/all-users");
                if (res.IsSuccessStatusCode)
                {
                    var json = await res.Content.ReadAsStringAsync();
                    var users = JsonSerializer.Deserialize<List<UserDto>>(json, new JsonSerializerOptions { PropertyNameCaseInsensitive = true });
                    var current = users.FirstOrDefault(u =>
                        string.Equals(u.Login?.Trim(), login?.Trim(), StringComparison.OrdinalIgnoreCase));
                    if (current != null)
                    {
                        label1.Text = $"{current.Imie} {current.Nazwisko}";
                        label2.Text = current.Email ?? "-";
                        label3.Text = current.Telefon ?? "-";
                        label4.Text = current.NazwaUslugi ?? "-";

                        // Pobierz faktury i filtruj po ImieNazwiskoKlienta
                        var resFaktury = await client.GetAsync("http://localhost:5180/api/Faktura/Invoiceslist");
                        if (resFaktury.IsSuccessStatusCode)
                        {
                            var jsonFaktury = await resFaktury.Content.ReadAsStringAsync();
                            var faktury = JsonSerializer.Deserialize<List<FakturaDto>>(jsonFaktury, new JsonSerializerOptions
                            {
                                PropertyNameCaseInsensitive = true
                            });

                            string imieNazwiskoUsera = $"{current.Imie} {current.Nazwisko}".Trim();

                            var userFaktury = faktury?
                                .Where(f => f != null &&
                                            !string.IsNullOrEmpty(f.ImieNazwiskoKlienta) &&
                                            f.ImieNazwiskoKlienta.Trim().Equals(imieNazwiskoUsera, StringComparison.OrdinalIgnoreCase))
                                .ToList() ?? new List<FakturaDto>();

                            dataGridView1.DataSource = userFaktury;

                            if (dataGridView1.Columns.Contains("Status"))
                                dataGridView1.Columns["Status"].HeaderText = "Status PDF";
                        }
                    }
                }

                // Pobierz zgłoszenia
                var resTickets = await client.GetAsync("http://localhost:5180/api/Ticket/all");
                if (resTickets.IsSuccessStatusCode)
                {
                    var json = await resTickets.Content.ReadAsStringAsync();
                    var tickets = JsonSerializer.Deserialize<List<TicketDto>>(json);
                    var userTickets = tickets
                        .Where(t => t.Login?.Trim().Equals(login.Trim(), StringComparison.OrdinalIgnoreCase) == true)
                        .ToList();

                    dataGridView2.DataSource = userTickets;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("❌ Błąd ładowania danych:\n" + ex.Message);
            }
        }

        private async void ksiegowybutton_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Wybierz fakturę.");
                return;
            }

            var selected = dataGridView1.SelectedRows[0].DataBoundItem as FakturaDto;
            if (selected == null) return;

            using var client = new HttpClient();
            var response = await client.GetAsync($"http://localhost:5180/api/Faktura/get-Invoice/{selected.IdFaktura}");
            if (response.IsSuccessStatusCode)
            {
                var bytes = await response.Content.ReadAsByteArrayAsync();
                string tempFile = System.IO.Path.Combine(System.IO.Path.GetTempPath(), $"faktura_{selected.IdFaktura}.pdf");
                await System.IO.File.WriteAllBytesAsync(tempFile, bytes);

                System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo
                {
                    FileName = tempFile,
                    UseShellExecute = true
                });
            }
            else
            {
                MessageBox.Show("❌ Nie udało się pobrać faktury.");
            }
        }

        private void materialButton1_Click(object sender, EventArgs e)
        {
            dodajzglosznie formularzZgloszenia = new dodajzglosznie();
            formularzZgloszenia.Show();
            this.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void logout_Click(object sender, EventArgs e)
        {
            Form1 loginForm = new Form1();
            loginForm.Show();
            this.Close();
        }

        private async void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            var row = dataGridView1.Rows[e.RowIndex];
            if (row.DataBoundItem is FakturaDto faktura)
            {
                try
                {
                    using var client = new HttpClient();
                    var response = await client.GetAsync($"http://localhost:5180/api/Faktura/get-Invoice/{faktura.IdFaktura}");
                    if (response.IsSuccessStatusCode)
                    {
                        var bytes = await response.Content.ReadAsByteArrayAsync();
                        string tempFile = System.IO.Path.Combine(System.IO.Path.GetTempPath(), $"faktura_{faktura.IdFaktura}.pdf");
                        await System.IO.File.WriteAllBytesAsync(tempFile, bytes);

                        System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo
                        {
                            FileName = tempFile,
                            UseShellExecute = true
                        });
                    }
                    else
                    {
                        MessageBox.Show("Nie udało się pobrać faktury.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Błąd podczas otwierania faktury:\n" + ex.Message);
                }
            }
        }

        // DTOs
        private class UserDto
        {
            public string Login { get; set; }
            public string Imie { get; set; }
            public string Nazwisko { get; set; }
            public string Email { get; set; }
            public string Telefon { get; set; }
            public string NazwaUslugi { get; set; }
        }

        private class FakturaDto
        {
            public int IdFaktura { get; set; }
            public string NrFaktury { get; set; }
            public string ImieNazwiskoKlienta { get; set; }
            public DateTime DataFaktury { get; set; }
            public decimal? Kwota { get; set; }
            public string Status => IdFaktura > 0 ? "✔ Wygenerowana" : "✖ Brak";
        }

        private class TicketDto
        {
            public int Id { get; set; }
            public string Login { get; set; }
            public string Opis { get; set; }
            public string Status { get; set; }
        }

        
        private void textBox1_TextChanged(object sender, EventArgs e) { }
        private void textBox2_TextChanged(object sender, EventArgs e) { }
        private void textBox3_TextChanged(object sender, EventArgs e) { }
        private void textBox4_TextChanged(object sender, EventArgs e) { }
        private void listauserow_Click(object sender, EventArgs e) { }
        private void label1_Click(object sender, EventArgs e) { }
        private void panele_Click(object sender, EventArgs e) { }
        private void materialLabel1_Click(object sender, EventArgs e) { }
        private void label4_Click(object sender, EventArgs e) { }
        private void label5_Click(object sender, EventArgs e) { }
        private void label3_Click(object sender, EventArgs e) { }
        private void label1_Click_1(object sender, EventArgs e) { }
        private void label2_Click(object sender, EventArgs e) { }
        private void label3_Click_1(object sender, EventArgs e) { }
        private void label4_Click_1(object sender, EventArgs e) { }
        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e) { }
    }
}
