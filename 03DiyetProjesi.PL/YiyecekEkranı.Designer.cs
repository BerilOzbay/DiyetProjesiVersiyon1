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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(YiyecekEkranı));
            btnYiyecekGuncelle = new Button();
            btnYiyecekSil = new Button();
            btnYiyecekEkle = new Button();
            dgvYiyecekEkrani = new DataGridView();
            label1 = new Label();
            txtYiyecekAdi = new TextBox();
            txtKalori = new TextBox();
            llblkalori = new Label();
            pbYiyecekResmi = new PictureBox();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvYiyecekEkrani).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbYiyecekResmi).BeginInit();
            SuspendLayout();
            // 
            // btnYiyecekGuncelle
            // 
            btnYiyecekGuncelle.BackColor = SystemColors.Info;
            btnYiyecekGuncelle.Location = new Point(630, 559);
            btnYiyecekGuncelle.Name = "btnYiyecekGuncelle";
            btnYiyecekGuncelle.Size = new Size(130, 38);
            btnYiyecekGuncelle.TabIndex = 11;
            btnYiyecekGuncelle.Text = "GÜNCELLE";
            btnYiyecekGuncelle.UseVisualStyleBackColor = false;
            btnYiyecekGuncelle.Click += btnYiyecekGuncelle_Click;
            // 
            // btnYiyecekSil
            // 
            btnYiyecekSil.BackColor = SystemColors.Info;
            btnYiyecekSil.Location = new Point(426, 559);
            btnYiyecekSil.Name = "btnYiyecekSil";
            btnYiyecekSil.Size = new Size(130, 38);
            btnYiyecekSil.TabIndex = 10;
            btnYiyecekSil.Text = "SİL";
            btnYiyecekSil.UseVisualStyleBackColor = false;
            btnYiyecekSil.Click += btnYiyecekSil_Click;
            // 
            // btnYiyecekEkle
            // 
            btnYiyecekEkle.BackColor = SystemColors.Info;
            btnYiyecekEkle.Location = new Point(227, 559);
            btnYiyecekEkle.Name = "btnYiyecekEkle";
            btnYiyecekEkle.Size = new Size(130, 38);
            btnYiyecekEkle.TabIndex = 9;
            btnYiyecekEkle.Text = "EKLE";
            btnYiyecekEkle.UseVisualStyleBackColor = false;
            btnYiyecekEkle.Click += btnYiyecekEkle_Click;
            // 
            // dgvYiyecekEkrani
            // 
            dgvYiyecekEkrani.BackgroundColor = SystemColors.Info;
            dgvYiyecekEkrani.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.Transparent;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            dgvYiyecekEkrani.DefaultCellStyle = dataGridViewCellStyle1;
            dgvYiyecekEkrani.EnableHeadersVisualStyles = false;
            dgvYiyecekEkrani.Location = new Point(227, 253);
            dgvYiyecekEkrani.Name = "dgvYiyecekEkrani";
            dgvYiyecekEkrani.RowHeadersWidth = 51;
            dgvYiyecekEkrani.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvYiyecekEkrani.Size = new Size(533, 283);
            dgvYiyecekEkrani.TabIndex = 8;
            dgvYiyecekEkrani.CellClick += dgvYiyecekEkrani_CellClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Location = new Point(227, 106);
            label1.Name = "label1";
            label1.Size = new Size(88, 20);
            label1.TabIndex = 7;
            label1.Text = "Yiyecek Adı:";
            // 
            // txtYiyecekAdi
            // 
            txtYiyecekAdi.BackColor = SystemColors.Info;
            txtYiyecekAdi.Location = new Point(328, 102);
            txtYiyecekAdi.Name = "txtYiyecekAdi";
            txtYiyecekAdi.Size = new Size(140, 27);
            txtYiyecekAdi.TabIndex = 6;
            // 
            // txtKalori
            // 
            txtKalori.BackColor = SystemColors.Info;
            txtKalori.Location = new Point(328, 149);
            txtKalori.Name = "txtKalori";
            txtKalori.Size = new Size(140, 27);
            txtKalori.TabIndex = 12;
            // 
            // llblkalori
            // 
            llblkalori.AutoSize = true;
            llblkalori.BackColor = Color.Transparent;
            llblkalori.Location = new Point(227, 149);
            llblkalori.Name = "llblkalori";
            llblkalori.Size = new Size(51, 20);
            llblkalori.TabIndex = 13;
            llblkalori.Text = "Kalori:";
            // 
            // pbYiyecekResmi
            // 
            pbYiyecekResmi.BackColor = Color.Transparent;
            pbYiyecekResmi.BorderStyle = BorderStyle.FixedSingle;
            pbYiyecekResmi.Location = new Point(498, 93);
            pbYiyecekResmi.Name = "pbYiyecekResmi";
            pbYiyecekResmi.Size = new Size(262, 133);
            pbYiyecekResmi.TabIndex = 14;
            pbYiyecekResmi.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Location = new Point(227, 50);
            label2.Name = "label2";
            label2.Size = new Size(291, 20);
            label2.TabIndex = 15;
            label2.Text = "Lütfen eklemek istediğiniz yiyeceği yazınız.";
            // 
            // YiyecekEkranı
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1067, 639);
            Controls.Add(label2);
            Controls.Add(pbYiyecekResmi);
            Controls.Add(llblkalori);
            Controls.Add(txtKalori);
            Controls.Add(btnYiyecekGuncelle);
            Controls.Add(btnYiyecekSil);
            Controls.Add(btnYiyecekEkle);
            Controls.Add(dgvYiyecekEkrani);
            Controls.Add(label1);
            Controls.Add(txtYiyecekAdi);
            Name = "YiyecekEkranı";
            Text = "YiyecekEkranı";
            ((System.ComponentModel.ISupportInitialize)dgvYiyecekEkrani).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbYiyecekResmi).EndInit();
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
        private TextBox txtKalori;
        private Label llblkalori;
        private PictureBox pbYiyecekResmi;
        private Label label2;
    }
}