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
                                    "       co.Code,"+
                                    "		SUM([mo].[amount_outcome]) as 'Сумма продажи',"+ 
                                    "		co.Name as Покупатель ,"+
                                    "		co.phone as Телефон,"+
                                    "		co.email as Email,"+
                                    "		co.comment as Коментарий"+
                                    " FROM "+
                                    "    [reg_goods_rests] mo"+
                                    "    left join[dbo].[lst_contractors] co"+
                                    "             on"+
                                    "                [mo].[contractor] =co.Code"+
                                    " WHERE "+
                                    "   ("+
                                    "       [mo].[DateTime] between '{0}'"+
                                    "       and '{1}'"+
                                    "    )"+
                                    "   AND"+
                                    "   ("+
                                    "       [mo].[operation] IN  (4,5,10,11)"+
                                    "	)"+
                                    "	AND"+
                                    "    ("+
                                    "       [mo].[contractor] is not null"+
                                    "	 )"+
                                    " GROUP BY "+
                                    "       co.Code, " +
                                    "       co.Name ,"+
                                    "		co.phone ,"+
                                    "		co.email ,"+
                                    "		co.comment"+
                                    " ORDER by co.Name ";//format datetime '2021-01-10 23:59:59'
        private SqlConnection _connector;


        static public List<string> GetDatabases(string host, string login, string password)
        {
            try
            {
                List<string> DataBases = new List<string>();
                SqlConnection _connector = new SqlConnection("Persist Security Info=False;Server=" + host + ";User Id=" + login + ";Password=" + password);
                _connector.Open();
                SqlCommand query = new SqlCommand(" SELECT name FROM sys.databases; ", _connector);
                SqlDataReader MyDataReader = query.ExecuteReader();
                while (MyDataReader.Read())
                {
                    DataBases.Add(MyDataReader.GetString(0));
                }
                _connector.Close();

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
        


        public bool Connection_test()
        {

            try
            {
                _connector = new SqlConnection(
                                                "Persist Security Info=False;Database=" + Program._configuration.settings.settings_ms_sql._database + 
                                                ";Server=" + Program._configuration.settings.settings_ms_sql._host + 
                                                ";User Id=" + Program._configuration.settings.settings_ms_sql._login + 
                                                ";Password=" + Program._configuration.settings.settings_ms_sql._password);
                _connector.Open();
               
                
                _connector.Close();
                return true;
            }
            catch (Exception e)
            {
                _connector = null;
                MessageBox.Show(e.Message);
                return false;
            }
        }


        public bool Connection_database_test()
        {

            try
            {
                _connector = new SqlConnection(
                                                "Persist Security Info=False;Database=" + Program._configuration.settings.settings_ms_sql._database +
                                                ";Server=" + Program._configuration.settings.settings_ms_sql._host +
                                                ";User Id=" + Program._configuration.settings.settings_ms_sql._login +
                                                ";Password=" + Program._configuration.settings.settings_ms_sql._password);
                _connector.Open();
                SqlCommand _query = new SqlCommand(SQL_Query.Replace("{0}", Program._configuration.settings.settings_action.data_begin)
                                                            .Replace("{1}", Program._configuration.settings.settings_action.data_end), _connector);
                _query.ExecuteNonQuery();
                _connector.Close();
                return true;
            }
            catch (Exception e)
            {
                _connector = null;
                MessageBox.Show(e.Message);
                return false;
            }
        }
        public DataTable get_byers_kayala()
        {

            try
            {
                _connector = new SqlConnection(
                                                "Persist Security Info=False;Database=" + Program._configuration.settings.settings_ms_sql._database +
                                                ";Server=" + Program._configuration.settings.settings_ms_sql._host +
                                                ";User Id=" + Program._configuration.settings.settings_ms_sql._login +
                                                ";Password=" + Program._configuration.settings.settings_ms_sql._password);
                _connector.Open();
                SqlCommand _query = new SqlCommand(SQL_Query.Replace("{0}", Program._configuration.settings.settings_action.data_begin)
                                                            .Replace("{1}", Program._configuration.settings.settings_action.data_end), _connector);
                SqlDataAdapter _adapter = new SqlDataAdapter(_query);
                DataSet _ds_result = new DataSet();
                _adapter.Fill(_ds_result);
                _connector.Close();
                return _ds_result.Tables[0];
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return null;
            }
        }
    }
}
