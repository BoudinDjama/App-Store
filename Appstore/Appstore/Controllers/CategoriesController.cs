using Appstore.DataSqlite;
using Appstore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Appstore.Controllers
{
    public class CategoriesController : Controller
    {
        AppstoreContext db = new AppstoreContext();
        // GET: Categories

        public ActionResult Index()
        {
            return View(); 
        }

        // GET: Categories/Details/5
        public ActionResult Details(int id)
        {
            return View(db.Categories.First(x => x.Id == id));
        }

        // GET: Categories/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Categories/Create
        [HttpPost]
        public ActionResult Create(Category category)
        {
            try
            {
                // TODO: Add insert logic here
                db.Categories.Add(category);
                db.SaveChanges();
                return RedirectToAction("CategoryView", "Appstore");
            }
            catch
            {
                return View();
            }
        }

        // GET: Categories/Edit/5
        public ActionResult Edit(int id)
        {
            return View(db.Categories.First(x => x.Id == id));
        }

        // POST: Categories/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, Category category)
        {
            try
            {
                // TODO: Add update logic here
                Category d = db.Categories.First(x => x.Id == id);
                d.Name = category.Name;
                d.Description = category.Description;
                db.SaveChanges();
                return RedirectToAction("CategoryView", "Appstore");
            }
            catch
            {
                return View();
            }
        }

        // GET: Categories/Delete/5
        public ActionResult Delete(int id)
        {
            return View(db.Categories.First(x => x.Id == id));
        }

        // POST: Categories/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here
                var cat = db.Categories.First(x => x.Id == id);
                db.Categories.Remove(cat);
                db.SaveChanges();
                return RedirectToAction("CategoryView", "Appstore");
            }
            catch
            {
                return View();
            }
        }
    }
}