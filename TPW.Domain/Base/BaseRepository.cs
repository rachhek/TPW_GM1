using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using TPW_GM1.Models;

namespace TPW.Domain.Base
{
    public abstract class BaseRepository<TEntity> : IDisposable where TEntity : BaseClass
    {
        public UnitOfWork UnitOfWork { get; set; }
        protected DbContext Context
        {
            get { return UnitOfWork.Context; }
        }
        public BaseRepository(UnitOfWork unitOfWork)
        {
            this.UnitOfWork = unitOfWork;
        }
        public void Dispose()
        {
            if (UnitOfWork != null)
            {
                UnitOfWork.Dispose();
            }
            GC.SuppressFinalize(this);
        }

        public virtual void SaveChanges()
        {
            Context.SaveChanges();

        }

        public virtual IQueryable<TEntity> GetQuery()
        {
            return Context.Set<TEntity>();
        }

        public virtual IEnumerable<TEntity> GetAll()
        {
            return Context.Set<TEntity>().ToList();
        }

        public virtual IEnumerable<TEntity> Find(Expression<Func<TEntity, bool>> predicate)
        {
            return GetQuery().Where(predicate).ToList();
        }

        public virtual int Count()
        {
            return GetQuery().Count();

        }

        public virtual bool Any(Expression<Func<TEntity, bool>> predicate)
        {
            return GetQuery().Any(predicate);
        }

        public virtual TEntity GetById(Guid Id)
        {
            return Context.Set<TEntity>().FirstOrDefault(entity => entity.Id == Id);
        }

        public virtual void Add(TEntity entity)
        {
            Context.Set<TEntity>().Add(entity);
        }

        public virtual void Update(TEntity entity)
        {
            Context.Entry(entity).State = EntityState.Modified;
        }

        public virtual void Delete(TEntity entity)
        {
            Context.Set<TEntity>().Remove(entity);
        }


    }
}
