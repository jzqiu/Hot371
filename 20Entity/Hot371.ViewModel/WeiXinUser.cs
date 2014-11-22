using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hot371.ViewModel
{
    public class WeiXinUser
    {
        public string openid { get; set; }
        public string nickname { get; set; }
        public string sex { get; set; }
        public string province { get; set; }
        public string city { get; set; }
        public string headimgurl { get; set; }

        public int errcode { get; set; }
        public string errmsg { get; set; }
    }
}
