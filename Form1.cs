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
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void nchild_CheckedChanged(object sender, EventArgs e)
        {
        
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            
       
        }

        private void button3_Click(object sender, EventArgs e)
        {
           
         
        }

        private void button7_Click(object sender, EventArgs e)
        {
           
            Form2 f2 = new Form2();
            f2.textBox1.Text = cal.Text;
            f2.Show();
            this.Hide();
            
            

          

        }

        private void button2_Click(object sender, EventArgs e)
        {
           
        }

        private void button4_Click(object sender, EventArgs e)
        {
           
         
        }

        private void button5_Click(object sender, EventArgs e)
        {
         
          
        }

        private void button6_Click(object sender, EventArgs e)
        {

          
        }

        private void cal_Click(object sender, EventArgs e)
        {

            int a = int.Parse(srl.Text);
            int b = int.Parse(bonus.Text);
            int c = int.Parse(esrl.Text);
            int y, outcome;
            y = (a * 12);
            outcome = y + b + c;
            cal.Text = outcome.ToString();

            
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
