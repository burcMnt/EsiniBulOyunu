
namespace EsiniBul
{
    partial class Form1
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
            this.pnlKartlar = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // pnlKartlar
            // 
            this.pnlKartlar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pnlKartlar.Location = new System.Drawing.Point(10, 10);
            this.pnlKartlar.Name = "pnlKartlar";
            this.pnlKartlar.Size = new System.Drawing.Size(700, 700);
            this.pnlKartlar.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(740, 744);
            this.Controls.Add(this.pnlKartlar);
            this.Name = "Form1";
            this.Text = "Eşini Bul";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlKartlar;
    }
}

