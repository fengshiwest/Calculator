using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        private double op0, op1, op2, resultnum;
        private string opt = "null";

        public Form1()
        {
            InitializeComponent();
        }

        private void OneButton_Click(object sender, EventArgs e)
        {
            if(ResultTextBox.Text.Contains("%"))
            {
                return;
            }
            if (ResultTextBox.Text != "0" & ResultTextBox.Text != "+" & ResultTextBox.Text != "-" & ResultTextBox.Text != "×" & ResultTextBox.Text != "÷")
            {
                ResultTextBox.Text = ResultTextBox.Text + "1";
            }
            else
                ResultTextBox.Text = "1";
        }

        private void TwoButton_Click(object sender, EventArgs e)
        {
            if (ResultTextBox.Text.Contains("%"))
            {
                return;
            }
            if (ResultTextBox.Text != "0" & ResultTextBox.Text != "+" & ResultTextBox.Text != "-" & ResultTextBox.Text != "×" & ResultTextBox.Text != "÷")
            {
                ResultTextBox.Text = ResultTextBox.Text + "2";
            }
            else
                ResultTextBox.Text = "2";
        }

        private void ThreeButton_Click(object sender, EventArgs e)
        {
            if (ResultTextBox.Text.Contains("%"))
            {
                return;
            }
            if (ResultTextBox.Text != "0" & ResultTextBox.Text != "+" & ResultTextBox.Text != "-" & ResultTextBox.Text != "×" & ResultTextBox.Text != "÷")
            {
                ResultTextBox.Text = ResultTextBox.Text + "3";
            }
            else
                ResultTextBox.Text = "3";
        }

        private void FourButton_Click(object sender, EventArgs e)
        {
            if (ResultTextBox.Text.Contains("%"))
            {
                return;
            }
            if (ResultTextBox.Text != "0" & ResultTextBox.Text != "+" & ResultTextBox.Text != "-" & ResultTextBox.Text != "×" & ResultTextBox.Text != "÷")
            {
                ResultTextBox.Text = ResultTextBox.Text + "4";
            }
            else
                ResultTextBox.Text = "4";
        }

        private void FiveButton_Click(object sender, EventArgs e)
        {
            if (ResultTextBox.Text.Contains("%"))
            {
                return;
            }
            if (ResultTextBox.Text != "0" & ResultTextBox.Text != "+" & ResultTextBox.Text != "-" & ResultTextBox.Text != "×" & ResultTextBox.Text != "÷")
            {
                ResultTextBox.Text = ResultTextBox.Text + "5";
            }
            else
                ResultTextBox.Text = "5";
        }

        private void SixButton_Click(object sender, EventArgs e)
        {
            if (ResultTextBox.Text.Contains("%"))
            {
                return;
            }
            if (ResultTextBox.Text != "0" & ResultTextBox.Text != "+" & ResultTextBox.Text != "-" & ResultTextBox.Text != "×" & ResultTextBox.Text != "÷")
            {
                ResultTextBox.Text = ResultTextBox.Text + "6";
            }
            else
                ResultTextBox.Text = "6";
        }

        private void SevenButton_Click(object sender, EventArgs e)
        {
            if (ResultTextBox.Text.Contains("%"))
            {
                return;
            }
            if (ResultTextBox.Text != "0" & ResultTextBox.Text != "+" & ResultTextBox.Text != "-" & ResultTextBox.Text != "×" & ResultTextBox.Text != "÷")
            {
                ResultTextBox.Text = ResultTextBox.Text + "7";
            }
            else
                ResultTextBox.Text = "7";
        }

        private void EightButton_Click(object sender, EventArgs e)
        {
            if (ResultTextBox.Text.Contains("%"))
            {
                return;
            }
            if (ResultTextBox.Text != "0" & ResultTextBox.Text != "+" & ResultTextBox.Text != "-" & ResultTextBox.Text != "×" & ResultTextBox.Text != "÷")
            {
                ResultTextBox.Text = ResultTextBox.Text + "8";
            }
            else
                ResultTextBox.Text = "8";
        }

        

        private void NineButton_Click(object sender, EventArgs e)
        {
            if (ResultTextBox.Text.Contains("%"))
            {
                return;
            }
            if (ResultTextBox.Text != "0" & ResultTextBox.Text != "+" & ResultTextBox.Text != "-" & ResultTextBox.Text != "×" & ResultTextBox.Text != "÷")
            {
                ResultTextBox.Text = ResultTextBox.Text + "9";
            }
            else
                ResultTextBox.Text = "9";
        }

       

        private void ZeroButton_Click(object sender, EventArgs e)
        {
            if (ResultTextBox.Text.Contains("%"))
            {
                return;
            }
            if (ResultTextBox.Text != "0" & ResultTextBox.Text != "+" & ResultTextBox.Text != "-" & ResultTextBox.Text != "×" & ResultTextBox.Text != "÷")
            {
                ResultTextBox.Text = ResultTextBox.Text + "0";
            }
            else
                ResultTextBox.Text = "0";
        }

        

        private void DotButton_Click(object sender, EventArgs e)
        {
            if (ResultTextBox.Text.Contains("%") || ResultTextBox.Text.Contains("."))
            {
                return;
            }
            if (ResultTextBox.Text != "+" & ResultTextBox.Text != "-" & ResultTextBox.Text != "×" & ResultTextBox.Text != "÷")
            {
                ResultTextBox.Text = ResultTextBox.Text + ".";
            }
        }

        

        private void ACButton_Click(object sender, EventArgs e)
        {
            this.ResultTextBox.Text = "0";
            opt = "null";
            op1 = 0;
            op2 = 0;
        }

        

        private void PlusButton_Click(object sender, EventArgs e)
        {
            if(ResultTextBox.Text == "+" || ResultTextBox.Text == "-" ||ResultTextBox.Text == "×" || ResultTextBox.Text == "÷")
            {
                return;
            }
            else
            {
                opt = "plus";
                ResultTextBox.Text = "+";
            }
        }

        

        private void MinusButton_Click(object sender, EventArgs e)
        {
            if (ResultTextBox.Text == "+" || ResultTextBox.Text == "-" || ResultTextBox.Text == "×" || ResultTextBox.Text == "÷")
            {
                return;
            }
            else
            {
                opt = "minus";
                ResultTextBox.Text = "-";
            }
        }

        private void NegativeButton_Click(object sender, EventArgs e)
        {
            if (ResultTextBox.Text == "+" || ResultTextBox.Text == "-" || ResultTextBox.Text == "×" || ResultTextBox.Text == "÷")
            {
                return;
            }
            else
            {
                op0 = double.Parse(ResultTextBox.Text);
                op0 = 0 - op0;
                ResultTextBox.Text = op0.ToString();
            }
        }

        

        private void MultipleButton_Click(object sender, EventArgs e)
        {
            if (ResultTextBox.Text == "+" || ResultTextBox.Text == "-" || ResultTextBox.Text == "×" || ResultTextBox.Text == "÷")
            {
                return;
            }
            else
            {
                opt = "multiple";
                ResultTextBox.Text = "×";
            }
        }

        private void DivideButton_Click(object sender, EventArgs e)
        {
            if (ResultTextBox.Text == "+" || ResultTextBox.Text == "-" || ResultTextBox.Text == "×" || ResultTextBox.Text == "÷")
            {
                return;
            }
            else
            {
                opt = "divide";
                ResultTextBox.Text =  "÷";
            }
        }

        private void RemainderButton_Click(object sender, EventArgs e)
        {
            if (ResultTextBox.Text == "+" || ResultTextBox.Text == "-" || ResultTextBox.Text == "×" || ResultTextBox.Text == "÷")
            {
                return;
            }
            if(ResultTextBox.Text.Contains("%"))
            {
                return;
            }
            else
            {
                ResultTextBox.Text = ResultTextBox.Text + "%";
                if (opt == "null")
                    opt = "percent";
            }
        }

        private void EqualButton_Click(object sender, EventArgs e)
        {
            if (ResultTextBox.Text == "+" || ResultTextBox.Text == "-" || ResultTextBox.Text == "×" || ResultTextBox.Text == "÷")
            {
                return;
            }
            else
            {
                switch (opt)
                {
                    case "null":
                        return;
                    case "plus":
                        resultnum = op1 + op2;
                        break;
                    case "minus":
                        resultnum = op1 - op2;
                        break;
                    case "multiple":
                        resultnum = op1 * op2;
                        break;
                    case "divide":
                        if (op2 == 0)
                        {
                            ResultTextBox.Text = "除数不能为零";
                            return;
                        }
                        resultnum = op1 / op2;
                        break;
                }
                ResultTextBox.Text = resultnum.ToString();
                opt = "null";

            }
        }
    }
}
