using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Guna.UI.WinForms;

namespace Calculate
{
    public partial class CalculatorZoom : Form
    {
        Double result = 0;
        string operation = "";
        bool enter_value, ischeck = false;
        bool enter_input = false;
        string rightNum = "0";
        Double oneXNum = 0;
        string displayCalculate = "";

        public CalculatorZoom()
        {
            InitializeComponent();
            this.SetStyle(ControlStyles.ResizeRedraw, true); // this is to avoid visual artifacts
            input.Text = "0";
        }

        private const int cGrip = 16;
        private const int cCaption = 32;
        protected override void WndProc(ref Message m)
        {
            if (m.Msg == 0x84)
            {
                Point pos = new Point(m.LParam.ToInt32());
                pos = this.PointToClient(pos);
                if (pos.Y < cCaption)
                {
                    m.Result = (IntPtr)2;
                    return;
                }

                if (pos.X >= this.ClientSize.Width - cGrip && pos.Y >= this.ClientSize.Height - cGrip)
                {
                    m.Result = (IntPtr)17;
                    return;
                }
            }
            base.WndProc(ref m);
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void gunaAdvenceButton2_Click(object sender, EventArgs e)
        {
            this.Close();
            Calculator.Instance.Show();
        }

        private void numbers_Only(object sender, EventArgs e)
        {
            GunaAdvenceButton b = (GunaAdvenceButton)sender;
            if (b.Checked) return;

            enter_input = true;
            oneXNum = 0;
            string plusOrMinusBtn = b.Name;

            if (displayCalculate.Split(' ').Length == 3)
            {
                displayCalculate = string.Join(" ", displayCalculate.Split(' ').Reverse().Skip(1).Reverse());
            }

            if ((input.Text == "0") || enter_value || string.IsNullOrEmpty(input.Text))
            {
                input.Text = "0";
                enter_value = false;
            }

            if (input.Text.Equals("Cannot divide by zero"))
            {
                input.Text = "0";
                displayCalculate = "";
                enter_value = false;
                ischeck = false;
                disableBtn();
            }

            if (b.Text == ".")
            {
                if (!input.Text.Contains("."))
                    if (input.Text == "")
                        input.Text = "0";
                input.Text += b.Text;
            }
            else if (plusOrMinusBtn == "plusOrMinusBtn")
            {
                if (input.Text != "0")
                {
                    if (input.Text.ToString()[0] == '-')
                    {
                        input.Text = string.Join("", input.Text.Skip(1).ToArray());
                    }
                    else
                    {
                        input.Text = "-" + input.Text;
                    }
                }
            }
            else
            {
                if (input.Text == "0")
                {
                    input.Text = b.Text;
                }
                else input.Text += b.Text;
            }
        }

        private void operators_Click(object sender, EventArgs e)
        {
            GunaAdvenceButton b = (GunaAdvenceButton)sender;
            if (b.Checked) return;

            oneXNum = 0;
            string buttonName = b.Name;
            String operation2 = "";
            switch (buttonName)
            {
                case "plusBtn":
                    operation2 = "+";
                    break;
                case "minusBtn":
                    operation2 = "-";
                    break;
                case "multiBtn":
                    operation2 = "*";
                    break;
                case "divisionBtn":
                    operation2 = "/";
                    break;
            }

            if (result != 0)
            {
                if (enter_input)
                {
                    equalBtn.PerformClick();
                    result = Double.Parse(input.Text);
                    enter_value = true;
                    displayCalculate = result + " " + operation2;
                }
                else
                {
                    enter_value = true;
                    displayCalculate = input.Text + " " + operation2;
                }
            }
            else
            {
                result = Double.Parse(input.Text);
                enter_value = true;
                displayCalculate = result + " " + operation2;
            }
            enter_input = false;

            switch (buttonName)
            {
                case "plusBtn":
                    operation = "+";
                    break;
                case "minusBtn":
                    operation = "-";
                    break;
                case "multiBtn":
                    operation = "*";
                    break;
                case "divisionBtn":
                    operation = "/";
                    break;
            }

        }

        private void equalBtn_Click(object sender, EventArgs e)
        {
            string number = input.Text;
            switch (operation)
            {
                case "+":
                    if (displayCalculate.Split(' ').Length == 4)
                    {
                        rightNum = displayCalculate.Split(' ')[2];

                        displayCalculate = result.ToString() + " " + operation + " " + rightNum + " =";
                        input.Text = (result + Double.Parse(rightNum)).ToString();
                    }
                    else
                    {
                        displayCalculate = result.ToString() + " " + operation + " " + number + " =";
                        input.Text = (result + Double.Parse(number)).ToString();
                    }
                    break;
                case "-":
                    if (displayCalculate.Split(' ').Length == 4)
                    {
                        rightNum = displayCalculate.Split(' ')[2];
                        displayCalculate = result.ToString() + " " + operation + " " + rightNum + " =";
                        input.Text = (result - Double.Parse(rightNum)).ToString();
                    }
                    else
                    {
                        displayCalculate = result.ToString() + " " + operation + " " + number + " =";
                        input.Text = (result - Double.Parse(number)).ToString();
                    }
                    break;
                case "*":
                    if (displayCalculate.Split(' ').Length == 4)
                    {
                        rightNum = displayCalculate.Split(' ')[2];
                        displayCalculate = result.ToString() + " " + operation + " " + rightNum + " =";
                        input.Text = (result * Double.Parse(rightNum)).ToString();
                    }
                    else
                    {
                        displayCalculate = result.ToString() + " " + operation + " " + number + " =";
                        input.Text = (result * Double.Parse(number)).ToString();
                    }
                    break;
                case "/":
                    if (Double.Parse(input.Text) == 0)
                    {
                        input.Text = "Cannot divide by zero";
                        result = 0;
                        operation = "";
                        displayCalculate = "";
                        input.Enabled = false;
                        ischeck = true;
                        disableBtn();
                        return;
                    }
                    else
                    {
                        if (displayCalculate.Split(' ').Length == 4)
                        {
                            rightNum = displayCalculate.Split(' ')[2];
                            displayCalculate = result.ToString() + " " + operation + " " + rightNum + " =";
                            input.Text = (result / Double.Parse(rightNum)).ToString();
                        }
                        else
                        {
                            displayCalculate = result.ToString() + " " + operation + " " + number + " =";
                            input.Text = (result / Double.Parse(number)).ToString();
                        }
                    }
                    break;
                default:
                    break;
            }

            if (input.Text.Equals("Cannot divide by zero") || string.IsNullOrEmpty(input.Text))
            {
                input.Text = "0";
                input.Enabled = true;
                displayCalculate = "";
                result = 0;
                return;
            }

            result = Double.Parse(input.Text);
        }

        private void backspaceBtn_Click(object sender, EventArgs e)
        {
            if (input.Text.Equals("Cannot divide by zero"))
            {
                input.Text = "0";
                displayCalculate = "";
                ischeck = false;
                disableBtn();
            }
            if (input.Text.Length > 0)
            {
                input.Text = input.Text.Remove(input.Text.Length - 1, 1);
            }
            if (input.Text == "")
            {
                input.Text = "0";
            }
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            if (input.Text.Equals("Cannot divide by zero"))
            {
                ischeck = false;
                disableBtn();
            }
            input.Text = "0";
            displayCalculate = "";
            result = 0;
        }

        private void input_MouseDown(object sender, MouseEventArgs e)
        {
            this.input.SelectionStart = this.input.Text.Length + 1;
            input.Focus();
        }

        private void input_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
            else
            {
                if (this.input.Text.Equals("0"))
                {
                    this.input.Text = "0";
                }

                e.Handled = true;
                if (e.KeyChar != (char)Keys.Back)
                {
                    this.input.Text += e.KeyChar;
                }
                else
                {
                    this.input.Text = this.input.Text.Substring(0, this.input.Text.Length - 1);
                }
            }
        }

