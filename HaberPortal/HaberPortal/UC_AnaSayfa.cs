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
    public partial class UC_AnaSayfa : UserControl
    {
        public class UserDisplayName
        {
            public static string Id;
        }

        public UC_AnaSayfa()
        {
            InitializeComponent();

            GenericRepository<tbl_Haberler> db = new GenericRepository<tbl_Haberler>();
            List<tbl_Haberler> haberler = db.List();

            PaneleUserControlleriGetir(haberler);
        }
        private void PaneleUserControlleriGetir(List<tbl_Haberler> haberler)
        {
            var habers = haberler.Where(h => h.Tur == "Ana Haber").OrderByDescending(h => h.Id).ToList();

            panel_AnaHaberler.Controls.Clear();
            int x = 70, y = 10;
            UC_HaberTemp[] haberTemp = new UC_HaberTemp[habers.Count()];
            for (int i = 0; i < habers.Count(); i++)
            {

                try
                {
                    haberTemp[i] = new UC_HaberTemp(habers[i]);
                    UserDisplayName.Id = habers[i].Id.ToString();
                    haberTemp[i].Location = new Point(x, y);
                    panel_AnaHaberler.Controls.Add(haberTemp[i]);
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
