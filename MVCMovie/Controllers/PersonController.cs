using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCMovie.Controllers
{
    public class PersonController : Controller
    {
        // GET: Person
        #region Views

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult List()
        {

            ViewBag.Title = "List of People";
            ViewBag.Message = "Please, don't slepp!";
            return View();
        }

        public ActionResult Insert()
        {
            return View();
        }

        public ActionResult Update()
        {
            return View();
        }

        #endregion

        public string GetFullName(string firstname, string lastname)
        {
            return string.Concat(firstname, " ", lastname);
        }


    }
}