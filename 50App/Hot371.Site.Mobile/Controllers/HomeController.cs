using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Hot371.Bll.Sys;
using Hot371.ViewModel;
using WeiXin.Bll;

namespace Hot371.Site.Mobile.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {
            //var url = AuthorizeUrl.GetOpenIdUrl(@"http://wx.17u.cn/flight/getopenid.html?url=http://10.1.201.8/test/Enterprise/index?ok=1");
            //return Redirect(url);
            //var content = @"<a href='http://m.ly.com'></a>";
            //var msg = new WeiXinMsg
            //{
            //    touser = "oOCyauCadvJ8JVO0cLPjWB-UMEv8",
            //    msgtype = MsgType.text.ToString(),
            //    text = new MsgContent {content = content}
            //};
            //WeiXinBiz.SendMsg(msg);
            //var test = new SysAreaBiz().GetAreaByLevel(1);
            //var test2 = new SysAreaBiz().GetAreaByParent(320500);
            return View();
        }
    }
}
