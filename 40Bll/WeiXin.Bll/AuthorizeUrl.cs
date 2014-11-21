using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WeiXin.Bll
{
    public class AuthorizeUrl
    {
        private const string WeixinOpenid = "https://open.weixin.qq.com/connect/oauth2/authorize?appid=wx3827070276e49e30&redirect_uri={0}&response_type=code&scope=snsapi_base&state=123#wechat_redirect";

        private const string WeixinUserinfo = "https://open.weixin.qq.com/connect/oauth2/authorize?appid=wx3827070276e49e30&redirect_uri={0}&response_type=code&scope=snsapi_userinfo&state=123#wechat_redirect";

        private const string AccessToken =
            "https://api.weixin.qq.com/cgi-bin/token?grant_type=client_credential&appid={0}&secret={1}";

        public static string GetOpenIdUrl(string redirectUrl)
        {
            return string.Format(WeixinOpenid, redirectUrl);
        }

        public static string GetUserInfoUrl(string redirectUrl)
        {
            return string.Format(WeixinUserinfo, redirectUrl);
        }
    }
}
