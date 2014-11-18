using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Hot371.Dal.Sys;
using Hot371.Model;
using QJZ.Framework.Utility;

namespace Hot371.Bll.Sys
{
    public class SysIFunctionBiz
    {
        /// <summary>
        /// 缓存key
        /// </summary>
        private const string CacheKey = "Hot371.IFunction";

        private readonly SysIFunctionRespository _respository;

        public SysIFunctionBiz()
        {
            this._respository = new SysIFunctionRespository();
        }

        /// <summary>
        /// 获取全部放缓存 1小时
        /// </summary>
        /// <returns></returns>
        public IEnumerable<SysIFunction> GetAll()
        {
            var cache = Caching.Get(CacheKey) as IEnumerable<SysIFunction>;
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
    }
}
