using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TPW.Domain.Base;
using TPW_GM1.Models;

namespace TPW.Domain.Repositories
{
    public class BranchRepository : BaseRepository<Branch>
    {
        public BranchRepository(UnitOfWork unitOfWork) : base(unitOfWork)
        {
        }
    }
}
