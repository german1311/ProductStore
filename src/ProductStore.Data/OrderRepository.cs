using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProductStore.Repository.Interfaces;
using ProductStore.Repository.Models;

namespace ProductStore.Data.Memory
{
    public class OrderRepository : IOrderReposiroty
    {
        public IEnumerable<Order> GetAll()
        {
            throw new NotImplementedException();
        }

        public Order GetById(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Order> GetByFilter(Func<Order, IEnumerable<Order>> func)
        {
            throw new NotImplementedException();
        }

        public bool Save(Order model)
        {
            throw new NotImplementedException();
        }

        public bool Delete(Order model)
        {
            throw new NotImplementedException();
        }

        public bool Update(Order model)
        {
            throw new NotImplementedException();
        }
    }
}
