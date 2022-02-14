
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
            this.groupBox_cashier = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.textBox_login_user = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_password = new System.Windows.Forms.TextBox();
            this.textBox_visibility_name_user = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridView_users = new System.Windows.Forms.DataGridView();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox_update_param_action = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePicker_end_action = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker_begin_action = new System.Windows.Forms.DateTimePicker();
            this.label_barcode_count = new System.Windows.Forms.Label();
            this.textBox_barcode_cost = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox_splitter = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.button_open_file_dialog_barcode = new System.Windows.Forms.Button();
            this.update_param_action = new System.Windows.Forms.Button();
            this.comboBox_search = new System.Windows.Forms.ComboBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.dataGridView_barcode = new System.Windows.Forms.DataGridView();
            this.dataGridView_bayers = new System.Windows.Forms.DataGridView();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label12 = new System.Windows.Forms.Label();
            this.groupBox_cashier.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_users)).BeginInit();
            this.groupBox_update_param_action.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_barcode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_bayers)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox_cashier
            // 
            this.groupBox_cashier.Controls.Add(this.groupBox3);
            this.groupBox_cashier.Controls.Add(this.dataGridView_users);
            this.groupBox_cashier.Controls.Add(this.button2);
            this.groupBox_cashier.Location = new System.Drawing.Point(12, 13);
            this.groupBox_cashier.Name = "groupBox_cashier";
            this.groupBox_cashier.Size = new System.Drawing.Size(331, 342);
            this.groupBox_cashier.TabIndex = 0;
            this.groupBox_cashier.TabStop = false;
            this.groupBox_cashier.Text = "Редактирование пользователей";
            this.groupBox_cashier.Enter += new System.EventHandler(this.groupBox_cashier_Enter);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.textBox_login_user);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.button1);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.textBox_password);
            this.groupBox3.Controls.Add(this.textBox_visibility_name_user);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Location = new System.Drawing.Point(0, 241);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(331, 101);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Создание пользователя";
            // 
            // textBox_login_user
            // 
            this.textBox_login_user.Location = new System.Drawing.Point(132, 16);
            this.textBox_login_user.Name = "textBox_login_user";
            this.textBox_login_user.Size = new System.Drawing.Size(105, 23);
            this.textBox_login_user.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(82, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "*Логин:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(243, 73);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Создать";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "Отображаемое имя:";
            // 
            // textBox_password
            // 
            this.textBox_password.Location = new System.Drawing.Point(132, 74);
            this.textBox_password.Name = "textBox_password";
            this.textBox_password.Size = new System.Drawing.Size(105, 23);
            this.textBox_password.TabIndex = 5;
            this.textBox_password.TextChanged += new System.EventHandler(this.textBox_password_TextChanged);
            // 
            // textBox_visibility_name_user
            // 
            this.textBox_visibility_name_user.Location = new System.Drawing.Point(132, 45);
            this.textBox_visibility_name_user.Name = "textBox_visibility_name_user";
            this.textBox_visibility_name_user.Size = new System.Drawing.Size(105, 23);
            this.textBox_visibility_name_user.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(74, 77);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 15);
            this.label4.TabIndex = 8;
            this.label4.Text = "*Пароль:";
            // 
            // dataGridView_users
            // 
            this.dataGridView_users.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_users.Location = new System.Drawing.Point(7, 22);
            this.dataGridView_users.MultiSelect = false;
            this.dataGridView_users.Name = "dataGridView_users";
            this.dataGridView_users.ReadOnly = true;
            this.dataGridView_users.RowTemplate.Height = 25;
            this.dataGridView_users.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_users.Size = new System.Drawing.Size(318, 184);
            this.dataGridView_users.TabIndex = 1;
            this.dataGridView_users.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_users_CellClick);
            this.dataGridView_users.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_users_CellContentClick);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(250, 212);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Удалить";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // groupBox_update_param_action
            // 
            this.groupBox_update_param_action.Controls.Add(this.label11);
            this.groupBox_update_param_action.Controls.Add(this.label10);
            this.groupBox_update_param_action.Controls.Add(this.label2);
            this.groupBox_update_param_action.Controls.Add(this.dateTimePicker_end_action);
            this.groupBox_update_param_action.Controls.Add(this.dateTimePicker_begin_action);
            this.groupBox_update_param_action.Controls.Add(this.label_barcode_count);
            this.groupBox_update_param_action.Controls.Add(this.textBox_barcode_cost);
            this.groupBox_update_param_action.Controls.Add(this.label7);
            this.groupBox_update_param_action.Controls.Add(this.label6);
            this.groupBox_update_param_action.Controls.Add(this.textBox_splitter);
            this.groupBox_update_param_action.Controls.Add(this.label5);
            this.groupBox_update_param_action.Controls.Add(this.button_open_file_dialog_barcode);
            this.groupBox_update_param_action.Controls.Add(this.update_param_action);
            this.groupBox_update_param_action.Location = new System.Drawing.Point(12, 361);
            this.groupBox_update_param_action.Name = "groupBox_update_param_action";
            this.groupBox_update_param_action.Size = new System.Drawing.Size(331, 299);
            this.groupBox_update_param_action.TabIndex = 10;
            this.groupBox_update_param_action.TabStop = false;
            this.groupBox_update_param_action.Text = "Редактирование параметров акции ";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 238);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(26, 15);
            this.label11.TabIndex = 16;
            this.label11.Text = "По:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(13, 209);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(18, 15);
            this.label10.TabIndex = 15;
            this.label10.Text = "С:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 184);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 15);
            this.label2.TabIndex = 14;
            this.label2.Text = "Период акции:";
            // 
            // dateTimePicker_end_action
            // 
            this.dateTimePicker_end_action.Location = new System.Drawing.Point(37, 231);
            this.dateTimePicker_end_action.Name = "dateTimePicker_end_action";
            this.dateTimePicker_end_action.Size = new System.Drawing.Size(200, 23);
            this.dateTimePicker_end_action.TabIndex = 11;
            // 
            // dateTimePicker_begin_action
            // 
            this.dateTimePicker_begin_action.Location = new System.Drawing.Point(37, 202);
            this.dateTimePicker_begin_action.Name = "dateTimePicker_begin_action";
            this.dateTimePicker_begin_action.Size = new System.Drawing.Size(200, 23);
            this.dateTimePicker_begin_action.TabIndex = 10;
            // 
            // label_barcode_count
            // 
            this.label_barcode_count.AutoSize = true;
            this.label_barcode_count.Location = new System.Drawing.Point(7, 72);
            this.label_barcode_count.Name = "label_barcode_count";
            this.label_barcode_count.Size = new System.Drawing.Size(146, 15);
            this.label_barcode_count.TabIndex = 11;
            this.label_barcode_count.Text = "Количество штрихкодов:";
            // 
            // textBox_barcode_cost
            // 
            this.textBox_barcode_cost.Location = new System.Drawing.Point(174, 140);
            this.textBox_barcode_cost.Name = "textBox_barcode_cost";
            this.textBox_barcode_cost.Size = new System.Drawing.Size(98, 23);
            this.textBox_barcode_cost.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 133);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(161, 30);
            this.label7.TabIndex = 5;
            this.label7.Text = "Необходимая сумма \r\nдля получения штрих-кода:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 20);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 15);
            this.label6.TabIndex = 4;
            this.label6.Text = "Разделитель:";
            // 
            // textBox_splitter
            // 
            this.textBox_splitter.Location = new System.Drawing.Point(91, 17);
            this.textBox_splitter.Name = "textBox_splitter";
            this.textBox_splitter.Size = new System.Drawing.Size(29, 23);
            this.textBox_splitter.TabIndex = 7;
            this.textBox_splitter.Text = ",";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 50);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 15);
            this.label5.TabIndex = 2;
            this.label5.Text = "Штрихкоды:";
            // 
            // button_open_file_dialog_barcode
            // 
            this.button_open_file_dialog_barcode.Location = new System.Drawing.Point(87, 46);
            this.button_open_file_dialog_barcode.Name = "button_open_file_dialog_barcode";
            this.button_open_file_dialog_barcode.Size = new System.Drawing.Size(185, 23);
            this.button_open_file_dialog_barcode.TabIndex = 8;
            this.button_open_file_dialog_barcode.Text = "Указать файл с штрихкодами";
            this.button_open_file_dialog_barcode.UseVisualStyleBackColor = true;
            this.button_open_file_dialog_barcode.Click += new System.EventHandler(this.button_open_file_dialog_barcode_Click);
            // 
            // update_param_action
            // 
            this.update_param_action.Location = new System.Drawing.Point(185, 260);
            this.update_param_action.Name = "update_param_action";
            this.update_param_action.Size = new System.Drawing.Size(87, 23);
            this.update_param_action.TabIndex = 12;
            this.update_param_action.Text = "Применить";
            this.update_param_action.UseVisualStyleBackColor = true;
            this.update_param_action.Click += new System.EventHandler(this.update_param_action_Click);
            // 
            // comboBox_search
            // 
            this.comboBox_search.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_search.FormattingEnabled = true;
            this.comboBox_search.Location = new System.Drawing.Point(46, 26);
            this.comboBox_search.Name = "comboBox_search";
            this.comboBox_search.Size = new System.Drawing.Size(131, 23);
            this.comboBox_search.TabIndex = 13;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(183, 26);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(166, 23);
            this.textBox5.TabIndex = 14;
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
            this.dataGridView_barcode.Size = new System.Drawing.Size(175, 493);
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
            this.dataGridView_bayers.TabIndex = 15;
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
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.dataGridView_bayers);
            this.groupBox1.Controls.Add(this.dataGridView_barcode);
            this.groupBox1.Location = new System.Drawing.Point(349, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(700, 647);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Просмотр данных акции";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.textBox1);
            this.groupBox4.Location = new System.Drawing.Point(519, 51);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(175, 81);
            this.groupBox4.TabIndex = 23;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Поиск штрихкода";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(6, 30);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(163, 23);
            this.textBox1.TabIndex = 16;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
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
            // Administrator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1061, 672);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox_update_param_action);
            this.Controls.Add(this.groupBox_cashier);
            this.Name = "Administrator";
            this.Text = "Административный раздел";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Administrator_FormClosing);
            this.Load += new System.EventHandler(this.Administrator_Load);
            this.groupBox_cashier.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_users)).EndInit();
            this.groupBox_update_param_action.ResumeLayout(false);
            this.groupBox_update_param_action.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_barcode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_bayers)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox_cashier;
        private System.Windows.Forms.TextBox textBox_password;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_visibility_name_user;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox_update_param_action;
        private System.Windows.Forms.Button update_param_action;
        private System.Windows.Forms.Label label_barcode_count;
        private System.Windows.Forms.TextBox textBox_barcode_cost;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox_splitter;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button_open_file_dialog_barcode;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePicker_end_action;
        private System.Windows.Forms.DateTimePicker dateTimePicker_begin_action;
        private System.Windows.Forms.ComboBox comboBox_search;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.DataGridView dataGridView_barcode;
        private System.Windows.Forms.DataGridView dataGridView_bayers;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DataGridView dataGridView_users;
        private System.Windows.Forms.TextBox textBox_login_user;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox textBox1;
    }
}