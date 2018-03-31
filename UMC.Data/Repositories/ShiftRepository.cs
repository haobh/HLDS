using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UMC.Data.Infrastructure;
using UMC.Model.Models;

namespace UMC.Data.Repositories
{
    public interface IShiftRepository : IRepository<Shift>
    {
    }
    public class ShiftRepository : RepositoryBase<Shift>, IShiftRepository
    {
        public ShiftRepository(IDbFactory dbFactory) : base(dbFactory)
        {

        }
    }
}
