using AutoMapper;
using E4Progress.DAL.IRepository;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace E4Progress.DAL.Repositories
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        private readonly E4ProgressDBContext _context;
        private IMapper _mapper;
        internal DbSet<TEntity> dbSet;

        public Repository(E4ProgressDBContext context ,IMapper mapper)
        {
            _context = context;
            this.dbSet = _context.Set<TEntity>();
            _mapper = mapper;
        }

        public void Add(TEntity t)
        {
            var entity = _mapper.Map<TEntity>(t);
            dbSet.Add(entity);
        }

        public TEntity FindById(int id)
        {
            return dbSet.Find(id);
        }

        public List<TEntity> GetAll(Expression<Func<TEntity, object>> include1 = null, Expression<Func<TEntity, object>> include2 = null, Expression<Func<TEntity, object>> include3 = null, Expression<Func<TEntity, object>> include4 = null, Expression<Func<TEntity, object>> include5 = null)
        {
            if (include1 != null && include2 != null && include3 != null && include4 != null && include5 != null)
            {
                return _context.Set<TEntity>().Include(include1).Include(include2).Include(include3).Include(include4).Include(include5).ToList();
            }
            else if (include1 != null && include2 != null && include3 != null && include4 != null)
            {
                return _context.Set<TEntity>().Include(include1).Include(include2).Include(include3).Include(include4).ToList();
            }
            else if (include1 != null && include2 != null && include3 != null)
            {
                return _context.Set<TEntity>().Include(include1).Include(include2).Include(include3).ToList();

            }
            else if (include1 != null && include2 != null )
            {
                return _context.Set<TEntity>().Include(include1).Include(include2).ToList();

            }
            else if (include1 != null )
            {
                return _context.Set<TEntity>().Include(include1).ToList();

            }

            return _context.Set<TEntity>().ToList();
        }

        public void Remove(int id)
        {
            var entity = dbSet.Find(id);
            dbSet.Remove(entity);
        }
    }
}
