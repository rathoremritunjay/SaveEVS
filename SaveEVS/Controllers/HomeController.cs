using SaveEVS.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SaveEVS.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Project()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }


        public ActionResult History()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult FeedBack()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }


        //Conn Instance Object of SQl Connection Class
        SqlConnection sqlCon;
        //String ConnectionString for Making the Connection between the Class and Database
        String conStr = "Data Source=DESKTOP-HKD1BEO\\SQLEXPRESS;Initial Catalog=SaveEvs;Integrated Security=True";
        //Cmd Instance Object to Create the Relation between  the Commad to execute the sql Command 
        SqlCommand sqlcmd;
        // DReader is instance to read the data from the database and pass to the Class
        SqlDataReader DReader;


        public void InsertRecord(String query)
        {
            sqlCon = new SqlConnection(conStr);
            sqlCon.Open();
            sqlcmd = new SqlCommand(query, sqlCon);
            sqlcmd.ExecuteNonQuery();
            sqlCon.Close();
        }


        public ActionResult feed_Back(Feedback fb)
        {
            InsertRecord("insert into Feed_Back_Table(Name,Email,Message) values ('"+fb.txtName+"','"+fb.txtEmail+"','"+fb.txtMessage+"')");

            return RedirectToAction("Next");
        }

        public ActionResult Next()
        {
            return View();
        }


        }
    }