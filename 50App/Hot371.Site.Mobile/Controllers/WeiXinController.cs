using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Web;
using System.Web.Mvc;
using Hot371.Bll.Ent;
using Hot371.Model;
using Newtonsoft.Json;
using QJZ.Framework.Utility;
using WeiXin.Bll;

namespace Hot371.Site.Mobile.Controllers
{
    public class WeiXinController : Controller
    {
        /// <summary>
        /// cookie key
        /// </summary>
        private const string CookieKeyOpenId = "Hot371.Cookie.OpenId";

        public ActionResult Oauth2(string code = "", int state = 0, string reurl="")
        {
            if (string.IsNullOrEmpty(code))
            {
                //授权失败
                return RedirectToAction("Register", "Enterprise");
            }

            var user = WeiXinBiz.GetUserInfo(code);
            if (user != null)
            {
                HttpCookie cookie = new HttpCookie(CookieKeyOpenId, user.openid);
                cookie.Expires = DateTime.Now.AddMonths(1);
                Cookie.Save(cookie);
                //企业
                if (reurl.ToLower().Contains("enterprise"))
                {
                    var biz = new EWeiXinBiz();
                    int? eId = biz.GetEnterpriseId(user.openid);
                    if (eId != null)
                    {
                        //已存在，跳企业首页
                        return RedirectToAction("Index", "Enterprise", new {entId = eId});
                    }

                    //不存在，转注册
                    var eWeiXin = new EWeiXin
                    {
                        OpenId = user.openid,
                        NikeName = user.nickname,
                        HeadUrl = user.headimgurl
                    };
                    biz.Insert(eWeiXin);
                    return RedirectToAction("Register", "Enterprise");
                }
                //应聘者
            }

            return RedirectToAction("Index", "Home");
        }
    }
}
