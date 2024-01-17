using _01DiyetProjesi.DAL.Enums;
using _02DiyetProjesi.BL.Manager.Concrete;
using _02DiyetProjesi.BL.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _03DiyetProjesi.PL
{
    public partial class KayitOlEkrani : Form
    {
        public KayitOlEkrani()
        {
            InitializeComponent();
        }

        private void btnKayitOl_Click(object sender, EventArgs e)
        {
            KullaniciViewModel kullaniciViewModel = new KullaniciViewModel();
            kullaniciViewModel.Ad=txtAd.Text;
            kullaniciViewModel.Soyad=txtSoyad.Text;
            kullaniciViewModel.Yas=Convert.ToByte( txtYas.Text);
            kullaniciViewModel.Kilo=float.Parse( txtKilo.Text);
            kullaniciViewModel.Cinsiyet = rBtnErkek.Checked ? Cinsiyet.Erkek : Cinsiyet.Kadın;
            kullaniciViewModel.Email = txtMail.Text;
            kullaniciViewModel.Sifre=txtSifre.Text;
            KullaniciManager kullaniciManager = new KullaniciManager();
            kullaniciManager.Add(kullaniciViewModel);

        }
    }
}
