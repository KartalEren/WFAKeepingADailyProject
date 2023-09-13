namespace WFAKeepingADailyProject
{
    partial class frmPasswordGenerate
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
            txtSifreOlustur = new TextBox();
            btnSifreOlustur = new Button();
            pictureBox1 = new PictureBox();
            btnSifreIstemiyorum = new Button();
            lblUyarı = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.White;
            label1.Font = new Font("Century", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(18, 51);
            label1.Name = "label1";
            label1.Size = new Size(113, 18);
            label1.TabIndex = 0;
            label1.Text = "Şifre Oluştur : ";
            // 
            // txtSifreOlustur
            // 
            txtSifreOlustur.BorderStyle = BorderStyle.FixedSingle;
            txtSifreOlustur.Location = new Point(125, 49);
            txtSifreOlustur.MaxLength = 4;
            txtSifreOlustur.Name = "txtSifreOlustur";
            txtSifreOlustur.Size = new Size(232, 23);
            txtSifreOlustur.TabIndex = 1;
            txtSifreOlustur.TextChanged += txtSifreOlustur_TextChanged;
            // 
            // btnSifreOlustur
            // 
            btnSifreOlustur.Enabled = false;
            btnSifreOlustur.Font = new Font("Century", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnSifreOlustur.ForeColor = Color.Black;
            btnSifreOlustur.Location = new Point(125, 78);
            btnSifreOlustur.Name = "btnSifreOlustur";
            btnSifreOlustur.Size = new Size(102, 30);
            btnSifreOlustur.TabIndex = 2;
            btnSifreOlustur.Text = "Onayla";
            btnSifreOlustur.UseVisualStyleBackColor = true;
            btnSifreOlustur.Click += btnSifreOlustur_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.MicrosoftTeams_image__7_1;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(390, 170);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // btnSifreIstemiyorum
            // 
            btnSifreIstemiyorum.FlatAppearance.BorderColor = Color.Red;
            btnSifreIstemiyorum.FlatStyle = FlatStyle.Flat;
            btnSifreIstemiyorum.Font = new Font("Century", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnSifreIstemiyorum.ForeColor = Color.Red;
            btnSifreIstemiyorum.Location = new Point(125, 119);
            btnSifreIstemiyorum.Name = "btnSifreIstemiyorum";
            btnSifreIstemiyorum.Size = new Size(204, 30);
            btnSifreIstemiyorum.TabIndex = 4;
            btnSifreIstemiyorum.Text = "Şifre Oluşturmak İstemiyorum";
            btnSifreIstemiyorum.UseVisualStyleBackColor = true;
            btnSifreIstemiyorum.Click += btnSifreIstemiyorum_Click;
            // 
            // lblUyarı
            // 
            lblUyarı.BackColor = Color.WhiteSmoke;
            lblUyarı.BorderStyle = BorderStyle.FixedSingle;
            lblUyarı.FlatStyle = FlatStyle.Flat;
            lblUyarı.Font = new Font("Century", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblUyarı.Location = new Point(125, 22);
            lblUyarı.Name = "lblUyarı";
            lblUyarı.Size = new Size(232, 23);
            lblUyarı.TabIndex = 5;
            lblUyarı.Text = "Lütfen 4 haneli bir şifre oluşturun";
            lblUyarı.TextAlign = ContentAlignment.MiddleLeft;
            lblUyarı.Visible = false;
            // 
            // frmPasswordGenerate
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(384, 161);
            Controls.Add(lblUyarı);
            Controls.Add(btnSifreIstemiyorum);
            Controls.Add(btnSifreOlustur);
            Controls.Add(txtSifreOlustur);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmPasswordGenerate";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "GÜNLÜK UYGULAMASI ŞİFRE OLUŞTURMA SAYFASI";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtSifreOlustur;
        private Button btnSifreOlustur;
        private PictureBox pictureBox1;
        private Button btnSifreIstemiyorum;
        private Label lblUyarı;
    }
}