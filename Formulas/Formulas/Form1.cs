using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Formulas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a = int.Parse(textBox1.Text);
            int b = int.Parse(textBox2.Text);
            int c = int.Parse(textBox3.Text);
           
            if(comboBox1.SelectedItem=="Триъгълник" )
            {
                
                label7.Text = (a+b+c).ToString();
                label9.Text = "Формулата е: (a+b+c)";
            }
            if (comboBox1.SelectedItem == "Квадрат" )
            {               
                label7.Text = (a*4).ToString();
                label9.Text = "Формулата е: (a*4)";
            }
            if (comboBox1.SelectedItem == "Правоъгълник")
            {
                label7.Text = ((2*a)+(2*b)).ToString();
                label9.Text = "Формулата е: (2*a)+(2*b)";
            }
            if (comboBox1.SelectedItem == "Ромб")
            {
                
                
                
                label7.Text = (2*(a+b)).ToString();
                label9.Text = "Формулата е: 2*(a+b)";
            }

        }
    }
}
