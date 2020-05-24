using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace vatPJ
{
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void Form7_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int tx = int.Parse(sy.Text);
            int w;
            if (tx <= 150000)
            {
                w = 0;
                outcome.Text = w.ToString();
            }
            else if (tx <= 300000)
            {
                w = (tx * 5) / 100;//5%
                outcome.Text = w.ToString();
            }
            else if (tx <= 500000)
            {
                w = (tx * 10) / 100;//10%
                outcome.Text = w.ToString();
            }
            else if (tx <= 750000)
            {
                w = (tx * 15) / 100; //15%
                outcome.Text = w.ToString();
            }
            else if (tx <= 1000000)
            {
                w = (tx * 20) / 100; //20%
                outcome.Text = w.ToString();
            }
            else if (tx <= 2000000)
            {
                w = (tx * 25) / 100; //25%
                outcome.Text = w.ToString();
            }
            else if (tx <= 5000000)
            {
                w = (tx * 30) / 100;//30%
                outcome.Text = w.ToString();
            }
            else
            {
                w = (tx * 35) / 100;//35%
                outcome.Text = w.ToString();
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
            this.Hide();
        }
    }
}
