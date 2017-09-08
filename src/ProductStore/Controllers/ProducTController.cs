using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ProductStore.Repository.Interfaces;
using ProductStore.Repository.Models;

namespace ProductStore.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductRepository _productRepository;

        public ProductController(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        // GET: Produc
        public ActionResult Index()
        {
            var model = _productRepository.GetAll();

            if(model == null)
                model = new List<Product>();

            return View(model);
        }

        public ActionResult New()
        {
            return View();
        }

        [HttpPost]
        public ActionResult New(Product model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            _productRepository.Save(model);
            return RedirectToAction("Index");
        }

        public ActionResult Delete(int id)
        {
            throw new NotImplementedException();
        }

        public ActionResult Edit(int id)
        {
            throw new NotImplementedException();
        }
    }
}