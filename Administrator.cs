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
            dataGridView_bayers.DataSource = Program._MSSQL.get_byers_kayala_test();
            dataGridView_bayers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

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

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView_users_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox_login_user.Text = dataGridView_users.SelectedRows[0].Cells[0].Value.ToString();
            textBox_visibility_name_user.Text = dataGridView_users.SelectedRows[0].Cells[1].Value.ToString();
        }
    }
}
