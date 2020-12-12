using Code_First_Repository_Pattern.Models;
using Code_First_Repository_Pattern.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Code_First_Repository_Pattern.Controllers
{
    public class ProductController : Controller
    {
        ProductRepository prodrepo = new ProductRepository();
        CategoryRepository catrepo = new CategoryRepository();
        public ActionResult Index()
        {
            ViewData["cat"] = catrepo.GetAll().ToList();
            return View(prodrepo.GetAll());
        }

        [HttpGet]
        public ActionResult Create()
        {
            ViewData["cat"] = catrepo.GetAll().ToList();
            return View();
        }

        [HttpPost]
        public ActionResult Create(Product prod)
        {

            prodrepo.Insert(prod);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult GoTocategories()
        {
            return RedirectToAction("Index", "Category");
        }
    }
}