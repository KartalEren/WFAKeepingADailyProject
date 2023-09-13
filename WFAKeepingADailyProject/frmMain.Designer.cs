namespace WFAKeepingADailyProject
{
    partial class frmMain
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
            menuStrip1 = new MenuStrip();
            tsmGiris = new ToolStripMenuItem();
            tsmKapat = new ToolStripMenuItem();
            tsmBilgi = new ToolStripMenuItem();
            statusStrip1 = new StatusStrip();
            tsslBuGun = new ToolStripStatusLabel();
            toolStrip1 = new ToolStrip();
            toolStripLabel1 = new ToolStripLabel();
            toolStripLabel2 = new ToolStripLabel();
            toolStripLabel3 = new ToolStripLabel();
            toolStripComboBox1 = new ToolStripComboBox();
            menuStrip1.SuspendLayout();
            statusStrip1.SuspendLayout();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { tsmGiris, tsmKapat, tsmBilgi });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(954, 24);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // tsmGiris
            // 
            tsmGiris.BackColor = SystemColors.Control;
            tsmGiris.Name = "tsmGiris";
            tsmGiris.Size = new Size(66, 20);
            tsmGiris.Text = "ÇALIŞTIR";
            tsmGiris.Click += tsmGiris_Click;
            // 
            // tsmKapat
            // 
            tsmKapat.Name = "tsmKapat";
            tsmKapat.Size = new Size(53, 20);
            tsmKapat.Text = "KAPAT";
            tsmKapat.Click += tsmKapat_Click;
            // 
            // tsmBilgi
            // 
            tsmBilgi.Name = "tsmBilgi";
            tsmBilgi.Size = new Size(46, 20);
            tsmBilgi.Text = "BİLGİ";
            tsmBilgi.Click += tsmBilgi_Click;
            // 
            // statusStrip1
            // 
            statusStrip1.Items.AddRange(new ToolStripItem[] { tsslBuGun });
            statusStrip1.Location = new Point(0, 909);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(954, 22);
            statusStrip1.TabIndex = 3;
            statusStrip1.Text = "statusStrip1";
            // 
            // tsslBuGun
            // 
            tsslBuGun.Name = "tsslBuGun";
            tsslBuGun.Size = new Size(118, 17);
            tsslBuGun.Text = "toolStripStatusLabel1";
            // 
            // toolStrip1
            // 
            toolStrip1.Items.AddRange(new ToolStripItem[] { toolStripLabel1, toolStripLabel2, toolStripLabel3, toolStripComboBox1 });
            toolStrip1.Location = new Point(0, 24);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(954, 25);
            toolStrip1.TabIndex = 5;
            toolStrip1.Text = "toolStrip1";
            // 
            // toolStripLabel1
            // 
            toolStripLabel1.Name = "toolStripLabel1";
            toolStripLabel1.Size = new Size(54, 22);
            toolStripLabel1.Text = "ÇALIŞTIR";
            // 
            // toolStripLabel2
            // 
            toolStripLabel2.Name = "toolStripLabel2";
            toolStripLabel2.Size = new Size(41, 22);
            toolStripLabel2.Text = "KAPAT";
            // 
            // toolStripLabel3
            // 
            toolStripLabel3.Name = "toolStripLabel3";
            toolStripLabel3.Size = new Size(34, 22);
            toolStripLabel3.Text = "BİLGİ";
            // 
            // toolStripComboBox1
            // 
            toolStripComboBox1.Name = "toolStripComboBox1";
            toolStripComboBox1.Size = new Size(121, 25);
            // 
            // frmMain
            // 
            AutoScaleDimensions = new SizeF(10F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(954, 931);
            Controls.Add(toolStrip1);
            Controls.Add(statusStrip1);
            Controls.Add(menuStrip1);
            Font = new Font("Lucida Handwriting", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Margin = new Padding(4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Daily Notes Application";
            Load += frmMain_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel tsslBuGun;
        public ToolStripMenuItem tsmGiris;
        private ToolStripMenuItem tsmKapat;
        private ToolStripMenuItem tsmBilgi;
        private ToolStrip toolStrip1;
        private ToolStripLabel toolStripLabel1;
        private ToolStripLabel toolStripLabel2;
        private ToolStripLabel toolStripLabel3;
        private ToolStripComboBox toolStripComboBox1;
    }
}