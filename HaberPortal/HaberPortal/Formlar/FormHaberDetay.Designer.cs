
namespace HaberPortal.Formlar
{
    partial class FormHaberDetay
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormHaberDetay));
            this.label_Baslik = new System.Windows.Forms.Label();
            this.panel_Ust = new System.Windows.Forms.Panel();
            this.label_Okundu = new System.Windows.Forms.Label();
            this.label_Bilgi = new System.Windows.Forms.Label();
            this.btn_GeriDon = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel = new System.Windows.Forms.Panel();
            this.label_HaberOzet = new System.Windows.Forms.Label();
            this.panel_Ekleme = new System.Windows.Forms.Panel();
            this.lbl_YorumSayisi = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label_Paylasim = new System.Windows.Forms.Label();
            this.label_Begeni = new System.Windows.Forms.Label();
            this.btn_Share = new System.Windows.Forms.Button();
            this.btn_Like = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.panel_YorumEkle = new System.Windows.Forms.Panel();
            this.btn_YorumEkle = new System.Windows.Forms.Button();
            this.label_Yorum = new System.Windows.Forms.Label();
            this.richTextBox_Yorum = new System.Windows.Forms.RichTextBox();
            this.panel_Yorum = new System.Windows.Forms.Panel();
            this.uC_YorumTemp1 = new HaberPortal.UC_YorumTemp();
            this.panel_Ust.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel.SuspendLayout();
            this.panel_Ekleme.SuspendLayout();
            this.panel_YorumEkle.SuspendLayout();
            this.panel_Yorum.SuspendLayout();
            this.SuspendLayout();
            // 
            // label_Baslik
            // 
            this.label_Baslik.AutoSize = true;
            this.label_Baslik.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_Baslik.Location = new System.Drawing.Point(12, 13);
            this.label_Baslik.Name = "label_Baslik";
            this.label_Baslik.Size = new System.Drawing.Size(98, 32);
            this.label_Baslik.TabIndex = 0;
            this.label_Baslik.Text = "Başlık";
            this.label_Baslik.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel_Ust
            // 
            this.panel_Ust.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.panel_Ust.Controls.Add(this.label_Okundu);
            this.panel_Ust.Controls.Add(this.label_Bilgi);
            this.panel_Ust.Controls.Add(this.btn_GeriDon);
            this.panel_Ust.Controls.Add(this.label2);
            this.panel_Ust.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_Ust.ForeColor = System.Drawing.Color.Coral;
            this.panel_Ust.Location = new System.Drawing.Point(0, 0);
            this.panel_Ust.Name = "panel_Ust";
            this.panel_Ust.Size = new System.Drawing.Size(607, 71);
            this.panel_Ust.TabIndex = 1;
            // 
            // label_Okundu
            // 
            this.label_Okundu.AutoSize = true;
            this.label_Okundu.Location = new System.Drawing.Point(527, 34);
            this.label_Okundu.Name = "label_Okundu";
            this.label_Okundu.Size = new System.Drawing.Size(19, 17);
            this.label_Okundu.TabIndex = 5;
            this.label_Okundu.Text = "O";
            // 
            // label_Bilgi
            // 
            this.label_Bilgi.AutoSize = true;
            this.label_Bilgi.Location = new System.Drawing.Point(413, 34);
            this.label_Bilgi.Name = "label_Bilgi";
            this.label_Bilgi.Size = new System.Drawing.Size(108, 17);
            this.label_Bilgi.TabIndex = 4;
            this.label_Bilgi.Text = "Kaç Kişi Okudu:";
            // 
            // btn_GeriDon
            // 
            this.btn_GeriDon.FlatAppearance.BorderSize = 0;
            this.btn_GeriDon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_GeriDon.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_GeriDon.Location = new System.Drawing.Point(3, 3);
            this.btn_GeriDon.Name = "btn_GeriDon";
            this.btn_GeriDon.Size = new System.Drawing.Size(75, 68);
            this.btn_GeriDon.TabIndex = 3;
            this.btn_GeriDon.Text = "<";
            this.btn_GeriDon.UseVisualStyleBackColor = true;
            this.btn_GeriDon.Click += new System.EventHandler(this.btn_GeriDon_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(182, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(212, 38);
            this.label2.TabIndex = 2;
            this.label2.Text = "Haber Detay";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label_Baslik);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 71);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(607, 58);
            this.panel1.TabIndex = 2;
            // 
            // panel
            // 
            this.panel.Controls.Add(this.label_HaberOzet);
            this.panel.Location = new System.Drawing.Point(0, 135);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(607, 423);
            this.panel.TabIndex = 3;
            // 
            // label_HaberOzet
            // 
            this.label_HaberOzet.AutoSize = true;
            this.label_HaberOzet.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_HaberOzet.Location = new System.Drawing.Point(12, 14);
            this.label_HaberOzet.MaximumSize = new System.Drawing.Size(607, 0);
            this.label_HaberOzet.Name = "label_HaberOzet";
            this.label_HaberOzet.Size = new System.Drawing.Size(107, 25);
            this.label_HaberOzet.TabIndex = 0;
            this.label_HaberOzet.Text = "HaberOzet";
            this.label_HaberOzet.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel_Ekleme
            // 
            this.panel_Ekleme.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_Ekleme.Controls.Add(this.lbl_YorumSayisi);
            this.panel_Ekleme.Controls.Add(this.label1);
            this.panel_Ekleme.Controls.Add(this.label_Paylasim);
            this.panel_Ekleme.Controls.Add(this.label_Begeni);
            this.panel_Ekleme.Controls.Add(this.btn_Share);
            this.panel_Ekleme.Controls.Add(this.btn_Like);
            this.panel_Ekleme.Controls.Add(this.linkLabel1);
            this.panel_Ekleme.Location = new System.Drawing.Point(1, 564);
            this.panel_Ekleme.Name = "panel_Ekleme";
            this.panel_Ekleme.Size = new System.Drawing.Size(606, 56);
            this.panel_Ekleme.TabIndex = 1;
            // 
            // lbl_YorumSayisi
            // 
            this.lbl_YorumSayisi.AutoSize = true;
            this.lbl_YorumSayisi.Location = new System.Drawing.Point(375, 19);
            this.lbl_YorumSayisi.Name = "lbl_YorumSayisi";
            this.lbl_YorumSayisi.Size = new System.Drawing.Size(17, 17);
            this.lbl_YorumSayisi.TabIndex = 6;
            this.lbl_YorumSayisi.Text = "Y";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(232, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Toplam Yorum Sayısı:";
            // 
            // label_Paylasim
            // 
            this.label_Paylasim.AutoSize = true;
            this.label_Paylasim.Location = new System.Drawing.Point(527, 19);
            this.label_Paylasim.Name = "label_Paylasim";
            this.label_Paylasim.Size = new System.Drawing.Size(17, 17);
            this.label_Paylasim.TabIndex = 4;
            this.label_Paylasim.Text = "P";
            // 
            // label_Begeni
            // 
            this.label_Begeni.AutoSize = true;
            this.label_Begeni.Location = new System.Drawing.Point(61, 19);
            this.label_Begeni.Name = "label_Begeni";
            this.label_Begeni.Size = new System.Drawing.Size(17, 17);
            this.label_Begeni.TabIndex = 3;
            this.label_Begeni.Text = "B";
            // 
            // btn_Share
            // 
            this.btn_Share.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_Share.FlatAppearance.BorderSize = 0;
            this.btn_Share.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Share.Image = ((System.Drawing.Image)(resources.GetObject("btn_Share.Image")));
            this.btn_Share.Location = new System.Drawing.Point(529, 0);
            this.btn_Share.Name = "btn_Share";
            this.btn_Share.Size = new System.Drawing.Size(75, 54);
            this.btn_Share.TabIndex = 2;
            this.btn_Share.UseVisualStyleBackColor = true;
            this.btn_Share.Click += new System.EventHandler(this.btn_Share_Click);
            // 
            // btn_Like
            // 
            this.btn_Like.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn_Like.FlatAppearance.BorderSize = 0;
            this.btn_Like.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Like.Image = ((System.Drawing.Image)(resources.GetObject("btn_Like.Image")));
            this.btn_Like.Location = new System.Drawing.Point(0, 0);
            this.btn_Like.Name = "btn_Like";
            this.btn_Like.Size = new System.Drawing.Size(78, 54);
            this.btn_Like.TabIndex = 1;
            this.btn_Like.UseVisualStyleBackColor = true;
            this.btn_Like.Click += new System.EventHandler(this.btn_Like_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Image = ((System.Drawing.Image)(resources.GetObject("linkLabel1.Image")));
            this.linkLabel1.Location = new System.Drawing.Point(29, 15);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(0, 17);
            this.linkLabel1.TabIndex = 0;
            // 
            // panel_YorumEkle
            // 
            this.panel_YorumEkle.Controls.Add(this.btn_YorumEkle);
            this.panel_YorumEkle.Controls.Add(this.label_Yorum);
            this.panel_YorumEkle.Controls.Add(this.richTextBox_Yorum);
            this.panel_YorumEkle.Location = new System.Drawing.Point(1, 625);
            this.panel_YorumEkle.Name = "panel_YorumEkle";
            this.panel_YorumEkle.Size = new System.Drawing.Size(606, 168);
            this.panel_YorumEkle.TabIndex = 4;
            // 
            // btn_YorumEkle
            // 
            this.btn_YorumEkle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btn_YorumEkle.FlatAppearance.BorderSize = 0;
            this.btn_YorumEkle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_YorumEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_YorumEkle.Location = new System.Drawing.Point(470, 116);
            this.btn_YorumEkle.Name = "btn_YorumEkle";
            this.btn_YorumEkle.Size = new System.Drawing.Size(136, 43);
            this.btn_YorumEkle.TabIndex = 2;
            this.btn_YorumEkle.Text = "Yorum Ekle";
            this.btn_YorumEkle.UseVisualStyleBackColor = false;
            this.btn_YorumEkle.Click += new System.EventHandler(this.btn_YorumEkle_Click);
            // 
            // label_Yorum
            // 
            this.label_Yorum.AutoSize = true;
            this.label_Yorum.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_Yorum.Location = new System.Drawing.Point(11, 12);
            this.label_Yorum.Name = "label_Yorum";
            this.label_Yorum.Size = new System.Drawing.Size(124, 24);
            this.label_Yorum.TabIndex = 1;
            this.label_Yorum.Text = "Yorum Ekle:";
            // 
            // richTextBox_Yorum
            // 
            this.richTextBox_Yorum.Location = new System.Drawing.Point(3, 39);
            this.richTextBox_Yorum.Name = "richTextBox_Yorum";
            this.richTextBox_Yorum.Size = new System.Drawing.Size(461, 120);
            this.richTextBox_Yorum.TabIndex = 0;
            this.richTextBox_Yorum.Text = "";
            // 
            // panel_Yorum
            // 
            this.panel_Yorum.AutoScroll = true;
            this.panel_Yorum.Controls.Add(this.uC_YorumTemp1);
            this.panel_Yorum.Location = new System.Drawing.Point(0, 799);
            this.panel_Yorum.Name = "panel_Yorum";
            this.panel_Yorum.Size = new System.Drawing.Size(607, 282);
            this.panel_Yorum.TabIndex = 5;
            // 
            // uC_YorumTemp1
            // 
            this.uC_YorumTemp1.Location = new System.Drawing.Point(0, 0);
            this.uC_YorumTemp1.Name = "uC_YorumTemp1";
            this.uC_YorumTemp1.Size = new System.Drawing.Size(607, 141);
            this.uC_YorumTemp1.TabIndex = 0;
            // 
            // FormHaberDetay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(607, 1081);
            this.Controls.Add(this.panel_Yorum);
            this.Controls.Add(this.panel_YorumEkle);
            this.Controls.Add(this.panel_Ekleme);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel_Ust);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormHaberDetay";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormHaberDetay";
            this.panel_Ust.ResumeLayout(false);
            this.panel_Ust.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            this.panel_Ekleme.ResumeLayout(false);
            this.panel_Ekleme.PerformLayout();
            this.panel_YorumEkle.ResumeLayout(false);
            this.panel_YorumEkle.PerformLayout();
            this.panel_Yorum.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label_Baslik;
        private System.Windows.Forms.Panel panel_Ust;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.Label label_HaberOzet;
        private System.Windows.Forms.Button btn_GeriDon;
        private System.Windows.Forms.Panel panel_Ekleme;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Button btn_Share;
        private System.Windows.Forms.Button btn_Like;
        private System.Windows.Forms.Label label_Paylasim;
        private System.Windows.Forms.Label label_Begeni;
        private System.Windows.Forms.Label label_Okundu;
        private System.Windows.Forms.Label label_Bilgi;
        private System.Windows.Forms.Panel panel_YorumEkle;
        private System.Windows.Forms.Button btn_YorumEkle;
        private System.Windows.Forms.Label label_Yorum;
        private System.Windows.Forms.RichTextBox richTextBox_Yorum;
        private System.Windows.Forms.Panel panel_Yorum;
        private UC_YorumTemp uC_YorumTemp1;
        private System.Windows.Forms.Label lbl_YorumSayisi;
        private System.Windows.Forms.Label label1;
    }
}