using System;
using System.Collections.Generic;
using System.Text;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Data;
using System.Data.Common;


namespace SQLManager
{
    public class SQL
    {
        //private OleDbConnection connection;
        private SqlConnection connection;
        //private OleDbTransaction transaction;
        private SqlTransaction transaction;
        private bool isConnected = false;
        private string sqlString;

        //        public OleDbConnection Connection
        public SqlConnection Connection
        {
            get { return connection; }
            set { connection = value; }
        }
        //public OleDbTransaction Transaction
        public SqlTransaction Transaction
        {
            get { return transaction; }
            set { transaction = value; }
        }
        public bool IsConnected
        {
            get { return isConnected; }
            set { isConnected = value; }
        }
        public string SqlString
        {
            get { return sqlString; }
            set { sqlString = value; }
        }


        /// <summary>
        /// Constructor, setea el connectionString, Abre la conexion
        /// </summary>
        public SQL()
        {
            //connection = new OleDbConnection();
            connection = new SqlConnection();
            try
            {
                Connection.ConnectionString = System.Configuration.ConfigurationManager.ConnectionStrings[@"ConnectionString"].ConnectionString;
                //Connection.ConnectionString = @"workstation id=""TRAIN195BASE"";packet size=4096;integrated security=SSPI;data source=""TRAIN195BASE"";persist security info=False;initial catalog=Practico";
                //Connection.ConnectionString = @"workstation id=""ORDCORP-PD4HLVN"";packet size=4096;integrated security=SSPI;data source=""ORDCORP-PD4HLVN"";persist security info=False;initial catalog=Practico";
                //"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=D:\DB.mdb";
                Connection.Open();
                IsConnected = true;
            }
            catch (Exception e)
            {
                IsConnected = false;
                throw new SQLManagerException(e.Message);
            }
        }

        /// <summary>
        /// Constructor, setea el connectionString, abre la conexion
        /// </summary>
        /// <param name="connectionString"></param>
        public SQL(string connectionString)
        {
            //connection = new OleDbConnection();
            connection = new SqlConnection();
            try
            {
                Connection.ConnectionString = connectionString;
                Connection.Open();
                IsConnected = true;
            }
            catch (Exception e)
            {
                IsConnected = false;
                throw new SQLManagerException(e.Message);
            }
        }

        /// <summary>
        /// Cerrar coneccion
        /// </summary>
        public void Close()
        {
            try
            {
                if (this.IsConnected)
                    Connection.Close();
            }
            catch (Exception e)
            {
                throw new SQLManagerException(e.Message);
            }
        }

        /// <summary>
        /// Iniciar transaccion
        /// </summary>
        public void InitTransaction()
        {
            try
            {
                Transaction = Connection.BeginTransaction();
            }
            catch (Exception e)
            {
                throw new SQLManagerException(e.Message);
            }
        }

        /// <summary>
        /// Confirmar transaccion
        /// </summary>
        public void CommitTransaction()
        {
            try
            {
                Transaction.Commit();
            }
            catch (Exception e)
            {
                throw new SQLManagerException(e.Message);
            }
        }


        /// <summary>
        /// Cancelar transaccion
        /// </summary>
        public void RollBackTransaction()
        {
            try
            {
                Transaction.Rollback();
            }
            catch (Exception e)
            {
                throw new SQLManagerException(e.Message);
            }
        }

        /// <summary>
        /// Consulta a la Base de datos
        /// </summary>
        /// <param name="args"></param>
        /// <returns></returns>
        //public OleDbDataReader GetDataReader(params object [] args)
        public SqlDataReader GetDataReader(params object[] args)
        {
            try
            {   //selec * fron auto where rodado = ? and color Like ?
                //args[0] = 16 //(int)
                //args[1] = "%r%" // (string)
                int parameterName = 0;
                //OleDbCommand comm = new OleDbCommand(SqlString, Connection, Transaction ?? null);
                SqlCommand comm = new SqlCommand(SqlString, Connection, Transaction ?? null);
                foreach (object arg in args)
                {
                    comm.Parameters.Add("@" + parameterName.ToString(), GetSqlDbtype(arg));
                    parameterName++;
                }

                parameterName = 0;
                foreach (object arg in args)
                {
                    comm.Parameters["@" + parameterName.ToString()].Value = arg;
                    parameterName++;
                }

                //OleDbDataReader DR = comm.ExecuteReader();
                SqlDataReader DR = comm.ExecuteReader();
                return DR;
            }
            catch (Exception e)
            {
                throw new SQLManagerException(e.Message);
                //              return null;
            }

        }

        /// <summary>
        ///Transaccion en la base de datos
        /// </summary>
        /// <param name="args"></param>
        /// <returns></returns>
        public int ExcecuteNonQuery(params object[] args)
        {
            try
            {
                //OleDbCommand comm = new OleDbCommand( SqlString,Connection,Transaction ?? null);
                SqlCommand comm = new SqlCommand(SqlString, Connection, Transaction ?? null);
                int parameterName = 0;
                foreach (object arg in args)
                {
                    comm.Parameters.Add("@" + parameterName.ToString(), GetSqlDbtype(arg));
                    parameterName++;
                }

                parameterName = 0;
                foreach (object arg in args)
                {
                    comm.Parameters["@" + parameterName.ToString()].Value = arg ?? DBNull.Value;
                    parameterName++;
                }
                return comm.ExecuteNonQuery();

            }
            catch (Exception e)
            {
                throw new SQLManagerException(e.Message);
            }
        }

        /// <summary>
        /// obtiene el tipo de dato para la BD segun el tipo de dato(completar)
        /// </summary>
        /// <param name="o"></param>
        /// <returns></returns>
        //private OleDbType GetOleDbType(Object o)
        private SqlDbType GetSqlDbtype(Object o)
        {
            try
            {
                if (o is int || o is Int16 || o is Int32 || o is Int64)
                {
                    return SqlDbType.Int;
                }
                else if (o is String || o is char)
                {
                    return SqlDbType.VarChar;
                }
                else if (o is DateTime)
                {
                    return SqlDbType.DateTime;
                }
                else if (o is bool)
                {
                    return SqlDbType.Bit;
                }
                else
                {
                    return SqlDbType.VarChar;
                }

            }
            catch (Exception e)
            {
                throw new SQLManagerException(e.Message);
            }
        }
    }
}

