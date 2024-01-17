namespace _03DiyetProjesi.PL
{
    partial class KullaniciAnaEkran
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
            yiyecekİslemleriToolStripMenuItem = new ToolStripMenuItem();
            günSonuKaloriRaporuToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { yiyecekİslemleriToolStripMenuItem, günSonuKaloriRaporuToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(7, 3, 0, 3);
            menuStrip1.Size = new Size(581, 30);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // yiyecekİslemleriToolStripMenuItem
            // 
            yiyecekİslemleriToolStripMenuItem.Name = "yiyecekİslemleriToolStripMenuItem";
            yiyecekİslemleriToolStripMenuItem.Size = new Size(132, 24);
            yiyecekİslemleriToolStripMenuItem.Text = "Yiyecek İslemleri";
            yiyecekİslemleriToolStripMenuItem.Click += yiyecekİslemleriToolStripMenuItem_Click;
            // 
            // günSonuKaloriRaporuToolStripMenuItem
            // 
            günSonuKaloriRaporuToolStripMenuItem.Name = "günSonuKaloriRaporuToolStripMenuItem";
            günSonuKaloriRaporuToolStripMenuItem.Size = new Size(181, 24);
            günSonuKaloriRaporuToolStripMenuItem.Text = "Gün Sonu Kalori Raporu";
            günSonuKaloriRaporuToolStripMenuItem.Click += günSonuKaloriRaporuToolStripMenuItem_Click;
            // 
            // KullaniciAnaEkran
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(581, 496);
            Controls.Add(menuStrip1);
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Margin = new Padding(3, 4, 3, 4);
            Name = "KullaniciAnaEkran";
            Text = "KullaniciAnaEkran";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem yiyecekİslemleriToolStripMenuItem;
        private ToolStripMenuItem günSonuKaloriRaporuToolStripMenuItem;
    }
}