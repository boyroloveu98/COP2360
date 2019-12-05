﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Phone_Book
{
    public partial class phoneBookForm : Form
    {
        public phoneBookForm()
        {
            InitializeComponent();
        }

        private void personBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.personBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.phoneListDataSet);

        }

        private void phoneBookForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'phoneListDataSet.Person' table. You can move, or remove it, as needed.
            this.personTableAdapter.Fill(this.phoneListDataSet.Person);

        }
    }
}
