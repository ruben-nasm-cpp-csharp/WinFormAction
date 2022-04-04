
namespace WinFormAction
{
    partial class set_users
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
            this.dataGridView_users = new System.Windows.Forms.DataGridView();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.textBox_login_user = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_password = new System.Windows.Forms.TextBox();
            this.textBox_visibility_name_user = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button3 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox_newPass2 = new System.Windows.Forms.TextBox();
            this.textBox_oldPass = new System.Windows.Forms.TextBox();
            this.textBox_newPass = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox_cashier.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_users)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox_cashier
            // 
            this.groupBox_cashier.Controls.Add(this.dataGridView_users);
            this.groupBox_cashier.Controls.Add(this.button2);
            this.groupBox_cashier.Location = new System.Drawing.Point(12, 12);
            this.groupBox_cashier.Name = "groupBox_cashier";
            this.groupBox_cashier.Size = new System.Drawing.Size(331, 246);
            this.groupBox_cashier.TabIndex = 1;
            this.groupBox_cashier.TabStop = false;
            this.groupBox_cashier.Text = "Удаление пользователей";
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
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.textBox_login_user);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.button1);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.textBox_password);
            this.groupBox3.Controls.Add(this.textBox_visibility_name_user);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Location = new System.Drawing.Point(349, 21);
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
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.textBox_newPass2);
            this.groupBox1.Controls.Add(this.textBox_oldPass);
            this.groupBox1.Controls.Add(this.textBox_newPass);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Location = new System.Drawing.Point(349, 128);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(331, 140);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Смена пароля Администратора!!!";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(199, 110);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(85, 23);
            this.button3.TabIndex = 6;
            this.button3.Text = "Применить";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(78, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "Старый пароль:";
            this.label2.Click += new System.EventHandler(this.label2_Click_1);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(78, 54);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 15);
            this.label5.TabIndex = 6;
            this.label5.Text = "Старый пароль:";
            // 
            // textBox_newPass2
            // 
            this.textBox_newPass2.Location = new System.Drawing.Point(179, 81);
            this.textBox_newPass2.Name = "textBox_newPass2";
            this.textBox_newPass2.Size = new System.Drawing.Size(105, 23);
            this.textBox_newPass2.TabIndex = 5;
            // 
            // textBox_oldPass
            // 
            this.textBox_oldPass.Location = new System.Drawing.Point(179, 22);
            this.textBox_oldPass.Name = "textBox_oldPass";
            this.textBox_oldPass.Size = new System.Drawing.Size(105, 23);
            this.textBox_oldPass.TabIndex = 4;
            // 
            // textBox_newPass
            // 
            this.textBox_newPass.Location = new System.Drawing.Point(179, 51);
            this.textBox_newPass.Name = "textBox_newPass";
            this.textBox_newPass.Size = new System.Drawing.Size(105, 23);
            this.textBox_newPass.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(82, 84);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 15);
            this.label6.TabIndex = 8;
            this.label6.Text = "Новый пароль:";
            // 
            // set_users
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(691, 279);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox_cashier);
            this.Name = "set_users";
            this.Text = "Редактирование пользователей";
            this.Load += new System.EventHandler(this.set_users_Load);
            this.groupBox_cashier.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_users)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox_cashier;
        private System.Windows.Forms.DataGridView dataGridView_users;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox textBox_login_user;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_password;
        private System.Windows.Forms.TextBox textBox_visibility_name_user;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox_newPass2;
        private System.Windows.Forms.TextBox textBox_newPass;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_oldPass;
    }
}