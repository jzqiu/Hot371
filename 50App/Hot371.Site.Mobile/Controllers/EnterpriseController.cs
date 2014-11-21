using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Hot371.Bll.Ent;
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
            if (string.IsNullOrEmpty(openId))
            {
                //重新授权获取
                string url = AuthorizeUrl.GetUserInfoUrl(RegisterUrl);
                return Redirect(url);
            }

            var biz = new EWeiXinBiz();
            int? eId = biz.GetEnterpriseId(openId);
            if (eId == null)
            {
                //重新授权获取
                string url = AuthorizeUrl.GetUserInfoUrl(RegisterUrl);
                return Redirect(url);
            }

            return RedirectToAction("Index", new {entId = eId});
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


    }
}
