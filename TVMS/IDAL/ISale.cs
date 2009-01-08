///////////////////////////////////////////////////////////
//  ISale.cs
//  Implementation of the Interface ISale
//  Generated by Enterprise Architect
//  Created on:      07-һ��-2009 23:49:59
//  Original author: anaki
///////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;


using TVMS.Model;
namespace TVMS.IDAL {
	public interface ISale {

		/// 
		/// <param name="saleId"></param>
		void Delete(int saleId);

		/// 
		/// <param name="saleId"></param>
		SaleInfo GetSale(int saleId);

		/// 
		/// <param name="contractId"></param>
		SaleInfo GetSaleByContract(int contractId);

		/// 
		/// <param name="quartersId"></param>
		SaleInfo GetSaleByQuarters(int quartersId);

		IList<SaleInfo> GetSales();

		/// 
		/// <param name="customerId"></param>
		IList<SaleInfo> GetSalesByCustomer(int customerId);

		/// 
		/// <param name="sale"></param>
		void Insert(SaleInfo sale);

		/// 
		/// <param name="sale"></param>
		void Save(SaleInfo sale);
	}//end ISale

}//end namespace IDAL