using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Hot371.Dal.Sys;
using Hot371.Model;
using QJZ.Framework.Utility;

namespace Hot371.Bll.Sys
{
    public class SysAdvertisingBiz
    {
        /// <summary>
        /// 缓存key
        /// </summary>
        private const string CacheKey = "Hot371.Advertising";

        private readonly SysAdvertisingRespository _respository;

        public SysAdvertisingBiz()
        {
            this._respository = new SysAdvertisingRespository();
        }

        /// <summary>
        /// 获取全部放缓存 1小时
        /// </summary>
        /// <returns></returns>
        private IEnumerable<SysAdvertising> GetAll()
        {
            var cache = Caching.Get(CacheKey) as IEnumerable<SysAdvertising>;
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

        public List<SysAdvertising> GetCityAdvertising(int cityId)
        {
            var cities = new List<int?> {0, cityId};
            var all = GetAll();
            var advs = all.Where(a => cities.Contains(a.CityId)).ToList();
            return advs;
        }
    }
}
