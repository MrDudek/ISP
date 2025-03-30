using System.Data.SqlClient;
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
    public partial class rejestracja : BaseForm
    {
        public rejestracja()
        {
            InitializeComponent();
            EnableDrag(panel1);
        }

        private void nazwa_Click(object sender, EventArgs e)
        {

        }

        private void login_pass_TextChanged(object sender, EventArgs e)
        {

        }

        private void button_login_Click(object sender, EventArgs e)
        {
            string login = login_username.Text.Trim();
            string haslo = login_pass.Text.Trim();
            string rola = comboBox1.SelectedItem?.ToString();

            if (string.IsNullOrEmpty(login) || string.IsNullOrEmpty(haslo) || string.IsNullOrEmpty(rola))
            {
                MessageBox.Show("Uzupełnij wszystkie pola!");
                return;
            }

            string connectionString = "Server=194.92.64.24,12145;Database=IOpsk;User Id=mirek;Password=ZAQ!2wsx;TrustServerCertificate=True;";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    string query = "INSERT INTO dbo.Klient (login, pass, rola) VALUES (@login, @haslo, @rola)";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@login", login);
                        cmd.Parameters.AddWithValue("@haslo", haslo);
                        cmd.Parameters.AddWithValue("@rola", rola);

                        cmd.ExecuteNonQuery();
                        MessageBox.Show("✅ Użytkownik dodany!");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("❌ Błąd: " + ex.Message);
                }
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void exit_Click(object sender, EventArgs e)
        {
        this.Close();   
        }
    }
}
