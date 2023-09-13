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
    public partial class frmGoruntule : Form
    {


        public frmGoruntule()
        {
            InitializeComponent();
            this.ParentChanged += FrmGoruntule_ParentChanged;

        }

        // ParentChanged event handler'ı
        private void FrmGoruntule_ParentChanged(object sender, EventArgs e)
        {
            // Parent değiştiğinde formun TopMost özelliğini tekrar true yap
            this.TopMost = true;
        }

        public void SetChildText(string baslik, string metin)
        {
            this.rtbBaslık.Text = baslik;
            this.rtbMetin.Text = metin;
        }

        public void SetChildImage(Image imageVariable)
        {
            this.pbResim.Image = imageVariable;
        }
    }
}
