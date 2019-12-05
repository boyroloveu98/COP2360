using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Person_and_Customer_Class_ex
{
    public partial class newCustomerForm : Form
    {
        public newCustomerForm()
        {
            InitializeComponent();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void customerInfoButton_Click(object sender, EventArgs e)
        {
            //variables to hold input
            string name, phone, address, customerId;
            bool allowSoliciation = false;

            //get the customer's name and ID
            name = nameTextBox.Text;
            address = addressTextBox.Text;
            phone = phoneTextBox.Text;
            customerId = idTextBox.Text;

            //create a customer person object
            var newCustomer = new Customer(name, address, customerId, phone, allowSoliciation);

            //get the customer's soliciation status
            if(allowSolicationRadioButton.Checked)
            {
                //inform the user whether to call the customer or not
                MessageBox.Show("You may call " + newCustomer.Name + " at " + newCustomer.Phone);
            }
            else
            {
                //inform the user whether to call the customer or not
                MessageBox.Show("You may not call " + newCustomer.Name + " Since they are not allowing" +
                    " soliciation at the moment");
            }



        }
    }
}
