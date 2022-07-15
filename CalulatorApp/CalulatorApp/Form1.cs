using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalulatorApp
{
    public partial class Calculator : Form
    {
        private Rectangle oneButtonOriginalRectangle;
        private Rectangle twoButtonOriginalRectangle;
        private Rectangle threeButtonOriginalRectangle;
        private Rectangle fourButtonOriginalRectangle;
        private Rectangle fiveButtonOriginalRectangle;
        private Rectangle sixButtonOriginalRectangle;
        private Rectangle sevenButtonOriginalRectangle;
        private Rectangle eightButtonOriginalRectangle;
        private Rectangle nineButtonOriginalRectangle;
        private Rectangle zeroButtonOriginalRectangle;
        private Rectangle backspaceButtonOriginalRectangle;
        private Rectangle plusMinusButtonOriginalRectangle;
        private Rectangle clearButtonOriginalRectangle;
        private Rectangle decimalButtonOriginalRectangle;
        private Rectangle squarerootButtonOriginalRectangle;
        private Rectangle multiplyButtonOriginalRectangle;
        private Rectangle divideButtonOriginalRectangle;
        private Rectangle minusButtonOriginalRectangle;
        private Rectangle equalButtonOriginalRectangle;
        private Rectangle plusButtonOriginalRectangle;
        private Rectangle displaylabelOriginalRectangle;
        private Size originalFormSize;

        public Calculator()
        {
            InitializeComponent();
        }

        private void Calculator_Load(object sender, EventArgs e)
        {
            originalFormSize = this.Size;
            oneButtonOriginalRectangle = new Rectangle(oneButton.Location.X, oneButton.Location.Y, oneButton.Size.Width, oneButton.Size.Height);
            twoButtonOriginalRectangle = new Rectangle(twoButton.Location.X, twoButton.Location.Y, twoButton.Size.Width, twoButton.Size.Height);
            threeButtonOriginalRectangle = new Rectangle(threeButton.Location.X, threeButton.Location.Y, threeButton.Size.Width, threeButton.Size.Height);
            fourButtonOriginalRectangle = new Rectangle(fourButton.Location.X, fourButton.Location.Y, fourButton.Size.Width, fourButton.Size.Height);
            fiveButtonOriginalRectangle = new Rectangle(fiveButton.Location.X, fiveButton.Location.Y, fiveButton.Size.Width, fiveButton.Size.Height);
            sixButtonOriginalRectangle = new Rectangle(sixButton.Location.X, sixButton.Location.Y, sixButton.Size.Width, sixButton.Size.Height);
            sevenButtonOriginalRectangle = new Rectangle(sevenButton.Location.X, sevenButton.Location.Y, sevenButton.Size.Width, sevenButton.Size.Height);
            eightButtonOriginalRectangle = new Rectangle(eightButton.Location.X, eightButton.Location.Y, eightButton.Size.Width, eightButton.Size.Height);
            nineButtonOriginalRectangle = new Rectangle(nineButton.Location.X, nineButton.Location.Y, nineButton.Size.Width, nineButton.Size.Height);
            zeroButtonOriginalRectangle = new Rectangle(zeroButton.Location.X, zeroButton.Location.Y, zeroButton.Size.Width, zeroButton.Size.Height);
            backspaceButtonOriginalRectangle = new Rectangle(backspaceButton.Location.X, backspaceButton.Location.Y, backspaceButton.Size.Width, backspaceButton.Size.Height);
            plusMinusButtonOriginalRectangle = new Rectangle(plusMinusButton.Location.X, plusMinusButton.Location.Y, plusMinusButton.Size.Width, plusMinusButton.Size.Height);
            clearButtonOriginalRectangle = new Rectangle(clearButton.Location.X, clearButton.Location.Y, clearButton.Size.Width, clearButton.Size.Height);
            decimalButtonOriginalRectangle = new Rectangle(decimalButton.Location.X, decimalButton.Location.Y, decimalButton.Size.Width, decimalButton.Size.Height);
            squarerootButtonOriginalRectangle = new Rectangle(squarerootButton.Location.X, squarerootButton.Location.Y, squarerootButton.Size.Width, squarerootButton.Size.Height);
            multiplyButtonOriginalRectangle = new Rectangle(multiplyButton.Location.X, multiplyButton.Location.Y, multiplyButton.Size.Width, multiplyButton.Size.Height);
            divideButtonOriginalRectangle = new Rectangle(divideButton.Location.X, divideButton.Location.Y, divideButton.Size.Width, divideButton.Size.Height);
            minusButtonOriginalRectangle = new Rectangle(minusButton.Location.X, minusButton.Location.Y, minusButton.Size.Width, minusButton.Size.Height);
            equalButtonOriginalRectangle = new Rectangle(equalButton.Location.X, equalButton.Location.Y, equalButton.Size.Width, equalButton.Size.Height);
            plusButtonOriginalRectangle = new Rectangle(plusButton.Location.X, plusButton.Location.Y, plusButton.Size.Width, plusButton.Size.Height);
            displaylabelOriginalRectangle = new Rectangle(displaylabel.Location.X, displaylabel.Location.Y, displaylabel.Size.Width, displaylabel.Size.Height);
        }
        private void Calculator_Resize(object sender, EventArgs e)
        {
            resizeControl(oneButtonOriginalRectangle, oneButton);
            resizeControl(twoButtonOriginalRectangle, twoButton);
            resizeControl(threeButtonOriginalRectangle, threeButton);
            resizeControl(fourButtonOriginalRectangle, fourButton);
            resizeControl(fiveButtonOriginalRectangle, fiveButton);
            resizeControl(sixButtonOriginalRectangle, sixButton);
            resizeControl(sevenButtonOriginalRectangle, sevenButton);
            resizeControl(eightButtonOriginalRectangle, eightButton);
            resizeControl(nineButtonOriginalRectangle, nineButton);
            resizeControl(zeroButtonOriginalRectangle, zeroButton);
            resizeControl(backspaceButtonOriginalRectangle, backspaceButton);
            resizeControl(plusMinusButtonOriginalRectangle, plusMinusButton);
            resizeControl(clearButtonOriginalRectangle, clearButton);
            resizeControl(decimalButtonOriginalRectangle, decimalButton);
            resizeControl(squarerootButtonOriginalRectangle, squarerootButton);
            resizeControl(multiplyButtonOriginalRectangle, multiplyButton);
            resizeControl(divideButtonOriginalRectangle, divideButton);
            resizeControl(minusButtonOriginalRectangle, minusButton);
            resizeControl(equalButtonOriginalRectangle, equalButton);
            resizeControl(plusButtonOriginalRectangle, plusButton);
            resizeControl(displaylabelOriginalRectangle, displaylabel); 
        }

        private void resizeControl(Rectangle OriginalControlRect, Control control)
        {   //resize math
            float xAxis = (float)(this.Width) / (float)originalFormSize.Width;
            float yAxis = (float)(this.Height) / (float)originalFormSize.Height;
            // where is the box supposed to be
            int newXPosition = (int)(OriginalControlRect.X * xAxis);
            int newYPosition = (int)(OriginalControlRect.Y * yAxis);
            //resize set to height
            int newWidth = (int)(OriginalControlRect.Width * xAxis);
            int newHeight = (int)(OriginalControlRect.Height * yAxis);
            //this changes the location based on original location
            control.Location = new Point(newXPosition, newYPosition);
            control.Size = new Size(newWidth, newHeight);   
        }

        float num1, num2, result;
        char operation;
        bool dec = false;

        private void changeLabel(int numPressed)
        {
            if (dec == true)
            {
                int decimalCount = 0;
                foreach (char c in displaylabel.Text)
                {
                    if (c == '.')
                    {
                        decimalCount++;
                    }
                }
                if (decimalCount < 1)
                {
                    displaylabel.Text = displaylabel.Text + ".";
                }
                dec = false;
            }
            else
            {
                if ((displaylabel.Text.Equals("0") == true && displaylabel.Text != null))
                {
                    displaylabel.Text = numPressed.ToString();
                }
                else if (displaylabel.Text.Equals("-0") == true)
                {
                    displaylabel.Text = "-" + numPressed.ToString();
                }
                else
                {
                    displaylabel.Text = displaylabel.Text + numPressed.ToString();
                }
            }
        }

        private void button20_Click(object sender, EventArgs e)
        {
            changeLabel(0);
        }

        private void oneButton_Click(object sender, EventArgs e)
        {
            changeLabel(1);
        }

        private void twoButton_Click(object sender, EventArgs e)
        {
            changeLabel(2);
        }

        private void threeButton_Click(object sender, EventArgs e)
        {
            changeLabel(3);
        }

        private void fourButton_Click(object sender, EventArgs e)
        {
            changeLabel(4);
        }

        private void fiveButton_Click(object sender, EventArgs e)
        {
            changeLabel(5);
        }

        private void sixButton_Click(object sender, EventArgs e)
        {
            changeLabel(6);
        }

        private void sevenButton_Click(object sender, EventArgs e)
        {
            changeLabel(7);
        }

        private void eightButton_Click(object sender, EventArgs e)
        {
            changeLabel(8);
        }

        private void nineButton_Click(object sender, EventArgs e)
        {
            changeLabel(9);
        }

        private void decimalButton_Click(object sender, EventArgs e)
        {
            dec = true;
            changeLabel(0);
        }

        private void plusMinusButton_Click(object sender, EventArgs e)
        {
            displaylabel.Text = "-" + displaylabel.Text;
        }

        private void squarerootButton_Click(object sender, EventArgs e)
        {
            num1 = float.Parse(displaylabel.Text);
            if (num1 > 0)
            {
                double sqrt = Math.Sqrt(num1);
                displaylabel.Text = sqrt.ToString();
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            displaylabel.Text = "0";
            num1 = 0;
            num2 = 0;
            result = 0;
            operation = '\0';
            dec = false;
        }

        private void backspaceButton_Click(object sender, EventArgs e)
        {
            int stringLength = displaylabel.Text.Length;
            if (stringLength > 1)
            {
                displaylabel.Text = displaylabel.Text.Substring(0, stringLength - 1);
            }
            else
            {
                displaylabel.Text = "0";
            }
        }

        private void muliplyButton_Click(object sender, EventArgs e)
        {
            num1 = float.Parse(displaylabel.Text);
            operation = '*';
            displaylabel.Text = "";
        }

        private void divideButton_Click(object sender, EventArgs e)
        {
            num1 = float.Parse(displaylabel.Text);
            operation = '/';
            displaylabel.Text = "";
        }

        private void minusButton_Click(object sender, EventArgs e)
        {
            num1 = float.Parse(displaylabel.Text);
            operation = '-';
            displaylabel.Text = "";
        }

        private void plusButton_Click(object sender, EventArgs e)
        {
            num1 = float.Parse(displaylabel.Text);
            operation = '+';
            result = result + num1;
            displaylabel.Text = "";
        }

        private void equalButton_Click(object sender, EventArgs e)
        {
            result = 0;
            if (displaylabel.Text.Equals("0") == false)
            {
                switch (operation)
                {
                    case '+':
                        num2 = float.Parse(displaylabel.Text);
                        result = num1 + num2;
                        break;
                    case '-':
                        num2 = float.Parse(displaylabel.Text);
                        result = num1 - num2;
                        break;
                    case '/':
                        num2 = float.Parse(displaylabel.Text);
                        result = num1 / num2;
                        break;
                    case '*':
                        num2 = float.Parse(displaylabel.Text);
                        result = num1 * num2;
                        break;
                    default:
                        break;
                }
            }
            displaylabel.Text = result.ToString();
        }
    }
}