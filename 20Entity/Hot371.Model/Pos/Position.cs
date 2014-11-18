/**  版本信息模板在安装目录下，可自行修改。
* Position.cs
*
* 功 能： N/A
* 类 名： Position
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
	/// Position:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class Position
	{
		#region Model
		/// <summary>
		/// PK 自增
		/// </summary>
		public int PId
		{
			set;
			get;
		}
		/// <summary>
		/// 发布企业
		/// </summary>
		public int? PublishEId
		{
			set;
			get;
		}
		/// <summary>
		/// 标题
		/// </summary>
		public string Title
		{
			set;
			get;
		}
		/// <summary>
		/// 招聘企业
		/// </summary>
		public int? RecruitEId
		{
			set;
			get;
		}
		/// <summary>
		/// 招聘企业名称
		/// </summary>
		public string RecruitEName
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
		/// 职能名称
		/// </summary>
		public string FunctionName
		{
			set;
			get;
		}
		/// <summary>
		/// 结算方式
		/// </summary>
		public int? SettlementId
		{
			set;
			get;
		}
		/// <summary>
		/// 结算方式名称
		/// </summary>
		public string SettlementName
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
		/// 招聘人数
		/// </summary>
		public int? Recruitment
		{
			set;
			get;
		}
		/// <summary>
		/// 职位描述
		/// </summary>
		public string Description
		{
			set;
			get;
		}
		/// <summary>
		/// 上线时间
		/// </summary>
		public DateTime? OnLineTime
		{
			set;
			get;
		}
		/// <summary>
		/// 下线时间
		/// </summary>
		public DateTime? FailureTime
		{
			set;
			get;
		}
		/// <summary>
		/// 联系电话
		/// </summary>
		public string Telephone
		{
			set;
			get;
		}
		/// <summary>
		/// 业务员OpenId
		/// </summary>
		public string BManOpenId
		{
			set;
			get;
		}
		/// <summary>
		/// 是否接收在线咨询：0 否，1 是
		/// </summary>
		public int? IsAcceptOnLine
		{
			set;
			get;
		}
		/// <summary>
		/// 状态：0 待审，10 通过，20 未通过
		/// </summary>
		public int? Status
		{
			set;
			get;
		}
		/// <summary>
		/// 是否发布
		/// </summary>
		public int? IsPublish
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

