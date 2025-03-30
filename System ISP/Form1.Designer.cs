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
            panel1 = new Panel();
            checkBox_showpass = new CheckBox();
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
            panel1.Controls.Add(checkBox_showpass);
            panel1.Controls.Add(button_login);
            panel1.Controls.Add(username);
            panel1.Controls.Add(login_pass);
            panel1.Controls.Add(password);
            panel1.Controls.Add(login_username);
            panel1.Controls.Add(nazwa);
            panel1.Controls.Add(exit);
            panel1.ForeColor = SystemColors.ActiveCaptionText;
            panel1.Location = new Point(-1, -2);
            panel1.Name = "panel1";
            panel1.Size = new Size(477, 581);
            panel1.TabIndex = 0;
            // 
            // checkBox_showpass
            // 
            checkBox_showpass.AutoSize = true;
            checkBox_showpass.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 238);
            checkBox_showpass.Location = new Point(27, 316);
            checkBox_showpass.Name = "checkBox_showpass";
            checkBox_showpass.Padding = new Padding(1);
            checkBox_showpass.Size = new Size(107, 26);
            checkBox_showpass.TabIndex = 10;
            checkBox_showpass.Text = "Pokaż hasło";
            checkBox_showpass.UseVisualStyleBackColor = true;
            checkBox_showpass.CheckedChanged += checkBox_showpass_CheckedChanged;
            // 
            // button_login
            // 
            button_login.BackColor = SystemColors.Desktop;
            button_login.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 238);
            button_login.ForeColor = SystemColors.Control;
            button_login.Location = new Point(151, 349);
            button_login.Name = "button_login";
            button_login.Size = new Size(152, 44);
            button_login.TabIndex = 7;
            button_login.Text = "Logowanie";
            button_login.UseVisualStyleBackColor = false;
            button_login.Click += button_login_Click;
            // 
            // username
            // 
            username.AutoSize = true;
            username.Cursor = Cursors.Hand;
            username.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 238);
            username.ForeColor = SystemColors.ActiveCaptionText;
            username.Location = new Point(27, 168);
            username.Name = "username";
            username.Size = new Size(172, 22);
            username.TabIndex = 6;
            username.Text = "Nazwa Użytkownika";
            username.Click += label3_Click;
            // 
            // login_pass
            // 
            login_pass.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 238);
            login_pass.Location = new Point(27, 281);
            login_pass.Name = "login_pass";
            login_pass.Size = new Size(427, 29);
            login_pass.TabIndex = 5;
            login_pass.TextChanged += login_pass_TextChanged;
            // 
            // password
            // 
            password.AutoSize = true;
            password.Cursor = Cursors.Hand;
            password.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 238);
            password.Location = new Point(27, 247);
            password.Name = "password";
            password.Size = new Size(58, 22);
            password.TabIndex = 4;
            password.Text = "Hasło";
            password.Click += label4_Click;
            // 
            // login_username
            // 
            login_username.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 238);
            login_username.Location = new Point(27, 203);
            login_username.Name = "login_username";
            login_username.Size = new Size(427, 29);
            login_username.TabIndex = 3;
            login_username.TextChanged += textBox1_TextChanged;
            // 
            // nazwa
            // 
            nazwa.AutoSize = true;
            nazwa.BackColor = Color.Transparent;
            nazwa.Cursor = Cursors.Hand;
            nazwa.Font = new Font("Arial Rounded MT Bold", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            nazwa.Location = new Point(3, 69);
            nazwa.Name = "nazwa";
            nazwa.Size = new Size(466, 24);
            nazwa.TabIndex = 1;
            nazwa.Text = "Witamy w systemie zarządzania usługami ISP";
            nazwa.Click += label2_Click_1;
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
            exit.Click += label1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(475, 577);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label exit;
        private Label nazwa;
        private TextBox login_pass;
        private Label password;
        private TextBox login_username;
        private Label username;
        private Button button_login;
        private CheckBox checkBox_showpass;
    }
}
