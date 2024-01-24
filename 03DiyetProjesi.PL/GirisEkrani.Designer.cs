namespace _03DiyetProjesi.PL
{
    partial class GirisEkrani
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GirisEkrani));
            label1 = new Label();
            label2 = new Label();
            txtMail = new TextBox();
            txtSifre = new TextBox();
            btnGiris = new Button();
            btnKayitOl = new Button();
            label3 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Location = new Point(209, 192);
            label1.Name = "label1";
            label1.Size = new Size(41, 20);
            label1.TabIndex = 0;
            label1.Text = "Mail:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Location = new Point(209, 238);
            label2.Name = "label2";
            label2.Size = new Size(42, 20);
            label2.TabIndex = 1;
            label2.Text = "Şifre:";
            // 
            // txtMail
            // 
            txtMail.Location = new Point(282, 188);
            txtMail.Margin = new Padding(3, 4, 3, 4);
            txtMail.Name = "txtMail";
            txtMail.Size = new Size(152, 27);
            txtMail.TabIndex = 2;
            // 
            // txtSifre
            // 
            txtSifre.Location = new Point(282, 234);
            txtSifre.Margin = new Padding(3, 4, 3, 4);
            txtSifre.Name = "txtSifre";
            txtSifre.PasswordChar = '*';
            txtSifre.Size = new Size(152, 27);
            txtSifre.TabIndex = 3;
            // 
            // btnGiris
            // 
            btnGiris.BackColor = SystemColors.Info;
            btnGiris.Location = new Point(315, 288);
            btnGiris.Margin = new Padding(3, 4, 3, 4);
            btnGiris.Name = "btnGiris";
            btnGiris.Size = new Size(86, 31);
            btnGiris.TabIndex = 4;
            btnGiris.Text = "GİRİŞ";
            btnGiris.UseVisualStyleBackColor = false;
            btnGiris.Click += btnGiris_Click;
            // 
            // btnKayitOl
            // 
            btnKayitOl.BackColor = SystemColors.Info;
            btnKayitOl.Location = new Point(315, 327);
            btnKayitOl.Margin = new Padding(3, 4, 3, 4);
            btnKayitOl.Name = "btnKayitOl";
            btnKayitOl.Size = new Size(86, 31);
            btnKayitOl.TabIndex = 5;
            btnKayitOl.Text = "KAYIT OL";
            btnKayitOl.UseVisualStyleBackColor = false;
            btnKayitOl.Click += btnKayitOl_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Location = new Point(137, 116);
            label3.Name = "label3";
            label3.Size = new Size(434, 20);
            label3.TabIndex = 6;
            label3.Text = "Merhaba! Diyet Uygulamasına Hoşgeldiniz . Lütfen giriş yaptınız.";
            // 
            // GirisEkrani
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(716, 538);
            Controls.Add(label3);
            Controls.Add(btnKayitOl);
            Controls.Add(btnGiris);
            Controls.Add(txtSifre);
            Controls.Add(txtMail);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "GirisEkrani";
            Text = "Diyet Uygulaması";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtMail;
        private TextBox txtSifre;
        private Button btnGiris;
        private Button btnKayitOl;
        private Label label3;
    }
}
