using Data.DAL.Generics;
using Data.Repositories.Db1Repository;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Data.DAL.Customer
{
    public interface ICustomerDAL:IGenericDAL<Customers>
    {
        public Task<IEnumerable<Customers>> CustomerList(int filialId);
        public Task<IEnumerable<Customers>> ActiveCustomerList(int filialId);
        public Task<IEnumerable<Customers>> FemaleList(int filialId);
        public Task<IEnumerable<Customers>> MaleList(int filialId);
        public Task<IEnumerable<Customers>> InActiveCustomerList(int filialId);
        public Task<Customers> SelectedCustomer(int CustomerId,int filialId);




    }
}
