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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
          
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form6_Load(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            int ans1 = int.Parse(n7.Text);
            int ans2 = int.Parse(n8.Text);
            
            if(ans1+ans2 >100000) //ค่าซ่อมรถ + ซ่อมบ้าน
            {
                l2.Text = "0";
            }
            else
            {
                l1.Text = ans1.ToString();
                l2.Text = ans2.ToString();
            }
            int bn1 = int.Parse(n5.Text); //เมืองหลัก เมืองรอง
            int bn2 = int.Parse(n6.Text);
            if(bn1+bn2 > 20000)
            {
                l3.Text = "0";
                l4.Text = "20000";
            }
            else
            {
                l3.Text = bn1.ToString();
                l4.Text = bn2.ToString();
            }

            int a = int.Parse(n1.Text);
            int b = int.Parse(n2.Text);
            int c = int.Parse(n3.Text);
            int d = int.Parse(n4.Text);
            int f = int.Parse(l3.Text);
            int g = int.Parse(l4.Text);
            int h = int.Parse(l1.Text);
            int i = int.Parse(l2.Text);
            int vat6;
            vat6 = a + b + c + d + f + g + h + i;
            ans6.Text = vat6.ToString();

            int m6 = int.Parse(salary.Text); //รายได้สุทธิ
            int anst6;
            anst6 = m6 - vat6;
            t6.Text = anst6.ToString();




        }

        private void vi_Click(object sender, EventArgs e)
        {
           
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
        
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
       
        }

        private void button4_Click(object sender, EventArgs e)
        {

           
        }

        private void button5_Click(object sender, EventArgs e)
        {
           
        }

        private void button9_Click(object sender, EventArgs e)
        {
            
        }

        private void button8_Click(object sender, EventArgs e)
        {

            Form7 f7 = new Form7();
            f7.sy.Text = t6.Text;
            f7.Show();
            this.Hide();


        }

        private void ans6_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
