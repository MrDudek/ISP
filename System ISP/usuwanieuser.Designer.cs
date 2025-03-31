namespace System_ISP
{
    partial class usuwanieuser
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
            uzytkownicy = new ComboBox();
            nazwa = new Label();
            Delete = new Button();
            exit = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ButtonFace;
            panel1.BackgroundImage = Properties.Resources.tło;
            panel1.Controls.Add(uzytkownicy);
            panel1.Controls.Add(nazwa);
            panel1.Controls.Add(Delete);
            panel1.Controls.Add(exit);
            panel1.ForeColor = SystemColors.ActiveCaptionText;
            panel1.Location = new Point(0, -1);
            panel1.Name = "panel1";
            panel1.Size = new Size(479, 585);
            panel1.TabIndex = 1;
            // 
            // uzytkownicy
            // 
            uzytkownicy.FormattingEnabled = true;
            uzytkownicy.Location = new Point(100, 104);
            uzytkownicy.Name = "uzytkownicy";
            uzytkownicy.Size = new Size(265, 23);
            uzytkownicy.TabIndex = 9;
            uzytkownicy.SelectedIndexChanged += uzytkownicy_SelectedIndexChanged;
            // 
            // nazwa
            // 
            nazwa.AutoSize = true;
            nazwa.BackColor = Color.Transparent;
            nazwa.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 238);
            nazwa.Location = new Point(100, 67);
            nazwa.Name = "nazwa";
            nazwa.Size = new Size(265, 25);
            nazwa.TabIndex = 8;
            nazwa.Text = "Wybierz i usuń Użytkownika";
            // 
            // Delete
            // 
            Delete.BackColor = SystemColors.Desktop;
            Delete.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 238);
            Delete.ForeColor = SystemColors.Control;
            Delete.Location = new Point(143, 455);
            Delete.Name = "Delete";
            Delete.Size = new Size(152, 44);
            Delete.TabIndex = 7;
            Delete.Text = "Uśuń";
            Delete.UseVisualStyleBackColor = false;
            Delete.Click += Delete_Click;
            // 
            // exit
            // 
            exit.AutoSize = true;
            exit.BackColor = Color.Transparent;
            exit.Cursor = Cursors.Hand;
            exit.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 238);
            exit.Location = new Point(445, 11);
            exit.Name = "exit";
            exit.Size = new Size(19, 20);
            exit.TabIndex = 0;
            exit.Text = "X";
            exit.Click += exit_Click;
            // 
            // usuwanieuser
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(477, 581);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "usuwanieuser";
            Text = "usuwanieuser";
            Load += usuwanieuser_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private CheckBox checkBox_showpass;
        private Button Delete;
        private Label username;
        private TextBox login_pass;
        private Label password;
        private TextBox login_username;
        private Label exit;
        private Label nazwa;
        private ComboBox uzytkownicy;
    }
}