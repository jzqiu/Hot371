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
    /// 职能业务逻辑
    /// </summary>
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

        /// <summary>
        /// 根据行业ID获取
        /// </summary>
        /// <param name="iId"></param>
        /// <returns></returns>
        public List<SysIFunction> GetByIndustryId(int iId = 0)
        {
            if (iId == 0)
            {
                return GetAll().ToList();
            }

            var all = GetAll();
            return all.Where(f => f.IId == iId).ToList();
        }

        /// <summary>
        /// 根据关键词获取，支持拼音
        /// </summary>
        /// <param name="keyWord"></param>
        /// <returns></returns>
        public List<SysIFunction> GetByKeyWord(string keyWord)
        {
            var all = GetAll();
            var result =
                all.Where(f => f.FName.Contains(keyWord) 
                    || f.QuanPin.Contains(keyWord) 
                    || f.PYShouZi.Contains(keyWord))
                    .Take(5)
                    .ToList();
            return result;
        }
    }
}
