using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassLibrary1;

namespace Задание_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int x1;
            int x2;

            int.TryParse(textBox1.Text, out x1);
            int.TryParse(textBox2.Text, out x2);

            textBox1.Text = x1.ToString();
            textBox2.Text = x2.ToString();

            string result = "";
            try
            {
                if (radioButton1.Checked)
                    result = Calculator.Summ(x1, x2).ToString();
                if (radioButton2.Checked)
                    result = Calculator.Division(x1, x2).ToString();
                if (radioButton3.Checked)
                    result = Calculator.Multiply(x1, x2).ToString();
                if (radioButton4.Checked)
                    result = Calculator.Residual(x1, x2).ToString();
            }    
            catch (Exception)
            {
                result = "error";
            }

            label3.Text = result;
        }
    }
}
