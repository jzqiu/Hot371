using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Hot371.Model;
using TCBase.Saker.Core.Persistence;

namespace Hot371.Dal.Ent
{
    public class EWeiXinRespository : Respository<EWeiXin>
    {
        public IEnumerable<EWeiXin> QueryEId(string openId)
        {
            string sql = string.Format(@"SELECT [EId]
                                FROM [EWeiXin]
                                where [OpenId]='{0}'", openId);
            return base.GetList(sql);
        }
    }
}
