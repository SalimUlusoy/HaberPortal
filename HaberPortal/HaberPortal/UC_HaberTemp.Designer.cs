
namespace HaberPortal
{
    partial class UC_HaberTemp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_HaberTemp));
            this.pictureBox_Haber = new System.Windows.Forms.PictureBox();
            this.lbl_HaberIcerik = new System.Windows.Forms.Label();
            this.lbl_HaberBaslik = new System.Windows.Forms.LinkLabel();
            this.lbl_Id = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Haber)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox_Haber
            // 
            this.pictureBox_Haber.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_Haber.Image")));
            this.pictureBox_Haber.Location = new System.Drawing.Point(0, 0);
            this.pictureBox_Haber.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox_Haber.Name = "pictureBox_Haber";
            this.pictureBox_Haber.Size = new System.Drawing.Size(518, 201);
            this.pictureBox_Haber.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_Haber.TabIndex = 0;
            this.pictureBox_Haber.TabStop = false;
            // 
            // lbl_HaberIcerik
            // 
            this.lbl_HaberIcerik.AutoSize = true;
            this.lbl_HaberIcerik.Location = new System.Drawing.Point(4, 239);
            this.lbl_HaberIcerik.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_HaberIcerik.Name = "lbl_HaberIcerik";
            this.lbl_HaberIcerik.Size = new System.Drawing.Size(84, 17);
            this.lbl_HaberIcerik.TabIndex = 3;
            this.lbl_HaberIcerik.Text = "Haber İçerik";
            // 
            // lbl_HaberBaslik
            // 
            this.lbl_HaberBaslik.AutoSize = true;
            this.lbl_HaberBaslik.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_HaberBaslik.ForeColor = System.Drawing.Color.Black;
            this.lbl_HaberBaslik.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lbl_HaberBaslik.Location = new System.Drawing.Point(4, 205);
            this.lbl_HaberBaslik.Name = "lbl_HaberBaslik";
            this.lbl_HaberBaslik.Size = new System.Drawing.Size(88, 17);
            this.lbl_HaberBaslik.TabIndex = 4;
            this.lbl_HaberBaslik.TabStop = true;
            this.lbl_HaberBaslik.Text = "Haber Başlık";
            this.lbl_HaberBaslik.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lbl_HaberBaslik_LinkClicked_1);
            // 
            // lbl_Id
            // 
            this.lbl_Id.AutoSize = true;
            this.lbl_Id.Location = new System.Drawing.Point(496, 302);
            this.lbl_Id.Name = "lbl_Id";
            this.lbl_Id.Size = new System.Drawing.Size(19, 17);
            this.lbl_Id.TabIndex = 6;
            this.lbl_Id.Text = "Id";
            this.lbl_Id.Visible = false;
            // 
            // UC_HaberTemp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lbl_Id);
            this.Controls.Add(this.lbl_HaberBaslik);
            this.Controls.Add(this.lbl_HaberIcerik);
            this.Controls.Add(this.pictureBox_Haber);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "UC_HaberTemp";
            this.Size = new System.Drawing.Size(518, 319);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Haber)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox_Haber;
        private System.Windows.Forms.Label lbl_HaberIcerik;
        private System.Windows.Forms.LinkLabel lbl_HaberBaslik;
        private System.Windows.Forms.Label lbl_Id;
    }
}
