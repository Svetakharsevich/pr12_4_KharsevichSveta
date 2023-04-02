using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _13pr
{
    public partial class Form1 : Form
    {
        Flowers a1 = new Flowers(); 
        public Form1()
        {
            InitializeComponent();
            button4.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
          
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || numericUpDown1.Value == 0 || numericUpDown2.Value == 0) MessageBox.Show("Введите значения", "Ошибка");
            
            else
            {
                
                a1.Name=textBox1.Text;
                a1.Type = textBox2.Text;
                a1.Country = textBox3.Text;
                a1.Length = Convert.ToInt32(numericUpDown1.Value);
                a1.Price = Convert.ToInt32(numericUpDown2.Value);
                label6.Text = "Название:"+ a1.Name + "\r" +"Тип:"+a1.Type + "\r" +"Страна-производитель:"+ a1.Country + "\r" +"Длина стебля:" +a1.Length + "\r" +"Цена :"+a1.price_more(Convert.ToInt32(numericUpDown3.Value));
                
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
           
            int counts = Convert.ToInt32(numericUpDown3.Value);
            a1.Price = Convert.ToInt32(numericUpDown2.Value);
            int cont = a1.bounquent(counts);
            label7.Text = cont.ToString();
            button4.Visible = true;
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        { 
          
           
                label9.Text = Flowers.price_bye.ToString();

          
          
        }
        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDown4_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            numericUpDown1.Value = 0;
            numericUpDown2.Value = 100;
            a1.Name = (textBox1.Text);
            a1.Type = textBox2.Text;
            a1.Country = textBox3.Text;
            a1.Length = Convert.ToInt32(numericUpDown1.Value);
            a1.Price = Convert.ToInt32(numericUpDown2.Value);
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}
