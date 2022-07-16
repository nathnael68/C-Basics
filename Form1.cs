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


namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            Product m1 = new Product
            {
                number = int.Parse(textBox1.Text),
                date = datetxt.Text,
                invnumb = int.Parse(textBox3.Text),
                objname = textBox4.Text,
                count = int.Parse(textBox5.Text),
                price = double.Parse(textBox6.Text),
            };
            MessageBox.Show("SAVED");
            m1.save();
            ProductView1.DataSource = null;
            ProductView1.DataSource = Product.GetAll();



        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
        

        private void datetxt_ValueChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
