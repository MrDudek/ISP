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
            panel1 = new Panel();
            data = new DateTimePicker();
            glowna_nazwa = new Label();
            panel2 = new Panel();
            panel3 = new Panel();
            Home = new Button();
            Ksiegowy = new Button();
            Serwisant = new Button();
            panele = new Label();
            Konsultant = new Button();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.GradientActiveCaption;
            panel1.Controls.Add(data);
            panel1.Controls.Add(glowna_nazwa);
            panel1.Cursor = Cursors.Hand;
            panel1.Dock = DockStyle.Top;
            panel1.ForeColor = SystemColors.ControlText;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1264, 123);
            panel1.TabIndex = 0;
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
            panel3.Controls.Add(Home);
            panel3.Controls.Add(Ksiegowy);
            panel3.Controls.Add(Serwisant);
            panel3.Controls.Add(panele);
            panel3.Controls.Add(Konsultant);
            panel3.Dock = DockStyle.Left;
            panel3.Location = new Point(0, 123);
            panel3.Name = "panel3";
            panel3.Size = new Size(316, 606);
            panel3.TabIndex = 3;
            // 
            // Home
            // 
            Home.BackColor = Color.DarkTurquoise;
            Home.BackgroundImageLayout = ImageLayout.None;
            Home.FlatStyle = FlatStyle.Flat;
            Home.Font = new Font("Arial Black", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 238);
            Home.Location = new Point(64, 91);
            Home.Name = "Home";
            Home.Size = new Size(194, 59);
            Home.TabIndex = 4;
            Home.Text = "Strona Główna";
            Home.UseVisualStyleBackColor = false;
            // 
            // Ksiegowy
            // 
            Ksiegowy.BackColor = Color.DarkTurquoise;
            Ksiegowy.BackgroundImageLayout = ImageLayout.None;
            Ksiegowy.FlatStyle = FlatStyle.Flat;
            Ksiegowy.Font = new Font("Arial Black", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 238);
            Ksiegowy.Location = new Point(64, 401);
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
            Serwisant.Location = new Point(64, 290);
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
            Konsultant.Location = new Point(64, 186);
            Konsultant.Name = "Konsultant";
            Konsultant.Size = new Size(194, 59);
            Konsultant.TabIndex = 0;
            Konsultant.Text = "Konsultant";
            Konsultant.UseVisualStyleBackColor = false;
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
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
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
        private Button Home;
        private Button Ksiegowy;
        private Button Serwisant;
    }
}