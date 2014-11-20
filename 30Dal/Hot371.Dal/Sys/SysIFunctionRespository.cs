using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Hot371.Model;
using TCBase.Saker.Core.Persistence;

namespace Hot371.Dal.Sys
{
    /// <summary>
    /// 职能数据访问
    /// </summary>
    public class SysIFunctionRespository : Respository<SysIFunction>
    {
        public SysIFunctionRespository()
            :base(DBGlobal.Hot371.ToString())
        { }
    }
}
