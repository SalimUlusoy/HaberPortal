using HaberPortal.Database.Model;
using HaberPortal.Model.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HaberPortal
{
    public partial class UC_Haberler : UserControl
    {

        public UC_Haberler()
        {
            InitializeComponent();

            GenericRepository<tbl_Haberler> db = new GenericRepository<tbl_Haberler>();
            List<tbl_Haberler> haberler = db.List();

            PaneleUserControlleriGetir(haberler);

        }

        private void PaneleUserControlleriGetir(List<tbl_Haberler> haberler)
        {
            panel_Haber.Controls.Clear();
            int x = 70, y = 10;
            UC_HaberTemp[] haberTemp = new UC_HaberTemp[haberler.Count];
            for (int i = 0; i < haberler.Count; i++)
            {

                try
                {
                    haberTemp[i] = new UC_HaberTemp(haberler[i]);
                    haberTemp[i].Location = new Point(x, y);
                    panel_Haber.Controls.Add(haberTemp[i]);
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
