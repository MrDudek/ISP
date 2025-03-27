namespace System_ISP
{
    partial class Serwisant
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
            tekst = new Label();
            SuspendLayout();
            // 
            // tekst
            // 
            tekst.AutoSize = true;
            tekst.Font = new Font("Segoe UI Black", 36F, FontStyle.Bold, GraphicsUnit.Point, 238);
            tekst.Location = new Point(216, 212);
            tekst.Name = "tekst";
            tekst.Size = new Size(828, 65);
            tekst.TabIndex = 0;
            tekst.Text = "Strona Serwisanta do wypełnienia";
            // 
            // Serwisant
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1248, 690);
            Controls.Add(tekst);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Serwisant";
            Text = "Serwisant";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label tekst;
    }
}