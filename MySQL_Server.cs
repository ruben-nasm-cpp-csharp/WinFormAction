using System;
using System.Collections.Generic;
using System.Text;
using MySql.Data.MySqlClient;


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WinFormAction
{
    
    class MySQL_Server
    {
        private string host;
        private string port;
        private string password;
        private string login;
        private string provider;
        private string database;
        private MySqlConnection Connector;

        public MySQL_Server(string host, string port, string login, string provider, string password, string database)
        {
            this.host = host;
            this.port = port;
            this.provider = provider;
            this.login = login;
            this.password = password;
            this.database = database;
        }

        static public List<string> GetDatabases(string host, string port, string login, string password)
        {
            try
            {
                List<string> DataBases = new List<string>();
                MySqlConnection Connector = new MySqlConnection("Server=" + host + ";Port=" + port + ";Uid=" + login + ";Pwd=" + password);
                Connector.Open();
                MySqlCommand query = new MySqlCommand(" SELECT SCHEMA_NAME AS `Database`" +
                                                      " FROM INFORMATION_SCHEMA.SCHEMATA" +
                                                      " WHERE SCHEMA_NAME LIKE '%_db%'; ", Connector);
                MySqlDataReader MyDataReader = query.ExecuteReader();
                while (MyDataReader.Read())
                {
                    DataBases.Add(MyDataReader.GetString(0));
                }
                Connector.Close();

                return DataBases;
            }
            catch(Exception e) { MessageBox.Show(e.Message); return null; }
        }

        public void Connection()
        {
            
            try {
                Connector = new MySqlConnection("Database="+this.database+";Data Source="+this.host+":"+this.port+";User Id="+this.login+";Password="+this.password);
                Connector.Open();
                Connector.Close();
            }
            catch(Exception e) 
            {
                Connector = null;
            }
        }

    } 

}
