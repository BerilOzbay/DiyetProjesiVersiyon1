namespace _03DiyetProjesi.PL
{
    partial class OgunEkrani
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OgunEkrani));
            txtOgunAdi = new TextBox();
            label1 = new Label();
            dgvOgunEkrani = new DataGridView();
            btnOgunEkle = new Button();
            btnOgunSil = new Button();
            btnOgunGuncelle = new Button();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvOgunEkrani).BeginInit();
            SuspendLayout();
            // 
            // txtOgunAdi
            // 
            txtOgunAdi.BackColor = SystemColors.Info;
            txtOgunAdi.Location = new Point(323, 114);
            txtOgunAdi.Name = "txtOgunAdi";
            txtOgunAdi.Size = new Size(188, 27);
            txtOgunAdi.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Location = new Point(242, 117);
            label1.Name = "label1";
            label1.Size = new Size(75, 20);
            label1.TabIndex = 1;
            label1.Text = "Öğün Adı:";
            // 
            // dgvOgunEkrani
            // 
            dgvOgunEkrani.BackgroundColor = SystemColors.Info;
            dgvOgunEkrani.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.Transparent;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            dgvOgunEkrani.DefaultCellStyle = dataGridViewCellStyle1;
            dgvOgunEkrani.EnableHeadersVisualStyles = false;
            dgvOgunEkrani.Location = new Point(241, 158);
            dgvOgunEkrani.Margin = new Padding(3, 4, 3, 4);
            dgvOgunEkrani.Name = "dgvOgunEkrani";
            dgvOgunEkrani.RowHeadersWidth = 51;
            dgvOgunEkrani.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvOgunEkrani.Size = new Size(488, 280);
            dgvOgunEkrani.TabIndex = 2;
            dgvOgunEkrani.CellClick += dgvOgunEkrani_CellClick;
            // 
            // btnOgunEkle
            // 
            btnOgunEkle.BackColor = SystemColors.Info;
            btnOgunEkle.Location = new Point(244, 471);
            btnOgunEkle.Margin = new Padding(3, 4, 3, 4);
            btnOgunEkle.Name = "btnOgunEkle";
            btnOgunEkle.Size = new Size(130, 41);
            btnOgunEkle.TabIndex = 3;
            btnOgunEkle.Text = "EKLE";
            btnOgunEkle.UseVisualStyleBackColor = false;
            btnOgunEkle.Click += btnOgunEkle_Click;
            // 
            // btnOgunSil
            // 
            btnOgunSil.BackColor = SystemColors.Info;
            btnOgunSil.Location = new Point(417, 471);
            btnOgunSil.Margin = new Padding(3, 4, 3, 4);
            btnOgunSil.Name = "btnOgunSil";
            btnOgunSil.Size = new Size(130, 41);
            btnOgunSil.TabIndex = 4;
            btnOgunSil.Text = "SİL";
            btnOgunSil.UseVisualStyleBackColor = false;
            btnOgunSil.Click += btnOgunSil_Click;
            // 
            // btnOgunGuncelle
            // 
            btnOgunGuncelle.BackColor = SystemColors.Info;
            btnOgunGuncelle.Location = new Point(599, 471);
            btnOgunGuncelle.Margin = new Padding(3, 4, 3, 4);
            btnOgunGuncelle.Name = "btnOgunGuncelle";
            btnOgunGuncelle.Size = new Size(130, 41);
            btnOgunGuncelle.TabIndex = 5;
            btnOgunGuncelle.Text = "GÜNCELLE";
            btnOgunGuncelle.UseVisualStyleBackColor = false;
            btnOgunGuncelle.Click += btnOgunGuncelle_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Location = new Point(244, 58);
            label2.Name = "label2";
            label2.Size = new Size(279, 20);
            label2.TabIndex = 6;
            label2.Text = "Lütfen eklemek istediğiniz öğünü yazınız.";
            // 
            // OgunEkrani
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1022, 660);
            Controls.Add(label2);
            Controls.Add(btnOgunGuncelle);
            Controls.Add(btnOgunSil);
            Controls.Add(btnOgunEkle);
            Controls.Add(dgvOgunEkrani);
            Controls.Add(label1);
            Controls.Add(txtOgunAdi);
            Name = "OgunEkrani";
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
        private Label label2;
    }
}