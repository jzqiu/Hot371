using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TCBase.Component.QRCode;

namespace Hot371.Site.Enterprise.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {
            //var stream = QRCodeGenerate.BuildQrCode(@"http://m.ly.com", QrCodeLevel.H);
            //return File(stream, @"image/jpeg");
            return View();
        }

    }
}
