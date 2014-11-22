using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Hot371.Dal.Ent;
using Hot371.Model;

namespace Hot371.Bll.Ent
{
    /// <summary>
    /// 企业微信业务逻辑
    /// </summary>
    public class EWeiXinBiz
    {
        private readonly EWeiXinRespository _respository;

        public EWeiXinBiz()
        {
            this._respository=new EWeiXinRespository();
        }

        /// <summary>
        /// 根据openid获取企业id
        /// </summary>
        /// <param name="openId"></param>
        /// <returns></returns>
        public int? GetEnterpriseId(string openId)
        {
            var enterprises = _respository.QueryEId(openId);
            if (enterprises != null && enterprises.Any())
            {
                return enterprises.First().EId;
            }

            return null;
        }

        /// <summary>
        /// 新增一企业微信
        /// </summary>
        /// <param name="eWeiXin"></param>
        public void Add(EWeiXin eWeiXin)
        {
            _respository.Add(eWeiXin);
        }

        /// <summary>
        /// 将微信绑到对应企业
        /// </summary>
        /// <param name="openId"></param>
        /// <param name="eId"></param>
        public void Bind(string openId, int eId)
        {
            _respository.UpdateEId(openId, eId);
        }
    }
}
