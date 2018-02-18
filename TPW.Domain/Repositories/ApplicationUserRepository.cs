using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using TPW_GM1.Models;

namespace TPW.Domain.Repositories
{
    public class ApplicationUserRepository
    {

        //public bool IsUserSubscribed(Guid id)
        //{
        //    using (var db = new ApplicationDbContext())
        //    {
        //        var user = db.Users.Where(x => x.Id.ToString() == id.ToString()).FirstOrDefault();
        //        int activeSubs = user.Subscriptions.Count(su => DateTime.Now >= su.StartDate && DateTime.Now <= su.EndDate);
        //        if (activeSubs <= 0)
        //            return false;
        //        else
        //            return true;
        //    }
        //}

        public UnitOfWork UnitOfWork { get; set; }
        protected DbContext Context
        {

            get { return UnitOfWork.Context; }
        }
        public ApplicationUserRepository(UnitOfWork unitOfWork)
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


        public void SaveChanges()
        {
            Context.SaveChanges();

        }

        public IQueryable<ApplicationUser> GetQuery()
        {
            return Context.Set<ApplicationUser>();
        }

        public IEnumerable<ApplicationUser> GetAll()
        {
            return Context.Set<ApplicationUser>().ToList();
        }

        public IEnumerable<ApplicationUser> Find(Expression<Func<ApplicationUser, bool>> predicate)
        {
            return GetQuery().Where(predicate).ToList();
        }

        public int Count()
        {
            return GetQuery().Count();

        }

        public bool Any(Expression<Func<ApplicationUser, bool>> predicate)
        {
            return GetQuery().Any(predicate);
        }

        public ApplicationUser GetById(Guid Id)
        {
            return Context.Set<ApplicationUser>().FirstOrDefault(entity => entity.Id.ToString() == Id.ToString());
        }

        public void Add(ApplicationUser entity)
        {
            Context.Set<ApplicationUser>().Add(entity);
        }

        public void Update(ApplicationUser entity)
        {
            Context.Entry(entity).State = EntityState.Modified;
        }

        public void Delete(ApplicationUser entity)
        {
            Context.Set<ApplicationUser>().Remove(entity);
        }
    }
}
