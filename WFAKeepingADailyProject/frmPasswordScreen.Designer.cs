namespace WFAKeepingADailyProject
{
    partial class frmPasswordScreen
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            txtSifreGirisi = new TextBox();
            pictureBox1 = new PictureBox();
            lblUyarı = new Label();
            lblKalanHakUyarisi = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.White;
            label1.Font = new Font("Century", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(18, 51);
            label1.Name = "label1";
            label1.Size = new Size(96, 18);
            label1.TabIndex = 0;
            label1.Text = "Şifre Girin : ";
            // 
            // txtSifreGirisi
            // 
            txtSifreGirisi.BorderStyle = BorderStyle.FixedSingle;
            txtSifreGirisi.Location = new Point(125, 49);
            txtSifreGirisi.MaxLength = 4;
            txtSifreGirisi.Name = "txtSifreGirisi";
            txtSifreGirisi.Size = new Size(232, 23);
            txtSifreGirisi.TabIndex = 1;
            txtSifreGirisi.TextChanged += txtSifreGirisi_TextChanged;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = Properties.Resources.MicrosoftTeams_image__7_;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(390, 170);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // lblUyarı
            // 
            lblUyarı.BackColor = Color.White;
            lblUyarı.Font = new Font("Century", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblUyarı.ForeColor = Color.Red;
            lblUyarı.Location = new Point(254, 51);
            lblUyarı.Name = "lblUyarı";
            lblUyarı.Size = new Size(101, 19);
            lblUyarı.TabIndex = 4;
            // 
            // lblKalanHakUyarisi
            // 
            lblKalanHakUyarisi.BackColor = Color.White;
            lblKalanHakUyarisi.Font = new Font("Century", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblKalanHakUyarisi.ForeColor = Color.Red;
            lblKalanHakUyarisi.Location = new Point(12, 75);
            lblKalanHakUyarisi.Name = "lblKalanHakUyarisi";
            lblKalanHakUyarisi.Size = new Size(143, 77);
            lblKalanHakUyarisi.TabIndex = 5;
            lblKalanHakUyarisi.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // frmPasswordScreen
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(384, 161);
            Controls.Add(lblKalanHakUyarisi);
            Controls.Add(lblUyarı);
            Controls.Add(txtSifreGirisi);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmPasswordScreen";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "GÜNLÜK UYGULAMASI ŞİFRE GİRİŞ SAYFASI";
            Load += frmPasswordScreen_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtSifreGirisi;
        private PictureBox pictureBox1;
        private Label lblUyarı;
        private Label lblKalanHakUyarisi;
    }
}