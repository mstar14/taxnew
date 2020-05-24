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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
          
        }

        private void Form5_Load(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            int s1 = int.Parse(school.Text); //สนับสนุนการศึกษา
            s1 = s1 * 2;
            l1.Text = s1.ToString();

            int s2 = int.Parse(hospital.Text); //สถานพยาบาลของรัฐ 
            s2 = s2 * 2;
            l2.Text = s2.ToString();

            int s3 = int.Parse(sport.Text); //สนับสนุนการกีฬา
            s3 = s3 * 2;
            l3.Text = s3.ToString();

            int s4 = int.Parse(pub.Text); //บริจาคเพื่อสาธารณประโยชน์ต่างๆ
            s4 = s4 * 2;
            l4.Text = s4.ToString();

            int s5 = int.Parse(storm.Text); //ช่วยเหลืออุทกภัยน้ำท่วมจากพายุปาบึก
            l5.Text = s5.ToString();

            int s6 = int.Parse(gen.Text); //บริจาคทั่วไป
            l6.Text = s6.ToString();

            int s7 = int.Parse(pha.Text); //บริจาคให้พรรคการเมือ
            l7.Text = s7.ToString();


            int a = int.Parse(l1.Text);
            int b = int.Parse(l2.Text);
            int c = int.Parse(l3.Text);
            int d = int.Parse(l4.Text);
            int f = int.Parse(l5.Text);
            int g = int.Parse(l6.Text);
            int h = int.Parse(l7.Text);
            
            int vat5;
            vat5 = a + b + c + d + f + g + h ;
            int m5 = int.Parse(salary.Text);
            int ansm5;
            ansm5=((m5-vat5)*10)/100;
            ans5.Text = ansm5.ToString();

            int anst5; //รายได้สุทธิ
            anst5 = m5 - ansm5;
            t5.Text = anst5.ToString();

          





        }

        private void vi_Click(object sender, EventArgs e)
        {
           
        }

        private void label7_Click(object sender, EventArgs e)
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

        private void button6_Click(object sender, EventArgs e)
        {
       
           
        }

        private void button9_Click(object sender, EventArgs e)
        {
        }

        private void button8_Click(object sender, EventArgs e)
        {
           
            Form6 f6 = new Form6();
            f6.salary.Text = t5.Text;
            f6.Show();
            this.Hide();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void ans5_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}