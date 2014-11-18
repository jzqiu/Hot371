/**  版本信息模板在安装目录下，可自行修改。
* SysMessage.cs
*
* 功 能： N/A
* 类 名： SysMessage
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2014/11/15 23:11:34   N/A    初版
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
	/// SysMessage:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class SysMessage
	{
		#region Model
		/// <summary>
		/// PK 自增
		/// </summary>
		public int MId
		{
			set;
			get;
		}
		/// <summary>
		/// 发送人
		/// </summary>
		public string SenderOpenId
		{
			set;
			get;
		}
		/// <summary>
		/// 发送人昵称
		/// </summary>
		public string SenderNikeName
		{
			set;
			get;
		}
		/// <summary>
		/// 接收人
		/// </summary>
		public string ReceiverOpenId
		{
			set;
			get;
		}
		/// <summary>
		/// 接收人昵称
		/// </summary>
		public string ReceiverNikeName
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
		/// 企业名称
		/// </summary>
		public string EName
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
		/// 职位标题
		/// </summary>
		public string PTitle
		{
			set;
			get;
		}
		/// <summary>
		/// 内容
		/// </summary>
		public string MContent
		{
			set;
			get;
		}
		/// <summary>
		/// 发送时间
		/// </summary>
		public DateTime? SendTime
		{
			set;
			get;
		}
		/// <summary>
		/// 是否打开
		/// </summary>
		public int? IsOpen
		{
			set;
			get;
		}
		/// <summary>
		/// 打开时间
		/// </summary>
		public DateTime? OpenTime
		{
			set;
			get;
		}
		#endregion Model

	}
}

