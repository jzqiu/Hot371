using System;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace Hot371.Model
{
	/// <summary>
	/// 类SysArea。
	/// </summary>
	[Serializable]
	public partial class SysArea
	{
		#region Model
		/// <summary>
		/// 区域编号
		/// </summary>
		public int AreaId
		{
			set;
			get;
		}
		/// <summary>
		/// 区域名称
		/// </summary>
		public string AreaName
		{
			set;
			get;
		}
		/// <summary>
		/// 父级编号
		/// </summary>
		public int ParentId
		{
			set;
			get;
		}
		/// <summary>
		/// 区域等级(1省/2市/3区县)
		/// </summary>
		public int AreaLevel
		{
			set;
			get;
		}
		/// <summary>
		/// 状态（1可用/0不可用）
		/// </summary>
		public int Status
		{
			set;
			get;
		}
		#endregion Model

	}
}

