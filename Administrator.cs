using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.IO;
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
            
        }

        private void Administrator_Load(object sender, EventArgs e)
        {
            label_barcode_count.Text = "Количество штрихкодов: "  + Program._MySQL.count_barcode_admin();
            dataGridView_users.DataSource = Program._MySQL._get_user_dt();
            try
            {
                dataGridView_bayers.DataSource = Program._MSSQL.get_byers_kayala();
                dateTimePicker_end_action.Value = DateTime.ParseExact(Program._configuration.settings.settings_action.data_end, "yyyy-dd-MM HH:mm:ss", null);
                dateTimePicker_begin_action.Value = DateTime.ParseExact(Program._configuration.settings.settings_action.data_begin, "yyyy-dd-MM HH:mm:ss", null);
                textBox_barcode_cost.Text = Program._configuration.settings.settings_action.barcode_cost.ToString();
                dataGridView_search_barcode.DataSource = Program._MySQL._get_barcode();

            }
            catch { MessageBox.Show("Отображение списка покупателей не возможно в данных акции содержится ошибка!"); }
            dataGridView_bayers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            for (int i = 0; i < dataGridView_bayers.Columns.Count; i++)
            {
                if (dataGridView_bayers.Columns[i].Name != "Code" && dataGridView_bayers.Columns[i].Name != "Сумма продажи")
                    comboBox_search.Items.Add(dataGridView_bayers.Columns[i].Name);
            }
            comboBox_search.SelectedIndex = 0;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        string[] _barcodes;
        private void button_open_file_dialog_barcode_Click(object sender, EventArgs e)
        {
            OpenFileDialog _select_file = new OpenFileDialog();
            if (_select_file.ShowDialog() == DialogResult.OK) 
            {
                var sr = new StreamReader(_select_file.FileName);
                if (textBox_splitter.Text != "" && textBox_splitter.Text != null)
                {
                    _barcodes = sr.ReadToEnd().Split(textBox_splitter.Text);
                    Program._MySQL.insert_barcode_admin(_barcodes);
                    label_barcode_count.Text = "Количество штрихкодов: " + Program._MySQL.count_barcode_admin();
                    dataGridView_search_barcode.DataSource = Program._MySQL._get_barcode();
                }
                else
                    MessageBox.Show("Разделитель между кодами задан ошибочно!");

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Program._MySQL.create_user_admin(textBox_login_user.Text, textBox_visibility_name_user.Text, textBox_password.Text);
            dataGridView_users.DataSource = Program._MySQL._get_user_dt();
           
        }

        private void textBox_password_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView_users_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            

        }

     

        private void dataGridView_users_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Program._MySQL.delete_user_admin(dataGridView_users.SelectedRows[0].Cells[0].Value.ToString());
            dataGridView_users.DataSource = Program._MySQL._get_user_dt();
           

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            try
            {
                (dataGridView_bayers.DataSource as DataTable).DefaultView.RowFilter = string.Format(comboBox_search.SelectedItem.ToString() + " LIKE '%{0}%'", textBox5.Text);
            }
            catch { }
        }

        private void update_param_action_Click(object sender, EventArgs e)
        {
            try
            {
                if (Convert.ToUInt32(textBox_barcode_cost.Text) > 0)
                    Program._configuration.settings.settings_action.barcode_cost = Convert.ToUInt32(textBox_barcode_cost.Text);
                else MessageBox.Show("Сумма для получения штрих-кода не может быть отрицательной или равной нулю!");
                Program._configuration.settings.settings_action.data_begin = dateTimePicker_begin_action.Value.ToString("yyyy-dd-MM")+ " 00:00:00";
                Program._configuration.settings.settings_action.data_end = dateTimePicker_end_action.Value.ToString("yyyy-dd-MM") + " 00:00:00";
                MessageBox.Show(Program._configuration.settings.settings_action.data_end);
                dataGridView_bayers.DataSource = Program._MSSQL.get_byers_kayala();
                Program._MySQL.save_config_action();
                MessageBox.Show("Настройки сохранены!");
            }
            catch(Exception exc)
            {
                MessageBox.Show("При вводе произошла ошибка! "+exc.Message);
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Administrator_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void dataGridView_bayers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                dataGridView_barcode.DataSource = Program._MySQL._get_user_barcode_reg(Convert.ToInt32(dataGridView_bayers.SelectedRows[0].Cells[0].Value));
            }
            catch { }
        }

        private void dataGridView_bayers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void tabControl_search_admin_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button_refresh_users_Click(object sender, EventArgs e)
        {
            try
            {
                dataGridView_bayers.DataSource = Program._MSSQL.get_byers_kayala();
            }
            catch { }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                dataGridView_search_barcode.DataSource = Program._MySQL._get_barcode();
            }
            catch { }
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
            try
            {
                (dataGridView_search_barcode.DataSource as DataTable).DefaultView.RowFilter = string.Format("Код LIKE '%{0}%'", textBox1.Text);
             }
            catch { }
        }

        private void dataGridView_search_barcode_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
                
            
        }

        private void dataGridView_search_barcode_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {

              string[] res =Program._MySQL._get_user_barcode(dataGridView_search_barcode.SelectedRows[0].Cells[0].Value.ToString());
                label_user_barcode.Text = "Имя владельца кода: " + res[0] + ";\nНомер телефона: " + res[1] + ";\nEmail: " + res[2] + ";\nШтрихкод пробит: " + res[3];
             }
            catch { }
        }
    }
}
