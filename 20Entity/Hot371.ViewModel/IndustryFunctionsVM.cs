using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Hot371.Model;

namespace Hot371.ViewModel
{
    public class IndustryFunctionsVM
    {
        /// <summary>
        /// PK 自增
        /// </summary>
        public int IId
        {
            set;
            get;
        }
        /// <summary>
        /// 行业名称
        /// </summary>
        public string IName
        {
            set;
            get;
        }
        /// <summary>
        /// 小图标
        /// </summary>
        public string ImgUrl
        {
            set;
            get;
        }

        public IEnumerable<SysIFunction> Functions;
    }
}
