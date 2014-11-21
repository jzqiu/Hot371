using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Security;
using QJZ.Framework.Utility;

namespace WeiXin.Bll
{
    public class WeiXinBiz
    {
        #region 服务器验证
        /// <summary>
        /// 成为开发者的第一步，验证并相应服务器的数据
        /// </summary>
        public static void Auth()
        {
            string token = ConfigurationManager.AppSettings["WeixinToken"];//从配置文件获取Token
            if (string.IsNullOrEmpty(token))
            {
                Log4Helper.Write(string.Format("WeixinToken 配置项没有配置！"), LogMessageType.Error);
            }

            string echoString = HttpContext.Current.Request.QueryString["echoStr"];
            string signature = HttpContext.Current.Request.QueryString["signature"];
            string timestamp = HttpContext.Current.Request.QueryString["timestamp"];
            string nonce = HttpContext.Current.Request.QueryString["nonce"];

            if (CheckSignature(token, signature, timestamp, nonce))
            {
                if (!string.IsNullOrEmpty(echoString))
                {
                    HttpContext.Current.Response.Write(echoString);
                    HttpContext.Current.Response.End();
                }
            }
        }

        /// <summary>
        /// 验证微信签名
        /// </summary>
        private static bool CheckSignature(string token, string signature, string timestamp, string nonce)
        {
            //将token、timestamp、nonce三个参数进行字典序排序
            string[] ArrTmp = { token, timestamp, nonce };
            Array.Sort(ArrTmp);
            string tmpStr = string.Join("", ArrTmp);

            //将三个参数字符串拼接成一个字符串进行sha1加密
            tmpStr = FormsAuthentication.HashPasswordForStoringInConfigFile(tmpStr, "SHA1");
            tmpStr = tmpStr.ToLower();

            //开发者获得加密后的字符串可与signature对比，标识该请求来源于微信
            if (tmpStr == signature)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        #endregion

        //http://blog.csdn.net/babauyang/article/details/20616107

        /// <summary>
        /// 根据当前日期 判断Access_Token 是否超期  如果超期返回新的Access_Token   否则返回之前的Access_Token 
        /// </summary>
        /// <returns></returns>
        public static string IsExistAccess_Token()
        {
            string token = string.Empty;
            //读库
            //token
            DateTime lastTime = DateTime.Now;

            if (DateTime.Now > lastTime)
            {
                //重新获取
            }

            return token;
        }
    }
}
