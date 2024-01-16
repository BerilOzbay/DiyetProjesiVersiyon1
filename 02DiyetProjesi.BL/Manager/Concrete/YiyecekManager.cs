using _01DiyetProjesi.DAL.Context.EF;
using _01DiyetProjesi.DAL.Entities.Concrete;
using _01DiyetProjesi.DAL.Repository.Concrete;
using _02DiyetProjesi.BL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02DiyetProjesi.BL.Manager.Concrete
{
    public class YiyecekManager
    {
        private YiyecekRepository _yiyecekRepository;
        public YiyecekManager()
        {
            _yiyecekRepository = new YiyecekRepository(new EfDbContext());
        }
        public void Add(YiyecekViewModel yiyecekViewModel)
        {
            Yiyecek yiyecek = new Yiyecek()
            {
                Ad = yiyecekViewModel.Ad,
                Kalori = yiyecekViewModel.Kalori,
                Resim = yiyecekViewModel.Resim,

            };

            _yiyecekRepository.Add(yiyecek);
        }
    }
}
