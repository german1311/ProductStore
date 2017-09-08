using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProductStore.Repository.Interfaces;
using ProductStore.Repository.Models;

namespace ProductStore.Data.Memory
{
    public class CustomerRepository:ICustomerRespository
    {
        public IEnumerable<Customer> GetAll()
        {
            throw new NotImplementedException();
        }

        public Customer GetById(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Customer> GetByFilter(Func<Customer, IEnumerable<Customer>> func)
        {
            throw new NotImplementedException();
        }

        public bool Save(Customer model)
        {
            throw new NotImplementedException();
        }

        public bool Delete(Customer model)
        {
            throw new NotImplementedException();
        }

        public bool Update(Customer model)
        {
            throw new NotImplementedException();
        }
    }
}
