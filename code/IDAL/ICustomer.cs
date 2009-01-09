///////////////////////////////////////////////////////////
//  ICustomer.cs
//  Implementation of the Interface ICustomer
//  Generated by Enterprise Architect
//  Created on:      07-һ��-2009 23:49:59
//  Original author: anaki
///////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;


using TVMS.Model;
namespace TVMS.IDAL {
	public interface ICustomer {

		/// 
		/// <param name="customerId"></param>
		void Delete(int customerId);

		/// 
		/// <param name="customerId"></param>
		CustomerInfo GetCustomer(int customerId);

		IList<CustomerInfo> GetCustomers();

		/// 
		/// <param name="customer"></param>
		void Insert(CustomerInfo customer);

		/// 
		/// <param name="customer"></param>
		void Update(CustomerInfo customer);
	}//end ICustomer

}//end namespace IDAL