using HaberPortal.Database.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HaberPortal
{
    public partial class FormAnaSayfa : Form
    {

        public class KullaniciNickName
        {
            public static string NickName;
        }

        private bool isCollapsed;

        UC_SonDakika ucSonDakika = new UC_SonDakika();
        UC_AnaSayfa ucAnaSayfa = new UC_AnaSayfa();
        UC_Haberler ucHaberler = new UC_Haberler();
        UC_Spor ucSpor = new UC_Spor();
        UC_Dunya ucDunya = new UC_Dunya();
        UC_Seyahat ucSeyahat = new UC_Seyahat();
        UC_Ekonomi ucEkonomi = new UC_Ekonomi();
        UC_Ayarlar ucAyarlar = new UC_Ayarlar();


        int Move;
        int Mouse_X;
        int Mouse_Y;

        public FormAnaSayfa()
        {
            InitializeComponent();

            isCollapsed = true;
            timer_Zaman.Start();
            this.panel_AnaSayfa.AutoScroll = true;
            UserControlGetir(ucAnaSayfa);


            HaberlerEntities1 db = new HaberlerEntities1();
            if(FormLogin.UyeId.Id != null)
            {
                tbl_Uye uye = db.tbl_Uye.Find(int.Parse(FormLogin.UyeId.Id));
                lbl_KullaniciAdi.Text = uye.İsim + " " + uye.Soyisim;
            }
            else
            {
                lbl_KullaniciAdi.Text = "Ziyaretçi";
            }
            
            if(FormLogin.UyeYetki.Yetki == "2")
            {
                btn_Ayarlar.Visible = true;
            }
            else
            {
                btn_Ayarlar.Visible = false;
            }

            KullaniciNickName.NickName = lbl_KullaniciAdi.Text;

            foreach (IPAddress adres in Dns.GetHostAddresses(Dns.GetHostName()))

            {
                label1.Text = adres.ToString();
            }
            DateTime myDateTime = DateTime.Now;

            tbl_Trafik trafik = new tbl_Trafik();
            trafik.ip = label1.Text;
            trafik.GirisSaat = myDateTime.TimeOfDay;
            trafik.GirisTarih = myDateTime.Date;

            db.tbl_Trafik.Add(trafik);
            db.SaveChanges();


            var kisiTrafik = db.tbl_Trafik.ToList();
            lbl_GirisSayisi.Text = kisiTrafik.Count().ToString();

        }

        private void panel_FormBorder_MouseUp(object sender, MouseEventArgs e)
        {
            Move = 0;
        }

        private void panel_FormBorder_MouseDown(object sender, MouseEventArgs e)
        {
            Move = 1;
            Mouse_X = e.X;
            Mouse_Y = e.Y;
        }

        private void panel_FormBorder_MouseMove(object sender, MouseEventArgs e)
        {
            if (Move == 1)
            {
                this.SetDesktopLocation(MousePosition.X - Mouse_X, MousePosition.Y - Mouse_Y);
            }
        }
        private void UserControlGetir(Control userControl)
        {
            userControl.Dock = DockStyle.Fill;
            panel_AnaSayfa.Controls.Clear();
            panel_AnaSayfa.Controls.Add(userControl);
        }
        private void SecimHareketEttir(Control btn)
        {
            panel_Secim.Top = btn.Top;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (isCollapsed)
            {
                panel_DropDown.Height += 10;
                if(panel_DropDown.Size == panel_DropDown.MaximumSize)
                {
                    timer1.Stop();
                    isCollapsed = false;
                }
            }
            else
            {
                panel_DropDown.Height -= 10;
                if (panel_DropDown.Size == panel_DropDown.MinimumSize)
                {
                    timer1.Stop();
                    isCollapsed = true;
                }
            }
        }

        private void timer_Zaman_Tick(object sender, EventArgs e)
        {
            DateTime dt = DateTime.Now;
            label_Zaman.Text = dt.ToString("HH:mm:ss");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_SonDakika_Click(object sender, EventArgs e)
        {
            SecimHareketEttir(btn_SonDakika);
            UserControlGetir(ucSonDakika);
        }

        private void btn_Haberler_Click(object sender, EventArgs e)
        {
            SecimHareketEttir(btn_Haberler);
            UserControlGetir(ucHaberler);
        }

        private void btn_AnaSayfa_Click(object sender, EventArgs e)
        {
            SecimHareketEttir(btn_AnaSayfa);
            UserControlGetir(ucAnaSayfa);
        }

        private void btn_DropDown_Click(object sender, EventArgs e)
        {
            SecimHareketEttir(panel_DropDown);
            timer1.Start();
        }

        private void btn_Spor_Click(object sender, EventArgs e)
        {
            UserControlGetir(ucSpor);
        }

        private void btn_Ekonomi_Click(object sender, EventArgs e)
        {
            UserControlGetir(ucEkonomi);
        }

        private void btn_Dunya_Click(object sender, EventArgs e)
        {
            UserControlGetir(ucDunya);
        }

        private void btn_Seyahat_Click(object sender, EventArgs e)
        {
            UserControlGetir(ucSeyahat);
        }

        private void btn_Ayarlar_Click(object sender, EventArgs e)
        {
            SecimHareketEttir(btn_Ayarlar);
            UserControlGetir(ucAyarlar);
        }
    }
}
