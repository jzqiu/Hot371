using System;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace Hot371.Model
{
	/// <summary>
	/// 类SysIFunction。
	/// </summary>
	[Serializable]
	public partial class SysIFunction
	{
		#region Model
		/// <summary>
		/// PK 自增
		/// </summary>
		public int FId
		{
			set;
			get;
		}
		/// <summary>
		/// 所属行业
		/// </summary>
		public int? IId
		{
			set;
			get;
		}
		/// <summary>
		/// 职能名称
		/// </summary>
		public string FName
		{
			set;
			get;
		}
		/// <summary>
		/// 排序
		/// </summary>
		public int? Sort
		{
			set;
			get;
		}
        /// <summary>
        /// 全拼
        /// </summary>
        public string QuanPin
        {
            set;
            get;
        }
        /// <summary>
        /// 拼音首字
        /// </summary>
        public string PYShouZi
        {
            set;
            get;
        }
		#endregion Model


	}
}

