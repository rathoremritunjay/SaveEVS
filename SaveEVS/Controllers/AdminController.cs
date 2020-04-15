using SaveEVS.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SaveEVS.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin
        public ActionResult Admin_Login()
        {
            return View();
        }

        public ActionResult WrongLogin()
        {
            return View();
        }

        public ActionResult RightLogin()
        {
            return View();
        }


        public ActionResult Admin(Admin adm)
        {
            DataTable tbl = new DataTable();
            tbl = adm.srchRecord("select * from Admin_Table where Name='"+adm.txtEmail+ "' and Password='" + adm.txtPassword+"'");
            if (tbl.Rows.Count>0) {
                return RedirectToAction("RightLogin");
            }
            else {
                return RedirectToAction("WrongLogin");
            }
        }
    }
}