        private void disableBtn()
        {
            if (ischeck)
            {
                percentBtn.Checked = true;
                oneXBtn.Checked = true;
                x2Btn.Checked = true;
                sqrtBtn.Checked = true;
                divisionBtn.Checked = true;
                multiBtn.Checked = true;
                minusBtn.Checked = true;
                plusBtn.Checked = true;
                dotBtn.Checked = true;
                plusOrMinusBtn.Checked = true;

                percentBtn.Cursor = Cursors.Default;
                oneXBtn.Cursor = Cursors.Default;
                x2Btn.Cursor = Cursors.Default;
                sqrtBtn.Cursor = Cursors.Default;
                divisionBtn.Cursor = Cursors.Default;
                multiBtn.Cursor = Cursors.Default;
                minusBtn.Cursor = Cursors.Default;
                plusBtn.Cursor = Cursors.Default;
                dotBtn.Cursor = Cursors.Default;
                plusOrMinusBtn.Cursor = Cursors.Default;
            }
            else
            {
                percentBtn.Checked = false;
                oneXBtn.Checked = false;
                x2Btn.Checked = false;
                sqrtBtn.Checked = false;
                divisionBtn.Checked = false;
                multiBtn.Checked = false;
                minusBtn.Checked = false;
                plusBtn.Checked = false;
                dotBtn.Checked = false;
                plusOrMinusBtn.Checked = false;

                percentBtn.Cursor = Cursors.Hand;
                oneXBtn.Cursor = Cursors.Hand;
                x2Btn.Cursor = Cursors.Hand;
                sqrtBtn.Cursor = Cursors.Hand;
                divisionBtn.Cursor = Cursors.Hand;
                multiBtn.Cursor = Cursors.Hand;
                minusBtn.Cursor = Cursors.Hand;
                plusBtn.Cursor = Cursors.Hand;
                dotBtn.Cursor = Cursors.Hand;
                plusOrMinusBtn.Cursor = Cursors.Hand;
            }
        }

