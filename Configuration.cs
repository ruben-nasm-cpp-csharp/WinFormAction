using System;
using System.Collections.Generic;
using System.Text;
using System.Configuration;
using System.Data;
using System.IO;


namespace WinFormAction
{
    class configuration
    {
        public configuration()
        { 
            settings = new settings_struct();
            settings.settings_ms_sql = new ms_sql();
            settings.settings_my_sql = new my_sql();
          
        }

        public settings_struct settings; 
        
        public struct settings_struct
        {
            public my_sql settings_my_sql;
            public ms_sql settings_ms_sql;
        }
        
        public struct my_sql
        {
            public string _host;
            public string _port;
            public string _database;
            public string _login;
            public string _password;

        }
        
        public struct ms_sql
        {
            public string _host;
            public string _database;
            public string _login;
            public string _password;
        }
        
        //Read file configuration in struct settings
        public int read_setting()
        {
            try
            {
                DataSet config = new DataSet();
                config.ReadXml(".\\ApplicationSettings.xml");
                Program._configuration.settings.settings_my_sql._host = config.Tables[0].Rows[0][0].ToString();
                Program._configuration.settings.settings_my_sql._port = config.Tables[0].Rows[0][1].ToString();
                Program._configuration.settings.settings_my_sql._database = config.Tables[0].Rows[0][2].ToString();
                
                return 0;
                
            }
            catch 
            {
                return 2;
            }
        }
        //Write struct settings in file configuration 
        public int write_settings()
        {
            try
            {
                Program._MySQL.Connection();
                Program._MySQL.save_config_mssql();
                DataTable settings_mysql = new DataTable();
                settings_mysql.Columns.Add("host");
                settings_mysql.Columns.Add("port");
                settings_mysql.Columns.Add("database");
                settings_mysql.Rows.Add(Program._configuration.settings.settings_my_sql._host, 
                                        Program._configuration.settings.settings_my_sql._port, 
                                        Program._configuration.settings.settings_my_sql._database);
                DataSet config = new DataSet();
                config.Tables.Add(settings_mysql);
                config.WriteXml(".\\ApplicationSettings.xml");
                
                return 0;

            }
            catch 
            {
                return 1;
            }

        }

    }
}
