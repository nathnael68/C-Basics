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
    public partial class Panel : Form
    {
        public Panel()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            indicator.Top = 65;
            panel1.Visible = false;
        }

        private void label2_Click(object sender, EventArgs e)
        {
            indicator.Top = 140;
            panel1.Visible = false;
        }

        private void label3_Click(object sender, EventArgs e)
        {
            indicator.Top = 210;
            panel1.Visible = false;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void label4_Click(object sender, EventArgs e)
        {
            indicator.Top = 290;
            panel1.Visible = false;
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
