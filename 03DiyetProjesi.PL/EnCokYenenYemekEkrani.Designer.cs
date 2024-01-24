namespace _03DiyetProjesi.PL
{
    partial class EnCokYenenYemekEkrani
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EnCokYenenYemekEkrani));
            cmbxyiyecek = new ComboBox();
            lblKisi1 = new Label();
            dgvEnCokYenenYemek = new DataGridView();
            label1 = new Label();
            lbxEnCok = new ListBox();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvEnCokYenenYemek).BeginInit();
            SuspendLayout();
            // 
            // cmbxyiyecek
            // 
            cmbxyiyecek.FormattingEnabled = true;
            cmbxyiyecek.Location = new Point(207, 112);
            cmbxyiyecek.Name = "cmbxyiyecek";
            cmbxyiyecek.Size = new Size(241, 28);
            cmbxyiyecek.TabIndex = 11;
            cmbxyiyecek.SelectedIndexChanged += cmbxyiyecek_SelectedIndexChanged;
            // 
            // lblKisi1
            // 
            lblKisi1.AutoSize = true;
            lblKisi1.BackColor = Color.Transparent;
            lblKisi1.Location = new Point(78, 115);
            lblKisi1.Name = "lblKisi1";
            lblKisi1.Size = new Size(61, 20);
            lblKisi1.TabIndex = 10;
            lblKisi1.Text = "Yiyecek:";
            // 
            // dgvEnCokYenenYemek
            // 
            dgvEnCokYenenYemek.BackgroundColor = SystemColors.Info;
            dgvEnCokYenenYemek.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.Transparent;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            dgvEnCokYenenYemek.DefaultCellStyle = dataGridViewCellStyle1;
            dgvEnCokYenenYemek.EnableHeadersVisualStyles = false;
            dgvEnCokYenenYemek.Location = new Point(78, 146);
            dgvEnCokYenenYemek.Name = "dgvEnCokYenenYemek";
            dgvEnCokYenenYemek.RowHeadersWidth = 51;
            dgvEnCokYenenYemek.Size = new Size(516, 410);
            dgvEnCokYenenYemek.TabIndex = 12;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Location = new Point(651, 120);
            label1.Name = "label1";
            label1.Size = new Size(161, 20);
            label1.TabIndex = 13;
            label1.Text = "En çok yenen 3 yemek :";
            // 
            // lbxEnCok
            // 
            lbxEnCok.BackColor = SystemColors.Info;
            lbxEnCok.FormattingEnabled = true;
            lbxEnCok.Location = new Point(651, 146);
            lbxEnCok.Name = "lbxEnCok";
            lbxEnCok.Size = new Size(292, 404);
            lbxEnCok.TabIndex = 14;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Location = new Point(78, 72);
            label2.Name = "label2";
            label2.Size = new Size(309, 20);
            label2.TabIndex = 15;
            label2.Text = "Lütfen bilgi almak istediğiniz yiyeceği seçiniz.";
            // 
            // EnCokYenenYemekEkrani
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1079, 666);
            Controls.Add(label2);
            Controls.Add(lbxEnCok);
            Controls.Add(label1);
            Controls.Add(dgvEnCokYenenYemek);
            Controls.Add(cmbxyiyecek);
            Controls.Add(lblKisi1);
            Name = "EnCokYenenYemekEkrani";
            Text = "EnCokYenenYemekEkrani";
            ((System.ComponentModel.ISupportInitialize)dgvEnCokYenenYemek).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cmbxyiyecek;
        private Label lblKisi1;
        private DataGridView dgvEnCokYenenYemek;
        private Label label1;
        private ListBox lbxEnCok;
        private Label label2;
    }
}