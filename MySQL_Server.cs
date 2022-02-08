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
        public string _database_creation;
        private string _query_insert_or_update_config = "INSERT INTO {0}.config (_parametr,_value) value ('{1}','{2}') " +
                                              "ON DUPLICATE KEY UPDATE _value = '{2}';";

        private string _query_select_config = "SELECT _parametr,_value FROM config";
        private string _query_select_user = "SELECT _nameVisibility,_type FROM {0}.users where {0}.users._login = '{1}' ";
        private string _query_create_db =
             "CREATE DATABASE {0};" +
             "    create table {0}.users" +
             "(" +
             "  _ID int (11) PRIMARY KEY AUTO_INCREMENT," +
             "	_login nvarchar(64) not null," +
             "	_nameVisibility nvarchar(64) not null," +
             "  _type nvarchar(64) not null " +
             ");" +
             "create table {0}.config" +
             "(" +
             "	_parametr nvarchar(64) not null PRIMARY KEY," +
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
             ");" +
            "" +
            "Insert INTO {0}.users (_login,_nameVisibility,_type) Value ('{1}','Administrator','admin');";
                  
        //+
        //    "GRANT ALL PRIVILEGES ON {0}.* TO '{1}'@'%';"

        static public List<string> GetDatabases(string host, string port, string login, string password)
        {
            try
            {
                List<string> DataBases = new List<string>();
                MySqlConnection connector = new MySqlConnection("Server=" + host + ";Port=" + port + ";Uid=" + login + ";Pwd=" + password);
                connector.Open();
                MySqlCommand query = new MySqlCommand(" SELECT SCHEMA_NAME AS `Database`" +
                                                      " FROM INFORMATION_SCHEMA.SCHEMATA", connector);
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
        public string[] _get_user()
        {
            try
            {
                _connector.Open();
                string[] user = new string[2];
                MySqlCommand _query = new MySqlCommand(_query_select_user.Replace("{0}", Program._configuration.settings.settings_my_sql._database)
                                                                         .Replace("{1}", Program._configuration.settings.settings_my_sql._login), _connector) ;
                MySqlDataReader _query_reader = _query.ExecuteReader();
                while (_query_reader.Read())
                {
                    user[0] = _query_reader[0].ToString();
                    user[1] = _query_reader[1].ToString();
                }
                _connector.Close();

                return user;
            }
            catch (Exception e)
            {
                
                MessageBox.Show(e.Message);
                return null;
            }
        }

        public bool Connection_database_test()
        {

            try
            {
                _connector = new MySqlConnection("Database=" + Program._configuration.settings.settings_my_sql._database + 
                                                 ";Server=" + Program._configuration.settings.settings_my_sql._host + ";Port=" + Program._configuration.settings.settings_my_sql._port + ";Uid=" + Program._configuration.settings.settings_my_sql._login + ";Pwd=" + Program._configuration.settings.settings_my_sql._password);
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
        public bool create_database()
        {
            try
            {
                if (Program._configuration.settings.settings_my_sql._database == "" || Program._configuration.settings.settings_my_sql._database == null)
                {
                    _connector = new MySqlConnection("Server=" + Program._configuration.settings.settings_my_sql._host + ";Port=" + Program._configuration.settings.settings_my_sql._port + ";Uid=" + Program._configuration.settings.settings_my_sql._login + ";Pwd=" + Program._configuration.settings.settings_my_sql._password);
                    _connector.Open();
                    MySqlCommand _query = new MySqlCommand(_query_create_db.Replace("{0}", _database_creation)
                                                                           .Replace("{1}", Program._configuration.settings.settings_my_sql._login), _connector);
                    _query.ExecuteNonQuery();
                    _connector.Close();
                }
                else
                {
                    _connector = new MySqlConnection("Database=" + Program._configuration.settings.settings_my_sql._database + ";Server=" + Program._configuration.settings.settings_my_sql._host + ";Port=" + Program._configuration.settings.settings_my_sql._port + ";Uid=" + Program._configuration.settings.settings_my_sql._login + ";Pwd=" + Program._configuration.settings.settings_my_sql._password);
                    _connector.Open();
                    MySqlCommand _query = new MySqlCommand(_query_create_db.Replace("{0}", Program._configuration.settings.settings_my_sql._database)
                                                                           .Replace("{1}", Program._configuration.settings.settings_my_sql._login), _connector);
                    _query.ExecuteNonQuery();
                    _connector.Close();
                }
                return true;
            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message);
                return false;
            }
        }

        public void select_data_admin()
        {
            
        }

        //public DataTable select_data_user(int user_id)
        //{

        //}
         
        public bool save_config_mssql()
        {
            try
            {
                _connector.Open();
                string[] host = Program._configuration.settings.settings_ms_sql._host.Split('\\');
                MessageBox.Show(host[0]);
                MySqlCommand _query = new MySqlCommand(_query_insert_or_update_config.Replace("{0}", Program._configuration.settings.settings_my_sql._database)
                                                                                     .Replace("{1}", "HOST_MSSQL")
                                                                                     .Replace("{2}", host[0]), _connector);
                _query.ExecuteNonQuery();
                _query = new MySqlCommand(_query_insert_or_update_config.Replace("{0}", Program._configuration.settings.settings_my_sql._database)
                                                                        .Replace("{1}", "OBJ_MSSQL")
                                                                        .Replace("{2}", host[1]), _connector);
                _query.ExecuteNonQuery();
                _query = new MySqlCommand(_query_insert_or_update_config.Replace("{0}", Program._configuration.settings.settings_my_sql._database)
                                                                        .Replace("{1}", "LOGN_MSSQL")
                                                                        .Replace("{2}", Program._configuration.settings.settings_ms_sql._login), _connector);
                _query.ExecuteNonQuery();
                _query = new MySqlCommand(_query_insert_or_update_config.Replace("{0}", Program._configuration.settings.settings_my_sql._database)
                                                                        .Replace("{1}", "PASS_MSSQL")
                                                                        .Replace("{2}", Program._configuration.settings.settings_ms_sql._password), _connector);
                _query.ExecuteNonQuery();
                _query = new MySqlCommand(_query_insert_or_update_config.Replace("{0}", Program._configuration.settings.settings_my_sql._database)
                                                                        .Replace("{1}", "DB_MSSQL")
                                                                        .Replace("{2}", Program._configuration.settings.settings_ms_sql._database), _connector);
                _query.ExecuteNonQuery();
                _connector.Close();
                return true;
            }
            catch (Exception e)
            {

                MessageBox.Show(e.Message);
                return false;
            }
        }
        public bool read_config_mssql()
        {
            try
            {
                _connector.Open();
                MySqlCommand _query = new MySqlCommand(_query_select_config, _connector);
                MySqlDataReader _query_reader = _query.ExecuteReader();
                while (_query_reader.Read())
                {
                    switch (_query_reader["_parametr"]) 
                    {
                        case "HOST_MSSQL":
                            Program._configuration.settings.settings_ms_sql._host = _query_reader["_value"].ToString();
                            break;
                        case "OBJ_MSSQL":
                            Program._configuration.settings.settings_ms_sql._host += "\\"+_query_reader["_value"].ToString();
                            break;
                        case "LOGN_MSSQL":
                            Program._configuration.settings.settings_ms_sql._login = _query_reader["_value"].ToString();
                            break;
                        case "PASS_MSSQL":
                            Program._configuration.settings.settings_ms_sql._password = _query_reader["_value"].ToString();
                            break;
                        case "DB_MSSQL":
                            Program._configuration.settings.settings_ms_sql._database = _query_reader["_value"].ToString();
                            break;
                    }
                }
                _connector.Close();
                
                return true;
             }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return false;
            }
        }

    } 

}
