using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Hot371.Dal.Ent;

namespace Hot371.Bll.Ent
{
    public class EWeiXinBiz
    {
        private readonly EWeiXinRespository _respository;

        public EWeiXinBiz()
        {
            this._respository=new EWeiXinRespository();
        }

        public int? GetEnterpriseId(string openId)
        {
            var enterprises = _respository.QueryEId(openId);
            if (enterprises != null && enterprises.Any())
            {
                return enterprises.First().EId;
            }

            return null;
        }
    }
}
