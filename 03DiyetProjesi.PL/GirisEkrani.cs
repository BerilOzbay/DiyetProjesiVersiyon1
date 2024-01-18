using _01DiyetProjesi.DAL.Context.EF;
using _01DiyetProjesi.DAL.Entities.Concrete;
using _02DiyetProjesi.BL.Manager.Concrete;
using _02DiyetProjesi.BL.Model;

namespace _03DiyetProjesi.PL
{
    public partial class GirisEkrani : Form
    {
        KullaniciManager kullaniciManager = new KullaniciManager();



        public GirisEkrani()
        {
            InitializeComponent();
        }

        private void btnKayitOl_Click(object sender, EventArgs e)
        {
            KayitOlEkrani kayitOlEkrani = new KayitOlEkrani();
            kayitOlEkrani.Show();

        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
        KullaniciViewModel KullaniciViewModel = new KullaniciViewModel();


            
            if ((kullaniciManager.GetAll().ToList().FirstOrDefault(a => a.Email.Contains(txtMail.Text)&&a.Sifre.Contains(txtSifre.Text)) != null))
            {
                
            if (!string.IsNullOrWhiteSpace(txtMail.Text))
            {
                KullaniciViewModel.Email = txtMail.Text;

                if (KullaniciViewModel.Email.Contains("@yonetici"))
                {
                    AdminEkran adminEkran = new AdminEkran();
                    adminEkran.Show();
                }
                else
                {
                    KullaniciAnaEkran kullaniciAnaEkran = new KullaniciAnaEkran();
                    kullaniciAnaEkran.Show();
                }
            }
            }
            else
            {
                MessageBox.Show("Lütfen Kayýt yapýnýz.");
                KayitOlEkrani kayitOlEkrani = new KayitOlEkrani();
                kayitOlEkrani.Show();
            }
        }
    }
}