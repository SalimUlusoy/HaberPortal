using HaberPortal.Formlar;
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
    public partial class UC_Ayarlar : UserControl
    {
        public UC_Ayarlar()
        {
            InitializeComponent();
        }

        private void linkLabel_HaberEkle_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormHaberEkle hbrekle = new FormHaberEkle();
            hbrekle.ShowDialog();
        }
    }
}
