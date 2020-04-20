using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using WpfEstudy.Domain.Entity;
using WpfEstudy.Domain.Interface.Repository;
using WpfEstudy.Infrastructure.Context;

namespace WpfEstudy.Infrastructure.Repository
{
    public abstract class Repository<TEntity> : IRepository<TEntity> where TEntity : Entidade, new()
    {
        protected readonly WpfEstudyDBContext Db;
        protected readonly DbSet<TEntity> DbSet;

        protected Repository(WpfEstudyDBContext db)
        {
            Db = db;
            DbSet = db.Set<TEntity>();
        }

        public virtual async Task<IEnumerable<TEntity>> FindAll()
        {
            return await DbSet.AsNoTracking().ToListAsync();
        }

        public virtual async Task<TEntity> FindById(int id)
        {
            return await DbSet.FindAsync(id);
        }

        public async Task<IEnumerable<TEntity>> Find(Expression<Func<TEntity,bool>> predicate)
        {
            return await DbSet.AsNoTracking().Where(predicate).ToListAsync();
        }

        public async Task<int> SaveChanges()
        {
            return await Db.SaveChangesAsync();
        }

        public virtual async Task Add(TEntity obj)
        {
            DbSet.Add(obj);
            await SaveChanges();
        }

        public virtual async Task Update(TEntity obj)
        {
            DbSet.Update(obj);
            await SaveChanges();
        }

        public virtual async Task Delete(int id)
        {
            DbSet.Remove(new TEntity { id = id });
            await SaveChanges();
        }

        public void Dispose()
        {
            Db?.Dispose();
        }
    }
}
