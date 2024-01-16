namespace _03DiyetProjesi.PL
{
    partial class TümKullanicilarEkrani
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
            dgvTumKullanicilar = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvTumKullanicilar).BeginInit();
            SuspendLayout();
            // 
            // dgvTumKullanicilar
            // 
            dgvTumKullanicilar.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTumKullanicilar.Location = new Point(12, 34);
            dgvTumKullanicilar.Name = "dgvTumKullanicilar";
            dgvTumKullanicilar.RowHeadersWidth = 51;
            dgvTumKullanicilar.Size = new Size(763, 389);
            dgvTumKullanicilar.TabIndex = 0;
            // 
            // TümKullanicilarEkrani
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dgvTumKullanicilar);
            Name = "TümKullanicilarEkrani";
            Text = "TümKullanicilarEkrani";
            ((System.ComponentModel.ISupportInitialize)dgvTumKullanicilar).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvTumKullanicilar;
    }
}