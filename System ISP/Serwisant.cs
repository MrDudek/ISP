using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace System_ISP
{
    public partial class Serwisant : BaseForm
    {
        public Serwisant()
        {
            InitializeComponent();
            EnableDrag(panel1);
            polestatusu.Items.Clear();
            polestatusu.Items.Add("— Wybierz status zgłoszenia —");
            polestatusu.Items.Add("Otwarte");
            polestatusu.Items.Add("W trakcie");
            polestatusu.Items.Add("Zamknięte");
            polestatusu.Items.Add("Oczekujące");
            polestatusu.Items.Add("Anulowane");
            polestatusu.SelectedIndex = 0;

        }

        private void tekst_Click(object sender, EventArgs e)
        {

        }

        private void listauserow_Click(object sender, EventArgs e)
        //lista zgloszen sam napis

        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        //tutaj bedzie wyswietlana lista zgloszen
        // pasuje dac tak ID zgloszenia tytul/temat moze jakis status data zgloszenia
        {

        }

        private void refresh_Click(object sender, EventArgs e)
        //odswiezanie listy zgloszen ale trzeba najpierw zrobic logike
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void szczegoly_Click(object sender, EventArgs e)
        //zwykle info co to jest nic szczegolnego poza tekstem
        {

        }

        private void tresczgloszenia_TextChanged(object sender, EventArgs e)
        //tutaj bedzie wyswietlana tresc zgloszenia
        {

        }

        private void save_Click(object sender, EventArgs e)
        //przycisk zapisz zmiany

        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        //pole do danych klienta

        {

        }

        private void polestatusu_SelectedIndexChanged(object sender, EventArgs e)
        //wybierz status zgloszenia do wyboru np. otwarte, zamkniete, w trakcie
        {

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

        private void materialButton1_Click(object sender, EventArgs e)
        {

        }
    }
}
