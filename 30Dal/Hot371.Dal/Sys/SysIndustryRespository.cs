using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Hot371.Model;
using TCBase.Saker.Core.Persistence;

namespace Hot371.Dal.Sys
{
    /// <summary>
    /// 行业数据访问
    /// </summary>
    public class SysIndustryRespository : Respository<SysIndustry>
    {
        public SysIndustryRespository()
            :base(DBGlobal.Hot371.ToString())
        {}
    }
}
