using Appstore.DataSqlite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Appstore.Models;
using Appstore.DataSqlite;

namespace Appstore.Controllers
{
    public class ApplicationsController : Controller
    {
        AppstoreContext db = new AppstoreContext();
        
        // GET: Applications
        public ActionResult NewApp()
        {
            
            return View();
        }
        //post
        [HttpPost]
        public ActionResult NewApp(App app)
        {
            try
            {
                app.PublishDate = DateTime.Now;
                db.Apps.Add(app);
                db.SaveChanges();
                return RedirectToAction("Apps", "Appstore");
            }
            catch
            {
                return View();
            }
        }
        // GET: Publishers/Edit/5
        public ActionResult AppDetails(int id)
        {
            return View(db.Apps.First(x => x.Id == id));
        }

        // POST: Publishers/Edit/5
        [HttpPost]
        public ActionResult AppDetails(int id, App app)
        {
            try
            {
                App d = db.Apps.First(x => x.Id == id);
                d.Name = app.Name;
                d.Description = app.Description;
                d.Price = app.Price;
                d.Downloads = app.Downloads;
                d.ImagePath = app.ImagePath;
                d.Dev = app.Dev;
                d.PublishDate = app.PublishDate;

                db.SaveChanges();
                return RedirectToAction("Apps", "Appstore");
            }
            catch
            {
                return View();
            }
        }
        public ActionResult EditApp(int id)
        {
            return View(db.Apps.First(x => x.Id == id));
        }

        [HttpPost]
        public ActionResult EditApp(int id, App app)
        {
            try
            {
                App d = db.Apps.First(x => x.Id == id);
                d.Name = app.Name;
                d.Description = app.Description;
                d.Price = app.Price;
                d.Downloads = app.Downloads;
                d.ImagePath = app.ImagePath;
                d.Dev = app.Dev;
                d.Reviews = app.Reviews;
                db.SaveChanges();
                return RedirectToAction("Apps", "Appstore");
            }
            catch
            {
                return View();
            }
        }
        public ActionResult DeleteApp(int id)
        {
            return View(db.Apps.First(x => x.Id == id));
        }
        
        [HttpPost]
        public ActionResult DeleteApp(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here
                var app = db.Apps.First(x => x.Id == id);
                db.Apps.Remove(app);
                db.SaveChanges();
                return RedirectToAction("Apps", "Appstore");
            }
            catch
            {
                return View();
            }
        }

    }
}