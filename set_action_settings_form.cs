using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WinFormAction
{
    public partial class set_action_settings_form : Form
    {
        public set_action_settings_form()
        {
            InitializeComponent();
        }

        private void set_action_settings_form_Load(object sender, EventArgs e)
        {
            label_barcode_count.Text = "Количество штрихкодов: " + Program._MySQL.count_barcode_admin();

            try
            {   dateTimePicker_end_action.Value = DateTime.ParseExact(Program._configuration.settings.settings_action.data_end, "yyyy-dd-MM HH:mm:ss", null);
                dateTimePicker_begin_action.Value = DateTime.ParseExact(Program._configuration.settings.settings_action.data_begin, "yyyy-dd-MM HH:mm:ss", null);
                textBox_barcode_cost.Text = Program._configuration.settings.settings_action.barcode_cost.ToString();
            }
            catch { }
        }

        private void button_open_file_dialog_barcode_Click(object sender, EventArgs e)
        {
            OpenFileDialog _select_file = new OpenFileDialog();
            if (_select_file.ShowDialog() == DialogResult.OK)
            {
                var sr = new System.IO.StreamReader(_select_file.FileName);
                if (textBox_splitter.Text != "" && textBox_splitter.Text != null)
                {
                    string[] _barcodes = sr.ReadToEnd().Split(textBox_splitter.Text);
                    Program._MySQL.insert_barcode_admin(_barcodes);
                    label_barcode_count.Text = "Количество штрихкодов: " + Program._MySQL.count_barcode_admin();
                 
                }
                else
                    MessageBox.Show("Разделитель между кодами задан ошибочно!");

            }
        }

        private void update_param_action_Click(object sender, EventArgs e)
        {
            try
            {
                if (Convert.ToUInt32(textBox_barcode_cost.Text) > 0)
                    Program._configuration.settings.settings_action.barcode_cost = Convert.ToUInt32(textBox_barcode_cost.Text);
                else MessageBox.Show("Сумма для получения штрих-кода не может быть отрицательной или равной нулю!");
                Program._configuration.settings.settings_action.data_begin = dateTimePicker_begin_action.Value.ToString("yyyy-dd-MM") + " 00:00:00";
                Program._configuration.settings.settings_action.data_end = dateTimePicker_end_action.Value.ToString("yyyy-dd-MM") + " 00:00:00";
                Program._MySQL.save_config_action();
                MessageBox.Show("Настройки сохранены!");
                this.DialogResult = DialogResult.OK;
            }
            catch (Exception exc)
            {
                MessageBox.Show("При вводе произошла ошибка! " + exc.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Вы действительно хотите УДАЛИТЬ все параметры и данные из всей базы данных?\nЭто действие нельзя будет отменить!", "ВНИМАНИЕ!!!!!!", MessageBoxButtons.YesNo);
                if( dialogResult == DialogResult.Yes)
            {
                Program._MySQL.drop_data();
                MessageBox.Show("Все даные безвозвратно удалены!");
                this.DialogResult = DialogResult.OK;
            }
            
        }
    }
}
