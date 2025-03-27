namespace System_ISP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
         Application.Exit();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Adminmenu adminMenu = new Adminmenu();

            adminMenu.Show();
            this.Hide();
            //zrobilem prosta logike ze jak klikniesz login to samo przerzuca na menu g³owne do zmiany oczywiscie w pozniejszym czasie
        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
