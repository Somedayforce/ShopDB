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
    public partial class Delete : Form
    {
        public Delete()
        {
            InitializeComponent();
        }
        int number;
        bool deleted = false;
        public Delete(int numb)
        {
            InitializeComponent();
            this.number = numb;
        }

       

        private void button1_Click_1(object sender, EventArgs e)
        {
            int id = int.Parse(textBox1.Text);
            using (ShopContext cc = new ShopContext())
            {
                switch (number)
                {

                    case 1:

                        foreach (Client conf in cc.clients)
                        {
                            if (id == conf.client_id)
                            {
                                cc.clients.Remove(conf);
                                MessageBox.Show("Deleted");
                                deleted = true;
                                break;

                            }
                        }
                        cc.SaveChanges();
                        break;
                    case 3:
                        
                            foreach (Income sect in cc.incomes)
                            {
                                if (id == sect.income_id)
                                {
                                    cc.incomes.Remove(sect);
                                    MessageBox.Show("Deleted");
                                    deleted = true;
                                    break;
                                }
                            }
                            cc.SaveChanges();
                        break;
                    case 5:
                        foreach (Provider sect in cc.providers)
                        {
                            if (id == sect.provider_id)
                            {
                                cc.providers.Remove(sect);
                                MessageBox.Show("Deleted");
                                deleted = true;
                                break;
                            }
                        }
                        cc.SaveChanges();
                        break;

                }
              
                if (deleted is false)
                {
                    MessageBox.Show("Element with this index not exists", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
