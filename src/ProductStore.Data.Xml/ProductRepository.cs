using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using ProductStore.Repository.Interfaces;
using ProductStore.Repository.Models;

namespace ProductStore.Data.Xml
{
    public class ProductRepository : IProductRepository
    {
        //todo: move to constructor or find a way to inject
        private static readonly string file = ConfigurationManager.AppSettings["XmlFilePlace"];

        private static List<Product> _productDataBase = new List<Product>();

        public IEnumerable<Product> GetAll()
        {
            if (!_productDataBase.Any())
                _productDataBase = FileUtils<List<Product>>.DeserializeFromXML(file) ?? new List<Product>();

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
            try
            {
                _productDataBase.Add(model);

                FileUtils<List<Product>>.SerializeToXML(_productDataBase, file);
                return true;
            }
            catch (Exception ex)
            {
                //todo: should be logged
                Console.WriteLine(ex);
                return false;
            }

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
