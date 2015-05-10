using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Purdue.OnlineClassScheduler.Logs;
using System.Configuration;

namespace Purdue.OnlineClassScheduler.DAL
{
    public class DataAccessEntity
    {
        //Access connect scring
        string acConnStr;
        //Access Connection
        SQLiteConnection acConnection;
        SQLiteCommand acCmd;

		/// <summary>
		///Initializes a connection to the database	
		/// </summary>       
        public DataAccessEntity()
        {

            acConnection = new SQLiteConnection();

            // connection string           
            acConnStr = ConfigurationManager.ConnectionStrings["sqlLiteDb"].ConnectionString;

            acConnection.ConnectionString = acConnStr;
            try
            {
                //open the connection
                acConnection.Open();

            }
            catch (SQLiteException e)
            {

                LogException(e);
                throw new Exception("Error Processing Request");
            }
        }

		/// <summary>
		/// Returns a recordset as a  result for a query on the open connection
		/// </summary>
		/// <param name="query"> Query to be Executed. </param>
		/// <returns> Result Dataset for the Query executed</returns>
        public DataSet Execute(string query)
        {
            var ds = new DataSet();
            using (acCmd = new SQLiteCommand(acConnection))
            {
                acCmd.CommandText = query;
                var adapter = new SQLiteDataAdapter(acCmd);
                adapter.Fill(ds);
                return ds;
            }
        }

		/// <summary>
		/// Returns a recordset as a result for a query on the open connection
		/// </summary>
		/// <param name="query"> Query to be Executed. </param>
		/// <returns> Result DataReader for the Query executed</returns>       
        public SQLiteDataReader ExecReader(string query)
        {
            using (acCmd = new SQLiteCommand(acConnection))
            {
                acCmd.CommandText = query;
                return acCmd.ExecuteReader();
            }
        }

		/// <summary>
		/// Executes the Input query and return the result set as list.
		/// </summary>
		/// <param name="query"> Query to be Executed. </param>
		/// <param name="Idflag"> Integer flag indicating the return Type to be Integer/String </param>
		/// <returns>  Array List based on Integer flag passed. </returns>       
        public string[] ExecReader(string query, int Idflag)
        {
            ArrayList alElements = new ArrayList();
            using (acCmd = new SQLiteCommand(acConnection))
            {
                acCmd.CommandText = query;

                SQLiteDataReader dr = acCmd.ExecuteReader();
                // loop through all the rows
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        if (Idflag == 1)
                            alElements.Add(dr.GetInt16(0) + "");
                        else
                            alElements.Add(dr.GetString(0));
                    }
                }
            }
            // convert arraylist to a string array
            string[] elements = (string[])alElements.ToArray(typeof(string));
            return elements;
        }

		/// <summary>
		/// Get Count of the resultset of Query Executed
		/// </summary>
		/// <param name="query"> Query to be Executed. </param>	
		/// <returns>Count of resultset </returns>           
        public int getCount(string query)
        {
            using (acCmd = new SQLiteCommand(acConnection))
            {
                acCmd.CommandText = query;
                var result = acCmd.ExecuteScalar();
                return int.Parse(result.ToString());
            }
        }

		/// <summary>
		/// Executes a query that does not return a result 
		/// </summary>
		/// <param name="query"> Query to be Executed. </param>	
		/// <returns>Count of rows affected </returns>                  
        public int ExecNonQuery(string query)
        {
            using (acCmd = new SQLiteCommand(acConnection))
            {

                acCmd.CommandText = query;
                return acCmd.ExecuteNonQuery();
            }
        }

		/// <summary>
		///  Executes a query that  not return a single row result set
		/// </summary>
		/// <param name="query"> Query to be Executed. </param>	
		/// <returns>single row result set </returns>                  
        public string ExecuteScalar(string query)
        {
            using (acCmd = new SQLiteCommand(acConnection))
            {

                acCmd.CommandText = query;
                return acCmd.ExecuteScalar().ToString();
            }
        }

		/// <summary>
		/// Closes the database conection
		/// </summary>        
        public void Dispose()
        {
            acConnection.Close();
        }

		/// <summary>
		///  Logs SQLiteExceptions
		/// </summary>
		/// <param name="sqlex">SQLiteException </param>	
        private static void LogException(SQLiteException sqlex)
        {
            LogFile log = new LogFile();

            string errorMessage;
            errorMessage = "Exception Number : " + sqlex.ErrorCode +
                         "(" + sqlex.Message + ") has occurred";


            log.Create(errorMessage);
        }

		/// <summary>
		///  Logs Exceptions
		/// </summary>
		/// <param name="ex">Exception </param>	
        private static void LogException(Exception ex)
        {
            string errorMessage;
            errorMessage = ex.Message + " has occurred";
            LogFile log = new LogFile();
            log.Create(errorMessage);
        }
    }
}
