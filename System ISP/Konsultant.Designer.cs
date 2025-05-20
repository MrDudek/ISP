namespace System_ISP
{
    partial class Konsultant
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
            toolTip1 = new ToolTip(components);
            logout = new PictureBox();
            refresh = new PictureBox();
            panele = new Label();
            panel3 = new Panel();
            buttonnewfaktura = new MaterialSkin.Controls.MaterialButton();
            pictureBox1 = new PictureBox();
            glowna_nazwa = new Label();
            panel1 = new Panel();
            findbox = new MaterialSkin.Controls.MaterialTextBox2();
            findusername = new MaterialSkin.Controls.MaterialLabel();
            materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
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
            listauserow.Location = new Point(11, 17);
            listauserow.Name = "listauserow";
            listauserow.Size = new Size(0, 25);
            listauserow.TabIndex = 0;
            // 
            // tabelka
            // 
            tabelka.Controls.Add(materialLabel1);
            tabelka.Controls.Add(dataGridView1);
            tabelka.Controls.Add(listauserow);
            tabelka.Location = new Point(322, 271);
            tabelka.Name = "tabelka";
            tabelka.Size = new Size(930, 446);
            tabelka.TabIndex = 10;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(11, 45);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(913, 401);
            dataGridView1.TabIndex = 1;
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
            refresh.Location = new Point(252, 544);
            refresh.Name = "refresh";
            refresh.Size = new Size(57, 50);
            refresh.TabIndex = 2;
            refresh.TabStop = false;
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
            // panel3
            // 
            panel3.BackColor = SystemColors.GradientActiveCaption;
            panel3.Controls.Add(buttonnewfaktura);
            panel3.Controls.Add(refresh);
            panel3.Controls.Add(logout);
            panel3.Controls.Add(panele);
            panel3.Dock = DockStyle.Left;
            panel3.Location = new Point(0, 123);
            panel3.Name = "panel3";
            panel3.Size = new Size(316, 606);
            panel3.TabIndex = 8;
            // 
            // buttonnewfaktura
            // 
            buttonnewfaktura.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            buttonnewfaktura.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            buttonnewfaktura.Depth = 0;
            buttonnewfaktura.HighEmphasis = true;
            buttonnewfaktura.Icon = null;
            buttonnewfaktura.Location = new Point(57, 62);
            buttonnewfaktura.Margin = new Padding(4, 6, 4, 6);
            buttonnewfaktura.MouseState = MaterialSkin.MouseState.HOVER;
            buttonnewfaktura.Name = "buttonnewfaktura";
            buttonnewfaktura.NoAccentTextColor = Color.Empty;
            buttonnewfaktura.Size = new Size(182, 36);
            buttonnewfaktura.TabIndex = 10;
            buttonnewfaktura.Text = "Szukaj użytkownika";
            buttonnewfaktura.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            buttonnewfaktura.UseAccentColor = false;
            buttonnewfaktura.UseVisualStyleBackColor = true;
            buttonnewfaktura.Click += buttonnewfaktura_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BackgroundImage = Properties.Resources.exit;
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(1235, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(17, 24);
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // glowna_nazwa
            // 
            glowna_nazwa.AutoSize = true;
            glowna_nazwa.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            glowna_nazwa.Location = new Point(256, 33);
            glowna_nazwa.Name = "glowna_nazwa";
            glowna_nazwa.Size = new Size(808, 37);
            glowna_nazwa.TabIndex = 1;
            glowna_nazwa.Text = "Witaj w panelu działań Konsultanta czuj się jak u sb w domu :)";
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.GradientActiveCaption;
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(glowna_nazwa);
            panel1.Cursor = Cursors.Hand;
            panel1.Dock = DockStyle.Top;
            panel1.ForeColor = SystemColors.ControlText;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1264, 123);
            panel1.TabIndex = 6;
            // 
            // findbox
            // 
            findbox.AnimateReadOnly = false;
            findbox.BackgroundImageLayout = ImageLayout.None;
            findbox.CharacterCasing = CharacterCasing.Normal;
            findbox.Depth = 0;
            findbox.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            findbox.HideSelection = true;
            findbox.LeadingIcon = null;
            findbox.Location = new Point(361, 200);
            findbox.MaxLength = 32767;
            findbox.MouseState = MaterialSkin.MouseState.OUT;
            findbox.Name = "findbox";
            findbox.PasswordChar = '\0';
            findbox.PrefixSuffixText = null;
            findbox.ReadOnly = false;
            findbox.RightToLeft = RightToLeft.No;
            findbox.SelectedText = "";
            findbox.SelectionLength = 0;
            findbox.SelectionStart = 0;
            findbox.ShortcutsEnabled = true;
            findbox.Size = new Size(385, 48);
            findbox.TabIndex = 11;
            findbox.TabStop = false;
            findbox.TextAlign = HorizontalAlignment.Left;
            findbox.TrailingIcon = null;
            findbox.UseSystemPasswordChar = false;
            // 
            // findusername
            // 
            findusername.AutoSize = true;
            findusername.Depth = 0;
            findusername.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            findusername.Location = new Point(361, 163);
            findusername.MouseState = MaterialSkin.MouseState.HOVER;
            findusername.Name = "findusername";
            findusername.Size = new Size(340, 19);
            findusername.TabIndex = 12;
            findusername.Text = "Wpisz żądaną fraze i kliknij Szukaj Użytkownika";
            // 
            // materialLabel1
            // 
            materialLabel1.AutoSize = true;
            materialLabel1.Depth = 0;
            materialLabel1.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel1.Location = new Point(39, 17);
            materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel1.Name = "materialLabel1";
            materialLabel1.Size = new Size(152, 19);
            materialLabel1.TabIndex = 13;
            materialLabel1.Text = "Wyniki wyszukiwania";
            // 
            // Konsultant
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1264, 729);
            Controls.Add(findusername);
            Controls.Add(findbox);
            Controls.Add(tabelka);
            Controls.Add(panel3);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Konsultant";
            Text = "Konsultant";
            Load += Konsultant_Load;
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
            PerformLayout();
        }

        #endregion

        private Label listauserow;
        private Panel tabelka;
        private DataGridView dataGridView1;
        private ToolTip toolTip1;
        private PictureBox logout;
        private PictureBox refresh;
        private Label panele;
        private Panel panel3;
        private PictureBox pictureBox1;
        private Label glowna_nazwa;
        private Panel panel1;
        private MaterialSkin.Controls.MaterialButton buttonnewfaktura;
        private MaterialSkin.Controls.MaterialTextBox2 findbox;
        private MaterialSkin.Controls.MaterialLabel findusername;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
    }
}