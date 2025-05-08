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

        private async void button_login_Click(object sender, EventArgs e)
        {
            string username = login_username.Text.Trim();
            string password = login_pass.Text.Trim();

            using (HttpClient client = new HttpClient())
            {
                try
                {
                    var loginData = new
                    {
                        username = username,
                        password = password
                    };

                    string json = JsonSerializer.Serialize(loginData);
                    var content = new StringContent(json, Encoding.UTF8, "application/json");

                    // ❗ ZMIEŃ NA ADRES SWOJEGO BACKENDU (np. publiczny IP lub localhost)
                    string apiUrl = "http://194.92.64.24:";

                    HttpResponseMessage response = await client.PostAsync(apiUrl, content);

                    if (response.IsSuccessStatusCode)
                    {
                        string result = await response.Content.ReadAsStringAsync();
                        var responseData = JsonDocument.Parse(result).RootElement;

                        string rola = responseData.GetProperty("role").GetString();
                        string imie = responseData.GetProperty("name").GetString();

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
                    else if (response.StatusCode == System.Net.HttpStatusCode.Unauthorized)
                    {
                        MessageBox.Show("❌ Logowanie nieudane. Sprawdź login i hasło.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        MessageBox.Show("❌ Wystąpił błąd po stronie API.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Błąd połączenia z API:\n" + ex.Message, "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}