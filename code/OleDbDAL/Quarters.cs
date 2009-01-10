///////////////////////////////////////////////////////////
//  Quarters.cs
//  Implementation of the Class Quarters
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
	public class Quarters : IQuarters {

        private const string SQL_SELECT_QUARTERS_BY_TENEMENT = "SELECT QuartersId, Model, BuiltUpArea, MarketPrice, Doorplate, Property, Code, Quantity, TenementId FROM TVMS_Quarters WHERE TenementId = @TenementId";
        private const string SQL_SELECT_QUARTERS = "SELECT QuartersId, Model, BuiltUpArea, MarketPrice, Doorplate, Property, Code, Quantity, TenementId FROM TVMS_Quarters WHERE QuartersId = @QuartersId";
        private const string SQL_INSERT_QUARTERS = "INSERT INTO TVMS_Quarters (Model, BuiltUpArea, MarketPrice, Doorplate, Property, Code, Quantity, TenementId) VALUES (@Model, @BuiltUpArea, @MarketPrice, @Doorplate, @Property, @Code, @Quantity, @TenementId)";
        private const string SQL_UPDATE_QUARTERS = "UPDATE TVMS_Quarters SET Model = @Model, BuiltUpArea = @BuiltUpArea, MarketPrice = @MarketPrice, Doorplate = @Doorplate, Property = @Property, Code = @Code, Quantity = @Quantity, TenementId = @TenementId WHERE QuartersId = @QuartersId";
        private const string SQL_DELETE_QUARTERS = "DELETE FROM TVMS_Quarters WHERE QuartersId = @QuartersId";
        private const string PARM_QUARTERS_ID = "@QuartersId";
        private const string PARM_MODEL = "@Model";
        private const string PARM_BUILT_UP_AREA = "@BuiltUpArea";
        private const string PARM_MARKET_PRICE = "@MarketPrice";
        private const string PARM_DOORPLATE = "@Doorplate";
        private const string PARM_PROPERTY = "@Property";
        private const string PARM_CODE = "@Code";
        private const string PARM_QUANTITY = "@Quantity";
        private const string PARM_TENEMENT_ID = "@TenementId";

        /// 
		/// <param name="tenementId"></param>
		public IList<QuartersInfo> GetQuartersByTenement(int tenementId){

            IList<QuartersInfo> quarters = new List<QuartersInfo>();

            OleDbParameter parm = new OleDbParameter(PARM_TENEMENT_ID, OleDbType.Integer);
            parm.Value = tenementId;

            using (OleDbDataReader rdr = OleDbHelper.ExecuteReader(OleDbHelper.ConnectionStringLocalTransaction, CommandType.Text, SQL_SELECT_QUARTERS_BY_TENEMENT, parm))
            {
                while (rdr.Read())
                {
                    QuartersInfo qua = new QuartersInfo(rdr.GetInt32(0), rdr.GetInt32(1), rdr.GetFloat(2), rdr.GetDecimal(3), rdr.GetString(4), rdr.GetInt32(5), rdr.GetString(6), rdr.GetInt32(7), rdr.GetInt32(8));
                    quarters.Add(qua);
                }
            }
            return quarters;
        }

		/// 
		/// <param name="quartersId"></param>
		public QuartersInfo GetQuarters(int quartersId){

            QuartersInfo quarters = null;

            OleDbParameter parm = new OleDbParameter(PARM_QUARTERS_ID, OleDbType.Integer);
            parm.Value = quartersId;

            using (OleDbDataReader rdr = OleDbHelper.ExecuteReader(OleDbHelper.ConnectionStringLocalTransaction, CommandType.Text, SQL_SELECT_QUARTERS, parm))
            {
                if (rdr.Read())

                    quarters = new QuartersInfo(rdr.GetInt32(0), rdr.GetInt32(1), rdr.GetFloat(2), rdr.GetDecimal(3), rdr.GetString(4), rdr.GetInt32(5), rdr.GetString(6), rdr.GetInt32(7), rdr.GetInt32(8));
                else
                    quarters = new QuartersInfo();
            }
            return quarters;
        }

		/// 
		/// <param name="quarters"></param>
		public void Insert(QuartersInfo quarters){

            OleDbParameter[] quartersParms = GetQuartersParameters();

            quartersParms[0].Value = quarters.QuartersId;
            quartersParms[1].Value = quarters.Model;
            quartersParms[2].Value = quarters.BuiltUpArea;
            quartersParms[3].Value = quarters.MarketPrice;
            quartersParms[4].Value = quarters.Doorplate;
            quartersParms[5].Value = quarters.Property;
            quartersParms[6].Value = quarters.Code;
            quartersParms[7].Value = quarters.Quantity;
            quartersParms[8].Value = quarters.TenementId;

            int numInserted = OleDbHelper.ExecuteNonQuery(OleDbHelper.ConnectionStringLocalTransaction, CommandType.Text, SQL_INSERT_QUARTERS, quartersParms);
            if (numInserted != 1)
                throw new ApplicationException("DATA INTEGRITY ERROR ON QUARTERS INSERT");
        }

		/// 
		/// <param name="quartersId"></param>
		public void Delete(int quartersId){

            OleDbParameter parm = new OleDbParameter(PARM_QUARTERS_ID, OleDbType.Integer);
            parm.Value = quartersId;

            int numDeleted = OleDbHelper.ExecuteNonQuery(OleDbHelper.ConnectionStringLocalTransaction, CommandType.Text, SQL_DELETE_QUARTERS, parm);
            if (numDeleted != 1)
                throw new ApplicationException("DATA INTEGRITY ERROR ON QUARTERS DELETE");
        }

		/// 
		/// <param name="quarters"></param>
		public void Update(QuartersInfo quarters){

            OleDbParameter[] quartersParms = GetQuartersParameters();

            quartersParms[0].Value = quarters.QuartersId;
            quartersParms[1].Value = quarters.Model;
            quartersParms[2].Value = quarters.BuiltUpArea;
            quartersParms[3].Value = quarters.MarketPrice;
            quartersParms[4].Value = quarters.Doorplate;
            quartersParms[5].Value = quarters.Property;
            quartersParms[6].Value = quarters.Code;
            quartersParms[7].Value = quarters.Quantity;
            quartersParms[8].Value = quarters.TenementId;

            int numUpdated = OleDbHelper.ExecuteNonQuery(OleDbHelper.ConnectionStringLocalTransaction, CommandType.Text, SQL_UPDATE_QUARTERS, quartersParms);
            if (numUpdated != 1)
                throw new ApplicationException("DATA INTEGRITY ERROR ON QUARTERS UPDATE");
        }

		/// 
		/// <param name="keywords"></param>
		public IList<QuartersInfo> GetQuartersBySearch(string[] keywords){

            throw new ApplicationException("The method or operation is not implemented.");
			return null;
		}

        private static OleDbParameter[] GetQuartersParameters()
        {
            OleDbParameter[] parms = OleDbHelper.GetCachedParameters(SQL_INSERT_QUARTERS);

            if (parms == null)
            {
                parms = new OleDbParameter[] {
					new OleDbParameter(PARM_QUARTERS_ID, OleDbType.Integer),
					new OleDbParameter(PARM_MODEL, OleDbType.Integer),
					new OleDbParameter(PARM_BUILT_UP_AREA, OleDbType.Single),
					new OleDbParameter(PARM_MARKET_PRICE, OleDbType.Currency),
					new OleDbParameter(PARM_DOORPLATE, OleDbType.VarChar, 30),
					new OleDbParameter(PARM_PROPERTY, OleDbType.Integer),
					new OleDbParameter(PARM_CODE, OleDbType.VarChar, 20),
					new OleDbParameter(PARM_QUANTITY, OleDbType.Integer),
					new OleDbParameter(PARM_TENEMENT_ID, OleDbType.Integer),
                };

                OleDbHelper.CacheParameters(SQL_INSERT_QUARTERS, parms);
            }

            return parms;
        }
    }//end Quarters

}//end namespace OleDbDAL