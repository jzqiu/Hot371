using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Hot371.Model;
using TCBase.Saker.Core.Persistence;

namespace Hot371.Dal.Ent
{
    /// <summary>
    /// 企业数据访问
    /// </summary>
    public class EnterpriseRespository : Respository<Enterprise>
    {
        public EnterpriseRespository()
            :base(DBGlobal.Hot371.ToString())
        { }

        /// <summary>
        /// 名企数据
        /// </summary>
        /// <returns></returns>
        public IEnumerable<Enterprise> GetFamousEnt()
        {
            var sql = string.Format(@"SELECT EId,EName,LogoUrl,FamousSort,CityId
                        FROM [Enterprise]
                        WHERE Status=50 AND IsFamous=1");

            return base.GetList(sql);
        }
    }
}
