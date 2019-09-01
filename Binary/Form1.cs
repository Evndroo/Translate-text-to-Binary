using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Binary
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            if (txtName.Text == "")
            {
                MessageBox.Show("Enter your name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtName.Focus();
            }
            else {
                txtResult.Text = "";
                pnlResult.Visible = true;
                string name = txtName.Text;
                byte[] ASCIIValues = Encoding.ASCII.GetBytes(name);
                foreach (byte b in ASCIIValues)
                {
                    txtResult.Text += Convert.ToString(b, 2).PadLeft(8, '0');


                }
            }
        }        
    }
}
