namespace System_ISP
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            exit = new Label();
            Login = new MaterialSkin.Controls.MaterialTextBox2();
            loginbutton = new MaterialSkin.Controls.MaterialButton();
            passbox = new MaterialSkin.Controls.MaterialTextBox2();
            loginname = new MaterialSkin.Controls.MaterialLabel();
            passname = new MaterialSkin.Controls.MaterialLabel();
            nametekst = new MaterialSkin.Controls.MaterialLabel();
            Nazwa = new Label();
            showpasssss = new MaterialSkin.Controls.MaterialCheckbox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ButtonFace;
            panel1.BackgroundImage = Properties.Resources.tło;
            panel1.Controls.Add(pictureBox1);
            panel1.ForeColor = SystemColors.ActiveCaptionText;
            panel1.Location = new Point(-1, -2);
            panel1.Name = "panel1";
            panel1.Size = new Size(477, 581);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(58, 157);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(373, 275);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // exit
            // 
            exit.AutoSize = true;
            exit.Cursor = Cursors.Hand;
            exit.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 238);
            exit.Location = new Point(921, 9);
            exit.Name = "exit";
            exit.Size = new Size(19, 20);
            exit.TabIndex = 0;
            exit.Text = "X";
            exit.Click += label1_Click;
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
            Login.Location = new Point(522, 191);
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
            Login.Size = new Size(250, 48);
            Login.TabIndex = 2;
            Login.TabStop = false;
            Login.TextAlign = HorizontalAlignment.Left;
            Login.TrailingIcon = null;
            Login.UseSystemPasswordChar = false;
            Login.Click += Login_Click;
            // 
            // loginbutton
            // 
            loginbutton.AutoSize = false;
            loginbutton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            loginbutton.Cursor = Cursors.Hand;
            loginbutton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            loginbutton.Depth = 0;
            loginbutton.Font = new Font("Segoe UI", 13F);
            loginbutton.HighEmphasis = true;
            loginbutton.Icon = null;
            loginbutton.Location = new Point(522, 410);
            loginbutton.Margin = new Padding(4, 6, 4, 6);
            loginbutton.MouseState = MaterialSkin.MouseState.HOVER;
            loginbutton.Name = "loginbutton";
            loginbutton.NoAccentTextColor = Color.Empty;
            loginbutton.Size = new Size(158, 36);
            loginbutton.TabIndex = 3;
            loginbutton.Text = "Logowanie";
            loginbutton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            loginbutton.UseAccentColor = false;
            loginbutton.UseVisualStyleBackColor = true;
            loginbutton.Click += loginbutton_Click;
            // 
            // passbox
            // 
            passbox.AnimateReadOnly = false;
            passbox.BackgroundImageLayout = ImageLayout.None;
            passbox.CharacterCasing = CharacterCasing.Normal;
            passbox.Depth = 0;
            passbox.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            passbox.HideSelection = true;
            passbox.LeadingIcon = null;
            passbox.Location = new Point(522, 293);
            passbox.MaxLength = 32767;
            passbox.MouseState = MaterialSkin.MouseState.OUT;
            passbox.Name = "passbox";
            passbox.PasswordChar = '\0';
            passbox.PrefixSuffixText = null;
            passbox.ReadOnly = false;
            passbox.RightToLeft = RightToLeft.No;
            passbox.SelectedText = "";
            passbox.SelectionLength = 0;
            passbox.SelectionStart = 0;
            passbox.ShortcutsEnabled = true;
            passbox.Size = new Size(250, 48);
            passbox.TabIndex = 4;
            passbox.TabStop = false;
            passbox.TextAlign = HorizontalAlignment.Left;
            passbox.TrailingIcon = null;
            passbox.UseSystemPasswordChar = false;
            passbox.Click += materialTextBox21_Click;
            // 
            // loginname
            // 
            loginname.AutoSize = true;
            loginname.BackColor = Color.Transparent;
            loginname.Depth = 0;
            loginname.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            loginname.Location = new Point(522, 155);
            loginname.MouseState = MaterialSkin.MouseState.HOVER;
            loginname.Name = "loginname";
            loginname.Size = new Size(81, 19);
            loginname.TabIndex = 5;
            loginname.Text = "Podaj login";
            loginname.TextAlign = ContentAlignment.TopCenter;
            loginname.Click += loginname_Click;
            // 
            // passname
            // 
            passname.AutoSize = true;
            passname.BackColor = Color.Transparent;
            passname.Depth = 0;
            passname.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            passname.Location = new Point(522, 259);
            passname.MouseState = MaterialSkin.MouseState.HOVER;
            passname.Name = "passname";
            passname.Size = new Size(85, 19);
            passname.TabIndex = 6;
            passname.Text = "Podaj hasło";
            passname.TextAlign = ContentAlignment.TopCenter;
            passname.Click += passname_Click;
            // 
            // nametekst
            // 
            nametekst.AutoSize = true;
            nametekst.BackColor = Color.Transparent;
            nametekst.Depth = 0;
            nametekst.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            nametekst.Location = new Point(522, 117);
            nametekst.MouseState = MaterialSkin.MouseState.HOVER;
            nametekst.Name = "nametekst";
            nametekst.Size = new Size(301, 19);
            nametekst.TabIndex = 7;
            nametekst.Text = "Aby sie zalogować wypełnij poniższe pola:";
            nametekst.TextAlign = ContentAlignment.TopCenter;
            nametekst.Click += nametekst_Click;
            // 
            // Nazwa
            // 
            Nazwa.AutoSize = true;
            Nazwa.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            Nazwa.Location = new Point(522, 40);
            Nazwa.Name = "Nazwa";
            Nazwa.Size = new Size(283, 37);
            Nazwa.TabIndex = 8;
            Nazwa.Text = "Witaj w systemie ISP";
            // 
            // showpasssss
            // 
            showpasssss.AutoSize = true;
            showpasssss.Depth = 0;
            showpasssss.Location = new Point(513, 344);
            showpasssss.Margin = new Padding(0);
            showpasssss.MouseLocation = new Point(-1, -1);
            showpasssss.MouseState = MaterialSkin.MouseState.HOVER;
            showpasssss.Name = "showpasssss";
            showpasssss.ReadOnly = false;
            showpasssss.Ripple = true;
            showpasssss.Size = new Size(122, 37);
            showpasssss.TabIndex = 9;
            showpasssss.Text = "Pokaż hasło";
            showpasssss.UseVisualStyleBackColor = true;
            showpasssss.CheckedChanged += showpasssss_CheckedChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(952, 577);
            Controls.Add(showpasssss);
            Controls.Add(Nazwa);
            Controls.Add(nametekst);
            Controls.Add(passname);
            Controls.Add(loginname);
            Controls.Add(passbox);
            Controls.Add(loginbutton);
            Controls.Add(Login);
            Controls.Add(panel1);
            Controls.Add(exit);
            Font = new Font("Segoe UI", 9F);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            Text = "Form1";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label exit;
        private MaterialSkin.Controls.MaterialTextBox2 Login;
        private MaterialSkin.Controls.MaterialButton loginbutton;
        private MaterialSkin.Controls.MaterialTextBox2 passbox;
        private MaterialSkin.Controls.MaterialLabel loginname;
        private MaterialSkin.Controls.MaterialLabel passname;
        private MaterialSkin.Controls.MaterialLabel nametekst;
        private Label Nazwa;
        private PictureBox pictureBox1;
        private MaterialSkin.Controls.MaterialCheckbox showpasssss;
    }
}
