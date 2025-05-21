using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace System_ISP
{
    public partial class rejestracja : BaseForm
    {
        // Klasa modelu wewnątrz tej samej klasy (jeśli nie masz osobnego pliku)
        private class Usluga
        {
            public int Id { get; set; }
            public string Nazwa { get; set; }

            public override string ToString()
            {
                return Nazwa;
            }
        }

        public rejestracja()
        {
            InitializeComponent();
            EnableDrag(panel1);
            SetupRoleComboBox();
            SetupUslugiComboBox();
        }

        private void SetupRoleComboBox()
        {
            comboBox1.Items.Clear();
            comboBox1.Items.Add("— Wybierz rolę —");
            comboBox1.Items.Add("Admin");
            comboBox1.Items.Add("Konsultant");
            comboBox1.Items.Add("Serwisant");
            comboBox1.Items.Add("Ksiegowy");
            comboBox1.Items.Add("Klient");
            comboBox1.SelectedIndex = 0;
        }

        private void SetupUslugiComboBox()
        {
            comboBox2.Items.Clear();
            comboBox2.Items.Add(new Usluga { Id = 0, Nazwa = "-- Wybierz usługę --" });
            comboBox2.Items.Add(new Usluga { Id = 1, Nazwa = "Internet 100Mb - Standard" });
            comboBox2.Items.Add(new Usluga { Id = 2, Nazwa = "Internet 300Mb - Premium" });
            comboBox2.SelectedIndex = 0;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e) { }
        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e) { }

        private void materialButton1_Click(object sender, EventArgs e)
        {
            string login = Login.Text.Trim();
            string haslo = materialTextBox21.Text.Trim();
            string imie = materialTextBox22.Text.Trim();
            string nazwisko = materialTextBox23.Text.Trim();
            string mail = materialTextBox24.Text.Trim();
            string tel = materialTextBox25.Text.Trim();
            string rola = comboBox1.SelectedItem?.ToString();
            Usluga usluga = comboBox2.SelectedItem as Usluga;

            if (string.IsNullOrEmpty(rola) || rola == "— Wybierz rolę —"
                || string.IsNullOrEmpty(login) || string.IsNullOrEmpty(haslo)
                || string.IsNullOrEmpty(imie) || string.IsNullOrEmpty(nazwisko)
                || string.IsNullOrEmpty(mail) || string.IsNullOrEmpty(tel)
                || usluga == null || usluga.Id == 0)
            {
                MessageBox.Show("Uzupełnij wszystkie pola!");
                return;
            }

            SqlConnection conn = DBConnection.GetConnection();

            try
            {
                if (conn.State != ConnectionState.Open)
                    conn.Open();

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

                string query;

                if (rola.ToLower() == "klient")
                {
                    query = "INSERT INTO dbo.Klient (login, pass, rola, Imie, Nazwisko, Email, Telefon, idUsluga) " +
                            "VALUES (@login, @haslo, @rola, @imie, @nazwisko, @email, @telefon, @idUsluga)";
                }
                else
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

                    if (rola.ToLower() == "klient")
                        cmd.Parameters.AddWithValue("@idUsluga", usluga.Id);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("✅ Użytkownik dodany!");

                    Login.Clear();
                    materialTextBox21.Clear();
                    materialTextBox22.Clear();
                    materialTextBox23.Clear();
                    materialTextBox24.Clear();
                    materialTextBox25.Clear();
                    comboBox1.SelectedIndex = 0;
                    comboBox2.SelectedIndex = 0;
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

        // Pozostałe puste eventy (zostawiłem jak miałeś):
        private void nazwa_Click(object sender, EventArgs e) { }
        private void login_pass_TextChanged(object sender, EventArgs e) { }
        private void button_login_Click(object sender, EventArgs e) { }
        private void exit_Click(object sender, EventArgs e) { this.Close(); }
        private void login_username_TextChanged(object sender, EventArgs e) { }
        private void name_Click(object sender, EventArgs e) { }
        private void surname_Click(object sender, EventArgs e) { }
        private void Email_Click(object sender, EventArgs e) { }
        private void telefon_Click(object sender, EventArgs e) { }
        private void textBox1_TextChanged(object sender, EventArgs e) { }
        private void textBox2_TextChanged(object sender, EventArgs e) { }
        private void textBox3_TextChanged(object sender, EventArgs e) { }
        private void textBox4_TextChanged(object sender, EventArgs e) { }
        private void nametekst_Click(object sender, EventArgs e) { }
        private void Login_Click(object sender, EventArgs e) { }
        private void materialTextBox21_Click(object sender, EventArgs e) { }
        private void materialTextBox22_Click(object sender, EventArgs e) { }
        private void materialTextBox23_Click(object sender, EventArgs e) { }
        private void materialTextBox24_Click(object sender, EventArgs e) { }
        private void materialTextBox25_Click(object sender, EventArgs e) { }
    }
}
