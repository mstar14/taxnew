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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            
            
        }

        private void button1_Click(object sender, EventArgs e)
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

        private void button6_Click(object sender, EventArgs e)
        {
        
          
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (nchild.Checked)
            {
                childans.Enabled = false;
                child60.Enabled = false;
                child61.Enabled = false;

            }
            else
            {
                childans.Enabled = true;
                child60.Enabled = true;
                child61.Enabled = true;
            }
               
        }

        private void button7_Click(object sender, EventArgs e)//กลุ่มที่หนึ่ง ลดหย่อนเกี่ยวกับตัวเองและครอบครัว
        {
            if (p1.Checked) //คู่สมรสที่ไม่มีรายได้
            {
                int m1 = int.Parse(n1.Text);
    
                if(m1 <= 60000)
                {
                    v1.Text = m1.ToString();
                }
                else
                {
                    v1.Text = "60000";
                }
            }
            if (p2.Checked) //ค่าฝากครรภ์และค่าคลอดบุตร
            {
                int m2 = int.Parse(n2.Text);

                if (m2 <= 60000)
                {
                    v2.Text = m2.ToString();
                }
                else
                {
                    v2.Text = "60000";
                }
            }
            int pr = int.Parse(parent.Text); //พ่อแม่
            int ans;
            ans = pr * 30000;
            pans.Text = ans.ToString();

            if (child.Checked) //ลูก
            {
                int c60 = int.Parse(child60.Text);
                int c61 = int.Parse(child61.Text);
                int cans;
                if (c60 < 1)
                {
                    
                    if (c61 + c60 <= 1)
                    {
                        cans = c61 * 30000;
                    }
                    else
                    {
                        cans = (c61 - 1) * 60000 + 30000;
                    }
                

                }
                else
                {
                    
                    cans =( c60 * 30000)+(c61*60000);
                    
                   
                } 
                 childans.Text = cans.ToString();
                 label7.Text = cans.ToString();

                
            }

            int dsb = int.Parse(sos.Text); //ผู้พิการ
            int adsb;
            adsb = dsb * 60000;
            disabled.Text = adsb.ToString();

            int a = int.Parse(textBox2.Text);
            int b = int.Parse(v1.Text);
            int c = int.Parse(v2.Text);
            int d = int.Parse(pans.Text);
            int f = int.Parse(label7.Text);
            int g = int.Parse(disabled.Text);
            int tax;
            tax = a + b + c + d + f + g;
            anstax.Text = tax.ToString();

            int t1 = int.Parse(textBox1.Text); //รายได้สุทธิ
            int ran;
            ran = t1 - tax;
            t2.Text = ran.ToString();




        }

        private void button8_Click(object sender, EventArgs e)
        {
            
        }

        private void vi_Click(object sender, EventArgs e)
        {
           
        }

        private void button9_Click(object sender, EventArgs e)
        {
           
        }

        private void button8_Click_1(object sender, EventArgs e)
        {
           
            Form3 f3 = new Form3();
            f3.salary.Text = t2.Text;
            f3.Show();
            this.Hide();
        }

        private void anstax_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void outcome_TextChanged(object sender, EventArgs e)
        {

        }

        private void labal_Click(object sender, EventArgs e)
        {

        }

        private void sal_Click(object sender, EventArgs e)
        {

        }

        private void label19_Click(object sender, EventArgs e)
        {

        }

        private void vatans_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
