using Microsoft.Data.SqlClient;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace System_ISP
{
    public partial class usuwanieuser : BaseForm
    {
        public usuwanieuser()
        {
            InitializeComponent();
            EnableDrag(panel1);
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            string selectedItem = uzytkownicy.SelectedItem?.ToString();

            if (string.IsNullOrEmpty(selectedItem) || selectedItem == "— Wybierz użytkownika —")
            {
                MessageBox.Show("⚠️ Wybierz użytkownika do usunięcia.");
                return;
            }

            // Wyciągnięcie loginu z tekstu w formacie: "Jan Kowalski (jkowalski)"
            int startIndex = selectedItem.LastIndexOf('(');
            int endIndex = selectedItem.LastIndexOf(')');

            if (startIndex == -1 || endIndex == -1 || endIndex <= startIndex)
            {
                MessageBox.Show("❌ Nieprawidłowy format danych użytkownika.");
                return;
            }

            string login = selectedItem.Substring(startIndex + 1, endIndex - startIndex - 1);

            try
            {
                SqlConnection conn = DBConnection.GetConnection();
                conn.Open();

                // Najpierw sprawdź, czy użytkownik istnieje w tabeli Klient
                string checkClient = "SELECT COUNT(*) FROM dbo.Klient WHERE login = @login";
                using (SqlCommand cmd = new SqlCommand(checkClient, conn))
                {
                    cmd.Parameters.AddWithValue("@login", login);
                    int count = (int)cmd.ExecuteScalar();

                    string deleteQuery;
                    if (count > 0)
                    {
                        deleteQuery = "DELETE FROM dbo.Klient WHERE login = @login";
                    }
                    else
                    {
                        deleteQuery = "DELETE FROM dbo.Pracownik WHERE login = @login";
                    }

                    using (SqlCommand deleteCmd = new SqlCommand(deleteQuery, conn))
                    {
                        deleteCmd.Parameters.AddWithValue("@login", login);
                        int affectedRows = deleteCmd.ExecuteNonQuery();

                        if (affectedRows > 0)
                        {
                            MessageBox.Show("✅ Użytkownik został usunięty.");
                            uzytkownicy.Items.Remove(selectedItem);
                        }
                        else
                        {
                            MessageBox.Show("❌ Użytkownik nie został znaleziony.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("❌ Błąd podczas usuwania:\n" + ex.Message);
            }
        }

        private void uzytkownicy_SelectedIndexChanged(object sender, EventArgs e)
        {
            // nieużywane, ale zostawione dla designer'a
        }

        private void usuwanieuser_Load(object sender, EventArgs e)
        {
            try
            {
                uzytkownicy.Items.Clear();
                uzytkownicy.Items.Add("— Wybierz użytkownika —");
                uzytkownicy.SelectedIndex = 0;

                using (SqlConnection conn = DBConnection.GetConnection())
                {
                    conn.Open();

                    // Klienci
                    string klientQuery = "SELECT Imie, Nazwisko, login, rola FROM dbo.Klient";
                    using (SqlCommand cmd = new SqlCommand(klientQuery, conn))
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string imie = reader["Imie"].ToString();
                            string nazwisko = reader["Nazwisko"].ToString();
                            string login = reader["login"].ToString();
                            string rola = reader["rola"].ToString();
                            uzytkownicy.Items.Add($"{imie} {nazwisko} ({login}) [{rola}]");
                        }
                    }

                    // Pracownicy
                    string pracownikQuery = "SELECT imię, nazwisko, login, rola FROM dbo.Pracownik";
                    using (SqlCommand cmd = new SqlCommand(pracownikQuery, conn))
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string imie = reader["imię"].ToString();
                            string nazwisko = reader["nazwisko"].ToString();
                            string login = reader["login"].ToString();
                            string rola = reader["rola"].ToString();
                            uzytkownicy.Items.Add($"{imie} {nazwisko} ({login}) [{rola}]");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("❌ Błąd podczas ładowania użytkowników:\n" + ex.Message);
            }
        }




        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
