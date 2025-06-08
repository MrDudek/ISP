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

        private async void loginbutton_Click(object sender, EventArgs e)
        {
            string username = Login.Text.Trim();
            string password = passbox.Text.Trim();

            var client = new HttpClient();
            var requestData = new
            {
                login = username,
                password = password
            };

            var content = new StringContent(JsonSerializer.Serialize(requestData), Encoding.UTF8, "application/json");

            try
            {
                var response = await client.PostAsync("http://localhost:5180/api/Login", content);
                if (response.IsSuccessStatusCode)
                {
                    var responseBody = await response.Content.ReadAsStringAsync();
                    var loginResponse = JsonSerializer.Deserialize<LoginResponse>(responseBody);

                    if (loginResponse != null && loginResponse.success)
                    {
                        //ZAPIS LOGINU I ROLI DO SESJI
                        Session.LoggedInLogin = username;
                        Session.LoggedInRole = loginResponse.role;
                        Session.CurrentLogin = username;

                        MessageBox.Show($"✅ Zalogowano jako {loginResponse.role} ({loginResponse.name})", "Sukces", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        switch (loginResponse.role)
                        {
                            case "Admin":
                                new Adminmenu().Show();
                                break;
                            case "Serwisant":
                                new Serwisant().Show();
                                break;
                            case "Księgowy":
                                new Ksiegowy().Show();
                                break;
                            case "Konsultant":
                                new Konsultant().Show();
                                break;
                            case "Klient":
                                new user().Show(); 
                                break;
                            default:
                                MessageBox.Show("❌ Nieznana rola użytkownika.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                        }

                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("❌ Błędne dane logowania.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("❌ Nieprawidłowa odpowiedź serwera.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"❌ Błąd połączenia z API: {ex.Message}", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void wersjaapp_Click(object sender, EventArgs e)
        //wersja aplikacji dla wygladu
        {

        }
    }
    public class LoginResponse
    {
        public bool success { get; set; }
        public string role { get; set; }
        public string name { get; set; }
    }
}
