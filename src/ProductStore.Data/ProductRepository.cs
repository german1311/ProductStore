using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProductStore.Repository.Interfaces;
using ProductStore.Repository.Models;

namespace ProductStore.Data.Memory
{
    public class ProductRepository : IProductRepository
    {
        private static List<Product> _productDataBase = new List<Product>();

        public IEnumerable<Product> GetAll()
        {
            return _productDataBase;
        }

        public Product GetById(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Product> GetByFilter(Func<Product, IEnumerable<Product>> func)
        {
            throw new NotImplementedException();
        }

        public bool Save(Product model)
        {
            var newId = GetAll().Count() + 1;
            model.Id = newId;
            _productDataBase.Add(model);

            return true;
        }

        public bool Delete(Product model)
        {
            throw new NotImplementedException();
        }

        public bool Update(Product model)
        {
            throw new NotImplementedException();
        }
    }
}
