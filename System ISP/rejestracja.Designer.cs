namespace System_ISP
{
    partial class rejestracja
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(rejestracja));
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            exit = new Label();
            comboBox1 = new ComboBox();
            nazwa = new Label();
            nametekst = new MaterialSkin.Controls.MaterialLabel();
            materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            Login = new MaterialSkin.Controls.MaterialTextBox2();
            materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            materialTextBox21 = new MaterialSkin.Controls.MaterialTextBox2();
            materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            materialTextBox22 = new MaterialSkin.Controls.MaterialTextBox2();
            materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            materialTextBox23 = new MaterialSkin.Controls.MaterialTextBox2();
            materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            materialTextBox24 = new MaterialSkin.Controls.MaterialTextBox2();
            materialLabel6 = new MaterialSkin.Controls.MaterialLabel();
            materialTextBox25 = new MaterialSkin.Controls.MaterialTextBox2();
            materialLabel7 = new MaterialSkin.Controls.MaterialLabel();
            materialButton1 = new MaterialSkin.Controls.MaterialButton();
            materialLabel8 = new MaterialSkin.Controls.MaterialLabel();
            comboBox2 = new ComboBox();
            materialLabel9 = new MaterialSkin.Controls.MaterialLabel();
            materialTextBox26 = new MaterialSkin.Controls.MaterialTextBox2();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ButtonFace;
            panel1.BackgroundImage = (Image)resources.GetObject("panel1.BackgroundImage");
            panel1.Controls.Add(pictureBox1);
            panel1.ForeColor = SystemColors.ActiveCaptionText;
            panel1.Location = new Point(-2, -2);
            panel1.Name = "panel1";
            panel1.Size = new Size(487, 706);
            panel1.TabIndex = 1;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(44, 157);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(420, 378);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // exit
            // 
            exit.AutoSize = true;
            exit.Cursor = Cursors.Hand;
            exit.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 238);
            exit.Location = new Point(926, 1);
            exit.Name = "exit";
            exit.Size = new Size(19, 20);
            exit.TabIndex = 0;
            exit.Text = "X";
            exit.Click += exit_Click;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "admin", "konsultant", "user", "serwisant", "ksiegowy" });
            comboBox1.Location = new Point(500, 618);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(175, 23);
            comboBox1.TabIndex = 12;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // nazwa
            // 
            nazwa.AutoSize = true;
            nazwa.BackColor = Color.Transparent;
            nazwa.Cursor = Cursors.Hand;
            nazwa.Font = new Font("Arial Rounded MT Bold", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            nazwa.Location = new Point(491, 21);
            nazwa.Name = "nazwa";
            nazwa.Size = new Size(454, 24);
            nazwa.TabIndex = 1;
            nazwa.Text = "Witaj administatorze w kreatorze Rejestracji";
            nazwa.Click += nazwa_Click;
            // 
            // nametekst
            // 
            nametekst.AutoSize = true;
            nametekst.BackColor = Color.Transparent;
            nametekst.Depth = 0;
            nametekst.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            nametekst.Location = new Point(491, 45);
            nametekst.MouseState = MaterialSkin.MouseState.HOVER;
            nametekst.Name = "nametekst";
            nametekst.Size = new Size(394, 19);
            nametekst.TabIndex = 8;
            nametekst.Text = "Aby zarejestrować użytkownika, wypełnij poniższe pola:";
            nametekst.TextAlign = ContentAlignment.TopCenter;
            nametekst.Click += nametekst_Click;
            // 
            // materialLabel1
            // 
            materialLabel1.AutoSize = true;
            materialLabel1.BackColor = Color.Transparent;
            materialLabel1.Depth = 0;
            materialLabel1.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel1.Location = new Point(500, 73);
            materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel1.Name = "materialLabel1";
            materialLabel1.Size = new Size(143, 19);
            materialLabel1.TabIndex = 9;
            materialLabel1.Text = "Nazwa użytkownika";
            materialLabel1.TextAlign = ContentAlignment.TopCenter;
            // 
            // Login
            // 
            Login.AnimateReadOnly = false;
            Login.BackgroundImageLayout = ImageLayout.None;
            Login.CharacterCasing = CharacterCasing.Normal;
            Login.Depth = 0;
            Login.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            Login.HideSelection = true;
            Login.LeadingIcon = null;
            Login.Location = new Point(500, 95);
            Login.MaxLength = 32767;
            Login.MouseState = MaterialSkin.MouseState.OUT;
            Login.Name = "Login";
            Login.PasswordChar = '\0';
            Login.PrefixSuffixText = null;
            Login.ReadOnly = false;
            Login.RightToLeft = RightToLeft.No;
            Login.SelectedText = "";
            Login.SelectionLength = 0;
            Login.SelectionStart = 0;
            Login.ShortcutsEnabled = true;
            Login.Size = new Size(440, 48);
            Login.TabIndex = 10;
            Login.TabStop = false;
            Login.TextAlign = HorizontalAlignment.Left;
            Login.TrailingIcon = null;
            Login.UseSystemPasswordChar = false;
            Login.Click += Login_Click;
            // 
            // materialLabel2
            // 
            materialLabel2.AutoSize = true;
            materialLabel2.BackColor = Color.Transparent;
            materialLabel2.Depth = 0;
            materialLabel2.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel2.Location = new Point(500, 146);
            materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel2.Name = "materialLabel2";
            materialLabel2.Size = new Size(42, 19);
            materialLabel2.TabIndex = 11;
            materialLabel2.Text = "Hasło";
            materialLabel2.TextAlign = ContentAlignment.TopCenter;
            // 
            // materialTextBox21
            // 
            materialTextBox21.AnimateReadOnly = false;
            materialTextBox21.BackgroundImageLayout = ImageLayout.None;
            materialTextBox21.CharacterCasing = CharacterCasing.Normal;
            materialTextBox21.Depth = 0;
            materialTextBox21.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialTextBox21.HideSelection = true;
            materialTextBox21.LeadingIcon = null;
            materialTextBox21.Location = new Point(500, 168);
            materialTextBox21.MaxLength = 32767;
            materialTextBox21.MouseState = MaterialSkin.MouseState.OUT;
            materialTextBox21.Name = "materialTextBox21";
            materialTextBox21.PasswordChar = '\0';
            materialTextBox21.PrefixSuffixText = null;
            materialTextBox21.ReadOnly = false;
            materialTextBox21.RightToLeft = RightToLeft.No;
            materialTextBox21.SelectedText = "";
            materialTextBox21.SelectionLength = 0;
            materialTextBox21.SelectionStart = 0;
            materialTextBox21.ShortcutsEnabled = true;
            materialTextBox21.Size = new Size(440, 48);
            materialTextBox21.TabIndex = 12;
            materialTextBox21.TabStop = false;
            materialTextBox21.TextAlign = HorizontalAlignment.Left;
            materialTextBox21.TrailingIcon = null;
            materialTextBox21.UseSystemPasswordChar = false;
            materialTextBox21.Click += materialTextBox21_Click;
            // 
            // materialLabel3
            // 
            materialLabel3.AutoSize = true;
            materialLabel3.BackColor = Color.Transparent;
            materialLabel3.Depth = 0;
            materialLabel3.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel3.Location = new Point(500, 219);
            materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel3.Name = "materialLabel3";
            materialLabel3.Size = new Size(31, 19);
            materialLabel3.TabIndex = 13;
            materialLabel3.Text = "Imię";
            materialLabel3.TextAlign = ContentAlignment.TopCenter;
            // 
            // materialTextBox22
            // 
            materialTextBox22.AnimateReadOnly = false;
            materialTextBox22.BackgroundImageLayout = ImageLayout.None;
            materialTextBox22.CharacterCasing = CharacterCasing.Normal;
            materialTextBox22.Depth = 0;
            materialTextBox22.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialTextBox22.HideSelection = true;
            materialTextBox22.LeadingIcon = null;
            materialTextBox22.Location = new Point(500, 241);
            materialTextBox22.MaxLength = 32767;
            materialTextBox22.MouseState = MaterialSkin.MouseState.OUT;
            materialTextBox22.Name = "materialTextBox22";
            materialTextBox22.PasswordChar = '\0';
            materialTextBox22.PrefixSuffixText = null;
            materialTextBox22.ReadOnly = false;
            materialTextBox22.RightToLeft = RightToLeft.No;
            materialTextBox22.SelectedText = "";
            materialTextBox22.SelectionLength = 0;
            materialTextBox22.SelectionStart = 0;
            materialTextBox22.ShortcutsEnabled = true;
            materialTextBox22.Size = new Size(440, 48);
            materialTextBox22.TabIndex = 14;
            materialTextBox22.TabStop = false;
            materialTextBox22.TextAlign = HorizontalAlignment.Left;
            materialTextBox22.TrailingIcon = null;
            materialTextBox22.UseSystemPasswordChar = false;
            materialTextBox22.Click += materialTextBox22_Click;
            // 
            // materialLabel4
            // 
            materialLabel4.AutoSize = true;
            materialLabel4.BackColor = Color.Transparent;
            materialLabel4.Depth = 0;
            materialLabel4.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel4.Location = new Point(500, 292);
            materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel4.Name = "materialLabel4";
            materialLabel4.Size = new Size(70, 19);
            materialLabel4.TabIndex = 15;
            materialLabel4.Text = "Nazwisko";
            materialLabel4.TextAlign = ContentAlignment.TopCenter;
            // 
            // materialTextBox23
            // 
            materialTextBox23.AnimateReadOnly = false;
            materialTextBox23.BackgroundImageLayout = ImageLayout.None;
            materialTextBox23.CharacterCasing = CharacterCasing.Normal;
            materialTextBox23.Depth = 0;
            materialTextBox23.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialTextBox23.HideSelection = true;
            materialTextBox23.LeadingIcon = null;
            materialTextBox23.Location = new Point(500, 314);
            materialTextBox23.MaxLength = 32767;
            materialTextBox23.MouseState = MaterialSkin.MouseState.OUT;
            materialTextBox23.Name = "materialTextBox23";
            materialTextBox23.PasswordChar = '\0';
            materialTextBox23.PrefixSuffixText = null;
            materialTextBox23.ReadOnly = false;
            materialTextBox23.RightToLeft = RightToLeft.No;
            materialTextBox23.SelectedText = "";
            materialTextBox23.SelectionLength = 0;
            materialTextBox23.SelectionStart = 0;
            materialTextBox23.ShortcutsEnabled = true;
            materialTextBox23.Size = new Size(440, 48);
            materialTextBox23.TabIndex = 16;
            materialTextBox23.TabStop = false;
            materialTextBox23.TextAlign = HorizontalAlignment.Left;
            materialTextBox23.TrailingIcon = null;
            materialTextBox23.UseSystemPasswordChar = false;
            materialTextBox23.Click += materialTextBox23_Click;
            // 
            // materialLabel5
            // 
            materialLabel5.AutoSize = true;
            materialLabel5.BackColor = Color.Transparent;
            materialLabel5.Depth = 0;
            materialLabel5.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel5.Location = new Point(501, 365);
            materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel5.Name = "materialLabel5";
            materialLabel5.Size = new Size(41, 19);
            materialLabel5.TabIndex = 17;
            materialLabel5.Text = "Email";
            materialLabel5.TextAlign = ContentAlignment.TopCenter;
            // 
            // materialTextBox24
            // 
            materialTextBox24.AnimateReadOnly = false;
            materialTextBox24.BackgroundImageLayout = ImageLayout.None;
            materialTextBox24.CharacterCasing = CharacterCasing.Normal;
            materialTextBox24.Depth = 0;
            materialTextBox24.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialTextBox24.HideSelection = true;
            materialTextBox24.LeadingIcon = null;
            materialTextBox24.Location = new Point(500, 387);
            materialTextBox24.MaxLength = 32767;
            materialTextBox24.MouseState = MaterialSkin.MouseState.OUT;
            materialTextBox24.Name = "materialTextBox24";
            materialTextBox24.PasswordChar = '\0';
            materialTextBox24.PrefixSuffixText = null;
            materialTextBox24.ReadOnly = false;
            materialTextBox24.RightToLeft = RightToLeft.No;
            materialTextBox24.SelectedText = "";
            materialTextBox24.SelectionLength = 0;
            materialTextBox24.SelectionStart = 0;
            materialTextBox24.ShortcutsEnabled = true;
            materialTextBox24.Size = new Size(440, 48);
            materialTextBox24.TabIndex = 18;
            materialTextBox24.TabStop = false;
            materialTextBox24.TextAlign = HorizontalAlignment.Left;
            materialTextBox24.TrailingIcon = null;
            materialTextBox24.UseSystemPasswordChar = false;
            materialTextBox24.Click += materialTextBox24_Click;
            // 
            // materialLabel6
            // 
            materialLabel6.AutoSize = true;
            materialLabel6.BackColor = Color.Transparent;
            materialLabel6.Depth = 0;
            materialLabel6.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel6.Location = new Point(501, 438);
            materialLabel6.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel6.Name = "materialLabel6";
            materialLabel6.Size = new Size(110, 19);
            materialLabel6.TabIndex = 19;
            materialLabel6.Text = "Numer telefonu";
            materialLabel6.TextAlign = ContentAlignment.TopCenter;
            // 
            // materialTextBox25
            // 
            materialTextBox25.AnimateReadOnly = false;
            materialTextBox25.BackgroundImageLayout = ImageLayout.None;
            materialTextBox25.CharacterCasing = CharacterCasing.Normal;
            materialTextBox25.Depth = 0;
            materialTextBox25.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialTextBox25.HideSelection = true;
            materialTextBox25.LeadingIcon = null;
            materialTextBox25.Location = new Point(500, 460);
            materialTextBox25.MaxLength = 32767;
            materialTextBox25.MouseState = MaterialSkin.MouseState.OUT;
            materialTextBox25.Name = "materialTextBox25";
            materialTextBox25.PasswordChar = '\0';
            materialTextBox25.PrefixSuffixText = null;
            materialTextBox25.ReadOnly = false;
            materialTextBox25.RightToLeft = RightToLeft.No;
            materialTextBox25.SelectedText = "";
            materialTextBox25.SelectionLength = 0;
            materialTextBox25.SelectionStart = 0;
            materialTextBox25.ShortcutsEnabled = true;
            materialTextBox25.Size = new Size(440, 48);
            materialTextBox25.TabIndex = 20;
            materialTextBox25.TabStop = false;
            materialTextBox25.TextAlign = HorizontalAlignment.Left;
            materialTextBox25.TrailingIcon = null;
            materialTextBox25.UseSystemPasswordChar = false;
            materialTextBox25.Click += materialTextBox25_Click;
            // 
            // materialLabel7
            // 
            materialLabel7.AutoSize = true;
            materialLabel7.BackColor = Color.Transparent;
            materialLabel7.Depth = 0;
            materialLabel7.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel7.Location = new Point(500, 596);
            materialLabel7.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel7.Name = "materialLabel7";
            materialLabel7.Size = new Size(175, 19);
            materialLabel7.TabIndex = 21;
            materialLabel7.Text = "Wybierz Rolę w systemie";
            materialLabel7.TextAlign = ContentAlignment.TopCenter;
            // 
            // materialButton1
            // 
            materialButton1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            materialButton1.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            materialButton1.Depth = 0;
            materialButton1.HighEmphasis = true;
            materialButton1.Icon = null;
            materialButton1.Location = new Point(629, 650);
            materialButton1.Margin = new Padding(4, 6, 4, 6);
            materialButton1.MouseState = MaterialSkin.MouseState.HOVER;
            materialButton1.Name = "materialButton1";
            materialButton1.NoAccentTextColor = Color.Empty;
            materialButton1.Size = new Size(175, 36);
            materialButton1.TabIndex = 22;
            materialButton1.Text = "Dodaj użytkownika";
            materialButton1.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            materialButton1.UseAccentColor = false;
            materialButton1.UseVisualStyleBackColor = true;
            materialButton1.Click += materialButton1_Click;
            // 
            // materialLabel8
            // 
            materialLabel8.AutoSize = true;
            materialLabel8.BackColor = Color.Transparent;
            materialLabel8.Depth = 0;
            materialLabel8.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel8.Location = new Point(700, 596);
            materialLabel8.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel8.Name = "materialLabel8";
            materialLabel8.Size = new Size(104, 19);
            materialLabel8.TabIndex = 23;
            materialLabel8.Text = "Wybierz usługi";
            materialLabel8.TextAlign = ContentAlignment.TopCenter;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "admin", "konsultant", "user", "serwisant", "ksiegowy" });
            comboBox2.Location = new Point(700, 618);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(240, 23);
            comboBox2.TabIndex = 24;
            comboBox2.SelectedIndexChanged += comboBox2_SelectedIndexChanged;
            // 
            // materialLabel9
            // 
            materialLabel9.AutoSize = true;
            materialLabel9.BackColor = Color.Transparent;
            materialLabel9.Depth = 0;
            materialLabel9.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel9.Location = new Point(500, 511);
            materialLabel9.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel9.Name = "materialLabel9";
            materialLabel9.Size = new Size(39, 19);
            materialLabel9.TabIndex = 25;
            materialLabel9.Text = "Pesel";
            materialLabel9.TextAlign = ContentAlignment.TopCenter;
            materialLabel9.Click += materialLabel9_Click;
            // 
            // materialTextBox26
            // 
            materialTextBox26.AnimateReadOnly = false;
            materialTextBox26.BackgroundImageLayout = ImageLayout.None;
            materialTextBox26.CharacterCasing = CharacterCasing.Normal;
            materialTextBox26.Depth = 0;
            materialTextBox26.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialTextBox26.HideSelection = true;
            materialTextBox26.LeadingIcon = null;
            materialTextBox26.Location = new Point(500, 533);
            materialTextBox26.MaxLength = 32767;
            materialTextBox26.MouseState = MaterialSkin.MouseState.OUT;
            materialTextBox26.Name = "materialTextBox26";
            materialTextBox26.PasswordChar = '\0';
            materialTextBox26.PrefixSuffixText = null;
            materialTextBox26.ReadOnly = false;
            materialTextBox26.RightToLeft = RightToLeft.No;
            materialTextBox26.SelectedText = "";
            materialTextBox26.SelectionLength = 0;
            materialTextBox26.SelectionStart = 0;
            materialTextBox26.ShortcutsEnabled = true;
            materialTextBox26.Size = new Size(440, 48);
            materialTextBox26.TabIndex = 26;
            materialTextBox26.TabStop = false;
            materialTextBox26.TextAlign = HorizontalAlignment.Left;
            materialTextBox26.TrailingIcon = null;
            materialTextBox26.UseSystemPasswordChar = false;
            materialTextBox26.Click += materialTextBox26_Click;
            // 
            // rejestracja
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(952, 704);
            Controls.Add(materialTextBox26);
            Controls.Add(materialLabel9);
            Controls.Add(comboBox2);
            Controls.Add(materialLabel8);
            Controls.Add(materialButton1);
            Controls.Add(exit);
            Controls.Add(materialLabel7);
            Controls.Add(materialTextBox25);
            Controls.Add(materialLabel6);
            Controls.Add(materialTextBox24);
            Controls.Add(materialLabel5);
            Controls.Add(materialTextBox23);
            Controls.Add(materialLabel4);
            Controls.Add(materialTextBox22);
            Controls.Add(materialLabel3);
            Controls.Add(materialTextBox21);
            Controls.Add(comboBox1);
            Controls.Add(materialLabel2);
            Controls.Add(Login);
            Controls.Add(materialLabel1);
            Controls.Add(nametekst);
            Controls.Add(panel1);
            Controls.Add(nazwa);
            FormBorderStyle = FormBorderStyle.None;
            Name = "rejestracja";
            Text = "rejestracja";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label nazwa;
        private Label exit;
        private ComboBox comboBox1;
        private MaterialSkin.Controls.MaterialLabel nametekst;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialTextBox2 Login;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialTextBox2 materialTextBox21;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialTextBox2 materialTextBox22;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialTextBox2 materialTextBox23;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private MaterialSkin.Controls.MaterialTextBox2 materialTextBox24;
        private MaterialSkin.Controls.MaterialLabel materialLabel6;
        private MaterialSkin.Controls.MaterialTextBox2 materialTextBox25;
        private MaterialSkin.Controls.MaterialLabel materialLabel7;
        private MaterialSkin.Controls.MaterialButton materialButton1;
        private PictureBox pictureBox1;
        private MaterialSkin.Controls.MaterialLabel materialLabel8;
        private ComboBox comboBox2;
        private MaterialSkin.Controls.MaterialLabel materialLabel9;
        private MaterialSkin.Controls.MaterialTextBox2 materialTextBox26;
    }
}