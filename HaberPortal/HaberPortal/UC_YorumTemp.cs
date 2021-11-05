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

namespace HaberPortal
{
    public partial class UC_YorumTemp : UserControl
    {
        public UC_YorumTemp()
        {
            InitializeComponent();
        }

        public UC_YorumTemp(tbl_Yorum yorumlar)
        {
            InitializeComponent();
            lbl_KullaniciAdi.Text = yorumlar.KullaniciAdi;
            lbl_YorumKismi.Text = yorumlar.Yorum;
            lbl_HaberTarih.Text = yorumlar.Tarih.ToString();
        }
    }
}
