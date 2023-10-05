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
        bool checkClick = false;
        string rightNum = "0";
        Double oneXNum = 0;
        string displayCalculate = "";
        History history = History.Instance;
        CaculatorTab calculatorTab = CaculatorTab.Instance;
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

            if (removeComma(input.Text).Equals("Cannot divide by zero") || removeComma(input.Text).Equals("Overflow") || removeComma(input.Text).Equals("Invalid input"))
            {
                input.Text = "0";
                input.Enabled = true;
                displayCalculate = "";
                enter_value = false;
                ischeck = false;
                disableBtn();
            }

            if (removeComma(input.Text.Split('.')[0]).Length >= 15)
            {
                if (enter_value)
                {
                    this.input.Text = b.Text;
                }
                return;
            }

            oneXNum = 0;
            string plusOrMinusBtn = b.Name;
            enter_input = true;

            if (((removeComma(input.Text) == "0") || enter_value || string.IsNullOrEmpty(removeComma(input.Text))) && plusOrMinusBtn != "plusOrMinusBtn")
            {
                input.Text = "0";
                enter_value = false;
            }

            if (displayCalculate.Split(' ').Length == 3 && plusOrMinusBtn != "plusOrMinusBtn")
            {
                displayCalculate = string.Join(" ", displayCalculate.Split(' ').Reverse().Skip(1).Reverse());
            }

            if (displayCalculate.Split(' ').Length == 4)
            {
                if (plusOrMinusBtn != "plusOrMinusBtn")
                {
                    displayCalculate = "";
                    input.Text = generateComma(b.Text);
                    result = Double.Parse(removeComma(input.Text));
                }
                else
                {
                    displayCalculate = "negate(" + removeComma(input.Text) + ")";
                    input.Text = generateComma((Double.Parse(removeComma(input.Text)) * -1).ToString());
                    rightNum = "0";
                    oneXNum = 0;
                }

                return;
            }

            if (b.Text == ".")
            {
                if (!removeComma(input.Text).Contains(".") && removeComma(input.Text) == "")
                    input.Text = "0";
                input.Text += b.Text;
            }
            else if (plusOrMinusBtn == "plusOrMinusBtn")
            {
                string tmp;
                if (removeComma(input.Text) != "0")
                {
                    tmp = removeComma(input.Text).StartsWith("-") ? removeComma(input.Text).Substring(1) : removeComma(input.Text);

                    if (displayCalculate.Split(' ').Length == 1 && !string.IsNullOrEmpty(displayCalculate))
                    {
                        displayCalculate = "negate(" + displayCalculate + ")";
                        input.Text = generateComma((Double.Parse(removeComma(input.Text)) * -1).ToString());
                        oneXNum = Double.Parse(removeComma(input.Text)) * -1;
                        rightNum = removeComma(input.Text);
                        result = oneXNum;
                        return;
                    }

                    if (displayCalculate.Split(' ').Length == 4)
                    {
                        displayCalculate = "negate(" + tmp + ")";
                        input.Text = (Double.Parse(removeComma(input.Text)) * -1).ToString();
                        rightNum = "0";
                        oneXNum = 0;
                        return;
                    }

                    if (displayCalculate.Split(' ').Length == 3)
                    {
                        double leftNum = Double.Parse(displayCalculate.Split(' ')[0]);
                        string elementTwo = "negate(" + displayCalculate.Split(' ')[2] + ")";
                        displayCalculate = leftNum + " " + operation + " " + elementTwo;
                        oneXNum = Double.Parse(removeComma(input.Text)) * -1;
                        input.Text = generateComma((Double.Parse(removeComma(input.Text)) * -1).ToString());
                        rightNum = removeComma(input.Text);
                        return;
                    }

                    oneXNum = Double.Parse(input.Text) * -1;
                    input.Text = generateComma((Double.Parse(removeComma(input.Text)) * -1).ToString());
                }
            }
            else
            {
                if (input.Text == "0")
                {
                    input.Text = b.Text;
                }
                else
                {
                    if (displayCalculate.Split(' ').Length == 1 && checkClick)
                    {
                        input.Text = b.Text;
                        checkClick = false;
                        return;
                    }
                    input.Text = generateComma(input.Text + b.Text);
                }
            }

        }


        private void operators_Click(object sender, EventArgs e)
        {
            GunaAdvenceButton b = (GunaAdvenceButton)sender;
            if (b.Checked) return;

            oneXNum = 0;
            string buttonName = b.Name;
            enter_input = false;
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
                    operation2 = "x";
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
                    result = Double.Parse(removeComma(input.Text));
                    enter_value = true;
                    displayCalculate = result + " " + operation2;
                }
                else
                {
                    if (displayCalculate.Split(' ').Length == 3)
                    {
                        enter_value = true;
                        equalBtn.PerformClick();
                        result = Double.Parse(removeComma(input.Text));
                        displayCalculate = result + " " + operation2;
                    } else
                    {
                        enter_value = true;
                        displayCalculate = input.Text + " " + operation2;
                    }
                }
            }
            else
            {
                result = Double.Parse(removeComma(input.Text));
                enter_value = true;
                displayCalculate = result + " " + operation2;
            }
            enter_input = false;

            operation = operation2;
        }

        private void equalBtn_Click(object sender, EventArgs e)
        {
            if (removeComma(input.Text).Equals("Cannot divide by zero") || string.IsNullOrEmpty(removeComma(input.Text)) || removeComma(input.Text).Equals("Overflow") || removeComma(input.Text).Equals("Invalid input"))
            {
                input.Text = "0";
                input.Enabled = true;
                displayCalculate = "";
                result = 0;
                oneXNum = 0;
                rightNum = "0";
                enter_input = false;
                enter_value = false;
                return;
            }

            enter_input = false;
            enter_value = false;


            string number = removeComma(input.Text);

            switch (operation)
            {
                case "+":
                    if (displayCalculate.Split(' ').Length == 4)
                    {
                        rightNum = displayCalculate.Split(' ')[2];

                        displayCalculate = result.ToString() + " " + operation + " " + rightNum + " =";
                        input.Text = generateComma((result + Double.Parse(rightNum)).ToString());
                        history.addHistoryItem(result, operation, Double.Parse(rightNum), Double.Parse(removeComma(input.Text)));
                        calculatorTab.history.addHistoryItem(result, operation, Double.Parse(rightNum), Double.Parse(removeComma(input.Text)));
                    }
                    else
                    {
                        displayCalculate = result.ToString() + " " + operation + " " + number + " =";
                        input.Text = generateComma((result + Double.Parse(number)).ToString());
                        history.addHistoryItem(result, operation, Double.Parse(number), Double.Parse(removeComma(input.Text)));
                        calculatorTab.history.addHistoryItem(result, operation, Double.Parse(number), Double.Parse(removeComma(input.Text)));
                    }
                    break;
                case "-":
                    if (displayCalculate.Split(' ').Length == 4)
                    {
                        rightNum = displayCalculate.Split(' ')[2];
                        displayCalculate = result.ToString() + " " + operation + " " + rightNum + " =";
                        input.Text = generateComma((result - Double.Parse(rightNum)).ToString());
                        history.addHistoryItem(result, operation, Double.Parse(rightNum), Double.Parse(input.Text));
                        calculatorTab.history.addHistoryItem(result, operation, Double.Parse(rightNum), Double.Parse(input.Text));
                    }
                    else
                    {
                        displayCalculate = result.ToString() + " " + operation + " " + number + " =";
                        input.Text = (result - Double.Parse(number)).ToString();
                        history.addHistoryItem(result, operation, Double.Parse(number), Double.Parse(removeComma(input.Text)));
                        calculatorTab.history.addHistoryItem(result, operation, Double.Parse(number), Double.Parse(removeComma(input.Text)));
                    }
                    break;
                case "x":
                    if (displayCalculate.Split(' ').Length == 4)
                    {
                        rightNum = displayCalculate.Split(' ')[2];
                        displayCalculate = result.ToString() + " " + operation + " " + rightNum + " =";
                        input.Text = generateComma((result * Double.Parse(rightNum)).ToString());
                        history.addHistoryItem(result, operation, Double.Parse(rightNum), Double.Parse(removeComma(input.Text)));
                        calculatorTab.history.addHistoryItem(result, operation, Double.Parse(rightNum), Double.Parse(removeComma(input.Text)));
                    }
                    else
                    {
                        displayCalculate = result.ToString() + " " + operation + " " + number + " =";
                        input.Text = generateComma((result * Double.Parse(number)).ToString());
                        history.addHistoryItem(result, operation, Double.Parse(number), Double.Parse(removeComma(input.Text)));
                        calculatorTab.history.addHistoryItem(result, operation, Double.Parse(number), Double.Parse(removeComma(input.Text)));
                    }
                    break;
                case "/":
                    if (Double.Parse(input.Text) == 0)
                    {
                        input.Text = "Cannot divide by zero";
                        result = 0;
                        operation = "";
                        displayCalculate = displayCalculate.Split(' ')[0] + " / (0)";
                        input.Enabled = false;
                        ischeck = true;
                        enter_value = false;
                        enter_input = false;
                        rightNum = "0";
                        oneXNum = 0;
                        disableBtn();
                        return;
                    }
                    else
                    {
                        if (displayCalculate.Split(' ').Length == 4)
                        {
                            rightNum = displayCalculate.Split(' ')[2];
                            displayCalculate = result.ToString() + " " + operation + " " + rightNum + " =";
                            input.Text = generateComma((result / Double.Parse(rightNum)).ToString());
                            history.addHistoryItem(result, operation, Double.Parse(rightNum), Double.Parse(removeComma(input.Text)));
                            calculatorTab.history.addHistoryItem(result, operation, Double.Parse(rightNum), Double.Parse(removeComma(input.Text)));
                        }
                        else
                        {
                            displayCalculate = result.ToString() + " " + operation + " " + number + " =";
                            input.Text = generateComma((result / Double.Parse(number)).ToString());
                            history.addHistoryItem(result, operation, Double.Parse(number), Double.Parse(removeComma(input.Text)));
                            calculatorTab.history.addHistoryItem(result, operation, Double.Parse(number), Double.Parse(removeComma(input.Text)));
                        }
                    }
                    break;
                default:
                    if (input.Text != "")
                    {
                        history.addHistoryItemV2(Double.Parse(removeComma(input.Text)));
                        calculatorTab.history.addHistoryItemV2(Double.Parse(removeComma(input.Text)));
                        displayCalculate = Double.Parse(removeComma(input.Text)).ToString() + " =";
                    }
                    break;
            }

            result = Double.Parse(removeComma(input.Text));
            rightNum = "0";
            enter_value = false;
            enter_input = false;
            oneXNum = 0;
        }

        private string removeComma(string text)
        {
            return string.Join("", text.Split(','));
        }

        private string generateComma(string text)
        {
            if (text.Equals("Cannot divide by zero") || text.Equals("Overflow") || text.Equals("Invalid input") || string.IsNullOrEmpty(text))
            {
                return text;
            }
            double tmp;

            if (text.Contains("."))
            {
                tmp = Double.Parse(text.Split('.')[0]);

                return text.StartsWith("-") ? "-" + $"{tmp:n0}" + "." + text.Split('.')[1] : $"{tmp:n0}" + "." + text.Split('.')[1];
            }

            tmp = Double.Parse(text);

            return $"{tmp:n0}";
        }

        private void reset()
        {
            input.Text = "0";
            displayCalculate = "";
            operation = "";
            result = 0;
            rightNum = "0";
            oneXNum = 0;
            input.Enabled = true;
            enter_input = false;
            enter_value = false;
            disableBtn();
        }


        private void backspaceBtn_Click(object sender, EventArgs e)
        {
            if (removeComma(input.Text).Equals("Cannot divide by zero") || removeComma(input.Text).Equals("Overflow") || removeComma(input.Text).Equals("Invalid input") || removeComma(input.Text).Equals("0"))
            {
                ischeck = false;
                reset();
                return;
            }
            if (removeComma(input.Text).Length > 0)
            {
                input.Text = generateComma(removeComma(input.Text).Remove(removeComma(input.Text).Length - 1, 1));
            }
            if (removeComma(input.Text) == "")
            {
                input.Text = "0";
                displayCalculate = "";
                ischeck = false;
                enter_input = false;
                enter_value = false;
                result = 0;
                rightNum = "0";
                oneXNum = 0;
            }
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            if (input.Text.Equals("Cannot divide by zero") || input.Text.Equals("Overflow") || input.Text.Equals("Invalid input"))
            {
                ischeck = false;
                reset();
                return;
            }
            input.Text = "0";
            displayCalculate = "";
            result = 0;
            rightNum = "0";
            oneXNum = 0;
        }

        private void input_MouseDown(object sender, MouseEventArgs e)
        {
            this.input.SelectionStart = this.input.Text.Length + 1;
            input.Focus();
        }

        private void input_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (removeComma(input.Text).Split('.')[0].Length >= 15 && e.KeyChar != (char)Keys.Back)
            {
                if (enter_value)
                {
                    this.input.Text = e.KeyChar.ToString();
                }
                e.Handled = true;
                return;
            }

            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back && e.KeyChar != '.')
            {
                e.Handled = true;
            }
            else
            {
                e.Handled = true;

                if (e.KeyChar == '.' && removeComma(input.Text).Contains("."))
                {
                    return;
                }

                if (removeComma(input.Text).Length >= 1)
                {
                    if (removeComma(input.Text).ToString()[0] == '0' && e.KeyChar != '.')
                    {
                        if (removeComma(input.Text).Length >= 2)
                        {
                            if (removeComma(input.Text).ToString()[1] == '.')
                            {
                                this.input.Text = generateComma(input.Text + e.KeyChar.ToString());
                                return;
                            }
                        }
                        this.input.Text = e.KeyChar.ToString();
                        return;
                    }


                }


                if (e.KeyChar != (char)Keys.Back)
                {
                    this.input.Text = generateComma(input.Text + e.KeyChar.ToString());
                }
                else
                {
                    this.input.Text = generateComma(removeComma(input.Text).Substring(0, removeComma(input.Text).Length - 1));
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
            string number = removeComma(input.Text);
            if (oneXBtn.Checked == true) return;

            

            if (Double.Parse(number) == 0)
            {
                input.Text = "Cannot divide by zero";
                displayCalculate = 1 + " / (0)";
                result = 0;
                operation = "";
                input.Enabled = false;
                ischeck = true;
                enter_value = false;
                enter_input = false;
                result = 0;
                rightNum = "0";
                oneXNum = 0;
                disableBtn();
                return;
            }
            else
            {
                checkClick = true;
                if (displayCalculate.Split(' ').Length == 4)
                {
                    displayCalculate = "1/(" + number + ")";
                    input.Text = generateComma((1 / Double.Parse(number)).ToString());
                }
                else
                {
                    if (oneXNum == 0)
                    {
                        oneXNum = Double.Parse(removeComma(input.Text));
                        if ((displayCalculate.Split(' ').Length == 2 || displayCalculate.Split(' ').Length == 3) && !displayCalculate.Contains("="))
                        {
                            double leftNum = Double.Parse(displayCalculate.Split(' ')[0]);
                            displayCalculate = leftNum + " " + operation + " " + "1/(" + oneXNum + ")";
                        }
                        else
                        {
                            displayCalculate = "1/(" + oneXNum + ")";
                        }
                        input.Text = generateComma((1 / oneXNum).ToString());
                    }
                    else
                    {
                        if (displayCalculate.Split(' ').Length == 3)
                        {
                            double leftNum = Double.Parse(displayCalculate.Split(' ')[0]);
                            string elementTwo = "1/(" + displayCalculate.Split(' ')[2] + ")";
                            displayCalculate = leftNum + " " + operation + " " + elementTwo;

                            input.Text = generateComma((1 / Double.Parse(rightNum)).ToString());
                        }
                        else
                        {
                            if (string.IsNullOrEmpty(displayCalculate))
                            {
                                displayCalculate = "1/(" + removeComma(input.Text) + ")";
                                Console.WriteLine(1 / Double.Parse(removeComma(input.Text)));
                                input.Text = generateComma((1 / Double.Parse(removeComma(input.Text))).ToString());
                            }
                            else
                            {
                                displayCalculate = "1/(" + displayCalculate + ")";
                                input.Text = generateComma((1 / Double.Parse(rightNum)).ToString());
                            }
                        }
                    }
                rightNum = removeComma(input.Text);
                }
            }
        }

        private void x2Btn_Click(object sender, EventArgs e)
        {
            string number = removeComma(input.Text);
            if (x2Btn.Checked == true) return;
            if (double.IsInfinity(Math.Pow(Double.Parse(number), 2)))
            {
                input.Text = "Overflow";
                input.Enabled = false;
                ischeck = true;
                enter_value = false;
                enter_input = false;
                result = 0;
                rightNum = "0";
                oneXNum = 0;

                disableBtn();

                return;
            }

            checkClick = true;

            if (displayCalculate.Split(' ').Length == 4)
            {
                displayCalculate = "sqr(" + number + ")";
                input.Text = generateComma(Math.Pow(Double.Parse(number), 2).ToString());
            }
            else
            {
                if (oneXNum == 0)
                {
                    oneXNum = Double.Parse(number);
                    if ((displayCalculate.Split(' ').Length == 2 || displayCalculate.Split(' ').Length == 3) && !displayCalculate.Contains("="))
                    {
                        double leftNum = Double.Parse(displayCalculate.Split(' ')[0]);
                        displayCalculate = leftNum  + " " + operation + " " + "sqr(" + oneXNum + ")";
                    }
                    else
                    {
                        displayCalculate = "sqr(" + oneXNum + ")";
                    }
                    input.Text = generateComma(Math.Pow(oneXNum, 2).ToString());
                }
                else
                {
                    if (displayCalculate.Split(' ').Length == 3)
                    {
                        double leftNum = Double.Parse(displayCalculate.Split(' ')[0]);
                        string elementTwo = "sqr(" + displayCalculate.Split(' ')[2] + ")";
                        displayCalculate = leftNum + " " + operation + " " + elementTwo;

                        input.Text = generateComma(Math.Pow(Double.Parse(rightNum), 2).ToString());
                    }
                    else
                    {
                        if (string.IsNullOrEmpty(displayCalculate))
                        {
                            displayCalculate = "sqr(" + removeComma(input.Text) + ")";
                            input.Text = generateComma(Math.Pow(Double.Parse(removeComma(input.Text)), 2).ToString());
                        }
                        else
                        {
                            displayCalculate = "sqr(" + displayCalculate + ")";
                            input.Text = generateComma(Math.Pow(Double.Parse(rightNum), 2).ToString());
                        }
                    }
                }
                rightNum = removeComma(input.Text);
            }
        }

        private void sqrtBtn_Click(object sender, EventArgs e)
        {

            string number = removeComma(input.Text);
            if (sqrtBtn.Checked == true) return;

            if (double.Parse(number) < 0)
            {
                input.Text = "Invalid input";
                input.Enabled = false;
                ischeck = true;
                enter_value = false;
                enter_input = false;
                result = 0;
                rightNum = "0";
                oneXNum = 0;
                disableBtn();

                return;
            }

            checkClick = true;

            if (displayCalculate.Split(' ').Length == 4)
            {
                displayCalculate = "√(" + number + ")";
                input.Text = generateComma(Math.Sqrt(Double.Parse(number)).ToString());
            }
            else
            {

                if (oneXNum == 0)
                {
                    oneXNum = Double.Parse(input.Text);
                    if ((displayCalculate.Split(' ').Length == 2 || displayCalculate.Split(' ').Length == 3) && !displayCalculate.Contains("="))
                    {
                        double leftNum = Double.Parse(displayCalculate.Split(' ')[0]);
                        displayCalculate = leftNum + " " + operation + " " + "√(" + oneXNum + ")";
                    }
                    else
                    {
                        displayCalculate = "√(" + oneXNum + ")";
                    }

                    input.Text = generateComma(Math.Sqrt(oneXNum).ToString());
                }
                else
                {
                    if (displayCalculate.Split(' ').Length == 3)
                    {
                        double leftNum = Double.Parse(displayCalculate.Split(' ')[0]);
                        string elementTwo = "√(" + displayCalculate.Split(' ')[2] + ")";
                        displayCalculate = leftNum + " " + operation + " " + elementTwo;
                    }
                    else
                    {
                        displayCalculate = "√(" + displayCalculate + ")";
                    }
                    input.Text = generateComma(Math.Sqrt(Double.Parse(rightNum)).ToString());
                }
                rightNum = removeComma(input.Text);
            }
        }

        private void percentBtn_Click(object sender, EventArgs e)
        {
            if (percentBtn.Checked == true) return;

            if (displayCalculate.Split(' ').Length == 2)
            {
                rightNum = removeComma(input.Text);

                input.Text = generateComma((Convert.ToDouble(removeComma(input.Text)) / 100 * Convert.ToDouble(displayCalculate.Split(' ')[0])).ToString());

                displayCalculate = result + " " + operation + " " + Convert.ToDouble(removeComma(input.Text)).ToString();

                oneXNum = 0;

                if (displayCalculate.Split(' ').Length == 4)
                {
                    displayCalculate += " =";
                }

                return;
            }

            if (displayCalculate.Split(' ').Length == 3)
            {
                input.Text = generateComma((Convert.ToDouble(rightNum) / 100 * Convert.ToDouble(removeComma(displayCalculate.Split(' ')[0]))).ToString());

                displayCalculate = result + " " + operation + " " + Convert.ToDouble(removeComma(input.Text)).ToString();

                oneXNum = 0;

                if (displayCalculate.Split(' ').Length == 4)
                {
                    displayCalculate += " =";
                }

                return;
            }

            if (displayCalculate.Split(' ').Length == 4)
            {
                input.Text = generateComma((Convert.ToDouble(removeComma(input.Text)) / 100 * Convert.ToDouble(removeComma(input.Text))).ToString());

                rightNum = "0";

                displayCalculate = result.ToString();

                return;
            }

            if (displayCalculate.Split(' ').Length == 1 || string.IsNullOrEmpty(displayCalculate))
            {
                input.Text = "0";
                displayCalculate = "0";
            }
            else
            {
                input.Text = generateComma((Convert.ToDouble(removeComma(input.Text)) / 100 * Convert.ToDouble(removeComma(input.Text))).ToString());

                displayCalculate = removeComma(input.Text).ToString();
                result = Convert.ToDouble(removeComma(input.Text));
            }
            oneXNum = 0;
            rightNum = "0";
        }

        private void clearInputBtn_Click(object sender, EventArgs e)
        {
            if (removeComma(input.Text).Equals("Cannot divide by zero") || removeComma(input.Text).Equals("Overflow") || removeComma(input.Text).Equals("Invalid input"))
            {
                ischeck = false;
                reset();
            }
            input.Text = "0";
            if (displayCalculate.Split(' ').Length == 4)
            {
                displayCalculate = "";
            }

        }

        private void input_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(removeComma(input.Text)))
            {
                ischeck = false;
                reset();
            }
        }
    }
}
