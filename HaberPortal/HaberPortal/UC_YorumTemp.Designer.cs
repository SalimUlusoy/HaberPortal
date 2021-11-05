
namespace HaberPortal
{
    partial class UC_YorumTemp
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbl_KullaniciAdi = new System.Windows.Forms.Label();
            this.lbl_YorumKismi = new System.Windows.Forms.Label();
            this.lbl_HaberTarih = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_KullaniciAdi
            // 
            this.lbl_KullaniciAdi.AutoSize = true;
            this.lbl_KullaniciAdi.BackColor = System.Drawing.SystemColors.Control;
            this.lbl_KullaniciAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_KullaniciAdi.ForeColor = System.Drawing.Color.Black;
            this.lbl_KullaniciAdi.Location = new System.Drawing.Point(33, 12);
            this.lbl_KullaniciAdi.Name = "lbl_KullaniciAdi";
            this.lbl_KullaniciAdi.Size = new System.Drawing.Size(97, 17);
            this.lbl_KullaniciAdi.TabIndex = 0;
            this.lbl_KullaniciAdi.Text = "Kullanici Adi";
            // 
            // lbl_YorumKismi
            // 
            this.lbl_YorumKismi.AutoSize = true;
            this.lbl_YorumKismi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_YorumKismi.ForeColor = System.Drawing.Color.Black;
            this.lbl_YorumKismi.Location = new System.Drawing.Point(32, 46);
            this.lbl_YorumKismi.Name = "lbl_YorumKismi";
            this.lbl_YorumKismi.Size = new System.Drawing.Size(108, 20);
            this.lbl_YorumKismi.TabIndex = 1;
            this.lbl_YorumKismi.Text = "Haber Yorum";
            // 
            // lbl_HaberTarih
            // 
            this.lbl_HaberTarih.AutoSize = true;
            this.lbl_HaberTarih.ForeColor = System.Drawing.Color.Black;
            this.lbl_HaberTarih.Location = new System.Drawing.Point(454, 12);
            this.lbl_HaberTarih.Name = "lbl_HaberTarih";
            this.lbl_HaberTarih.Size = new System.Drawing.Size(84, 17);
            this.lbl_HaberTarih.TabIndex = 2;
            this.lbl_HaberTarih.Text = "Haber Tarih";
            // 
            // UC_YorumTemp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lbl_HaberTarih);
            this.Controls.Add(this.lbl_YorumKismi);
            this.Controls.Add(this.lbl_KullaniciAdi);
            this.Name = "UC_YorumTemp";
            this.Size = new System.Drawing.Size(582, 141);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_KullaniciAdi;
        private System.Windows.Forms.Label lbl_YorumKismi;
        private System.Windows.Forms.Label lbl_HaberTarih;
    }
}
