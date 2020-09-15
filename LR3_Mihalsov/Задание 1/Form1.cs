using System;
using System.Windows.Forms;

namespace _1_WindowsFormsApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            float x;
            double y;

            x = float.Parse(textBox1.Text);
        
            if( x <= 0)
            {
                y = Math.Exp(2.0 * x);
                label2.Text = "Выбрано условие: x <= 0";
            } 
            else
            {
                if (0.0 < x  && x < 7.0)
                {
                    y = Math.Sqrt(Math.Abs(Math.Pow(x, 2) - 2));
                    label2.Text = "Выбрано условие: 0 < x < 7";
                } 
                else
                {
                    y = x / 2.0 - Math.Pow(x, 2);
                    label2.Text = "Выбрано условие: \nВо всех остальных случаях";
                }
            }

            label3.Text = "y = " + y.ToString();

        }
    }
}
