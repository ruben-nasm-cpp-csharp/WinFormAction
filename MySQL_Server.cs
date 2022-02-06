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
        private MySqlConnection _connector;

        private string _query_create_db =
             "CREATE DATABASE {0};" +
             "    create table {0}.users" +
             "(" +
             "  _ID int (11) PRIMARY KEY AUTO_INCREMENT," +
             "	_login nvarchar(64) not null," +
             "	_nameVisibility nvarchar(64) not null" +
             "   " +
             ");" +
             "create table {0}.config" +
             "(" +
             "    _ID int (11)  PRIMARY KEY AUTO_INCREMENT," +
             "	_parametr nvarchar(64) not null," +
             "	_value nvarchar(64) not null" +
             "    " +
             ");" +
             "create table {0}.barcodes_lst" +
             "(" +
             "    _ID int (11)  PRIMARY KEY AUTO_INCREMENT," +
             "	_value nvarchar(64) not null" +
             "    " +
             ");" +
             "create table {0}.barcodes_reg" +
             "(" +
             "    _ID int (11)  PRIMARY KEY AUTO_INCREMENT," +
             "	_barcode int not null," +
             "    _cashierIssued int not null," +
             "	_buyerReceived int not null," +
             "    Foreign Key(_barcode) REFERENCES {0}.barcodes_lst(_ID)," +
             "    Foreign Key(_cashierIssued) REFERENCES {0}.users(_ID)" +
             ");";
                  
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
                _connector = new MySqlConnection("Database=" + Program._configuration.settings.settings_my_sql._database + ";Server=" + Program._configuration.settings.settings_my_sql._host + ";Port=" + Program._configuration.settings.settings_my_sql._port + ";Uid=" + Program._configuration.settings.settings_my_sql._login + ";Pwd=" + Program._configuration.settings.settings_my_sql._password);
                _connector.Open();
                _connector.Close();
            }
            catch (Exception e)
            {
                _connector = null;
            }
        }
        public void create_database()
        {
            
                if (Program._configuration.settings.settings_my_sql._database == "" || Program._configuration.settings.settings_my_sql._database == null)
                {
                    _connector = new MySqlConnection("Server=" + Program._configuration.settings.settings_my_sql._host + ";Port=" + Program._configuration.settings.settings_my_sql._port + ";Uid=" + Program._configuration.settings.settings_my_sql._login + ";Pwd=" + Program._configuration.settings.settings_my_sql._password);
                    _connector.Open();
                    MySqlCommand _query = new MySqlCommand(_query_create_db.Replace("{0}", "ActionDataBase"), _connector);
                    MessageBox.Show(_query.ExecuteNonQuery().ToString());
                    _connector.Close();
                }
                else
                {
                    
                }
           
        }
    } 

}
