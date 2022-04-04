
namespace WinFormAction
{
    partial class set_action_settings_form
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
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox_update_param_action.SuspendLayout();
            this.SuspendLayout();
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
            this.groupBox_update_param_action.Location = new System.Drawing.Point(12, 12);
            this.groupBox_update_param_action.Name = "groupBox_update_param_action";
            this.groupBox_update_param_action.Size = new System.Drawing.Size(331, 299);
            this.groupBox_update_param_action.TabIndex = 11;
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
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(349, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(92, 69);
            this.button1.TabIndex = 13;
            this.button1.Text = "Сбросить все данные и параматры акции";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // set_action_settings_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(457, 323);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox_update_param_action);
            this.Name = "set_action_settings_form";
            this.Text = "Редактирование параметров акции ";
            this.Load += new System.EventHandler(this.set_action_settings_form_Load);
            this.groupBox_update_param_action.ResumeLayout(false);
            this.groupBox_update_param_action.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox_update_param_action;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePicker_end_action;
        private System.Windows.Forms.DateTimePicker dateTimePicker_begin_action;
        private System.Windows.Forms.Label label_barcode_count;
        private System.Windows.Forms.TextBox textBox_barcode_cost;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox_splitter;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button_open_file_dialog_barcode;
        private System.Windows.Forms.Button update_param_action;
        private System.Windows.Forms.Button button1;
    }
}