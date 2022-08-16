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
    public partial class MainWindow : Form
    {
        public string Username { get; set; }
        public MainWindow(string user)
        {
            InitializeComponent();
            Username = user;
        }

        private void newStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var activeScreen = ActiveMdiChild;
            if(activeScreen != null)
            {
                activeScreen.Close();
            }
            NewStudent screen = new NewStudent();
            screen.MdiParent = this;
            screen.Show();
        }

        private void displayAllToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var activeScreen = ActiveMdiChild;
            if (activeScreen != null)
            {
                activeScreen.Close();
            }
            DisplayProducts screen = new DisplayProducts();
            screen.MdiParent = this;
            screen.Show();
        }

        private void displayStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var activeScreen = ActiveMdiChild;
            if (activeScreen != null)
            {
                activeScreen.Close();
            }
            DisplayStudents screen = new DisplayStudents();
            screen.MdiParent = this;
            screen.Show();
        }

        private void searchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var activeScreen = ActiveMdiChild;
            if (activeScreen != null)
            {
                activeScreen.Close();
            }
            SearchProduct screen = new SearchProduct();
            screen.MdiParent = this;
            screen.Show();

        }

        private void aDDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1(Username);
            form1.Show();
        }
    }
}
