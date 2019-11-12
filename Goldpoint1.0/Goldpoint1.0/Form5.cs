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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {
            progressBar1.Maximum = 100;
            progressBar1.Minimum = 0;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (this.Opacity < 1)
                this.Opacity += 0.05;
            else
                this.Close();
            progressBar1.Value = (int)(Opacity * 100);
           
           
        }
    }
}
