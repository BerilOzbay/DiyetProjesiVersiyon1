namespace _03DiyetProjesi.PL
{
    partial class ÖğünEkranı
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
            txtOgunAdi = new TextBox();
            label1 = new Label();
            dgvOgunEkrani = new DataGridView();
            btnOgunEkle = new Button();
            btnOgunSil = new Button();
            btnOgunGuncelle = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvOgunEkrani).BeginInit();
            SuspendLayout();
            // 
            // txtOgunAdi
            // 
            txtOgunAdi.Location = new Point(153, 72);
            txtOgunAdi.Name = "txtOgunAdi";
            txtOgunAdi.Size = new Size(165, 27);
            txtOgunAdi.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(55, 72);
            label1.Name = "label1";
            label1.Size = new Size(72, 20);
            label1.TabIndex = 1;
            label1.Text = "Öğün Adı";
            // 
            // dgvOgunEkrani
            // 
            dgvOgunEkrani.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvOgunEkrani.Location = new Point(12, 141);
            dgvOgunEkrani.Name = "dgvOgunEkrani";
            dgvOgunEkrani.RowHeadersWidth = 51;
            dgvOgunEkrani.Size = new Size(488, 280);
            dgvOgunEkrani.TabIndex = 2;
            // 
            // btnOgunEkle
            // 
            btnOgunEkle.Location = new Point(12, 441);
            btnOgunEkle.Name = "btnOgunEkle";
            btnOgunEkle.Size = new Size(130, 41);
            btnOgunEkle.TabIndex = 3;
            btnOgunEkle.Text = "EKLE";
            btnOgunEkle.UseVisualStyleBackColor = true;
            // 
            // btnOgunSil
            // 
            btnOgunSil.Location = new Point(164, 441);
            btnOgunSil.Name = "btnOgunSil";
            btnOgunSil.Size = new Size(130, 41);
            btnOgunSil.TabIndex = 4;
            btnOgunSil.Text = "SİL";
            btnOgunSil.UseVisualStyleBackColor = true;
            // 
            // btnOgunGuncelle
            // 
            btnOgunGuncelle.Location = new Point(323, 441);
            btnOgunGuncelle.Name = "btnOgunGuncelle";
            btnOgunGuncelle.Size = new Size(130, 41);
            btnOgunGuncelle.TabIndex = 5;
            btnOgunGuncelle.Text = "GÜNCELLE";
            btnOgunGuncelle.UseVisualStyleBackColor = true;
            // 
            // ÖğünEkranı
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(726, 540);
            Controls.Add(btnOgunGuncelle);
            Controls.Add(btnOgunSil);
            Controls.Add(btnOgunEkle);
            Controls.Add(dgvOgunEkrani);
            Controls.Add(label1);
            Controls.Add(txtOgunAdi);
            Name = "ÖğünEkranı";
            Text = "ÖğünEkranı";
            ((System.ComponentModel.ISupportInitialize)dgvOgunEkrani).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtOgunAdi;
        private Label label1;
        private DataGridView dgvOgunEkrani;
        private Button btnOgunEkle;
        private Button btnOgunSil;
        private Button btnOgunGuncelle;
    }
}