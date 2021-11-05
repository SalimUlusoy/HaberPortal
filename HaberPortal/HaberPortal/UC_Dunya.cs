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

namespace HaberPortal
{
    public partial class UC_Dunya : UserControl
    {
        public UC_Dunya()
        {
            InitializeComponent();

            HaberlerEntities1 dbs = new HaberlerEntities1();
            int Id = 8;

            var dinamikSorgu = (from d in dbs.tbl_Haberler
                                join e in dbs.tbl_Kategori
                                on Id equals e.Id into j1

                                from r in j1.DefaultIfEmpty()

                                select new
                                {
                                    KategoriNo = d.KategoriNo,
                                    KategoriId = r.Id,
                                    KategoriAd = r.Ad,
                                }).Take(1).ToList();

            foreach (var book in dinamikSorgu)
            {
                label1.Text = book.KategoriAd;
            }

            GenericRepository<tbl_Haberler> db = new GenericRepository<tbl_Haberler>();
            List<tbl_Haberler> haberler = db.List();

            PaneleUserControlleriGetir(haberler);
        }

        private void PaneleUserControlleriGetir(List<tbl_Haberler> haberler)
        {
            var habers = haberler.Where(h => h.KategoriNo == 8).ToList();
            panel_DunyaHaberleri.Controls.Clear();
            int x = 70, y = 10;
            UC_HaberTemp[] haberTemp = new UC_HaberTemp[habers.Count()];
            for (int i = 0; i < habers.Count(); i++)
            {
                try
                {
                    haberTemp[i] = new UC_HaberTemp(habers[i]);
                    haberTemp[i].Location = new Point(x, y);
                    panel_DunyaHaberleri.Controls.Add(haberTemp[i]);
                    /*
                     * 
                     */

                    if (i % 2 == 0)
                    {
                        x = (150 + haberTemp[i].Width);

                    }
                    else
                    {
                        x = 70;
                        y = y + haberTemp[i].Height + 30;
                    }
                }
                catch (Exception hata)
                {
                }

            }
        }
    }
}
