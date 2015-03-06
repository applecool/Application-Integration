using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SQLite;
using System.Windows.Forms;

namespace Lab6
{
    class db : IDisposable
    {
        //Access connect scring
        string acConnStr;
        //Access Connection
        SQLiteConnection acConnection;
        SQLiteCommand acCmd;

        //Initializes a connection to the database
        public db()
        {
            string appPath = Application.StartupPath;
            acConnection = new SQLiteConnection();

            // connection string           
            acConnStr = "Data Source=" + Application.StartupPath + @"\..\..\..\ProgrammingLanguages.sqlite;";
            acConnection.ConnectionString = acConnStr;
            try
            {
                //open the connection
                acConnection.Open();
                acCmd = new SQLiteCommand(acConnection);
            }
            catch (SQLiteException e) { MessageBox.Show(e.Message); }
        }

        //Returns a resultset as a  result for a query on the open connection
        public SQLiteDataReader ExecReader(string query)
        {
            acCmd.CommandText = query;
            SQLiteDataReader dr = acCmd.ExecuteReader();
            return dr;
        }

        // Returns a count of resultset for a query on the open connection
        public int getCount(string query)
        {
            acCmd.CommandText = query;
            var result = acCmd.ExecuteScalar();
            return int.Parse(result.ToString());
        }

        // Executes a query that does  return a number of resultset
        public int ExecNonQuery(string query)
        {
            acCmd.CommandText = query;
            return acCmd.ExecuteNonQuery();
        }

        //Closes the database conection
        public void Dispose()
        {
            acConnection.Close();
        }
    }

}
