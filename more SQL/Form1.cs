using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Encrypt.Decrypt.Library;

// This is the code for your desktop app.
// Press Ctrl+F5 (or go to Debug > Start Without Debugging) to run your app.

namespace more_SQL
{
    public partial class Form1 : Form
    {
        public Form1()
        {

            

            InitializeComponent();

            MySqlDataAdapter mySqlDataAdapter;
            MySqlConnection connection = null;


            MySqlCommand cmd = null;
            MySqlDataReader sqlRdr = null;


            string connStr = AutoMap_Crypt.Decrypt(@"IfdWvr7g / AMMaXAvBBXjsRIOn3 +/ P8HLjbCjIOwSUFhilKE2Bc + 7qSxJe1UxVRKm7AlmWqKMaOYyg7HpPfYV79Auwj0u0oC + XOidiIrsqYtNGd4njyAS6g ==");
            //string somethingToProve;
            string sqlStr = "";


            connection = new MySqlConnection(connStr);
            connection.Open();

            sqlStr = "SELECT * FROM Capital_Chrysler_Jeep_Dodge_Ram_AutoMap.AutoMap;";
            //cmd = new MySqlCommand(sqlStr, connection);
            mySqlDataAdapter = new MySqlDataAdapter(sqlStr, connection);
            DataSet DS = new DataSet();
            mySqlDataAdapter.Fill(DS);
            dataGridView1.DataSource = DS.Tables[0];
            connection.Close();

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Click on the link below to continue learning how to build a desktop app using WinForms!
            System.Diagnostics.Process.Start("http://aka.ms/dotnet-get-started-desktop");

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Thanks!");
        }
    }
}
