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
            
            if(Program._MySQL.Connection_database_test())
            {
                Program._MySQL.read_config_mssql();
                if (Program._MSSQL.Connection_database_test())
                {
                    string[] user= Program._MySQL._get_user();
                    if(user!=null)
                    {
                        Program._configuration.settings.settings_user._visibilityname = user[0];
                        Program._configuration.settings.settings_user._type = user[1];
                        if (!Program._MySQL.read_config_action())
                            MessageBox.Show("Внимание данные акции не заполнены, перейдите в меню администратора и заполните соответствующие поля в левой нижней части окна!");
                        switch(Program._configuration.settings.settings_user._type)
                        {
                            case "admin":
                                this.Hide();
                                Administrator _Administrator = new Administrator();
                                _Administrator.Show();
                                break;
                            case "user":
                                this.Hide();
                                cashier _cashier = new cashier();
                                _cashier.Show();
                                break;
                            default : 
                                MessageBox.Show("При попытке авторизации произошла ошибка попробуйте позже или обратитесь к системному администратору!"); 
                                break;

                        }
                    }
                    else MessageBox.Show("При попытке авторизации произошла ошибка попробуйте позже или обратитесь к системному администратору!");
                }
                else
                {
                    MessageBox.Show("Нет подключения к базе данных \"Торговое место\" Обратитесь к системному администратору!");
                }
            }
            else { MessageBox.Show("Ошибка подключения!\n Проверте правильность введенных данных, если данные введенны ВЕРНО, обратитесь к системному администратору!"); }
            
            
        }

        private void auth_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
