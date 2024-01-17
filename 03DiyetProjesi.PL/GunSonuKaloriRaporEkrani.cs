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
    public partial class GunSonuKaloriRaporEkrani : Form
    {
        public GunSonuKaloriRaporEkrani()
        {
            InitializeComponent();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            DateTime selectedDate = dateTimePicker1.Value;
            dgvGunSonuKalori.DataSource = YemekleriListele(selectedDate);

        }

        private List<DiyetTablosuViewModel> YemekleriListele(DateTime selectedDate)
        {
            
            DiyetTablosuManager diyetTablosuManager = new DiyetTablosuManager();
            try
            {
                List<DiyetTablosuViewModel> yemekler = diyetTablosuManager
                    .GetAll()
                    .Where(dt => dt.YenilenGun == selectedDate)
                    .ToList();
                if (yemekler.Any())
                {
                    // Veri bulundu, işlemleri gerçekleştir
                    return yemekler;
                }
                else
                {
                    // Veri bulunamadı, kullanıcıya uyarı göster
                    MessageBox.Show("Seçtiğiniz tarihe ait veri bulunamadı.");
                    //Boş bir liste dön
                    return new List<DiyetTablosuViewModel>();
                }

            }

            catch (Exception ex) 
            {
                throw; 
            }
            
        }
    }
}
