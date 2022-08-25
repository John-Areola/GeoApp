using GeoApp.Models.DB_Model;
using GeoApp.Models.View_Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GeoApp.Controllers
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

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Register()
        {

            return View();
        }

        public ActionResult Register(Customers newcustomer)
        {
            try
            {
                var db = new Model1();
                var cust = new Customers();
                cust.firstName = newcustomer.firstName;
                cust.lastName = newcustomer.lastName;
                cust.DOB = newcustomer.DOB;
                db.SaveChanges();
            return View();
            }
            catch (Exception Ex)
            {
                ViewBag.ErrorMessage = "An Error Occured during Registration";
                return View();
            }
        }
        
    }
}