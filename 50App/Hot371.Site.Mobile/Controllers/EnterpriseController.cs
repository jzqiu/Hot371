using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Hot371.Bll.Ent;
using Hot371.Model;
using QJZ.Framework.Utility;
using QJZ.Framework.Web;
using WeiXin.Bll;

namespace Hot371.Site.Mobile.Controllers
{
    public class EnterpriseController : BaseController
    {
        /// <summary>
        /// cookie key
        /// </summary>
        private const string CookieKeyOpenId = "Hot371.Cookie.OpenId";

        private const string RegisterUrl = @"http://www.371hot.com/Enterprise/Register";

        /// <summary>
        /// 中转
        /// </summary>
        /// <returns></returns>
        public ActionResult Redirect()
        {
            string openId = Cookie.GetValue(CookieKeyOpenId);
            //授权获取
            string url = AuthorizeUrl.GetOauth2UserInfoUrl(RegisterUrl);
            if (string.IsNullOrEmpty(openId))
            {
                return Redirect(url);
            }

            var biz = new EWeiXinBiz();
            int? eId = biz.GetEnterpriseId(openId);
            if (eId == null)
            {
                //不存在记录
                return Redirect(url);
            }
            else if (eId==0)
            {
                //存在，但无关联企业
                return RedirectToAction("Register");
            }

            return RedirectToAction("Index", new {eId});
        }

        public ActionResult Index(int? eId)
        {
            

            //var url = Request.Url;
            //ViewBag.Url = url;
            return View();
        }
        //企业名称  直招    服务外包
        //  所在城市： 市    区   
        //  所在地址：
        //  行业：下拉框     规模：   人
        //  联系人： 
        //  联系电话：           
        //  上传营业执照（需要调用手机拍照及手机照片库）（第二次完善需要）
        //  企业简介：（文本形式，第二次完善需要）
        //  企业LOGO上传（调用手机拍

        public ActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public JsonResult Register(Enterprise enterprise)
        {
            var eId = new EnterpriseBiz().Register(enterprise);
            if (eId > 0)
            {
                string openId = Cookie.GetValue(CookieKeyOpenId);
                if (string.IsNullOrEmpty(openId))
                {
                    //关联
                    new EWeiXinBiz().Bind(openId, eId);
                }
            }
            else
            {
                return Json(new { State = 300 });
            }

            return Json(new { State = 200 });
        }

        public ActionResult ImageUpload(string fileStream)
        {
            var base64 = fileStream.Split(',')[1];
            byte[] file = Convert.FromBase64String(base64);
            var imgUrl = Path.Combine("~/Upload", "Ent", DateTime.Now.ToString("yyyyMM"));
            var uploadPath = HttpContext.Server.MapPath(imgUrl);
            if (!Directory.Exists(uploadPath))
            {
                Directory.CreateDirectory(uploadPath);
            }

            var imgName = string.Format("{0}{1}.{2}", DateTime.Now.ToString("ddhhmmss"),
                new Random(DateTime.Now.Millisecond).Next(10000), "jpg");
            var filePath = Path.Combine(uploadPath, imgName);
            
            using (var fs = new FileStream(filePath, FileMode.Create, FileAccess.Write))
            {
                fs.Write(file, 0, file.Length);
                fs.Flush();
                fs.Close();
            }

            var result = new
            {
                State = 200,
                ImgUrl = Path.Combine(imgUrl, imgName)
            };
            return Json(result);
        }
    }
}
