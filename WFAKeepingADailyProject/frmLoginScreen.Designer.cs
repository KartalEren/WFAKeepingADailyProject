namespace WFAKeepingADailyProject
{
    partial class frmLoginScreen
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
            pictureBox1 = new PictureBox();
            btnGiris = new Button();
            btnBilgi = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = Properties.Resources.oie_721614F75MqWUP;
            pictureBox1.Location = new Point(52, 163);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(278, 112);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // btnGiris
            // 
            btnGiris.BackColor = Color.WhiteSmoke;
            btnGiris.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            btnGiris.Location = new Point(210, 575);
            btnGiris.Name = "btnGiris";
            btnGiris.Size = new Size(120, 50);
            btnGiris.TabIndex = 2;
            btnGiris.Text = "GİRİŞ";
            btnGiris.UseVisualStyleBackColor = false;
            btnGiris.Click += btnGiris_Click;
            // 
            // btnBilgi
            // 
            btnBilgi.BackColor = Color.WhiteSmoke;
            btnBilgi.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            btnBilgi.Location = new Point(336, 575);
            btnBilgi.Name = "btnBilgi";
            btnBilgi.Size = new Size(120, 50);
            btnBilgi.TabIndex = 3;
            btnBilgi.Text = "BİLGİ";
            btnBilgi.UseVisualStyleBackColor = false;
            btnBilgi.Click += btnBilgi_Click;
            // 
            // frmLoginScreen
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.pngegg;
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(684, 661);
            Controls.Add(btnBilgi);
            Controls.Add(btnGiris);
            Controls.Add(pictureBox1);
            DoubleBuffered = true;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmLoginScreen";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "GÜNLÜK UYGULAMASI GİRİŞ SAYFASI";
            Load += frmLoginScreen_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private PictureBox pictureBox1;
        private Button btnGiris;
        private Button btnBilgi;
    }
}