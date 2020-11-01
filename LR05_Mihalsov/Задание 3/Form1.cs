using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Задание_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        class functionChose
        {
            int _chose;
            float _x;

            double f1(float x)
            {
                return Math.Pow(Math.Sin(x), 4);
            }
            double f2(float x)
            {
                return Math.Pow(x, 3 - 0.2 * x);
            }
            double f3(float x)
            {
                return Math.Pow(x, 2) - 6 * x + 18;
            }

            public functionChose(int chose, float x)
            {
                _chose = chose;
                _x = x;
            }

            public double Y
            {
                get
                {
                    switch (_chose)
                    {
                        case 1:
                            return f1(_x);
                            break;
                        case 2:
                            return f2(_x);
                            break;
                        case 3:
                            return f3(_x);
                            break;
                        default:
                            return -1.0;
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            float x;
            double y = 0;
            // n - переменная для сохранеия выбранной пользователем функции
            int n;

            x = float.Parse(textBox1.Text);
            n = int.Parse(textBox2.Text);

            if(!(n >= 1 && n <= 3))
            {
                label4.Text = "Введиете номер функции от 1 до 3 !!!";
                return;
            }

            functionChose F = new functionChose(n, x);

            label4.Text = "Y = " + F.Y.ToString();
        }
    }
}
