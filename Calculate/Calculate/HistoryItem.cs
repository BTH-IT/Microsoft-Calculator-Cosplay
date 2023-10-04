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
		public static Action<string, string> OnHistoryItemSelected;
		public HistoryItem(double number1,string operation,double number2,double result)
		{
			InitializeComponent();
			this.operation.Text = $@"{number1} {operation} {number2} = ";
			this.label1.Text = $@"{result}";
		}

		private void HistoryItem_MouseHover(object sender, EventArgs e)
		{
			this.BackColor = ColorTranslator.FromHtml("#EAEAEA");
		}

		private void HistoryItem_MouseLeave(object sender, EventArgs e)
		{
			this.BackColor = Color.Transparent;
		}
		

		private void HistoryItem_Click(object sender, EventArgs e)
		{
			OnHistoryItemSelected(this.operation.Text, this.label1.Text);
		}
	}
}
