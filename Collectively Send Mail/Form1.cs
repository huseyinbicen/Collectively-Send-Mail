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
using ExcelDataReader;
using System.Net.Mail;
using System.Net;
using System.Threading;

namespace Collectively_Send_Mail
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<string> Ad = new List<string>();
        List<string> Mail = new List<string>();
        string resimYolu;
        Thread th;
        int index = 0;

        private void btn_Excel_Click(object sender, EventArgs e)
        {
            OpenFileDialog excel = new OpenFileDialog();
            excel.InitialDirectory = "C:\\Users\\Hüseyin\\Desktop";
            excel.Filter = "Excel Dosyası |*.xlsx| Excel Dosyası|*.xls";
            excel.FilterIndex = 2;
            excel.Title = "Lütfen Ecxel Dosyasını Seçiniz!";
            excel.ShowDialog();
            lbl_Excel.Text = excel.FileName;


            //Dosyanın okunacağı dizin
            string filePath = lbl_Excel.Text;

            //Dosyayı okuyacağımı ve gerekli izinlerin ayarlanması.
            FileStream stream = File.Open(filePath, FileMode.Open, FileAccess.Read);
            IExcelDataReader excelReader;

            
            int counter = 0;

            //Gönderdiğim dosya xls'mi xlsx formatında mı kontrol ediliyor.
            if (Path.GetExtension(filePath).ToUpper() == ".XLS")
            {
                //Reading from a binary Excel file ('97-2003 format; *.xls)
                excelReader = ExcelReaderFactory.CreateBinaryReader(stream);
            }
            else
            {
                //Reading from a OpenXml Excel file (2007 format; *.xlsx)
                excelReader = ExcelReaderFactory.CreateOpenXmlReader(stream);
            }

            

            //Veriler okunmaya başlıyor.
            while (excelReader.Read())
            {
                counter++;

                //ilk satır başlık olduğu için 2.satırdan okumaya başlıyorum.
                if (counter > 1)
                {
                    Ad.Add(excelReader.GetString(0));
                    Mail.Add(excelReader.GetString(1));
                }
            }

            //Okuma bitiriliyor.
            excelReader.Close();

          
      
        }

        private void btn_Resim_Click(object sender, EventArgs e)
        {
            OpenFileDialog resim = new OpenFileDialog();
            resim.InitialDirectory = "C:\\Users\\Hüseyin\\Desktop";
            resim.Filter = "Resim Dosyası |*.jpg| Resim Dosyası|*.png";
            resim.FilterIndex = 2;
            resim.Title = "Lütfen Resim Dosyasını Seçiniz!";
            resim.ShowDialog();
            lbl_Resim.Text = resim.FileName;
            resimYolu = resim.FileName;
        }

        private  void btn_Send_Click(object sender, EventArgs e)
        {
            Thread th1 = new Thread(sayac);
            Thread th2 = new Thread(cagir);

            for (int i = 0; i < Ad.Count; i++)
            {
                th1.Start();
              //  th2.Start();
                index += 1;
            }

            MessageBox.Show("Mailler İletildi.");
        }


        public void sayac()
        {
            label9.Text = (index + 1) + ". mail gönderildi. Toplam: " + Ad.Count;
        }

        public void cagir()
        {
            Gonder_Metot(Ad[index], Mail[index]);
        }

        public void Gonder_Metot(string ad, string maill)
        {
            string icerikGecici = txt_Message.Text;
            icerikGecici = icerikGecici.Replace(".....", ad);


            SmtpClient sc = new SmtpClient();
            sc.Port = 587;
            sc.Host = "smtp.gmail.com";
            sc.EnableSsl = true;

            string kime = maill;
            string konu = txt_Subject.Text;
            string icerik = icerikGecici;

            sc.Credentials = new NetworkCredential(txt_Mail.Text, txt_Password.Text);
            MailMessage mail = new MailMessage();
            mail.From = new MailAddress(txt_Mail.Text, txt_AdSoyad.Text);
            mail.To.Add(kime);
            //mail.To.Add("alici2@mail.com");
            mail.Subject = konu;
            mail.IsBodyHtml = true;
            mail.Body = icerik;
            mail.Attachments.Add(new Attachment(resimYolu));
            sc.Send(mail);
        }
    }
}
