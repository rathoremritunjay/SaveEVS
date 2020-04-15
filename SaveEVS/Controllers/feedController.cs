using SaveEVS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SaveEVS.Controllers
{
    public class feedController : Controller
    {
        SaveEvsEntities db = new SaveEvsEntities();
        // GET: feed
        public ActionResult AllDetail()
        {
            return View(db.Feed_Back_Table.ToList());
        }

        // GET: feed/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: feed/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: feed/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: feed/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: feed/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: feed/Delete/5
        public ActionResult Delete(Feed_Back_Table IdDel)
        {

            var d = db.Feed_Back_Table.Where(x => x.id == IdDel.id).FirstOrDefault();
            db.Feed_Back_Table.Remove(d);
            db.SaveChanges();
            return RedirectToAction("AllDetail");
        }

        // POST: feed/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
