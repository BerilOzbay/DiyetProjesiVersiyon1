namespace _03DiyetProjesi.PL
{
    partial class GunSonuKaloriRaporEkrani
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
            dgvGunSonuKalori = new DataGridView();
            lblToplamKalori = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvGunSonuKalori).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(33, 28);
            label1.Name = "label1";
            label1.Size = new Size(133, 15);
            label1.TabIndex = 0;
            label1.Text = "Gün Sonu Kalori Raporu";
            // 
            // dgvGunSonuKalori
            // 
            dgvGunSonuKalori.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvGunSonuKalori.Location = new Point(33, 57);
            dgvGunSonuKalori.Name = "dgvGunSonuKalori";
            dgvGunSonuKalori.Size = new Size(343, 150);
            dgvGunSonuKalori.TabIndex = 1;
            // 
            // lblToplamKalori
            // 
            lblToplamKalori.AutoSize = true;
            lblToplamKalori.Location = new Point(33, 238);
            lblToplamKalori.Name = "lblToplamKalori";
            lblToplamKalori.Size = new Size(97, 15);
            lblToplamKalori.TabIndex = 2;
            lblToplamKalori.Text = "Toplam Kaloriniz:";
            // 
            // GunSonuKaloriRaporEkrani
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(388, 331);
            Controls.Add(lblToplamKalori);
            Controls.Add(dgvGunSonuKalori);
            Controls.Add(label1);
            Name = "GunSonuKaloriRaporEkrani";
            Text = "GunSonuRaporEkrani";
            ((System.ComponentModel.ISupportInitialize)dgvGunSonuKalori).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView dgvGunSonuKalori;
        private Label lblToplamKalori;
    }
}