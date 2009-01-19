///////////////////////////////////////////////////////////
//  Quarters.cs
//  Implementation of the Class Quarters
//  Generated by Enterprise Architect
//  Created on:      07-һ��-2009 23:56:35
//  Original author: anaki
///////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using TVMS.Model;
using TVMS.IDAL;


namespace TVMS.BLL {
	public class Quarters {

        private static readonly IQuarters dal = TVMS.DALFactory.DataAccess.CreateQuarters();
        
        /// 
		/// <param name="tenementId"></param>
		public IList<QuartersInfo> GetQuartersByTenement(int tenementId){

            return dal.GetQuartersByTenement(tenementId);
		}

        public IList<QuartersInfo> GetQuarters(){

            return dal.GetQuarters();
        }
        
        /// 
		/// <param name="quartersId"></param>
		public QuartersInfo GetQuarters(int quartersId){

			return null;
		}

		/// 
		/// <param name="quarters"></param>
		public void Insert(QuartersInfo quarters){

		}

		/// 
		/// <param name="quartersId"></param>
		public void Delete(int quartersId){

		}

		/// 
		/// <param name="quarters"></param>
		public void Update(QuartersInfo quarters){

		}

		/// 
		/// <param name="keywords"></param>
		public IList<QuartersInfo> GetQuartersBySearch(string text){

			return null;
		}

	}//end Quarters

}//end namespace BLL//end namespace BLL