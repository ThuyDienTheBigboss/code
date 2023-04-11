using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace formptbac2
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

       

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                textBox2.UseSystemPasswordChar == false;

            }
            else
            {
                textBox2.UseSystemPasswordChar == true;
            }
        }
    }
}

