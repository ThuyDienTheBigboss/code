using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DanhBa
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

    
        
        void CreaterColumFormData()
        {
            var colOrganization = new DataGridTextBoxColumn();
            var colNumberPhone = new DataGridTextBoxColumn();
            var colChief = new DataGridTextBoxColumn();
            var colNote = new DataGridTextBoxColumn();

            colOrganization.HeaderText = "Tên cơ quan ";
            colNumberPhone.HeaderText = "Số điện thoại";
            colChief.HeaderText = "Người đại diện";
            colNote.HeaderText = "ghi chú";

            dtgvPhoneBook.Columns.AddRange(new DataGridViewColumn[] { colNumberPhone, colOrganization, colChief, colNote });
        }
    

        private void Form1_Load(object sender, EventArgs e)
        {
            CreaterColumFormData();
        }
    }
}
