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
            string imie = textBox_imie.Text.Trim();
            string nazwisko = textBox_nazwisko.Text.Trim();
            string email = textBox_email.Text.Trim();
            string telefon = textBox_telefon.Text.Trim();

            // Sprawdzenie, czy wszystkie pola są wypełnione
            if (string.IsNullOrEmpty(login) || string.IsNullOrEmpty(haslo) || string.IsNullOrEmpty(rola)
                || string.IsNullOrEmpty(imie) || string.IsNullOrEmpty(nazwisko)
                || string.IsNullOrEmpty(email) || string.IsNullOrEmpty(telefon))
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

                    string query = "INSERT INTO dbo.Klient (login, pass, rola, Imie, Nazwisko, Email, Telefon) " +
                                   "VALUES (@login, @haslo, @rola, @imie, @nazwisko, @email, @telefon)";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@login", login);
                        cmd.Parameters.AddWithValue("@haslo", haslo);
                        cmd.Parameters.AddWithValue("@rola", rola);
                        cmd.Parameters.AddWithValue("@imie", imie);
                        cmd.Parameters.AddWithValue("@nazwisko", nazwisko);
                        cmd.Parameters.AddWithValue("@email", email);
                        cmd.Parameters.AddWithValue("@telefon", telefon);

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

        private void login_username_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
