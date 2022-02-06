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

            _bs_database_mysql.DataSource = MySQL_Server.GetDatabases(comboBox_host_mysql.Text, textBox_port_mysql.Text, textBox_login_mysql.Text, textBox_password_mysql.Text);
            comboBox_database_mysql.DataSource = _bs_database_mysql;
        }

        private void button_Connect_mssql_Click(object sender, EventArgs e)
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = MSSQL_Server.GetDatabases(comboBox_host_mssql.Text, textBox_login_mssql.Text, textBox_password_mssql.Text);
            comboBox_database_mssql.DataSource = bs;
        }

        private void firstauth_Load(object sender, EventArgs e)
        {

        }

        private void button_Save_mysql_connector_Click(object sender, EventArgs e)
        {
            Program._configuration.settings.settings_my_sql._database = comboBox_database_mysql.Text;
            Program._configuration.settings.settings_my_sql._host = comboBox_host_mysql.Text;
            Program._configuration.settings.settings_my_sql._login = textBox_login_mysql.Text;
            Program._configuration.settings.settings_my_sql._password = textBox_password_mysql.Text;
            Program._configuration.settings.settings_my_sql._port = textBox_port_mysql.Text;
            Program._MySQL.create_database();
        }

        private void button_Save_mssql_connector_Click(object sender, EventArgs e)
        {

        }

        private void button_next_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button_create_database_mysql_Click(object sender, EventArgs e)
        {
            
            Program._configuration.settings.settings_my_sql._host = comboBox_host_mysql.Text;
            Program._configuration.settings.settings_my_sql._login = textBox_login_mysql.Text;
            Program._configuration.settings.settings_my_sql._password = textBox_password_mysql.Text;
            Program._configuration.settings.settings_my_sql._port = textBox_port_mysql.Text;
            Program._MySQL.create_database();
            _bs_database_mysql.Add("ActionDataBase");
            comboBox_database_mysql.SelectedItem = "ActionDataBase";
        }
    }
}
