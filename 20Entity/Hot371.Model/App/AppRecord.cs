/**  版本信息模板在安装目录下，可自行修改。
* AppRecord.cs
*
* 功 能： N/A
* 类 名： AppRecord
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2014/11/15 23:11:31   N/A    初版
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
	/// AppRecord:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class AppRecord
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
		/// 应聘人
		/// </summary>
		public string OpenId
		{
			set;
			get;
		}
		/// <summary>
		/// 企业
		/// </summary>
		public int? EId
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
		/// 结果：0 待答复，10 合适，20 不合适
		/// </summary>
		public int? Result
		{
			set;
			get;
		}
		/// <summary>
		/// 企业答复时间
		/// </summary>
		public DateTime? ReplyTime
		{
			set;
			get;
		}
		/// <summary>
		/// 面试时间
		/// </summary>
		public DateTime? AuditionTime
		{
			set;
			get;
		}
		/// <summary>
		/// 面试地址
		/// </summary>
		public string AuditionAddr
		{
			set;
			get;
		}
		#endregion Model

	}
}

