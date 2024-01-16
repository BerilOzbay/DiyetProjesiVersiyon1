using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02DiyetProjesi.BL.Model
{
    public class YiyecekViewModel
    {
        public string Ad { get; set; }
        public float Kalori { get; set; }
        //Yiyeceklerin gorseli tutulacak.
        public byte[] Resim { get; set; }
    }
}
