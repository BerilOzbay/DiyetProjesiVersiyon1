namespace _03DiyetProjesi.PL
{
    partial class YiyecekİslemleriEkrani
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
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            cbxYiyecekSec = new ComboBox();
            cbxOgunSec = new ComboBox();
            cbxPorsiyonSec = new ComboBox();
            cbxMiktarSec = new ComboBox();
            dgvYiyecekİslemleri = new DataGridView();
            btnEkle = new Button();
            btnGuncelle = new Button();
            btnSil = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dgvYiyecekİslemleri).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 33);
            label1.Name = "label1";
            label1.Size = new Size(86, 15);
            label1.TabIndex = 0;
            label1.Text = "Yiyecek Seçiniz";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(180, 33);
            label2.Name = "label2";
            label2.Size = new Size(76, 15);
            label2.TabIndex = 1;
            label2.Text = "Öğün Seçiniz";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(362, 33);
            label3.Name = "label3";
            label3.Size = new Size(92, 15);
            label3.TabIndex = 2;
            label3.Text = "Porsiyon Seçiniz";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(539, 33);
            label4.Name = "label4";
            label4.Size = new Size(80, 15);
            label4.TabIndex = 3;
            label4.Text = "Miktar Seçiniz";
            // 
            // cbxYiyecekSec
            // 
            cbxYiyecekSec.FormattingEnabled = true;
            cbxYiyecekSec.Location = new Point(12, 51);
            cbxYiyecekSec.Name = "cbxYiyecekSec";
            cbxYiyecekSec.Size = new Size(121, 23);
            cbxYiyecekSec.TabIndex = 4;
            // 
            // cbxOgunSec
            // 
            cbxOgunSec.FormattingEnabled = true;
            cbxOgunSec.Location = new Point(180, 51);
            cbxOgunSec.Name = "cbxOgunSec";
            cbxOgunSec.Size = new Size(121, 23);
            cbxOgunSec.TabIndex = 5;
            // 
            // cbxPorsiyonSec
            // 
            cbxPorsiyonSec.FormattingEnabled = true;
            cbxPorsiyonSec.Location = new Point(362, 51);
            cbxPorsiyonSec.Name = "cbxPorsiyonSec";
            cbxPorsiyonSec.Size = new Size(121, 23);
            cbxPorsiyonSec.TabIndex = 6;
            // 
            // cbxMiktarSec
            // 
            cbxMiktarSec.FormattingEnabled = true;
            cbxMiktarSec.Location = new Point(539, 51);
            cbxMiktarSec.Name = "cbxMiktarSec";
            cbxMiktarSec.Size = new Size(121, 23);
            cbxMiktarSec.TabIndex = 7;
            // 
            // dgvYiyecekİslemleri
            // 
            dgvYiyecekİslemleri.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvYiyecekİslemleri.Location = new Point(180, 80);
            dgvYiyecekİslemleri.Name = "dgvYiyecekİslemleri";
            dgvYiyecekİslemleri.Size = new Size(480, 166);
            dgvYiyecekİslemleri.TabIndex = 8;
            // 
            // btnEkle
            // 
            btnEkle.Location = new Point(297, 252);
            btnEkle.Name = "btnEkle";
            btnEkle.Size = new Size(75, 43);
            btnEkle.TabIndex = 9;
            btnEkle.Text = "EKLE";
            btnEkle.UseVisualStyleBackColor = true;
            // 
            // btnGuncelle
            // 
            btnGuncelle.Location = new Point(389, 252);
            btnGuncelle.Name = "btnGuncelle";
            btnGuncelle.Size = new Size(75, 43);
            btnGuncelle.TabIndex = 10;
            btnGuncelle.Text = "GÜNCELLE";
            btnGuncelle.UseVisualStyleBackColor = true;
            // 
            // btnSil
            // 
            btnSil.Location = new Point(479, 252);
            btnSil.Name = "btnSil";
            btnSil.Size = new Size(75, 43);
            btnSil.TabIndex = 11;
            btnSil.Text = "SİL";
            btnSil.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(12, 103);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(121, 126);
            pictureBox1.TabIndex = 12;
            pictureBox1.TabStop = false;
            // 
            // YiyecekİslemleriEkrani
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(713, 404);
            Controls.Add(pictureBox1);
            Controls.Add(btnSil);
            Controls.Add(btnGuncelle);
            Controls.Add(btnEkle);
            Controls.Add(dgvYiyecekİslemleri);
            Controls.Add(cbxMiktarSec);
            Controls.Add(cbxPorsiyonSec);
            Controls.Add(cbxOgunSec);
            Controls.Add(cbxYiyecekSec);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "YiyecekİslemleriEkrani";
            Text = "YiyecekİslemleriEkrani";
            ((System.ComponentModel.ISupportInitialize)dgvYiyecekİslemleri).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private ComboBox cbxYiyecekSec;
        private ComboBox cbxOgunSec;
        private ComboBox cbxPorsiyonSec;
        private ComboBox cbxMiktarSec;
        private DataGridView dgvYiyecekİslemleri;
        private Button btnEkle;
        private Button btnGuncelle;
        private Button btnSil;
        private PictureBox pictureBox1;
    }
}