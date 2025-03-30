namespace System_ISP
{
    partial class Adminmenu
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
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            data = new DateTimePicker();
            glowna_nazwa = new Label();
            panel2 = new Panel();
            panel3 = new Panel();
            logout = new PictureBox();
            Ksiegowy = new Button();
            Serwisant = new Button();
            panele = new Label();
            Konsultant = new Button();
            toolTip1 = new ToolTip(components);
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)logout).BeginInit();
            SuspendLayout();
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
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
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
            pictureBox1.Click += pictureBox1_Click;
            // 
            // data
            // 
            data.Location = new Point(12, 16);
            data.Name = "data";
            data.Size = new Size(200, 23);
            data.TabIndex = 4;
            data.ValueChanged += data_ValueChanged;
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
            glowna_nazwa.Click += label1_Click;
            // 
            // panel2
            // 
            panel2.Location = new Point(349, 129);
            panel2.Name = "panel2";
            panel2.Size = new Size(8, 8);
            panel2.TabIndex = 2;
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.GradientActiveCaption;
            panel3.Controls.Add(logout);
            panel3.Controls.Add(Ksiegowy);
            panel3.Controls.Add(Serwisant);
            panel3.Controls.Add(panele);
            panel3.Controls.Add(Konsultant);
            panel3.Dock = DockStyle.Left;
            panel3.Location = new Point(0, 123);
            panel3.Name = "panel3";
            panel3.Size = new Size(316, 606);
            panel3.TabIndex = 3;
            panel3.Paint += panel3_Paint;
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
            // Ksiegowy
            // 
            Ksiegowy.BackColor = Color.DarkTurquoise;
            Ksiegowy.BackgroundImageLayout = ImageLayout.None;
            Ksiegowy.FlatStyle = FlatStyle.Flat;
            Ksiegowy.Font = new Font("Arial Black", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 238);
            Ksiegowy.Location = new Point(64, 268);
            Ksiegowy.Name = "Ksiegowy";
            Ksiegowy.Size = new Size(194, 59);
            Ksiegowy.TabIndex = 3;
            Ksiegowy.Text = "Księgowy";
            Ksiegowy.UseVisualStyleBackColor = false;
            Ksiegowy.Click += Ksiegowy_Click;
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
            // toolTip1
            // 
            toolTip1.Popup += toolTip1_Popup;
            // 
            // Adminmenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1264, 729);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Adminmenu";
            Text = "Adminmenu";
            Load += Adminmenu_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)logout).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Label glowna_nazwa;
        private Panel panel3;
        private DateTimePicker data;
        private Label panele;
        private Button Konsultant;
        private Button Admin;
        private Button Ksiegowy;
        private Button Serwisant;
        private PictureBox logout;
        private ToolTip toolTip1;
        private PictureBox pictureBox1;
    }
}