using Microsoft.Data.SqlClient;
using Microsoft.VisualBasic.Logging;
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
    public partial class Adminmenu : BaseForm
    {
        
        public Adminmenu()
        {
            InitializeComponent();
            EnableDrag(panel1);
            WczytajUzytkownikow();

            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void data_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Ksiegowy_Click(object sender, EventArgs e)
        {
            Ksiegowy ksiegowyForm = new Ksiegowy();
            ksiegowyForm.Show();
            this.Hide();
        }

        private void Adminmenu_Load(object sender, EventArgs e)
        {

        }

        private void Home_Click(object sender, EventArgs e)
        {


        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void logout_Click(object sender, EventArgs e)
        {
            Form1 loginForm = new Form1();
            loginForm.Show();
            this.Close();
        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }
       

        private void refresh_Click(object sender, EventArgs e)
        {
            WczytajUzytkownikow();
        }

        private void Rejestracja_Click(object sender, EventArgs e)
        {
            rejestracja rejestracjaOkno = new rejestracja();
            rejestracjaOkno.Show();
        }

        private void Serwisant_Click(object sender, EventArgs e)
        {
            Serwisant serwisantForm = new Serwisant();
            serwisantForm.Show();
            this.Hide();
        }

        private void Konsultant_Click(object sender, EventArgs e)
        {
            Konsultant konsultantForm = new Konsultant();
            konsultantForm.Show();
            this.Hide();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            usuwanieuser oknoUsuwania = new usuwanieuser();
            oknoUsuwania.Show();
        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }
      

        private void listapracownikowtabela_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void WczytajUzytkownikow()
        {
            SqlConnection conn = DBConnection.GetConnection();

            try
            {
                if (conn.State != ConnectionState.Open)
                    conn.Open();

                // Pobierz klientów
                string queryKlient = "SELECT Imie, Nazwisko, Wiek, Email, Telefon, login, pass, rola FROM dbo.Klient";
                SqlDataAdapter adapterKlient = new SqlDataAdapter(queryKlient, conn);
                DataTable dtKlient = new DataTable();
                adapterKlient.Fill(dtKlient);
                dataGridView1.DataSource = dtKlient;

                // Pobierz pracowników
                string queryPracownik = "SELECT imię, nazwisko, wiek, email, telefon, login, pass, rola FROM dbo.Pracownik";
                SqlDataAdapter adapterPracownik = new SqlDataAdapter(queryPracownik, conn);
                DataTable dtPracownik = new DataTable();
                adapterPracownik.Fill(dtPracownik);
                listapracownikowtabela.DataSource = dtPracownik;
            }
            catch (Exception ex)
            {
                MessageBox.Show("❌ Błąd ładowania danych:\n" + ex.Message);
            }
            finally
            {
                conn.Close(); // zamknij połączenie, bo to singleton
            }
        }
    }
}
