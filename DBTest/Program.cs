using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using WoxRejseplan;

namespace DBTest
{
    class Program
    {
        static void Main(string[] args)
        {
            string connectionString = 
                @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\lord_\Desktop\Projects\2Semester\SWC\WoxRejseplan\WoxRejseplan\WoxDB.accdb";
            string sqlString = "SELECT * FROM RejseplanenStoppesteder";

            using (OleDbConnection connection =
                new OleDbConnection(connectionString))
            {
                OleDbCommand cmd = new OleDbCommand(sqlString, connection);

                try
                {
                    connection.Open();

                    using (OleDbDataReader rdr = cmd.ExecuteReader())
                    {
                        while (rdr.Read())
                        {
                            Console.WriteLine(rdr.GetValue(0));
                            Console.WriteLine(rdr.GetValue(1));
                            
                        }
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                    throw;
                }
            }
            Console.ReadKey();
        }
    }
}
