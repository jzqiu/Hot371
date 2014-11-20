/**  版本信息模板在安装目录下，可自行修改。
* PCheck.cs
*
* 功 能： N/A
* 类 名： PCheck
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
	/// PCheck:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class PCheck
	{
		#region Model
		/// <summary>
		/// PK 自增
		/// </summary>
		public int CId
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
		/// 申请时间
		/// </summary>
		public DateTime? AppTime
		{
			set;
			get;
		}
		/// <summary>
		/// 审批结果：0 待审，10 通过，20 未通过
		/// </summary>
		public int? CheckResult
		{
			set;
			get;
		}
		/// <summary>
		/// 审批时间
		/// </summary>
		public DateTime? CheckTime
		{
			set;
			get;
		}
		/// <summary>
		/// 审批备注
		/// </summary>
		public string CheckRemark
		{
			set;
			get;
		}
		/// <summary>
		/// 审批人
		/// </summary>
		public int? CheckUserId
		{
			set;
			get;
		}
		#endregion Model

	}
}

