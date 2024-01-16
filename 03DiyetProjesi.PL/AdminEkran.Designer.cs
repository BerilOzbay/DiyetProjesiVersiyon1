namespace _03DiyetProjesi.PL
{
    partial class AdminEkran
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
            öğünEkranıToolStripMenuItem = new ToolStripMenuItem();
            yiyecekEkranıToolStripMenuItem = new ToolStripMenuItem();
            porsiyonEkranıToolStripMenuItem = new ToolStripMenuItem();
            kıyaslamaEkranıToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { öğünEkranıToolStripMenuItem, yiyecekEkranıToolStripMenuItem, porsiyonEkranıToolStripMenuItem, kıyaslamaEkranıToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1213, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // öğünEkranıToolStripMenuItem
            // 
            öğünEkranıToolStripMenuItem.Name = "öğünEkranıToolStripMenuItem";
            öğünEkranıToolStripMenuItem.Size = new Size(103, 24);
            öğünEkranıToolStripMenuItem.Text = "Öğün Ekranı";
            // 
            // yiyecekEkranıToolStripMenuItem
            // 
            yiyecekEkranıToolStripMenuItem.Name = "yiyecekEkranıToolStripMenuItem";
            yiyecekEkranıToolStripMenuItem.Size = new Size(116, 24);
            yiyecekEkranıToolStripMenuItem.Text = "Yiyecek Ekranı";
            // 
            // porsiyonEkranıToolStripMenuItem
            // 
            porsiyonEkranıToolStripMenuItem.Name = "porsiyonEkranıToolStripMenuItem";
            porsiyonEkranıToolStripMenuItem.Size = new Size(122, 24);
            porsiyonEkranıToolStripMenuItem.Text = "Porsiyon Ekranı";
            // 
            // kıyaslamaEkranıToolStripMenuItem
            // 
            kıyaslamaEkranıToolStripMenuItem.Name = "kıyaslamaEkranıToolStripMenuItem";
            kıyaslamaEkranıToolStripMenuItem.Size = new Size(134, 24);
            kıyaslamaEkranıToolStripMenuItem.Text = "Kıyaslama Ekranı";
            // 
            // AdminEkran
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1213, 527);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "AdminEkran";
            Text = "AdminEkran";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem öğünEkranıToolStripMenuItem;
        private ToolStripMenuItem yiyecekEkranıToolStripMenuItem;
        private ToolStripMenuItem porsiyonEkranıToolStripMenuItem;
        private ToolStripMenuItem kıyaslamaEkranıToolStripMenuItem;
    }
}