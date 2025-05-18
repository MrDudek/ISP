namespace System_ISP
{
    partial class NowaFakturaForm
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.TextBox txtNumer;
        private System.Windows.Forms.ComboBox comboKlient;
        private System.Windows.Forms.DateTimePicker dtDataWystawienia;
        private System.Windows.Forms.DateTimePicker dtTerminPlatnosci;
        private System.Windows.Forms.RichTextBox txtOpis;
        private System.Windows.Forms.DataGridView dgvPozycje;
        private System.Windows.Forms.Button btnDodajPozycje;
        private System.Windows.Forms.Button btnZapisz;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            txtNumer = new TextBox();
            comboKlient = new ComboBox();
            dtDataWystawienia = new DateTimePicker();
            dtTerminPlatnosci = new DateTimePicker();
            txtOpis = new RichTextBox();
            dgvPozycje = new DataGridView();
            btnDodajPozycje = new Button();
            btnZapisz = new Button();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn4 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn5 = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgvPozycje).BeginInit();
            SuspendLayout();
            // 
            // txtNumer
            // 
            txtNumer.Location = new Point(30, 30);
            txtNumer.Name = "txtNumer";
            txtNumer.PlaceholderText = "Numer faktury";
            txtNumer.Size = new Size(200, 23);
            txtNumer.TabIndex = 0;
            txtNumer.TextChanged += txtNumer_TextChanged_1;
            // 
            // comboKlient
            // 
            comboKlient.Location = new Point(30, 70);
            comboKlient.Name = "comboKlient";
            comboKlient.Size = new Size(200, 23);
            comboKlient.TabIndex = 1;
            // 
            // dtDataWystawienia
            // 
            dtDataWystawienia.Location = new Point(30, 110);
            dtDataWystawienia.Name = "dtDataWystawienia";
            dtDataWystawienia.Size = new Size(200, 23);
            dtDataWystawienia.TabIndex = 2;
            // 
            // dtTerminPlatnosci
            // 
            dtTerminPlatnosci.Location = new Point(30, 150);
            dtTerminPlatnosci.Name = "dtTerminPlatnosci";
            dtTerminPlatnosci.Size = new Size(200, 23);
            dtTerminPlatnosci.TabIndex = 3;
            // 
            // txtOpis
            // 
            txtOpis.Location = new Point(30, 190);
            txtOpis.Name = "txtOpis";
            txtOpis.Size = new Size(300, 80);
            txtOpis.TabIndex = 4;
            txtOpis.Text = "";
            // 
            // dgvPozycje
            // 
            dgvPozycje.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, dataGridViewTextBoxColumn2, dataGridViewTextBoxColumn3, dataGridViewTextBoxColumn4, dataGridViewTextBoxColumn5 });
            dgvPozycje.Location = new Point(30, 290);
            dgvPozycje.Name = "dgvPozycje";
            dgvPozycje.Size = new Size(740, 200);
            dgvPozycje.TabIndex = 5;
            dgvPozycje.CellContentClick += dgvPozycje_CellContentClick;
            // 
            // btnDodajPozycje
            // 
            btnDodajPozycje.Location = new Point(30, 500);
            btnDodajPozycje.Name = "btnDodajPozycje";
            btnDodajPozycje.Size = new Size(75, 23);
            btnDodajPozycje.TabIndex = 6;
            btnDodajPozycje.Text = "Dodaj pozycję";
            btnDodajPozycje.Click += btnDodajPozycje_Click;
            // 
            // btnZapisz
            // 
            btnZapisz.Location = new Point(650, 500);
            btnZapisz.Name = "btnZapisz";
            btnZapisz.Size = new Size(75, 23);
            btnZapisz.TabIndex = 7;
            btnZapisz.Text = "Zapisz fakturę";
            btnZapisz.Click += btnZapisz_Click;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // NowaFakturaForm
            // 
            ClientSize = new Size(800, 600);
            Controls.Add(txtNumer);
            Controls.Add(comboKlient);
            Controls.Add(dtDataWystawienia);
            Controls.Add(dtTerminPlatnosci);
            Controls.Add(txtOpis);
            Controls.Add(dgvPozycje);
            Controls.Add(btnDodajPozycje);
            Controls.Add(btnZapisz);
            Name = "NowaFakturaForm";
            Text = "Nowa Faktura";
            ((System.ComponentModel.ISupportInitialize)dgvPozycje).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
    }
}