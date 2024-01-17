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
            dateTimePicker1 = new DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)dgvGunSonuKalori).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(38, 37);
            label1.Name = "label1";
            label1.Size = new Size(341, 20);
            label1.TabIndex = 0;
            label1.Text = "Gün Sonu Raporu Görmek istediğiniz tarihi seçiniz:";
            // 
            // dgvGunSonuKalori
            // 
            dgvGunSonuKalori.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvGunSonuKalori.Location = new Point(38, 78);
            dgvGunSonuKalori.Margin = new Padding(3, 4, 3, 4);
            dgvGunSonuKalori.Name = "dgvGunSonuKalori";
            dgvGunSonuKalori.RowHeadersWidth = 51;
            dgvGunSonuKalori.Size = new Size(893, 414);
            dgvGunSonuKalori.TabIndex = 1;
            // 
            // lblToplamKalori
            // 
            lblToplamKalori.AutoSize = true;
            lblToplamKalori.Location = new Point(38, 512);
            lblToplamKalori.Name = "lblToplamKalori";
            lblToplamKalori.Size = new Size(124, 20);
            lblToplamKalori.TabIndex = 2;
            lblToplamKalori.Text = "Toplam Kaloriniz:";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(402, 32);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(250, 27);
            dateTimePicker1.TabIndex = 3;
            dateTimePicker1.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // GunSonuKaloriRaporEkrani
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1035, 568);
            Controls.Add(dateTimePicker1);
            Controls.Add(lblToplamKalori);
            Controls.Add(dgvGunSonuKalori);
            Controls.Add(label1);
            Margin = new Padding(3, 4, 3, 4);
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
        private DateTimePicker dateTimePicker1;
    }
}