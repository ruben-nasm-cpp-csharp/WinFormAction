using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WinFormAction
{
    public partial class Administrator : Form
    {
        public Administrator()
        {
            InitializeComponent();
        }

        private void groupBox_cashier_Enter(object sender, EventArgs e)
        {
            //CREATE USER 'test_user'@'%' IDENTIFIED BY 'password';
            //DROP USER 'itisgood'@'localhost'
            //GRANT привилегии ON база_данных . таблица TO 'имя_пользователя'@'хост';
            /*
             * ALL PRIVILEGES - все, кроме GRANT;
                USAGE PRIVILEGES - никаких привилегий;
                SELECT - делать выборки из таблиц;
                INSERT - вставлять данные в таблицу;
                UPDATE - обновлять данные в таблице;
                DELETE - удалять данные из таблицы;
                FILE - разрешает читать файлы на сервере;
                CREATE - создавать таблицы или базы данных;
                ALTER - изменять структуру таблиц;
                INDEX - создавать индексы для таблиц;
                DROP - удалять таблицы;
                EVENT - обработка событий;
                TRIGGER - создание триггеров.

                CREATE USER 'test_user'@'%' IDENTIFIED BY 'password';
                GRANT SELECT ON actiondatabase1.users TO 'test_user'@'%';
                GRANT SELECT ON actiondatabase1.config TO 'test_user'@'%';
                GRANT SELECT ON actiondatabase1.barcodes_lst TO 'test_user'@'%';
                GRANT SELECT,INSERT,UPDATE ON actiondatabase1.barcodes_reg TO 'test_user'@'%';
                INSERT INTO actiondatabase1.users(actiondatabase1.users._login,actiondatabase1.users._nameVisibility,actiondatabase1.users._type) value ('test_user','Тестовый пользователь','user');
             */
        }

        private void Administrator_Load(object sender, EventArgs e)
        {

        }
    }
}
