using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WeiXin.Bll
{
    public class AuthorizeUrl
    {
        private const string WeixinOpenid = "https://open.weixin.qq.com/connect/oauth2/authorize?appid={1}&redirect_uri={0}&response_type=code&scope=snsapi_base&state=123#wechat_redirect";

        private const string WeixinUserinfo = "https://open.weixin.qq.com/connect/oauth2/authorize?appid={1}&redirect_uri={0}&response_type=code&scope=snsapi_userinfo&state=123#wechat_redirect";

        private const string AccessToken =
            "https://api.weixin.qq.com/cgi-bin/token?grant_type=client_credential&appid={0}&secret={1}";

        private const string MsgSend = "https://api.weixin.qq.com/cgi-bin/message/custom/send?access_token={0}";

        public static string GetOpenIdUrl(string redirectUrl)
        {
            return string.Format(WeixinOpenid, redirectUrl, "wx3827070276e49e30");
        }

        public static string GetUserInfoUrl(string redirectUrl)
        {
            return string.Format(WeixinUserinfo, redirectUrl, "wx3827070276e49e30");
        }

        public static string GetTokenUrl()
        {
            return string.Format(AccessToken, "wx043225275885dafd", "cb4425b24ab79ef875029cf0bf326ae9");
        }

        public static string GetMsgSendUrl(string token)
        {
            return string.Format(MsgSend, token);
        }
    }
}
