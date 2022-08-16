using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Inventory;

namespace Inventory
{
    public partial class Form1 : Form
    {
        public string Username { get; set; }
        public Form1(string user)
        {
            InitializeComponent();
            Username = user;
            label7.Text = user;
        }

        private void btn_addItem_Click(object sender, EventArgs e)
        {
            Boolean isVal = true;

            //obj name and inv error provider
            Regex regex = new Regex(@"^[a-z]{2}$");
            if (regex.IsMatch(txt_ObjectName.Text))
            {
                isVal = false;
                errorProviderName.SetError(txt_ObjectName, "2 digit name");
            }
            if (string.IsNullOrEmpty(txt_ObjectName.Text))
            {
                isVal = false;
                errorProviderName.SetError(txt_ObjectName, "Name is Required");
            }
            else
                errorProviderName.Clear();

            try
            {
                errorProviderName.Clear();
                errorProviderInventoryN.Clear();
                var Sname = Product.findOne(txt_ObjectName.Text);
                var Pid = Product.findInvent(int.Parse(txt_InventoryNumber.Text));
                if (Sname != null)
                {
                    isVal = false;
                    errorProviderName.SetError(txt_ObjectName, "Name already Exists");
                }
                else if (txt_ObjectName.TextLength < 3)
                {
                    isVal = false;
                    errorProviderName.SetError(txt_ObjectName, "Name should have more than 3 char");
                }

                if (Pid != null)
                {
                    isVal = false;
                    errorProviderInventoryN.SetError(txt_InventoryNumber, "Inventory Number already Exists");
                }
            }
            catch
            {
                errorProviderName.SetError(txt_ObjectName, "Name is required");
                errorProviderName.SetError(txt_InventoryNumber, "Inventory Number is Required");
            }

            if (string.IsNullOrEmpty(txt_InventoryNumber.Text))
            {
                isVal = false;
                errorProviderInventoryN.SetError(txt_InventoryNumber, "Inventory Number is Required");
            }else
                errorProviderInventoryN.Clear();


            //Number, Count, Price ErrorP
            if (string.IsNullOrEmpty(txt_Number.Text))
            {
                isVal = false;
                errorProviderNum.SetError(txt_Number, "Number is Required");
            }
            else
                errorProviderNum.Clear();

            if (string.IsNullOrEmpty(txt_Count.Text))
            {
                isVal = false;
                errorCount.SetError(txt_Count, "Count is Required");
            }
            else
                errorCount.Clear();
            try
            {
                errorCount.Clear();
                int.Parse(txt_Count.Text);
            }
            catch
            {
                errorCount.SetError(txt_Count, "Count is required");
            }

            if (string.IsNullOrEmpty(txt_Price.Text))
            {
                isVal = false;
                errorProviderPrice.SetError(txt_Price, "Price is required");
            }
            else
                errorCount.Clear();
            try
            {
                errorProviderPrice.Clear();
                double.Parse(txt_Price.Text);
            }
            catch (Exception)
            {
                errorProviderPrice.SetError(txt_Price, "Price is required");
            }


            //ADD
            if (isVal)
            {
                Product m1 = new Product
                {
                    itemName = txt_ObjectName.Text,
                    number = int.Parse(txt_Number.Text),
                    date = txt_Date.Text,
                    inventoryNumber = int.Parse(txt_InventoryNumber.Text),
                    count = int.Parse(txt_Count.Text),
                    price = double.Parse(txt_Price.Text),
                    isAvail = chk_isAvailable.Checked,
                };
                string message = "";
                foreach (var item in chk_List.CheckedItems)
                {
                    message += item.ToString() + '\n';
                }
                if (radioButton1.Checked)
                    message += "simple";
                else
                    message += "Variable";
                if (radioButton3.Checked)
                    message += "Payment on Delivery";
                else
                    message += "PayPal";
                MessageBox.Show("Added!\n" + message);
                m1.save();
                ProductView.DataSource = null;
                ProductView.DataSource = Product.getAll();
            }
            
            
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void isAvailable_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void ProductView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void txt_Number_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
