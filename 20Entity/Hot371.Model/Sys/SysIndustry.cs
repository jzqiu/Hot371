using System;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace Hot371.Model
{
	/// <summary>
	/// 类SysIndustry。
	/// </summary>
	[Serializable]
	public partial class SysIndustry
	{
		#region Model
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
		/// 排序
		/// </summary>
		public int? Sort
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
		#endregion Model

	}
}

