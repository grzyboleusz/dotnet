using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculatron3000
{
    public partial class Form1 : Form
    {
        private double n;
        private double m;
        enum operations { NONE, ADD, SUB, MUL, DIV, POW, ROOT, EQ};
        bool new_number = true;
        bool eq = false;

        private operations operation;
        public Form1()
        {
            m = 0;
            n = 0;
            InitializeComponent();
        }

        private void Execute()
        {
            double temp = 0;
            double.TryParse(textBox.Text, out temp);
            switch (operation)
            { 
                case operations.ADD:
                    textBox.Text = (n + temp).ToString();
                    break;
                case operations.SUB:
                    textBox.Text = (n - temp).ToString();
                    break;
                case operations.MUL:
                    textBox.Text = (n * temp).ToString();
                    break;
                case operations.DIV:
                    if (temp == 0)
                        textBox.Text = "ERROR!";
                    else
                        textBox.Text = (n / temp).ToString();
                    break;
                case operations.POW:
                    textBox.Text = (Math.Pow(n, temp)).ToString();
                    break;
                case operations.ROOT:
                    temp = Math.Pow(n, 1 / temp);
                    textBox.Text = (temp).ToString();
                    break;
            }
        }

        private void WriteNumber(object sender)
        {
            
            string text = ((Button)sender).Text;

            if (new_number)
            {
                textBox.Text = text;
                new_number = false;
            } 
            else
                textBox.Text += text;
        }

        private void RemoveComa()
        {
            if (textBox.Text.EndsWith(","))
                textBox.Text = textBox.Text.TrimEnd(',');
        }

        private void button0_Click(object sender, EventArgs e)
        {
            double temp = 0;
            double.TryParse(textBox.Text, out temp);
            if (textBox.Text.Length > 1 || temp != 0)
                WriteNumber(sender);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            WriteNumber(sender);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            WriteNumber(sender);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            WriteNumber(sender);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            WriteNumber(sender);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            WriteNumber(sender);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            WriteNumber(sender);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            WriteNumber(sender);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            WriteNumber(sender);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            WriteNumber(sender);
        }

        private void buttonADD_Click(object sender, EventArgs e)
        {
            if (operation == operations.ADD && !eq)
            {
                Execute();
                eq = false;
            }

            n = 0;
            double.TryParse(textBox.Text, out n);
            operation = operations.ADD;
            new_number = true;
            RemoveComa();
        }

        private void buttonEQ_Click(object sender, EventArgs e)
        {
            Execute();
            eq = true;
            new_number = true;
        }

        private void buttonDOT_Click(object sender, EventArgs e)
        {
            if (!textBox.Text.Contains(","))
            {
                textBox.Text += ",";
                new_number = false;
            }
        }

        private void buttonSUB_Click(object sender, EventArgs e)
        {
            if (operation == operations.SUB && !eq)
            {
                Execute();
                eq = false;
            }

            n = double.Parse(textBox.Text);
            operation = operations.SUB;
            new_number = true;
            RemoveComa();
        }

        private void buttonMUL_Click(object sender, EventArgs e)
        {
            if (operation == operations.MUL && !eq)
            {
                Execute();
                eq = false;
            }

            n = double.Parse(textBox.Text);
            operation = operations.MUL;
            new_number = true;
            RemoveComa();
        }

        private void buttonDIV_Click(object sender, EventArgs e)
        {
            if (operation == operations.DIV && !eq)
            {
                Execute();
                eq = false;
            }

            n = double.Parse(textBox.Text);
            operation = operations.DIV;
            new_number = true;
            RemoveComa();
        }

        private void buttonMPLUS_Click(object sender, EventArgs e)
        {
            double temp = 0;
            double.TryParse(textBox.Text, out temp);
            m += temp;
        }

        private void buttonMMINUS_Click(object sender, EventArgs e)
        {
            double temp = 0;
            double.TryParse(textBox.Text, out temp);
            m -= temp;
        }

        private void buttonMC_Click(object sender, EventArgs e)
        {
            m = 0;
            new_number = true;
        }

        private void buttonMR_Click(object sender, EventArgs e)
        {
            textBox.Text = m.ToString();
            new_number = true;
        }

        private void buttonMS_Click(object sender, EventArgs e)
        {
            double.TryParse(textBox.Text, out m);
            new_number = true;
        }

        private void buttonDELETE_Click(object sender, EventArgs e)
        {
            int len = textBox.Text.Length;
            if (len == 1 || (len == 2  && (textBox.Text.Contains('-'))))
            {
                textBox.Text = "0";
                new_number = true;
            }
            else
                textBox.Text = textBox.Text.Substring(0, len - 1);
        }

        private void buttonCE_Click(object sender, EventArgs e)
        {
            textBox.Text = "0";
            new_number = true;
        }

        private void buttonC_Click(object sender, EventArgs e)
        {
            textBox.Text = "0";
            new_number = true;
            n = 0;
            eq = true;

        }

        private void buttonSQRT_Click(object sender, EventArgs e)
        {
            double temp = 0;
            double.TryParse(textBox.Text, out temp);
            temp = Math.Sqrt(temp);
            textBox.Text = temp.ToString();
            new_number = true;
        }

        private void buttonPERCENT_Click(object sender, EventArgs e)
        {
            double temp = 0;
            double.TryParse(textBox.Text, out temp);
            temp = temp * (n / 100);
            textBox.Text = temp.ToString();
            new_number = true;
        }

        private void button1DIVX_Click(object sender, EventArgs e)
        {
            double temp = 0;
            double.TryParse(textBox.Text, out temp);
            temp = 1.0 / temp;
            textBox.Text = temp.ToString();
            new_number = true;
        }

        private void buttonPOWER_Click(object sender, EventArgs e)
        {
            if (operation == operations.POW && !eq)
            {
                Execute();
                eq = false;
            }

            n = double.Parse(textBox.Text);
            operation = operations.POW;
            new_number = true;
            RemoveComa();
        }

        private void buttonPLUSMIN_Click(object sender, EventArgs e)
        {
            double temp = 0;
            double.TryParse(textBox.Text, out temp);
            temp = -temp;
            textBox.Text = temp.ToString();
        }

        private void buttonLOG_Click(object sender, EventArgs e)
        {
            double temp = 0;
            double.TryParse(textBox.Text, out temp);

            temp = Math.Log(temp);

            textBox.Text = temp.ToString();
            new_number = true;
        }

        private void buttonROOT_Click(object sender, EventArgs e)
        {
            if (operation == operations.ROOT && !eq)
            {
                Execute();
                eq = false;
            }

            n = double.Parse(textBox.Text);
            operation = operations.ROOT;
            new_number = true;
            RemoveComa();
        }

        private void buttonSIN_Click(object sender, EventArgs e)
        {
            double temp = 0;
            double.TryParse(textBox.Text, out temp);

            temp = Math.Sin(temp);

            textBox.Text = temp.ToString();
            new_number = true;
        }

        private void buttonCOS_Click(object sender, EventArgs e)
        {
            double temp = 0;
            double.TryParse(textBox.Text, out temp);

            temp = Math.Cos(temp);

            textBox.Text = temp.ToString();
            new_number = true;
        }

        private void buttonTAN_Click(object sender, EventArgs e)
        {
            double temp = 0;
            double.TryParse(textBox.Text, out temp);

            temp = Math.Tan(temp);

            textBox.Text = temp.ToString();
            new_number = true;
        }
    }
}
