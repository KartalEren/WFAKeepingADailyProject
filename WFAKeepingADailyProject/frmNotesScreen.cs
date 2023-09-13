using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WFAKeepingADailyProject.Properties;
using static System.Windows.Forms.DataFormats;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace WFAKeepingADailyProject
{



    public partial class frmNotesScreen : Form
    {

        //Dizi elemanlarının başlıklarıdır.
        string metinIcerik, fileName, baslik;

        string kaynakDosyaAdiKisa;
        string kaynakDosyaAdi;
        string hedefDosyaAdi;

        bool kayıtOlduMu = false;
        bool textClear;

        //DateTime Key li ve string 3 elemanlı dizidir.
        SortedList<DateTime, string[]> veriDizisi = new SortedList<DateTime, string[]>();



        /// <summary>
        /// Takvimde ileri günlerin gösterilmesini kısıtlayan metottur..
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// 

        public frmNotesScreen()
        {
            InitializeComponent();
        }

        private void frmNotesScreen_Load(object sender, EventArgs e)
        {

            monthCalendar1.MaxDate = DateTime.Today;
            richTextBoxBaslik.Font = new Font("Century", 14, FontStyle.Italic);
            richTextBoxMetin.Font = new Font("Century", 12, FontStyle.Italic);
            lstDizi.Font = new Font("Century", 11, FontStyle.Italic);

            frmMain frmMain = new frmMain();
            frmNotesScreen frmNotesScreen = new frmNotesScreen();
            frmNotesScreen.MdiParent = frmMain;
            frmNotesScreen.Dock = DockStyle.Fill;
            frmNotesScreen.FormBorderStyle = FormBorderStyle.None;
            frmNotesScreen.Show();

            if (!File.Exists("ImagesFile"))
            {
                Directory.CreateDirectory(Application.StartupPath + @"ImagesFile");
            }

            VeriyiGeriGetir();
        }

        /// <summary>
        /// Metin içeriğine kullanıcının seçeceği resmi eklemesi için kullanılan metottur.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAddPicture_Click(object sender, EventArgs e)
        {


            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                fileName = openFileDialog.FileName;

                kaynakDosyaAdi = openFileDialog.FileName;
                kaynakDosyaAdiKisa = Path.GetFileName(kaynakDosyaAdi);
                hedefDosyaAdi = Path.Combine(Application.StartupPath, "ImagesFile", kaynakDosyaAdiKisa);
                File.Copy(kaynakDosyaAdi, hedefDosyaAdi, true);

                pictureBoxResim.Image = Image.FromFile(hedefDosyaAdi);
            }
        }



        /// <summary>
        /// Metin içeriğine kullanıcının seçeceği resmi silmesi için kullanılan metottur.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDeletePicture_Click(object sender, EventArgs e)
        {
            pictureBoxResim.Image = null;
        }



        /// <summary>
        /// Kullanıcının girdiği içeriği ve resmi listeye ekleyen metottur. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (monthCalendar1.SelectionStart == DateTime.Today)
                kayıtOlduMu = true;

            baslik = richTextBoxBaslik.Text;
            metinIcerik = richTextBoxMetin.Text;
            if (lstDizi.Items.Contains(DateTime.Today))
            {

                veriDizisi.Remove(monthCalendar1.SelectionStart);
            }
            veriDizisi.Add(monthCalendar1.SelectionStart, new string[] { baslik, metinIcerik, hedefDosyaAdi });
            /*sortedlistte 3 elemanlı dizi oluşturuldu*/

            foreach (var item in veriDizisi)
            {
                if (lstDizi.Items.Contains(item.Key))
                {
                    lstDizi.Items.Remove(item.Key);
                }
                lstDizi.Items.Add(item.Key);
                textClear = true;
            }

            VeriyiKaydet();

            hedefDosyaAdi = string.Empty;
            pictureBoxResim.Image = null;


        }



        /// <summary>
        /// ListBox'daki verileri RichBox ve PictureBox'a geri yazdıran metottur.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lstDizi_DoubleClick(object sender, EventArgs e)
        {
            IcerikTemizle();

            foreach (var item in veriDizisi)
            {
                if (lstDizi.SelectedItems.Contains(item.Key))
                {
                    if (item.Key == DateTime.Today)
                    {

                        TumButonVeRichTextlerTrue();
                        richTextBoxBaslik.Text = item.Value[0];
                        richTextBoxMetin.Text = item.Value[1];
                        if (!string.IsNullOrEmpty(item.Value[2]))
                            pictureBoxResim.Image = Image.FromFile(item.Value[2]);
                    }
                    else
                    {
                        TumButonVeRichTextlerFalse();
                        richTextBoxBaslik.Text = item.Value[0];
                        richTextBoxMetin.Text = item.Value[1];
                        if (!string.IsNullOrEmpty(item.Value[2]))
                            pictureBoxResim.Image = Image.FromFile(item.Value[2]);
                    }
                }
            }
        }

        /// <summary>
        /// Kullanıcı tarafıdan girilen içerikleri temizleyen metottur
        /// </summary>
        private void IcerikTemizle()
        {
            richTextBoxBaslik.Clear();
            richTextBoxMetin.Clear();
            pictureBoxResim.Image = null;
        }



        /// <summary>
        /// Seçilen gün değiştiğinde kayıtlı olan bilgileri getiren metot
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {

            IcerikTemizle();


            if (monthCalendar1.SelectionStart == DateTime.Today)
            {

                TumButonVeRichTextlerTrue();
                if (kayıtOlduMu)
                    VerileriNesnelereAtama();
                else
                    MessageBox.Show("Lütfen Başlık ve Metin Giriniz");
            }
            else
            {

                if (veriDizisi.ContainsKey(monthCalendar1.SelectionStart))
                {
                    TumButonVeRichTextlerFalse();
                    VerileriNesnelereAtama();

                }
                else
                {

                    TumButonVeRichTextlerTrue();
                }

            }
        }

        private void VerileriNesnelereAtama()
        {
            var ok = veriDizisi.FirstOrDefault(x => x.Key.Equals(monthCalendar1.SelectionStart)).Value;
            richTextBoxBaslik.Text = ok[0].ToString();
            richTextBoxMetin.Text = ok[1].ToString();
            if (!string.IsNullOrEmpty(ok[2]))
            {
                pictureBoxResim.Image = Image.FromFile(ok[2]);
            }
        }



        /// <summary>
        /// Uygulama içerisine yazılan bilgileri txt dosyasına kaydeden metot
        /// </summary>
        private void VeriyiKaydet()
        {
            // StreamWriter ile dosyayı açma
            using (StreamWriter writer = new StreamWriter("dosya_yolu.txt"))
            {
                // SortedList'in tüm anahtar-değer çiftlerini döndürür
                foreach (KeyValuePair<DateTime, string[]> pair in veriDizisi)
                {
                    // Anahtar ve değerleri dosyaya yazma
                    writer.WriteLine("{0} - {1}", pair.Key, string.Join(", ", pair.Value));
                }
            }
        }


        /// <summary>
        /// Uygulama içerisinde txt dosyasına kaydedilen verileri programa geri yükleyen metot
        /// </summary>
        private void VeriyiGeriGetir()
        {
            // StreamReader ile dosyayı açma
            using (StreamReader reader = new StreamReader("dosya_yolu.txt"))
            {
                string line;
                // Dosyanın sonuna kadar her satırı okuma
                while ((line = reader.ReadLine()) != null)
                {
                    // Satırı ayırma işlemi yap
                    string[] parts = line.Split(new string[] { " - " }, StringSplitOptions.None);

                    // DateTime ve string[] türlerine dönüştürme işlemi yap
                    DateTime key = DateTime.Parse(parts[0]);
                    string[] values = parts[1].Split(new string[] { ", " }, StringSplitOptions.None);

                    // SortedList'e ekleme işlemi yap

                    veriDizisi.Add(key, values);
                }
            }

            foreach (var item in veriDizisi)
            {
                if (lstDizi.Items.Contains(item.Key))
                {
                    lstDizi.Items.Remove(item.Key);
                }
                lstDizi.Items.Add(item.Key);
                textClear = true;
            }
        }



        /// <summary>
        /// Uygulamada tüm buton ve richtextboxları false yapan metot
        /// </summary>
        private void TumButonVeRichTextlerTrue()
        {
            btnKaydet.Enabled = true;
            btnAddPicture.Enabled = true;
            btnDeletePicture.Enabled = true;
            richTextBoxBaslik.Enabled = true;
            richTextBoxMetin.Enabled = true;

            richTextBoxBaslik.Text = "Başlık giriniz";
            richTextBoxMetin.Text = "İçerik giriniz";
        }



        /// <summary>
        /// Uygulamada tüm buton ve richtextboxları true yapan metot
        /// </summary>
        private void TumButonVeRichTextlerFalse()
        {
            btnKaydet.Enabled = false;
            btnAddPicture.Enabled = false;
            btnDeletePicture.Enabled = false;
            richTextBoxBaslik.Enabled = false;
            richTextBoxMetin.Enabled = false;
        }


        private void richTextBoxBaslik_MouseClick(object sender, MouseEventArgs e)
        {
            richTextBoxMetin.Font = new Font("Century", 12, FontStyle.Italic);

            if (richTextBoxBaslik.Text == "Başlık giriniz")
            {
                richTextBoxBaslik.Text = "";
            }
            else
            {
                return;
            }
        }


        private void richTextBoxMetin_MouseClick(object sender, MouseEventArgs e)
        {
            richTextBoxBaslik.Font = new Font("Century", 14, FontStyle.Italic);
            if (richTextBoxMetin.Text == "İçerik giriniz")
            {
                richTextBoxMetin.Text = "";
            }
            else
            {
                return;
            }
        }

        private void frmNotesScreen_FormClosing(object sender, FormClosingEventArgs e)
        {
            frmPasswordGenerate sifreOlusturmaEkranı = new frmPasswordGenerate();
            sifreOlusturmaEkranı.ShowDialog();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblSaat.Text = DateTime.Now.ToLongTimeString();
        }

        private void btnAddPicture_MouseEnter(object sender, EventArgs e)
        {
            lblEkle.Visible = true;
        }

        private void btnAddPicture_MouseLeave(object sender, EventArgs e)
        {
            lblEkle.Visible = false;
        }

        private void btnDeletePicture_MouseEnter(object sender, EventArgs e)
        {
            lblResimSil.Visible = true;
        }

        private void btnDeletePicture_MouseLeave(object sender, EventArgs e)
        {
            lblResimSil.Visible = false;
        }

        private void btnKaydet_MouseEnter(object sender, EventArgs e)
        {
            lblKaydet.Visible = true;
        }

        private void btnKaydet_MouseLeave(object sender, EventArgs e)
        {
            lblKaydet.Visible = false;
        }

        private void btnGoruntule_MouseEnter(object sender, EventArgs e)
        {
            lblKaydıPenceredeAc.Visible = true;
        }

        private void btnGoruntule_MouseLeave(object sender, EventArgs e)
        {
            lblKaydıPenceredeAc.Visible = false;
        }

        private void pbxBilgi_MouseEnter(object sender, EventArgs e)
        {
            lblBilgi.Visible = true;
        }

        private void pbxBilgi_MouseLeave(object sender, EventArgs e)
        {
            lblBilgi.Visible = false;
        }

        public SortedList<string, frmGoruntule> childListesi = new SortedList<string, frmGoruntule>();

        private void btnGoruntule_Click(object sender, EventArgs e)
        {
            frmGoruntule newChild = new frmGoruntule();
            newChild.Text += childListesi.Count;

            childListesi.Add(newChild.Text, newChild);

            newChild.MdiParent = this.MdiParent;


            newChild.TopMost = true;

            string childbaslık = richTextBoxBaslik.Text;
            string childicerik = richTextBoxMetin.Text;
            Image imageVariable = pictureBoxResim.Image;

            newChild.SetChildText(childbaslık, childicerik);
            newChild.SetChildImage(imageVariable);


            newChild.Show();
        }

        private void pbxBilgi_Click(object sender, EventArgs e)
        {
            frmInfoScreen frmInfoScreen = new frmInfoScreen();
            frmInfoScreen.ShowDialog();
        }
    }
}
