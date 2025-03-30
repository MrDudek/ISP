using System.Data.SqlClient;
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

            string connectionString = "Server=194.92.64.24,12145;Database=IOpsk;User Id=mirek;Password=ZAQ!2wsx;TrustServerCertificate=False;";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    string query = "SELECT rola FROM dbo.klient WHERE login = @username AND pass = @password";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@username", username);
                        command.Parameters.AddWithValue("@password", password);

                        object result = command.ExecuteScalar();

                        if (result != null)
                        {
                            string rola = result.ToString().Trim().ToLower();
                            MessageBox.Show($"✅ Zalogowano jako: {rola}", "Sukces", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            // Przekierowanie na odpowiednie okno:
                            switch (rola.ToLower())
                            {
                                case "admin":
                                    new Adminmenu().Show();
                                    break;
                                case "serwisant":
                                    new Serwisant().Show();
                                    break;
                                case "konsultant":
                                    new Konsultant().Show();
                                    break;
                                case "ksiegowy":
                                    new Ksiegowy().Show();
                                    break;
                                case "user":
                                    new user().Show(); 
                                    break;
                                default:
                                    MessageBox.Show("🔒 Rola nieznana. Brak dostępu.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                    return;
                            }

                            this.Hide(); // ukryj formularz logowania
                        }
                        else
                        {
                            MessageBox.Show("❌ Logowanie nieudane. Sprawdź login i hasło.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Błąd połączenia z bazą danych:\n" + ex.Message, "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
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
    }
}
