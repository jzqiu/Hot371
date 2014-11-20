using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Hot371.Dal.Sys;
using Hot371.Model;
using QJZ.Framework.Utility;

namespace Hot371.Bll.Sys
{
    /// <summary>
    /// 系统参数业务逻辑
    /// </summary>
    public class SysParametersBiz
    {
        /// <summary>
        /// 缓存key
        /// </summary>
        private const string CacheKey = "Hot371.AllParameters";

        private readonly SysParametersRespository _respository;

        public SysParametersBiz()
        {
            this._respository=new SysParametersRespository();
        }

        /// <summary>
        /// 获取全部放缓存 1小时
        /// </summary>
        /// <returns></returns>
        public IEnumerable<SysParameters> GetAll()
        {
            var cache = Caching.Get(CacheKey) as IEnumerable<SysParameters>;
            if (cache != null)
            {
                return cache;
            }

            var all = _respository.GetAll();
            try
            {
                Caching.Set(CacheKey, all, 60);
            }
            catch (Exception)
            {
            }
            return all;
        }

        /// <summary>
        /// 根据分组获取
        /// </summary>
        /// <param name="gId"></param>
        /// <returns></returns>
        public List<SysParameters> GetByGroup(int gId)
        {
            var all = GetAll();
            var paras = all.Where(p => p.GroupId == gId).ToList();
            return paras;
        }
    }
}
