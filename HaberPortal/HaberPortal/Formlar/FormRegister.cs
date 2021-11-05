using HaberPortal.Database.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HaberPortal.Formlar
{
    public partial class FormRegister : Form
    {
        HaberlerEntities1 db = new HaberlerEntities1();
        public FormRegister()
        {
            InitializeComponent();
            label_Message.Visible = false;
        }

        private void btn_KayitYap_Click(object sender, EventArgs e)
        {
            if(txt_Isim.Text == "" || txt_Soyad.Text == "" || txt_Eposta.Text == "" || txt_Parola.Text == "")
            {
                label_Message.ForeColor = Color.Red;
                label_Message.Visible = true;
                label_Message.Text = "Alanlar Boş Bırakılmamalı!!!";
            }
            else
            {
                tbl_Uye uye = new tbl_Uye();
                uye.İsim = txt_Isim.Text;
                uye.Soyisim = txt_Soyad.Text;
                uye.Eposta = txt_Eposta.Text;
                uye.Parola = txt_Parola.Text;
                uye.DogumTarihi = dateTimePicker_DogumTarihi.Value.Date;
                uye.Yetki = "1";
                db.tbl_Uye.Add(uye);
                db.SaveChanges();

                label_Message.ForeColor = Color.Green;
                label_Message.Visible = true;
                label_Message.Text = "Kayıt Oldunuz...";
            }
        }

        private void linkLabel_GirisYap_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormLogin login = new FormLogin();
            login.Show();
            this.Hide();
        }

        private void btn_Cikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
