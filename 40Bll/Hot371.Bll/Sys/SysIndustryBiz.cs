using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Hot371.Dal.Sys;
using Hot371.Model;
using Hot371.ViewModel;
using QJZ.Framework.Utility;

namespace Hot371.Bll.Sys
{
    public class SysIndustryBiz
    {
        /// <summary>
        /// 缓存key
        /// </summary>
        private const string CacheKey = "Hot371.AllIndustry";

        private readonly SysIndustryRespository _respository;

        public SysIndustryBiz()
        {
            this._respository=new SysIndustryRespository();
        }

        /// <summary>
        /// 获取全部放缓存 1小时
        /// </summary>
        /// <returns></returns>
        public IEnumerable<SysIndustry> GetAll()
        {
            var cache = Caching.Get(CacheKey) as IEnumerable<SysIndustry>;
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
        /// 获取行业及其职能
        /// </summary>
        /// <returns></returns>
        public List<IndustryFunctionsVM> GetIndustryFunctions()
        {
            var industries = GetAll();
            var funcBiz = new SysIFunctionBiz();
            var functions = funcBiz.GetAll();
            var result = from r in industries
                orderby r.Sort
                select new IndustryFunctionsVM
                {
                    IId = r.IId,
                    IName = r.IName,
                    ImgUrl = r.ImgUrl,
                    Functions = from f in functions
                        where f.IId == r.IId
                        orderby f.Sort
                        select f
                };
            return result.ToList();
        }
    }
}
