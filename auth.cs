using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormAction
{
    public partial class auth : Form
    {
        public auth()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Program._configuration.settings.settings_my_sql._login = textBox_login.Text;
            Program._configuration.settings.settings_my_sql._password = textBox_password.Text;
            Program._MySQL.Connection();
            Program._MySQL.read_config_mssql();
        }
    }
}
