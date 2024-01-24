namespace _03DiyetProjesi.PL
{
    partial class PorsiyonEkranı
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PorsiyonEkranı));
            btnPorsiyonGuncelle = new Button();
            btnPorsiyonSil = new Button();
            btnPorsiyonEkle = new Button();
            dgvPorsiyonEkrani = new DataGridView();
            lblTuru = new Label();
            txtporsiyonTuru = new TextBox();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvPorsiyonEkrani).BeginInit();
            SuspendLayout();
            // 
            // btnPorsiyonGuncelle
            // 
            btnPorsiyonGuncelle.BackColor = SystemColors.Info;
            btnPorsiyonGuncelle.Location = new Point(568, 426);
            btnPorsiyonGuncelle.Name = "btnPorsiyonGuncelle";
            btnPorsiyonGuncelle.Size = new Size(130, 38);
            btnPorsiyonGuncelle.TabIndex = 15;
            btnPorsiyonGuncelle.Text = "GÜNCELLE";
            btnPorsiyonGuncelle.UseVisualStyleBackColor = false;
            btnPorsiyonGuncelle.Click += btnPorsiyonGuncelle_Click;
            // 
            // btnPorsiyonSil
            // 
            btnPorsiyonSil.BackColor = SystemColors.Info;
            btnPorsiyonSil.Location = new Point(396, 426);
            btnPorsiyonSil.Name = "btnPorsiyonSil";
            btnPorsiyonSil.Size = new Size(130, 38);
            btnPorsiyonSil.TabIndex = 14;
            btnPorsiyonSil.Text = "SİL";
            btnPorsiyonSil.UseVisualStyleBackColor = false;
            btnPorsiyonSil.Click += btnPorsiyonSil_Click;
            // 
            // btnPorsiyonEkle
            // 
            btnPorsiyonEkle.BackColor = Color.Beige;
            btnPorsiyonEkle.Location = new Point(210, 426);
            btnPorsiyonEkle.Name = "btnPorsiyonEkle";
            btnPorsiyonEkle.Size = new Size(130, 38);
            btnPorsiyonEkle.TabIndex = 13;
            btnPorsiyonEkle.Text = "EKLE";
            btnPorsiyonEkle.UseVisualStyleBackColor = false;
            btnPorsiyonEkle.Click += btnPorsiyonEkle_Click;
            // 
            // dgvPorsiyonEkrani
            // 
            dgvPorsiyonEkrani.BackgroundColor = SystemColors.Info;
            dgvPorsiyonEkrani.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.Transparent;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            dgvPorsiyonEkrani.DefaultCellStyle = dataGridViewCellStyle1;
            dgvPorsiyonEkrani.EnableHeadersVisualStyles = false;
            dgvPorsiyonEkrani.Location = new Point(210, 168);
            dgvPorsiyonEkrani.Name = "dgvPorsiyonEkrani";
            dgvPorsiyonEkrani.RowHeadersWidth = 51;
            dgvPorsiyonEkrani.Size = new Size(488, 222);
            dgvPorsiyonEkrani.TabIndex = 12;
            dgvPorsiyonEkrani.CellClick += dgvPorsiyonEkrani_CellClick;
            // 
            // lblTuru
            // 
            lblTuru.AutoSize = true;
            lblTuru.BackColor = Color.Transparent;
            lblTuru.Location = new Point(210, 122);
            lblTuru.Name = "lblTuru";
            lblTuru.Size = new Size(100, 20);
            lblTuru.TabIndex = 17;
            lblTuru.Text = "Porsiyon Türü:";
            // 
            // txtporsiyonTuru
            // 
            txtporsiyonTuru.BackColor = SystemColors.Info;
            txtporsiyonTuru.Location = new Point(328, 122);
            txtporsiyonTuru.Name = "txtporsiyonTuru";
            txtporsiyonTuru.Size = new Size(370, 27);
            txtporsiyonTuru.TabIndex = 16;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Location = new Point(210, 64);
            label2.Name = "label2";
            label2.Size = new Size(302, 20);
            label2.TabIndex = 18;
            label2.Text = "Lütfen eklemek istediğiniz porsiyonu yazınız.";
            // 
            // PorsiyonEkranı
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(998, 585);
            Controls.Add(label2);
            Controls.Add(lblTuru);
            Controls.Add(txtporsiyonTuru);
            Controls.Add(btnPorsiyonGuncelle);
            Controls.Add(btnPorsiyonSil);
            Controls.Add(btnPorsiyonEkle);
            Controls.Add(dgvPorsiyonEkrani);
            Name = "PorsiyonEkranı";
            Text = "PorsiyonEkranı";
            ((System.ComponentModel.ISupportInitialize)dgvPorsiyonEkrani).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnPorsiyonGuncelle;
        private Button btnPorsiyonSil;
        private Button btnPorsiyonEkle;
        private DataGridView dgvPorsiyonEkrani;
        private Label lblTuru;
        private TextBox txtporsiyonTuru;
        private Label label2;
    }
}