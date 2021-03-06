using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using Vehicle.DAL;

namespace Vehicle.Repository.Common
{
    public interface IRepository<TEntity> where TEntity : class
    {
        TEntity Get(int id);
         IEnumerable<TEntity> GetAll();
        IEnumerable<TEntity> Find(Expression<Func<TEntity, bool>> predicate);
        IEnumerable<TEntity> Include(params Expression<Func<TEntity, object>>[] includes);
        TEntity SingleOrDefault(Expression<Func<TEntity, bool>> predicate);
        void Add(TEntity entity);
        void AddRange(IEnumerable<TEntity> entities);
        
        void Remove(TEntity entity);

        void RemoveRange(IEnumerable<TEntity> entities);
    }
}