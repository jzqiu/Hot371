/**  版本信息模板在安装目录下，可自行修改。
* AppIntention.cs
*
* 功 能： N/A
* 类 名： AppIntention
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2014/11/19 21:04:18   N/A    初版
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
	/// AppIntention:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class AppIntention
	{
		#region Model
		/// <summary>
		/// 
		/// </summary>
		public int IId
		{
			set;
			get;
		}
		/// <summary>
		/// 应聘者
		/// </summary>
		public string OpenId
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
		/// 职能
		/// </summary>
		public int? FunctionId
		{
			set;
			get;
		}
		/// <summary>
		/// 省
		/// </summary>
		public int? ProvinceId
		{
			set;
			get;
		}
		/// <summary>
		/// 市
		/// </summary>
		public int? CityId
		{
			set;
			get;
		}
		/// <summary>
		/// 区
		/// </summary>
		public int? AreaId
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

