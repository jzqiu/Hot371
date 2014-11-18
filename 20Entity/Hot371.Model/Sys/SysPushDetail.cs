/**  版本信息模板在安装目录下，可自行修改。
* SysPushDetail.cs
*
* 功 能： N/A
* 类 名： SysPushDetail
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
	/// SysPushDetail:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class SysPushDetail
	{
		#region Model
		/// <summary>
		/// PK 自增
		/// </summary>
		public int DId
		{
			set;
			get;
		}
		/// <summary>
		/// 推送OpenId
		/// </summary>
		public string OpenId
		{
			set;
			get;
		}
		/// <summary>
		/// 推送内容
		/// </summary>
		public string PContent
		{
			set;
			get;
		}
		/// <summary>
		/// 推送时间
		/// </summary>
		public DateTime? CreateTime
		{
			set;
			get;
		}
		/// <summary>
		/// 状态：0未发，1已发
		/// </summary>
		public int? Status
		{
			set;
			get;
		}
		#endregion Model

	}
}

