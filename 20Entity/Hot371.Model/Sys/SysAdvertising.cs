/**  版本信息模板在安装目录下，可自行修改。
* SysAdvertising.cs
*
* 功 能： N/A
* 类 名： SysAdvertising
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
	/// SysAdvertising:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class SysAdvertising
	{
		#region Model
		/// <summary>
		/// PK 自增
		/// </summary>
		public int AId
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
		/// 图片
		/// </summary>
		public string ImgUrl
		{
			set;
			get;
		}
		/// <summary>
		/// 排序
		/// </summary>
		public int? Sort
		{
			set;
			get;
		}
		/// <summary>
		/// 显示城市，默认全国 0
		/// </summary>
		public int? CityId
		{
			set;
			get;
		}
		/// <summary>
		/// 状态：1 有效，0 无效
		/// </summary>
		public int? Status
		{
			set;
			get;
		}
		/// <summary>
		/// 跳转地址
		/// </summary>
		public string RedirectUrl
		{
			set;
			get;
		}
		#endregion Model

	}
}

