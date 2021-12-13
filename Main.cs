using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inlämningsupggift_final_version
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();

            private Main adresses;
            

        }

        private void btnAddAddress_Click(object sender, EventArgs e)
        {
            var showAddressAdder = new addressAdder(this, );
            
            addressAdder.Show();
        }

         

}

