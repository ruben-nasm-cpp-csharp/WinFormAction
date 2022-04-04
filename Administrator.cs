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
            
            try
            {
                dataGridView_bayers.DataSource = Program._MSSQL.get_byers_kayala();
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
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
          
           
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

        private void MenuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            MessageBox.Show(e.ClickedItem.Name);
            switch (e.ClickedItem.Name.ToString())
            {
                case "set_user": set_users form= new set_users(); form.Show(); break;
                case "set_action_settings": set_action_settings_form form1 = new set_action_settings_form();if (form1.ShowDialog() == DialogResult.OK) { reset_form_data(); }; break;
                case "action": Action form2 = new Action(); form2.ShowDialog(); break;
            }
            

        }
        private void reset_form_data() 
        {
            try
            {
                dataGridView_bayers.DataSource = Program._MSSQL.get_byers_kayala();
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

        private void delete_barcode_Click(object sender, EventArgs e)
        {
            try
            {
                Program._MySQL.delete_barcode_by_user(dataGridView_barcode.Rows[dataGridView_barcode.SelectedRows[0].Index].Cells[0].Value.ToString());
            }
            catch { }
            try
            {
                dataGridView_barcode.DataSource = Program._MySQL._get_user_barcode_reg(Convert.ToInt32(dataGridView_bayers.SelectedRows[0].Cells[0].Value));
            }
            catch { }
        }
    }
}
