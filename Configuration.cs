using System;
using System.Collections.Generic;
using System.Text;
using System.Configuration;


namespace WinFormAction
{
    class configuration
    {
        public configuration(string path_config)
        {
            settings = new settings_struct();
            settings.settings_ms_sql = new ms_sql();
            settings.settings_my_sql = new my_sql();
            settings.path_config = path_config;
        }

        public settings_struct settings; 
        
        public struct settings_struct
        {
            public string path_config;
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
                var app_settings = ConfigurationManager.AppSettings;

                settings.settings_ms_sql._host = app_settings["MS_SQL_HOST"];
                settings.settings_ms_sql._database = app_settings["MS_SQL_DATABASE"];
                settings.settings_my_sql._host = app_settings["My_SQL_HOST"];
                settings.settings_my_sql._port = app_settings["My_SQL_PORT"];
               
                settings.settings_my_sql._database = app_settings["My_SQL_DATABASE"];
                return 0;
                
            }
            catch (ConfigurationErrorsException)
            {
                return 2;
            }
        }
        //Write struct settings in file configuration 
        public int write_settings()
        {
            try
            {
                var app_settings = ConfigurationManager.AppSettings;
                app_settings.Add("MS_SQL_HOST", settings.settings_ms_sql._host);
                app_settings.Add("MS_SQL_DATABASE", settings.settings_ms_sql._database);
                app_settings.Add("My_SQL_HOST", settings.settings_my_sql._host);
                app_settings.Add("My_SQL_PORT", settings.settings_my_sql._port);
                
                app_settings.Add("My_SQL_DATABASE", settings.settings_my_sql._database);

                return 0;

            }
            catch (ConfigurationErrorsException)
            {
                return 1;
            }

        }

    }
}
