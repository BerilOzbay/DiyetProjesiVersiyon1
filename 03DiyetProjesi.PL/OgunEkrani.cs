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
    public partial class OgunEkrani : Form
    {
        OgunManager ogunManager = new OgunManager();
        OgunViewModel secilenOgun;

        public OgunEkrani()
        {
            InitializeComponent();
            Goster();
        }
        private void Goster()
        {
            dgvOgunEkrani.DataSource = null;
            dgvOgunEkrani.DataSource = OgunleriGetir();
        }
        private List<OgunViewModel> OgunleriGetir()
        {
            try
            {
                List<OgunViewModel> ogunler = ogunManager.GetAll().ToList();
                return ogunler;
            }
            catch (Exception)
            {

                throw;
            }
        }
        private void btnOgunEkle_Click(object sender, EventArgs e)
        {
            try
            {
                OgunViewModel ogun = new OgunViewModel();
                ogun.Ad = txtOgunAdi.Text;
                ogunManager.Add(ogun);
                MessageBox.Show("Öğün başarıyla eklenmiştir");
                Goster();

            }
            catch (Exception ex)
            {

                MessageBox.Show("hata oluştu" + ex.Message);

            }

        }

        private void btnOgunGuncelle_Click(object sender, EventArgs e)
        {
            try
            {
                if (secilenOgun != null)
                {
                    secilenOgun.Ad = txtOgunAdi.Text;
                    ogunManager.Update(secilenOgun);
                    Goster();
                }
                else
                    MessageBox.Show("Lütfen öğün seçiniz");
            }
            catch (Exception ex)
            {
                MessageBox.Show("hata oluştu" + ex.Message);
            }


        }

        private void dgvOgunEkrani_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            secilenOgun = (OgunViewModel)dgvOgunEkrani.SelectedRows[0].DataBoundItem;
            txtOgunAdi.Text = secilenOgun.Ad;
        }

        private void btnOgunSil_Click(object sender, EventArgs e)
        {
            if (secilenOgun != null)
            {
                ogunManager.Delete(secilenOgun);
                Goster();

                MessageBox.Show("Başarıyla silinmiştir");
                
            }
            else
                MessageBox.Show("Ogun seçiniz!");
        }
    }
}
