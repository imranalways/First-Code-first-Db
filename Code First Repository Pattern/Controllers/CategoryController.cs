using Code_First_Repository_Pattern.Models;
using Code_First_Repository_Pattern.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Code_First_Repository_Pattern.Controllers
{
    public class CategoryController : Controller
    {
        CategoryRepository catrepo = new CategoryRepository();
        // GET: Category
        public ActionResult Index()
        {
            
            return View(catrepo.GetAll());
        }
        [HttpGet]
       public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Category cat)
        {
            catrepo.Insert(cat);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult GoToProducts()
        {
            return RedirectToAction("Index", "Product");
        }
    }
}