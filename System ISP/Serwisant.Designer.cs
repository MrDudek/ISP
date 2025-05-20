namespace System_ISP
{
    partial class Serwisant
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
            Listazgloszen = new Label();
            tabelka = new Panel();
            polestatusu = new ComboBox();
            statuszgloszenia = new Label();
            daneuser = new Label();
            textBox1 = new TextBox();
            tresczgloszenia = new TextBox();
            szczegoly = new Label();
            dataGridView1 = new DataGridView();
            toolTip1 = new ToolTip(components);
            logout = new PictureBox();
            refresh = new PictureBox();
            panele = new Label();
            panel3 = new Panel();
            materialButton1 = new MaterialSkin.Controls.MaterialButton();
            save = new MaterialSkin.Controls.MaterialButton();
            panel2 = new Panel();
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            label1 = new Label();
            tabelka.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)logout).BeginInit();
            ((System.ComponentModel.ISupportInitialize)refresh).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // Listazgloszen
            // 
            Listazgloszen.AutoSize = true;
            Listazgloszen.Font = new Font("Tahoma", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 238);
            Listazgloszen.Location = new Point(15, 15);
            Listazgloszen.Name = "Listazgloszen";
            Listazgloszen.Size = new Size(140, 25);
            Listazgloszen.TabIndex = 0;
            Listazgloszen.Text = "Lista zgłoszeń";
            Listazgloszen.Click += listauserow_Click;
            // 
            // tabelka
            // 
            tabelka.Controls.Add(polestatusu);
            tabelka.Controls.Add(statuszgloszenia);
            tabelka.Controls.Add(daneuser);
            tabelka.Controls.Add(textBox1);
            tabelka.Controls.Add(tresczgloszenia);
            tabelka.Controls.Add(szczegoly);
            tabelka.Controls.Add(dataGridView1);
            tabelka.Controls.Add(Listazgloszen);
            tabelka.Location = new Point(322, 129);
            tabelka.Name = "tabelka";
            tabelka.Size = new Size(920, 588);
            tabelka.TabIndex = 10;
            // 
            // polestatusu
            // 
            polestatusu.FormattingEnabled = true;
            polestatusu.Location = new Point(654, 332);
            polestatusu.Name = "polestatusu";
            polestatusu.Size = new Size(207, 23);
            polestatusu.TabIndex = 7;
            polestatusu.SelectedIndexChanged += polestatusu_SelectedIndexChanged;
            // 
            // statuszgloszenia
            // 
            statuszgloszenia.AutoSize = true;
            statuszgloszenia.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point, 238);
            statuszgloszenia.Location = new Point(644, 292);
            statuszgloszenia.Name = "statuszgloszenia";
            statuszgloszenia.Size = new Size(273, 28);
            statuszgloszenia.TabIndex = 6;
            statuszgloszenia.Text = "Status zgłoszenia (do wyboru)";
            // 
            // daneuser
            // 
            daneuser.AutoSize = true;
            daneuser.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point, 238);
            daneuser.Location = new Point(324, 292);
            daneuser.Name = "daneuser";
            daneuser.Size = new Size(120, 28);
            daneuser.TabIndex = 5;
            daneuser.Text = "Dane klienta";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(324, 323);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(308, 247);
            textBox1.TabIndex = 4;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // tresczgloszenia
            // 
            tresczgloszenia.Location = new Point(11, 323);
            tresczgloszenia.Multiline = true;
            tresczgloszenia.Name = "tresczgloszenia";
            tresczgloszenia.Size = new Size(294, 244);
            tresczgloszenia.TabIndex = 3;
            tresczgloszenia.TextChanged += tresczgloszenia_TextChanged;
            // 
            // szczegoly
            // 
            szczegoly.AutoSize = true;
            szczegoly.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point, 238);
            szczegoly.Location = new Point(8, 292);
            szczegoly.Name = "szczegoly";
            szczegoly.Size = new Size(297, 28);
            szczegoly.TabIndex = 2;
            szczegoly.Text = "Szczegóły wybranego zgłoszenia";
            szczegoly.Click += szczegoly_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(11, 45);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(906, 237);
            dataGridView1.TabIndex = 1;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
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
            logout.Click += logout_Click;
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
            refresh.Click += refresh_Click;
            // 
            // panele
            // 
            panele.AutoSize = true;
            panele.Font = new Font("Arial Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 238);
            panele.Location = new Point(42, 24);
            panele.Name = "panele";
            panele.Size = new Size(227, 23);
            panele.TabIndex = 1;
            panele.Text = "Przyciski do zarządzania";
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.GradientActiveCaption;
            panel3.Controls.Add(materialButton1);
            panel3.Controls.Add(save);
            panel3.Controls.Add(refresh);
            panel3.Controls.Add(logout);
            panel3.Controls.Add(panele);
            panel3.Dock = DockStyle.Left;
            panel3.Location = new Point(0, 123);
            panel3.Name = "panel3";
            panel3.Size = new Size(316, 606);
            panel3.TabIndex = 8;
            // 
            // materialButton1
            // 
            materialButton1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            materialButton1.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            materialButton1.Depth = 0;
            materialButton1.HighEmphasis = true;
            materialButton1.Icon = null;
            materialButton1.Location = new Point(42, 135);
            materialButton1.Margin = new Padding(4, 6, 4, 6);
            materialButton1.MouseState = MaterialSkin.MouseState.HOVER;
            materialButton1.Name = "materialButton1";
            materialButton1.NoAccentTextColor = Color.Empty;
            materialButton1.Size = new Size(237, 36);
            materialButton1.TabIndex = 11;
            materialButton1.Text = "Zakończ edycje zgłoszenia";
            materialButton1.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            materialButton1.UseAccentColor = false;
            materialButton1.UseVisualStyleBackColor = true;
            materialButton1.Click += materialButton1_Click;
            // 
            // save
            // 
            save.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            save.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            save.Depth = 0;
            save.HighEmphasis = true;
            save.Icon = null;
            save.Location = new Point(42, 76);
            save.Margin = new Padding(4, 6, 4, 6);
            save.MouseState = MaterialSkin.MouseState.HOVER;
            save.Name = "save";
            save.NoAccentTextColor = Color.Empty;
            save.Size = new Size(222, 36);
            save.TabIndex = 10;
            save.Text = "Zapisz Zmiany zgłoszenia";
            save.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            save.UseAccentColor = false;
            save.UseVisualStyleBackColor = true;
            save.Click += save_Click;
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
            pictureBox1.Location = new Point(1236, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(16, 20);
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.GradientActiveCaption;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox1);
            panel1.Cursor = Cursors.Hand;
            panel1.Dock = DockStyle.Top;
            panel1.ForeColor = SystemColors.ControlText;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1264, 123);
            panel1.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label1.Location = new Point(256, 38);
            label1.Name = "label1";
            label1.Size = new Size(683, 37);
            label1.TabIndex = 5;
            label1.Text = "Witaj w panelu działań Serwisanta czuj sie jak u sb :)";
            // 
            // Serwisant
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1264, 729);
            Controls.Add(tabelka);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Serwisant";
            Text = "Serwisant";
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

        private Label Listazgloszen;
        private Panel tabelka;
        private DataGridView dataGridView1;
        private ToolTip toolTip1;
        private PictureBox logout;
        private PictureBox refresh;
        private Label panele;
        private Panel panel3;
        private Panel panel2;
        private PictureBox pictureBox1;
        private Panel panel1;
        private MaterialSkin.Controls.MaterialButton save;
        private Label szczegoly;
        private MaterialSkin.Controls.MaterialButton materialButton1;
        private TextBox tresczgloszenia;
        private ComboBox polestatusu;
        private Label statuszgloszenia;
        private Label daneuser;
        private TextBox textBox1;
        private Label label1;
    }
}