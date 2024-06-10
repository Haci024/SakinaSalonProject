using Data.Context;
using Data.DAL.Customer;
using Data.DAL.Generics;
using Data.Repositories.Generic;
using Entity.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Repositories.Db1Repository
{
    public class CustomerRepository :GenericRepository<Customers>,ICustomerDAL
    {
        private readonly AppDbContext _db;
        public CustomerRepository(AppDbContext db ):base(db)
        {
            _db = db;   
        }

        public async Task<IEnumerable<Customers>> ActiveCustomerList(int filialId)
        {
            return await _db.Customers.Where(x=>x.Status==true).ToListAsync();
        }

        public async Task<IEnumerable<Customers>> BirthDateList(int filialId)
        {
            return await _db.Customers.Include(x=>x.Filial).Where(x => x.Status == true && x.BirthDate.Value.Date==DateTime.Today.Date && x.FilialId==filialId).ToListAsync();
        }

        public async Task<IEnumerable<Customers>> CustomerList(int filialId)
        {
            return await _db.Customers.Include(x=>x.Filial).Where(x=>x.FilialId==filialId).ToListAsync(); 
        }

        public async Task<IEnumerable<Customers>> FemaleList(int filialId)
        {
            
            return await _db.Customers.Include(x => x.Filial).Where(x => x.Female == true && x.FilialId == filialId).ToListAsync();
        }
        
        public async Task<IEnumerable<Customers>> InActiveCustomerList(int filialId)
        {
            return await _db.Customers.Include(x=>x.Filial).Where(x => x.Status==false && x.FilialId==filialId).ToListAsync();
        }

        public async Task<IEnumerable<Customers>> MaleList(int filialId)
        {
            return await _db.Customers.Include(x => x.Filial).Where(x=>x.Female==false).ToListAsync();
        }
        public async Task<Customers> SelectedCustomer(int CustomerId, int filialId)
        {
            return await _db.Customers.Include(x => x.Filial).Where(x => x.Id == CustomerId && x.FilialId == filialId).FirstOrDefaultAsync();
        }
    }
}
