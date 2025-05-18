using System.Data;
using System.Text.Json;
using System.Text;
using Microsoft.Data.SqlClient;
namespace System_ISP
{
    public partial class Form1 : BaseForm
    {
        public Form1()
        {
            InitializeComponent();
            passbox.PasswordChar = '●';
            EnableDrag(panel1);
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label2_Click(object sender, EventArgs e)
        {

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

        private void login_pass_TextChanged(object sender, EventArgs e)
        {

        }

        private async void button_login_Click(object sender, EventArgs e)
        {

        }


        private void checkBox_showpass_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void mainname_Click(object sender, EventArgs e)
        //głowna nazwa programu
        {

        }

        private void Login_Click(object sender, EventArgs e)
        //miejsce do wpisywania loginu
        {
           
        }

        private void loginbutton_Click(object sender, EventArgs e)
        //przycisk logowania
        {
            string username = Login.Text.Trim();
            string password = passbox.Text.Trim();

            if (username == "admin" && password == "1234")
            {
                MessageBox.Show("✅ Zalogowano jako administrator!", "Sukces", MessageBoxButtons.OK, MessageBoxIcon.Information);

                Adminmenu panelAdministratora = new Adminmenu();
                panelAdministratora.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("❌ Nieprawidłowy login lub hasło.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void materialTextBox21_Click(object sender, EventArgs e)
        //miejsce do wpisywania hasła
        {

        }

        private void loginname_Click(object sender, EventArgs e)
        //nazwa login
        {

        }

        private void passname_Click(object sender, EventArgs e)
        //nazwa hasła
        {

        }

        private void nametekst_Click(object sender, EventArgs e)
        //podpowiedz
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void showpasssss_CheckedChanged(object sender, EventArgs e)
        //pokazuje hasło
        {
            passbox.PasswordChar = showpasssss.Checked ? '\0' : '●';
        }
    }
}
