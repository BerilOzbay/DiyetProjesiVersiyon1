using _01DiyetProjesi.DAL.Entities.Concrete;
using _02DiyetProjesi.BL.Manager.Concrete;
using _02DiyetProjesi.BL.Model;

namespace _03DiyetProjesi.PL
{
    public partial class GirisEkrani : Form
    {
        KullaniciManager kullaniciManager = new KullaniciManager();
        KullaniciViewModel KullaniciViewModel = new KullaniciViewModel();


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
            if (!string.IsNullOrEmpty(textBox1.Text))
            {
                KullaniciViewModel.Email = textBox1.Text;

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
            else
            {
                MessageBox.Show("Lütfen bilgilerinizi giriniz");
            }
        }
    }
}