
namespace EsiniBul
{
    partial class YeniOyunForm
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
            this.gboSeviye = new System.Windows.Forms.GroupBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.rbKolay = new System.Windows.Forms.RadioButton();
            this.rbOrta = new System.Windows.Forms.RadioButton();
            this.rbZor = new System.Windows.Forms.RadioButton();
            this.btnBaslat = new System.Windows.Forms.Button();
            this.btnKapat = new System.Windows.Forms.Button();
            this.gboSeviye.SuspendLayout();
            this.SuspendLayout();
            // 
            // gboSeviye
            // 
            this.gboSeviye.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gboSeviye.Controls.Add(this.rbZor);
            this.gboSeviye.Controls.Add(this.rbOrta);
            this.gboSeviye.Controls.Add(this.rbKolay);
            this.gboSeviye.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gboSeviye.Location = new System.Drawing.Point(240, 110);
            this.gboSeviye.Name = "gboSeviye";
            this.gboSeviye.Size = new System.Drawing.Size(380, 195);
            this.gboSeviye.TabIndex = 0;
            this.gboSeviye.TabStop = false;
            this.gboSeviye.Text = "ZORLUK SEVİYELERİ";
            // 
            // rbKolay
            // 
            this.rbKolay.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rbKolay.AutoSize = true;
            this.rbKolay.Checked = true;
            this.rbKolay.Location = new System.Drawing.Point(52, 41);
            this.rbKolay.Name = "rbKolay";
            this.rbKolay.Size = new System.Drawing.Size(152, 29);
            this.rbKolay.TabIndex = 0;
            this.rbKolay.TabStop = true;
            this.rbKolay.Text = "KOLAY (4x4)";
            this.rbKolay.UseVisualStyleBackColor = true;
            // 
            // rbOrta
            // 
            this.rbOrta.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rbOrta.AutoSize = true;
            this.rbOrta.Location = new System.Drawing.Point(52, 85);
            this.rbOrta.Name = "rbOrta";
            this.rbOrta.Size = new System.Drawing.Size(140, 29);
            this.rbOrta.TabIndex = 1;
            this.rbOrta.Text = "ORTA (6x6)";
            this.rbOrta.UseVisualStyleBackColor = true;
            // 
            // rbZor
            // 
            this.rbZor.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rbZor.AutoSize = true;
            this.rbZor.Location = new System.Drawing.Point(52, 129);
            this.rbZor.Name = "rbZor";
            this.rbZor.Size = new System.Drawing.Size(125, 29);
            this.rbZor.TabIndex = 2;
            this.rbZor.Text = "ZOR (8x8)";
            this.rbZor.UseVisualStyleBackColor = true;
            // 
            // btnBaslat
            // 
            this.btnBaslat.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnBaslat.Location = new System.Drawing.Point(240, 311);
            this.btnBaslat.Name = "btnBaslat";
            this.btnBaslat.Size = new System.Drawing.Size(380, 43);
            this.btnBaslat.TabIndex = 1;
            this.btnBaslat.Text = "OYUNU BAŞLAT";
            this.btnBaslat.UseVisualStyleBackColor = true;
            this.btnBaslat.Click += new System.EventHandler(this.btnBaslat_Click);
            // 
            // btnKapat
            // 
            this.btnKapat.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnKapat.Location = new System.Drawing.Point(240, 360);
            this.btnKapat.Name = "btnKapat";
            this.btnKapat.Size = new System.Drawing.Size(380, 43);
            this.btnKapat.TabIndex = 2;
            this.btnKapat.Text = "OYUNDAN ÇIK !";
            this.btnKapat.UseVisualStyleBackColor = true;
            this.btnKapat.Click += new System.EventHandler(this.btnKapat_Click);
            // 
            // YeniOyunForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnKapat);
            this.Controls.Add(this.btnBaslat);
            this.Controls.Add(this.gboSeviye);
            this.Name = "YeniOyunForm";
            this.Text = "EŞİNİ BUL";
            this.gboSeviye.ResumeLayout(false);
            this.gboSeviye.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gboSeviye;
        private System.Windows.Forms.RadioButton rbZor;
        private System.Windows.Forms.RadioButton rbOrta;
        private System.Windows.Forms.RadioButton rbKolay;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button btnBaslat;
        private System.Windows.Forms.Button btnKapat;
    }
}