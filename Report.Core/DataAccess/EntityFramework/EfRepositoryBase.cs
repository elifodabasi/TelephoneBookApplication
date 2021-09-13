﻿using Microsoft.EntityFrameworkCore;
using Report.Core.Entity.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Report.Core.DataAccess.EntityFramework
{
    public class EfRepositoryBase<TEntity, TContext> : IEntityRepository<TEntity>
        where TEntity : class, IEntity, new()
       where TContext : DbContext, new()
    {
        public void Add(TEntity entity)
        {
            using (TContext context = new TContext())
            {
                var addedEntity = context.Entry(entity);
                addedEntity.State = EntityState.Added;
                context.SaveChanges();
            }
        }

        public void Delete(TEntity entity)
        {
            using (TContext context = new TContext())
            {
                var deletedEntity = context.Remove(entity);
                deletedEntity.State = EntityState.Deleted;
                context.SaveChanges();

            }
        }

        public TEntity Find(Expression<Func<TEntity, bool>> predicate)
        {
            using (TContext context = new TContext())
            {
                return context.Set<TEntity>().SingleOrDefault(predicate);

            }
        }

        public List<TEntity> GetAll(Expression<Func<TEntity, bool>> predicate = null)
        {
            using (TContext context = new TContext())
            {
                return predicate == null ? context.Set<TEntity>().ToList() : context.Set<TEntity>().Where(predicate).ToList();
            }
        }


        public void Update(TEntity entity)
        {
            using (TContext context = new TContext())
            {
                var updatedEntity = context.Update(entity);
                updatedEntity.State = EntityState.Modified;
                context.SaveChanges();

            }
        }
    }
}
