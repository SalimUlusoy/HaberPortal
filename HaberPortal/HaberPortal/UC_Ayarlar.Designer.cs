
namespace HaberPortal
{
    partial class UC_Ayarlar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_Ayarlar));
            this.panel3 = new System.Windows.Forms.Panel();
            this.label_SayfaAdi = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.linkLabel_HaberEkle = new System.Windows.Forms.LinkLabel();
            this.pictureBox_Haber = new System.Windows.Forms.PictureBox();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Haber)).BeginInit();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.panel3.Controls.Add(this.label_SayfaAdi);
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Location = new System.Drawing.Point(100, 2);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(157, 151);
            this.panel3.TabIndex = 8;
            // 
            // label_SayfaAdi
            // 
            this.label_SayfaAdi.AutoSize = true;
            this.label_SayfaAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_SayfaAdi.ForeColor = System.Drawing.Color.White;
            this.label_SayfaAdi.Location = new System.Drawing.Point(37, 100);
            this.label_SayfaAdi.Name = "label_SayfaAdi";
            this.label_SayfaAdi.Size = new System.Drawing.Size(81, 25);
            this.label_SayfaAdi.TabIndex = 3;
            this.label_SayfaAdi.Text = "Ayarlar";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(40, 12);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(75, 70);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1315, 10);
            this.panel2.TabIndex = 7;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.linkLabel_HaberEkle);
            this.panel1.Controls.Add(this.pictureBox_Haber);
            this.panel1.Location = new System.Drawing.Point(224, 231);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(272, 246);
            this.panel1.TabIndex = 9;
            // 
            // linkLabel_HaberEkle
            // 
            this.linkLabel_HaberEkle.AutoSize = true;
            this.linkLabel_HaberEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.linkLabel_HaberEkle.LinkColor = System.Drawing.Color.Black;
            this.linkLabel_HaberEkle.Location = new System.Drawing.Point(77, 166);
            this.linkLabel_HaberEkle.Name = "linkLabel_HaberEkle";
            this.linkLabel_HaberEkle.Size = new System.Drawing.Size(118, 25);
            this.linkLabel_HaberEkle.TabIndex = 10;
            this.linkLabel_HaberEkle.TabStop = true;
            this.linkLabel_HaberEkle.Text = "Haber Ekle";
            this.linkLabel_HaberEkle.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel_HaberEkle_LinkClicked);
            // 
            // pictureBox_Haber
            // 
            this.pictureBox_Haber.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_Haber.Image")));
            this.pictureBox_Haber.Location = new System.Drawing.Point(80, 25);
            this.pictureBox_Haber.Name = "pictureBox_Haber";
            this.pictureBox_Haber.Size = new System.Drawing.Size(112, 113);
            this.pictureBox_Haber.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox_Haber.TabIndex = 0;
            this.pictureBox_Haber.TabStop = false;
            // 
            // UC_Ayarlar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Name = "UC_Ayarlar";
            this.Size = new System.Drawing.Size(1315, 673);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Haber)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label_SayfaAdi;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.LinkLabel linkLabel_HaberEkle;
        private System.Windows.Forms.PictureBox pictureBox_Haber;
    }
}
