using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Goldpoint1._0
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string id, pwd;
            id = textBox1.Text;
            pwd = textBox2.Text;
            if (id == "123" && pwd == "123")
            {

                Form4 Form = new Form4();
                Form.ShowDialog();
                this.Hide();
            }
            else
            {
                MessageBox.Show("账号或密码错误");
            }
            
        }
    }
}
