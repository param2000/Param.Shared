using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Param.Shared.Core;
using Param.Shared.Web.Models;

namespace Param.Shared.Web.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Message = "Modify this template to jump-start your ASP.NET MVC application.";
            var app = new Application { FirstName = "param",LastName = "Singh" ,City = "Olathe" };
            var validator = new RequireForCompletnessValidator(app);
            ViewData["validator"] = validator;
            ViewData["application"] = app;
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your app description page.";

            return View();
        }


        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}
