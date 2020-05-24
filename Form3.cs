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
    public partial class Form3 : Form
    {
       
        public Form3()
        {
            InitializeComponent();
      

        }

        private void Form3_Load(object sender, EventArgs e)
        {
          
        }

        private void label2_Click(object sender, EventArgs e)
        {
            
        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void n7_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void p7_CheckedChanged(object sender, EventArgs e)
        {

        }

        public void gone_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (p1.Checked) //ประกันสังคม
            {
                int m1 = int.Parse(n1.Text);
                if (m1 <= 9000)
                {
                    gone.Text = m1.ToString();
                }
                else
                {
                    gone.Text = "9000";

                }
                label1.Text = gone.Text;


            }
            if (p2.Checked) //ประกันสังคม
            {
                int m2 = int.Parse(n2.Text);
                if (m2 <= 100000)
                {
                    gone.Text = m2.ToString();
                }
                else
                {
                    gone.Text = "100000";
                }
                label2.Text = gone.Text;

            }
            if (p3.Checked) //เบี้ยประกันสุขภาพ
            {
                int m2 = int.Parse(n2.Text);
                int m3 = int.Parse(n3.Text);
                if (m2 < 100000)
                {
                    gone.Text = m3.ToString();
                }
                else
                {
                    gone.Text = "0";

                }
                label3.Text = gone.Text;


            }
            if (p4.Checked) //เบี้ยประกันสุขภาพบิดามารดา
            {
                int m4 = int.Parse(n4.Text);
                if (m4 <= 15000)
                {
                    gone.Text = m4.ToString();
                }
                else
                {
                    gone.Text = "15000";
                }
                label4.Text = gone.Text;


            }
            if (p5.Checked) //ประกันชีวิตคู่สมรส
            {
                int m5 = int.Parse(n5.Text);
                if (status2.Checked)
                {
                    if (m5 < 10000)
                    {
                        gone.Text = m5.ToString();
                    }
                    else
                    {
                        gone.Text = "10000";
                    }
                }
                else
                {
                    gone.Text = "0";
                }
                label5.Text = gone.Text;
            }
            if (p6.Checked) //เงินกองทุนสำรองเลี้ยงชีพ
            {
                int m6 = int.Parse(n6.Text);
                if (m6 <= 10000)
                {
                    gone.Text = m6.ToString();
                }
                else
                {
                    gone.Text = "10000";
                }
                label6.Text = gone.Text;


            }
            if (p7.Checked) //เงินสะสมกองทุน
            {
                int m7 = int.Parse(n7.Text);
                if (m7 <= 500000)
                {
                    gone.Text = m7.ToString();
                }
                else
                {
                    gone.Text = "500000";
                }
                label7.Text = gone.Text;

            }
            int aws1 = int.Parse(label1.Text);
            int aws2 = int.Parse(label2.Text);
            int aws3 = int.Parse(label3.Text);
            int aws4 = int.Parse(label4.Text);
            int aws5 = int.Parse(label5.Text);
            int aws6 = int.Parse(label6.Text);
            int aws7 = int.Parse(label7.Text);
            int tax;
            tax = aws1 + aws2 + aws3 + aws4 + aws5 + aws6 + aws7;
            gone.Text = tax.ToString();

            int srl = int.Parse(salary.Text); //รายได้สุทธิ
            int m;
            m = srl - tax;
            t3.Text = m.ToString();



        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void status1_CheckedChanged(object sender, EventArgs e)
        {
            if (status1.Checked)
            {
                p5.Enabled = false;
                n5.Enabled = false;
            }
            else
            {
                p5.Enabled = true;
                n5.Enabled = true;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void p5_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void vi_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
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

        private void button9_Click(object sender, EventArgs e)
        {
            
        }

        private void button8_Click(object sender, EventArgs e)
        {
            
            Form4 f4 = new Form4();
            f4.salary.Text = t3.Text;
            f4.Show();
            this.Hide();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            
        }
    }
}
