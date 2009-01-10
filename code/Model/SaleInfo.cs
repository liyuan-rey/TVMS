///////////////////////////////////////////////////////////
//  OrderInfo.cs
//  Implementation of the Class OrderInfo
//  Generated by Enterprise Architect
//  Created on:      07-一月-2009 20:08:54
//  Original author: anaki
///////////////////////////////////////////////////////////

using System;


namespace TVMS.Model {
    public class SaleInfo
    {


		/// <summary>
		/// 参建款
		/// </summary>
		private decimal cjk;
		/// <summary>
		/// 参建面积
		/// </summary>
		private float cjmj;
		/// <summary>
		/// 参建面积_套数
		/// </summary>
		private int cjts;
		/// <summary>
		/// 参建已用
		/// </summary>
		private float cjyy;
		/// <summary>
		/// 合同编号
		/// </summary>
		private int contractId;
		/// <summary>
		/// 客户编号
		/// </summary>
		private int customerId;
		/// <summary>
		/// 购房日期
		/// </summary>
		private DateTime payingDate;
		/// <summary>
		/// 定金
		/// </summary>
		private decimal deposit;
		/// <summary>
		/// 定金日期
		/// </summary>
		private DateTime depositDate;
		/// <summary>
		/// 预付款1
		/// </summary>
		private decimal imprest1;
		private DateTime imprest1Date;
		private int imprest1State;
		/// <summary>
		/// 预付款2
		/// </summary>
		private decimal imprest2;
		private DateTime imprest2Date;
		private int imprest2State;
		/// <summary>
		/// 预付款3
		/// </summary>
		private decimal imprest3;
		private DateTime imprest3Date;
		private int imprest3State;
		/// <summary>
		/// 预付款4
		/// </summary>
		private decimal imprest4;
		private DateTime imprest4Date;
		private int imprest4State;
		/// <summary>
		/// 预付款5
		/// </summary>
		private decimal imprest5;
		private DateTime imprest5Date;
		private int imprest5State;
		/// <summary>
		/// 住宅编号
		/// </summary>
		private int quartersId;
		/// <summary>
		/// 备注
		/// </summary>
		private string remark;
		/// <summary>
		/// 销售价格
		/// </summary>
		private decimal salePrice;
		/// <summary>
		/// 销售单编号
		/// </summary>
		private int saleId;

		public SaleInfo(){

		}

        /// 
        /// <param name="saleId"></param>
        /// <param name="salePrice"></param>
        /// <param name="payingDate"></param>
        /// <param name="deposit"></param>
        /// <param name="depositDate"></param>
        /// <param name="cjk"></param>
        /// <param name="cjmj"></param>
        /// <param name="cjts"></param>
        /// <param name="cjyy"></param>
        /// <param name="imprest1"></param>
        /// <param name="imprest1Date"></param>
        /// <param name="imprest1State"></param>
        /// <param name="imprest2"></param>
        /// <param name="imprest2Date"></param>
        /// <param name="imprest2State"></param>
        /// <param name="imprest3"></param>
        /// <param name="imprest3Date"></param>
        /// <param name="imprest3State"></param>
        /// <param name="imprest4"></param>
        /// <param name="imprest4Date"></param>
        /// <param name="imprest4State"></param>
        /// <param name="imprest5"></param>
        /// <param name="imprest5Date"></param>
        /// <param name="imprest5State"></param>
        /// <param name="remark"></param>
        /// <param name="quartersId"></param>
        /// <param name="contractId"></param>
        /// <param name="customerId"></param>
        public SaleInfo(int saleId, decimal salePrice, DateTime payingDate, decimal deposit, DateTime depositDate, decimal cjk, float cjmj, int cjts, float cjyy, decimal imprest1, DateTime imprest1Date, int imprest1State, decimal imprest2, DateTime imprest2Date, int imprest2State, decimal imprest3, DateTime imprest3Date, int imprest3State, decimal imprest4, DateTime imprest4Date, int imprest4State, decimal imprest5, DateTime imprest5Date, int imprest5State, string remark, int quartersId, int contractId, int customerId)
        {
            this.saleId = saleId;
            this.salePrice = salePrice;
            this.payingDate = payingDate;
            this.deposit = deposit;
            this.depositDate = depositDate;
            this.cjk = cjk;
            this.cjmj = cjmj;
            this.cjts = cjts;
            this.cjyy = cjyy;
            this.imprest1 = imprest1;
            this.imprest1Date = imprest1Date;
            this.imprest1State = imprest1State;
            this.imprest2 = imprest2;
            this.imprest2Date = imprest2Date;
            this.imprest2State = imprest2State;
            this.imprest3 = imprest3;
            this.imprest3Date = imprest3Date;
            this.imprest3State = imprest3State;
            this.imprest4 = imprest4;
            this.imprest4Date = imprest4Date;
            this.imprest4State = imprest4State;
            this.imprest5 = imprest5;
            this.imprest5Date = imprest5Date;
            this.imprest5State = imprest5State;
            this.remark = remark;
            this.quartersId = quartersId;
            this.contractId = contractId;
            this.customerId = customerId;
        }

