using Data.Context;
using Data.DAL.Customer;
using Data.DAL.Generics;
using Data.Repositories.Generic;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Repositories.Db1Repository
{
    public class MasterRepository:GenericRepository<Master>,IMasterDAL
    {
        private readonly AppDbContext _db;
        public MasterRepository(AppDbContext db):base(db)
        {
            _db = db;
        }
        

    }
}
