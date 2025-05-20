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
    public partial class Ksiegowy : Form
    {
        public Ksiegowy()
        {
            InitializeComponent();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void buttonnewfaktura_Click(object sender, EventArgs e)
        //przycisk dodawania nowej faktury

        {
            faktury oknoFaktury = new faktury();
            oknoFaktury.Show();
        }

        private void buttongeneratefaktura_Click(object sender, EventArgs e)
        //przycisk generowania faktury
        {

        }

        private void glowna_nazwa_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        //lista fakur do generowania
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        //lista faktur do generowania
        {

        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        //lista faktur do wysylki
        {

        }

        private void sendfaktura_Click(object sender, EventArgs e)
        //przycisk wysylania faktury
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        //przycisk wyjscia
        {
            Application.Exit();
        }

        private void refresh_Click(object sender, EventArgs e)
        //przycisk odswiezania trzeba ogarnac tabelki i dopisac dopiero odswiezanie
        {

        }

        private void logout_Click(object sender, EventArgs e)
        //przycisk wylogowania
        {
            Form1 loginForm = new Form1();
            loginForm.Show();
            this.Close();
        }

        private void panele_Click(object sender, EventArgs e)
        {

        }
    }
}
