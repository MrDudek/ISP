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
    public partial class user : BaseForm
    {
        public user()
        {
            InitializeComponent();
        }

        private void listauserow_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        // pole do wyswietlenia nazwy uzytkownika
        {

        }

        private void panele_Click(object sender, EventArgs e)
        {

        }

        private void materialLabel1_Click(object sender, EventArgs e)
        // 
        {

        }

        private void label4_Click(object sender, EventArgs e)
        // tu bedzie wyswietlany email
        {

        }

        private void label5_Click(object sender, EventArgs e)
        // tu bedzie wyswietlana taryfa
        {

        }

        private void label3_Click(object sender, EventArgs e)
        //tu bedzie wyswietlany email
        {

        }

        private void ksiegowybutton_Click(object sender, EventArgs e)
        //przycisk do pobrania i otworzenia pdf
        {

        }

        private void materialButton1_Click(object sender, EventArgs e)
        //przycisk do dodania zgłoszenia
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
    }
}
