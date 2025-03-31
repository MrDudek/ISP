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
            panel1 = new Panel();
            tekstrola = new Label();
            telefonbox = new TextBox();
            telefon = new Label();
            emailbox = new TextBox();
            Email = new Label();
            surnamebox = new TextBox();
            surname = new Label();
            namebox = new TextBox();
            name = new Label();
            comboBox1 = new ComboBox();
            opis = new Label();
            button_login = new Button();
            username = new Label();
            login_pass = new TextBox();
            password = new Label();
            login_username = new TextBox();
            nazwa = new Label();
            exit = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ButtonFace;
            panel1.BackgroundImage = Properties.Resources.tło;
            panel1.Controls.Add(tekstrola);
            panel1.Controls.Add(telefonbox);
            panel1.Controls.Add(telefon);
            panel1.Controls.Add(emailbox);
            panel1.Controls.Add(Email);
            panel1.Controls.Add(surnamebox);
            panel1.Controls.Add(surname);
            panel1.Controls.Add(namebox);
            panel1.Controls.Add(name);
            panel1.Controls.Add(comboBox1);
            panel1.Controls.Add(opis);
            panel1.Controls.Add(button_login);
            panel1.Controls.Add(username);
            panel1.Controls.Add(login_pass);
            panel1.Controls.Add(password);
            panel1.Controls.Add(login_username);
            panel1.Controls.Add(nazwa);
            panel1.Controls.Add(exit);
            panel1.ForeColor = SystemColors.ActiveCaptionText;
            panel1.Location = new Point(-2, -2);
            panel1.Name = "panel1";
            panel1.Size = new Size(487, 591);
            panel1.TabIndex = 1;
            // 
            // tekstrola
            // 
            tekstrola.AutoSize = true;
            tekstrola.BackColor = Color.Transparent;
            tekstrola.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 238);
            tekstrola.Location = new Point(13, 501);
            tekstrola.Name = "tekstrola";
            tekstrola.Size = new Size(199, 21);
            tekstrola.TabIndex = 21;
            tekstrola.Text = "Wybierz Role w systemie";
            // 
            // telefonbox
            // 
            telefonbox.BackColor = SystemColors.Control;
            telefonbox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 238);
            telefonbox.Location = new Point(14, 446);
            telefonbox.Name = "telefonbox";
            telefonbox.Size = new Size(427, 29);
            telefonbox.TabIndex = 20;
            telefonbox.TextChanged += textBox4_TextChanged;
            // 
            // telefon
            // 
            telefon.AutoSize = true;
            telefon.BackColor = Color.Transparent;
            telefon.Cursor = Cursors.Hand;
            telefon.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 238);
            telefon.ForeColor = SystemColors.ActiveCaptionText;
            telefon.Location = new Point(14, 421);
            telefon.Name = "telefon";
            telefon.Size = new Size(73, 22);
            telefon.TabIndex = 19;
            telefon.Text = "Telefon";
            telefon.Click += telefon_Click;
            // 
            // emailbox
            // 
            emailbox.BackColor = SystemColors.Control;
            emailbox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 238);
            emailbox.Location = new Point(14, 380);
            emailbox.Name = "emailbox";
            emailbox.Size = new Size(427, 29);
            emailbox.TabIndex = 18;
            emailbox.TextChanged += textBox3_TextChanged;
            // 
            // Email
            // 
            Email.AutoSize = true;
            Email.BackColor = Color.Transparent;
            Email.Cursor = Cursors.Hand;
            Email.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 238);
            Email.ForeColor = SystemColors.ActiveCaptionText;
            Email.Location = new Point(14, 355);
            Email.Name = "Email";
            Email.Size = new Size(57, 22);
            Email.TabIndex = 17;
            Email.Text = "Email";
            Email.Click += Email_Click;
            // 
            // surnamebox
            // 
            surnamebox.BackColor = SystemColors.Control;
            surnamebox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 238);
            surnamebox.Location = new Point(14, 323);
            surnamebox.Name = "surnamebox";
            surnamebox.Size = new Size(427, 29);
            surnamebox.TabIndex = 16;
            surnamebox.TextChanged += textBox2_TextChanged;
            // 
            // surname
            // 
            surname.AutoSize = true;
            surname.BackColor = Color.Transparent;
            surname.Cursor = Cursors.Hand;
            surname.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 238);
            surname.ForeColor = SystemColors.ActiveCaptionText;
            surname.Location = new Point(14, 298);
            surname.Name = "surname";
            surname.Size = new Size(89, 22);
            surname.TabIndex = 15;
            surname.Text = "Nazwisko";
            surname.Click += surname_Click;
            // 
            // namebox
            // 
            namebox.BackColor = SystemColors.Control;
            namebox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 238);
            namebox.Location = new Point(14, 256);
            namebox.Name = "namebox";
            namebox.Size = new Size(427, 29);
            namebox.TabIndex = 14;
            namebox.TextChanged += textBox1_TextChanged;
            // 
            // name
            // 
            name.AutoSize = true;
            name.BackColor = Color.Transparent;
            name.Cursor = Cursors.Hand;
            name.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 238);
            name.ForeColor = SystemColors.ActiveCaptionText;
            name.Location = new Point(14, 231);
            name.Name = "name";
            name.Size = new Size(47, 22);
            name.TabIndex = 13;
            name.Text = "Imie";
            name.Click += name_Click;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "admin", "konsultant", "user", "serwisant", "ksiegowy" });
            comboBox1.Location = new Point(14, 535);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 12;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // opis
            // 
            opis.AutoSize = true;
            opis.BackColor = Color.Transparent;
            opis.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 238);
            opis.Location = new Point(14, 80);
            opis.Name = "opis";
            opis.Size = new Size(261, 25);
            opis.TabIndex = 11;
            opis.Text = "Wprowadz podstawowe dane";
            // 
            // button_login
            // 
            button_login.BackColor = SystemColors.Desktop;
            button_login.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 238);
            button_login.ForeColor = SystemColors.Control;
            button_login.Location = new Point(289, 514);
            button_login.Name = "button_login";
            button_login.Size = new Size(152, 44);
            button_login.TabIndex = 7;
            button_login.Text = "Dodaj";
            button_login.UseVisualStyleBackColor = false;
            button_login.Click += button_login_Click;
            // 
            // username
            // 
            username.AutoSize = true;
            username.BackColor = Color.Transparent;
            username.Cursor = Cursors.Hand;
            username.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 238);
            username.ForeColor = SystemColors.ActiveCaptionText;
            username.Location = new Point(14, 117);
            username.Name = "username";
            username.Size = new Size(192, 22);
            username.TabIndex = 6;
            username.Text = "Nazwa Użytkownika";
            // 
            // login_pass
            // 
            login_pass.BackColor = SystemColors.Control;
            login_pass.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 238);
            login_pass.Location = new Point(14, 199);
            login_pass.Name = "login_pass";
            login_pass.Size = new Size(427, 29);
            login_pass.TabIndex = 5;
            login_pass.TextChanged += login_pass_TextChanged;
            // 
            // password
            // 
            password.AutoSize = true;
            password.BackColor = Color.Transparent;
            password.Cursor = Cursors.Hand;
            password.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 238);
            password.Location = new Point(14, 174);
            password.Name = "password";
            password.Size = new Size(62, 22);
            password.TabIndex = 4;
            password.Text = "Hasło";
            // 
            // login_username
            // 
            login_username.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 238);
            login_username.Location = new Point(14, 142);
            login_username.Name = "login_username";
            login_username.Size = new Size(427, 29);
            login_username.TabIndex = 3;
            login_username.TextChanged += login_username_TextChanged;
            // 
            // nazwa
            // 
            nazwa.AutoSize = true;
            nazwa.BackColor = Color.Transparent;
            nazwa.Cursor = Cursors.Hand;
            nazwa.Font = new Font("Arial Rounded MT Bold", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            nazwa.Location = new Point(13, 46);
            nazwa.Name = "nazwa";
            nazwa.Size = new Size(454, 24);
            nazwa.TabIndex = 1;
            nazwa.Text = "Witaj administatorze w kreatorze Rejestracji";
            nazwa.Click += nazwa_Click;
            // 
            // exit
            // 
            exit.AutoSize = true;
            exit.Cursor = Cursors.Hand;
            exit.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 238);
            exit.Location = new Point(445, 11);
            exit.Name = "exit";
            exit.Size = new Size(19, 20);
            exit.TabIndex = 0;
            exit.Text = "X";
            exit.Click += exit_Click;
            // 
            // rejestracja
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(477, 581);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "rejestracja";
            Text = "rejestracja";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button button_login;
        private Label username;
        private TextBox login_pass;
        private Label password;
        private TextBox login_username;
        private Label nazwa;
        private Label exit;
        private Label opis;
        private ComboBox comboBox1;
        private TextBox telefonbox;
        private Label telefon;
        private TextBox emailbox;
        private Label Email;
        private TextBox surnamebox;
        private Label surname;
        private TextBox namebox;
        private Label name;
        private Label tekstrola;
    }
}