using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Data.Common;
using System.ComponentModel;
using System.Data;

using System.Drawing;
using System.Windows.Forms;


namespace WinFormAction
{
    class MSSQL_Server
    {
        
        private SqlConnection Connector;


        static public List<string> GetDatabases(string host, string login, string password)
        {
            try
            {
                List<string> DataBases = new List<string>();
                SqlConnection Connector = new SqlConnection("Persist Security Info=False;Server=" + host + ";User Id=" + login + ";Password=" + password);
                Connector.Open();
                SqlCommand query = new SqlCommand(" SELECT name FROM sys.databases; ", Connector);
                SqlDataReader MyDataReader = query.ExecuteReader();
                while (MyDataReader.Read())
                {
                    DataBases.Add(MyDataReader.GetString(0));
                }
                Connector.Close();

                return DataBases;
            }
            catch (Exception e) { MessageBox.Show(e.Message); return null; }
        }
        static public List<string> GetServers()
        {
            List<string> _servers = new List<string>();
            //instance = System.Data.Common.DbDataSourceEnumerator.Instance.GetDataSources();
            //DataTable table = instance.GetDataSources();
            //foreach (DataRow row in table.Rows)
            //{
            //    if (row["InstanceName"].ToString() == "")
            //        _servers.Add(Convert.ToString(row["ServerName"]));
            //    else
            //        _servers.Add(Convert.ToString(row["ServerName"] + "" + row["InstanceName"]));
            //}
            return _servers;
        }
       
        public void Connection()
        {

            try
            {
                Connector = new SqlConnection(
                                                "Persist Security Info=False;Database=" + Program._configuration.settings.settings_ms_sql._database + 
                                                ";Server=" + Program._configuration.settings.settings_ms_sql._host + 
                                                ";User Id=" + Program._configuration.settings.settings_ms_sql._login + 
                                                ";Password=" + Program._configuration.settings.settings_ms_sql._password);
                Connector.Open();
                Connector.Close();
            }
            catch (Exception e)
            {
                Connector = null;
            }
        }
    }
}
