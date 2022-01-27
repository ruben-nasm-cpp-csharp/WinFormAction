
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
            this.group_box_mysql_server = new System.Windows.Forms.GroupBox();
            this.SuspendLayout();
            // 
            // group_box_mssql_server
            // 
            this.group_box_mssql_server.Location = new System.Drawing.Point(12, 12);
            this.group_box_mssql_server.Name = "group_box_mssql_server";
            this.group_box_mssql_server.Size = new System.Drawing.Size(218, 246);
            this.group_box_mssql_server.TabIndex = 0;
            this.group_box_mssql_server.TabStop = false;
            this.group_box_mssql_server.Text = "MSSQL Server";
            // 
            // group_box_mysql_server
            // 
            this.group_box_mysql_server.Location = new System.Drawing.Point(236, 12);
            this.group_box_mysql_server.Name = "group_box_mysql_server";
            this.group_box_mysql_server.Size = new System.Drawing.Size(218, 246);
            this.group_box_mysql_server.TabIndex = 1;
            this.group_box_mysql_server.TabStop = false;
            this.group_box_mysql_server.Text = "MySQL Server";
            // 
            // firstauth
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(463, 265);
            this.Controls.Add(this.group_box_mysql_server);
            this.Controls.Add(this.group_box_mssql_server);
            this.Name = "firstauth";
            this.Text = "Первичная настройка";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox group_box_sql_server;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox group_box_mysql_server;
        private System.Windows.Forms.GroupBox group_box_mssql_server;
    }
}