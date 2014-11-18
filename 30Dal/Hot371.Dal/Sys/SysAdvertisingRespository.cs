using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Hot371.Model;
using TCBase.Saker.Core.Persistence;

namespace Hot371.Dal.Sys
{
    public class SysAdvertisingRespository : Respository<SysAdvertising>
    {
        public SysAdvertisingRespository()
            :base(DBGlobal.Hot371.ToString())
        { }
    }
}
