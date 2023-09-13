using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFAKeepingADailyProject
{
    public partial class frmMain : Form
    {

        string password;

        public frmMain()
        {
            InitializeComponent();

            //frmNotesScreen frmNotesScreen = new frmNotesScreen();
            //frmNotesScreen.MdiParent = this;
            //frmNotesScreen.Dock = DockStyle.Fill;
            //frmNotesScreen.FormBorderStyle = FormBorderStyle.None;
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            //tsslBuGun.Text = $"---{DateTime.Today.Day}/{DateTime.Today.Month}/{DateTime.Today.Year}---";

            //VeriKayıtTxtDosyasıKontrol();
            //SifreKayıtTxtDosyasıKontrol();

            //using (StreamReader reader = new StreamReader("sifre.txt"))
            //{
            //    password = reader.ReadLine();
            //}

            //frmLoginScreen frmLoginScreen = new frmLoginScreen();
            //frmLoginScreen.MdiParent = this;
            //frmLoginScreen.Dock = DockStyle.Fill;
            //frmLoginScreen.FormBorderStyle = FormBorderStyle.None;
            //frmLoginScreen.Show();
        }

        /// <summary>
        /// Sifre kayıt txt uzantılı dosya yoksayı kontrol et yoksa oluştur
        /// </summary>
        private static void SifreKayıtTxtDosyasıKontrol()
        {
            //string sifre = "sifre.txt";
            //if (!File.Exists(sifre))
            //{
            //    string varsayilanIcerik = "";
            //    File.WriteAllText(sifre, varsayilanIcerik);
            //}
        }

        /// <summary>
        /// Veri kayıt txt uzantılı dosya yoksayı kontrol et yoksa oluştur
        /// </summary>
        private static void VeriKayıtTxtDosyasıKontrol()
        {
            //string dosyaYolu = "dosya_yolu.txt";
            //if (!File.Exists(dosyaYolu))
            //{
            //    string varsayilanIcerik = "";
            //    File.WriteAllText(dosyaYolu, varsayilanIcerik);
            //}
        }

        private void tsmGiris_Click(object sender, EventArgs e)
        {
            //if (password != null)
            //{
            //    frmPasswordScreen frmPassword = new frmPasswordScreen();
            //    frmPassword.ShowDialog();
            //}
            //else
            //{
            //    frmNotesScreen frmNotesScreen = new frmNotesScreen();
            //    frmNotesScreen.MdiParent = this;
            //    frmNotesScreen.Dock = DockStyle.Fill;
            //    frmNotesScreen.FormBorderStyle = FormBorderStyle.None;
            //    frmNotesScreen.Show();
            //}
        }

        private void tsmKapat_Click(object sender, EventArgs e)
        {
            //this.Close();
        }

        private void tsmBilgi_Click(object sender, EventArgs e)
        {
            //frmInfoScreen frmInfoScreen = new frmInfoScreen();
            //frmInfoScreen.MdiParent = this;
            //frmInfoScreen.Dock = DockStyle.Fill;
            //frmInfoScreen.FormBorderStyle = FormBorderStyle.None;
            //frmInfoScreen.Show();
        }

    }
}
