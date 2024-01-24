namespace _03DiyetProjesi.PL
{
    partial class GunSonuKaloriRaporEkrani
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GunSonuKaloriRaporEkrani));
            label1 = new Label();
            dgvGunSonuKalori = new DataGridView();
            Label = new Label();
            dateTimePicker1 = new DateTimePicker();
            label2 = new Label();
            lblGunSonuKalorisi = new Label();
            lblToplamKalori = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvGunSonuKalori).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Location = new Point(186, 76);
            label1.Name = "label1";
            label1.Size = new Size(341, 20);
            label1.TabIndex = 0;
            label1.Text = "Gün Sonu Raporu Görmek istediğiniz tarihi seçiniz:";
            // 
            // dgvGunSonuKalori
            // 
            dgvGunSonuKalori.BackgroundColor = SystemColors.Info;
            dgvGunSonuKalori.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.Transparent;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            dgvGunSonuKalori.DefaultCellStyle = dataGridViewCellStyle1;
            dgvGunSonuKalori.EnableHeadersVisualStyles = false;
            dgvGunSonuKalori.Location = new Point(186, 117);
            dgvGunSonuKalori.Margin = new Padding(3, 4, 3, 4);
            dgvGunSonuKalori.Name = "dgvGunSonuKalori";
            dgvGunSonuKalori.RowHeadersWidth = 51;
            dgvGunSonuKalori.Size = new Size(893, 414);
            dgvGunSonuKalori.TabIndex = 1;
            // 
            // Label
            // 
            Label.AutoSize = true;
            Label.BackColor = Color.Transparent;
            Label.Location = new Point(186, 563);
            Label.Name = "Label";
            Label.Size = new Size(195, 20);
            Label.TabIndex = 2;
            Label.Text = "Gün Sonu Toplam Kaloriniz :";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.CalendarMonthBackground = SystemColors.Info;
            dateTimePicker1.Location = new Point(550, 71);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(250, 27);
            dateTimePicker1.TabIndex = 3;
            dateTimePicker1.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Location = new Point(186, 610);
            label2.Name = "label2";
            label2.Size = new Size(128, 20);
            label2.TabIndex = 4;
            label2.Text = "Toplam Kaloriniz :";
            // 
            // lblGunSonuKalorisi
            // 
            lblGunSonuKalorisi.BackColor = SystemColors.Info;
            lblGunSonuKalorisi.BorderStyle = BorderStyle.FixedSingle;
            lblGunSonuKalorisi.Location = new Point(400, 563);
            lblGunSonuKalorisi.Name = "lblGunSonuKalorisi";
            lblGunSonuKalorisi.Size = new Size(166, 25);
            lblGunSonuKalorisi.TabIndex = 5;
            // 
            // lblToplamKalori
            // 
            lblToplamKalori.BackColor = SystemColors.Info;
            lblToplamKalori.BorderStyle = BorderStyle.FixedSingle;
            lblToplamKalori.Location = new Point(400, 610);
            lblToplamKalori.Name = "lblToplamKalori";
            lblToplamKalori.Size = new Size(166, 25);
            lblToplamKalori.TabIndex = 6;
            // 
            // GunSonuKaloriRaporEkrani
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1220, 690);
            Controls.Add(lblToplamKalori);
            Controls.Add(lblGunSonuKalorisi);
            Controls.Add(label2);
            Controls.Add(dateTimePicker1);
            Controls.Add(Label);
            Controls.Add(dgvGunSonuKalori);
            Controls.Add(label1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "GunSonuKaloriRaporEkrani";
            Text = "GunSonuRaporEkrani";
            ((System.ComponentModel.ISupportInitialize)dgvGunSonuKalori).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView dgvGunSonuKalori;
        private Label Label;
        private DateTimePicker dateTimePicker1;
        private Label label2;
        private Label lblGunSonuKalorisi;
        private Label lblToplamKalori;
    }
}