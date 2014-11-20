/**  版本信息模板在安装目录下，可自行修改。
* AppWorkExperience.cs
*
* 功 能： N/A
* 类 名： AppWorkExperience
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2014/11/19 21:04:19   N/A    初版
*
* Copyright (c) 2012 Maticsoft Corporation. All rights reserved.
*┌──────────────────────────────────┐
*│　此技术信息为本公司机密信息，未经本公司书面同意禁止向第三方披露．　│
*│　版权所有：　　　　　　　　　　　　　　│
*└──────────────────────────────────┘
*/
using System;
namespace Hot371.Model
{
	/// <summary>
	/// AppWorkExperience:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class AppWorkExperience
	{
		#region Model
		/// <summary>
		/// PK 自增
		/// </summary>
		public int EId
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
		/// 公司名称
		/// </summary>
		public string CompanyName
		{
			set;
			get;
		}
		/// <summary>
		/// 行业
		/// </summary>
		public int? IndustryId
		{
			set;
			get;
		}
		/// <summary>
		/// 职位名称
		/// </summary>
		public string PositionName
		{
			set;
			get;
		}
		/// <summary>
		/// 待遇
		/// </summary>
		public int? Treatment
		{
			set;
			get;
		}
		/// <summary>
		/// 待遇单位
		/// </summary>
		public string TreatmentUnit
		{
			set;
			get;
		}
		/// <summary>
		/// 开始时间-年
		/// </summary>
		public int? StartYear
		{
			set;
			get;
		}
		/// <summary>
		/// 开始时间-月
		/// </summary>
		public int? StartMonth
		{
			set;
			get;
		}
		/// <summary>
		/// 结束时间-年
		/// </summary>
		public int? EndYear
		{
			set;
			get;
		}
		/// <summary>
		/// 结束时间-月
		/// </summary>
		public int? EndMonth
		{
			set;
			get;
		}
		/// <summary>
		/// 工作内容
		/// </summary>
		public string WorkContent
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
		#endregion Model

	}
}