        private void oneXBtn_Click(object sender, EventArgs e)
        {
            string number = input.Text;
            if (oneXBtn.Checked == true) return;

            if (Double.Parse(input.Text) == 0)
            {
                input.Text = "Cannot divide by zero";
                displayCalculate = result.ToString() + " / (0)";
                result = 0;
                operation = "";
                input.Enabled = false;
                ischeck = true;
                disableBtn();
                return;
            }
            else
            {
                if (displayCalculate.Split(' ').Length == 4)
                {
                    displayCalculate = "1/(" + input.Text + ")";
                    input.Text = (1 / Double.Parse(input.Text)).ToString();
                }
                else
                {
                    if (oneXNum == 0)
                    {
                        oneXNum = Double.Parse(input.Text);
                        if (displayCalculate.Split(' ').Length == 2)
                        {
                            double leftNum = Double.Parse(displayCalculate.Split(' ')[0]);
                            displayCalculate = displayCalculate.Split(' ')[0] + " " + operation + " " + "1/(" + oneXNum + ")";
                        }
                        else
                        {
                            displayCalculate = "1/(" + oneXNum + ")";
                        }
                        input.Text = (1 / oneXNum).ToString();
                    }
                    else
                    {
                        if (displayCalculate.Split(' ').Length == 3)
                        {
                            double leftNum = Double.Parse(displayCalculate.Split(' ')[0]);
                            string elementTwo = "1/(" + displayCalculate.Split(' ')[2] + ")";
                            displayCalculate = leftNum + " " + operation + " " + elementTwo;

                            input.Text = (1 / Double.Parse(rightNum)).ToString();
                        }
                        else
                        {
                            displayCalculate = "1/(" + displayCalculate + ")";
                            input.Text = (1 / Double.Parse(rightNum)).ToString();
                        }
                    }
                }
                rightNum = input.Text;
            }
        }

        private void x2Btn_Click(object sender, EventArgs e)
        {
            string number = input.Text;
            if (x2Btn.Checked == true) return;
            if (double.IsInfinity(Math.Pow(Double.Parse(input.Text), 2)))
            {
                input.Text = "Overflow";
                ischeck = true;
                disableBtn();

                return;
            }
            if (displayCalculate.Split(' ').Length == 4)
            {
                displayCalculate = "sqr(" + input.Text + ")";
                input.Text = Math.Pow(Double.Parse(input.Text), 2).ToString();
            }
            else
            {
                if (oneXNum == 0)
                {
                    oneXNum = Double.Parse(input.Text);
                    if (displayCalculate.Split(' ').Length == 2)
                    {
                        double leftNum = Double.Parse(displayCalculate.Split(' ')[0]);
                        displayCalculate = displayCalculate.Split(' ')[0] + " " + operation + " " + "sqr/(" + oneXNum + ")";
                    }
                    else
                    {
                        displayCalculate = "sqr(" + oneXNum + ")";
                    }
                    input.Text = Math.Pow(oneXNum, 2).ToString();
                }
                else
                {
                    if (displayCalculate.Split(' ').Length == 3)
                    {
                        double leftNum = Double.Parse(displayCalculate.Split(' ')[0]);
                        string elementTwo = "sqr(" + displayCalculate.Split(' ')[2] + ")";
                        displayCalculate = leftNum + " " + operation + " " + elementTwo;

                        input.Text = Math.Pow(Double.Parse(rightNum), 2).ToString();
                    }
                    else
                    {
                        displayCalculate = "sqr(" + displayCalculate + ")";
                        input.Text = Math.Pow(Double.Parse(rightNum), 2).ToString();
                    }
                }
                rightNum = input.Text;
            }
        }

