/**  版本信息模板在安装目录下，可自行修改。
* PTimeRequirement.cs
*
* 功 能： N/A
* 类 名： PTimeRequirement
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2014/11/15 23:11:33   N/A    初版
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
	/// PTimeRequirement:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class PTimeRequirement
	{
		#region Model
		/// <summary>
		/// PK 自增
		/// </summary>
		public int RId
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
		/// 时间 表格行
		/// </summary>
		public int? TimeRequirementRow
		{
			set;
			get;
		}
		/// <summary>
		/// 时间 表格列
		/// </summary>
		public int? TimeRequirementColumn
		{
			set;
			get;
		}
		#endregion Model

	}
}

