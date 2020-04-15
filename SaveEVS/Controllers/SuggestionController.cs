using SaveEVS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SaveEVS.Controllers
{
    public class SuggestionController : Controller
    {
        // GET: Suggestion
        SaveEvsEntities db = new SaveEvsEntities();

        public ActionResult AllDetail()
        {
            return View(db.Suggestions.ToList());
        }


        public ActionResult ViewDetail()
        {
            return View(db.Suggestions.ToList());
        }


        // GET: Suggestion/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Suggestion/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Suggestion/Create
        [HttpPost]
        public ActionResult Create([Bind(Exclude = "id")] Suggestion tech)
        {

            if (!ModelState.IsValid)
                return View();
            db.Suggestions.Add(tech);
            db.SaveChanges();
            //Response.Redirect("StudentAdmission",true);
            return RedirectToAction("AllDetail");
        }

        // GET: Suggestion/Edit/5
        public ActionResult Edit(int id)
        {
            var IdEdit = (from m in db.Suggestions where m.id == id select m).First();
            return View(IdEdit);
        }

        // POST: Suggestion/Edit/5
        [HttpPost]
        public ActionResult Edit(Suggestion IdEdit)
        {
            var orignalRecord = (from m in db.Suggestions where m.id == IdEdit.id select m).First();

            if (!ModelState.IsValid)
                return View(orignalRecord);
            db.Entry(orignalRecord).CurrentValues.SetValues(IdEdit);

            db.SaveChanges();
            return RedirectToAction("AllDetail");

        }

        // GET: Suggestion/Delete/5
        public ActionResult Delete(Suggestion IdDel)
        {
            var d = db.Suggestions.Where(x => x.id == IdDel.id).FirstOrDefault();
            db.Suggestions.Remove(d);
            db.SaveChanges();
            return RedirectToAction("AllDetail");
            
        }

        // POST: Suggestion/Delete/5
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
