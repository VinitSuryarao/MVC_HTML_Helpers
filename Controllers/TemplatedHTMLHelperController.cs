using HTML_Helpers.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HTML_Helpers.Controllers
{
    public class TemplatedHTMLHelperController : Controller
    {
        // GET: TemplatedHTMLHelper
        public ActionResult Index()
        {
            ClientModel clientObj = new ClientModel
            {
                Name = "Vinit Suryarao",
                City = "Navi Mumbai",
                Married = false
            };

            return View(clientObj);
        }
    }
}