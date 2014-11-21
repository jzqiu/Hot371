using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Web;
using WeiXin.Bll;

namespace Hot371.Site.Mobile
{
    /// <summary>
    /// 微信接口。统一接收并处理信息的入口。
    /// </summary>
    public class WXApi : IHttpHandler
    {
        public void ProcessRequest(HttpContext context)
        {
            string postString = string.Empty;
            if (HttpContext.Current.Request.HttpMethod.ToUpper() == "POST")
            {
                using (Stream stream = HttpContext.Current.Request.InputStream)
                {
                    Byte[] postBytes = new Byte[stream.Length];
                    stream.Read(postBytes, 0, (Int32)stream.Length);
                    postString = Encoding.UTF8.GetString(postBytes);
                }

                if (!string.IsNullOrEmpty(postString))
                {
                    //处理各种请求信息并应答
                    //Execute(postString);
                }
            }
            else
            {
                WeiXinBiz.Auth(); //微信接入的测试
            }
        }

        

        public bool IsReusable
        {
            get
            {
                return false;
            }
        }
    }
}