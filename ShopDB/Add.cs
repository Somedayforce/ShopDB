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
    public partial class Add : Form
    {
        public Add()
        {
            InitializeComponent();

           
        }
        //int ToAdd;
        List<TextBox> boxes = new List<TextBox>();
        List<string> Names = new List<string>();
        string lastString = "";
        int ToAdd;
        bool Upd = false;
        int toUpd;
        public Add(int toAdd, string[] names, bool upd = false)
        {
            InitializeComponent();
            //ToAdd = toAdd;
            textBox1.Visible = false;
            boxes.Add(textBox2);
            boxes.Add(textBox3);
            boxes.Add(textBox4);
            boxes.Add(textBox5);
            boxes.Add(textBox6);
            boxes.Add(textBox7);
            boxes.Add(textBox8);
            boxes.Add(textBox9);

            for (int i = names.Length; i <8 ; ++i)
            {
                boxes[i].Visible = false;
            }
            for (int i = 0; i < names.Length; ++i)
            {
                boxes[i].Text = names[i];
            }
            Names = names.ToList();
            ToAdd = toAdd;
            if (upd)
            {
                Upd = true;
                this.Text = "Update";
                textBox1.Visible = true;
                button1.Text = "Update";
            }

        }
      

        private void Add_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
        
            try
            {
                using (ShopContext db = new ShopContext())
                {
                    if (Upd) { toUpd = int.Parse(textBox1.Text); }
                    if (ToAdd == 1)
                    {

                        Client cli = new Client();
                        if (Upd)
                        {
                            bool exists = false;
                            foreach (Client cf in db.clients)
                            {
                                if (cf.client_id == toUpd)
                                {
                                    cli = cf;
                                    exists = true;
                                }
                            }
                            if (exists == false)
                            { MessageBox.Show("Incorrect ID", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); return; }
                        }


                        cli.name = textBox2.Text;
                        cli.dept = int.Parse(textBox3.Text);
                        cli.adress = textBox4.Text;
                     
                        
                      
                        //conf.conferenceEnd = DateTime.ParseExact(textBox5.Text, "yyyyMdd", null);
                        //db.Entry(conf).State = System.Data.Entity.EntityState.Modified;
                        if (Upd == false)
                        { db.clients.Add(cli); MessageBox.Show("Новый объект добавлен"); }
                        else { db.Entry(cli).State = System.Data.Entity.EntityState.Modified; }
                        db.SaveChanges();
                    }
                    else if (ToAdd == 2)
                    {
                        Decommission dec = new Decommission();
                        if (Upd)
                        {
                            bool exists = false;
                            foreach (Decommission dc in db.decommissions)
                            {
                                if (dc.decommission_id == toUpd)
                                {
                                    dec = dc;
                                    exists = true;
                                }
                            }
                            if (exists == false)
                            { MessageBox.Show("Incorrect ID", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); return; }
                        }
                        dec.product_id = int.Parse(textBox2.Text);
                        dec.manufacture_date = DateTime.ParseExact(textBox3.Text, "yyyyMdd", null);
                        dec.expiry_term = DateTime.ParseExact(textBox4.Text, "yyyyMdd", null);
                        dec.deccom_date = DateTime.ParseExact(textBox5.Text, "yyyyMdd", null);
                        dec.amount = int.Parse(textBox6.Text);
                        if (Upd == false)
                        { db.decommissions.Add(dec); MessageBox.Show("Новый объект добавлен"); }
                        else { db.Entry(dec).State = System.Data.Entity.EntityState.Modified; }
                        db.SaveChanges();


                    }
                    else if (ToAdd == 3)
                    {
                        Income inc = new Income();
                        if (Upd)
                        {
                            bool exists = false;
                            foreach (Income inco in db.incomes)
                            {
                                if (inco.income_id == toUpd)
                                {
                                    inc = inco;
                                    exists = true;
                                }
                            }
                            if (exists == false)
                            { MessageBox.Show("Incorrect ID", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); return; }
                        }

                        inc.incomedate = DateTime.ParseExact(textBox2.Text, "yyyyMdd", null);
                        inc.price = Convert.ToDecimal(textBox3.Text);
                        inc.provider_id = int.Parse(textBox4.Text);


                        if (Upd == false)
                        { db.incomes.Add(inc); MessageBox.Show("Новый объект добавлен"); }
                        else { db.Entry(inc).State = System.Data.Entity.EntityState.Modified; }
                        db.SaveChanges();
                    }
                    else if (ToAdd == 4)
                    {
                        Product prd = new Product();
                        if (Upd)
                        {
                            bool exists = false;
                            foreach (Product pr in db.products)
                            {
                                if (prd.product_id == toUpd)
                                {
                                    prd = pr;
                                    exists = true;
                                }
                            }
                            if (exists == false)
                            { MessageBox.Show("Incorrect ID", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); return; }
                        }

                        prd.type = textBox2.Text;
                        prd.name = textBox3.Text;
                        prd.measure = textBox4.Text;
                        prd.amount = int.Parse(textBox5.Text);
                        prd.expiry = int.Parse(textBox6.Text);
                        prd.buyprice = Convert.ToDecimal(textBox7.Text);
                        prd.sellprice = Convert.ToDecimal(textBox8.Text);

                        if (Upd == false)
                        { db.products.Add(prd); MessageBox.Show("Новый объект добавлен"); }
                        else { db.Entry(prd).State = System.Data.Entity.EntityState.Modified; }
                        db.SaveChanges();

                    }
                    else if (ToAdd == 5)
                    {
                        Provider prv = new Provider();
                        if (Upd)
                        {
                            bool exists = false;
                            foreach (Provider pr in db.providers)
                            {
                                if (prv.provider_id == toUpd)
                                {
                                    prv = pr;
                                    exists = true;
                                }
                            }
                            if (exists == false)
                            { MessageBox.Show("Incorrect ID", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); return; }
                        }

                        prv.adress = textBox4.Text;
                        prv.name = textBox2.Text;
                        prv.product_name = textBox3.Text;
                        prv.discount = int.Parse(textBox5.Text);
                        if (Upd == false)
                        { db.providers.Add(prv); MessageBox.Show("Новый объект добавлен"); }
                        else { db.Entry(prv).State = System.Data.Entity.EntityState.Modified; }
                        db.SaveChanges();

                    }
                    else if (ToAdd == 6)
                    {
                        Purchase prd = new Purchase();
                        if (Upd)
                        {
                            bool exists = false;
                            foreach (Purchase pr in db.purchases)
                            {
                                if (prd.purchase_id == toUpd)
                                {
                                    prd = pr;
                                    exists = true;
                                }
                            }
                            if (exists == false)
                            { MessageBox.Show("Incorrect ID", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); return; }
                        }

                        prd.product_id = int.Parse(textBox2.Text);
                        prd.amount = int.Parse(textBox3.Text);
                        prd.income_id = int.Parse(textBox4.Text);

                        if (Upd == false)
                        { db.purchases.Add(prd); MessageBox.Show("Новый объект добавлен"); }
                        else { db.Entry(prd).State = System.Data.Entity.EntityState.Modified; }
                        db.SaveChanges();

                    }
                    else if (ToAdd == 7)
                    {
                        Sale prd = new Sale();
                        if (Upd)
                        {
                            bool exists = false;
                            foreach (Sale pr in db.sales)
                            {
                                if (prd.sale_id == toUpd)
                                {
                                    prd = pr;
                                    exists = true;
                                }
                            }
                            if (exists == false)
                            { MessageBox.Show("Incorrect ID", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); return; }
                        }

                        prd.product_id = int.Parse(textBox2.Text);
                        prd.client_id = int.Parse(textBox3.Text);
                        prd.amount = int.Parse(textBox4.Text);
                        prd.dateofsale = DateTime.ParseExact(textBox5.Text, "yyyyMdd", null);
                        prd.price = Convert.ToDecimal(textBox6.Text);

                        if (Upd == false)
                        { db.sales.Add(prd); MessageBox.Show("Новый объект добавлен"); }
                        else { db.Entry(prd).State = System.Data.Entity.EntityState.Modified; }
                        db.SaveChanges();

                    }
                }
            }

            catch
            {
                MessageBox.Show("Incorrect input", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void textBox_Leave(object sender, EventArgs e)
        {
            if ((sender as TextBox).Text == "")
            {
                (sender as TextBox).Text = lastString;
            }
        }


    }
    
}
