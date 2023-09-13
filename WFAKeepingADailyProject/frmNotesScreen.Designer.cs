namespace WFAKeepingADailyProject
{
    partial class frmNotesScreen
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNotesScreen));
            monthCalendar1 = new MonthCalendar();
            richTextBoxMetin = new RichTextBox();
            fontDialog1 = new FontDialog();
            pictureBoxResim = new PictureBox();
            openFileDialog1 = new OpenFileDialog();
            btnAddPicture = new Button();
            btnDeletePicture = new Button();
            richTextBoxBaslik = new RichTextBox();
            btnKaydet = new Button();
            lstDizi = new ListBox();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            lblSaat = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            label3 = new Label();
            lblEkle = new Label();
            lblResimSil = new Label();
            lblKaydet = new Label();
            pictureBox3 = new PictureBox();
            lblKaydıPenceredeAc = new Label();
            btnGoruntule = new Button();
            pbxBilgi = new PictureBox();
            lblBilgi = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBoxResim).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbxBilgi).BeginInit();
            SuspendLayout();
            // 
            // monthCalendar1
            // 
            monthCalendar1.AccessibleRole = AccessibleRole.ToolTip;
            monthCalendar1.BackColor = Color.DarkGray;
            monthCalendar1.ForeColor = Color.PowderBlue;
            monthCalendar1.Location = new Point(2, 45);
            monthCalendar1.MaxDate = new DateTime(2023, 12, 31, 0, 0, 0, 0);
            monthCalendar1.MinDate = new DateTime(2023, 1, 1, 0, 0, 0, 0);
            monthCalendar1.Name = "monthCalendar1";
            monthCalendar1.ShowToday = false;
            monthCalendar1.TabIndex = 0;
            monthCalendar1.TrailingForeColor = Color.Red;
            monthCalendar1.DateChanged += monthCalendar1_DateChanged;
            // 
            // richTextBoxMetin
            // 
            richTextBoxMetin.BackColor = Color.White;
            richTextBoxMetin.BorderStyle = BorderStyle.None;
            richTextBoxMetin.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Italic, GraphicsUnit.Point);
            richTextBoxMetin.ForeColor = Color.LightBlue;
            richTextBoxMetin.Location = new Point(379, 309);
            richTextBoxMetin.Name = "richTextBoxMetin";
            richTextBoxMetin.Size = new Size(300, 250);
            richTextBoxMetin.TabIndex = 1;
            richTextBoxMetin.Text = "İçerik giriniz";
            richTextBoxMetin.MouseClick += richTextBoxMetin_MouseClick;
            richTextBoxMetin.MouseDoubleClick += richTextBoxMetin_MouseClick;
            // 
            // pictureBoxResim
            // 
            pictureBoxResim.BackColor = Color.Transparent;
            pictureBoxResim.Location = new Point(563, 566);
            pictureBoxResim.Name = "pictureBoxResim";
            pictureBoxResim.Size = new Size(116, 92);
            pictureBoxResim.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxResim.TabIndex = 2;
            pictureBoxResim.TabStop = false;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // btnAddPicture
            // 
            btnAddPicture.BackColor = Color.Transparent;
            btnAddPicture.BackgroundImage = Properties.Resources.pngwing_com__3_;
            btnAddPicture.BackgroundImageLayout = ImageLayout.Zoom;
            btnAddPicture.Location = new Point(462, 617);
            btnAddPicture.Name = "btnAddPicture";
            btnAddPicture.Size = new Size(40, 40);
            btnAddPicture.TabIndex = 3;
            btnAddPicture.UseVisualStyleBackColor = false;
            btnAddPicture.Click += btnAddPicture_Click;
            btnAddPicture.MouseEnter += btnAddPicture_MouseEnter;
            btnAddPicture.MouseLeave += btnAddPicture_MouseLeave;
            // 
            // btnDeletePicture
            // 
            btnDeletePicture.BackColor = Color.White;
            btnDeletePicture.BackgroundImage = Properties.Resources.pngwing1;
            btnDeletePicture.BackgroundImageLayout = ImageLayout.Zoom;
            btnDeletePicture.Location = new Point(508, 617);
            btnDeletePicture.Name = "btnDeletePicture";
            btnDeletePicture.Size = new Size(40, 40);
            btnDeletePicture.TabIndex = 3;
            btnDeletePicture.UseVisualStyleBackColor = false;
            btnDeletePicture.Click += btnDeletePicture_Click;
            btnDeletePicture.MouseEnter += btnDeletePicture_MouseEnter;
            btnDeletePicture.MouseLeave += btnDeletePicture_MouseLeave;
            // 
            // richTextBoxBaslik
            // 
            richTextBoxBaslik.BackColor = Color.White;
            richTextBoxBaslik.BorderStyle = BorderStyle.None;
            richTextBoxBaslik.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Italic, GraphicsUnit.Point);
            richTextBoxBaslik.ForeColor = Color.PowderBlue;
            richTextBoxBaslik.Location = new Point(379, 253);
            richTextBoxBaslik.Name = "richTextBoxBaslik";
            richTextBoxBaslik.Size = new Size(300, 50);
            richTextBoxBaslik.TabIndex = 5;
            richTextBoxBaslik.Text = "Başlık giriniz";
            richTextBoxBaslik.MouseClick += richTextBoxBaslik_MouseClick;
            richTextBoxBaslik.MouseDoubleClick += richTextBoxBaslik_MouseClick;
            // 
            // btnKaydet
            // 
            btnKaydet.BackgroundImage = Properties.Resources.pngwing_com__2_;
            btnKaydet.BackgroundImageLayout = ImageLayout.Zoom;
            btnKaydet.Location = new Point(321, 617);
            btnKaydet.Name = "btnKaydet";
            btnKaydet.Size = new Size(40, 40);
            btnKaydet.TabIndex = 7;
            btnKaydet.UseVisualStyleBackColor = true;
            btnKaydet.Click += btnKaydet_Click;
            btnKaydet.MouseEnter += btnKaydet_MouseEnter;
            btnKaydet.MouseLeave += btnKaydet_MouseLeave;
            // 
            // lstDizi
            // 
            lstDizi.BackColor = Color.LightBlue;
            lstDizi.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Italic, GraphicsUnit.Point);
            lstDizi.ForeColor = Color.White;
            lstDizi.FormattingEnabled = true;
            lstDizi.ItemHeight = 16;
            lstDizi.Location = new Point(2, 207);
            lstDizi.Name = "lstDizi";
            lstDizi.Size = new Size(234, 276);
            lstDizi.TabIndex = 9;
            lstDizi.DoubleClick += lstDizi_DoubleClick;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Ekran_görüntüsü_2023_05_07_153621;
            pictureBox1.Location = new Point(0, 408);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(306, 253);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 10;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.Ekran_görüntüsü_2023_05_07_1536211;
            pictureBox2.Location = new Point(378, -4);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(306, 253);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 10;
            pictureBox2.TabStop = false;
            // 
            // label1
            // 
            label1.BackColor = Color.PowderBlue;
            label1.Location = new Point(378, 252);
            label1.Name = "label1";
            label1.Size = new Size(302, 52);
            label1.TabIndex = 11;
            label1.Text = "label1";
            // 
            // label2
            // 
            label2.BackColor = Color.LightBlue;
            label2.Location = new Point(378, 308);
            label2.Name = "label2";
            label2.Size = new Size(302, 252);
            label2.TabIndex = 12;
            label2.Text = "label2";
            // 
            // lblSaat
            // 
            lblSaat.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblSaat.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Italic, GraphicsUnit.Point);
            lblSaat.ForeColor = Color.PowderBlue;
            lblSaat.Location = new Point(4, 6);
            lblSaat.Name = "lblSaat";
            lblSaat.Size = new Size(153, 43);
            lblSaat.TabIndex = 13;
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // label3
            // 
            label3.BackColor = Color.Aqua;
            label3.BorderStyle = BorderStyle.FixedSingle;
            label3.Location = new Point(562, 565);
            label3.Name = "label3";
            label3.Size = new Size(118, 94);
            label3.TabIndex = 14;
            label3.Text = "label3";
            // 
            // lblEkle
            // 
            lblEkle.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Italic, GraphicsUnit.Point);
            lblEkle.Location = new Point(462, 601);
            lblEkle.Name = "lblEkle";
            lblEkle.Size = new Size(71, 19);
            lblEkle.TabIndex = 15;
            lblEkle.Text = "Resim Ekle";
            lblEkle.Visible = false;
            // 
            // lblResimSil
            // 
            lblResimSil.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Italic, GraphicsUnit.Point);
            lblResimSil.Location = new Point(509, 601);
            lblResimSil.Name = "lblResimSil";
            lblResimSil.Size = new Size(62, 19);
            lblResimSil.TabIndex = 15;
            lblResimSil.Text = "Resim Sil";
            lblResimSil.Visible = false;
            // 
            // lblKaydet
            // 
            lblKaydet.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Italic, GraphicsUnit.Point);
            lblKaydet.Location = new Point(321, 601);
            lblKaydet.Name = "lblKaydet";
            lblKaydet.Size = new Size(54, 19);
            lblKaydet.TabIndex = 15;
            lblKaydet.Text = "Kaydet";
            lblKaydet.Visible = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.pngwing_com__5_;
            pictureBox3.Location = new Point(379, 127);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(120, 120);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 16;
            pictureBox3.TabStop = false;
            // 
            // lblKaydıPenceredeAc
            // 
            lblKaydıPenceredeAc.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Italic, GraphicsUnit.Point);
            lblKaydıPenceredeAc.Location = new Point(367, 601);
            lblKaydıPenceredeAc.Name = "lblKaydıPenceredeAc";
            lblKaydıPenceredeAc.Size = new Size(62, 19);
            lblKaydıPenceredeAc.TabIndex = 15;
            lblKaydıPenceredeAc.Text = "Görüntüle";
            lblKaydıPenceredeAc.Visible = false;
            // 
            // btnGoruntule
            // 
            btnGoruntule.BackgroundImage = (Image)resources.GetObject("btnGoruntule.BackgroundImage");
            btnGoruntule.BackgroundImageLayout = ImageLayout.Zoom;
            btnGoruntule.Location = new Point(367, 617);
            btnGoruntule.Name = "btnGoruntule";
            btnGoruntule.Size = new Size(40, 40);
            btnGoruntule.TabIndex = 7;
            btnGoruntule.UseVisualStyleBackColor = true;
            btnGoruntule.Click += btnGoruntule_Click;
            btnGoruntule.MouseEnter += btnGoruntule_MouseEnter;
            btnGoruntule.MouseLeave += btnGoruntule_MouseLeave;
            // 
            // pbxBilgi
            // 
            pbxBilgi.BackColor = Color.Transparent;
            pbxBilgi.Image = Properties.Resources.MicrosoftTeams_image__8_1;
            pbxBilgi.Location = new Point(415, 617);
            pbxBilgi.Name = "pbxBilgi";
            pbxBilgi.Size = new Size(40, 38);
            pbxBilgi.SizeMode = PictureBoxSizeMode.StretchImage;
            pbxBilgi.TabIndex = 18;
            pbxBilgi.TabStop = false;
            pbxBilgi.Click += pbxBilgi_Click;
            pbxBilgi.MouseEnter += pbxBilgi_MouseEnter;
            pbxBilgi.MouseLeave += pbxBilgi_MouseLeave;
            // 
            // lblBilgi
            // 
            lblBilgi.AutoSize = true;
            lblBilgi.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Italic, GraphicsUnit.Point);
            lblBilgi.Location = new Point(421, 601);
            lblBilgi.Name = "lblBilgi";
            lblBilgi.Size = new Size(26, 13);
            lblBilgi.TabIndex = 19;
            lblBilgi.Text = "Bilgi";
            lblBilgi.Visible = false;
            // 
            // frmNotesScreen
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(684, 661);
            Controls.Add(pbxBilgi);
            Controls.Add(pictureBox3);
            Controls.Add(lblSaat);
            Controls.Add(richTextBoxBaslik);
            Controls.Add(richTextBoxMetin);
            Controls.Add(pictureBoxResim);
            Controls.Add(lstDizi);
            Controls.Add(btnGoruntule);
            Controls.Add(btnKaydet);
            Controls.Add(btnDeletePicture);
            Controls.Add(btnAddPicture);
            Controls.Add(monthCalendar1);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(label3);
            Controls.Add(lblEkle);
            Controls.Add(lblKaydıPenceredeAc);
            Controls.Add(lblKaydet);
            Controls.Add(lblResimSil);
            Controls.Add(lblBilgi);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmNotesScreen";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "GÜNLÜK PROGRAMI ANA SAYFASI";
            FormClosing += frmNotesScreen_FormClosing;
            Load += frmNotesScreen_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBoxResim).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbxBilgi).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MonthCalendar monthCalendar1;
        private RichTextBox richTextBoxMetin;
        private FontDialog fontDialog1;
        private PictureBox pictureBoxResim;
        private OpenFileDialog openFileDialog1;
        private Button btnAddPicture;
        private Button btnDeletePicture;
        private RichTextBox richTextBoxBaslik;
        private Button btnKaydet;
        private ListBox lstDizi;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Label label1;
        private Label label2;
        private Label lblSaat;
        private System.Windows.Forms.Timer timer1;
        private Label label3;
        private Label lblEkle;
        private Label lblResimSil;
        private Label lblKaydet;
        private PictureBox pictureBox3;
        private Label lblKaydıPenceredeAc;
        private Button btnGoruntule;
        private PictureBox pbxBilgi;
        private Label lblBilgi;
    }
}