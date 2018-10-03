using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace ConsoleApp4
{
    class DBConnect
    {
        //private MySqlConnection connection;
        //private string server;
        //private string database;
        //private string uid;
        //private string password;
        //private string port;

       // public DBConnect()
        //{
        //    server = "automap.cxnllsgrt5yp.us - west - 2.rds.amazonaws.com";
        //    database = "Capital_Chrysler_Jeep_Dodge_Ram_AutoMap";
        //    uid = "rfid";
        //    password = "rfid_tag";
            
        //    string connectionString;
        //    connectionString = "server=automap.cxnllsgrt5yp.us-west-2.rds.amazonaws.com;uid=rfid;pwd=rfid_tag;database=Capital_Chrysler_Jeep_Dodge_Ram_AutoMap";
            //server=automap.cxnllsgrt5yp.us-west-2.rds.amazonaws.com;uid=rfid;pwd=rfid_tag;database=Capital_Chrysler_Jeep_Dodge_Ram_AutoMap
        //    connection = new MySqlConnection(connectionString);
        //}





    }

    class Program
    {
        static void Main(string[] args)
        {
            MySqlConnection connection = null;
            MySqlCommand cmd = null;
            MySqlDataReader sqlRdr = null;
            string connStr = "server=automap.cxnllsgrt5yp.us-west-2.rds.amazonaws.com;uid=rfid;pwd=rfid_tag;database=Capital_Chrysler_Jeep_Dodge_Ram_AutoMap";
            string somethingToProve;
            string sqlStr = "";


            connection = new MySqlConnection(connStr);
            connection.Open();
            Console.WriteLine("Theoretically this worked.");
            sqlStr = "SELECT VIN FROM Capital_Chrysler_Jeep_Dodge_Ram_AutoMap.AutoMap;";
            cmd = new MySqlCommand(sqlStr, connection);
            sqlRdr = cmd.ExecuteReader();
            while (sqlRdr.Read())
            {
                somethingToProve = sqlRdr.GetString("VIN");
                Console.WriteLine(somethingToProve);
            }




                //somethingToProve = 
                connection.Close();
            
            Console.ReadKey();
        }
    }
}
