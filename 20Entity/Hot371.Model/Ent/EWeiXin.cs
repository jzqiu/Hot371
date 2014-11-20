/**  版本信息模板在安装目录下，可自行修改。
* EWeiXin.cs
*
* 功 能： N/A
* 类 名： EWeiXin
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2014/11/15 23:11:32   N/A    初版
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
	/// EWeiXin:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class EWeiXin
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
		/// 企业Id
		/// </summary>
		public int? EId
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
		/// 昵称
		/// </summary>
		public string NikeName
		{
			set;
			get;
		}
		/// <summary>
		/// 头像
		/// </summary>
		public string HeadUrl
		{
			set;
			get;
		}
		/// <summary>
		/// 备注名
		/// </summary>
		public string RemarkName
		{
			set;
			get;
		}
		/// <summary>
		/// 业务电话
		/// </summary>
		public string Telephone
		{
			set;
			get;
		}
		/// <summary>
		/// 绑定时间
		/// </summary>
		public DateTime? BindTime
		{
			set;
			get;
		}
		#endregion Model

	}
}

