using _01DiyetProjesi.DAL.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02DiyetProjesi.BL.Model
{
    public class KullaniciViewModel
    {
        public int Id {  get; set; } // id kalkacak.
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string Email { get; set; }
        public string Sifre { get; set; }
        public Cinsiyet Cinsiyet { get; set; }
        public byte Yas { get; set; }
        public float Kilo { get; set; }
    }
}
