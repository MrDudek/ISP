using System;
using System.Windows.Forms;
using System.Globalization;

namespace System_ISP
{
    public partial class NowaFakturaForm : Form
    {
        public NowaFakturaForm()
        {
            InitializeComponent();
            InitFormData();
        }

        private void InitFormData()
        {
            comboKlient.Items.AddRange(new object[]
            {
                "-- Wybierz klienta --",
                "Jan Kowalski",
                "Anna Nowak",
                "Testowy Klient"
            });
            comboKlient.SelectedIndex = 0;
            dtDataWystawienia.Value = DateTime.Now;
            dtTerminPlatnosci.Value = DateTime.Now.AddDays(14);
        }

        private void btnDodajPozycje_Click(object sender, EventArgs e)
        {
            dgvPozycje.Rows.Add("", 1, "0.00", "23%", "0.00");
        }

        private void btnZapisz_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNumer.Text))
            {
                MessageBox.Show("Numer faktury jest wymagany.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (comboKlient.SelectedIndex == 0)
            {
                MessageBox.Show("Wybierz klienta.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (dgvPozycje.Rows.Count == 0 || dgvPozycje.Rows[0].IsNewRow)
            {
                MessageBox.Show("Dodaj przynajmniej jedną pozycję do faktury.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string fakturaNumer = txtNumer.Text.Trim();
            string klient = comboKlient.SelectedItem.ToString();
            DateTime dataWystawienia = dtDataWystawienia.Value;
            DateTime terminPlatnosci = dtTerminPlatnosci.Value;
            string opis = txtOpis.Text.Trim();

            string podsumowanie = $"Numer: {fakturaNumer}\nKlient: {klient}\nData: {dataWystawienia:yyyy-MM-dd}\nTermin: {terminPlatnosci:yyyy-MM-dd}\n\nPozycje:\n";

            foreach (DataGridViewRow row in dgvPozycje.Rows)
            {
                if (row.IsNewRow) continue;
                string nazwa = row.Cells["Nazwa"].Value?.ToString() ?? "";
                string ilosc = row.Cells["Ilość"].Value?.ToString() ?? "";
                string netto = row.Cells["Cena netto"].Value?.ToString() ?? "";
                string vat = row.Cells["VAT"].Value?.ToString() ?? "";
                string brutto = row.Cells["Cena brutto"].Value?.ToString() ?? "";

                podsumowanie += $"- {nazwa}, Ilość: {ilosc}, Netto: {netto}, VAT: {vat}, Brutto: {brutto}\n";
            }

            MessageBox.Show(podsumowanie, "Podsumowanie faktury", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // TODO: tutaj można dodać zapisywanie do bazy danych (Faktura + PozycjeFaktury)

            this.Close();
        }

        private void txtNumer_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgvPozycje_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtNumer_TextChanged_1(object sender, EventArgs e)
            //nazwa faktury
        {

        }
    }
}