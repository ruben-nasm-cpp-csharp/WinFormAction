using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WinFormAction
{
    public partial class set_users : Form
    {
        public set_users()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void set_users_Load(object sender, EventArgs e)
        {
            dataGridView_users.DataSource = Program._MySQL._get_user_dt();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Program._MySQL.create_user_admin(textBox_login_user.Text, textBox_visibility_name_user.Text, textBox_password.Text);
            dataGridView_users.DataSource = Program._MySQL._get_user_dt();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Program._MySQL.delete_user_admin(dataGridView_users.SelectedRows[0].Cells[0].Value.ToString());
            dataGridView_users.DataSource = Program._MySQL._get_user_dt();
        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox_oldPass.Text == Program._configuration.settings.settings_my_sql._password)
            {
                if (textBox_newPass.Text == textBox_newPass2.Text)
                    Program._MySQL.set_password(textBox_newPass.Text);
                else 
                    MessageBox.Show("Пароли не совпадают!");
            }
            else
            { MessageBox.Show("Введен не правильный пароль\nДействие не возможно!"); }
        }
    }
}
