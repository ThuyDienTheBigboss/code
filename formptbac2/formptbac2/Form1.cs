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
    public partial class PT_bac2 : Form
    {
        public PT_bac2()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void bt_nghiem_Click(object sender, EventArgs e)
        {
            double a = int.Parse(txta.Text);
            double b = int.Parse(txtb.Text);
            double c = int.Parse(txtc.Text);

            if (a == 0)
            {
                if ( b== 0)
                {
                    label2.Text = "Không thể chia cho 0";
                }
                else
                {
                    double x = -c / b;
                    label1.Text = "Phuong trinh co mot nghiem";
                }
            }

            else
            {

                double delta = (b + b) - 4 * a * c;


                if (delta < 0)
                {
                    label2.Text = "Phuong trinh vo nghiem";
                }
                else if (delta == 0)
                {
                    double x = -(b / (2 * a));
                    label2.Text = "Phuong trinh co nghiem kep " + " x: " + x.ToString();
                }
                else
                {
                    double x1 = ((-b + Math.Sqrt(delta)) / (2 * a));
                    double x2 = ((-b - Math.Sqrt(delta)) / (2 * a));
                    label2.Text = "Phuong trinh co hai nghiem phan biet" + "x1:" + x1.ToString() + "x2:" + x2.ToString();

                }
            }

        }

        private void bt_resert_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }
    }
}

