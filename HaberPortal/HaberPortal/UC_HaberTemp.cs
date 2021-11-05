using HaberPortal.Database.Model;
using HaberPortal.Formlar;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HaberPortal
{
    
    public partial class UC_HaberTemp : UserControl
    {
        HaberlerEntities1 db = new HaberlerEntities1();
        public class UserDisplayName
        {
            public static string Id;
        }

        public UC_HaberTemp()
        {
            InitializeComponent();
        }

        public UC_HaberTemp(tbl_Haberler haberler)
        {
            InitializeComponent();
            if(haberler.BaslikResim != null)
            {
                Byte[] data = new Byte[0];
                data = (Byte[])(haberler.BaslikResim);
                MemoryStream mem = new MemoryStream(data);
                pictureBox_Haber.Image = Image.FromStream(mem);
                lbl_HaberBaslik.Text = haberler.AnaBaslik.ToString();
                lbl_HaberIcerik.Text = haberler.HaberOzet.ToString();
                lbl_Id.Text = haberler.Id.ToString();
            }
            else
            {
                lbl_HaberBaslik.Text = haberler.AnaBaslik.ToString();
                lbl_HaberIcerik.Text = haberler.HaberOzet.ToString();
                lbl_Id.Text = haberler.Id.ToString();
            }
        }

        private void lbl_HaberBaslik_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            UserDisplayName.Id = lbl_Id.Text;

            tbl_Haberler hbr = db.tbl_Haberler.Find(int.Parse(lbl_Id.Text));
            hbr.Okundu += 1;
            db.SaveChanges();

            FormHaberDetay f = new FormHaberDetay();
            f.ShowDialog();
        }
    }
}
