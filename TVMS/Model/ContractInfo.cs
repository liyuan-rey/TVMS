///////////////////////////////////////////////////////////
//  ContractInfo.cs
//  Implementation of the Class ContractInfo
//  Generated by Enterprise Architect
//  Created on:      07-一月-2009 20:08:53
//  Original author: anaki
///////////////////////////////////////////////////////////

using System;


namespace TVMS.Model {
	public class ContractInfo {

		/// <summary>
		/// 销售日期
		/// </summary>
		private DateTime date;
		/// <summary>
		/// 合同号码
		/// </summary>
		private string sn;
		/// <summary>
		/// 预/销售类型
		/// </summary>
		private int type;
		/// <summary>
		/// 合同编号
		/// </summary>
		private int contractId;
		/// <summary>
		/// 客户编号
		/// </summary>
		private int customerId;
		/// <summary>
		/// 住宅编号
		/// </summary>
		private int quartersId;

		public ContractInfo(){

		}

        /// 
        /// <param name="contractId"></param>
        /// <param name="sn"></param>
        /// <param name="type"></param>
        /// <param name="date"></param>
        /// <param name="customerId"></param>
        /// <param name="quartersId"></param>
        public ContractInfo(int contractId, string sn, int type, DateTime date, int customerId, int quartersId)
        {

        }

        /// <summary>
		/// 销售日期
		/// </summary>
		public DateTime Date{
			get{
				return date;
			}
			set{
				date = value;
			}
		}

		/// <summary>
		/// 合同号码
		/// </summary>
		public string Sn{
			get{
				return sn;
			}
			set{
				sn = value;
			}
		}

		/// <summary>
		/// 预/销售类型
		/// </summary>
		public int Type{
			get{
				return type;
			}
			set{
				type = value;
			}
		}

		/// <summary>
		/// 合同编号
		/// </summary>
		public int ContractId{
			get{
				return contractId;
			}
			set{
				contractId = value;
			}
		}

		public int CustomerId{
			get{
				return customerId;
			}
			set{
				customerId = value;
			}
		}

		public int QuartersId{
			get{
				return quartersId;
			}
			set{
				quartersId = value;
			}
		}

	}//end ContractInfo

}//end namespace Model