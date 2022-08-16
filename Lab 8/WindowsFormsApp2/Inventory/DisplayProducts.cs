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
    public partial class DisplayProducts : Form
    {
        public DisplayProducts()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

            foreach (var item in Product.getAll())
            {
                ProdCard card = new ProdCard();
                card.Title = item.itemName;
                card.Desc = item.number.ToString();
                card.Price = item.price;
                flowLayoutPanel1.Controls.Add(card);
            }
        }
    }
}
