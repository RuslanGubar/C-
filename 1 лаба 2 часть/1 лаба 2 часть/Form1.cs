using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1_лаба_2_часть
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double x = Convert.ToDouble(textBox1.Text);
            double y = Convert.ToDouble(textBox2.Text);
            double max = 0;
            double min = 0;
            if (x > y)
            {
                max = x;
                min = y;
            }
            else
            {
                max = y;
                min = x;
            }
            label1.Text = "максимальное значение: " + max;
            label2.Text = "минимальное значение: " + min;
        }
    }
}
