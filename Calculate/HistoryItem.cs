using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculate
{
	public partial class HistoryItem : UserControl
	{
		bool hovered = false;
		public HistoryItem(double number1, string operation, double number2, double result)
		{
			InitializeComponent();
			this.operation.Text = $@"{number1} {operation} {number2} =";
			this.label1.Text = $@"{result}";
			timer1.Start();

		}
		public HistoryItem(double number)
		{
			InitializeComponent();
			this.operation.Text = $@"{number} =";
			this.label1.Text = $@"{number}";
			timer1.Start();
		}

		private void panel1_MouseHover(object sender, EventArgs e)
		{
			hovered = true;
		}
		public void setCorrectLocationForOperation()
		{

			int opearionWidth = this.operation.ClientSize.Width;
			int parentWidth = this.Width;
			int newX = parentWidth - opearionWidth - this.panel1.Padding.Right;
			int y = this.operation.Location.Y;
			this.operation.Location = new Point(newX, y);
		}
		public void setCorrectLocationForResult()
		{
			int resultWidth = this.label1.ClientSize.Width;
			int parentWidth = this.Width;
			int newX = parentWidth - resultWidth - this.panel1.Padding.Right;
			int y = this.label1.Location.Y;
			this.label1.Location = new Point(newX, y);
		}
		private void panel1_MouseLeave(object sender, EventArgs e)
		{

			hovered = false;
		}

		private void panel1_Click(object sender, EventArgs e)
		{
			Calculator.Instance.displayCalculate.Text = this.operation.Text;
			Calculator.Instance.input.Text = this.label1.Text;
			Calculator.Instance.clickChangeHistory();
		}
		private void HistoryItem_Load(object sender, EventArgs e)
		{
			this.gunaContextMenuStrip1.PerformLayout();
		}

		private void deleteToolStripMenuItem_MouseHover(object sender, EventArgs e)
		{
			this.deleteToolStripMenuItem.BackColor = ColorTranslator.FromHtml("#ECECEC");
			this.gunaContextMenuStrip1.Refresh();
		}

		private void deleteToolStripMenuItem_MouseLeave(object sender, EventArgs e)
		{
			this.deleteToolStripMenuItem.BackColor = ColorTranslator.FromHtml("#F3F3F3");
			this.gunaContextMenuStrip1.Refresh();
		}
		public string getOperation()
		{
			return this.operation.Text;
		}
		public string getResult()
		{
			return this.label1.Text;
		}
		private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Calculator.Instance.synchronizeHistoryWhenDelete(nameof(HistoryItem), mode: 1, operation: getOperation(), result: getResult());
			this.gunaContextMenuStrip1.Close();
		}

		private void gunaContextMenuStrip1_Closing(object sender, ToolStripDropDownClosingEventArgs e)
		{
			if (e.CloseReason == ToolStripDropDownCloseReason.ItemClicked)
			{
				e.Cancel = true;
			}
		}

		private void panel1_MouseEnter(object sender, EventArgs e)
		{
			hovered = true;
		}

		private void timer1_Tick(object sender, EventArgs e)
		{
			if (hovered)
			{
				this.panel1.BackColor = ColorTranslator.FromHtml("#EAEAEA");
			}
			else
			{
				this.panel1.BackColor = Color.Transparent;
			}
		}

		private void operation_Resize(object sender, EventArgs e)
		{
			if (this.operation.Height > 20)
			{
				this.Height += (this.operation.Height - 20);

			}
		}
	}
}
