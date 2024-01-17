﻿using _01DiyetProjesi.DAL.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace _01DiyetProjesi.DAL.Repository.Abstract
{
    internal interface IGenericRepository<T> where T : class
    {
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
        void Remove(T entity);
        ICollection<T> GetAll();
        T GetById(int id);
        ICollection<T> Search(Expression<Func<T, bool>> predicate);
    }
}