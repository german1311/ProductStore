using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using Autofac;
using ProductStore.Repository.Interfaces;
using ProductStore.Repository.Models;

namespace ProductStore.Controllers
{
    public class ProductController : BaseController
    {
        private IProductRepository _productRepository;
        private readonly IComponentContext _icoContext;

        public ProductController(IProductRepository productRepository, IComponentContext icoContext)
        {
            _productRepository = productRepository;
            _icoContext = icoContext;
        }

        // GET: Produc
        public ActionResult Index()
        {
            _productRepository = _icoContext.ResolveNamed<IProductRepository>(SourceName);

            var model = _productRepository.GetAll();

            if (model == null)
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


            _productRepository = _icoContext.ResolveNamed<IProductRepository>(SourceName);

            if (_productRepository.GetAll().Any(p => p.Number == model.Number))
            {
                //todo: add in resource file
                ModelState.AddModelError("Number", "This number already exists!");
                return View(model);
            }

            _productRepository.Save(model);
            return RedirectToAction("Index");
        }

        public ActionResult Delete(int id)
        {
            //todo: implement
            throw new NotImplementedException();
        }

        public ActionResult Edit(int id)
        {
            //todo: implement
            throw new NotImplementedException();
        }

        public JsonResult Source(string source)
        {
            if (Request.IsAjaxRequest())
            {
                if (!string.IsNullOrEmpty(source))
                {
                    SourceName = source;
                    return Json(new
                    {
                        Url = HttpContext.Request.UrlReferrer.LocalPath
                    }, JsonRequestBehavior.AllowGet);
                }
            }

            return null;
        }
    }
}