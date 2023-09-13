namespace WFAKeepingADailyProject
{
    partial class frmInfoScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInfoScreen));
            label1 = new Label();
            lblBilgiText = new Label();
            lblMaddelerAcıklama = new Label();
            lblMadde1 = new Label();
            lblMadde2 = new Label();
            lblMadde3 = new Label();
            lblMadde4 = new Label();
            lblMadde5 = new Label();
            lblMadde6 = new Label();
            lbl7 = new Label();
            lblMadde9 = new Label();
            lbl8 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(264, 21);
            label1.Name = "label1";
            label1.Size = new Size(63, 15);
            label1.TabIndex = 0;
            label1.Text = "MERHABA";
            // 
            // lblBilgiText
            // 
            lblBilgiText.Location = new Point(23, 52);
            lblBilgiText.Name = "lblBilgiText";
            lblBilgiText.Size = new Size(545, 64);
            lblBilgiText.TabIndex = 1;
            lblBilgiText.Text = resources.GetString("lblBilgiText.Text");
            // 
            // lblMaddelerAcıklama
            // 
            lblMaddelerAcıklama.Location = new Point(23, 125);
            lblMaddelerAcıklama.Name = "lblMaddelerAcıklama";
            lblMaddelerAcıklama.Size = new Size(545, 20);
            lblMaddelerAcıklama.TabIndex = 1;
            lblMaddelerAcıklama.Text = "Uygulamayı kullanmak için aşağıdaki adımları izleyin:";
            // 
            // lblMadde1
            // 
            lblMadde1.Location = new Point(23, 145);
            lblMadde1.Name = "lblMadde1";
            lblMadde1.Size = new Size(545, 20);
            lblMadde1.TabIndex = 1;
            lblMadde1.Text = "1. Takvimden bir tarih seçin. Seçtiğiniz tarih listbox'ta da görünecektir.";
            // 
            // lblMadde2
            // 
            lblMadde2.Location = new Point(23, 165);
            lblMadde2.Name = "lblMadde2";
            lblMadde2.Size = new Size(545, 20);
            lblMadde2.TabIndex = 1;
            lblMadde2.Text = "2. Başlık textbox'ına kaydınızın başlığını yazın.";
            // 
            // lblMadde3
            // 
            lblMadde3.Location = new Point(23, 185);
            lblMadde3.Name = "lblMadde3";
            lblMadde3.Size = new Size(545, 20);
            lblMadde3.TabIndex = 1;
            lblMadde3.Text = "3. İçerik textbox'ına kaydınızın içeriğini yazın.";
            // 
            // lblMadde4
            // 
            lblMadde4.Location = new Point(23, 205);
            lblMadde4.Name = "lblMadde4";
            lblMadde4.Size = new Size(545, 20);
            lblMadde4.TabIndex = 1;
            lblMadde4.Text = "4. Resim ekle butonuna tıklayarak kaydınıza bir resim ekleyin.";
            // 
            // lblMadde5
            // 
            lblMadde5.Location = new Point(23, 225);
            lblMadde5.Name = "lblMadde5";
            lblMadde5.Size = new Size(545, 34);
            lblMadde5.TabIndex = 1;
            lblMadde5.Text = "5. Kaydet butonuna tıklayarak kaydınızı tamamlayın. Kaydettiğiniz kayıt takvimde ve listbox'ta görünecektir.";
            // 
            // lblMadde6
            // 
            lblMadde6.Location = new Point(23, 259);
            lblMadde6.Name = "lblMadde6";
            lblMadde6.Size = new Size(545, 34);
            lblMadde6.TabIndex = 1;
            lblMadde6.Text = "6. Takvimden veya listbox'tan başka bir tarih seçerseniz, o tarihe ait kaydı görebilirsiniz. Ancak kaydı değiştiremezsiniz.";
            // 
            // lbl7
            // 
            lbl7.Location = new Point(23, 293);
            lbl7.Name = "lbl7";
            lbl7.Size = new Size(545, 34);
            lbl7.TabIndex = 1;
            lbl7.Text = "7. Bulunduğunuz günün kaydını değiştirmek isterseniz, başlık, içerik veya resmi değiştirip güncelle butonuna tıklayabilirsiniz.";
            // 
            // lblMadde9
            // 
            lblMadde9.Location = new Point(23, 361);
            lblMadde9.Name = "lblMadde9";
            lblMadde9.Size = new Size(545, 60);
            lblMadde9.TabIndex = 1;
            lblMadde9.Text = resources.GetString("lblMadde9.Text");
            // 
            // lbl8
            // 
            lbl8.Location = new Point(23, 327);
            lbl8.Name = "lbl8";
            lbl8.Size = new Size(545, 34);
            lbl8.TabIndex = 1;
            lbl8.Text = "8. Kaydını görüntülediğiniz günün, sayfa altına bulunan görüntüle butonuna tılayarak daha önceki kayıtlarınızı yeni pencerede görüntüleyebilirsiniz.";
            // 
            // frmInfoScreen
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(590, 460);
            Controls.Add(lblMadde9);
            Controls.Add(lbl8);
            Controls.Add(lbl7);
            Controls.Add(lblMadde6);
            Controls.Add(lblMadde5);
            Controls.Add(lblMadde4);
            Controls.Add(lblMadde3);
            Controls.Add(lblMadde2);
            Controls.Add(lblMadde1);
            Controls.Add(lblMaddelerAcıklama);
            Controls.Add(lblBilgiText);
            Controls.Add(label1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmInfoScreen";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmInfoScreen";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label lblBilgiText;
        private Label lblMaddelerAcıklama;
        private Label lblMadde1;
        private Label lblMadde2;
        private Label lblMadde3;
        private Label lblMadde4;
        private Label lblMadde5;
        private Label lblMadde6;
        private Label lbl7;
        private Label lblMadde9;
        private Label lbl8;
    }
}