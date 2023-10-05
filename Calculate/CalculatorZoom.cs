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

            enter_input = true;
            oneXNum = 0;
            string plusOrMinusBtn = b.Name;

            string newText = removeComma();

            if (newText.Length >= 15) return;

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
                    result = Double.Parse(b.Text);
                }
                else
                {
                    displayCalculate = "negate(" + newText + ")";
                    input.Text = generateComma((Double.Parse(newText) * -1).ToString());
                    rightNum = "0";
                    oneXNum = 0;
                }

                return;
            }

            if (((newText == "0") || enter_value || string.IsNullOrEmpty(newText)) && plusOrMinusBtn != "plusOrMinusBtn")
            {
                input.Text = "0";
                enter_value = false;
            }

            if (newText.Equals("Cannot divide by zero") || newText.Equals("Overflow") || newText.Equals("Invalid input"))
            {
                ischeck = true;
                reset();
                ischeck = false;
                return;
            }

            if (b.Text == ".")
            {
                if (!input.Text.Contains("."))
                    if (input.Text == "")
                        input.Text = "0";
                input.Text = newText + b.Text;
            }
            else if (plusOrMinusBtn == "plusOrMinusBtn")
            {
                string tmp;
                if (newText != "0")
                {
                    tmp = newText.StartsWith("-") ? newText.Substring(1) : newText;

                    if (displayCalculate.Split(' ').Length == 1)
                    {
                        displayCalculate = "negate(" + displayCalculate + ")";
                        input.Text = generateComma((Double.Parse(newText) * -1).ToString());
                        oneXNum = Double.Parse(removeComma()) * -1;
                        rightNum = removeComma();
                        result = oneXNum;
                        return;
                    }

                    if (enter_input && displayCalculate.Split(' ').Length == 2)
                    {
                        double leftNum = Double.Parse(displayCalculate.Split(' ')[0]);
                        oneXNum = Double.Parse(newText) * -1;
                        displayCalculate = leftNum + " " + operation + " " + oneXNum;
                        input.Text = generateComma((Double.Parse(newText) * -1).ToString());
                        rightNum = removeComma();
                        return;
                    }

                    if (displayCalculate.Split(' ').Length == 4)
                    {
                        displayCalculate = "negate(" + tmp + ")";
                        result = Double.Parse(newText) * -1;
                        input.Text = generateComma((Double.Parse(newText) * -1).ToString());
                        rightNum = "0";
                        oneXNum = 0;
                        return;
                    }


                    if (displayCalculate.Split(' ').Length == 3)
                    {
                        double leftNum = Double.Parse(displayCalculate.Split(' ')[0]);
                        string elementTwo = "negate(" + displayCalculate.Split(' ')[2] + ")";
                        displayCalculate = leftNum + " " + operation + " " + elementTwo;
                        oneXNum = Double.Parse(newText) * -1;
                        input.Text = (Double.Parse(newText) * -1).ToString();
                        rightNum = removeComma();
                        return;
                    }

                    if (displayCalculate.Split(' ').Length == 2)
                    {
                        double leftNum = Double.Parse(displayCalculate.Split(' ')[0]);
                        string elementTwo = "negate(" + tmp + ")";
                        displayCalculate = leftNum + " " + operation + " " + elementTwo;
                        oneXNum = (Double.Parse(newText) * -1);
                        input.Text = (Double.Parse(newText) * -1).ToString();
                        rightNum = removeComma();
                        return;
                    }

                    oneXNum = Double.Parse(input.Text) * -1;
                    input.Text = generateComma((Double.Parse(input.Text) * -1).ToString());
                }
            }
            else
            {
                Console.WriteLine("123");
                if (newText == "0")
                {
                    input.Text = b.Text;
                }
                else input.Text = generateComma(newText + b.Text);
            }
        }


        private void operators_Click(object sender, EventArgs e)
        {
            GunaAdvenceButton b = (GunaAdvenceButton)sender;
            if (b.Checked) return;

            oneXNum = 0;
            string buttonName = b.Name;
            String operation2 = "";
            string newText = removeComma();

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

            operation = operation2;

            if (result != 0)
            {
                if (enter_input)
                {
                    equalBtn.PerformClick();
                    result = Double.Parse(newText);
                    enter_value = true;
                    displayCalculate = result + " " + operation2;
                }
                else
                {
                    enter_value = true;
                    displayCalculate = newText + " " + operation2;
                }
            }
            else
            {
                result = Double.Parse(newText);
                enter_value = true;
                displayCalculate = result + " " + operation2;
            }
            enter_input = false;
        }

        private void equalBtn_Click(object sender, EventArgs e)
        {
            if (removeComma().Equals("Cannot divide by zero") || string.IsNullOrEmpty(removeComma()) || removeComma().Equals("Overflow") || removeComma().Equals("Invalid input"))
            {
                ischeck = false;
                reset();
                return;
            }

            enter_input = false;
            enter_value = false;


            string number = removeComma();

            switch (operation)
            {
                case "+":
                    if (displayCalculate.Split(' ').Length == 4)
                    {
                        rightNum = displayCalculate.Split(' ')[2];

                        displayCalculate = result.ToString() + " " + operation + " " + rightNum + " =";
                        input.Text = generateComma((result + Double.Parse(rightNum)).ToString());
                        history.addHistoryItem(result, operation, Double.Parse(rightNum), Double.Parse(removeComma()));
                        calculatorTab.history.addHistoryItem(result, operation, Double.Parse(rightNum), Double.Parse(removeComma()));

                    }
                    else
                    {
                        displayCalculate = result.ToString() + " " + operation + " " + number + " =";
                        input.Text = generateComma((result + Double.Parse(number)).ToString());
                        history.addHistoryItem(result, operation, Double.Parse(number), Double.Parse(removeComma()));
                        calculatorTab.history.addHistoryItem(result, operation, Double.Parse(number), Double.Parse(removeComma()));
                    }
                    break;
                case "-":
                    if (displayCalculate.Split(' ').Length == 4)
                    {
                        rightNum = displayCalculate.Split(' ')[2];
                        displayCalculate = result.ToString() + " " + operation + " " + rightNum + " =";
                        input.Text = generateComma((result - Double.Parse(rightNum)).ToString());
                        history.addHistoryItem(result, operation, Double.Parse(rightNum), Double.Parse(removeComma()));
                        calculatorTab.history.addHistoryItem(result, operation, Double.Parse(rightNum), Double.Parse(removeComma()));
                    }
                    else
                    {
                        displayCalculate = result.ToString() + " " + operation + " " + number + " =";
                        input.Text = generateComma((result - Double.Parse(number)).ToString());
                        history.addHistoryItem(result, operation, Double.Parse(number), Double.Parse(removeComma()));
                        calculatorTab.history.addHistoryItem(result, operation, Double.Parse(number), Double.Parse(removeComma()));
                    }
                    break;
                case "x":
                    if (displayCalculate.Split(' ').Length == 4)
                    {
                        rightNum = displayCalculate.Split(' ')[2];
                        displayCalculate = result.ToString() + " " + operation + " " + rightNum + " =";
                        input.Text = generateComma((result * Double.Parse(rightNum)).ToString());
                        history.addHistoryItem(result, operation, Double.Parse(rightNum), Double.Parse(removeComma()));
                        calculatorTab.history.addHistoryItem(result, operation, Double.Parse(rightNum), Double.Parse(removeComma()));
                    }
                    else
                    {
                        displayCalculate = result.ToString() + " " + operation + " " + number + " =";
                        input.Text = generateComma((result * Double.Parse(number)).ToString());
                        history.addHistoryItem(result, operation, Double.Parse(number), Double.Parse(removeComma()));
                        calculatorTab.history.addHistoryItem(result, operation, Double.Parse(number), Double.Parse(removeComma()));
                    }
                    break;
                case "/":
                    if (Double.Parse(input.Text) == 0)
                    {
                        ischeck = true;
                        reset();
                        ischeck = false;
                        input.Text = "Cannot divide by zero";
                        displayCalculate = "1 / (0)";
                        return;
                    }
                    else
                    {
                        if (displayCalculate.Split(' ').Length == 4)
                        {
                            rightNum = displayCalculate.Split(' ')[2];
                            displayCalculate = result.ToString() + " " + operation + " " + rightNum + " =";
                            input.Text = generateComma((result / Double.Parse(rightNum)).ToString());
                            history.addHistoryItem(result, operation, Double.Parse(rightNum), Double.Parse(removeComma()));
                            calculatorTab.history.addHistoryItem(result, operation, Double.Parse(rightNum), Double.Parse(removeComma()));
                        }
                        else
                        {
                            displayCalculate = result.ToString() + " " + operation + " " + number + " =";
                            input.Text = generateComma((result / Double.Parse(number)).ToString());
                            history.addHistoryItem(result, operation, Double.Parse(number), Double.Parse(removeComma()));
                            calculatorTab.history.addHistoryItem(result, operation, Double.Parse(number), Double.Parse(removeComma()));
                        }
                    }
                    break;
                default:
                    if (number != "")
                    {
                        history.addHistoryItemV2(Double.Parse(number));
                        calculatorTab.history.addHistoryItemV2(Double.Parse(number));
                        displayCalculate = Double.Parse(number).ToString() + " =";
                    }
                    break;
            }

            result = Double.Parse(removeComma());
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
            if (removeComma().Equals("Cannot divide by zero") || input.Text == "" || removeComma().Equals("Overflow") || removeComma().Equals("Invalid input"))
            {
                ischeck = false;
                reset();
                return;
            }
            else if (input.Text.Length > 0)
            {
                input.Text = generateComma(removeComma().Remove(removeComma().Length - 1, 1));
            }
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            if (input.Text.Equals("Cannot divide by zero") || input.Text.Equals("Overflow") || input.Text.Equals("Invalid input"))
            {
                ischeck = true;
                reset();
                ischeck = false;
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

        private string removeComma()
        {
            return string.Join("", this.input.Text.Split(','));
        }

        private string generateComma(string text)
        {
            double tmp = Double.Parse(text);
            Console.WriteLine(tmp);

            return $"{tmp:n0}";
        }

        private void input_KeyPress(object sender, KeyPressEventArgs e)
        {
            string newInput = removeComma();
            if (newInput.Length >= 15)
            {
                if (e.KeyChar == (char)Keys.Back)
                {
                    this.input.Text = generateComma(newInput.Substring(0, newInput.Length - 1));
                }
                else
                {
                    e.Handled = true;
                }
                return;
            }

            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back && e.KeyChar != '.')
            {
                e.Handled = true;
            }
            else
            {
                e.Handled = true;

                if (e.KeyChar == '.' && newInput.Contains("."))
                {
                    return;
                }

                if (newInput.Length >= 1)
                {
                    if (newInput.ToString()[0] == '0' && e.KeyChar != '.')
                    {
                        if (newInput.Length >= 2)
                        {
                            if (newInput.ToString()[1] == '.')
                            {
                                this.input.Text = generateComma(newInput + e.KeyChar.ToString());
                                return;
                            }
                        }
                        this.input.Text = e.KeyChar.ToString();
                        return;
                    }


                }


                if (e.KeyChar != (char)Keys.Back)
                {
                    this.input.Text = generateComma(newInput + e.KeyChar.ToString()); ;
                }
                else
                {
                    this.input.Text = generateComma(newInput.Substring(0, newInput.Length - 1));
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
            string number = removeComma();
            if (oneXBtn.Checked == true) return;

            if (Double.Parse(number) == 0)
            {
                ischeck = true;
                reset();
                input.Text = "Cannot divide by zero";
                displayCalculate = result.ToString() + " / (0)";
                ischeck = false;
                return;
            }
            else
            {
                if (displayCalculate.Split(' ').Length == 4)
                {
                    displayCalculate = "1/(" + number + ")";
                    input.Text = generateComma((1 / Double.Parse(number)).ToString());
                }
                else
                {
                    if (oneXNum == 0)
                    {
                        oneXNum = Double.Parse(number);
                        if (displayCalculate.Split(' ').Length == 2)
                        {
                            double leftNum = Double.Parse(displayCalculate.Split(' ')[0]);
                            displayCalculate = displayCalculate.Split(' ')[0] + " " + operation + " " + "1/(" + oneXNum + ")";
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
                            displayCalculate = "1/(" + displayCalculate + ")";
                            input.Text = generateComma((1 / Double.Parse(rightNum)).ToString());
                        }
                    }
                }
                rightNum = removeComma();
            }
        }

        private void x2Btn_Click(object sender, EventArgs e)
        {
            string number = removeComma();
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
                ischeck = false;
                return;
            }
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
                    if (displayCalculate.Split(' ').Length == 2)
                    {
                        double leftNum = Double.Parse(displayCalculate.Split(' ')[0]);
                        displayCalculate = displayCalculate.Split(' ')[0] + " " + operation + " " + "sqr/(" + oneXNum + ")";
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
                    }
                    else
                    {
                        displayCalculate = "sqr(" + displayCalculate + ")";
                    }
                    input.Text = generateComma(Math.Pow(Double.Parse(rightNum), 2).ToString());
                }
                rightNum = removeComma();
            }
        }

        private void sqrtBtn_Click(object sender, EventArgs e)
        {

            string number = removeComma();
            if (sqrtBtn.Checked == true) return;

            if (double.Parse(number) < 0)
            {
                if (displayCalculate.Split(' ').Length == 2)
                {
                    displayCalculate = displayCalculate.Split(' ')[0] + " " + operation + " " + "√(" + number + ")";
                }
                else if (displayCalculate.Split(' ').Length == 3)
                {
                    string elementTwo = "√(" + displayCalculate.Split(' ')[2] + ")";
                    displayCalculate = displayCalculate.Split(' ')[0] + " " + operation + " " + elementTwo;
                }
                else
                {
                    displayCalculate = "√(" + number + ")";
                }

                input.Text = "Invalid input";
                input.Enabled = false;
                ischeck = true;
                enter_value = false;
                enter_input = false;
                result = 0;
                rightNum = "0";
                oneXNum = 0;
                disableBtn();
                ischeck = false;
                return;
            }
            if (displayCalculate.Split(' ').Length == 4)
            {
                displayCalculate = "√(" + number + ")";
                input.Text = generateComma(Math.Sqrt(Double.Parse(number)).ToString());
            }
            else
            {

                if (oneXNum == 0)
                {
                    oneXNum = Double.Parse(number);
                    if (displayCalculate.Split(' ').Length == 2 || displayCalculate.Split(' ').Length == 3)
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
                        input.Text = generateComma(Math.Sqrt(Double.Parse(rightNum)).ToString());
                    }
                    else
                    {
                        displayCalculate = "√(" + displayCalculate + ")";
                        input.Text = generateComma(Math.Sqrt(Double.Parse(rightNum)).ToString());
                    }
                }
                rightNum = removeComma();
            }
        }

        private void percentBtn_Click(object sender, EventArgs e)
        {
            if (percentBtn.Checked == true) return;

            if (displayCalculate.Split(' ').Length == 2)
            {
                rightNum = removeComma();

                input.Text = generateComma((Convert.ToDouble(removeComma()) / 100 * Convert.ToDouble(displayCalculate.Split(' ')[0])).ToString());

                displayCalculate = result + " " + operation + " " + Convert.ToDouble(removeComma()).ToString();

                oneXNum = 0;

                if (displayCalculate.Split(' ').Length == 4)
                {
                    displayCalculate += " =";
                }

                return;
            }

            if (displayCalculate.Split(' ').Length == 3)
            {
                input.Text = generateComma((Convert.ToDouble(rightNum) / 100 * Convert.ToDouble(removeComma())).ToString());

                displayCalculate = result + " " + operation + " " + Convert.ToDouble(removeComma()).ToString();

                oneXNum = 0;

                if (displayCalculate.Split(' ').Length == 4)
                {
                    displayCalculate += " =";
                }

                return;
            }

            if (displayCalculate.Split(' ').Length == 4)
            {
                input.Text = generateComma((Convert.ToDouble(removeComma()) / 100 * Convert.ToDouble(removeComma())).ToString());

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
                input.Text = (Convert.ToDouble(removeComma()) / 100 * Convert.ToDouble(removeComma())).ToString();

                displayCalculate = removeComma();
                result = Convert.ToDouble(removeComma());
            }
            oneXNum = 0;
            rightNum = "0";
        }

        private void clearInputBtn_Click(object sender, EventArgs e)
        {
            if (removeComma().Equals("Cannot divide by zero") || removeComma().Equals("Overflow") || removeComma().Equals("Invalid input"))
            {
                ischeck = true;
                reset();
                ischeck = false;
            }
            input.Text = "0";
            if (displayCalculate.Split(' ').Length == 4)
            {
                displayCalculate = "";
            }

        }

        private void input_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(removeComma()))
            {
                ischeck = true;
                reset();
                ischeck = false;
            }
        }

        public void synchronizeHistoryWhenDelete(string senderName, int mode = 0, string operation = "", string result = "")
        {
            // mode = 0 => xóa hết toàn bộ , mode = 1 xóa 1 item
            if (mode == 0)
            {
                if (senderName == typeof(History).Name)
                {
                    calculatorTab.history.ClearAllItem();
                }
                else
                if (senderName == typeof(HistoryZoom).Name)
                {
                    history.ClearAllItems();
                }
            }
            else if (mode == 1)
            {
                history.DeleteOneItem(operation, result);
                calculatorTab.history.DeleteOneItem(operation, result);
            }

        }
    }
}
