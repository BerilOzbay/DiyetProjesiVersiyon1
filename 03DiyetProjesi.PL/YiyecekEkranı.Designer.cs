namespace _03DiyetProjesi.PL
{
    partial class YiyecekEkranı
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
            btnYiyecekGuncelle = new Button();
            btnYiyecekSil = new Button();
            btnYiyecekEkle = new Button();
            dgvYiyecekEkrani = new DataGridView();
            label1 = new Label();
            txtYiyecekAdi = new TextBox();
            textBox1 = new TextBox();
            llblkalori = new Label();
            pictureBox1 = new PictureBox();
            lblResim = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvYiyecekEkrani).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnYiyecekGuncelle
            // 
            btnYiyecekGuncelle.Location = new Point(331, 431);
            btnYiyecekGuncelle.Name = "btnYiyecekGuncelle";
            btnYiyecekGuncelle.Size = new Size(130, 38);
            btnYiyecekGuncelle.TabIndex = 11;
            btnYiyecekGuncelle.Text = "GÜNCELLE";
            btnYiyecekGuncelle.UseVisualStyleBackColor = true;
            // 
            // btnYiyecekSil
            // 
            btnYiyecekSil.Location = new Point(172, 431);
            btnYiyecekSil.Name = "btnYiyecekSil";
            btnYiyecekSil.Size = new Size(130, 38);
            btnYiyecekSil.TabIndex = 10;
            btnYiyecekSil.Text = "SİL";
            btnYiyecekSil.UseVisualStyleBackColor = true;
            // 
            // btnYiyecekEkle
            // 
            btnYiyecekEkle.Location = new Point(20, 431);
            btnYiyecekEkle.Name = "btnYiyecekEkle";
            btnYiyecekEkle.Size = new Size(130, 38);
            btnYiyecekEkle.TabIndex = 9;
            btnYiyecekEkle.Text = "EKLE";
            btnYiyecekEkle.UseVisualStyleBackColor = true;
            // 
            // dgvYiyecekEkrani
            // 
            dgvYiyecekEkrani.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvYiyecekEkrani.Location = new Point(20, 192);
            dgvYiyecekEkrani.Name = "dgvYiyecekEkrani";
            dgvYiyecekEkrani.RowHeadersWidth = 51;
            dgvYiyecekEkrani.Size = new Size(488, 222);
            dgvYiyecekEkrani.TabIndex = 8;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(78, 19);
            label1.Name = "label1";
            label1.Size = new Size(85, 20);
            label1.TabIndex = 7;
            label1.Text = "Yiyecek Adı";
            // 
            // txtYiyecekAdi
            // 
            txtYiyecekAdi.Location = new Point(176, 12);
            txtYiyecekAdi.Name = "txtYiyecekAdi";
            txtYiyecekAdi.Size = new Size(165, 27);
            txtYiyecekAdi.TabIndex = 6;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(176, 59);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(165, 27);
            textBox1.TabIndex = 12;
            // 
            // llblkalori
            // 
            llblkalori.AutoSize = true;
            llblkalori.Location = new Point(78, 62);
            llblkalori.Name = "llblkalori";
            llblkalori.Size = new Size(48, 20);
            llblkalori.TabIndex = 13;
            llblkalori.Text = "Kalori";
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(177, 105);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(164, 62);
            pictureBox1.TabIndex = 14;
            pictureBox1.TabStop = false;
            // 
            // lblResim
            // 
            lblResim.AutoSize = true;
            lblResim.Location = new Point(78, 105);
            lblResim.Name = "lblResim";
            lblResim.Size = new Size(53, 20);
            lblResim.TabIndex = 15;
            lblResim.Text = "Resim ";
            // 
            // YiyecekEkranı
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 549);
            Controls.Add(lblResim);
            Controls.Add(pictureBox1);
            Controls.Add(llblkalori);
            Controls.Add(textBox1);
            Controls.Add(btnYiyecekGuncelle);
            Controls.Add(btnYiyecekSil);
            Controls.Add(btnYiyecekEkle);
            Controls.Add(dgvYiyecekEkrani);
            Controls.Add(label1);
            Controls.Add(txtYiyecekAdi);
            Name = "YiyecekEkranı";
            Text = "YiyecekEkranı";
            ((System.ComponentModel.ISupportInitialize)dgvYiyecekEkrani).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnYiyecekGuncelle;
        private Button btnYiyecekSil;
        private Button btnYiyecekEkle;
        private DataGridView dgvYiyecekEkrani;
        private Label label1;
        private TextBox txtYiyecekAdi;
        private TextBox textBox1;
        private Label llblkalori;
        private PictureBox pictureBox1;
        private Label lblResim;
    }
}