        /// <summary>
		/// 参建款
		/// </summary>
		public decimal Cjk{
			get{
				return cjk;
			}
			set{
				cjk = value;
			}
		}

		/// <summary>
		/// 参建面积
		/// </summary>
		public float Cjmj{
			get{
				return cjmj;
			}
			set{
				cjmj = value;
			}
		}

		/// <summary>
		/// 参建面积_套数
		/// </summary>
		public int Cjts{
			get{
				return cjts;
			}
			set{
				cjts = value;
			}
		}

		/// <summary>
		/// 参建已用
		/// </summary>
		public float Cjyy{
			get{
				return cjyy;
			}
			set{
				cjyy = value;
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

		/// <summary>
		/// 客户编号
		/// </summary>
		public int CustomerId{
			get{
				return customerId;
			}
			set{
				customerId = value;
			}
		}

		/// <summary>
		/// 购房日期
		/// </summary>
		public DateTime PayingDate{
			get{
				return payingDate;
			}
			set{
                payingDate = value;
			}
		}

		/// <summary>
		/// 定金
		/// </summary>
		public decimal Deposit{
			get{
				return deposit;
			}
			set{
				deposit = value;
			}
		}

		/// <summary>
		/// 定金日期
		/// </summary>
		public DateTime DepositDate{
			get{
				return depositDate;
			}
			set{
				depositDate = value;
			}
		}

		/// <summary>
		/// 预付款1
		/// </summary>
		public decimal Imprest1{
			get{
				return imprest1;
			}
			set{
				imprest1 = value;
			}
		}

		public DateTime Imprest1Date{
			get{
				return imprest1Date;
			}
			set{
				imprest1Date = value;
			}
		}

		public int Imprest1State{
			get{
				return imprest1State;
			}
			set{
				imprest1State = value;
			}
		}

		/// <summary>
		/// 预付款2
		/// </summary>
		public decimal Imprest2{
			get{
				return imprest2;
			}
			set{
				imprest2 = value;
			}
		}

		public DateTime Imprest2Date{
			get{
				return imprest2Date;
			}
			set{
				imprest2Date = value;
			}
		}

		public int Imprest2State{
			get{
				return imprest2State;
			}
			set{
				imprest2State = value;
			}
		}

		/// <summary>
		/// 预付款3
		/// </summary>
		public decimal Imprest3{
			get{
				return imprest3;
			}
			set{
				imprest3 = value;
			}
		}

		public DateTime Imprest3Date{
			get{
				return imprest3Date;
			}
			set{
				imprest3Date = value;
			}
		}

		public int Imprest3State{
			get{
				return imprest3State;
			}
			set{
				imprest3State = value;
			}
		}

		/// <summary>
		/// 预付款4
		/// </summary>
		public decimal Imprest4{
			get{
				return imprest4;
			}
			set{
				imprest4 = value;
			}
		}

		public DateTime Imprest4Date{
			get{
				return imprest4Date;
			}
			set{
				imprest4Date = value;
			}
		}

		public int Imprest4State{
			get{
				return imprest4State;
			}
			set{
				imprest4State = value;
			}
		}

		/// <summary>
		/// 预付款5
		/// </summary>
		public decimal Imprest5{
			get{
				return imprest5;
			}
			set{
				imprest5 = value;
			}
		}

		public DateTime Imprest5Date{
			get{
				return imprest5Date;
			}
			set{
				imprest5Date = value;
			}
		}

		public int Imprest5State{
			get{
				return imprest5State;
			}
			set{
				imprest5State = value;
			}
		}

		/// <summary>
		/// 住宅编号
		/// </summary>
		public int QuartersId{
			get{
				return quartersId;
			}
			set{
				quartersId = value;
			}
		}

		/// <summary>
		/// 备注
		/// </summary>
		public string Remark{
			get{
				return remark;
			}
			set{
				remark = value;
			}
		}

		/// <summary>
		/// 销售价格
		/// </summary>
		public decimal SalePrice{
			get{
				return salePrice;
			}
			set{
				salePrice = value;
			}
		}

		/// <summary>
		/// 销售单编号
		/// </summary>
		public int SaleId{
			get{
				return saleId;
			}
			set{
				saleId = value;
			}
		}


	}//end SaleInfo

}//end namespace Model