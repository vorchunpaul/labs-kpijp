using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace Задание_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
                button3.Visible = true;
            else
                button3.Visible = false;
        }

        MatchCollection matchs;
        Regex regex;

        string spaseexp;
        string spasepatert;
        string finaltext;
        static bool initsteping = false;
        static List<int> greenList;
        static int greenLenth;
        string msg;
        private void button3_Click(object sender, EventArgs e)
        {
            if(matchs.Count == 0)
            {
                richTextBox1.Select(0, richTextBox1.Text.Length);
                richTextBox1.SelectionBackColor = Color.White;
                richTextBox1.Select(0,0);
                label1.Text = finaltext;

                button1.Enabled = true;
                button2.Enabled = true;
                button3.Enabled = false;

                return;
            }
            if(initsteping)
            {
                msg = msg.Remove(matchs[0].Index, matchs[0].Length);
                msg = msg.Insert(matchs[0].Index, spasepatert);
                richTextBox1.Text = msg;
                greenList.Add(matchs[0].Index);
            }
            else
            {
                initsteping = true;
            }

            matchs = regex.Matches(msg);
            SelectMath(matchs);
            SelectGreen(greenList, greenLenth);
        }

        void SelectMath(MatchCollection mc)
        {
            foreach (Match i in mc)
            {
                SelectOneColor(i.Index, i.Length, Color.Yellow);
            }
        }

        void SelectGreen(List<int> gl, int length)
        {
            foreach(var i in gl)
            {
                SelectOneColor(i, length, Color.Green);
            }
        }
        void SelectOneColor(int index, int length, Color c)
        {
            richTextBox1.Select(index, length);
            richTextBox1.SelectionBackColor = c;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(!checkBox1.Checked)
            {
                fastSpace();
                return;
            }

            spaseexp = @"\s{2,}";
            spasepatert = " ";
            finaltext = "Все лишние пробыле убраны";

            initSteping();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (!checkBox1.Checked)
            {
                fastNewLine();
                return;
            }

            spaseexp = @"[.][ ]";
            spasepatert = ".\n";
            finaltext = "Все предложения разделены";

            initSteping();
        }

        private void initSteping()
        {
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = true;

            greenLenth = spasepatert.Length;

            greenList = new List<int>();
            regex = new Regex(spaseexp);

            msg = richTextBox1.Text;
            matchs = regex.Matches(msg);
        }


        private void fastSpace()
        {
            string msg = richTextBox1.Text;
            string pattern = @"\s+";
            string target = " ";
            Regex regex = new Regex(pattern);
            string result = regex.Replace(msg, target);

            richTextBox1.Text = result;

            label1.Text = "Все лишние пробелы были удалены";
        }

        private void fastNewLine()
        {
            string msg = richTextBox1.Text;
            string pattern = @"[.]\s{0,}";
            string target = ".\n";
            Regex regex = new Regex(pattern);
            string result = regex.Replace(msg, target);

            richTextBox1.Text = result;

            label1.Text = "Все предложения начинаються с новой строки";
        }
    }
}
