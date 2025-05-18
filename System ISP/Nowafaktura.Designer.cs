namespace System_ISP
{
    partial class Nowafaktura
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
            exit = new Label();
            SuspendLayout();
            // 
            // exit
            // 
            exit.AutoSize = true;
            exit.Cursor = Cursors.Hand;
            exit.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 238);
            exit.Location = new Point(923, -18);
            exit.Name = "exit";
            exit.Size = new Size(19, 20);
            exit.TabIndex = 23;
            exit.Text = "X";
            // 
            // Nowafaktura
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(965, 665);
            Controls.Add(exit);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Nowafaktura";
            Text = "Nowafaktura";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label exit;
    }
}