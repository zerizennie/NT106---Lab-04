using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab04
{
    public partial class menu : Form
    {
        public menu()
        {
            InitializeComponent();
        }



        private void button1_Click_1(object sender, EventArgs e)
        {
            Form frm2 = new Bai2();
            frm2.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form frm3 = new Bai3();
            frm3.Show();
        }
    }
}
