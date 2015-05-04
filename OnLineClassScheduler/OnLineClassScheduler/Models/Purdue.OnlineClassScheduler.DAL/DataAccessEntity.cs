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

        //Initializes a connection to the database
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

        //Returns a recordset as a  result for a query on the open connection
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

        //Returns a recordset as a  result for a query on the open connection
        public SQLiteDataReader ExecReader(string query)
        {
            using (acCmd = new SQLiteCommand(acConnection))
            {
                acCmd.CommandText = query;
                return acCmd.ExecuteReader();
            }
        }

        //Returns a recordset as a  result for a query on the open connection
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
        // Returns a Interger result for a query on the open connection
        public int getCount(string query)
        {
            using (acCmd = new SQLiteCommand(acConnection))
            {

                acCmd.CommandText = query;
                var result = acCmd.ExecuteScalar();
                return int.Parse(result.ToString());
            }
        }

        // Executes a query that does not return a result 
        public int ExecNonQuery(string query)
        {
            using (acCmd = new SQLiteCommand(acConnection))
            {

                acCmd.CommandText = query;
                return acCmd.ExecuteNonQuery();
            }
        }

        // Executes a query that does not return a result 
        public string ExecuteScalar(string query)
        {
            using (acCmd = new SQLiteCommand(acConnection))
            {

                acCmd.CommandText = query;
                return acCmd.ExecuteScalar().ToString();
            }
        }
        //Closes the database conection
        public void Dispose()
        {
            acConnection.Close();
        }


        private static void LogException(SQLiteException sqlex)
        {
            LogFile log = new LogFile();

            string errorMessage;
            errorMessage = "Exception Number : " + sqlex.ErrorCode +
                         "(" + sqlex.Message + ") has occurred";


            log.Create(errorMessage);
        }

        private static void LogException(Exception ex)
        {
            string errorMessage;
            errorMessage = ex.Message + " has occurred";
            LogFile log = new LogFile();
            log.Create(errorMessage);
        }
    }
}
