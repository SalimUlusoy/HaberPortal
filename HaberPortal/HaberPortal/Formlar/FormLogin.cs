using HaberPortal.Database.Model;
using HaberPortal.Formlar;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HaberPortal
{
    public partial class FormLogin : Form
    {
        HaberlerEntities1 db = new HaberlerEntities1();
        public class UyeId
        {
            public static string Id;
        }

        public class UyeYetki
        {
            public static string Yetki;
        }
        public FormLogin()
        {
            InitializeComponent();

            Load += FormLogin_Load;
            label_Message.Visible = false;
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {
        }

        private void btn_Cikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_GirisYap_Click(object sender, EventArgs e)
        {
            tbl_Uye uye = db.tbl_Uye.Where(u => u.Eposta == txt_Eposta.Text && u.Parola == txt_Parola.Text).FirstOrDefault();
            if (uye != null)
            {
                UyeId.Id = uye.Id.ToString();
                UyeYetki.Yetki = uye.Yetki.ToString();
                FormAnaSayfa anasayfa = new FormAnaSayfa();
                anasayfa.Show();
                this.Hide();
            }
            else
            {
                label_Message.Visible = true;
                label_Message.Text = "Kullanıcı Bulunamadi. Şifre Değiştiriniz veya Üye Değilseniz Üye Olunuz!";
            }
        }

        private void linkLabel_Kayit_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormRegister register = new FormRegister();
            register.Show();
            this.Hide();
        }

        private void linkLabel_SifremiUnuttum_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if(txt_Eposta.Text != "")
            {
                try
                {
                    tbl_Uye uyesifre = db.tbl_Uye.AsNoTracking().FirstOrDefault(u => u.Eposta == txt_Eposta.Text);

                    if (uyesifre != null)
                    {
                        MailMessage mailMessage = new MailMessage();

                        StringBuilder sbEmailBody = new StringBuilder();
                        sbEmailBody.Append("Sayın " + uyesifre.İsim + uyesifre.Soyisim + ",<br/><br/>");
                        sbEmailBody.Append("Bu bir şifre hatırlatma E-Postasıdır Lütfen Şifrenizi Kimseyle Paylaşmayınız");
                        sbEmailBody.Append("<br/>"); sbEmailBody.Append("Şifreniz: " + uyesifre.Parola);
                        sbEmailBody.Append("<br/><br/>");
                        sbEmailBody.Append("<b>Haber Portal</b>");

                        mailMessage.IsBodyHtml = true;

                        mailMessage.Body = sbEmailBody.ToString();
                        mailMessage.Subject = "Şifreniz";
                        SmtpClient smtpClient = new SmtpClient("smtp.gmail.com", 587);

                        smtpClient.Credentials = new System.Net.NetworkCredential()
                        {
                            UserName = "salimulusoy25@gmail.com",
                            Password = "salimkral2E"
                        };
                        string to = uyesifre.Eposta;
                        string from = "salimulusoy25@gmail.com";

                        smtpClient.EnableSsl = true;

                        mailMessage.From = new MailAddress(from);
                        mailMessage.To.Add(to);
                        smtpClient.Send(mailMessage);
                        smtpClient.UseDefaultCredentials = false;

                        MessageBox.Show("Şifreniz Başarı İle Gönderilmiştir.");
                    }
                    else
                    {
                        MessageBox.Show("Kullanıcı sistemde bulamadı.");
                    }
                }
                catch (Exception hata)
                {

                    label_Message.Text = hata.Message;
                }
            }
            else
            {
                MessageBox.Show("Eposta Adresi Kısmı Boş Olmamalıdır!!!");
            }

        }

        private void linkLabel_Ziyaretci_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormAnaSayfa anasayfa = new FormAnaSayfa();
            anasayfa.Show();
            this.Hide();
        }
    }
}
