using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;

namespace ShopDB
{
    public partial class Form1 : Form
    {
        ShopContext db;
        
        public Form1(string user)
        {
            InitializeComponent();
            if (user == "Reader")
            {
                button1.Visible = false;
                button2.Visible = false;
                button3.Visible = false;
            }
            else if (user == "Manager")
            {
                button3.Visible = false;
                comboBox1.Items.Remove("Decommission");
                comboBox1.Items.Remove("Product");
                comboBox1.Items.Remove("Provider");
                comboBox1.Items.Remove("Sale");
                comboBox1.Items.Remove("Purchase");
            }
            db = new ShopContext();
            db.clients.Load();
            dataGridView1.DataSource = db.clients.Local.ToBindingList();
        }
        public Form1()
        {
            InitializeComponent();

            db = new ShopContext();
            db.clients.Load();
            dataGridView1.DataSource = db.clients.Local.ToBindingList();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            string selectedState = comboBox1.SelectedItem.ToString();
            //MessageBox.Show(selectedState);
            switch (selectedState)
            {
                case "Client":
                    ToMod = 1;
                    db.clients.Load();
                    dataGridView1.DataSource = db.clients.Local.ToBindingList();
                    break;
                case "Product":
                    ToMod = 4;
                    db.products.Load();
                    dataGridView1.DataSource = db.products.Local.ToBindingList();
                    break;
                case "Decommission":
                    ToMod = 2;
                    db.decommissions.Load();
                    dataGridView1.DataSource = db.decommissions.Local.ToBindingList();
                    break;
                case "Income":
                    ToMod = 3;
                    db.incomes.Load();
                    dataGridView1.DataSource = db.incomes.Local.ToBindingList();
                    break;
                case "Provider":
                    ToMod = 5;
                    db.providers.Load();
                    dataGridView1.DataSource = db.providers.Local.ToBindingList();
                    break;
                case "Purchase":
                    ToMod = 6;
                    db.purchases.Load();
                    dataGridView1.DataSource = db.purchases.Local.ToBindingList();
                    break;
                case "Sale":
                    ToMod = 7;
                    db.sales.Load();
                    dataGridView1.DataSource = db.sales.Local.ToBindingList();
                    break;

            }
        }
        int ToMod = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            string[] names = new string[dataGridView1.ColumnCount - 1];
            for (int i = 1; i < dataGridView1.ColumnCount; ++i)
            {
                names[i - 1] = dataGridView1.Columns[i].HeaderText;
            }
            Add add = new Add (ToMod, names);
            add.ShowDialog();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string[] names = new string[dataGridView1.ColumnCount - 1];
            for (int i = 1; i < dataGridView1.ColumnCount; ++i)
            {
                names[i - 1] = dataGridView1.Columns[i].HeaderText;
            }
            Add upd = new Add(ToMod, names, true);
            upd.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Delete del = new Delete(ToMod);
            del.ShowDialog();
           
        }
    }
}
