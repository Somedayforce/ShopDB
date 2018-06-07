using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShopDB
{
    public partial class Enter : Form
    {
        public Enter()
        {
            InitializeComponent();

        }

       

        private void Open()
        {
            this.Visible = false;
            Form1 tables = new Form1(comboBox1.SelectedItem.ToString());
            tables.ShowDialog();
            this.Visible = true;
        }
       

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ((string)comboBox1.SelectedItem == "Reader")
            {
                textBox1.Enabled = false;
            }
            else
            {
                textBox1.Enabled = true;
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem == null)
            {
                return;
            }

            if (comboBox1.SelectedItem.ToString() == "Reader")
            {
                Open();
            }
            else if (comboBox1.SelectedItem.ToString() == "Manager" && textBox1.Text == "1234")
            {
                Open();
            }
            else if (comboBox1.SelectedItem.ToString() == "Admin" && textBox1.Text == "1234")
            {
                Open();
            }
            else
            {
                MessageBox.Show("Incorrect password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
