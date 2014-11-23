using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Hot371.Model;

namespace Hot371.ViewModel
{
    public class MobileHomeVM
    {
        /// <summary>
        /// 头部广告
        /// </summary>
        public List<SysAdvertising> Advertisings;
        /// <summary>
        /// 行业
        /// </summary>
        public List<IndustryFunctionsVM> Industries;
        /// <summary>
        /// 名企
        /// </summary>
        public List<Enterprise> FamousEnts;
    }
}
