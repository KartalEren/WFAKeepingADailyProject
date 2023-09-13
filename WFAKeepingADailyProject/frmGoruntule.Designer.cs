namespace WFAKeepingADailyProject
{
    partial class frmGoruntule
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
            rtbBaslık = new RichTextBox();
            rtbMetin = new RichTextBox();
            label1 = new Label();
            label2 = new Label();
            pbResim = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pbResim).BeginInit();
            SuspendLayout();
            // 
            // rtbBaslık
            // 
            rtbBaslık.BackColor = Color.White;
            rtbBaslık.BorderStyle = BorderStyle.None;
            rtbBaslık.Enabled = false;
            rtbBaslık.Font = new Font("Century", 14.25F, FontStyle.Italic, GraphicsUnit.Point);
            rtbBaslık.ForeColor = Color.PowderBlue;
            rtbBaslık.Location = new Point(282, 7);
            rtbBaslık.Name = "rtbBaslık";
            rtbBaslık.Size = new Size(300, 50);
            rtbBaslık.TabIndex = 14;
            rtbBaslık.Text = "";
            // 
            // rtbMetin
            // 
            rtbMetin.BackColor = Color.White;
            rtbMetin.BorderStyle = BorderStyle.None;
            rtbMetin.Enabled = false;
            rtbMetin.Font = new Font("Century", 12F, FontStyle.Italic, GraphicsUnit.Point);
            rtbMetin.ForeColor = Color.LightBlue;
            rtbMetin.Location = new Point(282, 63);
            rtbMetin.Name = "rtbMetin";
            rtbMetin.Size = new Size(300, 250);
            rtbMetin.TabIndex = 13;
            rtbMetin.Text = "";
            // 
            // label1
            // 
            label1.BackColor = Color.PowderBlue;
            label1.Location = new Point(281, 6);
            label1.Name = "label1";
            label1.Size = new Size(302, 52);
            label1.TabIndex = 15;
            label1.Text = "label1";
            // 
            // label2
            // 
            label2.BackColor = Color.LightBlue;
            label2.Location = new Point(281, 62);
            label2.Name = "label2";
            label2.Size = new Size(302, 252);
            label2.TabIndex = 16;
            label2.Text = "label2";
            // 
            // pbResim
            // 
            pbResim.BackColor = Color.Transparent;
            pbResim.Location = new Point(0, -1);
            pbResim.Name = "pbResim";
            pbResim.Size = new Size(276, 315);
            pbResim.SizeMode = PictureBoxSizeMode.StretchImage;
            pbResim.TabIndex = 17;
            pbResim.TabStop = false;
            // 
            // frmGoruntule
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(585, 317);
            Controls.Add(pbResim);
            Controls.Add(rtbBaslık);
            Controls.Add(rtbMetin);
            Controls.Add(label1);
            Controls.Add(label2);
            Name = "frmGoruntule";
            Text = "frmGoruntule";
            ((System.ComponentModel.ISupportInitialize)pbResim).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private RichTextBox rtbBaslık;
        private RichTextBox rtbMetin;
        private Label label1;
        private Label label2;
        private PictureBox pbResim;
    }
}