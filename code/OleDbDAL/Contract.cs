///////////////////////////////////////////////////////////
//  Contract.cs
//  Implementation of the Class Contract
//  Generated by Enterprise Architect
//  Created on:      07-һ��-2009 23:56:34
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
	public class Contract : IContract {

        private const string SQL_SELECT_CONTRACTS = "SELECT ContractId, Sn, ContractType, SigningDate, CustomerId, QuartersId FROM TVMS_Contracts";
        private const string SQL_SELECT_CONTRACT = "SELECT ContractId, Sn, ContractType, SigningDate, CustomerId, QuartersId FROM TVMS_Contracts WHERE ContractId = @ContractId";
        private const string SQL_INSERT_CONTRACT = "INSERT INTO TVMS_Contracts (Sn, ContractType, SigningDate, CustomerId, QuartersId) VALUES (@Sn, @ContractType, @SigningDate, @CustomerId, @QuartersId)";
        private const string SQL_UPDATE_CONTRACT = "UPDATE TVMS_Contracts SET Sn = @Sn, ContractType = @ContractType, SigningDate = @SigningDate, CustomerId = @CustomerId, QuartersId = @QuartersId WHERE ContractId = @ContractId";
        private const string SQL_DELETE_CONTRACT = "DELETE FROM TVMS_Contracts WHERE ContractId = @ContractId";
        private const string PARM_CONTRACT_ID = "@ContractId";
        private const string PARM_SN = "@Sn";
        private const string PARM_CONTRACT_TYPE = "@ContractType";
        private const string PARM_SIGNING_DATE = "@SigningDate";
        private const string PARM_CUSTOMER_ID = "@CustomerId";
        private const string PARM_QUARTERS_ID = "@QuartersId";

        public IList<ContractInfo> GetContracts(){

            IList<ContractInfo> contracts = new List<ContractInfo>();

            using (OleDbDataReader rdr = OleDbHelper.ExecuteReader(OleDbHelper.ConnectionStringLocalTransaction, CommandType.Text, SQL_SELECT_CONTRACTS, null))
            {
                while (rdr.Read())
                {
                    ContractInfo con = new ContractInfo();
                    ORMHelper.RelationalToObject(con, rdr);
                    //ContractInfo con = new ContractInfo(rdr.GetInt32(0), rdr.GetString(1), rdr.GetInt32(2), new DBNullAdapter(rdr.GetValue(3)), rdr.GetInt32(4), rdr.GetInt32(5));
                    contracts.Add(con);
                }
            }
            return contracts;
        }

		/// 
		/// <param name="contractId"></param>
		public ContractInfo GetContract(int contractId){

            ContractInfo contract = null;

            OleDbParameter parm = new OleDbParameter(PARM_CONTRACT_ID, OleDbType.Integer);
            parm.Value = contractId;

            using (OleDbDataReader rdr = OleDbHelper.ExecuteReader(OleDbHelper.ConnectionStringLocalTransaction, CommandType.Text, SQL_SELECT_CONTRACT, parm))
            {
                if (rdr.Read())
                {
                    contract = new ContractInfo();
                    ORMHelper.RelationalToObject(contract, rdr);
                }
                //    contract = new ContractInfo(rdr.GetInt32(0), rdr.GetString(1), rdr.GetInt32(2), new DBNullAdapter(rdr.GetValue(3)), rdr.GetInt32(4), rdr.GetInt32(5));
                //else
                //    contract = new ContractInfo();
            }
            return contract;
        }

		/// 
		/// <param name="contract"></param>
		public void Insert(ContractInfo contract){

            OleDbParameter[] contractParms = GetContractParameters();

            contractParms[0].Value = contract.ContractId;
            contractParms[1].Value = contract.Sn;
            contractParms[2].Value = contract.ContractType;
            contractParms[3].Value = contract.SigningDate;
            contractParms[4].Value = contract.CustomerId;
            contractParms[5].Value = contract.QuartersId;

            int numInserted = OleDbHelper.ExecuteNonQuery(OleDbHelper.ConnectionStringLocalTransaction, CommandType.Text, SQL_INSERT_CONTRACT, contractParms);
            if (numInserted != 1)
                throw new ApplicationException("DATA INTEGRITY ERROR ON CONTRACT INSERT");
        }

		/// 
		/// <param name="contractId"></param>
		public void Delete(int contractId){

            OleDbParameter parm = new OleDbParameter(PARM_CONTRACT_ID, OleDbType.Integer);
            parm.Value = contractId;

            int numDeleted = OleDbHelper.ExecuteNonQuery(OleDbHelper.ConnectionStringLocalTransaction, CommandType.Text, SQL_DELETE_CONTRACT, parm);
            if (numDeleted != 1)
                throw new ApplicationException("DATA INTEGRITY ERROR ON CONTRACT DELETE");
        }

		/// 
		/// <param name="contract"></param>
		public void Update(ContractInfo contract){

            OleDbParameter[] contractParms = GetContractParameters();

            contractParms[0].Value = contract.ContractId;
            contractParms[1].Value = contract.Sn;
            contractParms[2].Value = contract.ContractType;
            contractParms[3].Value = contract.SigningDate;
            contractParms[4].Value = contract.CustomerId;
            contractParms[5].Value = contract.QuartersId;

            int numUpdated = OleDbHelper.ExecuteNonQuery(OleDbHelper.ConnectionStringLocalTransaction, CommandType.Text, SQL_UPDATE_CONTRACT, contractParms);
            if (numUpdated != 1)
                throw new ApplicationException("DATA INTEGRITY ERROR ON CONTRACT UPDATE");
        }

        private static OleDbParameter[] GetContractParameters()
        {
            OleDbParameter[] parms = OleDbHelper.GetCachedParameters(SQL_INSERT_CONTRACT);

            if (parms == null)
            {
                parms = new OleDbParameter[] {
					new OleDbParameter(PARM_CONTRACT_ID, OleDbType.Integer),
					new OleDbParameter(PARM_SN, OleDbType.VarChar, 30),
					new OleDbParameter(PARM_CONTRACT_TYPE, OleDbType.Integer),
					new OleDbParameter(PARM_SIGNING_DATE, OleDbType.DBTimeStamp),
					new OleDbParameter(PARM_CUSTOMER_ID, OleDbType.Integer),
					new OleDbParameter(PARM_QUARTERS_ID, OleDbType.Integer),
                };

                OleDbHelper.CacheParameters(SQL_INSERT_CONTRACT, parms);
            }

            return parms;
        }
    }//end Contract

}//end namespace OleDbDAL