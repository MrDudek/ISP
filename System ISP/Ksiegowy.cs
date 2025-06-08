using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace System_ISP
{
    public partial class Ksiegowy : BaseForm
    {
        public Ksiegowy()
        {
            InitializeComponent();
            Load += Ksiegowy_Load;
        }

        private async void Ksiegowy_Load(object sender, EventArgs e)
        {
            await ZaladujFaktury();
        }

        private async void refresh_Click(object sender, EventArgs e)
        {
            await ZaladujFaktury();
        }

        private async Task ZaladujFaktury()
        {
            try
            {
                using var client = new HttpClient();
                var res = await client.GetAsync("http://localhost:5180/api/Faktura/Invoiceslist");

                if (res.IsSuccessStatusCode)
                {
                    var json = await res.Content.ReadAsStringAsync();
                    var faktury = JsonSerializer.Deserialize<List<FakturaDto>>(json, new JsonSerializerOptions
                    {
                        PropertyNameCaseInsensitive = true
                    });

                    var fakturyBezNulli = faktury?
                        .Where(f => f != null && f.IdFaktura != 0 && f.NrFaktury != null)
                        .ToList() ?? new List<FakturaDto>();

                    dataGridView1.DataSource = fakturyBezNulli;

                    
                    if (dataGridView1.Columns.Contains("PlikFaktury"))
                        dataGridView1.Columns["PlikFaktury"].Visible = false;

                    
                    if (dataGridView1.Columns.Contains("Status"))
                        dataGridView1.Columns["Status"].HeaderText = "Status PDF";
                }
                else
                {
                    MessageBox.Show("❌ Nie udało się pobrać faktur.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("❌ Błąd sieci: " + ex.Message);
            }
        }


        private void sendfaktura_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Wybierz fakturę do wysłania.");
                return;
            }

            var selected = dataGridView1.SelectedRows[0].DataBoundItem as FakturaDto;
            if (selected == null || selected.PlikFaktury == null || selected.PlikFaktury.Length == 0)
            {
                MessageBox.Show("Faktura nie posiada wygenerowanego pliku PDF.");
                return;
            }

            string tempPath = Path.Combine(Path.GetTempPath(), $"faktura_{selected.IdFaktura}.pdf");
            File.WriteAllBytes(tempPath, selected.PlikFaktury);

            var gmailUrl = "https://mail.google.com/mail/?view=cm&fs=1" +
                           "&to=" +
                           "&su=" + Uri.EscapeDataString("Faktura") +
                           "&body=" + Uri.EscapeDataString("W załączeniu znajduje się faktura.\nProszę o jej przesłanie do księgowości.");

            System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo
            {
                FileName = gmailUrl,
                UseShellExecute = true
            });

            System.Diagnostics.Process.Start("explorer.exe", $"/select,\"{tempPath}\"");
        }

        private void buttonnewfaktura_Click(object sender, EventArgs e)
        {
            faktury oknoFaktury = new faktury();
            oknoFaktury.Show();
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

        // Puste zdarzenia
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e) { }
        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e) { }
        private void panel3_Paint(object sender, PaintEventArgs e) { }
        private void buttongeneratefaktura_Click(object sender, EventArgs e) { }
        private void glowna_nazwa_Click(object sender, EventArgs e) { }
        private void label1_Click(object sender, EventArgs e) { }
        private void label3_Click(object sender, EventArgs e) { }
        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e) { }
        private void panele_Click(object sender, EventArgs e) { }
    }

    // DTO do obsługi frontu z dodatkowym polem Status
    public class FakturaDto
    {
        public int IdFaktura { get; set; }
        public string NrFaktury { get; set; }
        public DateTime DataFaktury { get; set; }
        public DateTime? TerminPlatnosci { get; set; }
        public decimal? Kwota { get; set; }
        public string ImieNazwiskoKlienta { get; set; }
        public byte[] PlikFaktury { get; set; }

        public string Status => (PlikFaktury != null && PlikFaktury.Length > 0)
            ? "✔ Wygenerowana"
            : "✖ Brak pliku";
    }
}
