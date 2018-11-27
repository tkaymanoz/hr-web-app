using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using PeopleFit.Data;
using PeopleFit.Services.Repositories;
using Microsoft.EntityFrameworkCore;

namespace PeopleFit.Services.Implementations
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        internal DbContext _context;
        internal DbSet<TEntity> dbSet;

        public Repository(DbContext context)
        {
            _context=context;
        }

        public void Add(TEntity entity)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<TEntity> Get(Expression<Func<TEntity, bool>> filter = null, Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> orderBy = null, string includeProperties = "")
        {
            IQueryable<TEntity> query = dbSet;

            if (filter != null)
            {
                query = query.Where(filter);
            }

            foreach (var includeProperty in includeProperties.Split
                (new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries))
            {
                query = query.Include(includeProperty);
            }

            if (orderBy != null)
            {
                return orderBy(query).ToList();
            }
            else
            {
                return query.ToList();
            }
        }


        public TEntity GetByID(int id)
        {
            return dbSet.Find(id);
        }

        public void Remove(TEntity entity)
        {
            throw new NotImplementedException();
        }

        public void Update(TEntity entity)
        {
            throw new NotImplementedException();
        }
    }
}