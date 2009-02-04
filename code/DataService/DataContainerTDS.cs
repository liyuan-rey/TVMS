using System;
using System.Data;
using System.Data.OleDb;
using TVMS.DataService.DataContainerTDSTableAdapters;

namespace TVMS.DataService {
    partial class DataContainerTDS
    {

        public static DataContainerTDS GetQuarters()
        {
            QuartersTableAdapter quaAdapter = new QuartersTableAdapter();
            SalesTableAdapter salAdapter = new SalesTableAdapter();
            TenementsTableAdapter tenAdapter = new TenementsTableAdapter();

            DataContainerTDS ds = new DataContainerTDS();
            quaAdapter.Fill(ds.Quarters);
            salAdapter.Fill(ds.Sales);
            tenAdapter.Fill(ds.Tenements);

            return ds;
        }

    }
}

namespace TVMS.DataService.DataContainerTDSTableAdapters
{

    public partial class QuartersTableAdapter
    {
        public OleDbTransaction BeginTransaction(OleDbConnection p_connection, OleDbTransaction p_transaction)
        {
            //--- A Transaction requires an open connection
            if (p_connection.State != ConnectionState.Open)
            {
                throw new ArgumentException("Connection must be open to begin a transaction !");

            }

            //--- Set the connection for all the contained commands
            this.Connection = p_connection;

            if (p_transaction == null)
            {
                p_transaction = p_connection.BeginTransaction();
            }


            foreach (OleDbCommand cmd in _commandCollection)
            {
                if (cmd != null)
                    cmd.Transaction = p_transaction;
            }
            if ((Adapter.InsertCommand != null))
            {
                Adapter.InsertCommand.Transaction = p_transaction;
            }
            if ((Adapter.DeleteCommand != null))
            {
                Adapter.DeleteCommand.Transaction = p_transaction;
            }
            if ((Adapter.UpdateCommand != null))
            {
                Adapter.UpdateCommand.Transaction = p_transaction;
            }
            if ((Adapter.SelectCommand != null))
            {
                Adapter.SelectCommand.Transaction = p_transaction;
            }

            return p_transaction;
        }
    }

    public partial class SalesTableAdapter
    {
        public OleDbTransaction BeginTransaction(OleDbConnection p_connection, OleDbTransaction p_transaction)
        {
            //--- A Transaction requires an open connection
            if (p_connection.State != ConnectionState.Open)
            {
                throw new ArgumentException("Connection must be open to begin a transaction !");

            }

            //--- Set the connection for all the contained commands
            this.Connection = p_connection;

            if (p_transaction == null)
            {
                p_transaction = p_connection.BeginTransaction();
            }


            foreach (OleDbCommand cmd in _commandCollection)
            {
                if (cmd != null)
                    cmd.Transaction = p_transaction;
            }
            if ((Adapter.InsertCommand != null))
            {
                Adapter.InsertCommand.Transaction = p_transaction;
            }
            if ((Adapter.DeleteCommand != null))
            {
                Adapter.DeleteCommand.Transaction = p_transaction;
            }
            if ((Adapter.UpdateCommand != null))
            {
                Adapter.UpdateCommand.Transaction = p_transaction;
            }
            if ((Adapter.SelectCommand != null))
            {
                Adapter.SelectCommand.Transaction = p_transaction;
            }

            return p_transaction;
        }
    }

}