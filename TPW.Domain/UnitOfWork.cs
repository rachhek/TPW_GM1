using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TPW_GM1.Models;

namespace TPW.Domain
{
    public class UnitOfWork : IDisposable
    {
        public DbContext Context { get; set; }
        public UnitOfWork()
        {
            Context = ApplicationDbContext.Create();
        }
        public void Dispose()
        {
            if (Context != null)
            {
                Context.Dispose();
                Context = null;
            }
            GC.SuppressFinalize(this);
        }
    }
}
