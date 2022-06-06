using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FirstMVCApp.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Sponser()
        {
            return View();
        }

        public ActionResult Content()
        {
            return View();
        }

        public ActionResult Products()
        {
            return View();
        }

        //public string Find(string country,string state)
        //{
        //    return ("Country : " + country + " " + "State : " + state);
        //}

        public ActionResult Find(String Country, String State)
        {
            string result = "Country :- " + Country + "State :- " + State;
            return Content(result);

        }
    }
}