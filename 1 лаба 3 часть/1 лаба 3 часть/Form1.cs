using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1_лаба_3_часть
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double x = Convert.ToDouble(textBox1.Text);
            double y = Convert.ToDouble(textBox2.Text);
            double a = Convert.ToDouble(textBox3.Text);
            string q = "a";
            if (a>x && a<y)
            {
                q = "число принадлежить интервалу";
            }
            else
            {
                q = "число не принадлежить интервалу";
            }
            label3.Text = q ;
        }
    }
}
