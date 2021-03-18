using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace E4Progress.DAL.IRepository
{
    public interface IRepository<TEntity> where TEntity : class
    {
        void Add(TEntity t);
        TEntity FindById(int id);
        List<TEntity> GetAll(Expression<Func<TEntity, object>> include1 = null, Expression<Func<TEntity, object>> include2 = null, Expression<Func<TEntity, object>> include3 = null, Expression<Func<TEntity, object>> include4 = null, Expression<Func<TEntity, object>> include5 = null);
        void Remove(int id);
    }
}
