
namespace WinFormAction
{
    partial class Administrator
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
            this.comboBox_search = new System.Windows.Forms.ComboBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.dataGridView_barcode = new System.Windows.Forms.DataGridView();
            this.dataGridView_bayers = new System.Windows.Forms.DataGridView();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button_refresh_users = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label12 = new System.Windows.Forms.Label();
            this.tabControl_search_admin = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.button3 = new System.Windows.Forms.Button();
            this.label_user_barcode = new System.Windows.Forms.Label();
            this.dataGridView_search_barcode = new System.Windows.Forms.DataGridView();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.mySqlCommand1 = new MySql.Data.MySqlClient.MySqlCommand();
            this.set_user = new System.Windows.Forms.ToolStripMenuItem();
            this.set_action_settings = new System.Windows.Forms.ToolStripMenuItem();
            this.Action = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.set_password = new System.Windows.Forms.ToolStripMenuItem();
            this.delete_barcode = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_barcode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_bayers)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tabControl_search_admin.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_search_barcode)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboBox_search
            // 
            this.comboBox_search.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_search.FormattingEnabled = true;
            this.comboBox_search.Location = new System.Drawing.Point(46, 26);
            this.comboBox_search.Name = "comboBox_search";
            this.comboBox_search.Size = new System.Drawing.Size(131, 23);
            this.comboBox_search.TabIndex = 14;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(183, 26);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(166, 23);
            this.textBox5.TabIndex = 15;
            this.textBox5.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // dataGridView_barcode
            // 
            this.dataGridView_barcode.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_barcode.Location = new System.Drawing.Point(519, 138);
            this.dataGridView_barcode.MultiSelect = false;
            this.dataGridView_barcode.Name = "dataGridView_barcode";
            this.dataGridView_barcode.ReadOnly = true;
            this.dataGridView_barcode.RowTemplate.Height = 25;
            this.dataGridView_barcode.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_barcode.Size = new System.Drawing.Size(175, 442);
            this.dataGridView_barcode.TabIndex = 17;
            // 
            // dataGridView_bayers
            // 
            this.dataGridView_bayers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_bayers.Location = new System.Drawing.Point(6, 138);
            this.dataGridView_bayers.MultiSelect = false;
            this.dataGridView_bayers.Name = "dataGridView_bayers";
            this.dataGridView_bayers.ReadOnly = true;
            this.dataGridView_bayers.RowTemplate.Height = 25;
            this.dataGridView_bayers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_bayers.Size = new System.Drawing.Size(507, 493);
            this.dataGridView_bayers.TabIndex = 16;
            this.dataGridView_bayers.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_bayers_CellClick);
            this.dataGridView_bayers.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_bayers_CellContentClick);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(19, 22);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(265, 15);
            this.label9.TabIndex = 13;
            this.label9.Text = "Количество зарегистрированных штрихкодов:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.delete_barcode);
            this.groupBox1.Controls.Add(this.button_refresh_users);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.dataGridView_bayers);
            this.groupBox1.Controls.Add(this.dataGridView_barcode);
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(700, 647);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Просмотр данных акции";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // button_refresh_users
            // 
            this.button_refresh_users.Location = new System.Drawing.Point(379, 109);
            this.button_refresh_users.Name = "button_refresh_users";
            this.button_refresh_users.Size = new System.Drawing.Size(75, 23);
            this.button_refresh_users.TabIndex = 18;
            this.button_refresh_users.Text = "Обновить";
            this.button_refresh_users.UseVisualStyleBackColor = true;
            this.button_refresh_users.Click += new System.EventHandler(this.button_refresh_users_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.comboBox_search);
            this.groupBox2.Controls.Add(this.textBox5);
            this.groupBox2.Location = new System.Drawing.Point(6, 51);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(367, 81);
            this.groupBox2.TabIndex = 21;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Поиск покупателя";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(14, 30);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(23, 15);
            this.label12.TabIndex = 22;
            this.label12.Text = "По";
            // 
            // tabControl_search_admin
            // 
            this.tabControl_search_admin.Controls.Add(this.tabPage1);
            this.tabControl_search_admin.Controls.Add(this.tabPage2);
            this.tabControl_search_admin.Location = new System.Drawing.Point(12, 27);
            this.tabControl_search_admin.Name = "tabControl_search_admin";
            this.tabControl_search_admin.SelectedIndex = 0;
            this.tabControl_search_admin.Size = new System.Drawing.Size(721, 664);
            this.tabControl_search_admin.TabIndex = 13;
            this.tabControl_search_admin.SelectedIndexChanged += new System.EventHandler(this.tabControl_search_admin_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(713, 636);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Поиск покупателей";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.button3);
            this.tabPage2.Controls.Add(this.label_user_barcode);
            this.tabPage2.Controls.Add(this.dataGridView_search_barcode);
            this.tabPage2.Controls.Add(this.groupBox4);
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(713, 636);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Поиск штрих-кодов";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(184, 603);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 21;
            this.button3.Text = "Обновить";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label_user_barcode
            // 
            this.label_user_barcode.AutoSize = true;
            this.label_user_barcode.Location = new System.Drawing.Point(184, 134);
            this.label_user_barcode.Name = "label_user_barcode";
            this.label_user_barcode.Size = new System.Drawing.Size(0, 15);
            this.label_user_barcode.TabIndex = 25;
            // 
            // dataGridView_search_barcode
            // 
            this.dataGridView_search_barcode.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_search_barcode.Location = new System.Drawing.Point(3, 134);
            this.dataGridView_search_barcode.MultiSelect = false;
            this.dataGridView_search_barcode.Name = "dataGridView_search_barcode";
            this.dataGridView_search_barcode.ReadOnly = true;
            this.dataGridView_search_barcode.RowTemplate.Height = 25;
            this.dataGridView_search_barcode.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_search_barcode.Size = new System.Drawing.Size(175, 493);
            this.dataGridView_search_barcode.TabIndex = 20;
            this.dataGridView_search_barcode.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_search_barcode_CellClick);
            this.dataGridView_search_barcode.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_search_barcode_CellContentClick);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.textBox1);
            this.groupBox4.Location = new System.Drawing.Point(3, 47);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(175, 81);
            this.groupBox4.TabIndex = 24;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Поиск штрихкода";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(6, 30);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(163, 23);
            this.textBox1.TabIndex = 19;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // mySqlCommand1
            // 
            this.mySqlCommand1.CacheAge = 0;
            this.mySqlCommand1.Connection = null;
            this.mySqlCommand1.EnableCaching = false;
            this.mySqlCommand1.Transaction = null;
            // 
            // set_user
            // 
            this.set_user.Name = "set_user";
            this.set_user.Size = new System.Drawing.Size(193, 20);
            this.set_user.Text = "Редактирование пользователей";
            // 
            // set_action_settings
            // 
            this.set_action_settings.Name = "set_action_settings";
            this.set_action_settings.Size = new System.Drawing.Size(213, 20);
            this.set_action_settings.Text = "Редактирование параметров акции";
            // 
            // Action
            // 
            this.Action.Name = "Action";
            this.Action.Size = new System.Drawing.Size(94, 20);
            this.Action.Text = "О программе";
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.set_user,
            this.set_action_settings,
            this.set_password,
            this.Action});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(730, 24);
            this.menuStrip.TabIndex = 14;
            this.menuStrip.Text = "menuStrip1";
            this.menuStrip.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.MenuStrip1_ItemClicked);
            // 
            // set_password
            // 
            this.set_password.Name = "set_password";
            this.set_password.Size = new System.Drawing.Size(124, 20);
            this.set_password.Text = "Изменение пароля";
            // 
            // delete_barcode
            // 
            this.delete_barcode.Location = new System.Drawing.Point(519, 586);
            this.delete_barcode.Name = "delete_barcode";
            this.delete_barcode.Size = new System.Drawing.Size(175, 44);
            this.delete_barcode.TabIndex = 22;
            this.delete_barcode.Text = "убрать штрихкод у пользователя";
            this.delete_barcode.UseVisualStyleBackColor = true;
            this.delete_barcode.Click += new System.EventHandler(this.delete_barcode_Click);
            // 
            // Administrator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(730, 690);
            this.Controls.Add(this.tabControl_search_admin);
            this.Controls.Add(this.menuStrip);
            this.MainMenuStrip = this.menuStrip;
            this.Name = "Administrator";
            this.Text = "Административный раздел";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Administrator_FormClosing);
            this.Load += new System.EventHandler(this.Administrator_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_barcode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_bayers)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tabControl_search_admin.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_search_barcode)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox comboBox_search;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.DataGridView dataGridView_barcode;
        private System.Windows.Forms.DataGridView dataGridView_bayers;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TabControl tabControl_search_admin;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label_user_barcode;
        private System.Windows.Forms.DataGridView dataGridView_search_barcode;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button_refresh_users;
        private MySql.Data.MySqlClient.MySqlCommand mySqlCommand1;
        private System.Windows.Forms.ToolStripMenuItem set_user;
        private System.Windows.Forms.ToolStripMenuItem set_action_settings;
        private System.Windows.Forms.ToolStripMenuItem Action;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem set_password;
        private System.Windows.Forms.Button delete_barcode;
    }
}