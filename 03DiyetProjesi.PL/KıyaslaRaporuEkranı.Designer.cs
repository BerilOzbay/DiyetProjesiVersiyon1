namespace _03DiyetProjesi.PL
{
    partial class KıyaslaRaporuEkranı
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KıyaslaRaporuEkranı));
            dgvKiyaslamaEkrani = new DataGridView();
            lblKisi1 = new Label();
            lblkisi2 = new Label();
            cmbxKisi1 = new ComboBox();
            cmbxKisi2 = new ComboBox();
            dgvKıyaslamaEkrani2 = new DataGridView();
            dtpKıyas = new DateTimePicker();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvKiyaslamaEkrani).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvKıyaslamaEkrani2).BeginInit();
            SuspendLayout();
            // 
            // dgvKiyaslamaEkrani
            // 
            dgvKiyaslamaEkrani.BackgroundColor = SystemColors.Info;
            dgvKiyaslamaEkrani.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.Transparent;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            dgvKiyaslamaEkrani.DefaultCellStyle = dataGridViewCellStyle1;
            dgvKiyaslamaEkrani.EnableHeadersVisualStyles = false;
            dgvKiyaslamaEkrani.Location = new Point(66, 172);
            dgvKiyaslamaEkrani.Name = "dgvKiyaslamaEkrani";
            dgvKiyaslamaEkrani.RowHeadersWidth = 51;
            dgvKiyaslamaEkrani.Size = new Size(438, 398);
            dgvKiyaslamaEkrani.TabIndex = 5;
            // 
            // lblKisi1
            // 
            lblKisi1.AutoSize = true;
            lblKisi1.BackColor = Color.Transparent;
            lblKisi1.Location = new Point(66, 135);
            lblKisi1.Name = "lblKisi1";
            lblKisi1.Size = new Size(47, 20);
            lblKisi1.TabIndex = 4;
            lblKisi1.Text = "Kişi 1:";
            // 
            // lblkisi2
            // 
            lblkisi2.AutoSize = true;
            lblkisi2.Location = new Point(580, 138);
            lblkisi2.Name = "lblkisi2";
            lblkisi2.Size = new Size(47, 20);
            lblkisi2.TabIndex = 7;
            lblkisi2.Text = "Kişi 2:";
            // 
            // cmbxKisi1
            // 
            cmbxKisi1.BackColor = SystemColors.Info;
            cmbxKisi1.FormattingEnabled = true;
            cmbxKisi1.Location = new Point(128, 132);
            cmbxKisi1.Name = "cmbxKisi1";
            cmbxKisi1.Size = new Size(209, 28);
            cmbxKisi1.TabIndex = 9;
            // 
            // cmbxKisi2
            // 
            cmbxKisi2.BackColor = SystemColors.Info;
            cmbxKisi2.FormattingEnabled = true;
            cmbxKisi2.Location = new Point(633, 135);
            cmbxKisi2.Name = "cmbxKisi2";
            cmbxKisi2.Size = new Size(243, 28);
            cmbxKisi2.TabIndex = 10;
            // 
            // dgvKıyaslamaEkrani2
            // 
            dgvKıyaslamaEkrani2.BackgroundColor = SystemColors.Info;
            dgvKıyaslamaEkrani2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.Transparent;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvKıyaslamaEkrani2.DefaultCellStyle = dataGridViewCellStyle2;
            dgvKıyaslamaEkrani2.EnableHeadersVisualStyles = false;
            dgvKıyaslamaEkrani2.Location = new Point(578, 171);
            dgvKıyaslamaEkrani2.Name = "dgvKıyaslamaEkrani2";
            dgvKıyaslamaEkrani2.RowHeadersWidth = 51;
            dgvKıyaslamaEkrani2.Size = new Size(452, 398);
            dgvKıyaslamaEkrani2.TabIndex = 11;
            // 
            // dtpKıyas
            // 
            dtpKıyas.CalendarMonthBackground = SystemColors.Info;
            dtpKıyas.Location = new Point(1056, 135);
            dtpKıyas.Name = "dtpKıyas";
            dtpKıyas.Size = new Size(242, 27);
            dtpKıyas.TabIndex = 12;
            dtpKıyas.ValueChanged += dtpKıyas_ValueChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Location = new Point(66, 93);
            label1.Name = "label1";
            label1.Size = new Size(350, 20);
            label1.TabIndex = 13;
            label1.Text = "Lütfen bilgilerini görmek istediğiniz iki kişiyi seçiniz.";
            // 
            // KıyaslaRaporuEkranı
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1358, 659);
            Controls.Add(label1);
            Controls.Add(dtpKıyas);
            Controls.Add(dgvKıyaslamaEkrani2);
            Controls.Add(cmbxKisi2);
            Controls.Add(cmbxKisi1);
            Controls.Add(lblkisi2);
            Controls.Add(dgvKiyaslamaEkrani);
            Controls.Add(lblKisi1);
            Name = "KıyaslaRaporuEkranı";
            Text = "KıyaslaRaporuEkranı";
            Load += KıyaslaRaporuEkranı_Load;
            ((System.ComponentModel.ISupportInitialize)dgvKiyaslamaEkrani).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvKıyaslamaEkrani2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvKiyaslamaEkrani;
        private Label lblKisi1;
        private Label lblkisi2;
        private ComboBox cmbxKisi1;
        private ComboBox cmbxKisi2;
        private DataGridView dgvKıyaslamaEkrani2;
        private DateTimePicker dtpKıyas;
        private Label label1;
    }
}