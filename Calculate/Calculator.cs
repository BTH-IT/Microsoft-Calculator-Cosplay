using Guna.UI.WinForms;
using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Calculate
{
    public partial class Calculator : Form
    {
        private static Calculator instance;
        Double result = 0;
        string operation = "";
        bool enter_value, ischeck = false;
        bool enter_input = false;
        string rightNum = "0";
        Double oneXNum = 0;

        public static Calculator Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Calculator();
                }

                return Calculator.instance;
            }
            private set { Calculator.instance = value; }
        }

        bool sidebarExpand = true;
        bool fullscreen = false;
        GlassyPanel overlayHistory = new GlassyPanel();
        GlassyPanel overlaySidebar = new GlassyPanel();
        GlassyPanel overlayMemory = new GlassyPanel();
        History history = new History();
        Memory memory = new Memory();
        CaculatorTab calculatorTab = new CaculatorTab();

        public Calculator()
        {
            InitializeComponent();
            input.Text = "0";
            overlaySidebar.Opacity = 0;

            overlayHistory.Dock = DockStyle.Fill;
            this.Controls.Add(overlayHistory);

            history.Dock = DockStyle.Bottom;
            overlayHistory.Controls.Add(history);

            overlayHistory.Hide();
            overlayHistory.SendToBack();
            history.BringToFront();

            overlayHistory.Click += new EventHandler(OnClickOverlayHistory);

            overlayMemory.Dock = DockStyle.Fill;
            this.Controls.Add(overlayMemory);

            memory.Dock = DockStyle.Bottom;
            overlayMemory.Controls.Add(memory);

            overlayMemory.Hide();
            overlayMemory.SendToBack();

            overlayMemory.Click += new EventHandler(OnClickOverlayMemory);

            overlaySidebar.Dock = DockStyle.Fill;
            this.Controls.Add(overlaySidebar);

            this.sidebarChild.Dock = DockStyle.Left;
            overlaySidebar.Controls.Add(sidebarChild);

            overlaySidebar.Hide();
            overlaySidebar.BringToFront();

            overlaySidebar.Click += new EventHandler(OnClickOverlaySidebar);

            this.sidebarChild.Width = 0;

            calculatorTab.TopLevel = false;
            calculatorTab.Dock = DockStyle.Fill;
            calculatorTab.BringToFront();
            this.leftPanel.Controls.Add(calculatorTab);
            calculatorTab.Visible = true;
        }

        private void OnClickOverlaySidebar(object sender, EventArgs e)
        {
            sidebarTransition.Start();
        }

        private void OnClickOverlayHistory(object sender, EventArgs e)
        {
            this.test.Visible = true;
            overlayHistory.Hide();
            historyIcon.BringToFront();
        }

        private void OnClickOverlayMemory(object sender, EventArgs e)
        {
            this.test.Visible = true;
            overlayMemory.Hide();
        }

        private void Calculator_Load(object sender, EventArgs e)
        {
            sidebarTransition.Start();
        }

        private void menuIcon_MouseDown(object sender, MouseEventArgs e)
        {
            this.menuIcon.ImageSize = new Size(10, 20);
        }

        private void menuIcon_MouseUp(object sender, MouseEventArgs e)
        {
            this.menuIcon.ImageSize = new Size(20, 20);
        }

        private void sidebarTransition_Tick(object sender, EventArgs e)
        {
            if (sidebarExpand)
            {
                this.sidebarChild.Width -= 20;

                if (this.sidebarChild.Width <= 0)
                {
                    sidebarExpand = false;
                    sidebarTransition.Stop();
                    overlaySidebar.Hide();
                }
            }
            else
            {
                sidebarChild.Width += 20;
                if (sidebarChild.Width >= 200)
                {
                    sidebarExpand = true;
                    sidebarTransition.Stop();
                }
            }
        }

        private void menuIcon_Click(object sender, EventArgs e)
        {
            overlaySidebar.BringToFront();
            overlaySidebar.Show();
            sidebarTransition.Start();
        }

        private void historyIcon_Click(object sender, EventArgs e)
        {
            overlayHistory.BringToFront();
            overlayHistory.Show();
            this.test.Visible = false;
        }

        private void openMemoryBtn_Click(object sender, EventArgs e)
        {
            overlayMemory.BringToFront();
            overlayMemory.Show();
            this.test.Visible = false;
        }

        private void gunaAdvenceButton1_Click(object sender, EventArgs e)
        {
            Instance.Hide();
            CalculatorZoom calZoom = new CalculatorZoom();

            calZoom.Show();
        }

        private void Calculator_Resize(object sender, EventArgs e)
        {
            
            if (this.Size.Width >= 600)
            {
                fullscreen = true;

                if (memory.panel3.Controls.Count > 1)
                {
                    Control[] MemoryCtrls = new Control[memory.panel3.Controls.Count];
                    memory.panel3.Controls.CopyTo(MemoryCtrls, 0);
                    calculatorTab.memory.loadMemoryItem(MemoryCtrls);
                }

                this.historyIcon.Visible = false;
                this.openMemoryBtn.Visible = false;
                this.leftPanel.Visible = true;
                if (this.Size.Width >= 900)
                {
                    this.leftPanel.Size = new Size(400, 100);
                } else
                {
                    this.leftPanel.Size = new Size(300, 100);
                }
            }
            else
            {
                fullscreen = false;

                if (calculatorTab.memory.panel3.Controls.Count > 1)
                {
                    Control[] MemoryCtrls = new Control[calculatorTab.memory.panel3.Controls.Count];
                    calculatorTab.memory.panel3.Controls.CopyTo(MemoryCtrls, 0);
                    memory.loadMemoryItem(MemoryCtrls);
                }

                this.historyIcon.Visible = true;
                this.openMemoryBtn.Visible = true;
                this.leftPanel.Visible = false;
            }
        }

        private void gunaAdvenceButton2_Click(object sender, EventArgs e)
        {
            sidebarTransition.Start();
        }

        private void numbers_Only(object sender, EventArgs e)
        {
            GunaAdvenceButton b = (GunaAdvenceButton)sender;
            if (b.Checked) return;

            enter_input = true;
            oneXNum = 0;
            string plusOrMinusBtn = b.Name;

            if (displayCalculate.Text.Split(' ').Length == 3 && plusOrMinusBtn != "plusOrMinusBtn")
            {
                displayCalculate.Text = string.Join(" ", displayCalculate.Text.Split(' ').Reverse().Skip(1).Reverse());
            }

            if (displayCalculate.Text.Split(' ').Length == 4)
            {
                if (plusOrMinusBtn != "plusOrMinusBtn")
                {
                    displayCalculate.Text = "";
                    input.Text = b.Text;
                    result = Double.Parse(input.Text);
                } else
                {
                    displayCalculate.Text = "negate(" + input.Text + ")";
                    input.Text = (Double.Parse(input.Text) * -1).ToString();
                    rightNum = "0";
                    oneXNum = 0;
                }
                
                return;
            }

            if (((input.Text == "0") || enter_value || string.IsNullOrEmpty(input.Text)) && plusOrMinusBtn != "plusOrMinusBtn")
            {
                input.Text = "0";
                enter_value = false;
            }

            if (input.Text.Equals("Cannot divide by zero") || input.Text.Equals("Overflow") || input.Text.Equals("Invalid input"))
            {
                input.Text = "0";
                input.Enabled = true;
                displayCalculate.Text = "";
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
                string tmp;
                if (input.Text != "0")
                {
                    tmp = input.Text.StartsWith("-") ? input.Text.Substring(1) : input.Text;

                    if (displayCalculate.Text.Split(' ').Length == 1)
                    {
                        displayCalculate.Text = "negate(" + displayCalculate.Text + ")";
                        input.Text = (Double.Parse(input.Text) * -1).ToString();
                        oneXNum = Double.Parse(input.Text) * -1;
                        rightNum = input.Text;
                        result = oneXNum;
                        return;
                    }

                    if (enter_input && displayCalculate.Text.Split(' ').Length == 2)
                    {
                        double leftNum = Double.Parse(displayCalculate.Text.Split(' ')[0]);
                        oneXNum = Double.Parse(input.Text) * -1;
                        displayCalculate.Text = leftNum + " " + operation + " " + oneXNum;
                        input.Text = (Double.Parse(input.Text) * -1).ToString();
                        rightNum = input.Text;
                        return;
                    }

                    if (displayCalculate.Text.Split(' ').Length == 4)
                    {
                        displayCalculate.Text = "negate(" + tmp + ")";
                        input.Text = (Double.Parse(input.Text) * -1).ToString();
                        rightNum = "0";
                        oneXNum = 0;
                        return;
                    }


                    if (displayCalculate.Text.Split(' ').Length == 3)
                    {
                        double leftNum = Double.Parse(displayCalculate.Text.Split(' ')[0]);
                        string elementTwo = "negate(" + displayCalculate.Text.Split(' ')[2] + ")";
                        displayCalculate.Text = leftNum + " " + operation + " " + elementTwo;
                        oneXNum = Double.Parse(input.Text) * -1;
                        input.Text = (Double.Parse(input.Text) * -1).ToString();
                        rightNum = input.Text;
                        return;
                    }

                    if (displayCalculate.Text.Split(' ').Length == 2)
                    {
                        double leftNum = Double.Parse(displayCalculate.Text.Split(' ')[0]);
                        string elementTwo = "negate(" + tmp + ")";
                        displayCalculate.Text = leftNum + " " + operation + " " + elementTwo;
                        oneXNum = (Double.Parse(input.Text) * -1);
                        input.Text = (Double.Parse(input.Text) * -1).ToString();
                        rightNum = input.Text;
                        return;
                    }

                    oneXNum = Double.Parse(input.Text) * -1;
                    input.Text = (Double.Parse(input.Text) * -1).ToString();
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
            enter_input = false;
            String operation2="";
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
                    result = Double.Parse(input.Text);
                    enter_value = true;
                    displayCalculate.Text = result + " " + operation2;
                } else
                {
                    enter_value = true;
                    displayCalculate.Text = input.Text + " " + operation2;
                }
            }
            else
            {
                result = Double.Parse(input.Text);
                enter_value = true;
                displayCalculate.Text = result + " " + operation2;
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
                    operation = "x";
                    break;
                case "divisionBtn":
                    operation = "/";
                    break;
            }

        }

        private void equalBtn_Click(object sender, EventArgs e)
        {
            if (input.Text.Equals("Cannot divide by zero") || string.IsNullOrEmpty(input.Text) || input.Text.Equals("Overflow") || input.Text.Equals("Invalid input"))
            {
                input.Text = "0";
                input.Enabled = true;
                displayCalculate.Text = "";
                result = 0;
                oneXNum = 0;
                rightNum = "0";
                enter_input = false;
                enter_value = false;
                return;
            }

            enter_input = false;
            enter_value = false;


            string number = input.Text;

            switch (operation)
            {
                case "+":
                    if (displayCalculate.Text.Split(' ').Length == 4)
                    {
                        rightNum = displayCalculate.Text.Split(' ')[2];
                        
                        displayCalculate.Text = result.ToString() + " " + operation + " " + rightNum + " =";
                        input.Text = (result + Double.Parse(rightNum)).ToString();
                        history.addHistoryItem(result, operation, Double.Parse(rightNum), Double.Parse(input.Text));
                        calculatorTab.history.addHistoryItem(result, operation, Double.Parse(rightNum), Double.Parse(input.Text));

                    }
                    else
                    {
                        displayCalculate.Text = result.ToString() + " " + operation + " " + number + " =";
                        input.Text = (result + Double.Parse(number)).ToString();
                        history.addHistoryItem(result, operation, Double.Parse(number), Double.Parse(input.Text));
                        
                        calculatorTab.history.addHistoryItem(result, operation, Double.Parse(number), Double.Parse(input.Text));
                    }
                    break; 
                case "-":
                    if (displayCalculate.Text.Split(' ').Length == 4)
                    {
                        rightNum = displayCalculate.Text.Split(' ')[2];
                        displayCalculate.Text = result.ToString() + " " + operation + " " + rightNum + " =";
                        input.Text = (result - Double.Parse(rightNum)).ToString();
                        history.addHistoryItem(result, operation, Double.Parse(rightNum), Double.Parse(input.Text));
                        calculatorTab.history.addHistoryItem(result, operation, Double.Parse(rightNum), Double.Parse(input.Text));
                    }
                    else
                    {
                        displayCalculate.Text = result.ToString() + " " + operation + " " + number + " =";
                        input.Text = (result - Double.Parse(number)).ToString();
                        history.addHistoryItem(result, operation, Double.Parse(number), Double.Parse(input.Text));
                        calculatorTab.history.addHistoryItem(result, operation, Double.Parse(number), Double.Parse(input.Text));
                    }
                    break;                
                case "x":
                    if (displayCalculate.Text.Split(' ').Length == 4)
                    {
                        rightNum = displayCalculate.Text.Split(' ')[2];
                        displayCalculate.Text = result.ToString() + " " + operation + " " + rightNum + " =";
                        input.Text = (result * Double.Parse(rightNum)).ToString();
                        history.addHistoryItem(result, operation, Double.Parse(rightNum), Double.Parse(input.Text));
                        calculatorTab.history.addHistoryItem(result, operation, Double.Parse(rightNum), Double.Parse(input.Text));
                    }
                    else
                    {
                        displayCalculate.Text = result.ToString() + " " + operation + " " + number + " =";
                        input.Text = (result * Double.Parse(number)).ToString();
                        history.addHistoryItem(result, operation, Double.Parse(number), Double.Parse(input.Text));
                        calculatorTab.history.addHistoryItem(result, operation, Double.Parse(number), Double.Parse(input.Text));
                    }
                    break;
                case "/":
                    if (Double.Parse(input.Text) == 0)
                    {
                        input.Text = "Cannot divide by zero";
                        result = 0;
                        operation = "";
                        displayCalculate.Text = "1 / (0)";
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
                        if (displayCalculate.Text.Split(' ').Length == 4)
                        {
                            rightNum = displayCalculate.Text.Split(' ')[2];
                            displayCalculate.Text = result.ToString() + " " + operation + " " + rightNum + " =";
                            input.Text = (result / Double.Parse(rightNum)).ToString();
                            history.addHistoryItem(result, operation, Double.Parse(rightNum), Double.Parse(input.Text));
                            calculatorTab.history.addHistoryItem(result, operation, Double.Parse(rightNum), Double.Parse(input.Text));
                        }
                        else
                        {
                            displayCalculate.Text = result.ToString() + " " + operation + " " + number + " =";
                            input.Text = (result / Double.Parse(number)).ToString();
                            history.addHistoryItem(result, operation, Double.Parse(number), Double.Parse(input.Text));
                            calculatorTab.history.addHistoryItem(result, operation, Double.Parse(number), Double.Parse(input.Text));
                        }
                    }
                    break;
                default:
                    if (input.Text != "")
                    {
                        history.addHistoryItemV2(Double.Parse(input.Text));
                        calculatorTab.history.addHistoryItemV2(Double.Parse(input.Text));
                        displayCalculate.Text = Double.Parse(input.Text).ToString() + " =";
                    }
                    break;
            }

            result = Double.Parse(input.Text);
        }

        private void reset()
        {
            input.Text = "0";
            displayCalculate.Text = "";
            operation = "";
            ischeck = false;
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
            if (input.Text.Equals("Cannot divide by zero") || input.Text.Equals("Overflow") || input.Text.Equals("Invalid input"))
            {
                reset();
                return;
            }
            if (input.Text.Length > 0)
            {
                input.Text = input.Text.Remove(input.Text.Length - 1, 1);
            }
            if (input.Text == "")
            {
                input.Text = "0";
                displayCalculate.Text = "";
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
                reset();
                return;
            }
            input.Text = "0";
            displayCalculate.Text = "";
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
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char) Keys.Back && e.KeyChar != '.')
            {
                e.Handled = true;
            } else
            {
                e.Handled = true;

                if (e.KeyChar == '.' && this.input.Text.Contains("."))
                {
                    return;
                }

                if (this.input.Text.Length >= 1)
                {
                    if (this.input.Text.ToString()[0] == '0' && e.KeyChar != '.')
                    {
                        if (this.input.Text.Length >= 2)
                        {
                            if (this.input.Text.ToString()[1] == '.')
                            {
                                this.input.Text += e.KeyChar.ToString();
                                return;
                            }
                        }
                        this.input.Text = e.KeyChar.ToString();
                        return;
                    }

                    
                }
                

                if (e.KeyChar != (char)Keys.Back)
                {
                    this.input.Text += e.KeyChar;
                } else
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
                mcBtn.Checked = true;
                msBtn.Checked = true;
                mrBtn.Checked = true;
                mPlusBtn.Checked = true;
                mMinusBtn.Checked = true;
                openMemoryBtn.Checked = true;

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
                mcBtn.Cursor = Cursors.Default;
                msBtn.Cursor = Cursors.Default;
                mrBtn.Cursor = Cursors.Default;
                mPlusBtn.Cursor = Cursors.Default;
                mMinusBtn.Cursor = Cursors.Default;
                openMemoryBtn.Cursor = Cursors.Default;
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
                mcBtn.Checked = false;
                msBtn.Checked = false;
                mrBtn.Checked = false;
                mPlusBtn.Checked = false;
                mMinusBtn.Checked = false;
                openMemoryBtn.Checked = false;

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
                mcBtn.Cursor = Cursors.Hand;
                msBtn.Cursor = Cursors.Hand;
                mrBtn.Cursor = Cursors.Hand;
                mPlusBtn.Cursor = Cursors.Hand;
                mMinusBtn.Cursor = Cursors.Hand;
                openMemoryBtn.Cursor = Cursors.Hand;
            }
        }

        private void oneXBtn_Click(object sender, EventArgs e)
        {
            string number = input.Text;
            if (oneXBtn.Checked == true) return;

            if (Double.Parse(input.Text) == 0)
            {
                input.Text = "Cannot divide by zero";
                displayCalculate.Text = result.ToString() + " / (0)";
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
                if (displayCalculate.Text.Split(' ').Length == 4)
                {
                    displayCalculate.Text = "1/(" + input.Text + ")";
                    input.Text = (1 / Double.Parse(input.Text)).ToString();
                }
                else
                {
                    if (oneXNum == 0)
                    {
                        oneXNum = Double.Parse(input.Text);
                        if (displayCalculate.Text.Split(' ').Length == 2)
                        {
                            double leftNum = Double.Parse(displayCalculate.Text.Split(' ')[0]);
                            displayCalculate.Text = displayCalculate.Text.Split(' ')[0] + " " + operation + " " + "1/(" + oneXNum + ")";
                        }
                        else
                        {
                            displayCalculate.Text = "1/(" + oneXNum + ")";
                        }
                        input.Text = (1 / oneXNum).ToString();
                    }
                    else
                    {
                        if (displayCalculate.Text.Split(' ').Length == 3)
                        {
                            double leftNum = Double.Parse(displayCalculate.Text.Split(' ')[0]);
                            string elementTwo = "1/(" + displayCalculate.Text.Split(' ')[2] + ")";
                            displayCalculate.Text = leftNum + " " + operation + " " + elementTwo;

                            input.Text = (1 / Double.Parse(rightNum)).ToString();
                        }
                        else
                        {
                            displayCalculate.Text = "1/(" + displayCalculate.Text + ")";
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
            if (displayCalculate.Text.Split(' ').Length == 4)
            {
                displayCalculate.Text = "sqr(" + input.Text + ")";
                input.Text = Math.Pow(Double.Parse(input.Text), 2).ToString();
            }
            else
            {
                if (oneXNum == 0)
                {
                    oneXNum = Double.Parse(input.Text);
                    if (displayCalculate.Text.Split(' ').Length == 2)
                    {
                        double leftNum = Double.Parse(displayCalculate.Text.Split(' ')[0]);
                        displayCalculate.Text = displayCalculate.Text.Split(' ')[0] + " " + operation + " " + "sqr/(" + oneXNum + ")";
                    }
                    else
                    {
                        displayCalculate.Text = "sqr(" + oneXNum + ")";
                    }
                    input.Text = Math.Pow(oneXNum, 2).ToString();
                }
                else
                {
                    if (displayCalculate.Text.Split(' ').Length == 3)
                    {
                        double leftNum = Double.Parse(displayCalculate.Text.Split(' ')[0]);
                        string elementTwo = "sqr(" + displayCalculate.Text.Split(' ')[2] + ")";
                        displayCalculate.Text = leftNum + " " + operation + " " + elementTwo;

                        input.Text = Math.Pow(Double.Parse(rightNum), 2).ToString();
                    }
                    else
                    {
                        displayCalculate.Text = "sqr(" + displayCalculate.Text + ")";
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

            if (double.Parse(number)<0)
            {
                if (displayCalculate.Text.Split(' ').Length == 2)
                {
                    displayCalculate.Text = displayCalculate.Text.Split(' ')[0] + " " + operation + " " + "√(" + input.Text + ")";
                }
                else if (displayCalculate.Text.Split(' ').Length == 3)
                {
                    string elementTwo = "√(" + displayCalculate.Text.Split(' ')[2] + ")";
                    displayCalculate.Text = displayCalculate.Text.Split(' ')[0] + " " + operation + " " + elementTwo;
                    input.Text = Math.Sqrt(Double.Parse(rightNum)).ToString();
                }
                else
                {
                    displayCalculate.Text = "√(" + input.Text + ")";
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

                return;
            }
            if (displayCalculate.Text.Split(' ').Length == 4)
            {
                displayCalculate.Text = "√(" + input.Text + ")";
                input.Text = Math.Sqrt(Double.Parse(input.Text)).ToString();
            }
            else
            {
                
                if (oneXNum == 0)
                {
                    oneXNum = Double.Parse(input.Text);
                    if (displayCalculate.Text.Split(' ').Length == 2 || displayCalculate.Text.Split(' ').Length == 3)
                    {
                        double leftNum = Double.Parse(displayCalculate.Text.Split(' ')[0]);
                        displayCalculate.Text = leftNum + " " + operation + " " + "√(" + oneXNum + ")";
                    }
                    else
                    {
                        displayCalculate.Text = "√(" + oneXNum + ")";
                    }
                    
                    input.Text = Math.Sqrt(oneXNum).ToString();
                }
                else
                {
                    if (displayCalculate.Text.Split(' ').Length == 3)
                    {
                        double leftNum = Double.Parse(displayCalculate.Text.Split(' ')[0]);
                        string elementTwo = "√(" + displayCalculate.Text.Split(' ')[2] + ")";
                        displayCalculate.Text = leftNum + " " + operation + " " + elementTwo;
                        input.Text = Math.Sqrt(Double.Parse(rightNum)).ToString();
                    }
                    else
                    {
                        displayCalculate.Text = "√(" + displayCalculate.Text + ")";
                        input.Text = Math.Sqrt(Double.Parse(rightNum)).ToString();
                    }
                }
                rightNum = input.Text;
            }
        }

        private void percentBtn_Click(object sender, EventArgs e)
        {
            if (percentBtn.Checked == true) return;

            if (displayCalculate.Text.Split(' ').Length == 2)
            {
                rightNum = input.Text;

                input.Text = (Convert.ToDouble(input.Text) / 100 * Convert.ToDouble(displayCalculate.Text.Split(' ')[0])).ToString();

                displayCalculate.Text = result + " " + operation + " " + Convert.ToDouble(input.Text).ToString();

                oneXNum = 0;

                if (displayCalculate.Text.Split(' ').Length == 4)
                {
                    displayCalculate.Text += " =";
                }

                return;
            }

            if (displayCalculate.Text.Split(' ').Length == 3)
            {
                input.Text = (Convert.ToDouble(rightNum) / 100 * Convert.ToDouble(input.Text)).ToString();

                displayCalculate.Text = result + " " + operation + " " + Convert.ToDouble(input.Text).ToString();

                oneXNum = 0;

                if (displayCalculate.Text.Split(' ').Length == 4)
                {
                    displayCalculate.Text += " =";
                }

                return;
            }

            if (displayCalculate.Text.Split(' ').Length == 4)
            {
                input.Text = (Convert.ToDouble(input.Text) / 100 * Convert.ToDouble(input.Text)).ToString();

                rightNum = "0";

                displayCalculate.Text = result.ToString();

                return;
            }

            if (displayCalculate.Text.Split(' ').Length == 1 || string.IsNullOrEmpty(displayCalculate.Text))
            {
                input.Text = "0";
                displayCalculate.Text = "0";
            } else
            {
                input.Text = (Convert.ToDouble(input.Text) / 100 * Convert.ToDouble(input.Text)).ToString();

                displayCalculate.Text = input.Text.ToString();
                result = Convert.ToDouble(input.Text);
            }
            oneXNum = 0;
            rightNum = "0";
        }

        public void memoryAddMomoryItem(double number)
        {
            memory.memoryValidation();
            memory.label2.Hide();
            memory.label2.SendToBack();

            MemoryItem memoryItem = new MemoryItem(number);
            memoryItem.Dock = DockStyle.Top;
            memoryItem.SendToBack();
            memoryItem.mcBtn.MouseClick += (object sender, MouseEventArgs e) =>
            {
                memory.panel3.Controls.Remove(memoryItem);
                if (memory.panel3.Controls.Count <= 1)
                {
                    memory.label2.Show();
                    memory.label2.BringToFront();
                    memory.clearBtn.Visible = false;
                }
                if (fullscreen)
                {
                    calculatorTab.memory.panel3.Controls.Remove(memoryItem);
                    if (calculatorTab.memory.panel3.Controls.Count <= 1)
                    {
                        calculatorTab.memory.label2.Show();
                        calculatorTab.memory.label2.BringToFront();
                        calculatorTab.memory.clearBtn.Visible = false;
                    }
                }
            };
            memoryItem.mPlusBtn.MouseClick += (object sender, MouseEventArgs e) =>
            {
                memoryItem.label1.Text = $@"{Convert.ToDouble(memoryItem.label1.Text) + Convert.ToDouble(input.Text)}";
            };
            memoryItem.mMinusBtn.MouseClick += (object sender, MouseEventArgs e) =>
            {
                memoryItem.label1.Text = $@"{Convert.ToDouble(memoryItem.label1.Text) - Convert.ToDouble(input.Text)}";
            };

            memory.panel3.Controls.Add(memoryItem);

            if (memory.panel3.Controls.Count <= 1)
            {
                memory.label2.Show();
                memory.label2.BringToFront();
                memory.clearBtn.Visible = false;
            }
            else
            {
                memory.label2.Hide();
                memory.label2.SendToBack();
                memory.clearBtn.Visible = true;
            }

        }

        public void memoryZoomAddMomoryItem(double number)
        {
            calculatorTab.memory.memoryValidation();
            calculatorTab.memory.label2.Hide();
            calculatorTab.memory.label2.SendToBack();

            MemoryItem memoryItem = new MemoryItem(number);
            memoryItem.Dock = DockStyle.Top;
            memoryItem.SendToBack();
            memoryItem.mcBtn.MouseClick += (object sender, MouseEventArgs e) =>
            {
                calculatorTab.memory.panel3.Controls.Remove(memoryItem);
                if (calculatorTab.memory.panel3.Controls.Count <= 1)
                {
                    calculatorTab.memory.label2.Show();
                    calculatorTab.memory.label2.BringToFront();
                    calculatorTab.memory.clearBtn.Visible = false;
                }
                if (!fullscreen)
                {
                    memory.panel3.Controls.Remove(memoryItem);
                    if (memory.panel3.Controls.Count <= 1)
                    {
                        memory.label2.Show();
                        memory.label2.BringToFront();
                        memory.clearBtn.Visible = false;
                    }
                }
            };
            memoryItem.mPlusBtn.MouseClick += (object sender, MouseEventArgs e) =>
            {
                memoryItem.label1.Text = $@"{Convert.ToDouble(memoryItem.label1.Text) + Convert.ToDouble(input.Text)}";
            };
            memoryItem.mMinusBtn.MouseClick += (object sender, MouseEventArgs e) =>
            {
                memoryItem.label1.Text = $@"{Convert.ToDouble(memoryItem.label1.Text) - Convert.ToDouble(input.Text)}";
            };

            calculatorTab.memory.panel3.Controls.Add(memoryItem);

            if (calculatorTab.memory.panel3.Controls.Count <= 1)
            {
                calculatorTab.memory.label2.Show();
                calculatorTab.memory.label2.BringToFront();
                calculatorTab.memory.clearBtn.Visible = false;
            }
            else
            {
                calculatorTab.memory.label2.Hide();
                calculatorTab.memory.label2.SendToBack();
                calculatorTab.memory.clearBtn.Visible = true;
            }

        }

        private void msBtn_Click(object sender, EventArgs e)
        {
            if (msBtn.Checked) return;
            if (!fullscreen)
            {
                memoryAddMomoryItem(Convert.ToDouble(input.Text));
            }
            else
            {
                memoryZoomAddMomoryItem(Convert.ToDouble(input.Text));
            }
        }

        private void mMinusBtn_Click(object sender, EventArgs e)
        {
            if (mMinusBtn.Checked) return;

            if (!fullscreen)
            {
                if (memory.panel3.Controls.Count <= 1)
                {
                    memoryAddMomoryItem(Convert.ToDouble(input.Text));
                }
                else
                {
                    int n = memory.panel3.Controls.Count - 2;
                    MemoryItem memoryItem = memory.panel3.Controls[n] as MemoryItem;
                    if (memoryItem != null)
                    {
                        memoryItem.Mminus(Convert.ToDouble(input.Text));
                    }
                }
            }
            else
            {
                if (calculatorTab.memory.panel3.Controls.Count <= 1)
                {
                    memoryZoomAddMomoryItem(Convert.ToDouble(input.Text));
                }
                else
                {
                    int n = calculatorTab.memory.panel3.Controls.Count - 2;
                    MemoryItem memoryItem = calculatorTab.memory.panel3.Controls[n] as MemoryItem;
                    if (memoryItem != null)
                    {
                        memoryItem.Mminus(Convert.ToDouble(input.Text));
                    }
                }
            }
        }

        private void mPlusBtn_Click(object sender, EventArgs e)
        {
            if (mPlusBtn.Checked) return;
            if (!fullscreen)
            {
                if (memory.panel3.Controls.Count <= 1)
                {
                    memoryAddMomoryItem(Convert.ToDouble(input.Text));
                }
                else
                {
                    int n = memory.panel3.Controls.Count - 2;
                    MemoryItem memoryItem = memory.panel3.Controls[n] as MemoryItem;
                    if (memoryItem != null)
                    {
                        memoryItem.Mplus(Convert.ToDouble(input.Text));
                    }
                }
            }
            else
            {
                if (calculatorTab.memory.panel3.Controls.Count <= 1)
                {
                    memoryZoomAddMomoryItem(Convert.ToDouble(input.Text));
                }
                else
                {
                    int n = calculatorTab.memory.panel3.Controls.Count - 2;
                    MemoryItem memoryItem = calculatorTab.memory.panel3.Controls[n] as MemoryItem;
                    if (memoryItem != null)
                    {
                        memoryItem.Mplus(Convert.ToDouble(input.Text));
                    }
                }
            }
        }

        private void mrBtn_Click(object sender, EventArgs e)
        {
            if (mrBtn.Checked) return;

            if (!fullscreen)
            {
                int n = memory.panel3.Controls.Count - 2;
                MemoryItem memoryItem = memory.panel3.Controls[n] as MemoryItem;
                if (memoryItem != null)
                {
                    input.Text = memoryItem.label1.Text;
                }
            }
            else
            {
                int n = calculatorTab.memory.panel3.Controls.Count - 2;
                MemoryItem memoryItem = calculatorTab.memory.panel3.Controls[n] as MemoryItem;
                if (memoryItem != null)
                {
                    input.Text = memoryItem.label1.Text;
                }
            }
        }

        private void mcBtn_Click(object sender, EventArgs e)
        {
            if (mcBtn.Checked) return;
            if (!fullscreen)
            {
                memory.clearMemory();
            }
            else
            {
                calculatorTab.memory.clearMemory();
            }
        }

        private void clearInputBtn_Click(object sender, EventArgs e)
        {
            if (input.Text.Equals("Cannot divide by zero") || input.Text.Equals("Overflow") || input.Text.Equals("Invalid input"))
            {
                reset();
            }
            input.Text="0";
            if (displayCalculate.Text.Split(' ').Length == 4)
            {
                displayCalculate.Text = "";
            }
            
        }

        private void input_TextChanged(object sender, EventArgs e)
        {
        }

        private void input_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(input.Text))
            {
                reset();
            }
        }

        private void memoryCheck_Tick(object sender, EventArgs e)
        {
            if (!fullscreen)
            {
                if (memory.panel3.Controls.Count <= 1)
                {
                    openMemoryBtn.Checked = true;
                    mcBtn.Checked = true;
                    mrBtn.Checked = true;

                    openMemoryBtn.Cursor = Cursors.Default;
                    mcBtn.Cursor = Cursors.Default;
                    mrBtn.Cursor = Cursors.Default;
                }
                else
                {
                    openMemoryBtn.Checked = false;
                    mcBtn.Checked = false;
                    mrBtn.Checked = false;

                    openMemoryBtn.Cursor = Cursors.Hand;
                    mcBtn.Cursor = Cursors.Hand;
                    mrBtn.Cursor = Cursors.Hand;
                }
            }
            else
            {
                if (calculatorTab.memory.panel3.Controls.Count <= 1)
                {
                    openMemoryBtn.Checked = true;
                    mcBtn.Checked = true;
                    mrBtn.Checked = true;

                    openMemoryBtn.Cursor = Cursors.Default;
                    mcBtn.Cursor = Cursors.Default;
                    mrBtn.Cursor = Cursors.Default;
                }
                else
                {
                    openMemoryBtn.Checked = false;
                    mcBtn.Checked = false;
                    mrBtn.Checked = false;

                    openMemoryBtn.Cursor = Cursors.Hand;
                    mcBtn.Cursor = Cursors.Hand;
                    mrBtn.Cursor = Cursors.Hand;
                }
            }
        }

        public void clickChangeHistory()
        {
            overlayHistory.Hide();
            historyIcon.BringToFront();
            this.test.Visible = true;
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
