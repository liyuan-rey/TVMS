///////////////////////////////////////////////////////////
//  Sale.cs
//  Implementation of the Class Sale
//  Generated by Enterprise Architect
//  Created on:      07-һ��-2009 23:56:35
//  Original author: anaki
///////////////////////////////////////////////////////////

using System;
using System.Data;
using System.Data.OleDb;
using System.Collections.Generic;
using TVMS.Model;
using TVMS.IDAL;
using TVMS.DBUtility;


namespace TVMS.OleDbDAL {
	public class Sale : ISale {

		/// 
		/// <param name="saleId"></param>
		public SaleInfo GetSale(int saleId){

			return null;
		}

		public IList<SaleInfo> GetSales(){

			return null;
		}

		/// 
		/// <param name="sale"></param>
		public void Insert(SaleInfo sale){

		}

		/// 
		/// <param name="quartersId"></param>
		public SaleInfo GetSaleByQuarters(int quartersId){

			return null;
		}

		/// 
		/// <param name="customerId"></param>
		public IList<SaleInfo> GetSalesByCustomer(int customerId){

			return null;
		}

		/// 
		/// <param name="contractId"></param>
		public SaleInfo GetSaleByContract(int contractId){

			return null;
		}

		/// 
		/// <param name="saleId"></param>
		public void Delete(int saleId){

		}

		/// 
		/// <param name="sale"></param>
		public void Update(SaleInfo sale){

		}

	}//end Sale

}//end namespace OleDbDAL