        private void sqrtBtn_Click(object sender, EventArgs e)
        {

            string number = input.Text;
            if (sqrtBtn.Checked == true) return;

            if (displayCalculate.Split(' ').Length == 4)
            {
                displayCalculate = "√(" + input.Text + ")";
                input.Text = Math.Sqrt(Double.Parse(input.Text)).ToString();
            }
            else
            {
                if (oneXNum == 0)
                {
                    oneXNum = Double.Parse(input.Text);
                    if (displayCalculate.Split(' ').Length == 2)
                    {
                        double leftNum = Double.Parse(displayCalculate.Split(' ')[0]);
                        displayCalculate = displayCalculate.Split(' ')[0] + " " + operation + " " + "√(" + oneXNum + ")";
                    }
                    else
                    {
                        displayCalculate = "√(" + oneXNum + ")";
                    }
                    input.Text = Math.Sqrt(oneXNum).ToString();
                }
                else
                {
                    if (displayCalculate.Split(' ').Length == 3)
                    {
                        double leftNum = Double.Parse(displayCalculate.Split(' ')[0]);
                        string elementTwo = "√(" + displayCalculate.Split(' ')[2] + ")";
                        displayCalculate = leftNum + " " + operation + " " + elementTwo;

                        input.Text = Math.Sqrt(Double.Parse(rightNum)).ToString();
                    }
                    else
                    {
                        displayCalculate = "√(" + displayCalculate + ")";
                        input.Text = Math.Sqrt(Double.Parse(rightNum)).ToString();
                    }
                }
                rightNum = input.Text;
            }
        }

        private void clearInputBtn_Click(object sender, EventArgs e)
        {
            input.Text = "0";
            if (displayCalculate.Split(' ').Length == 4)
            {
                displayCalculate = "";
            }
        }

        private void percentBtn_Click(object sender, EventArgs e)
        {
            if (percentBtn.Checked == true) return;

            if (displayCalculate.Split(' ').Length == 2)
            {
                rightNum = input.Text;

                input.Text = (Convert.ToDouble(input.Text) / 100 * Convert.ToDouble(input.Text)).ToString();

                displayCalculate = result + " " + operation + " " + Convert.ToDouble(input.Text).ToString();

                if (displayCalculate.Split(' ').Length == 4)
                {
                    displayCalculate += " =";
                }

                return;
            }

            if (displayCalculate.Split(' ').Length == 3)
            {
                input.Text = (Convert.ToDouble(rightNum) / 100 * Convert.ToDouble(input.Text)).ToString();


                displayCalculate = result + " " + operation + " " + Convert.ToDouble(input.Text).ToString();

                if (displayCalculate.Split(' ').Length == 4)
                {
                    displayCalculate += " =";
                }

                return;
            }

            if (displayCalculate.Split(' ').Length == 4)
            {
                input.Text = (Convert.ToDouble(input.Text) / 100 * Convert.ToDouble(input.Text)).ToString();

                rightNum = "0";

                displayCalculate = result.ToString();

                return;
            }

            if (displayCalculate.Split(' ').Length == 1 && string.IsNullOrEmpty(displayCalculate))
            {
                input.Text = "0";
                displayCalculate = "0";
            }
            else
            {
                input.Text = (Convert.ToDouble(input.Text) / 100 * Convert.ToDouble(input.Text)).ToString();

                displayCalculate = input.Text.ToString();
                result = Convert.ToDouble(input.Text);
            }
            rightNum = "0";
        }
    }
}
