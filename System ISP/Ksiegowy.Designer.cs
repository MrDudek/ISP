namespace System_ISP
{
    partial class Ksiegowy
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
            logout = new PictureBox();
            refresh = new PictureBox();
            panele = new Label();
            panel3 = new Panel();
            sendfaktura = new MaterialSkin.Controls.MaterialButton();
            buttongeneratefaktura = new MaterialSkin.Controls.MaterialButton();
            buttonnewfaktura = new MaterialSkin.Controls.MaterialButton();
            pictureBox1 = new PictureBox();
            glowna_nazwa = new Label();
            panel1 = new Panel();
            dataGridView1 = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            dataGridView2 = new DataGridView();
            label3 = new Label();
            dataGridView3 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)logout).BeginInit();
            ((System.ComponentModel.ISupportInitialize)refresh).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView3).BeginInit();
            SuspendLayout();
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
            // refresh
            // 
            refresh.BackgroundImage = Properties.Resources.Refresh_icon;
            refresh.BackgroundImageLayout = ImageLayout.Stretch;
            refresh.Location = new Point(252, 544);
            refresh.Name = "refresh";
            refresh.Size = new Size(57, 50);
            refresh.TabIndex = 2;
            refresh.TabStop = false;
            refresh.Click += refresh_Click;
            // 
            // panele
            // 
            panele.AutoSize = true;
            panele.Font = new Font("Arial Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 238);
            panele.Location = new Point(12, 17);
            panele.Name = "panele";
            panele.Size = new Size(297, 23);
            panele.TabIndex = 1;
            panele.Text = "Dostępne Panele do zarządzania";
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.GradientActiveCaption;
            panel3.Controls.Add(sendfaktura);
            panel3.Controls.Add(buttongeneratefaktura);
            panel3.Controls.Add(buttonnewfaktura);
            panel3.Controls.Add(refresh);
            panel3.Controls.Add(logout);
            panel3.Controls.Add(panele);
            panel3.Dock = DockStyle.Left;
            panel3.Location = new Point(0, 123);
            panel3.Name = "panel3";
            panel3.Size = new Size(316, 606);
            panel3.TabIndex = 8;
            panel3.Paint += panel3_Paint;
            // 
            // sendfaktura
            // 
            sendfaktura.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            sendfaktura.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            sendfaktura.Depth = 0;
            sendfaktura.HighEmphasis = true;
            sendfaktura.Icon = null;
            sendfaktura.Location = new Point(59, 190);
            sendfaktura.Margin = new Padding(4, 6, 4, 6);
            sendfaktura.MouseState = MaterialSkin.MouseState.HOVER;
            sendfaktura.Name = "sendfaktura";
            sendfaktura.NoAccentTextColor = Color.Empty;
            sendfaktura.Size = new Size(140, 36);
            sendfaktura.TabIndex = 11;
            sendfaktura.Text = "Wyślij fakturę";
            sendfaktura.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            sendfaktura.UseAccentColor = false;
            sendfaktura.UseVisualStyleBackColor = true;
            sendfaktura.Click += sendfaktura_Click;
            // 
            // buttongeneratefaktura
            // 
            buttongeneratefaktura.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            buttongeneratefaktura.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            buttongeneratefaktura.Depth = 0;
            buttongeneratefaktura.HighEmphasis = true;
            buttongeneratefaktura.Icon = null;
            buttongeneratefaktura.Location = new Point(59, 133);
            buttongeneratefaktura.Margin = new Padding(4, 6, 4, 6);
            buttongeneratefaktura.MouseState = MaterialSkin.MouseState.HOVER;
            buttongeneratefaktura.Name = "buttongeneratefaktura";
            buttongeneratefaktura.NoAccentTextColor = Color.Empty;
            buttongeneratefaktura.Size = new Size(153, 36);
            buttongeneratefaktura.TabIndex = 10;
            buttongeneratefaktura.Text = "Generuj fakturę";
            buttongeneratefaktura.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            buttongeneratefaktura.UseAccentColor = false;
            buttongeneratefaktura.UseVisualStyleBackColor = true;
            buttongeneratefaktura.Click += buttongeneratefaktura_Click;
            // 
            // buttonnewfaktura
            // 
            buttonnewfaktura.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            buttonnewfaktura.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            buttonnewfaktura.Depth = 0;
            buttonnewfaktura.HighEmphasis = true;
            buttonnewfaktura.Icon = null;
            buttonnewfaktura.Location = new Point(59, 70);
            buttonnewfaktura.Margin = new Padding(4, 6, 4, 6);
            buttonnewfaktura.MouseState = MaterialSkin.MouseState.HOVER;
            buttonnewfaktura.Name = "buttonnewfaktura";
            buttonnewfaktura.NoAccentTextColor = Color.Empty;
            buttonnewfaktura.Size = new Size(195, 36);
            buttonnewfaktura.TabIndex = 9;
            buttonnewfaktura.Text = "Utwórz nową fakture";
            buttonnewfaktura.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            buttonnewfaktura.UseAccentColor = false;
            buttonnewfaktura.UseVisualStyleBackColor = true;
            buttonnewfaktura.Click += buttonnewfaktura_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BackgroundImage = Properties.Resources.exit;
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(1233, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(19, 23);
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // glowna_nazwa
            // 
            glowna_nazwa.AutoSize = true;
            glowna_nazwa.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point, 238);
            glowna_nazwa.Location = new Point(252, 34);
            glowna_nazwa.Name = "glowna_nazwa";
            glowna_nazwa.Size = new Size(697, 37);
            glowna_nazwa.TabIndex = 1;
            glowna_nazwa.Text = "Witaj w panelu działań księgowego czuj sie jak u sb :)";
            glowna_nazwa.Click += glowna_nazwa_Click;
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
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(336, 193);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(418, 478);
            dataGridView1.TabIndex = 9;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F);
            label1.Location = new Point(432, 150);
            label1.Name = "label1";
            label1.Size = new Size(207, 28);
            label1.TabIndex = 10;
            label1.Text = "Lista utworzych faktur ";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15F);
            label2.Location = new Point(863, 150);
            label2.Name = "label2";
            label2.Size = new Size(294, 28);
            label2.TabIndex = 11;
            label2.Text = "Faktury gotowe do generowania";
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(793, 193);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.Size = new Size(418, 216);
            dataGridView2.TabIndex = 12;
            dataGridView2.CellContentClick += dataGridView2_CellContentClick;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15F);
            label3.Location = new Point(863, 424);
            label3.Name = "label3";
            label3.Size = new Size(255, 28);
            label3.TabIndex = 13;
            label3.Text = "Faktury gotowe do wysłania";
            label3.Click += label3_Click;
            // 
            // dataGridView3
            // 
            dataGridView3.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView3.Location = new Point(793, 465);
            dataGridView3.Name = "dataGridView3";
            dataGridView3.Size = new Size(418, 206);
            dataGridView3.TabIndex = 14;
            dataGridView3.CellContentClick += dataGridView3_CellContentClick;
            // 
            // Ksiegowy
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1264, 729);
            Controls.Add(dataGridView3);
            Controls.Add(label3);
            Controls.Add(dataGridView2);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Controls.Add(panel3);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Ksiegowy";
            Text = "Ksiegowy";
            ((System.ComponentModel.ISupportInitialize)logout).EndInit();
            ((System.ComponentModel.ISupportInitialize)refresh).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ToolTip toolTip1;
        private PictureBox logout;
        private PictureBox refresh;
        private Label panele;
        private Panel panel3;
        private PictureBox pictureBox1;
        private Label glowna_nazwa;
        private Panel panel1;
        private MaterialSkin.Controls.MaterialButton buttonnewfaktura;
        private MaterialSkin.Controls.MaterialButton buttongeneratefaktura;
        private MaterialSkin.Controls.MaterialButton sendfaktura;
        private DataGridView dataGridView1;
        private Label label1;
        private Label label2;
        private DataGridView dataGridView2;
        private Label label3;
        private DataGridView dataGridView3;
    }
}