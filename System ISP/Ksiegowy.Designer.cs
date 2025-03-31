namespace System_ISP
{
    partial class Ksiegowy
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            listauserow = new Label();
            tabelka = new Panel();
            dataGridView1 = new DataGridView();
            panelP = new Panel();
            panelsrodkowy = new Panel();
            panelL = new Panel();
            toolTip1 = new ToolTip(components);
            logout = new PictureBox();
            Rejestracja = new Button();
            refresh = new PictureBox();
            button1 = new Button();
            Serwisant = new Button();
            panele = new Label();
            Konsultant = new Button();
            panel3 = new Panel();
            panel2 = new Panel();
            pictureBox1 = new PictureBox();
            data = new DateTimePicker();
            glowna_nazwa = new Label();
            panel1 = new Panel();
            tabelka.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)logout).BeginInit();
            ((System.ComponentModel.ISupportInitialize)refresh).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // listauserow
            // 
            listauserow.AutoSize = true;
            listauserow.Font = new Font("Tahoma", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 238);
            listauserow.Location = new Point(15, 15);
            listauserow.Name = "listauserow";
            listauserow.Size = new Size(192, 25);
            listauserow.TabIndex = 0;
            listauserow.Text = "Lista Użytkownikow";
            // 
            // tabelka
            // 
            tabelka.Controls.Add(dataGridView1);
            tabelka.Controls.Add(listauserow);
            tabelka.Location = new Point(322, 355);
            tabelka.Name = "tabelka";
            tabelka.Size = new Size(930, 362);
            tabelka.TabIndex = 10;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(11, 45);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(913, 313);
            dataGridView1.TabIndex = 1;
            // 
            // panelP
            // 
            panelP.Location = new Point(914, 141);
            panelP.Name = "panelP";
            panelP.Size = new Size(253, 190);
            panelP.TabIndex = 11;
            // 
            // panelsrodkowy
            // 
            panelsrodkowy.Location = new Point(619, 141);
            panelsrodkowy.Name = "panelsrodkowy";
            panelsrodkowy.Size = new Size(253, 190);
            panelsrodkowy.TabIndex = 12;
            // 
            // panelL
            // 
            panelL.Location = new Point(343, 141);
            panelL.Name = "panelL";
            panelL.Size = new Size(253, 190);
            panelL.TabIndex = 9;
            // 
            // logout
            // 
            logout.BackColor = Color.Transparent;
            logout.BackgroundImage = Properties.Resources.logout3;
            logout.BackgroundImageLayout = ImageLayout.Stretch;
            logout.Cursor = Cursors.Hand;
            logout.Location = new Point(12, 544);
            logout.Name = "logout";
            logout.Size = new Size(51, 50);
            logout.TabIndex = 4;
            logout.TabStop = false;
            toolTip1.SetToolTip(logout, "Wyloguj z systemu");
            // 
            // Rejestracja
            // 
            Rejestracja.BackColor = Color.DarkTurquoise;
            Rejestracja.BackgroundImageLayout = ImageLayout.None;
            Rejestracja.FlatStyle = FlatStyle.Flat;
            Rejestracja.Font = new Font("Arial Black", 10F, FontStyle.Bold);
            Rejestracja.Location = new Point(12, 457);
            Rejestracja.Name = "Rejestracja";
            Rejestracja.Size = new Size(297, 59);
            Rejestracja.TabIndex = 5;
            Rejestracja.Text = "Rejestracja nowych uzytkownikow";
            Rejestracja.UseVisualStyleBackColor = false;
            // 
            // refresh
            // 
            refresh.BackgroundImage = Properties.Resources.Refresh_icon;
            refresh.BackgroundImageLayout = ImageLayout.Stretch;
            refresh.Location = new Point(256, 544);
            refresh.Name = "refresh";
            refresh.Size = new Size(57, 50);
            refresh.TabIndex = 2;
            refresh.TabStop = false;
            // 
            // button1
            // 
            button1.BackColor = Color.DarkTurquoise;
            button1.BackgroundImageLayout = ImageLayout.None;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Arial Black", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 238);
            button1.Location = new Point(64, 268);
            button1.Name = "button1";
            button1.Size = new Size(194, 59);
            button1.TabIndex = 3;
            button1.Text = "Księgowy";
            button1.UseVisualStyleBackColor = false;
            // 
            // Serwisant
            // 
            Serwisant.BackColor = Color.DarkTurquoise;
            Serwisant.BackgroundImageLayout = ImageLayout.None;
            Serwisant.FlatStyle = FlatStyle.Flat;
            Serwisant.Font = new Font("Arial Black", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 238);
            Serwisant.Location = new Point(64, 168);
            Serwisant.Name = "Serwisant";
            Serwisant.Size = new Size(194, 59);
            Serwisant.TabIndex = 2;
            Serwisant.Text = "Serwisant";
            Serwisant.UseVisualStyleBackColor = false;
            // 
            // panele
            // 
            panele.AutoSize = true;
            panele.Font = new Font("Arial Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 238);
            panele.Location = new Point(12, 18);
            panele.Name = "panele";
            panele.Size = new Size(297, 23);
            panele.TabIndex = 1;
            panele.Text = "Dostępne Panele do zarządzania";
            // 
            // Konsultant
            // 
            Konsultant.BackColor = Color.DarkTurquoise;
            Konsultant.BackgroundImageLayout = ImageLayout.None;
            Konsultant.FlatStyle = FlatStyle.Flat;
            Konsultant.Font = new Font("Arial Black", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 238);
            Konsultant.Location = new Point(64, 76);
            Konsultant.Name = "Konsultant";
            Konsultant.Size = new Size(194, 59);
            Konsultant.TabIndex = 0;
            Konsultant.Text = "Konsultant";
            Konsultant.UseVisualStyleBackColor = false;
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.GradientActiveCaption;
            panel3.Controls.Add(Rejestracja);
            panel3.Controls.Add(refresh);
            panel3.Controls.Add(logout);
            panel3.Controls.Add(button1);
            panel3.Controls.Add(Serwisant);
            panel3.Controls.Add(panele);
            panel3.Controls.Add(Konsultant);
            panel3.Dock = DockStyle.Left;
            panel3.Location = new Point(0, 123);
            panel3.Name = "panel3";
            panel3.Size = new Size(316, 606);
            panel3.TabIndex = 8;
            // 
            // panel2
            // 
            panel2.Location = new Point(349, 129);
            panel2.Name = "panel2";
            panel2.Size = new Size(8, 8);
            panel2.TabIndex = 7;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BackgroundImage = Properties.Resources.exit;
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(1216, 16);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(26, 38);
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // data
            // 
            data.Location = new Point(12, 16);
            data.Name = "data";
            data.Size = new Size(200, 23);
            data.TabIndex = 4;
            // 
            // glowna_nazwa
            // 
            glowna_nazwa.AutoSize = true;
            glowna_nazwa.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 238);
            glowna_nazwa.Location = new Point(349, 17);
            glowna_nazwa.Name = "glowna_nazwa";
            glowna_nazwa.Size = new Size(332, 21);
            glowna_nazwa.TabIndex = 1;
            glowna_nazwa.Text = "Witaj Administratorze w swoim królestwie";
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.GradientActiveCaption;
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(data);
            panel1.Controls.Add(glowna_nazwa);
            panel1.Cursor = Cursors.Hand;
            panel1.Dock = DockStyle.Top;
            panel1.ForeColor = SystemColors.ControlText;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1264, 123);
            panel1.TabIndex = 6;
            // 
            // Ksiegowy
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1264, 729);
            Controls.Add(tabelka);
            Controls.Add(panelP);
            Controls.Add(panelsrodkowy);
            Controls.Add(panelL);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Ksiegowy";
            Text = "Ksiegowy";
            tabelka.ResumeLayout(false);
            tabelka.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)logout).EndInit();
            ((System.ComponentModel.ISupportInitialize)refresh).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label listauserow;
        private Panel tabelka;
        private DataGridView dataGridView1;
        private Panel panelP;
        private Panel panelsrodkowy;
        private Panel panelL;
        private ToolTip toolTip1;
        private PictureBox logout;
        private Button Rejestracja;
        private PictureBox refresh;
        private Button button1;
        private Button Serwisant;
        private Label panele;
        private Button Konsultant;
        private Panel panel3;
        private Panel panel2;
        private PictureBox pictureBox1;
        private DateTimePicker data;
        private Label glowna_nazwa;
        private Panel panel1;
    }
}