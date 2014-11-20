using System;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace Hot371.Model
{
	/// <summary>
	/// 类AppDefTime。
	/// </summary>
	[Serializable]
	public partial class AppDefTime
	{
		#region Model
		/// <summary>
		/// PK 自增
		/// </summary>
		public int TId
		{
			set;
			get;
		}
		/// <summary>
		/// OpenId
		/// </summary>
		public string OpenId
		{
			set;
			get;
		}
		/// <summary>
		/// 默认时间 表格行
		/// </summary>
		public int? DefTimeRow
		{
			set;
			get;
		}
		/// <summary>
		/// 默认时间 表格列
		/// </summary>
		public int? DefTimeColumn
		{
			set;
			get;
		}
		#endregion Model


	}
}

