using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Hot371.Bll.Sys;

namespace Hot371.Site.Mobile.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {
            var test = new SysAreaBiz().GetAreaByLevel(1);
            var test2 = new SysAreaBiz().GetAreaByParent(320500);
            return View();
        }

    }
}
