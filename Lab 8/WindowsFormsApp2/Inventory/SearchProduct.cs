using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inventory
{
    public partial class SearchProduct : Form
    {
        public SearchProduct()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtSearch.Text))
            {
                errorProviderSearch.Clear();
                var item = Product.findOne(txtSearch.Text);
                if (item == null)
                {
                    MessageBox.Show("Not Found");
                }
                else
                {
                    label1.Text = item.itemName;
                    label2.Text = item.price.ToString();
                }
            }
            else
            {
                errorProviderSearch.SetError(txtSearch, "Enter Field");
            }
                
        }
    }
}
