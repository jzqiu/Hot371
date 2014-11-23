using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Hot371.Bll.Ent;
using Hot371.Bll.Sys;
using Hot371.ViewModel;

namespace Hot371.Bll
{
    /// <summary>
    /// 首页业务逻辑
    /// </summary>
    public class HomeBiz
    {
        /// <summary>
        /// 手机站首页
        /// </summary>
        /// <param name="cityId">城市</param>
        /// <returns></returns>
        public MobileHomeVM GetMobileHome(int cityId=0)
        {
            var list = new MobileHomeVM();
            list.Advertisings = new SysAdvertisingBiz().GetCityAdvertising(cityId);
            list.Industries = new SysIndustryBiz().GetIndustryFunctions();
            list.FamousEnts = new EnterpriseBiz().GetCityFamousEnt(cityId);

            return list;
        }
    }
}
