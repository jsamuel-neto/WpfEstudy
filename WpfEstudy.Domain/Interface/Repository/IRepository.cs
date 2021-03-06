﻿using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using WpfEstudy.Domain.Entity;

namespace WpfEstudy.Domain.Interface.Repository
{
    public interface IRepository<TEntity> : IDisposable where TEntity : Entidade
    {
        Task Add(TEntity obj);
        Task<TEntity> FindById(int id);
        Task<IEnumerable<TEntity>> FindAll();
        Task Update(TEntity obj);
        Task Delete(int id);
        Task<IEnumerable<TEntity>> Find(Expression<Func<TEntity, bool>> predicate);
        Task<int> SaveChanges();
    }
}
