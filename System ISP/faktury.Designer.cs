namespace System_ISP
{
    partial class faktury
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(faktury));
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            nametekst = new MaterialSkin.Controls.MaterialLabel();
            nazwa = new Label();
            materialButton1 = new MaterialSkin.Controls.MaterialButton();
            comboBox1 = new ComboBox();
            materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            comboBox2 = new ComboBox();
            materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            textBox2 = new TextBox();
            comboBox3 = new ComboBox();
            materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            materialLabel6 = new MaterialSkin.Controls.MaterialLabel();
            textBox3 = new TextBox();
            pictureBox2 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ButtonFace;
            panel1.BackgroundImage = (Image)resources.GetObject("panel1.BackgroundImage");
            panel1.Controls.Add(pictureBox1);
            panel1.ForeColor = SystemColors.ActiveCaptionText;
            panel1.Location = new Point(-1, -1);
            panel1.Name = "panel1";
            panel1.Size = new Size(475, 707);
            panel1.TabIndex = 2;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(43, 156);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(420, 378);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // nametekst
            // 
            nametekst.AutoSize = true;
            nametekst.BackColor = Color.Transparent;
            nametekst.Depth = 0;
            nametekst.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            nametekst.Location = new Point(544, 57);
            nametekst.MouseState = MaterialSkin.MouseState.HOVER;
            nametekst.Name = "nametekst";
            nametekst.Size = new Size(300, 19);
            nametekst.TabIndex = 9;
            nametekst.Text = "Aby dodać fakture wypełnij wszystkie pola";
            nametekst.TextAlign = ContentAlignment.TopCenter;
            // 
            // nazwa
            // 
            nazwa.AutoSize = true;
            nazwa.BackColor = Color.Transparent;
            nazwa.Cursor = Cursors.Hand;
            nazwa.Font = new Font("Arial Rounded MT Bold", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            nazwa.Location = new Point(513, 22);
            nazwa.Name = "nazwa";
            nazwa.Size = new Size(355, 24);
            nazwa.TabIndex = 10;
            nazwa.Text = "Witaj w kreatorze tworzenia faktur";
            // 
            // materialButton1
            // 
            materialButton1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            materialButton1.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            materialButton1.Depth = 0;
            materialButton1.HighEmphasis = true;
            materialButton1.Icon = null;
            materialButton1.Location = new Point(803, 653);
            materialButton1.Margin = new Padding(4, 6, 4, 6);
            materialButton1.MouseState = MaterialSkin.MouseState.HOVER;
            materialButton1.Name = "materialButton1";
            materialButton1.NoAccentTextColor = Color.Empty;
            materialButton1.Size = new Size(136, 36);
            materialButton1.TabIndex = 23;
            materialButton1.Text = "Dodaj Fakture";
            materialButton1.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            materialButton1.UseAccentColor = false;
            materialButton1.UseVisualStyleBackColor = true;
            materialButton1.Click += materialButton1_Click;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(513, 137);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(355, 23);
            comboBox1.TabIndex = 24;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // materialLabel1
            // 
            materialLabel1.AutoSize = true;
            materialLabel1.BackColor = Color.Transparent;
            materialLabel1.Depth = 0;
            materialLabel1.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel1.Location = new Point(582, 115);
            materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel1.Name = "materialLabel1";
            materialLabel1.Size = new Size(195, 19);
            materialLabel1.TabIndex = 25;
            materialLabel1.Text = "Wybierz użytkownika z listy";
            materialLabel1.TextAlign = ContentAlignment.TopCenter;
            // 
            // materialLabel3
            // 
            materialLabel3.AutoSize = true;
            materialLabel3.BackColor = Color.Transparent;
            materialLabel3.Depth = 0;
            materialLabel3.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel3.Location = new Point(605, 178);
            materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel3.Name = "materialLabel3";
            materialLabel3.Size = new Size(153, 19);
            materialLabel3.TabIndex = 28;
            materialLabel3.Text = "Wybierz usługe z listy";
            materialLabel3.TextAlign = ContentAlignment.TopCenter;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(513, 210);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(355, 23);
            comboBox2.TabIndex = 29;
            comboBox2.SelectedIndexChanged += comboBox2_SelectedIndexChanged;
            // 
            // materialLabel4
            // 
            materialLabel4.AutoSize = true;
            materialLabel4.BackColor = Color.Transparent;
            materialLabel4.Depth = 0;
            materialLabel4.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel4.Location = new Point(619, 245);
            materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel4.Name = "materialLabel4";
            materialLabel4.Size = new Size(119, 19);
            materialLabel4.TabIndex = 30;
            materialLabel4.Text = "Podaj cenę netto";
            materialLabel4.TextAlign = ContentAlignment.TopCenter;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(513, 276);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(355, 23);
            textBox2.TabIndex = 31;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // comboBox3
            // 
            comboBox3.FormattingEnabled = true;
            comboBox3.Location = new Point(513, 343);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(355, 23);
            comboBox3.TabIndex = 32;
            comboBox3.SelectedIndexChanged += comboBox3_SelectedIndexChanged;
            // 
            // materialLabel5
            // 
            materialLabel5.AutoSize = true;
            materialLabel5.BackColor = Color.Transparent;
            materialLabel5.Depth = 0;
            materialLabel5.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel5.Location = new Point(635, 312);
            materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel5.Name = "materialLabel5";
            materialLabel5.Size = new Size(85, 19);
            materialLabel5.TabIndex = 33;
            materialLabel5.Text = "Wybierz Vat";
            materialLabel5.TextAlign = ContentAlignment.TopCenter;
            // 
            // materialLabel6
            // 
            materialLabel6.AutoSize = true;
            materialLabel6.BackColor = Color.Transparent;
            materialLabel6.Depth = 0;
            materialLabel6.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel6.Location = new Point(637, 386);
            materialLabel6.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel6.Name = "materialLabel6";
            materialLabel6.Size = new Size(83, 19);
            materialLabel6.TabIndex = 34;
            materialLabel6.Text = "Cena brutto";
            materialLabel6.TextAlign = ContentAlignment.TopCenter;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(513, 420);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(355, 23);
            textBox3.TabIndex = 35;
            textBox3.TextChanged += textBox3_TextChanged;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.BackgroundImage = Properties.Resources.exit;
            pictureBox2.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox2.Location = new Point(924, 12);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(16, 20);
            pictureBox2.TabIndex = 36;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // faktury
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(952, 704);
            Controls.Add(pictureBox2);
            Controls.Add(textBox3);
            Controls.Add(materialLabel6);
            Controls.Add(materialLabel5);
            Controls.Add(comboBox3);
            Controls.Add(textBox2);
            Controls.Add(materialLabel4);
            Controls.Add(comboBox2);
            Controls.Add(materialLabel3);
            Controls.Add(materialLabel1);
            Controls.Add(comboBox1);
            Controls.Add(materialButton1);
            Controls.Add(nazwa);
            Controls.Add(nametekst);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "faktury";
            Text = "faktury";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private MaterialSkin.Controls.MaterialLabel nametekst;
        private Label nazwa;
        private MaterialSkin.Controls.MaterialButton materialButton1;
        private ComboBox comboBox1;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private ComboBox comboBox2;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private TextBox textBox2;
        private ComboBox comboBox3;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private MaterialSkin.Controls.MaterialLabel materialLabel6;
        private TextBox textBox3;
        private PictureBox pictureBox2;
    }
}