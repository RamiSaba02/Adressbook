using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Inlämningsupggift_final_version
{
    public partial class addressAdder : Form
    {
        public addressAdder()
        {
            InitializeComponent();
        }

        private void btnAddAddress_Click(object sender, EventArgs e)
        {

            var NewAddress = new ContactGetter { Name = tbxName.Text, Street = tbxStreet.Text, Zip = tbxZip.Text, Tel = tbxTel.Text, Email = tbxEmail.Text };




        }
    }
}
