/**  版本信息模板在安装目录下，可自行修改。
* Applicant.cs
*
* 功 能： N/A
* 类 名： Applicant
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
	/// Applicant:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class Applicant
	{
		#region Model
		/// <summary>
		/// PK OpenId
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
		/// 性别：1 男，0 女
		/// </summary>
		public int? Sex
		{
			set;
			get;
		}
		/// <summary>
		/// 姓名
		/// </summary>
		public string Name
		{
			set;
			get;
		}
		/// <summary>
		/// 出生年份
		/// </summary>
		public int? BirthYear
		{
			set;
			get;
		}
		/// <summary>
		/// 工作经验
		/// </summary>
		public int? WorkExperience
		{
			set;
			get;
		}
		/// <summary>
		/// 最高学历
		/// </summary>
		public int? HighestDegree
		{
			set;
			get;
		}
		/// <summary>
		/// 手机号
		/// </summary>
		public string Mobile
		{
			set;
			get;
		}
		/// <summary>
		/// 自我简介
		/// </summary>
		public string Introduction
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

