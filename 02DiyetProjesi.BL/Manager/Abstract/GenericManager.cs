using _01DiyetProjesi.DAL.Entities.Abstract;
using _01DiyetProjesi.DAL.Entities.Concrete;
using _01DiyetProjesi.DAL.Repository.Abstract;
using _01DiyetProjesi.DAL.Repository.Concrete;
using _02DiyetProjesi.BL.Model;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace _02DiyetProjesi.BL.Manager.Abstract
{
    public class GenericManager<TEntity, TRepo,TDbContext,TModel> : IGenericManager<TModel> 
        where TEntity : BaseEntity, new()
        where TModel : class, new()
        where TDbContext : DbContext, new()
        where TRepo : GenericRepository<TEntity>, new()
    {
        private TRepo _repo;
        private TDbContext _dbContext;
        private IMapper _mapper;
        public GenericManager(IMapper mapper)
        {
            _dbContext = new TDbContext();
            _repo = new TRepo();

            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<TModel,TEntity>().ReverseMap();
            });
            _mapper = new Mapper(config);
        }
        public void Add(TModel model)
        {
            TEntity entity = _mapper.Map<TEntity>(model);

            _repo.Add(entity);
        }

        public void Delete(TModel model)
        {
            throw new NotImplementedException();
        }

        public List<TModel> GetAll()
        {
            throw new NotImplementedException();
        }

        public TModel GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Remove(TModel model)
        {
            throw new NotImplementedException();
        }

        public List<TModel> Search(Expression<Func<TModel, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public void Update(TModel model)
        {
            throw new NotImplementedException();
        }
    }
}
