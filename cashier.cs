using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WinFormAction
{
    public partial class cashier : Form
    {
        DataTable _dt_bayers = new DataTable();
        public cashier()
        {
            InitializeComponent();
            Program._MSSQL.get_byers_kayala_test();
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

        }

        private void cashier_Load(object sender, EventArgs e)
        {
            
        }
    }
}
