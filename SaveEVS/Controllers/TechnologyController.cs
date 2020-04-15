using SaveEVS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SaveEVS.Controllers
{
    public class TechnologyController : Controller
    {
        // GET: Technology
        SaveEvsEntities db = new SaveEvsEntities();
        public ActionResult AllDetail()
        {
            return View(db.Technologies.ToList());
        }

        public ActionResult ViewDetail()
        {
            return View(db.Technologies.ToList());
        }


        // GET: Technology/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Technology/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Technology/Create
        [HttpPost]
        public ActionResult Create([Bind(Exclude = "id")] Technology tech)
        {

            if (!ModelState.IsValid)
                return View();
            db.Technologies.Add(tech);
            db.SaveChanges();
            //Response.Redirect("StudentAdmission",true);
            return RedirectToAction("AllDetail");
        }

        // GET: Technology/Edit/5
        public ActionResult Edit(int id)
        {
            var IdEdit = (from m in db.Technologies where m.id == id select m).First();
            return View(IdEdit);
        }

        // POST: Technology/Edit/5
        [HttpPost]
        public ActionResult Edit(Technology IdEdit)
        {
            var orignalRecord = (from m in db.Technologies where m.id == IdEdit.id select m).First();

            if (!ModelState.IsValid)
                return View(orignalRecord);
            db.Entry(orignalRecord).CurrentValues.SetValues(IdEdit);

            db.SaveChanges();
            return RedirectToAction("AllDetail");


        }

        // GET: Technology/Delete/5
        public ActionResult Delete(Technology IdDel)
        {
            var d = db.Technologies.Where(x => x.id == IdDel.id).FirstOrDefault();
            db.Technologies.Remove(d);
            db.SaveChanges();
            return RedirectToAction("AllDetail");

        }

        // POST: Technology/Delete/5
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
