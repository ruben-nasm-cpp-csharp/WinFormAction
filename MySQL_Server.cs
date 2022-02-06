using System;
using System.Collections.Generic;
using System.Text;
using MySql.Data.MySqlClient;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace WinFormAction
{
    
    class MySQL_Server
    {
        
       
        private MySqlConnection connector;

       

        static public List<string> GetDatabases(string host, string port, string login, string password)
        {
            try
            {
                List<string> DataBases = new List<string>();
                MySqlConnection connector = new MySqlConnection("Server=" + host + ";Port=" + port + ";Uid=" + login + ";Pwd=" + password);
                connector.Open();
                MySqlCommand query = new MySqlCommand(" SELECT SCHEMA_NAME AS `Database`" +
                                                      " FROM INFORMATION_SCHEMA.SCHEMATA" +
                                                      " WHERE SCHEMA_NAME LIKE '%_db%'; ", connector);
                MySqlDataReader MyDataReader = query.ExecuteReader();
                while (MyDataReader.Read())
                {
                    DataBases.Add(MyDataReader.GetString(0));
                }
                connector.Close();

                return DataBases;
            }
            catch (Exception e) { MessageBox.Show(e.Message); return null; }
        }

        public void Connection()
        {

            try
            {
                connector = new MySqlConnection("Database=" + Program._configuration.settings.settings_my_sql._database + ";Data Source=" + Program._configuration.settings.settings_my_sql._host + ":" + Program._configuration.settings.settings_my_sql._port + ";User Id=" + Program._configuration.settings.settings_my_sql._login + ";Password=" + Program._configuration.settings.settings_ms_sql._password);
                connector.Open();
                connector.Close();
            }
            catch (Exception e)
            {
                connector = null;
            }
        }

    } 

}
