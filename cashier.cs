﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace WinFormAction
{
    public partial class cashier : Form
    {
        DataTable _dt_bayers = new DataTable();
        DataTable search = new DataTable();
        public cashier()
        {
            InitializeComponent();
            search = Program._MSSQL.get_byers_kayala();
            _dt_bayers = search;
            dataGridView_byers.DataSource = _dt_bayers;
            for (int i = 0; i < dataGridView_byers.Columns.Count; i++)
            {
                if (dataGridView_byers.Columns[i].Name != "Code" && dataGridView_byers.Columns[i].Name != "Сумма продажи")
                    comboBox_search.Items.Add(dataGridView_byers.Columns[i].Name);
            }
            comboBox_search.SelectedIndex = 0;
        }

        private void textBox2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button1_Click(sender, e);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] cels = dataGridView_byers.SelectedRows[0].Cells[1].Value.ToString().Split(',');
            if (Convert.ToInt32(cels[0]) / Program._configuration.settings.settings_action.barcode_cost - Program._MySQL._get_count_barcode_user(Convert.ToInt32(dataGridView_byers.SelectedRows[0].Cells[0].Value.ToString())) <= 0)
                MessageBox.Show("Добавление штрихкода не возможно!\n Превышен лимит для данного пользователя!");
            else
            {
                if (0 == Program._MySQL._get_count_barcode_reg(Convert.ToInt32(textBox2.Text)))
                {
                    Program._MySQL.insert_barcode_user(textBox2.Text, dataGridView_byers.SelectedRows[0].Cells[0].Value.ToString());
                }
                else { MessageBox.Show("Штрихкод уже был зарегистрирован в системе!"); }
            }
        }

        public static String[] GetFilesFrom(String searchFolder, String[] filters, bool isRecursive)
        {
            List<String> filesFound = new List<String>();
            var searchOption = isRecursive ? SearchOption.AllDirectories : SearchOption.TopDirectoryOnly;
            foreach (var filter in filters)
            {
                filesFound.AddRange(Directory.GetFiles(searchFolder, String.Format("*.{0}", filter), searchOption));
            }
            return filesFound.ToArray();
        }

        private void cashier_Load(object sender, EventArgs e)
        {
            Task.Run(() => TaskPicture());


        }
        
        async void TaskPicture()
        {
            Bitmap image;

            try
            {
                String searchFolder = Application.StartupPath + @"\image";
                var filters = new String[] { "jpg", "jpeg", "png", "gif", "tiff", "bmp", "svg" };
                var files = GetFilesFrom(searchFolder, filters, false);
            loop:
                for (int i = 0; i < files.Length; i++)
                {
                    image = new Bitmap(files[i]);
                    pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                    pictureBox1.Image = image;
                    pictureBox1.Invalidate();
                    await Task.Delay(20000);
                }
                goto loop;
             }
                catch
                {
                    
                }
            
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                (dataGridView_byers.DataSource as DataTable).DefaultView.RowFilter = string.Format(comboBox_search.SelectedItem.ToString() + " LIKE '%{0}%'", textBox1.Text);
            }
            catch {  }
        }

        private void dataGridView_byers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void dataGridView_byers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                string[] cels = dataGridView_byers.SelectedRows[0].Cells[1].Value.ToString().Split(',');
                label3.Text = "У выбранного клиента сейчас штрихкодов: " + Program._MySQL._get_count_barcode_user(Convert.ToInt32(dataGridView_byers.SelectedRows[0].Cells[0].Value.ToString())).ToString();
                label_barcode_now.Text = "Возможно добавить штрихкодов: " + (Convert.ToInt32(cels[0]) / Program._configuration.settings.settings_action.barcode_cost - Program._MySQL._get_count_barcode_user(Convert.ToInt32(dataGridView_byers.SelectedRows[0].Cells[0].Value.ToString()))).ToString();
            }
            catch { }
        }

        private void cashier_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
