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
            button1 = new Button();
            label3 = new Label();
            textBox2 = new TextBox();
            label4 = new Label();
            nazwauzytkownika = new TextBox();
            label2 = new Label();
            label1 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ButtonFace;
            panel1.Controls.Add(button1);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(textBox2);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(nazwauzytkownika);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(-1, -2);
            panel1.Name = "panel1";
            panel1.Size = new Size(477, 581);
            panel1.TabIndex = 0;
            // 
            // button1
            // 
            button1.BackColor = Color.Black;
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 238);
            button1.ForeColor = SystemColors.Control;
            button1.Location = new Point(159, 322);
            button1.Name = "button1";
            button1.Size = new Size(152, 44);
            button1.TabIndex = 7;
            button1.Text = "Logowanie";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label3
            // 
            label3.AccessibleName = "";
            label3.AutoSize = true;
            label3.Cursor = Cursors.Hand;
            label3.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 238);
            label3.Location = new Point(27, 178);
            label3.Name = "label3";
            label3.Size = new Size(172, 22);
            label3.TabIndex = 6;
            label3.Text = "Nazwa Użytkownika";
            label3.TextAlign = ContentAlignment.TopRight;
            label3.Click += label3_Click;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 238);
            textBox2.Location = new Point(27, 276);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(427, 29);
            textBox2.TabIndex = 5;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Cursor = Cursors.Hand;
            label4.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 238);
            label4.Location = new Point(27, 256);
            label4.Name = "label4";
            label4.Size = new Size(58, 22);
            label4.TabIndex = 4;
            label4.Text = "Hasło";
            label4.Click += label4_Click;
            // 
            // nazwauzytkownika
            // 
            nazwauzytkownika.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 238);
            nazwauzytkownika.Location = new Point(27, 203);
            nazwauzytkownika.Name = "nazwauzytkownika";
            nazwauzytkownika.Size = new Size(427, 29);
            nazwauzytkownika.TabIndex = 3;
            nazwauzytkownika.TextChanged += textBox1_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Cursor = Cursors.Hand;
            label2.Font = new Font("Arial Rounded MT Bold", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(3, 69);
            label2.Name = "label2";
            label2.Size = new Size(466, 24);
            label2.TabIndex = 1;
            label2.Text = "Witamy w systemie zarządzania usługami ISP";
            label2.Click += label2_Click_1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Cursor = Cursors.Hand;
            label1.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label1.Location = new Point(445, 11);
            label1.Name = "label1";
            label1.Size = new Size(19, 20);
            label1.TabIndex = 0;
            label1.Text = "X";
            label1.Click += label1_Click;
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
        private Label label1;
        private Label label2;
        private TextBox textBox2;
        private Label label4;
        private TextBox nazwauzytkownika;
        private Label label3;
        private Button button1;
    }
}
