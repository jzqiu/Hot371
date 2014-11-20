/**  版本信息模板在安装目录下，可自行修改。
* SysPushHead.cs
*
* 功 能： N/A
* 类 名： SysPushHead
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2014/11/15 23:11:35   N/A    初版
*
* Copyright (c) 2012 Maticsoft Corporation. All rights reserved.
*┌──────────────────────────────────┐
*│　此技术信息为本公司机密信息，未经本公司书面同意禁止向第三方披露．　│
*│　版权所有：三缺一　　　　　　　　　　　　　　│
*└──────────────────────────────────┘
*/
using System;
namespace Hot371.Model
{
	/// <summary>
	/// SysPushHead:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class SysPushHead
	{
		#region Model
		/// <summary>
		/// 
		/// </summary>
		public int HId
		{
			set;
			get;
		}
		/// <summary>
		/// 职位
		/// </summary>
		public int? PId
		{
			set;
			get;
		}
		/// <summary>
		/// 创建时间
		/// </summary>
		public DateTime? CreateTime
		{
			set;
			get;
		}
		/// <summary>
		/// 是否分解：0 否，1 是
		/// </summary>
		public int? IsResolve
		{
			set;
			get;
		}
		/// <summary>
		/// 分解时间
		/// </summary>
		public DateTime? ResolveTime
		{
			set;
			get;
		}
		#endregion Model

	}
}

