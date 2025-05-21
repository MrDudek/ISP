namespace System_ISP
{
    partial class user
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
            toolTip1 = new ToolTip(components);
            panel3 = new Panel();
            materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            label1 = new Label();
            materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            refresh = new PictureBox();
            logout = new PictureBox();
            panele = new Label();
            ksiegowybutton = new MaterialSkin.Controls.MaterialButton();
            toolTip2 = new ToolTip(components);
            panel2 = new Panel();
            pictureBox1 = new PictureBox();
            glowna_nazwa = new Label();
            tabelka = new Panel();
            label7 = new Label();
            label6 = new Label();
            materialButton1 = new MaterialSkin.Controls.MaterialButton();
            dataGridView2 = new DataGridView();
            dataGridView1 = new DataGridView();
            panel1 = new Panel();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)refresh).BeginInit();
            ((System.ComponentModel.ISupportInitialize)logout).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            tabelka.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.GradientActiveCaption;
            panel3.Controls.Add(materialLabel5);
            panel3.Controls.Add(label5);
            panel3.Controls.Add(label4);
            panel3.Controls.Add(label3);
            panel3.Controls.Add(materialLabel4);
            panel3.Controls.Add(materialLabel3);
            panel3.Controls.Add(label1);
            panel3.Controls.Add(materialLabel1);
            panel3.Controls.Add(refresh);
            panel3.Controls.Add(logout);
            panel3.Controls.Add(panele);
            panel3.Dock = DockStyle.Left;
            panel3.Location = new Point(0, 123);
            panel3.Name = "panel3";
            panel3.Size = new Size(319, 614);
            panel3.TabIndex = 8;
            // 
            // materialLabel5
            // 
            materialLabel5.AutoSize = true;
            materialLabel5.Depth = 0;
            materialLabel5.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel5.Location = new Point(64, 205);
            materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel5.Name = "materialLabel5";
            materialLabel5.Size = new Size(141, 19);
            materialLabel5.TabIndex = 14;
            materialLabel5.Text = "Taryfa użytkownika";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(64, 236);
            label5.Name = "label5";
            label5.Size = new Size(158, 15);
            label5.TabIndex = 13;
            label5.Text = "Tu bedzie wyswietlana taryfa";
            label5.Click += label5_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(64, 180);
            label4.Name = "label4";
            label4.Size = new Size(165, 15);
            label4.TabIndex = 12;
            label4.Text = "Tu bedzie wyswietlany telefon";
            label4.Click += label4_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(64, 121);
            label3.Name = "label3";
            label3.Size = new Size(160, 15);
            label3.TabIndex = 11;
            label3.Text = "Tu bedzie wyswietlany email ";
            label3.Click += label3_Click;
            // 
            // materialLabel4
            // 
            materialLabel4.AutoSize = true;
            materialLabel4.Depth = 0;
            materialLabel4.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel4.Location = new Point(64, 148);
            materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel4.Name = "materialLabel4";
            materialLabel4.Size = new Size(148, 19);
            materialLabel4.TabIndex = 10;
            materialLabel4.Text = "Telefon użytkownika";
            // 
            // materialLabel3
            // 
            materialLabel3.AutoSize = true;
            materialLabel3.Depth = 0;
            materialLabel3.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel3.Location = new Point(64, 93);
            materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel3.Name = "materialLabel3";
            materialLabel3.Size = new Size(134, 19);
            materialLabel3.TabIndex = 9;
            materialLabel3.Text = "Email użytkownika";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(64, 69);
            label1.Name = "label1";
            label1.Size = new Size(208, 15);
            label1.TabIndex = 6;
            label1.Text = "Tu bedzie wyswietlane imie i nazwisko";
            label1.Click += label1_Click;
            // 
            // materialLabel1
            // 
            materialLabel1.AutoSize = true;
            materialLabel1.Depth = 0;
            materialLabel1.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel1.Location = new Point(64, 36);
            materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel1.Name = "materialLabel1";
            materialLabel1.Size = new Size(112, 19);
            materialLabel1.TabIndex = 5;
            materialLabel1.Text = "Imię i Nazwisko";
            materialLabel1.Click += materialLabel1_Click;
            // 
            // refresh
            // 
            refresh.BackgroundImage = Properties.Resources.Refresh_icon;
            refresh.BackgroundImageLayout = ImageLayout.Stretch;
            refresh.Location = new Point(250, 552);
            refresh.Name = "refresh";
            refresh.Size = new Size(57, 50);
            refresh.TabIndex = 2;
            refresh.TabStop = false;
            // 
            // logout
            // 
            logout.BackColor = Color.Transparent;
            logout.BackgroundImage = Properties.Resources.logout3;
            logout.BackgroundImageLayout = ImageLayout.Stretch;
            logout.Cursor = Cursors.Hand;
            logout.Location = new Point(12, 552);
            logout.Name = "logout";
            logout.Size = new Size(51, 50);
            logout.TabIndex = 4;
            logout.TabStop = false;
            toolTip2.SetToolTip(logout, "Wyloguj z systemu");
            logout.Click += logout_Click;
            // 
            // panele
            // 
            panele.AutoSize = true;
            panele.Font = new Font("Arial Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 238);
            panele.Location = new Point(60, 6);
            panele.Name = "panele";
            panele.Size = new Size(171, 23);
            panele.TabIndex = 1;
            panele.Text = "Dane użytkownika";
            panele.Click += panele_Click;
            // 
            // ksiegowybutton
            // 
            ksiegowybutton.AutoSize = false;
            ksiegowybutton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ksiegowybutton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            ksiegowybutton.Depth = 0;
            ksiegowybutton.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            ksiegowybutton.HighEmphasis = true;
            ksiegowybutton.Icon = null;
            ksiegowybutton.Location = new Point(106, 527);
            ksiegowybutton.Margin = new Padding(4, 6, 4, 6);
            ksiegowybutton.MouseState = MaterialSkin.MouseState.HOVER;
            ksiegowybutton.Name = "ksiegowybutton";
            ksiegowybutton.NoAccentTextColor = Color.Empty;
            ksiegowybutton.Size = new Size(194, 59);
            ksiegowybutton.TabIndex = 9;
            ksiegowybutton.Text = "Pobierz PDF";
            ksiegowybutton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            ksiegowybutton.UseAccentColor = false;
            ksiegowybutton.UseVisualStyleBackColor = true;
            ksiegowybutton.Click += ksiegowybutton_Click;
            // 
            // panel2
            // 
            panel2.Location = new Point(299, 129);
            panel2.Name = "panel2";
            panel2.Size = new Size(8, 8);
            panel2.TabIndex = 7;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BackgroundImage = Properties.Resources.exit;
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(1236, 16);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(16, 19);
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // glowna_nazwa
            // 
            glowna_nazwa.AutoSize = true;
            glowna_nazwa.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            glowna_nazwa.Location = new Point(343, 61);
            glowna_nazwa.Name = "glowna_nazwa";
            glowna_nazwa.Size = new Size(522, 37);
            glowna_nazwa.TabIndex = 1;
            glowna_nazwa.Text = "Witaj Użytkowniku w swoim królestwie";
            // 
            // tabelka
            // 
            tabelka.Controls.Add(label7);
            tabelka.Controls.Add(label6);
            tabelka.Controls.Add(materialButton1);
            tabelka.Controls.Add(dataGridView2);
            tabelka.Controls.Add(dataGridView1);
            tabelka.Controls.Add(ksiegowybutton);
            tabelka.Location = new Point(343, 129);
            tabelka.Name = "tabelka";
            tabelka.Size = new Size(909, 600);
            tabelka.TabIndex = 9;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Arial Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label7.Location = new Point(580, 25);
            label7.Name = "label7";
            label7.Size = new Size(208, 23);
            label7.TabIndex = 16;
            label7.Text = "Zgłoszenia Serwisowe";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label6.Location = new Point(135, 26);
            label6.Name = "label6";
            label6.Size = new Size(121, 23);
            label6.TabIndex = 15;
            label6.Text = "Moje faktury";
            // 
            // materialButton1
            // 
            materialButton1.AutoSize = false;
            materialButton1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            materialButton1.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            materialButton1.Depth = 0;
            materialButton1.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            materialButton1.HighEmphasis = true;
            materialButton1.Icon = null;
            materialButton1.Location = new Point(580, 527);
            materialButton1.Margin = new Padding(4, 6, 4, 6);
            materialButton1.MouseState = MaterialSkin.MouseState.HOVER;
            materialButton1.Name = "materialButton1";
            materialButton1.NoAccentTextColor = Color.Empty;
            materialButton1.Size = new Size(194, 59);
            materialButton1.TabIndex = 12;
            materialButton1.Text = "Utwórz nowe zgłoszenie";
            materialButton1.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            materialButton1.UseAccentColor = false;
            materialButton1.UseVisualStyleBackColor = true;
            materialButton1.Click += materialButton1_Click;
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(467, 63);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.Size = new Size(411, 455);
            dataGridView2.TabIndex = 11;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(5, 63);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(411, 455);
            dataGridView1.TabIndex = 10;
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
            // user
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1264, 737);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(tabelka);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "user";
            Text = "user";
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)refresh).EndInit();
            ((System.ComponentModel.ISupportInitialize)logout).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            tabelka.ResumeLayout(false);
            tabelka.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private ToolTip toolTip1;
        private Panel panel3;
        private MaterialSkin.Controls.MaterialButton ksiegowybutton;
        private PictureBox refresh;
        private PictureBox logout;
        private ToolTip toolTip2;
        private Label panele;
        private Panel panel2;
        private PictureBox pictureBox1;
        private Label glowna_nazwa;
        private Panel tabelka;
        private Panel panel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private Label label5;
        private Label label4;
        private Label label3;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private Label label1;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private Label label7;
        private Label label6;
        private MaterialSkin.Controls.MaterialButton materialButton1;
        private DataGridView dataGridView2;
        private DataGridView dataGridView1;
    }
}