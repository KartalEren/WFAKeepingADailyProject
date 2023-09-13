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
    public partial class frmPasswordScreen : Form
    {
        int count = 0;
        string password;
        string girisSifresi;

        public frmPasswordScreen()
        {
            InitializeComponent();
        }

        private void frmPasswordScreen_Load(object sender, EventArgs e)
        {
            using (StreamReader reader = new StreamReader("sifre.txt"))
            {
                password = reader.ReadLine();
            }
        }

        /// <summary>
        /// Şifre girilen textbox dolu olması durumunda giriş butonunu aktif eden metot
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtSifreGirisi_TextChanged(object sender, EventArgs e)
        {
            if (txtSifreGirisi.Text.Length == 4)
            {
                if (txtSifreGirisi.Text == password)
                {
                    Hide();
                    frmNotesScreen frmNotesScreen = new frmNotesScreen();
                    frmNotesScreen.ShowDialog();
                }
                else
                {
                    lblUyarı.Text = "Şifre Yanlış!";
                    txtSifreGirisi.Text = "";
                    count++;
                    if (count == 1)
                    {
                        lblKalanHakUyarisi.Text = "2 hakkınız kaldı!";
                    }
                    else if (count == 2)
                    {
                        lblKalanHakUyarisi.Text = "1 hakkınız kaldı!" + "\n" + "Şifrenizi yanlış girerseniz uygulama kapanacaktır.";
                    }
                    else
                    {
                        Environment.Exit(0);
                    }
                }
            }
        }
    }
}
