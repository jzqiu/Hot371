using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hot371.ViewModel
{
    public class WeiXinMsg
    {
        public string touser { get; set; }
        public string msgtype { get; set; }
        public MsgContent text { get; set; }
    }

    public enum MsgType
    {
        text
    }

    public class MsgContent
    {
        public string content { get; set; }
    }
}
