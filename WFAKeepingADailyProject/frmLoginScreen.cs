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
    public partial class frmLoginScreen : Form
    {
        string password;
        public frmLoginScreen()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Uygulama giriş ekranı metodu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmLoginScreen_Load(object sender, EventArgs e)
        {


            VeriKayıtTxtDosyasıKontrol();
            SifreKayıtTxtDosyasıKontrol();

            using (StreamReader reader = new StreamReader("sifre.txt"))
            {
                password = reader.ReadLine();
            }
        }

        private void btnBilgi_Click(object sender, EventArgs e)
        {
            frmInfoScreen frmInfoScreen = new frmInfoScreen();
            frmInfoScreen.ShowDialog();
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            if (password != null)
            {
                frmPasswordScreen frmPassword = new frmPasswordScreen();
                frmPassword.ShowDialog();
            }
            else
            {
                frmNotesScreen frmNotesScreen = new frmNotesScreen();
                frmNotesScreen.ShowDialog();
            }
        }

        /// <summary>
        /// Sifre kayıt txt uzantılı dosya yoksayı kontrol et yoksa oluştur
        /// </summary>
        private static void SifreKayıtTxtDosyasıKontrol()
        {
            string sifre = "sifre.txt";
            if (!File.Exists(sifre))
            {
                string varsayilanIcerik = "";
                File.WriteAllText(sifre, varsayilanIcerik);
            }
        }

        /// <summary>
        /// Veri kayıt txt uzantılı dosya yoksayı kontrol et yoksa oluştur
        /// </summary>
        private static void VeriKayıtTxtDosyasıKontrol()
        {
            string dosyaYolu = "dosya_yolu.txt";
            if (!File.Exists(dosyaYolu))
            {
                string varsayilanIcerik = "";
                File.WriteAllText(dosyaYolu, varsayilanIcerik);
            }
        }
    }
}
