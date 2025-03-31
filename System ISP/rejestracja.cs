using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace System_ISP
{
    public partial class rejestracja : BaseForm
    {
        public rejestracja()
        {
            InitializeComponent();
            EnableDrag(panel1);
            comboBox1.Items.Clear();
            comboBox1.Items.Add("— Wybierz rolę —");
            comboBox1.Items.Add("Admin");
            comboBox1.Items.Add("Konsultant");
            comboBox1.Items.Add("Serwisant");
            comboBox1.Items.Add("Ksiegowy");
            comboBox1.Items.Add("Klient");
            comboBox1.SelectedIndex = 0;
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
            string imie = namebox.Text.Trim();
            string nazwisko = surnamebox.Text.Trim();
            string mail = emailbox.Text.Trim();
            string tel = telefonbox.Text.Trim();

            if (string.IsNullOrEmpty(rola) || rola == "— Wybierz rolę —"
                || string.IsNullOrEmpty(login) || string.IsNullOrEmpty(haslo)
                || string.IsNullOrEmpty(imie) || string.IsNullOrEmpty(nazwisko)
                || string.IsNullOrEmpty(mail) || string.IsNullOrEmpty(tel))
            {
                MessageBox.Show("Uzupełnij wszystkie pola!");
                return;
            }

            SqlConnection conn = DBConnection.GetConnection();

            try
            {
                if (conn.State != ConnectionState.Open)
                    conn.Open();

                // 1. Sprawdź, czy login już istnieje
                string checkLogin = "SELECT COUNT(*) FROM dbo.Klient WHERE login = @login " +
                                    "UNION ALL " +
                                    "SELECT COUNT(*) FROM dbo.Pracownik WHERE login = @login";

                using (SqlCommand checkCmd = new SqlCommand(checkLogin, conn))
                {
                    checkCmd.Parameters.AddWithValue("@login", login);
                    int totalMatches = 0;

                    using (SqlDataReader reader = checkCmd.ExecuteReader())
                    {
                        while (reader.Read())
                            totalMatches += reader.GetInt32(0);
                    }

                    if (totalMatches > 0)
                    {
                        MessageBox.Show("⚠️ Login już istnieje.");
                        return;
                    }
                }

                // 2. Wstawianie do odpowiedniej tabeli
                string query;

                if (rola.ToLower() == "klient") // dodaj do Klient
                {
                    query = "INSERT INTO dbo.Klient (login, pass, rola, Imie, Nazwisko, Email, Telefon) " +
                            "VALUES (@login, @haslo, @rola, @imie, @nazwisko, @email, @telefon)";
                }
                else // dodaj do Pracownik
                {
                    query = "INSERT INTO dbo.Pracownik (login, pass, rola, imię, nazwisko, email, telefon) " +
                            "VALUES (@login, @haslo, @rola, @imie, @nazwisko, @email, @telefon)";
                }

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@login", login);
                    cmd.Parameters.AddWithValue("@haslo", haslo);
                    cmd.Parameters.AddWithValue("@rola", rola);
                    cmd.Parameters.AddWithValue("@imie", imie);
                    cmd.Parameters.AddWithValue("@nazwisko", nazwisko);
                    cmd.Parameters.AddWithValue("@email", mail);
                    cmd.Parameters.AddWithValue("@telefon", tel);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("✅ Użytkownik dodany!");

                    // Czyścimy formularz
                    login_username.Clear();
                    login_pass.Clear();
                    comboBox1.SelectedIndex = 0;
                    namebox.Clear();
                    surnamebox.Clear();
                    emailbox.Clear();
                    telefonbox.Clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("❌ Błąd: " + ex.Message);
            }
            finally
            {
                conn.Close();
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

        private void name_Click(object sender, EventArgs e)
        {

        }

        private void surname_Click(object sender, EventArgs e)
        {

        }

        private void Email_Click(object sender, EventArgs e)
        {

        }

        private void telefon_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
