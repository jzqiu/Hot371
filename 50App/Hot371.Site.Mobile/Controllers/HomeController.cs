﻿using System;
using System.Collections.Generic;
using System.IO;
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
            //var test = new SysAreaBiz().GetAreaByLevel(1);
            //var test2 = new SysAreaBiz().GetAreaByParent(320500);
            return View();
        }

        public ActionResult ImageUpload(string fileStream)
        {
            var base64 = fileStream.Split(',')[1];
            byte[] file = Convert.FromBase64String(base64);
            var uploadPath = HttpContext.Server.MapPath("~/" + "Upload");
            uploadPath = Path.Combine(uploadPath, "Ent");
            var filePath = Path.Combine(uploadPath,
                    string.Format("{0}{1}.{2}", DateTime.Now.ToString("yyyyMMddhhmmss"), new Random(DateTime.Now.Millisecond).Next(10000), "jpg")
                    );
            if (!Directory.Exists(uploadPath))
            {
                Directory.CreateDirectory(uploadPath);
            }
            using (var fs = new FileStream(filePath, FileMode.Create, FileAccess.Write))
            {
                fs.Write(file, 0, file.Length);
                fs.Flush();
                fs.Close();
            }

            var result = new
            {
                State = 200,
                ImgUrl = filePath
            };
            return Json(result);
        }

    }
}