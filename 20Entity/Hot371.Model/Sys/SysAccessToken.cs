using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hot371.Model.Sys
{
    public class SysAccessToken
    {
        public int TId
        {
            set;
            get;
        }

        public string access_token
        {
            set;
            get;
        }

        public int expires_in
        {
            set;
            get;
        }
    }
}
