using _01DiyetProjesi.DAL.Context.EF;
using _01DiyetProjesi.DAL.Entities.Concrete;
using _02DiyetProjesi.BL.Manager.Concrete;
using _02DiyetProjesi.BL.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace _03DiyetProjesi.PL
{
    public partial class YiyecekİslemleriEkrani : Form
    {
        OgunManager OgunManager = new OgunManager();
        YiyecekManager YiyecekManager= new YiyecekManager();
        PorsiyonManager PorsiyonManager =new PorsiyonManager();
        KullaniciManager KullaniciManager = new KullaniciManager();
        DiyetTablosuManager diyetTablosuManager = new DiyetTablosuManager();
        DiyetTablosuViewModel secilen;
        List<YiyecekViewModel> yiyecekler;
        List<KullaniciViewModel> kullanicilar;
        List<OgunViewModel> ogunler;
        List<PorsiyonViewModel> porsiyonlar;
        public YiyecekİslemleriEkrani()
        {
            InitializeComponent();
            Doldur();
            Goster();
        }
        private void Doldur()
        {
            yiyecekler= YiyecekManager.GetAll().ToList();
            ogunler=OgunManager.GetAll().ToList();
            porsiyonlar=PorsiyonManager.GetAll().ToList();
            kullanicilar = KullaniciManager.GetAll().ToList();
            cbxOgunSec.DataSource = ogunler;
            cbxYiyecekSec.DataSource = yiyecekler;
            cbxPorsiyonSec.DataSource = porsiyonlar;
        }
        private void Goster()
        {
            List<DiyetTablosuViewModel>diyetTablosu=diyetTablosuManager.GetAll().ToList();
            foreach (var d in diyetTablosu)
            {
                d.Yiyecek=yiyecekler.Where(y => y.Id == d.YiyecekId).FirstOrDefault();
                d.Kullanici=kullanicilar.Where(k=>k.Id==d.KullaniciId).FirstOrDefault();
                d.Porsiyon = porsiyonlar.Where(p => p.Id == d.PorsiyonId).FirstOrDefault();
                d.Ogun = ogunler.Where(o => o.Id == d.OgunId).FirstOrDefault();
            }
            dgvYiyecekİslemleri.DataSource = null;
            dgvYiyecekİslemleri.DataSource = diyetTablosu;
            

        }
        private void btnEkle_Click(object sender, EventArgs e)
        {
            DiyetTablosuViewModel diyetTablosu = new DiyetTablosuViewModel();
            diyetTablosu.OgunId = ((OgunViewModel)cbxOgunSec.SelectedItem).Id;
            diyetTablosu.YiyecekId = ((YiyecekViewModel)cbxYiyecekSec.SelectedItem).Id;
            diyetTablosu.PorsiyonId = ((PorsiyonViewModel)cbxPorsiyonSec.SelectedItem).Id;
            diyetTablosu.Birim = (int)nUd.Value;
            diyetTablosu.KullaniciId = 3;//todo
            diyetTablosuManager.Add(diyetTablosu);
            Goster();
            
        }

        private void dgvYiyecekİslemleri_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
