using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Helpers;
using System.Web.Mvc;

namespace AngularForFun.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Message = "Modify this template to jump-start your ASP.NET MVC application.";

            return View();
        }
         






        [HttpPost]
        public JsonResult GetAngularRequest()
        {
            var result = new List<object>();
            result.Add(new   { title = "shoes2", quantity="2",price="1.2" });
            result.Add(new  { title = "shoes3", quantity="3", price="1.3" });
            result.Add(new { title = "shoes4", quantity = "1", price = "1.1" });
           
           

            return Json(result, JsonRequestBehavior.AllowGet);

        }



    }
}
