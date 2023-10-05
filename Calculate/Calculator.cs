using Guna.UI.WinForms;
using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Calculate
{
    public partial class Calculator : Form
    {
        Double result = 0;
        string operation = "";
        bool enter_value, ischeck = false;
        bool enter_input = false;
        string rightNum = "0";
        Double oneXNum = 0;
        private static Calculator instance;

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
        History history = History.Instance;
        Memory memory = Memory.Instance;
        CaculatorTab calculatorTab = CaculatorTab.Instance;

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

            this.sidebarChild.Dock = DockStyle.Left;
            overlaySidebar.Controls.Add(sidebarChild);

            overlaySidebar.Hide();
            overlaySidebar.BringToFront();
            this.Controls.Add(overlaySidebar);

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
                    mcBtn.Visible = true;
                    mrBtn.Visible = true;
                }
            }
            else
            {
                sidebarChild.Width += 20;
                mcBtn.Visible = false;
                mrBtn.Visible = false;
                if (sidebarChild.Width >= 280)
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

            string newText = removeComma();

            if (newText.Length >= 15) return;

            if (displayCalculate.Text.Split(' ').Length == 3 && plusOrMinusBtn != "plusOrMinusBtn")
            {
                displayCalculate.Text = string.Join(" ", displayCalculate.Text.Split(' ').Reverse().Skip(1).Reverse());
            }

            if (displayCalculate.Text.Split(' ').Length == 4)
            {
                if (plusOrMinusBtn != "plusOrMinusBtn")
                {
                    displayCalculate.Text = "";
                    input.Text = generateComma(b.Text);
                    result = Double.Parse(b.Text);
                } else
                {
                    displayCalculate.Text = "negate(" + newText + ")";
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

                    if (displayCalculate.Text.Split(' ').Length == 1)
                    {
                        displayCalculate.Text = "negate(" + displayCalculate.Text + ")";
                        input.Text = generateComma((Double.Parse(newText) * -1).ToString());
                        oneXNum = Double.Parse(removeComma()) * -1;
                        rightNum = removeComma();
                        result = oneXNum;
                        return;
                    }

                    if (enter_input && displayCalculate.Text.Split(' ').Length == 2)
                    {
                        double leftNum = Double.Parse(displayCalculate.Text.Split(' ')[0]);
                        oneXNum = Double.Parse(newText) * -1;
                        displayCalculate.Text = leftNum + " " + operation + " " + oneXNum;
                        input.Text = generateComma((Double.Parse(newText) * -1).ToString());
                        rightNum = removeComma();
                        return;
                    }

                    if (displayCalculate.Text.Split(' ').Length == 4)
                    {
                        displayCalculate.Text = "negate(" + tmp + ")";
                        result = Double.Parse(newText) * -1;
                        input.Text = generateComma((Double.Parse(newText) * -1).ToString());
                        rightNum = "0";
                        oneXNum = 0;
                        return;
                    }


                    if (displayCalculate.Text.Split(' ').Length == 3)
                    {
                        double leftNum = Double.Parse(displayCalculate.Text.Split(' ')[0]);
                        string elementTwo = "negate(" + displayCalculate.Text.Split(' ')[2] + ")";
                        displayCalculate.Text = leftNum + " " + operation + " " + elementTwo;
                        oneXNum = Double.Parse(newText) * -1;
                        input.Text = (Double.Parse(newText) * -1).ToString();
                        rightNum = removeComma();
                        return;
                    }

                    if (displayCalculate.Text.Split(' ').Length == 2)
                    {
                        double leftNum = Double.Parse(displayCalculate.Text.Split(' ')[0]);
                        string elementTwo = "negate(" + tmp + ")";
                        displayCalculate.Text = leftNum + " " + operation + " " + elementTwo;
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
            String operation2="";
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
                    displayCalculate.Text = result + " " + operation2;
                } else
                {
                    enter_value = true;
                    displayCalculate.Text = newText + " " + operation2;
                }
            }
            else
            {
                result = Double.Parse(newText);
                enter_value = true;
                displayCalculate.Text = result + " " + operation2;
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
                    if (displayCalculate.Text.Split(' ').Length == 4)
                    {
                        rightNum = displayCalculate.Text.Split(' ')[2];
                        
                        displayCalculate.Text = result.ToString() + " " + operation + " " + rightNum + " =";
                        input.Text = generateComma((result + Double.Parse(rightNum)).ToString());
                        history.addHistoryItem(result, operation, Double.Parse(rightNum), Double.Parse(removeComma()));
                        calculatorTab.history.addHistoryItem(result, operation, Double.Parse(rightNum), Double.Parse(removeComma()));

                    }
                    else
                    {
                        displayCalculate.Text = result.ToString() + " " + operation + " " + number + " =";
                        input.Text = generateComma((result + Double.Parse(number)).ToString());
                        history.addHistoryItem(result, operation, Double.Parse(number), Double.Parse(removeComma()));
                        calculatorTab.history.addHistoryItem(result, operation, Double.Parse(number), Double.Parse(removeComma()));
                    }
                    break; 
                case "-":
                    if (displayCalculate.Text.Split(' ').Length == 4)
                    {
                        rightNum = displayCalculate.Text.Split(' ')[2];
                        displayCalculate.Text = result.ToString() + " " + operation + " " + rightNum + " =";
                        input.Text = generateComma((result - Double.Parse(rightNum)).ToString());
                        history.addHistoryItem(result, operation, Double.Parse(rightNum), Double.Parse(removeComma()));
                        calculatorTab.history.addHistoryItem(result, operation, Double.Parse(rightNum), Double.Parse(removeComma()));
                    }
                    else
                    {
                        displayCalculate.Text = result.ToString() + " " + operation + " " + number + " =";
                        input.Text = generateComma((result - Double.Parse(number)).ToString());
                        history.addHistoryItem(result, operation, Double.Parse(number), Double.Parse(removeComma()));
                        calculatorTab.history.addHistoryItem(result, operation, Double.Parse(number), Double.Parse(removeComma()));
                    }
                    break;                
                case "x":
                    if (displayCalculate.Text.Split(' ').Length == 4)
                    {
                        rightNum = displayCalculate.Text.Split(' ')[2];
                        displayCalculate.Text = result.ToString() + " " + operation + " " + rightNum + " =";
                        input.Text = generateComma((result * Double.Parse(rightNum)).ToString());
                        history.addHistoryItem(result, operation, Double.Parse(rightNum), Double.Parse(removeComma()));
                        calculatorTab.history.addHistoryItem(result, operation, Double.Parse(rightNum), Double.Parse(removeComma()));
                    }
                    else
                    {
                        displayCalculate.Text = result.ToString() + " " + operation + " " + number + " =";
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
                        displayCalculate.Text = "1 / (0)";
                        return;
                    }
                    else
                    {
                        if (displayCalculate.Text.Split(' ').Length == 4)
                        {
                            rightNum = displayCalculate.Text.Split(' ')[2];
                            displayCalculate.Text = result.ToString() + " " + operation + " " + rightNum + " =";
                            input.Text = generateComma((result / Double.Parse(rightNum)).ToString());
                            history.addHistoryItem(result, operation, Double.Parse(rightNum), Double.Parse(removeComma()));
                            calculatorTab.history.addHistoryItem(result, operation, Double.Parse(rightNum), Double.Parse(removeComma()));
                        }
                        else
                        {
                            displayCalculate.Text = result.ToString() + " " + operation + " " + number + " =";
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
                        displayCalculate.Text = Double.Parse(number).ToString() + " =";
                    }
                    break;
            }

            result = Double.Parse(removeComma());
        }

        private void reset()
        {
            input.Text = "0";
            displayCalculate.Text = "";
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
                } else
                {
                    e.Handled = true;
                }
                return;
            }

            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char) Keys.Back && e.KeyChar != '.')
            {
                e.Handled = true;
            } else
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
                } else
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
            string number = removeComma();
            if (oneXBtn.Checked == true) return;

            if (Double.Parse(number) == 0)
            {
                ischeck = true;
                reset();
                input.Text = "Cannot divide by zero";
                displayCalculate.Text = result.ToString() + " / (0)";
                ischeck = false;
                return;
            }
            else
            {
                if (displayCalculate.Text.Split(' ').Length == 4)
                {
                    displayCalculate.Text = "1/(" + number + ")";
                    input.Text = generateComma((1 / Double.Parse(number)).ToString());
                }
                else
                {
                    if (oneXNum == 0)
                    {
                        oneXNum = Double.Parse(number);
                        if (displayCalculate.Text.Split(' ').Length == 2)
                        {
                            double leftNum = Double.Parse(displayCalculate.Text.Split(' ')[0]);
                            displayCalculate.Text = displayCalculate.Text.Split(' ')[0] + " " + operation + " " + "1/(" + oneXNum + ")";
                        }
                        else
                        {
                            displayCalculate.Text = "1/(" + oneXNum + ")";
                        }
                        input.Text = generateComma((1 / oneXNum).ToString());
                    }
                    else
                    {
                        if (displayCalculate.Text.Split(' ').Length == 3)
                        {
                            double leftNum = Double.Parse(displayCalculate.Text.Split(' ')[0]);
                            string elementTwo = "1/(" + displayCalculate.Text.Split(' ')[2] + ")";
                            displayCalculate.Text = leftNum + " " + operation + " " + elementTwo;

                            input.Text = generateComma((1 / Double.Parse(rightNum)).ToString());
                        }
                        else
                        {
                            displayCalculate.Text = "1/(" + displayCalculate.Text + ")";
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
            if (displayCalculate.Text.Split(' ').Length == 4)
            {
                displayCalculate.Text = "sqr(" + number + ")";
                input.Text = generateComma(Math.Pow(Double.Parse(number), 2).ToString());
            }
            else
            {
                if (oneXNum == 0)
                {
                    oneXNum = Double.Parse(number);
                    if (displayCalculate.Text.Split(' ').Length == 2)
                    {
                        double leftNum = Double.Parse(displayCalculate.Text.Split(' ')[0]);
                        displayCalculate.Text = displayCalculate.Text.Split(' ')[0] + " " + operation + " " + "sqr/(" + oneXNum + ")";
                    }
                    else
                    {
                        displayCalculate.Text = "sqr(" + oneXNum + ")";
                    }
                    input.Text = generateComma(Math.Pow(oneXNum, 2).ToString());
                }
                else
                {
                    if (displayCalculate.Text.Split(' ').Length == 3)
                    {
                        double leftNum = Double.Parse(displayCalculate.Text.Split(' ')[0]);
                        string elementTwo = "sqr(" + displayCalculate.Text.Split(' ')[2] + ")";
                        displayCalculate.Text = leftNum + " " + operation + " " + elementTwo;
                    }
                    else
                    {
                        displayCalculate.Text = "sqr(" + displayCalculate.Text + ")";
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

            if (double.Parse(number)<0)
            {
                if (displayCalculate.Text.Split(' ').Length == 2)
                {
                    displayCalculate.Text = displayCalculate.Text.Split(' ')[0] + " " + operation + " " + "√(" + number + ")";
                }
                else if (displayCalculate.Text.Split(' ').Length == 3)
                {
                    string elementTwo = "√(" + displayCalculate.Text.Split(' ')[2] + ")";
                    displayCalculate.Text = displayCalculate.Text.Split(' ')[0] + " " + operation + " " + elementTwo;
                }
                else
                {
                    displayCalculate.Text = "√(" + number + ")";
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
            if (displayCalculate.Text.Split(' ').Length == 4)
            {
                displayCalculate.Text = "√(" + number + ")";
                input.Text = generateComma(Math.Sqrt(Double.Parse(number)).ToString());
            }
            else
            {
                
                if (oneXNum == 0)
                {
                    oneXNum = Double.Parse(number);
                    if (displayCalculate.Text.Split(' ').Length == 2 || displayCalculate.Text.Split(' ').Length == 3)
                    {
                        double leftNum = Double.Parse(displayCalculate.Text.Split(' ')[0]);
                        displayCalculate.Text = leftNum + " " + operation + " " + "√(" + oneXNum + ")";
                    }
                    else
                    {
                        displayCalculate.Text = "√(" + oneXNum + ")";
                    }
                    
                    input.Text = generateComma(Math.Sqrt(oneXNum).ToString());
                }
                else
                {
                    if (displayCalculate.Text.Split(' ').Length == 3)
                    {
                        double leftNum = Double.Parse(displayCalculate.Text.Split(' ')[0]);
                        string elementTwo = "√(" + displayCalculate.Text.Split(' ')[2] + ")";
                        displayCalculate.Text = leftNum + " " + operation + " " + elementTwo;
                        input.Text = generateComma(Math.Sqrt(Double.Parse(rightNum)).ToString());
                    }
                    else
                    {
                        displayCalculate.Text = "√(" + displayCalculate.Text + ")";
                        input.Text = generateComma(Math.Sqrt(Double.Parse(rightNum)).ToString());
                    }
                }
                rightNum = removeComma();
            }
        }

        private void percentBtn_Click(object sender, EventArgs e)
        {
            if (percentBtn.Checked == true) return;

            if (displayCalculate.Text.Split(' ').Length == 2)
            {
                rightNum = removeComma();

                input.Text = generateComma((Convert.ToDouble(removeComma()) / 100 * Convert.ToDouble(displayCalculate.Text.Split(' ')[0])).ToString());

                displayCalculate.Text = result + " " + operation + " " + Convert.ToDouble(removeComma()).ToString();

                oneXNum = 0;

                if (displayCalculate.Text.Split(' ').Length == 4)
                {
                    displayCalculate.Text += " =";
                }

                return;
            }

            if (displayCalculate.Text.Split(' ').Length == 3)
            {
                input.Text = generateComma((Convert.ToDouble(rightNum) / 100 * Convert.ToDouble(removeComma())).ToString());

                displayCalculate.Text = result + " " + operation + " " + Convert.ToDouble(removeComma()).ToString();

                oneXNum = 0;

                if (displayCalculate.Text.Split(' ').Length == 4)
                {
                    displayCalculate.Text += " =";
                }

                return;
            }

            if (displayCalculate.Text.Split(' ').Length == 4)
            {
                input.Text = generateComma((Convert.ToDouble(removeComma()) / 100 * Convert.ToDouble(removeComma())).ToString());

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
                input.Text = (Convert.ToDouble(removeComma()) / 100 * Convert.ToDouble(removeComma())).ToString();

                displayCalculate.Text = removeComma();
                result = Convert.ToDouble(removeComma());
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
                memoryItem.label1.Text = $@"{Convert.ToDouble(memoryItem.label1.Text) + Convert.ToDouble(removeComma())}";
            };
            memoryItem.mMinusBtn.MouseClick += (object sender, MouseEventArgs e) =>
            {
                memoryItem.label1.Text = $@"{Convert.ToDouble(memoryItem.label1.Text) - Convert.ToDouble(removeComma())}";
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
                memoryItem.label1.Text = $@"{Convert.ToDouble(memoryItem.label1.Text) + Convert.ToDouble(removeComma())}";
            };
            memoryItem.mMinusBtn.MouseClick += (object sender, MouseEventArgs e) =>
            {
                memoryItem.label1.Text = $@"{Convert.ToDouble(memoryItem.label1.Text) - Convert.ToDouble(removeComma())}";
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
                memoryAddMomoryItem(Convert.ToDouble(removeComma()));
            }
            else
            {
                memoryZoomAddMomoryItem(Convert.ToDouble(removeComma()));
            }
        }

        private void mMinusBtn_Click(object sender, EventArgs e)
        {
            if (mMinusBtn.Checked) return;

            if (!fullscreen)
            {
                if (memory.panel3.Controls.Count <= 1)
                {
                    memoryAddMomoryItem(Convert.ToDouble(removeComma()));
                }
                else
                {
                    int n = memory.panel3.Controls.Count - 2;
                    MemoryItem memoryItem = memory.panel3.Controls[n] as MemoryItem;
                    if (memoryItem != null)
                    {
                        memoryItem.Mminus(Convert.ToDouble(removeComma()));
                    }
                }
            }
            else
            {
                if (calculatorTab.memory.panel3.Controls.Count <= 1)
                {
                    memoryZoomAddMomoryItem(Convert.ToDouble(removeComma()));
                }
                else
                {
                    int n = calculatorTab.memory.panel3.Controls.Count - 2;
                    MemoryItem memoryItem = calculatorTab.memory.panel3.Controls[n] as MemoryItem;
                    if (memoryItem != null)
                    {
                        memoryItem.Mminus(Convert.ToDouble(removeComma()));
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
                    memoryAddMomoryItem(Convert.ToDouble(removeComma()));
                }
                else
                {
                    int n = memory.panel3.Controls.Count - 2;
                    MemoryItem memoryItem = memory.panel3.Controls[n] as MemoryItem;
                    if (memoryItem != null)
                    {
                        memoryItem.Mplus(Convert.ToDouble(removeComma()));
                    }
                }
            }
            else
            {
                if (calculatorTab.memory.panel3.Controls.Count <= 1)
                {
                    memoryZoomAddMomoryItem(Convert.ToDouble(removeComma()));
                }
                else
                {
                    int n = calculatorTab.memory.panel3.Controls.Count - 2;
                    MemoryItem memoryItem = calculatorTab.memory.panel3.Controls[n] as MemoryItem;
                    if (memoryItem != null)
                    {
                        memoryItem.Mplus(Convert.ToDouble(removeComma()));
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
            if (removeComma().Equals("Cannot divide by zero") || removeComma().Equals("Overflow") || removeComma().Equals("Invalid input"))
            {
                ischeck = true;
                reset();
                ischeck = false;
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
            if (string.IsNullOrEmpty(removeComma()))
            {
                ischeck = true;
                reset();
                ischeck = false;
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
