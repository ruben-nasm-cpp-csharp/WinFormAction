using System;
using System.Windows.Forms;

namespace WinFormAction
{
    static class Program
    {
        public static MSSQL_Server _MSSQL;
        public static MySQL_Server _MySQL;
        public static configuration _configuration;
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            try
            {
                _configuration = new configuration();
                _MySQL = new MySQL_Server();
                _MSSQL = new MSSQL_Server();
                Application.SetHighDpiMode(HighDpiMode.SystemAware);
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                if (_configuration.read_setting() == 0)
                    Application.Run(new auth());
                else
                    Application.Run(new firstauth());
            }catch(Exception e) {MessageBox.Show( e.Message); }
        }
    }
}
