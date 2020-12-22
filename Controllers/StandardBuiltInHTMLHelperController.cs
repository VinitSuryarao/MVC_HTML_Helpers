using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HTML_Helpers.Controllers
{
    public class StandardBuiltInHTMLHelperController : Controller
    {
        // GET: StandardBuiltInHTMLHelper
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            return View();
        }
    }
}