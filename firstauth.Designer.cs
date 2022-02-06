
namespace WinFormAction
{
    partial class firstauth
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.group_box_mssql_server = new System.Windows.Forms.GroupBox();
            this.button_Save_mssql_connector = new System.Windows.Forms.Button();
            this.button_Connect_mssql = new System.Windows.Forms.Button();
            this.comboBox_database_mssql = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_password_mssql = new System.Windows.Forms.TextBox();
            this.textBox_login_mssql = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox_host_mssql = new System.Windows.Forms.ComboBox();
            this.group_box_mysql_server = new System.Windows.Forms.GroupBox();
            this.textBox_port_mysql = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.button_Save_mysql_connector = new System.Windows.Forms.Button();
            this.button_Connect_mysql = new System.Windows.Forms.Button();
            this.comboBox_database_mysql = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox_login_mysql = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBox_host_mysql = new System.Windows.Forms.ComboBox();
            this.textBox_password_mysql = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.button_next = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.button_create_database_mysql = new System.Windows.Forms.Button();
            this.group_box_mssql_server.SuspendLayout();
            this.group_box_mysql_server.SuspendLayout();
            this.SuspendLayout();
            // 
            // group_box_mssql_server
            // 
            this.group_box_mssql_server.Controls.Add(this.button_Save_mssql_connector);
            this.group_box_mssql_server.Controls.Add(this.button_Connect_mssql);
            this.group_box_mssql_server.Controls.Add(this.comboBox_database_mssql);
            this.group_box_mssql_server.Controls.Add(this.label9);
            this.group_box_mssql_server.Controls.Add(this.label4);
            this.group_box_mssql_server.Controls.Add(this.label3);
            this.group_box_mssql_server.Controls.Add(this.textBox_password_mssql);
            this.group_box_mssql_server.Controls.Add(this.textBox_login_mssql);
            this.group_box_mssql_server.Controls.Add(this.label1);
            this.group_box_mssql_server.Controls.Add(this.comboBox_host_mssql);
            this.group_box_mssql_server.Location = new System.Drawing.Point(232, 12);
            this.group_box_mssql_server.Name = "group_box_mssql_server";
            this.group_box_mssql_server.Size = new System.Drawing.Size(224, 231);
            this.group_box_mssql_server.TabIndex = 0;
            this.group_box_mssql_server.TabStop = false;
            this.group_box_mssql_server.Text = "MSSQL Server";
            // 
            // button_Save_mssql_connector
            // 
            this.button_Save_mssql_connector.Location = new System.Drawing.Point(142, 165);
            this.button_Save_mssql_connector.Name = "button_Save_mssql_connector";
            this.button_Save_mssql_connector.Size = new System.Drawing.Size(75, 23);
            this.button_Save_mssql_connector.TabIndex = 18;
            this.button_Save_mssql_connector.Text = "Save";
            this.button_Save_mssql_connector.UseVisualStyleBackColor = true;
            this.button_Save_mssql_connector.Click += new System.EventHandler(this.button_Save_mssql_connector_Click);
            // 
            // button_Connect_mssql
            // 
            this.button_Connect_mssql.Location = new System.Drawing.Point(142, 107);
            this.button_Connect_mssql.Name = "button_Connect_mssql";
            this.button_Connect_mssql.Size = new System.Drawing.Size(75, 23);
            this.button_Connect_mssql.TabIndex = 17;
            this.button_Connect_mssql.Text = "Connect";
            this.button_Connect_mssql.UseVisualStyleBackColor = true;
            this.button_Connect_mssql.Click += new System.EventHandler(this.button_Connect_mssql_Click);
            // 
            // comboBox_database_mssql
            // 
            this.comboBox_database_mssql.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_database_mssql.FormattingEnabled = true;
            this.comboBox_database_mssql.Location = new System.Drawing.Point(80, 136);
            this.comboBox_database_mssql.Name = "comboBox_database_mssql";
            this.comboBox_database_mssql.Size = new System.Drawing.Size(137, 23);
            this.comboBox_database_mssql.TabIndex = 10;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(16, 141);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(58, 15);
            this.label9.TabIndex = 9;
            this.label9.Text = "Database:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 81);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 15);
            this.label4.TabIndex = 8;
            this.label4.Text = "Password:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "Login:";
            // 
            // textBox_password_mssql
            // 
            this.textBox_password_mssql.Location = new System.Drawing.Point(80, 78);
            this.textBox_password_mssql.Name = "textBox_password_mssql";
            this.textBox_password_mssql.PasswordChar = '*';
            this.textBox_password_mssql.Size = new System.Drawing.Size(137, 23);
            this.textBox_password_mssql.TabIndex = 6;
            // 
            // textBox_login_mssql
            // 
            this.textBox_login_mssql.Location = new System.Drawing.Point(80, 49);
            this.textBox_login_mssql.Name = "textBox_login_mssql";
            this.textBox_login_mssql.Size = new System.Drawing.Size(137, 23);
            this.textBox_login_mssql.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Host:";
            // 
            // comboBox_host_mssql
            // 
            this.comboBox_host_mssql.ForeColor = System.Drawing.SystemColors.WindowText;
            this.comboBox_host_mssql.FormattingEnabled = true;
            this.comboBox_host_mssql.Location = new System.Drawing.Point(80, 20);
            this.comboBox_host_mssql.Name = "comboBox_host_mssql";
            this.comboBox_host_mssql.Size = new System.Drawing.Size(137, 23);
            this.comboBox_host_mssql.TabIndex = 0;
            // 
            // group_box_mysql_server
            // 
            this.group_box_mysql_server.Controls.Add(this.button_create_database_mysql);
            this.group_box_mysql_server.Controls.Add(this.label2);
            this.group_box_mysql_server.Controls.Add(this.textBox_port_mysql);
            this.group_box_mysql_server.Controls.Add(this.label11);
            this.group_box_mysql_server.Controls.Add(this.button_Save_mysql_connector);
            this.group_box_mysql_server.Controls.Add(this.button_Connect_mysql);
            this.group_box_mysql_server.Controls.Add(this.comboBox_database_mysql);
            this.group_box_mysql_server.Controls.Add(this.label10);
            this.group_box_mysql_server.Controls.Add(this.label5);
            this.group_box_mysql_server.Controls.Add(this.textBox_login_mysql);
            this.group_box_mysql_server.Controls.Add(this.label6);
            this.group_box_mysql_server.Controls.Add(this.comboBox_host_mysql);
            this.group_box_mysql_server.Controls.Add(this.textBox_password_mysql);
            this.group_box_mysql_server.Controls.Add(this.label8);
            this.group_box_mysql_server.Location = new System.Drawing.Point(8, 12);
            this.group_box_mysql_server.Name = "group_box_mysql_server";
            this.group_box_mysql_server.Size = new System.Drawing.Size(218, 260);
            this.group_box_mysql_server.TabIndex = 1;
            this.group_box_mysql_server.TabStop = false;
            this.group_box_mysql_server.Text = "MySQL Server";
            // 
            // textBox_port_mysql
            // 
            this.textBox_port_mysql.Location = new System.Drawing.Point(78, 52);
            this.textBox_port_mysql.Name = "textBox_port_mysql";
            this.textBox_port_mysql.Size = new System.Drawing.Size(137, 23);
            this.textBox_port_mysql.TabIndex = 18;
            this.textBox_port_mysql.Text = "3306";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(28, 56);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(32, 15);
            this.label11.TabIndex = 19;
            this.label11.Text = "port:";
            // 
            // button_Save_mysql_connector
            // 
            this.button_Save_mysql_connector.Location = new System.Drawing.Point(137, 231);
            this.button_Save_mysql_connector.Name = "button_Save_mysql_connector";
            this.button_Save_mysql_connector.Size = new System.Drawing.Size(75, 23);
            this.button_Save_mysql_connector.TabIndex = 17;
            this.button_Save_mysql_connector.Text = "Save";
            this.button_Save_mysql_connector.UseVisualStyleBackColor = true;
            this.button_Save_mysql_connector.Click += new System.EventHandler(this.button_Save_mysql_connector_Click);
            // 
            // button_Connect_mysql
            // 
            this.button_Connect_mysql.Location = new System.Drawing.Point(137, 141);
            this.button_Connect_mysql.Name = "button_Connect_mysql";
            this.button_Connect_mysql.Size = new System.Drawing.Size(75, 23);
            this.button_Connect_mysql.TabIndex = 11;
            this.button_Connect_mysql.Text = "Connect";
            this.button_Connect_mysql.UseVisualStyleBackColor = true;
            this.button_Connect_mysql.Click += new System.EventHandler(this.button_Connect_mysql_Click);
            // 
            // comboBox_database_mysql
            // 
            this.comboBox_database_mysql.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_database_mysql.ForeColor = System.Drawing.SystemColors.Window;
            this.comboBox_database_mysql.FormattingEnabled = true;
            this.comboBox_database_mysql.Location = new System.Drawing.Point(81, 170);
            this.comboBox_database_mysql.Name = "comboBox_database_mysql";
            this.comboBox_database_mysql.Size = new System.Drawing.Size(137, 23);
            this.comboBox_database_mysql.TabIndex = 12;
            this.comboBox_database_mysql.SelectedIndexChanged += new System.EventHandler(this.comboBox6_SelectedIndexChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 158);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(57, 30);
            this.label10.TabIndex = 11;
            this.label10.Text = "Select\r\ndatabase:";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 115);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 15);
            this.label5.TabIndex = 16;
            this.label5.Text = "Password:";
            // 
            // textBox_login_mysql
            // 
            this.textBox_login_mysql.Location = new System.Drawing.Point(78, 83);
            this.textBox_login_mysql.Name = "textBox_login_mysql";
            this.textBox_login_mysql.Size = new System.Drawing.Size(137, 23);
            this.textBox_login_mysql.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(26, 86);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 15);
            this.label6.TabIndex = 15;
            this.label6.Text = "login:";
            // 
            // comboBox_host_mysql
            // 
            this.comboBox_host_mysql.FormattingEnabled = true;
            this.comboBox_host_mysql.Location = new System.Drawing.Point(78, 20);
            this.comboBox_host_mysql.Name = "comboBox_host_mysql";
            this.comboBox_host_mysql.Size = new System.Drawing.Size(137, 23);
            this.comboBox_host_mysql.TabIndex = 9;
            // 
            // textBox_password_mysql
            // 
            this.textBox_password_mysql.Location = new System.Drawing.Point(78, 112);
            this.textBox_password_mysql.Name = "textBox_password_mysql";
            this.textBox_password_mysql.PasswordChar = '*';
            this.textBox_password_mysql.Size = new System.Drawing.Size(137, 23);
            this.textBox_password_mysql.TabIndex = 14;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(28, 23);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 15);
            this.label8.TabIndex = 10;
            this.label8.Text = "Host:";
            // 
            // button_next
            // 
            this.button_next.Location = new System.Drawing.Point(381, 249);
            this.button_next.Name = "button_next";
            this.button_next.Size = new System.Drawing.Size(75, 23);
            this.button_next.TabIndex = 2;
            this.button_next.Text = "Next ->";
            this.button_next.UseVisualStyleBackColor = true;
            this.button_next.Click += new System.EventHandler(this.button_next_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 203);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 15);
            this.label2.TabIndex = 20;
            this.label2.Text = "Or create new:";
            // 
            // button_create_database_mysql
            // 
            this.button_create_database_mysql.Location = new System.Drawing.Point(137, 199);
            this.button_create_database_mysql.Name = "button_create_database_mysql";
            this.button_create_database_mysql.Size = new System.Drawing.Size(75, 23);
            this.button_create_database_mysql.TabIndex = 21;
            this.button_create_database_mysql.Text = "Create";
            this.button_create_database_mysql.UseVisualStyleBackColor = true;
            this.button_create_database_mysql.Click += new System.EventHandler(this.button_create_database_mysql_Click);
            // 
            // firstauth
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(463, 280);
            this.Controls.Add(this.button_next);
            this.Controls.Add(this.group_box_mysql_server);
            this.Controls.Add(this.group_box_mssql_server);
            this.Name = "firstauth";
            this.Text = "Первичная настройка";
            this.Load += new System.EventHandler(this.firstauth_Load);
            this.group_box_mssql_server.ResumeLayout(false);
            this.group_box_mssql_server.PerformLayout();
            this.group_box_mysql_server.ResumeLayout(false);
            this.group_box_mysql_server.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion


        private System.Windows.Forms.GroupBox group_box_mysql_server;
        private System.Windows.Forms.GroupBox group_box_mssql_server;
        private System.Windows.Forms.Button button_Connect_mssql;
        private System.Windows.Forms.ComboBox comboBox_database_mssql;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox_host_mssql;
        private System.Windows.Forms.Button button_Connect_mysql;
        private System.Windows.Forms.ComboBox comboBox_database_mysql;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox_login_mysql;
        private System.Windows.Forms.Label label6;
  
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button_Save_mssql_connector;
        private System.Windows.Forms.Button button_Save_mysql_connector;
        private System.Windows.Forms.Button button_next;
        private System.Windows.Forms.ComboBox comboBox_host_mysql;
       
        private System.Windows.Forms.TextBox textBox_password_mysql;
        private System.Windows.Forms.TextBox textBox_login_mssql;
        private System.Windows.Forms.TextBox textBox_password_mssql;
     
        private System.Windows.Forms.TextBox textBox_port_mysql;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button button_create_database_mysql;
        private System.Windows.Forms.Label label2;
    }
}