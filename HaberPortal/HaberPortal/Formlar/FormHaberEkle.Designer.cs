
namespace HaberPortal.Formlar
{
    partial class FormHaberEkle
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
            this.panel_UstKisim = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_GeriDon = new System.Windows.Forms.Button();
            this.dataGridView_Haberler = new System.Windows.Forms.DataGridView();
            this.btn_Ekle = new System.Windows.Forms.Button();
            this.btn_Sil = new System.Windows.Forms.Button();
            this.btn_Guncelle = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox_HaberBaslik = new System.Windows.Forms.TextBox();
            this.textBox_HaberTur = new System.Windows.Forms.TextBox();
            this.textBox_HaberOzet = new System.Windows.Forms.TextBox();
            this.richTextBox_HaberYazi = new System.Windows.Forms.RichTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_Id = new System.Windows.Forms.TextBox();
            this.btn_Temizle = new System.Windows.Forms.Button();
            this.panel_UstKisim.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Haberler)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_UstKisim
            // 
            this.panel_UstKisim.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.panel_UstKisim.Controls.Add(this.label2);
            this.panel_UstKisim.Controls.Add(this.btn_GeriDon);
            this.panel_UstKisim.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_UstKisim.Location = new System.Drawing.Point(0, 0);
            this.panel_UstKisim.Name = "panel_UstKisim";
            this.panel_UstKisim.Size = new System.Drawing.Size(1531, 80);
            this.panel_UstKisim.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(585, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(361, 38);
            this.label2.TabIndex = 5;
            this.label2.Text = "Haber Ekleme Sayfası";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_GeriDon
            // 
            this.btn_GeriDon.FlatAppearance.BorderSize = 0;
            this.btn_GeriDon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_GeriDon.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_GeriDon.ForeColor = System.Drawing.Color.Coral;
            this.btn_GeriDon.Location = new System.Drawing.Point(0, 0);
            this.btn_GeriDon.Name = "btn_GeriDon";
            this.btn_GeriDon.Size = new System.Drawing.Size(78, 80);
            this.btn_GeriDon.TabIndex = 4;
            this.btn_GeriDon.Text = "<";
            this.btn_GeriDon.UseVisualStyleBackColor = true;
            this.btn_GeriDon.Click += new System.EventHandler(this.btn_GeriDon_Click);
            // 
            // dataGridView_Haberler
            // 
            this.dataGridView_Haberler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Haberler.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridView_Haberler.Location = new System.Drawing.Point(0, 80);
            this.dataGridView_Haberler.Name = "dataGridView_Haberler";
            this.dataGridView_Haberler.RowHeadersWidth = 51;
            this.dataGridView_Haberler.RowTemplate.Height = 24;
            this.dataGridView_Haberler.Size = new System.Drawing.Size(1531, 306);
            this.dataGridView_Haberler.TabIndex = 1;
            this.dataGridView_Haberler.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_Haberler_CellClick);
            // 
            // btn_Ekle
            // 
            this.btn_Ekle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btn_Ekle.FlatAppearance.BorderSize = 0;
            this.btn_Ekle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Ekle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Ekle.ForeColor = System.Drawing.Color.White;
            this.btn_Ekle.Location = new System.Drawing.Point(993, 661);
            this.btn_Ekle.Name = "btn_Ekle";
            this.btn_Ekle.Size = new System.Drawing.Size(128, 43);
            this.btn_Ekle.TabIndex = 2;
            this.btn_Ekle.Text = "Ekle";
            this.btn_Ekle.UseVisualStyleBackColor = false;
            this.btn_Ekle.Click += new System.EventHandler(this.btn_Ekle_Click);
            // 
            // btn_Sil
            // 
            this.btn_Sil.BackColor = System.Drawing.Color.Red;
            this.btn_Sil.FlatAppearance.BorderSize = 0;
            this.btn_Sil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Sil.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Sil.ForeColor = System.Drawing.Color.White;
            this.btn_Sil.Location = new System.Drawing.Point(1298, 661);
            this.btn_Sil.Name = "btn_Sil";
            this.btn_Sil.Size = new System.Drawing.Size(128, 43);
            this.btn_Sil.TabIndex = 3;
            this.btn_Sil.Text = "Sil";
            this.btn_Sil.UseVisualStyleBackColor = false;
            this.btn_Sil.Click += new System.EventHandler(this.btn_Sil_Click);
            // 
            // btn_Guncelle
            // 
            this.btn_Guncelle.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btn_Guncelle.FlatAppearance.BorderSize = 0;
            this.btn_Guncelle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Guncelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Guncelle.ForeColor = System.Drawing.Color.White;
            this.btn_Guncelle.Location = new System.Drawing.Point(1145, 661);
            this.btn_Guncelle.Name = "btn_Guncelle";
            this.btn_Guncelle.Size = new System.Drawing.Size(128, 43);
            this.btn_Guncelle.TabIndex = 4;
            this.btn_Guncelle.Text = "Güncelle";
            this.btn_Guncelle.UseVisualStyleBackColor = false;
            this.btn_Guncelle.Click += new System.EventHandler(this.btn_Guncelle_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(303, 445);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Ana Başlık:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(358, 500);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Tür:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(296, 554);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Haber Özet:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(287, 613);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Haber Yazısı:";
            // 
            // textBox_HaberBaslik
            // 
            this.textBox_HaberBaslik.Location = new System.Drawing.Point(412, 445);
            this.textBox_HaberBaslik.Name = "textBox_HaberBaslik";
            this.textBox_HaberBaslik.Size = new System.Drawing.Size(154, 22);
            this.textBox_HaberBaslik.TabIndex = 9;
            // 
            // textBox_HaberTur
            // 
            this.textBox_HaberTur.Location = new System.Drawing.Point(412, 500);
            this.textBox_HaberTur.Name = "textBox_HaberTur";
            this.textBox_HaberTur.Size = new System.Drawing.Size(154, 22);
            this.textBox_HaberTur.TabIndex = 10;
            // 
            // textBox_HaberOzet
            // 
            this.textBox_HaberOzet.Location = new System.Drawing.Point(412, 554);
            this.textBox_HaberOzet.Name = "textBox_HaberOzet";
            this.textBox_HaberOzet.Size = new System.Drawing.Size(154, 22);
            this.textBox_HaberOzet.TabIndex = 11;
            // 
            // richTextBox_HaberYazi
            // 
            this.richTextBox_HaberYazi.Location = new System.Drawing.Point(412, 613);
            this.richTextBox_HaberYazi.Name = "richTextBox_HaberYazi";
            this.richTextBox_HaberYazi.Size = new System.Drawing.Size(271, 96);
            this.richTextBox_HaberYazi.TabIndex = 12;
            this.richTextBox_HaberYazi.Text = "";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(370, 400);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(27, 20);
            this.label6.TabIndex = 13;
            this.label6.Text = "Id:";
            // 
            // txt_Id
            // 
            this.txt_Id.Enabled = false;
            this.txt_Id.Location = new System.Drawing.Point(412, 400);
            this.txt_Id.Name = "txt_Id";
            this.txt_Id.Size = new System.Drawing.Size(154, 22);
            this.txt_Id.TabIndex = 14;
            this.txt_Id.Text = "0";
            this.txt_Id.TextChanged += new System.EventHandler(this.txt_Id_TextChanged);
            // 
            // btn_Temizle
            // 
            this.btn_Temizle.BackColor = System.Drawing.Color.Gray;
            this.btn_Temizle.FlatAppearance.BorderSize = 0;
            this.btn_Temizle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Temizle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Temizle.ForeColor = System.Drawing.Color.White;
            this.btn_Temizle.Location = new System.Drawing.Point(1298, 602);
            this.btn_Temizle.Name = "btn_Temizle";
            this.btn_Temizle.Size = new System.Drawing.Size(128, 43);
            this.btn_Temizle.TabIndex = 15;
            this.btn_Temizle.Text = "Temizle";
            this.btn_Temizle.UseVisualStyleBackColor = false;
            this.btn_Temizle.Click += new System.EventHandler(this.btn_Temizle_Click);
            // 
            // FormHaberEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1531, 716);
            this.Controls.Add(this.btn_Temizle);
            this.Controls.Add(this.txt_Id);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.richTextBox_HaberYazi);
            this.Controls.Add(this.textBox_HaberOzet);
            this.Controls.Add(this.textBox_HaberTur);
            this.Controls.Add(this.textBox_HaberBaslik);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Guncelle);
            this.Controls.Add(this.btn_Sil);
            this.Controls.Add(this.btn_Ekle);
            this.Controls.Add(this.dataGridView_Haberler);
            this.Controls.Add(this.panel_UstKisim);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormHaberEkle";
            this.Text = "FormHaberEkle";
            this.panel_UstKisim.ResumeLayout(false);
            this.panel_UstKisim.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Haberler)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel_UstKisim;
        private System.Windows.Forms.Button btn_GeriDon;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView_Haberler;
        private System.Windows.Forms.Button btn_Ekle;
        private System.Windows.Forms.Button btn_Sil;
        private System.Windows.Forms.Button btn_Guncelle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox_HaberBaslik;
        private System.Windows.Forms.TextBox textBox_HaberTur;
        private System.Windows.Forms.TextBox textBox_HaberOzet;
        private System.Windows.Forms.RichTextBox richTextBox_HaberYazi;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_Id;
        private System.Windows.Forms.Button btn_Temizle;
    }
}