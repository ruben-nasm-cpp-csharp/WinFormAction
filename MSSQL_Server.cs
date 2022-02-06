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
        private string SQL_Query =  "SELECT"+
                                    "        SUM([mo].[quantity]) as Количество,"+
                                    "		SUM([mo].[amount_outcome]) as Суммапродажи,"+ 
                                    "		co.Name as Покупатель ,"+
                                    "		co.phone as Телефон,"+
                                    "		co.email as Email,"+
                                    "		co.comment as Коментарий"+
                                    "FROM"+
                                    "    reg_goods_rests mo"+
                                    "    left join[dbo].[lst_contractors]"+
                                    "        co"+
                                    "             on"+
                                    "                [mo].[contractor] =co.Code"+
                                    "WHERE"+
                                    "   ("+
                                    "       [mo].[DateTime] between '2021-01-10 23:59:59'"+
                                    "       and '2022-02-03 23:59:59'"+
                                    "    )"+
                                    "   AND"+
                                    "   ("+
                                    "       [mo].[operation] IN  (4,5,10,11)"+
                                    "	)"+
                                    "	AND"+
                                    "    ("+
                                    "       [mo].[contractor] is not null"+
                                    "	 )"+
                                    "GROUP BY"+
                                    "        co.Name ,"+
                                    "		co.phone ,"+
                                    "		co.email ,"+
                                    "		co.comment"+
                                    "ORDER by co.Name";
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
        


        public void Connection_test()
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
                MessageBox.Show(e.Message);
            }
        }


        public void Connection_database_test()
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
                MessageBox.Show(e.Message);
            }
        }
    }
}
