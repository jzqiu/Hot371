using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Web;
using System.Web.Mvc;
using Hot371.Bll.Ent;
using Hot371.Model;
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
                return Redirect(reurl);
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
                    //再次查询
                    var biz = new EWeiXinBiz();
                    int? eId = biz.GetEnterpriseId(user.openid);
                    if (eId > 0)
                    {
                        //已存在并关联，跳企业首页
                        return RedirectToAction("Index", "Enterprise", new {entId = eId});
                    }
                    if (eId == null)
                    {
                        //不存在
                        var eWeiXin = new EWeiXin
                        {
                            EId = 0, //未关联
                            OpenId = user.openid,
                            NikeName = user.nickname,
                            HeadUrl = user.headimgurl
                        };
                        biz.Add(eWeiXin);
                    }
                    //转注册
                    return RedirectToAction("Register", "Enterprise");
                }
                //应聘者
            }

            return RedirectToAction("Index", "Home");
        }
    }
}
