using _01DiyetProjesi.DAL.Entities.Concrete;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace _03DiyetProjesi.PL
{
    public partial class YiyecekİslemleriEkrani : Form
    {
        OgunManager OgunManager = new OgunManager();
        YiyecekManager YiyecekManager= new YiyecekManager();
        PorsiyonManager PorsiyonManager =new PorsiyonManager();
        DiyetTablosuManager diyetTablosuManager = new DiyetTablosuManager();
        DiyetTablosuViewModel secilen;
        public YiyecekİslemleriEkrani()
        {
            InitializeComponent();
            Doldur();
        }
        private void Doldur()
        {
            cbxOgunSec.DataSource = OgunManager.GetAll().ToList();
            cbxYiyecekSec.DataSource = YiyecekManager.GetAll().ToList();
            cbxPorsiyonSec.DataSource = PorsiyonManager.GetAll().ToList();
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
            
            
        }

        private void dgvYiyecekİslemleri_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
