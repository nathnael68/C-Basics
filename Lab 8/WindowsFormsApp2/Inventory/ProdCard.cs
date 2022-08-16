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
    public partial class ProdCard : UserControl
    {
        public ProdCard()
        {
            InitializeComponent();
        }
        private string _title;
        private string _desc;
        private double _price;
        public string Title
        {
            get { return _title; }
            set { _title = value; label1.Text = value; }
        }

        public string Desc
        {
            get { return _desc; }
            set { _desc = value; label2.Text = value; }
        }

        public double Price
        {
            get { return _price; }
            set { _price = value; label3.Text = value.ToString(); }
        }

        
    }
}
