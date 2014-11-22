using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using Hot371.Dal.Ent;
using Hot371.Model;
using QJZ.Framework.Utility;

namespace Hot371.Bll.Ent
{
    /// <summary>
    /// 企业业务逻辑
    /// </summary>
    public class EnterpriseBiz
    {
        /// <summary>
        /// 缓存key
        /// </summary>
        private const string CacheKey = "Hot371.FamousEnt";

        private readonly EnterpriseRespository _respository;

        public EnterpriseBiz()
        {
            this._respository=new EnterpriseRespository();
        }

        /// <summary>
        /// 获取全部名企放缓存 1小时
        /// </summary>
        /// <returns></returns>
        private IEnumerable<Enterprise> GetFamousEnt()
        {
            var cache = Caching.Get(CacheKey) as IEnumerable<Enterprise>;
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
        /// 根据城市获取名企
        /// </summary>
        /// <param name="cityId"></param>
        /// <returns></returns>
        public List<Enterprise> GetCityFamousEnt(int cityId)
        {
            var ents = GetFamousEnt().OrderBy(e => e.FamousSort);
            if (cityId > 0)
            {
                return ents.Where(e => e.CityId == cityId).ToList();
            }

            return ents.ToList();
        }

        /// <summary>
        /// 根据ID获取企业
        /// </summary>
        /// <param name="eId"></param>
        /// <returns></returns>
        public Enterprise GetEnterpriseById(int eId)
        {
            return _respository.GetEntityById(eId);
        }

        /// <summary>
        /// 注册
        /// </summary>
        /// <param name="enterprise"></param>
        /// <returns></returns>
        public int Register(Enterprise enterprise)
        {
            enterprise.Status = 5;
            enterprise.PublishNumbers = int.Parse(ConfigurationManager.AppSettings["EnterprisePublishPositionNumbers"]);
            enterprise.DownloadNumbers = int.Parse(ConfigurationManager.AppSettings["CanDownloadNumbers"]);
            if (enterprise.ETypeId == 20)
            {
                //中介
                enterprise.ENumbers = int.Parse(ConfigurationManager.AppSettings["WeixinAppSecret"]);
            }
            return _respository.Add(enterprise);
        }
    }
}
