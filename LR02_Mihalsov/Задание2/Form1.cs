using System;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            float x, y, z;
            double b;

            x = float.Parse(textBox1.Text);
            y = float.Parse(textBox2.Text);
            z = float.Parse(textBox3.Text);

            b = 1.0 + (Math.Pow(x, 2) + 1.0) / (3.0 + Math.Pow(y, 2)) + Math.Pow(Math.Sin(2.0 * z), 2);

            label4.Text = "b = " + b.ToString();  
        }
    }
}
