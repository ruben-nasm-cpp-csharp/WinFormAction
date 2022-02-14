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

        private string _query_delete_user = "REVOKE ALL PRIVILEGES, GRANT OPTION FROM '{1}'@'%';" +
                                            "DROP USER '{1}'@'%' ;" +
                                            "DELETE FROM {0}.users WHERE {0}.users._login = '{1}'";

        private string _query_create_user = "CREATE USER '{1}'@'%' IDENTIFIED BY '{3}';" +
                                            "GRANT SELECT ON {0}.users TO '{1}'@'%';" +
                                            "GRANT SELECT ON {0}.config TO '{1}'@'%';" +
                                            "GRANT SELECT ON {0}.barcodes_lst TO '{1}'@'%';" +
                                            "GRANT SELECT, INSERT ON {0}.barcodes_reg TO '{1}'@'%';" +
                                            "INSERT INTO {0}.users({0}.users._login, {0}.users._nameVisibility, {0}.users._type) " +
                                                                        "value('{1}','{2}','user');";

        private string _query_insert_or_update_config = "INSERT INTO {0}.config (_parametr,_value) value ('{1}','{2}') " +
                                              "ON DUPLICATE KEY UPDATE _value = '{2}';";
        
        private string _query_insert_barcode_reg = "INSERT INTO {0}.barcodes_reg (_barcode,_cashierIssued,_buyerReceived) value ({1},'{2}',{3}) ";//
        
        private string _query_insert_barcode = "INSERT INTO {0}.barcodes_lst (_value) value ('{1}') ";

        private string _query_select_barcode_user = "select bl._value from {0}.barcodes_reg br left join {0}.barcodes_lst bl on br._barcode = bl._ID where  br._buyerReceived = {1} ";

        private string _query_select_user_barcode = "select br._buyerReceived,br._cashierIssued from {0}.barcodes_reg br " +
                                                    "left join {0}.barcodes_lst  bl on br._barcode = bl._ID " +
            "                                       where bl._value = {1} ";/// <summary>
        /// ////////////////////////////////////
        /// </summary>

        private string _query_sum_barcode_user = "select COUNT({0}.barcodes_reg._barcode) from {0}.barcodes_reg where {0}.barcodes_reg._buyerReceived = '{1}' ";

        private string _query_sum_barcode_this = "select COUNT(br._barcode) from {0}.barcodes_reg br left join {0}.barcodes_lst bl on br._barcode = bl._ID  where bl._value = '{1}' ";

        private string _query_count_barcode = "SELECT COUNT(_value) FROM {0}.barcodes_lst";

        private string _query_select_this_barcode = "SELECT _ID FROM {0}.barcodes_lst where {0}.barcodes_lst._value = '{1}'";//

        private string _query_select_barcode = "SELECT _value as 'Код' FROM {0}.barcodes_lst";

        private string _query_select_config = "SELECT _parametr,_value FROM config";

        private string _query_select_user = "SELECT _nameVisibility,_type FROM {0}.users where {0}.users._login = '{1}' ";
        private string _query_select_user_all = "SELECT _login as 'Логин',_nameVisibility as 'Отображаемое имя', _type as 'Тип' FROM {0}.users ";

        private string _query_create_db =
             "CREATE DATABASE {0};" +
             "    create table {0}.users" +
             "("  +
             "	_login nvarchar(64) not null PRIMARY KEY," +
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
             "      _ID int (11)  PRIMARY KEY AUTO_INCREMENT," +
             "	    _barcode int not null," +
             "      _cashierIssued nvarchar(64) not null," +
             "	    _buyerReceived int not null," +
             "      Foreign Key(_barcode) REFERENCES {0}.barcodes_lst(_ID)," +
             "      Foreign Key(_cashierIssued) REFERENCES {0}.users(_login)" +
             ");" +
            "" +
            "Insert INTO {0}.users ({0}.users._login,{0}.users._nameVisibility,{0}.users._type) Value ('{1}','Administrator','admin');";
                  
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
                _connector.Close();
                MessageBox.Show(e.Message);
                return null;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="barcode"></param>
        /// <returns></returns>
        public string[] _get_user_barcode(string barcode)
        {
            try
            {
                _connector.Open();
                string[] result = new string[4];
                MySqlCommand _query = new MySqlCommand(_query_select_user_barcode.Replace("{0}", Program._configuration.settings.settings_my_sql._database)
                                                                                 .Replace("{1}", barcode), _connector);
                MySqlDataReader _query_reader = _query.ExecuteReader();
               
                while (_query_reader.Read())
                {
                    DataRow[] rekal = Program._MSSQL.get_byers_kayala().Select("Code = " + _query_reader[0].ToString());
                    result[0] = rekal[0][2].ToString();
                    result[1] = rekal[0][3].ToString();
                    result[2] = rekal[0][4].ToString();
                    result[3] = _query_reader[1].ToString();
                }
                _connector.Close();

                return result;
            }
            catch (Exception e)
            {
                _connector.Close();
                MessageBox.Show(e.Message);
                return null;
            }
        }

        public DataTable _get_barcode()
        {
            DataTable res = new DataTable();
            try
            {
                _connector.Open();

                MySqlCommand _query = new MySqlCommand(_query_select_barcode.Replace("{0}", Program._configuration.settings.settings_my_sql._database), _connector);
                MySqlDataAdapter _query_reader = new MySqlDataAdapter(_query);
                _query_reader.Fill(res);
                DataTable buf = new DataTable();
                buf.Columns.Add("Код", typeof(string));
                foreach(DataRow resrow in res.Rows)
                {
                    buf.Rows.Add(resrow[0].ToString());
                }
                 
                _connector.Close();
                return buf;

            }
            catch (Exception e)
            {

                MessageBox.Show(e.Message);
                _connector.Close();
                return null;
            }
        }

        public DataTable _get_user_dt()
        {
            DataTable users= new DataTable();
            try
            {
                
                _connector.Open();
                MySqlCommand _query = new MySqlCommand(_query_select_user_all.Replace("{0}", Program._configuration.settings.settings_my_sql._database), _connector);
                MySqlDataAdapter _query_reader = new MySqlDataAdapter(_query);
                _query_reader.Fill(users);
                _connector.Close();

                return users;
            }
            catch (Exception e)
            {
                _connector.Close();
                MessageBox.Show(e.Message);
                return users;
            }
        }
        public int _get_count_barcode_user(int userID)
        {
            try
            {
                _connector.Open();

                MySqlCommand _query = new MySqlCommand(_query_sum_barcode_user.Replace("{0}", Program._configuration.settings.settings_my_sql._database)
                                                                              .Replace("{1}",userID.ToString()), _connector);
                MySqlDataReader _query_reader = _query.ExecuteReader();
                int _count = 0;
                while (_query_reader.Read())
                    _count = Convert.ToInt32(_query_reader[0]);


                _connector.Close();
                return _count;

            }
            catch (Exception e)
            {

                MessageBox.Show(e.Message);
                _connector.Close();
                return 1;
            }
        }

        public DataTable _get_user_barcode_reg(int userid)
        {
            DataTable res = new DataTable();
            try
            {
                _connector.Open();
                
                MySqlCommand _query = new MySqlCommand(_query_select_barcode_user.Replace("{0}", Program._configuration.settings.settings_my_sql._database)
                                                                                 .Replace("{1}", userid.ToString()), _connector);
                MySqlDataAdapter _query_reader = new MySqlDataAdapter(_query);
                _query_reader.Fill(res);


                _connector.Close();
                return res;

            }
            catch (Exception e)
            {

                MessageBox.Show(e.Message);
                _connector.Close();
                return null ;
            }
        }

        

        public int _get_count_barcode_reg(int barcode)
        {
            try
            {
                _connector.Open();
                
                MySqlCommand _query = new MySqlCommand(_query_sum_barcode_this.Replace("{0}", Program._configuration.settings.settings_my_sql._database)
                                                                              .Replace("{1}", barcode.ToString()), _connector);
                MySqlDataReader _query_reader = _query.ExecuteReader();
                int _count = 0;
                while (_query_reader.Read())
                    _count = Convert.ToInt32(_query_reader[0]);


                _connector.Close();
                return _count;

            }
            catch (Exception e)
            {

                MessageBox.Show(e.Message);
                _connector.Close();
                return 0;
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
                _connector.Close();
                MessageBox.Show(e.Message);
                return false;
            }
        }

       

        public bool insert_barcode_admin(string[] _barcodes)
        {
            int i = 0;
            try
            {
                
                string[] host = Program._configuration.settings.settings_ms_sql._host.Split('\\');
                MySqlCommand _query1 = new MySqlCommand(_query_select_barcode.Replace("{0}", Program._configuration.settings.settings_my_sql._database), _connector);
                

                foreach (string _barcode in _barcodes)
                {
                    if (_barcode != "" && _barcode != null)
                    {
                        _connector.Open();
                        MySqlDataReader _query_reader1 = _query1.ExecuteReader();
                        while (_query_reader1.Read())
                        {
                            if (_barcode == _query_reader1[0].ToString())
                                goto sory_this; //
                        }
                        _connector.Close();
                        _connector.Open();
                        MySqlCommand _query = new MySqlCommand(_query_insert_barcode.Replace("{0}", Program._configuration.settings.settings_my_sql._database)
                                                                                             .Replace("{1}", _barcode), _connector);
                    
                        _query.ExecuteNonQuery();
                        
                        i++;
                        sory_this:;//
                        _connector.Close();
                    }
               
                }
                MessageBox.Show("Успешно добавленно " + i + "штрих-кодов");
                _connector.Close();
                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show("Успешно добавленно " + i + "штрих-кодов");
                MessageBox.Show(e.Message);
                _connector.Close();
                return false;
            }
        }

        public bool insert_barcode_user(string _barcode,string _userID)
        {
            int i = 0;
            try
            {
                _connector.Open();
               
                MySqlCommand _query1 = new MySqlCommand(_query_select_this_barcode.Replace("{0}", Program._configuration.settings.settings_my_sql._database)
                                                                                                        .Replace("{1}", _barcode), _connector);
                string barcodeid ="нет";
                        MySqlDataReader _query_reader = _query1.ExecuteReader();
                        while (_query_reader.Read())
                        {
                            barcodeid = _query_reader[0].ToString();
                        }
                _connector.Close();
                _connector.Open();
                MySqlCommand _query = new MySqlCommand(_query_insert_barcode_reg.Replace("{0}", Program._configuration.settings.settings_my_sql._database)
                                                                                         .Replace("{1}", barcodeid)
                                                                                         .Replace("{2}", Program._configuration.settings.settings_my_sql._login)
                                                                                          .Replace("{3}", _userID), _connector);

                        _query.ExecuteNonQuery();
                MessageBox.Show("Штрих-код добавлен к выбранному пользователю");
                _connector.Close();
                return true;

            }
            catch (Exception e)
            {
                MessageBox.Show("Ошибка штрих-код не был занесен в базу!");
                MessageBox.Show(e.Message);
                _connector.Close();
                return false;
            }
        }

        public int count_barcode_admin()
        {
            try
            {
                _connector.Open();
                
                        MySqlCommand _query = new MySqlCommand(_query_count_barcode.Replace("{0}", Program._configuration.settings.settings_my_sql._database), _connector);
                MySqlDataReader _query_reader = _query.ExecuteReader();
                int _count = 0;
                while (_query_reader.Read())
                    _count =Convert.ToInt32( _query_reader[0]);


                        _connector.Close();
                return _count;
                
            }
            catch (Exception e)
            {
                
                MessageBox.Show(e.Message);
                _connector.Close();
                return 0;
            }
        }

        public bool create_user_admin(string user_name,string user_vibility_name,string password)
        {
            try
            {
                _connector.Open();

                MySqlCommand _query = new MySqlCommand(_query_create_user.Replace("{0}", Program._configuration.settings.settings_my_sql._database)
                                                                        .Replace("{1}", user_name)
                                                                        .Replace("{2}", user_vibility_name)
                                                                        .Replace("{3}", password), _connector);
                _query.ExecuteNonQuery();
                


                _connector.Close();
                MessageBox.Show("Пользователь создан!");
                return true;

            }
            catch (Exception e)
            {
                _connector.Close();
                MessageBox.Show(e.Message);
                MessageBox.Show("Ошибка вероятно этот пользователь уже существует!");
                return false;
            }
        }

        public bool update_user_admin(string old_user_name, string user_name, string user_vibility_name, string password)
        {
            try
            {
                _connector.Open();



                MySqlCommand _query = new MySqlCommand(_query_create_user.Replace("{0}", Program._configuration.settings.settings_my_sql._database)
                                                                        .Replace("{1}", user_name)
                                                                        .Replace("{2}", user_vibility_name)
                                                                        .Replace("{3}", password), _connector);
                _query.ExecuteNonQuery();



                _connector.Close();
                return true;

            }
            catch (Exception e)
            {
                _connector.Close();
                MessageBox.Show(e.Message);
                return false;
            }
        }

        public bool delete_user_admin(string user_name)
        {
            try
            {
                _connector.Open();

                MySqlCommand _query = new MySqlCommand(_query_delete_user.Replace("{0}", Program._configuration.settings.settings_my_sql._database)
                                                                        .Replace("{1}", user_name), _connector);
                _query.ExecuteNonQuery();



                _connector.Close();
                MessageBox.Show("Пользователь удален!");
                return true;

            }
            catch (Exception e)
            {
                _connector.Close();
                MessageBox.Show(e.Message);
                return false;
            }
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
                
                MySqlCommand _query = new MySqlCommand(_query_insert_or_update_config.Replace("{0}", Program._configuration.settings.settings_my_sql._database)
                                                                                     .Replace("{1}", "MSSQL_HOST")
                                                                                     .Replace("{2}", host[0]), _connector);
                _query.ExecuteNonQuery();
                _query = new MySqlCommand(_query_insert_or_update_config.Replace("{0}", Program._configuration.settings.settings_my_sql._database)
                                                                        .Replace("{1}", "MSSQL_OBJ")
                                                                        .Replace("{2}", host[1]), _connector);
                _query.ExecuteNonQuery();
                _query = new MySqlCommand(_query_insert_or_update_config.Replace("{0}", Program._configuration.settings.settings_my_sql._database)
                                                                        .Replace("{1}", "MSSQL_LOGN")
                                                                        .Replace("{2}", Program._configuration.settings.settings_ms_sql._login), _connector);
                _query.ExecuteNonQuery();
                _query = new MySqlCommand(_query_insert_or_update_config.Replace("{0}", Program._configuration.settings.settings_my_sql._database)
                                                                        .Replace("{1}", "MSSQL_PASS")
                                                                        .Replace("{2}", Program._configuration.settings.settings_ms_sql._password), _connector);
                _query.ExecuteNonQuery();
                _query = new MySqlCommand(_query_insert_or_update_config.Replace("{0}", Program._configuration.settings.settings_my_sql._database)
                                                                        .Replace("{1}", "MSSQL_DB")
                                                                        .Replace("{2}", Program._configuration.settings.settings_ms_sql._database), _connector);
                _query.ExecuteNonQuery();
                
                _connector.Close();
                return true;
            }
            catch (Exception e)
            {
                _connector.Close();
                MessageBox.Show(e.Message);
                return false;
            }
        }
        public bool save_config_action()
        {
            try
            {
                _connector.Open();
                MySqlCommand _query = new MySqlCommand(_query_insert_or_update_config.Replace("{0}", Program._configuration.settings.settings_my_sql._database)
                                                                       .Replace("{1}", "ACTN_BGN_DT")
                                                                       .Replace("{2}", Program._configuration.settings.settings_action.data_begin), _connector);
                _query.ExecuteNonQuery();
                _query = new MySqlCommand(_query_insert_or_update_config.Replace("{0}", Program._configuration.settings.settings_my_sql._database)
                                                                        .Replace("{1}", "ACTN_END_DT")
                                                                        .Replace("{2}", Program._configuration.settings.settings_action.data_end), _connector);
                _query.ExecuteNonQuery();
                _query = new MySqlCommand(_query_insert_or_update_config.Replace("{0}", Program._configuration.settings.settings_my_sql._database)
                                                                        .Replace("{1}", "ACTN_CODE_COST")
                                                                        .Replace("{2}", Convert.ToString(Program._configuration.settings.settings_action.barcode_cost)), _connector);
                _query.ExecuteNonQuery();
                _connector.Close();
                return true;

            }
            catch (Exception e)
            {
                _connector.Close();
                MessageBox.Show(e.Message);
                return false;
            }
        }
        

          public bool read_config_action()
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
                        case "ACTN_BGN_DT":
                            Program._configuration.settings.settings_action.data_begin = _query_reader["_value"].ToString();
                            break;
                        case "ACTN_END_DT":
                            Program._configuration.settings.settings_action.data_end = _query_reader["_value"].ToString();
                            break;
                        case "ACTN_CODE_COST":
                            Program._configuration.settings.settings_action.barcode_cost = Convert.ToUInt32(_query_reader["_value"].ToString());
                            break;

                    }
                    

                   
                }
                _connector.Close();
                return true;
            }
            catch (Exception e)
            {
                _connector.Close();
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
                        case "MSSQL_HOST":
                            Program._configuration.settings.settings_ms_sql._host = _query_reader["_value"].ToString();
                            break;
                        case "MSSQL_OBJ":
                            Program._configuration.settings.settings_ms_sql._host += "\\"+_query_reader["_value"].ToString();
                            break;
                        case "MSSQL_LOGN":
                            Program._configuration.settings.settings_ms_sql._login = _query_reader["_value"].ToString();
                            break;
                        case "MSSQL_PASS":
                            Program._configuration.settings.settings_ms_sql._password = _query_reader["_value"].ToString();
                            break;
                        case "MSSQL_DB":
                            Program._configuration.settings.settings_ms_sql._database = _query_reader["_value"].ToString();
                            break;
                       
                    }
                }
                _connector.Close();
                
                return true;
             }
            catch (Exception e)
            {
                _connector.Close();
                MessageBox.Show(e.Message);
                return false;
            }
        }

    } 

}
