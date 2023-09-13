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
    public partial class frmPasswordGenerate : Form
    {
        public frmPasswordGenerate()
        {
            InitializeComponent();
        }
        List<string> sifreOlustur = new List<string>();


        private void btnSifreOlustur_Click(object sender, EventArgs e)
        {
            try
            {
                using (StreamWriter writer = new StreamWriter("sifre.txt"))
                {
                    string sifre = txtSifreOlustur.Text;

                    sifreOlustur.Add(sifre.ToString());
                    // SortedList'in tüm anahtar-değer çiftlerini döndürür
                    foreach (var item in sifreOlustur)
                    {
                        // Anahtar ve değerleri dosyaya yazma
                        writer.Write(item);
                    }
                    MessageBox.Show("Şifre Başarıyla Oluşturuldu.");

                }
                Environment.Exit(0);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        private void txtSifreOlustur_TextChanged(object sender, EventArgs e)
        {
            lblUyarı.Visible = txtSifreOlustur.Text.Length > 0 ? true : false;
            btnSifreOlustur.Enabled = txtSifreOlustur.Text.Length == 4 ? true : false;
        }

        private void btnSifreIstemiyorum_Click(object sender, EventArgs e)
        {
            using (StreamWriter writer = new StreamWriter("sifre.txt"))
            {
                string sifre = string.Empty;
                sifreOlustur.Add(sifre.ToString());
                // SortedList'in tüm anahtar-değer çiftlerini döndürür
                foreach (var item in sifreOlustur)
                {
                    // Anahtar ve değerleri dosyaya yazma
                    writer.Write(item);
                }
            }
            Environment.Exit(0);
        }
    }

}

