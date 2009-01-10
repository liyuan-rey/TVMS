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
		private DateTime signingDate;
		/// <summary>
		/// 合同号码
		/// </summary>
		private string sn;
		/// <summary>
		/// 预/销售类型
		/// </summary>
		private int contractType;
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
        /// <param name="contractType"></param>
        /// <param name="signingDate"></param>
        /// <param name="customerId"></param>
        /// <param name="quartersId"></param>
        public ContractInfo(int contractId, string sn, int contractType, DateTime signingDate, int customerId, int quartersId)
        {
            this.contractId = contractId;
            this.sn = sn;
            this.contractType = contractType;
            this.signingDate = signingDate;
            this.customerId = customerId;
            this.quartersId = quartersId;
        }

        /// <summary>
		/// 销售日期
		/// </summary>
        public DateTime SigningDate{
			get{
                return signingDate;
			}
			set{
                signingDate = value;
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
		public int ContractType{
			get{
				return contractType;
			}
			set{
				contractType = value;
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