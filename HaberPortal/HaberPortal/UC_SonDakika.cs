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
    public partial class UC_SonDakika : UserControl
    {
        public UC_SonDakika()
        {
            InitializeComponent();

            GenericRepository<tbl_Haberler> db = new GenericRepository<tbl_Haberler>();
            List<tbl_Haberler> haberler = db.List();

            PaneleUserControlleriGetir(haberler);
        }
        private void PaneleUserControlleriGetir(List<tbl_Haberler> haberler)
        {
            var habers = haberler.OrderByDescending(h => h.Id).Take(5).ToList();
            panel_SonDakikaHaber.Controls.Clear();
            int x = 70, y = 10;
            UC_HaberTemp[] haberTemp = new UC_HaberTemp[habers.Count()];
            for (int i = 0; i < habers.Count(); i++)
            {

                try
                {
                    haberTemp[i] = new UC_HaberTemp(habers[i]);
                    haberTemp[i].Location = new Point(x, y);
                    panel_SonDakikaHaber.Controls.Add(haberTemp[i]);
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
