using Guna.UI.WinForms;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Calculate
{
    public partial class Calculator : Form
    {
		private static Calculator instance;
		Double result = 0;
		String operation = "";
		bool enter_value, isNegative = false;
		char iOperation;

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
		GlassyPanel overlayHistory = new GlassyPanel();
		GlassyPanel overlaySidebar = new GlassyPanel();
		GlassyPanel overlayMemory = new GlassyPanel();
		History history;
		Memory memory = new Memory();

		public Calculator()
		{
			
			InitializeComponent();
			overlaySidebar.Opacity = 0;

			overlayHistory.Dock = DockStyle.Fill;
			this.Controls.Add(overlayHistory);
			history = new History();
			history.Dock = DockStyle.Bottom;
			History.HistoryAction = SelectHistoryItem;
			overlayHistory.Controls.Add(history);

			overlayHistory.Hide();
			overlayHistory.SendToBack();

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
			if (History.HistoryAction == null)
			{
				History.HistoryAction += SelectHistoryItem;
			}
			overlayHistory.BringToFront();
			overlayHistory.Show();
		}

		private void openMemoryBtn_Click(object sender, EventArgs e)
		{
			overlayMemory.BringToFront();
			overlayMemory.Show();
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
				this.historyIcon.Visible = false;
				this.openMemoryBtn.Visible = false;
				this.leftPanel.Visible = true;
			}
			else
			{
				this.historyIcon.Visible = true;
				this.openMemoryBtn.Visible = true;
				this.leftPanel.Visible = false;
			}
		}

		private void gunaAdvenceButton2_Click(object sender, EventArgs e)
		{
			sidebarTransition.Start();
		}

		private void displayCalculate_Click(object sender, EventArgs e)
		{

		}

		private void numbers_Only(object sender, EventArgs e)
		{
			GunaAdvenceButton b = (GunaAdvenceButton)sender;
			string plusOrMinusBtn = b.Name;
			if ((input.Text == "0") || enter_value)
			{
				input.Text = "";
				enter_value = false;
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
				isNegative = !isNegative;

				if (input.Text != "0")
				{
					input.Text = (isNegative ? "-" : "") + input.Text;
				}
			}
			else
			{
				input.Text += b.Text;
			}
		}

		private void operators_Click(object sender, EventArgs e)
		{
			GunaAdvenceButton b = (GunaAdvenceButton)sender;
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
				equalBtn.PerformClick();
				enter_value = true;
				displayCalculate.Text = input.Text + " " + operation2;

			}
			else
			{
				result = Double.Parse(input.Text);
				enter_value = true;
				displayCalculate.Text = result + " " + operation2;
			}
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
			Double number2 = Double.Parse(input.Text);
			Double number1 = result;
			string number = input.Text;
			switch (operation)
			{
				case "+":
					displayCalculate.Text += number.ToString() + " =";
					input.Text = (result + Double.Parse(input.Text)).ToString();
					history.addHistoryItem(number1,"+",number2,Double.Parse(input.Text));
					break;
				case "-":
					displayCalculate.Text += number.ToString() + " =";
					input.Text = (result - Double.Parse(input.Text)).ToString();
					history.addHistoryItem(number2, "-", Double.Parse(number), Double.Parse(input.Text));
					break;
				case "*":
					displayCalculate.Text += number.ToString() + " =";
					input.Text = (result * Double.Parse(input.Text)).ToString();
					history.addHistoryItem(number2, "*", Double.Parse(number), Double.Parse(input.Text));
					break;
				case "/":
					displayCalculate.Text += number.ToString() + " =";
					if (Double.Parse(input.Text) == 0)
					{
						input.Text = "Cannot divide by zero";
						result = 0;
						operation = "";
						displayCalculate.Text = "";
						return;
					}
					else
					{
						input.Text = (result / Double.Parse(input.Text)).ToString();
						history.addHistoryItem(number2, "/", Double.Parse(number), Double.Parse(input.Text));
					}
					break;
				default:
					break;
			}
			result = Double.Parse(input.Text);
			operation = "";
		}

		private void backspaceBtn_Click(object sender, EventArgs e)
		{
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
			input.Text = "0";
			displayCalculate.Text = "";
			result = 0;
		}

		private void clearInputBtn_Click(object sender, EventArgs e)
		{
			input.Text = "0";
		}
		private void SelectHistoryItem(string operations,string result)
		{
			this.displayCalculate.Text = operations;	
			this.input.Text = result;
			overlayHistory.Hide();
			historyIcon.BringToFront();
		}
	}
}
