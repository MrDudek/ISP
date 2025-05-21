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
            listauserow = new Label();
            listapracownikow = new Label();
            listapracownikowtabela = new DataGridView();
            tabelka = new Panel();
            dataGridView1 = new DataGridView();
            toolTip1 = new ToolTip(components);
            logout = new PictureBox();
            panele = new Label();
            refresh = new PictureBox();
            panel3 = new Panel();
            label1 = new Label();
            materialButton1 = new MaterialSkin.Controls.MaterialButton();
            newuserbuttonadd = new MaterialSkin.Controls.MaterialButton();
            ksiegowybutton = new MaterialSkin.Controls.MaterialButton();
            serwisantbutton = new MaterialSkin.Controls.MaterialButton();
            konsultantbutton = new MaterialSkin.Controls.MaterialButton();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            data = new DateTimePicker();
            glowna_nazwa = new Label();
            materialButton2 = new MaterialSkin.Controls.MaterialButton();
            ((System.ComponentModel.ISupportInitialize)listapracownikowtabela).BeginInit();
            tabelka.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)logout).BeginInit();
            ((System.ComponentModel.ISupportInitialize)refresh).BeginInit();
            panel3.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // listauserow
            // 
            listauserow.AutoSize = true;
            listauserow.Font = new Font("Tahoma", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 238);
            listauserow.Location = new Point(21, 0);
            listauserow.Name = "listauserow";
            listauserow.Size = new Size(192, 25);
            listauserow.TabIndex = 0;
            listauserow.Text = "Lista Użytkownikow";
            listauserow.Click += label1_Click_1;
            // 
            // listapracownikow
            // 
            listapracownikow.AutoSize = true;
            listapracownikow.Font = new Font("Tahoma", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 238);
            listapracownikow.Location = new Point(21, 318);
            listapracownikow.Name = "listapracownikow";
            listapracownikow.Size = new Size(183, 25);
            listapracownikow.TabIndex = 2;
            listapracownikow.Text = "Lista Pracowników";
            listapracownikow.Click += label1_Click_2;
            // 
            // listapracownikowtabela
            // 
            listapracownikowtabela.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            listapracownikowtabela.Location = new Point(21, 346);
            listapracownikowtabela.Name = "listapracownikowtabela";
            listapracownikowtabela.Size = new Size(909, 242);
            listapracownikowtabela.TabIndex = 3;
            listapracownikowtabela.CellContentClick += listapracownikowtabela_CellContentClick;
            // 
            // tabelka
            // 
            tabelka.Controls.Add(dataGridView1);
            tabelka.Controls.Add(listapracownikowtabela);
            tabelka.Controls.Add(listapracownikow);
            tabelka.Controls.Add(listauserow);
            tabelka.Location = new Point(322, 129);
            tabelka.Name = "tabelka";
            tabelka.Size = new Size(942, 600);
            tabelka.TabIndex = 5;
            tabelka.Paint += tabelka_Paint;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(21, 28);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(909, 270);
            dataGridView1.TabIndex = 1;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // toolTip1
            // 
            toolTip1.Popup += toolTip1_Popup;
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
            // panele
            // 
            panele.AutoSize = true;
            panele.Font = new Font("Arial Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 238);
            panele.Location = new Point(64, 18);
            panele.Name = "panele";
            panele.Size = new Size(189, 23);
            panele.TabIndex = 1;
            panele.Text = "Panel Administatora";
            panele.Click += panele_Click;
            // 
            // refresh
            // 
            refresh.BackgroundImage = Properties.Resources.Refresh_icon;
            refresh.BackgroundImageLayout = ImageLayout.Stretch;
            refresh.Location = new Point(256, 544);
            refresh.Name = "refresh";
            refresh.Size = new Size(57, 50);
            refresh.TabIndex = 2;
            refresh.TabStop = false;
            refresh.Click += refresh_Click;
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.GradientActiveCaption;
            panel3.Controls.Add(materialButton2);
            panel3.Controls.Add(label1);
            panel3.Controls.Add(materialButton1);
            panel3.Controls.Add(newuserbuttonadd);
            panel3.Controls.Add(ksiegowybutton);
            panel3.Controls.Add(serwisantbutton);
            panel3.Controls.Add(konsultantbutton);
            panel3.Controls.Add(refresh);
            panel3.Controls.Add(logout);
            panel3.Controls.Add(panele);
            panel3.Dock = DockStyle.Left;
            panel3.Location = new Point(0, 123);
            panel3.Name = "panel3";
            panel3.Size = new Size(316, 606);
            panel3.TabIndex = 3;
            panel3.Paint += panel3_Paint;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label1.Location = new Point(38, 366);
            label1.Name = "label1";
            label1.Size = new Size(255, 23);
            label1.TabIndex = 12;
            label1.Text = "Zarządzanie użytkownikami";
            label1.Click += label1_Click_3;
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
            materialButton1.Location = new Point(64, 476);
            materialButton1.Margin = new Padding(4, 6, 4, 6);
            materialButton1.MouseState = MaterialSkin.MouseState.HOVER;
            materialButton1.Name = "materialButton1";
            materialButton1.NoAccentTextColor = Color.Empty;
            materialButton1.Size = new Size(194, 59);
            materialButton1.TabIndex = 11;
            materialButton1.Text = "Usuwanie użytkowników";
            materialButton1.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            materialButton1.UseAccentColor = false;
            materialButton1.UseVisualStyleBackColor = true;
            materialButton1.Click += materialButton1_Click;
            // 
            // newuserbuttonadd
            // 
            newuserbuttonadd.AutoSize = false;
            newuserbuttonadd.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            newuserbuttonadd.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            newuserbuttonadd.Depth = 0;
            newuserbuttonadd.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            newuserbuttonadd.HighEmphasis = true;
            newuserbuttonadd.Icon = null;
            newuserbuttonadd.Location = new Point(64, 405);
            newuserbuttonadd.Margin = new Padding(4, 6, 4, 6);
            newuserbuttonadd.MouseState = MaterialSkin.MouseState.HOVER;
            newuserbuttonadd.Name = "newuserbuttonadd";
            newuserbuttonadd.NoAccentTextColor = Color.Empty;
            newuserbuttonadd.Size = new Size(194, 59);
            newuserbuttonadd.TabIndex = 10;
            newuserbuttonadd.Text = "Rejestracja nowego użytkownika";
            newuserbuttonadd.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            newuserbuttonadd.UseAccentColor = false;
            newuserbuttonadd.UseVisualStyleBackColor = true;
            newuserbuttonadd.Click += newuserbuttonadd_Click;
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
            ksiegowybutton.Location = new Point(64, 198);
            ksiegowybutton.Margin = new Padding(4, 6, 4, 6);
            ksiegowybutton.MouseState = MaterialSkin.MouseState.HOVER;
            ksiegowybutton.Name = "ksiegowybutton";
            ksiegowybutton.NoAccentTextColor = Color.Empty;
            ksiegowybutton.Size = new Size(194, 59);
            ksiegowybutton.TabIndex = 9;
            ksiegowybutton.Text = "Księgowy";
            ksiegowybutton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            ksiegowybutton.UseAccentColor = false;
            ksiegowybutton.UseVisualStyleBackColor = true;
            ksiegowybutton.Click += ksiegowybutton_Click;
            // 
            // serwisantbutton
            // 
            serwisantbutton.AutoSize = false;
            serwisantbutton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            serwisantbutton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            serwisantbutton.Depth = 0;
            serwisantbutton.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            serwisantbutton.HighEmphasis = true;
            serwisantbutton.Icon = null;
            serwisantbutton.Location = new Point(64, 127);
            serwisantbutton.Margin = new Padding(4, 6, 4, 6);
            serwisantbutton.MouseState = MaterialSkin.MouseState.HOVER;
            serwisantbutton.Name = "serwisantbutton";
            serwisantbutton.NoAccentTextColor = Color.Empty;
            serwisantbutton.Size = new Size(194, 59);
            serwisantbutton.TabIndex = 8;
            serwisantbutton.Text = "Serwisant";
            serwisantbutton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            serwisantbutton.UseAccentColor = false;
            serwisantbutton.UseVisualStyleBackColor = true;
            serwisantbutton.Click += serwisantbutton_Click;
            // 
            // konsultantbutton
            // 
            konsultantbutton.AutoSize = false;
            konsultantbutton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            konsultantbutton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            konsultantbutton.Depth = 0;
            konsultantbutton.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            konsultantbutton.HighEmphasis = true;
            konsultantbutton.Icon = null;
            konsultantbutton.Location = new Point(64, 56);
            konsultantbutton.Margin = new Padding(4, 6, 4, 6);
            konsultantbutton.MouseState = MaterialSkin.MouseState.HOVER;
            konsultantbutton.Name = "konsultantbutton";
            konsultantbutton.NoAccentTextColor = Color.Empty;
            konsultantbutton.Size = new Size(194, 59);
            konsultantbutton.TabIndex = 7;
            konsultantbutton.Text = "   Konsultant   ";
            konsultantbutton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            konsultantbutton.UseAccentColor = false;
            konsultantbutton.UseVisualStyleBackColor = true;
            konsultantbutton.Click += konsultantbutton_Click;
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
            pictureBox1.Location = new Point(1236, 16);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(16, 19);
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // data
            // 
            data.Location = new Point(12, 12);
            data.Name = "data";
            data.Size = new Size(200, 23);
            data.TabIndex = 4;
            data.ValueChanged += data_ValueChanged;
            // 
            // glowna_nazwa
            // 
            glowna_nazwa.AutoSize = true;
            glowna_nazwa.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            glowna_nazwa.Location = new Point(343, 61);
            glowna_nazwa.Name = "glowna_nazwa";
            glowna_nazwa.Size = new Size(564, 37);
            glowna_nazwa.TabIndex = 1;
            glowna_nazwa.Text = "Witaj Administratorze w swoim królestwie";
            glowna_nazwa.Click += label1_Click;
            // 
            // materialButton2
            // 
            materialButton2.AutoSize = false;
            materialButton2.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            materialButton2.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            materialButton2.Depth = 0;
            materialButton2.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            materialButton2.HighEmphasis = true;
            materialButton2.Icon = null;
            materialButton2.Location = new Point(64, 269);
            materialButton2.Margin = new Padding(4, 6, 4, 6);
            materialButton2.MouseState = MaterialSkin.MouseState.HOVER;
            materialButton2.Name = "materialButton2";
            materialButton2.NoAccentTextColor = Color.Empty;
            materialButton2.Size = new Size(194, 59);
            materialButton2.TabIndex = 13;
            materialButton2.Text = "Użytkownik";
            materialButton2.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            materialButton2.UseAccentColor = false;
            materialButton2.UseVisualStyleBackColor = true;
            materialButton2.Click += materialButton2_Click;
            // 
            // Adminmenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1264, 729);
            Controls.Add(tabelka);
            Controls.Add(panel3);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Adminmenu";
            Text = "Adminmenu";
            Load += Adminmenu_Load;
            ((System.ComponentModel.ISupportInitialize)listapracownikowtabela).EndInit();
            tabelka.ResumeLayout(false);
            tabelka.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)logout).EndInit();
            ((System.ComponentModel.ISupportInitialize)refresh).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label listauserow;
        private Label listapracownikow;
        private DataGridView listapracownikowtabela;
        private Panel tabelka;
        private DataGridView dataGridView1;
        private ToolTip toolTip1;
        private Label panele;
        private PictureBox logout;
        private PictureBox refresh;
        private Panel panel3;
        private Label label1;
        private MaterialSkin.Controls.MaterialButton materialButton1;
        private MaterialSkin.Controls.MaterialButton newuserbuttonadd;
        private MaterialSkin.Controls.MaterialButton ksiegowybutton;
        private MaterialSkin.Controls.MaterialButton serwisantbutton;
        private MaterialSkin.Controls.MaterialButton konsultantbutton;
        private Panel panel1;
        private PictureBox pictureBox1;
        private DateTimePicker data;
        private Label glowna_nazwa;
        private MaterialSkin.Controls.MaterialButton materialButton2;
    }
}