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
            dgvKiyaslamaEkrani = new DataGridView();
            lblKisi1 = new Label();
            lblkisi2 = new Label();
            btnRaporla = new Button();
            cmbxKisi1 = new ComboBox();
            cmbxKisi2 = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dgvKiyaslamaEkrani).BeginInit();
            SuspendLayout();
            // 
            // dgvKiyaslamaEkrani
            // 
            dgvKiyaslamaEkrani.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvKiyaslamaEkrani.Location = new Point(26, 158);
            dgvKiyaslamaEkrani.Name = "dgvKiyaslamaEkrani";
            dgvKiyaslamaEkrani.RowHeadersWidth = 51;
            dgvKiyaslamaEkrani.Size = new Size(704, 280);
            dgvKiyaslamaEkrani.TabIndex = 5;
            // 
            // lblKisi1
            // 
            lblKisi1.AutoSize = true;
            lblKisi1.Location = new Point(141, 31);
            lblKisi1.Name = "lblKisi1";
            lblKisi1.Size = new Size(44, 20);
            lblKisi1.TabIndex = 4;
            lblKisi1.Text = "Kişi 1";
            // 
            // lblkisi2
            // 
            lblkisi2.AutoSize = true;
            lblkisi2.Location = new Point(141, 78);
            lblkisi2.Name = "lblkisi2";
            lblkisi2.Size = new Size(44, 20);
            lblkisi2.TabIndex = 7;
            lblkisi2.Text = "Kişi 2";
            // 
            // btnRaporla
            // 
            btnRaporla.Location = new Point(258, 123);
            btnRaporla.Name = "btnRaporla";
            btnRaporla.Size = new Size(94, 29);
            btnRaporla.TabIndex = 8;
            btnRaporla.Text = "RAPORLA";
            btnRaporla.UseVisualStyleBackColor = true;
            // 
            // cmbxKisi1
            // 
            cmbxKisi1.FormattingEnabled = true;
            cmbxKisi1.Location = new Point(237, 31);
            cmbxKisi1.Name = "cmbxKisi1";
            cmbxKisi1.Size = new Size(151, 28);
            cmbxKisi1.TabIndex = 9;
            // 
            // cmbxKisi2
            // 
            cmbxKisi2.FormattingEnabled = true;
            cmbxKisi2.Location = new Point(237, 70);
            cmbxKisi2.Name = "cmbxKisi2";
            cmbxKisi2.Size = new Size(151, 28);
            cmbxKisi2.TabIndex = 10;
            // 
            // KıyaslaRaporuEkranı
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(cmbxKisi2);
            Controls.Add(cmbxKisi1);
            Controls.Add(btnRaporla);
            Controls.Add(lblkisi2);
            Controls.Add(dgvKiyaslamaEkrani);
            Controls.Add(lblKisi1);
            Name = "KıyaslaRaporuEkranı";
            Text = "KıyaslaRaporuEkranı";
            Load += KıyaslaRaporuEkranı_Load;
            ((System.ComponentModel.ISupportInitialize)dgvKiyaslamaEkrani).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvKiyaslamaEkrani;
        private Label lblKisi1;
        private Label lblkisi2;
        private Button btnRaporla;
        private ComboBox cmbxKisi1;
        private ComboBox cmbxKisi2;
    }
}