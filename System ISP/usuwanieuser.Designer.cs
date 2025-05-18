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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(usuwanieuser));
            panel1 = new Panel();
            exit = new Label();
            uzytkownicy = new ComboBox();
            nazwa = new Label();
            materialButton1 = new MaterialSkin.Controls.MaterialButton();
            pictureBox1 = new PictureBox();
            label2 = new Label();
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
            panel1.Location = new Point(0, -1);
            panel1.Name = "panel1";
            panel1.Size = new Size(469, 585);
            panel1.TabIndex = 1;
            // 
            // exit
            // 
            exit.BackColor = Color.Transparent;
            exit.Cursor = Cursors.Hand;
            exit.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 238);
            exit.Location = new Point(922, 9);
            exit.Name = "exit";
            exit.Size = new Size(19, 20);
            exit.TabIndex = 0;
            exit.Text = "X";
            exit.Click += exit_Click;
            // 
            // uzytkownicy
            // 
            uzytkownicy.FormattingEnabled = true;
            uzytkownicy.Location = new Point(588, 112);
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
            nazwa.Location = new Point(588, 75);
            nazwa.Name = "nazwa";
            nazwa.Size = new Size(265, 25);
            nazwa.TabIndex = 8;
            nazwa.Text = "Wybierz i usuń Użytkownika";
            // 
            // materialButton1
            // 
            materialButton1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            materialButton1.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            materialButton1.Depth = 0;
            materialButton1.HighEmphasis = true;
            materialButton1.Icon = null;
            materialButton1.Location = new Point(588, 180);
            materialButton1.Margin = new Padding(4, 6, 4, 6);
            materialButton1.MouseState = MaterialSkin.MouseState.HOVER;
            materialButton1.Name = "materialButton1";
            materialButton1.NoAccentTextColor = Color.Empty;
            materialButton1.Size = new Size(166, 36);
            materialButton1.TabIndex = 10;
            materialButton1.Text = "Usuń Użytkownika";
            materialButton1.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            materialButton1.UseAccentColor = false;
            materialButton1.UseVisualStyleBackColor = true;
            materialButton1.Click += materialButton1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(38, 76);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(387, 371);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label2.Location = new Point(475, 489);
            label2.MaximumSize = new Size(475, 0);
            label2.Name = "label2";
            label2.Size = new Size(475, 60);
            label2.TabIndex = 13;
            label2.Text = "Pamiętaj! Usunięcie użytkownika powoduje utrate wszystkich jego danych w systemie. Upewnij się że użytkownik nie korzysta już z naszych usług!";
            label2.Click += label2_Click;
            // 
            // usuwanieuser
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(953, 581);
            Controls.Add(label2);
            Controls.Add(exit);
            Controls.Add(materialButton1);
            Controls.Add(uzytkownicy);
            Controls.Add(panel1);
            Controls.Add(nazwa);
            FormBorderStyle = FormBorderStyle.None;
            Name = "usuwanieuser";
            Text = "usuwanieuser";
            Load += usuwanieuser_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private CheckBox checkBox_showpass;
        private Label username;
        private TextBox login_pass;
        private Label password;
        private TextBox login_username;
        private Label exit;
        private Label nazwa;
        private ComboBox uzytkownicy;
        private MaterialSkin.Controls.MaterialButton materialButton1;
        private PictureBox pictureBox1;
        private Label label2;
    }
}