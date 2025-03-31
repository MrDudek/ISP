using System.Data;
using Microsoft.Data.SqlClient;
namespace System_ISP
{
    public partial class Form1 : BaseForm
    {
        public Form1()
        {
            InitializeComponent();
            login_pass.UseSystemPasswordChar = true;
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

        private void button_login_Click(object sender, EventArgs e)
        {
            string username = login_username.Text.Trim();
            string password = login_pass.Text.Trim();

            SqlConnection connection = DBConnection.GetConnection();

            try
            {
                if (connection.State != ConnectionState.Open)
                    connection.Open();

                string rola = null;
                string imie = null;

                // 1. Spróbuj znaleźć użytkownika w tabeli Klient
                string klientQuery = "SELECT rola, Imie FROM dbo.Klient WHERE login = @username AND pass = @password";
                using (SqlCommand cmd = new SqlCommand(klientQuery, connection))
                {
                    cmd.Parameters.AddWithValue("@username", username);
                    cmd.Parameters.AddWithValue("@password", password);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            rola = reader["rola"].ToString().Trim().ToLower();
                            imie = reader["Imie"].ToString().Trim();
                        }
                    }
                }

                // 2. Jeśli nie znaleziono w Klient, szukaj w Pracownik
                if (rola == null)
                {
                    string pracownikQuery = "SELECT rola, imię FROM dbo.Pracownik WHERE login = @username AND pass = @password";
                    using (SqlCommand cmd = new SqlCommand(pracownikQuery, connection))
                    {
                        cmd.Parameters.AddWithValue("@username", username);
                        cmd.Parameters.AddWithValue("@password", password);

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                rola = reader["rola"].ToString().Trim().ToLower();
                                imie = reader["imię"].ToString().Trim();
                            }
                        }
                    }
                }

                if (rola != null)
                {
                    MessageBox.Show($"✅ Zalogowano jako: {rola}", "Sukces", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    Form nextForm = UserFactory.CreateFormForRole(rola);
                    if (nextForm != null)
                    {
                        nextForm.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("🔒 Rola nieznana. Brak dostępu.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("❌ Logowanie nieudane. Sprawdź login i hasło.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Błąd połączenia z bazą:\n" + ex.Message, "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                connection.Close();
            }
        }


        private void checkBox_showpass_CheckedChanged(object sender, EventArgs e)
        {
            // Jeżeli checkbox zaznaczony ma pokazywac haslo
            if (checkBox_showpass.Checked)
            {
                login_pass.UseSystemPasswordChar = false;
            }
            else
            {
                login_pass.UseSystemPasswordChar = true;
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}