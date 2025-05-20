using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace System_ISP
{
    public partial class faktury : BaseForm
    {
        public faktury()
        {
            InitializeComponent();

            // Inicjalizacja VAT
            comboBox3.Items.Clear();
            comboBox3.Items.Add("— Wybierz VAT —");
            comboBox3.Items.Add("23%");
            comboBox3.Items.Add("8%");
            comboBox3.SelectedIndex = 0;

            // Cena brutto tylko do odczytu
            textBox3.ReadOnly = true;

            // Obsługa zdarzeń
            comboBox3.SelectedIndexChanged += comboBox3_SelectedIndexChanged;
            textBox2.TextChanged += textBox2_TextChanged;
        }

        private void materialLabel2_Click(object sender, EventArgs e)
        {

        }

        private void materialButton1_Click(object sender, EventArgs e)
        //przycisk do dodawania nowej faktury
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        // pole wyboru użytkownika z bazy combobox
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        // pole do wpisania numeru faktury vat
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        // combobox wyboru usługi
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        // pole do wpisania ceny netto
        {
            PrzeliczBrutto();
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        // combobox wybor vatu np 23 % lub 8%
        {
            PrzeliczBrutto();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        // pole ceny brutto i opcja tylko do odczytu
        {
            textBox3.ReadOnly = true;
        }

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

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
