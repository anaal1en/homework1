using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calcul
{
    public partial class Form1 : Form
    {
       
        public string d; //действие
        public string n1; //число, которое было набрано
        public bool n2; //флаг, что начали набирать 2-е число

        public Form1()
        {
            n2 = false;
            InitializeComponent();
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            //стираем первое число и действие перед началом набора второго числа
            if (n2==true)
            {
                n2 = false;
                textBox1.Text = "0";
            }

           Button B = (Button)sender; //sender - кнопка, по которой нажали
            if(textBox1.Text == "0")
                textBox1.Text = B.Text;
            else
                textBox1.Text = textBox1.Text + B.Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0"; //кнопка "стереть"     
        }

       private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button15_Click_1(object sender, EventArgs e)
        {
            Button B = (Button)sender;
            d = B.Text; //запоминаем действие
            n1 = textBox1.Text; //запоминаем набранное число
            n2 = true; //стираем первое число и действие перед началом набора второго числа          
        }

        private void button16_Click(object sender, EventArgs e)
        {
            double dn1, dn2, res;
            res = 0;
            dn1 = Convert.ToDouble(n1);
            dn2 = Convert.ToDouble(textBox1.Text);
            if (d == "+")
            {
                res = dn1 + dn2;
            }
            if (d == "-")
            {
                res = dn1 - dn2;
            }
            if (d == "*")
            {
                res = dn1 * dn2;
            }
            if (d == "/")
            {
                res = dn1 / dn2;
            }
            d = "=";
            n2 = true;
            textBox1.Text = res.ToString();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            if(!textBox1.Text.Contains(","))
            textBox1.Text = textBox1.Text + ",";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double dn, res;
            dn = Convert.ToDouble(textBox1.Text);
            res = -dn;
            textBox1.Text = res.ToString();
        }
    }
}
