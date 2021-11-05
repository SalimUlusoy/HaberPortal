using HaberPortal.Database.Model;
using HaberPortal.Model.Repository;
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
    public partial class FormHaberDetay : Form
    {
        public FormHaberDetay()
        {
            InitializeComponent();

            if(FormAnaSayfa.KullaniciNickName.NickName == "Ziyaretçi")
            {
                richTextBox_Yorum.Enabled = false;
                btn_YorumEkle.Enabled = false;
            }
            else
            {
                richTextBox_Yorum.Enabled = true;
                btn_YorumEkle.Enabled = true;
            }

            GenericRepository<tbl_Yorum> dbs = new GenericRepository<tbl_Yorum>();
            List<tbl_Yorum> yorumlar = dbs.List();

            PaneleYorumGetir(yorumlar);

            using (HaberlerEntities1 db = new HaberlerEntities1())
            {

                tbl_Haberler hbr = db.tbl_Haberler.Find(int.Parse(UC_HaberTemp.UserDisplayName.Id));
                label_Paylasim.Text = hbr.Paylasildi.ToString();
                label_Begeni.Text = hbr.BeğeniSayisi.ToString();
                lbl_YorumSayisi.Text = hbr.YorumSayisi.ToString();
                label_Okundu.Text = hbr.Okundu.ToString();
                label_Baslik.Text = hbr.AnaBaslik;
                label_HaberOzet.Text = hbr.HaberYazisi;
            }
        }

        private void btn_GeriDon_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btn_Like_Click(object sender, EventArgs e)
        {
            using (HaberlerEntities1 db = new HaberlerEntities1())
            {
                tbl_Haberler hbr = db.tbl_Haberler.Find(int.Parse(UC_HaberTemp.UserDisplayName.Id));
                hbr.BeğeniSayisi += 1;
                db.SaveChanges();

                label_Begeni.Text = hbr.BeğeniSayisi.ToString();
            }


        }

        private void btn_Share_Click(object sender, EventArgs e)
        {
            using (HaberlerEntities1 db = new HaberlerEntities1())
            {
                tbl_Haberler hbr = db.tbl_Haberler.Find(int.Parse(UC_HaberTemp.UserDisplayName.Id));
                hbr.Paylasildi += 1;
                db.SaveChanges();

                label_Paylasim.Text = hbr.Paylasildi.ToString();
            }
            System.Diagnostics.Process.Start("www.twitter.com/intent/tweet");
        }

        private void btn_YorumEkle_Click(object sender, EventArgs e)
        {

            if (richTextBox_Yorum.Text != "")
            {
                using (HaberlerEntities1 db = new HaberlerEntities1())
                {
                    tbl_Yorum yrm = new tbl_Yorum();
                    yrm.Yorum = richTextBox_Yorum.Text;
                    yrm.UyeNo = int.Parse(FormLogin.UyeId.Id);
                    yrm.HaberNo = int.Parse(UC_HaberTemp.UserDisplayName.Id);
                    yrm.Tarih = DateTime.Now;
                    tbl_Uye uye = db.tbl_Uye.Find(int.Parse(FormLogin.UyeId.Id));
                    yrm.KullaniciAdi = uye.İsim + " " + uye.Soyisim;
                    tbl_Haberler hbr = db.tbl_Haberler.Find(int.Parse(UC_HaberTemp.UserDisplayName.Id));
                    hbr.YorumSayisi += 1;
                    db.tbl_Yorum.Add(yrm);
                    db.SaveChanges();

                    lbl_YorumSayisi.Text = hbr.YorumSayisi.ToString();

                    GenericRepository<tbl_Yorum> dbs = new GenericRepository<tbl_Yorum>();
                    List<tbl_Yorum> yorumlar = dbs.List();

                    PaneleYorumGetir(yorumlar);
                }
            }
            else
            {
                MessageBox.Show("Yorum Bölümü Boş Olmamalıdır!!!");
            }
        }
        private void PaneleYorumGetir(List<tbl_Yorum> yorumlar)
        {
            var yorums = yorumlar.Where(z => z.HaberNo == int.Parse(UC_HaberTemp.UserDisplayName.Id)).ToList();

            panel_Yorum.Controls.Clear();
            int x = 10, y = 10;
            UC_YorumTemp[] yorumTemp = new UC_YorumTemp[yorums.Count];
            for (int i = 0; i < yorums.Count; i++)
            {

                try
                {
                    yorumTemp[i] = new UC_YorumTemp(yorums[i]);
                    yorumTemp[i].Location = new Point(x, y);
                    panel_Yorum.Controls.Add(yorumTemp[i]);
                    /*
                     * 
                     */

                        x = 10;
                        y = y + yorumTemp[i].Height + 5;
                }
                catch (Exception hata)
                {
                }
            }
        }
    }
}
