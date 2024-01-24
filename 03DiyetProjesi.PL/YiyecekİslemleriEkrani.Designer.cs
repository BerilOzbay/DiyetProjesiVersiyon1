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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(YiyecekİslemleriEkrani));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            cbxYiyecekSec = new ComboBox();
            cbxOgunSec = new ComboBox();
            cbxPorsiyonSec = new ComboBox();
            dgvYiyecekİslemleri = new DataGridView();
            btnEkle = new Button();
            btnGuncelle = new Button();
            btnSil = new Button();
            pictureBox1 = new PictureBox();
            nUd = new NumericUpDown();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvYiyecekİslemleri).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nUd).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Location = new Point(128, 123);
            label1.Name = "label1";
            label1.Size = new Size(108, 20);
            label1.TabIndex = 0;
            label1.Text = "Yiyecek Seçiniz";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Location = new Point(440, 124);
            label2.Name = "label2";
            label2.Size = new Size(95, 20);
            label2.TabIndex = 1;
            label2.Text = "Öğün Seçiniz";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Location = new Point(742, 125);
            label3.Name = "label3";
            label3.Size = new Size(114, 20);
            label3.TabIndex = 2;
            label3.Text = "Porsiyon Seçiniz";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Location = new Point(996, 123);
            label4.Name = "label4";
            label4.Size = new Size(101, 20);
            label4.TabIndex = 3;
            label4.Text = "Miktar Seçiniz";
            // 
            // cbxYiyecekSec
            // 
            cbxYiyecekSec.BackColor = SystemColors.Info;
            cbxYiyecekSec.FormattingEnabled = true;
            cbxYiyecekSec.Location = new Point(128, 147);
            cbxYiyecekSec.Margin = new Padding(3, 4, 3, 4);
            cbxYiyecekSec.Name = "cbxYiyecekSec";
            cbxYiyecekSec.Size = new Size(138, 28);
            cbxYiyecekSec.TabIndex = 4;
            cbxYiyecekSec.SelectedIndexChanged += cbxYiyecekSec_SelectedIndexChanged;
            // 
            // cbxOgunSec
            // 
            cbxOgunSec.BackColor = SystemColors.Info;
            cbxOgunSec.FormattingEnabled = true;
            cbxOgunSec.Location = new Point(440, 148);
            cbxOgunSec.Margin = new Padding(3, 4, 3, 4);
            cbxOgunSec.Name = "cbxOgunSec";
            cbxOgunSec.Size = new Size(138, 28);
            cbxOgunSec.TabIndex = 5;
            // 
            // cbxPorsiyonSec
            // 
            cbxPorsiyonSec.BackColor = SystemColors.Info;
            cbxPorsiyonSec.FormattingEnabled = true;
            cbxPorsiyonSec.Location = new Point(742, 149);
            cbxPorsiyonSec.Margin = new Padding(3, 4, 3, 4);
            cbxPorsiyonSec.Name = "cbxPorsiyonSec";
            cbxPorsiyonSec.Size = new Size(138, 28);
            cbxPorsiyonSec.TabIndex = 6;
            // 
            // dgvYiyecekİslemleri
            // 
            dgvYiyecekİslemleri.BackgroundColor = SystemColors.Info;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.Transparent;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvYiyecekİslemleri.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvYiyecekİslemleri.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.Transparent;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvYiyecekİslemleri.DefaultCellStyle = dataGridViewCellStyle2;
            dgvYiyecekİslemleri.EnableHeadersVisualStyles = false;
            dgvYiyecekİslemleri.Location = new Point(335, 200);
            dgvYiyecekİslemleri.Margin = new Padding(3, 4, 3, 4);
            dgvYiyecekİslemleri.Name = "dgvYiyecekİslemleri";
            dgvYiyecekİslemleri.RowHeadersWidth = 51;
            dgvYiyecekİslemleri.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvYiyecekİslemleri.Size = new Size(798, 296);
            dgvYiyecekİslemleri.TabIndex = 8;
            dgvYiyecekİslemleri.CellClick += dgvYiyecekİslemleri_CellClick;
            // 
            // btnEkle
            // 
            btnEkle.BackColor = SystemColors.Info;
            btnEkle.Location = new Point(335, 514);
            btnEkle.Margin = new Padding(3, 4, 3, 4);
            btnEkle.Name = "btnEkle";
            btnEkle.Size = new Size(135, 57);
            btnEkle.TabIndex = 9;
            btnEkle.Text = "EKLE";
            btnEkle.UseVisualStyleBackColor = false;
            btnEkle.Click += btnEkle_Click;
            // 
            // btnGuncelle
            // 
            btnGuncelle.BackColor = SystemColors.Info;
            btnGuncelle.Location = new Point(658, 514);
            btnGuncelle.Margin = new Padding(3, 4, 3, 4);
            btnGuncelle.Name = "btnGuncelle";
            btnGuncelle.Size = new Size(151, 57);
            btnGuncelle.TabIndex = 10;
            btnGuncelle.Text = "GÜNCELLE";
            btnGuncelle.UseVisualStyleBackColor = false;
            btnGuncelle.Click += btnGuncelle_Click;
            // 
            // btnSil
            // 
            btnSil.BackColor = SystemColors.Info;
            btnSil.Location = new Point(1006, 504);
            btnSil.Margin = new Padding(3, 4, 3, 4);
            btnSil.Name = "btnSil";
            btnSil.Size = new Size(127, 57);
            btnSil.TabIndex = 11;
            btnSil.Text = "SİL";
            btnSil.UseVisualStyleBackColor = false;
            btnSil.Click += btnSil_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
            pictureBox1.Location = new Point(128, 200);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(183, 168);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 12;
            pictureBox1.TabStop = false;
            // 
            // nUd
            // 
            nUd.BackColor = SystemColors.Info;
            nUd.Location = new Point(996, 149);
            nUd.Margin = new Padding(3, 4, 3, 4);
            nUd.Name = "nUd";
            nUd.Size = new Size(137, 27);
            nUd.TabIndex = 13;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Location = new Point(128, 74);
            label5.Name = "label5";
            label5.Size = new Size(281, 20);
            label5.TabIndex = 14;
            label5.Text = "Lütfen öğün bazında yediklerinizi ekleyin.";
            // 
            // YiyecekİslemleriEkrani
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1212, 674);
            Controls.Add(label5);
            Controls.Add(nUd);
            Controls.Add(pictureBox1);
            Controls.Add(btnSil);
            Controls.Add(btnGuncelle);
            Controls.Add(btnEkle);
            Controls.Add(dgvYiyecekİslemleri);
            Controls.Add(cbxPorsiyonSec);
            Controls.Add(cbxOgunSec);
            Controls.Add(cbxYiyecekSec);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "YiyecekİslemleriEkrani";
            Text = "YiyecekİslemleriEkrani";
            ((System.ComponentModel.ISupportInitialize)dgvYiyecekİslemleri).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)nUd).EndInit();
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
        private DataGridView dgvYiyecekİslemleri;
        private Button btnEkle;
        private Button btnGuncelle;
        private Button btnSil;
        private PictureBox pictureBox1;
        private NumericUpDown nUd;
        private Label label5;
    }
}