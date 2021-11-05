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
    public partial class FormHaberEkle : Form
    {
        public FormHaberEkle()
        {
            InitializeComponent();
            HaberleriListele();
            Temizle();
        }

        private void Temizle()
        {
            textBox_HaberBaslik.Text = "";
            textBox_HaberOzet.Text = "";
            txt_Id.Text = "0";
            textBox_HaberTur.Text = "";
            richTextBox_HaberYazi.Text = "";
        }

        private void HaberleriListele()
        {
            using (HaberlerEntities1 db = new HaberlerEntities1())
            {
                dataGridView_Haberler.DataSource = db.tbl_Haberler.AsNoTracking()
                                            .Select(s => new
                                            {
                                                Id = s.Id,
                                                AnaBaslik = s.AnaBaslik,
                                                HaberOzet = s.HaberOzet,
                                                HaberYazisi = s.HaberYazisi,
                                                Tur = s.Tur
                                            }).ToList();
            }
        }
        private void btn_GeriDon_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void txt_Id_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txt_Id.Text))
            {
                if (txt_Id.Text != "0")
                {
                    btn_Guncelle.Enabled = true;
                    btn_Sil.Enabled = true;
                }
                else
                {
                    btn_Guncelle.Enabled = false;
                    btn_Sil.Enabled = false;
                }

            }
            else
            {
                btn_Guncelle.Enabled = false;
                //btn_Sil.Enabled = false;
            }
        }

        private void dataGridView_Haberler_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_Id.Text = dataGridView_Haberler.CurrentRow.Cells["Id"].Value.ToString();
            textBox_HaberBaslik.Text = dataGridView_Haberler.CurrentRow.Cells["AnaBaslik"].Value.ToString();
            textBox_HaberOzet.Text = dataGridView_Haberler.CurrentRow.Cells["HaberOzet"].Value.ToString();
            textBox_HaberTur.Text = dataGridView_Haberler.CurrentRow.Cells["Tur"].Value.ToString();
            richTextBox_HaberYazi.Text = dataGridView_Haberler.CurrentRow.Cells["HaberYazisi"].Value.ToString();
        }

        private void btn_Guncelle_Click(object sender, EventArgs e)
        {
            using (HaberlerEntities1 db = new HaberlerEntities1())
            {
                tbl_Haberler hbr = db.tbl_Haberler.Find(int.Parse(txt_Id.Text));
                hbr.AnaBaslik = textBox_HaberBaslik.Text;
                hbr.HaberOzet = textBox_HaberOzet.Text;
                hbr.Tur = textBox_HaberTur.Text;
                hbr.HaberYazisi = richTextBox_HaberYazi.Text;
                db.SaveChanges();
                HaberleriListele();
            }
        }

        private void btn_Sil_Click(object sender, EventArgs e)
        {
            using (HaberlerEntities1 db = new HaberlerEntities1())
            {
                db.tbl_Haberler.Remove(db.tbl_Haberler.Find(int.Parse(txt_Id.Text)));
                db.SaveChanges();
                HaberleriListele();
            }
        }

        private void btn_Ekle_Click(object sender, EventArgs e)
        {
            if(textBox_HaberBaslik != null || textBox_HaberOzet != null || textBox_HaberTur != null || richTextBox_HaberYazi != null)
            {
                using (HaberlerEntities1 db = new HaberlerEntities1())
                {
                    tbl_Haberler hbr = new tbl_Haberler();
                    hbr.AnaBaslik = textBox_HaberBaslik.Text;
                    hbr.HaberOzet = textBox_HaberOzet.Text;
                    hbr.Tur = textBox_HaberTur.Text;
                    hbr.HaberYazisi = richTextBox_HaberYazi.Text;
                    hbr.YayinTarihi = DateTime.Now.Date;
                    hbr.YayinSaati = DateTime.Now.TimeOfDay;
                    hbr.BeğeniSayisi = 0;
                    hbr.YorumSayisi = 0;
                    hbr.Okundu = 0;
                    hbr.Paylasildi = 0;
                    hbr.KategoriNo = 6;

                    db.tbl_Haberler.Add(hbr);
                    db.SaveChanges();
                    HaberleriListele();
                }
            }
            else
            {
                MessageBox.Show("Alanlar Boş Bırakılmamalı!!!");
            }
           
        }

        private void btn_Temizle_Click(object sender, EventArgs e)
        {
            Temizle();
        }
    }
}
