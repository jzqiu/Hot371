using System;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace Hot371.Model
{
	/// <summary>
	/// 类Enterprise。
	/// </summary>
	[Serializable]
	public partial class Enterprise
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
		/// 名称
		/// </summary>
		public string EName
		{
			set;
			get;
		}
		/// <summary>
		/// 类型：10直招，20中介
		/// </summary>
		public int? ETypeId
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
		/// 详细地址
		/// </summary>
		public string Address
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
		/// 规模
		/// </summary>
		public int? Scale
		{
			set;
			get;
		}
		/// <summary>
		/// 联系人
		/// </summary>
		public string Contact
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
		/// 简介
		/// </summary>
		public string Introduction
		{
			set;
			get;
		}
		/// <summary>
		/// 营业执照/合作协议 地址
		/// </summary>
		public string LicenseImgUrl
		{
			set;
			get;
		}
		/// <summary>
		/// logo地址
		/// </summary>
		public string LogoUrl
		{
			set;
			get;
		}
		/// <summary>
        /// 企业可上线职位数
		/// </summary>
		public int? PublishNumbers
		{
			set;
			get;
		}
		/// <summary>
		/// 企业等级
		/// </summary>
		public int? ELevel
		{
			set;
			get;
		}
		/// <summary>
		/// 挂靠父中介，直招企业默认0
		/// </summary>
		public int? ParentId
		{
			set;
			get;
		}
		/// <summary>
		/// 中介可上线企业数
		/// </summary>
		public int? ENumbers
		{
			set;
			get;
		}
        /// <summary>
        /// 可下载简历数
        /// </summary>
        public int? DownloadNumbers
        {
            set;
            get;
        }
		/// <summary>
		/// 中介发布的企业是否上线，默认 0； 直招企业 默认 1
		/// </summary>
		public int? IsOnline
		{
			set;
			get;
		}
		/// <summary>
		/// 是否名企
		/// </summary>
		public int? IsFamous
		{
			set;
			get;
		}
		/// <summary>
		/// 名企排序
		/// </summary>
		public int? FamousSort
		{
			set;
			get;
		}
		/// <summary>
		/// 状态：0 草稿，5 等待审批，10 申请不通过，50 申请通过
		/// </summary>
		public int? Status
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
		/// <summary>
		/// 更新时间
		/// </summary>
		public DateTime? UpateTime
		{
			set;
			get;
		}
		#endregion Model

	}
}

