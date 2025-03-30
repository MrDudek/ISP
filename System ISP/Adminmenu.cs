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
    public partial class Adminmenu : BaseForm
    {
        public Adminmenu()
        {
            InitializeComponent();
            EnableDrag(panel1);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void data_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Ksiegowy_Click(object sender, EventArgs e)
        {

        }

        private void Adminmenu_Load(object sender, EventArgs e)
        {

        }

        private void Home_Click(object sender, EventArgs e)
        {


        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void logout_Click(object sender, EventArgs e)
        {
            Form1 loginForm = new Form1();
            loginForm.Show();
            this.Close();
        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
          
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
