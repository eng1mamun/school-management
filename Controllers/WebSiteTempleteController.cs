using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SchoolManagementViewSite.Controllers
{
    public class WebSiteTempleteController : Controller
    {
        // GET: WebSiteTemplete
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Category()
        {
            return View("Category");
        }
        public ActionResult About()
        {
            return View("About");
        }

    }
}