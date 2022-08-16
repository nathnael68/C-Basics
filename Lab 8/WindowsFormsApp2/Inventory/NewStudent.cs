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
    public partial class NewStudent : Form
    {
        public NewStudent()
        {
            InitializeComponent();
        }



        private void btnAdd_Click(object sender, EventArgs e)
        {
            bool isVal = true;
            try
            {
                errorPName.Clear();
                errorPID.Clear();
                var Sname = Student.findName(txtName.Text);
                var Sid = Student.findID(int.Parse(txtID.Text));
                if (Sname != null)
                {
                    isVal = false;
                    errorPName.SetError(txtName, "Name already Exists");
                }
                else if (txtName.TextLength < 3)
                {
                    isVal = false;
                    errorPName.SetError(txtName, "Name should have more than 3 char");
                }

                if (Sid != null)
                {
                    isVal = false;
                    errorPID.SetError(txtID, "ID already Exists");
                }
            }
            catch
            {
                errorPName.SetError(txtName, "Name is required");
                errorPID.SetError(txtID, "Id is req");
            }
            

            
            

            if(string.IsNullOrEmpty(txtBatch.Text))
            {
                isVal = false;
                errorPBatch.SetError(txtBatch, "Batch is Required");
            }
            else if (txtBatch.TextLength != 4)
            {
                isVal = false;
                errorPBatch.SetError(txtBatch, "Enter correct batch");
            }
            else
                errorPBatch.Clear();

            if (isVal)
            {
                Student s1 = new Student
                {
                    Name = txtName.Text,
                    id = int.Parse(txtID.Text),
                    dob = txt_Date.Text,
                    Batch = txtBatch.Text,
                };
                MessageBox.Show("Added!\n");
                s1.save();
                txtID.Text = (s1.id + 1).ToString();
            }
            
        }
    }
}
