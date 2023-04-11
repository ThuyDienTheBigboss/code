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
    public partial class F_main : Form
    {
        public F_main()
        {
            InitializeComponent();
        }

        private void F_main_Load(object sender, EventArgs e)
        {
            IsMdiContainer = true;
        }

        private void pTbac2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PT_bac2 fptb2= new PT_bac2();
            fptb2 .Show();
            fptb2.MdiParent= this;
        }

        private void đăngNhậpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            login login=new login();
            login.Show();
            login.MdiParent = this; 
        }

        private void phòngBanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PhongBan phongBan= new PhongBan();
            phongBan .Show();
              phongBan.MdiParent = this;
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void tàiKhoảnToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
