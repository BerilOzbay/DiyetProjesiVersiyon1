using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace _02DiyetProjesi.BL.Manager.Abstract
{
    public interface IGenericManager<T>
    {
        void Add(T model);
        void Update(T model);
        void Delete(T model);
        void Remove(T model);
        T GetById(int id);
        List<T> GetAll();
        List<T> Search(Expression<Func<T, bool>> predicate);
    }
}
