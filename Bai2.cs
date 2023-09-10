using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace Lab04
{
    public partial class Bai2 : Form
    {
        public Bai2()
        {
            InitializeComponent();
        }

        public string url;
        public Bai2(string url)
        {
            InitializeComponent();
            this.url = url;
            textBox1.Text = url;
        }



        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != null)
            {
                url = textBox1.Text;
            }

            WebClient myClient = new WebClient();
            byte[] respone = myClient.DownloadData(url);
            textBox2.Text = Encoding.UTF8.GetString(respone);
            WebHeaderCollection whc = myClient.ResponseHeaders;

            string[] header = whc.AllKeys;

            listView1.View = View.Details;
            listView1.Columns.Add("Header");
            listView1.Columns.Add("Value");
            int number = 1;
            foreach (string file in header)
            {
                ListViewItem item = new ListViewItem();
                item.Text = number.ToString();
                number++;
                item.SubItems.Add(file);
                item.SubItems.Add(whc.Get(file));
                listView1.Items.Add(item);

            }
            for (int i = 0; i < listView1.Columns.Count; i++)
            {
                listView1.Columns[i].Width = -2;
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            var newForm = new menu();
            newForm.Closed += (s, args) => this.Close();
            newForm.Show();
        }
    }
}