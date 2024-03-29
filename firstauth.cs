﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;


namespace WinFormAction
{
    public partial class firstauth : Form
    {
        
        public firstauth()
        {
            InitializeComponent();
            
        }
        BindingSource _bs_database_mysql = new BindingSource();
        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void comboBox6_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button_Connect_mysql_Click(object sender, EventArgs e)
        {
            try
            {
                _bs_database_mysql.DataSource = MySQL_Server.GetDatabases(comboBox_host_mysql.Text, textBox_port_mysql.Text, textBox_login_mysql.Text, textBox_password_mysql.Text);
                comboBox_database_mysql.DataSource = _bs_database_mysql;
            }
            catch(Exception exc) { MessageBox.Show(exc.Message+"fa.cs 38"); }
        }

        private void button_Connect_mssql_Click(object sender, EventArgs e)
        {
            try
            {
                BindingSource bs = new BindingSource();
                bs.DataSource = MSSQL_Server.GetDatabases(comboBox_host_mssql.Text, textBox_login_mssql.Text, textBox_password_mssql.Text);
                comboBox_database_mssql.DataSource = bs;
                Program._configuration.settings.settings_ms_sql._host = comboBox_host_mssql.Text;
                Program._configuration.settings.settings_ms_sql._login = textBox_login_mssql.Text;
                Program._configuration.settings.settings_ms_sql._password = textBox_password_mssql.Text;
            }
            catch { MessageBox.Show("fa.cs 4352"); }

        }

        private void firstauth_Load(object sender, EventArgs e)
        {

        }

        private void button_Save_mysql_connector_Click(object sender, EventArgs e)
        {
            try
            {
                Program._configuration.settings.settings_my_sql._database = comboBox_database_mysql.Text;
                Program._configuration.settings.settings_my_sql._host = comboBox_host_mysql.Text;
                Program._configuration.settings.settings_my_sql._login = textBox_login_mysql.Text;
                Program._configuration.settings.settings_my_sql._password = textBox_password_mysql.Text;
                Program._configuration.settings.settings_my_sql._port = textBox_port_mysql.Text;
                if (Program._MySQL.Connection_database_test())
                {
                    MessageBox.Show("Подключение к MySQLSERVER успешно!");
                }
                else 
                { 
                    MessageBox.Show("Ошибка подключение к MySQLSERVER проверте все данные и попытайтесь еще раз!");
                    Program._configuration.settings.settings_my_sql._database = null;
                    Program._configuration.settings.settings_my_sql._host = null;
                    Program._configuration.settings.settings_my_sql._login = null;
                    Program._configuration.settings.settings_my_sql._password = null;
                    Program._configuration.settings.settings_my_sql._port = null;
                }
            }
            catch(Exception exc) 
            { 
                MessageBox.Show(exc.Message); 
            }

        }

        private void button_Save_mssql_connector_Click(object sender, EventArgs e)
        {
            Program._configuration.settings.settings_ms_sql._database = comboBox_database_mssql.Text;
        }

        private void button_next_Click(object sender, EventArgs e)
        {
            
                if (Program._MSSQL.Connection_database_test()) {
                    Program._configuration.write_settings();
                    Program._configuration.settings.settings_my_sql._login = "";
                    Program._configuration.settings.settings_my_sql._password = "";
                    this.Hide();
                    auth _auth = new auth();
                    _auth.Show();
                }
                else { MessageBox.Show("Ошибка подключение к MSSQLSERVER проверте все данные и попытайтесь еще раз!"); }
           

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button_create_database_mysql_Click(object sender, EventArgs e)
        {
            try
            {
                Program._configuration.settings.settings_my_sql._host = comboBox_host_mysql.Text;
                Program._configuration.settings.settings_my_sql._login = textBox_login_mysql.Text;
                Program._configuration.settings.settings_my_sql._password = textBox_password_mysql.Text;
                Program._configuration.settings.settings_my_sql._port = textBox_port_mysql.Text;
                int i;
                List<string> table = MySQL_Server.GetDatabases(comboBox_host_mysql.Text, textBox_port_mysql.Text, textBox_login_mysql.Text, textBox_password_mysql.Text);
                for (i = 0; table.Contains("actiondatabase" + i); i++) { }
                Program._MySQL._database_creation = "actiondatabase" + i;
                Program._MySQL.create_database();
                _bs_database_mysql.Add(Program._MySQL._database_creation);
                comboBox_database_mysql.SelectedItem = Program._MySQL._database_creation;
                Program._configuration.settings.settings_my_sql._database = comboBox_database_mysql.Text;
            }
            catch(Exception exc) { MessageBox.Show(exc.Message+"\n Зачем вам создавать столько баз данных подряд?"); }
        }
    }
}
