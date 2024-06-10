using Data.Context;
using Data.Repositories.Generic;
using Data.Services.EntityService;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Repositories.EntityRepos
{
    public class LazerCategoryRepository:GenericRepository<LazerCategory>,ILazerCategoryDAL
    {
        private readonly AppDbContext _db;
        public LazerCategoryRepository(AppDbContext db):base(db)
        {
            _db = db;
        }
    }
}
