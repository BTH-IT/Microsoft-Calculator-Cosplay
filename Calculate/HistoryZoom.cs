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
	public partial class HistoryZoom : UserControl
	{
		public HistoryZoom()
		{
			InitializeComponent();
			if (this.panel3.Controls.Count == 1)
			{
				this.label1.Show();
				this.label1.BringToFront();
				this.clearBtn.Visible = false;
			}
			else
			{
				this.label1.Hide();
				this.label1.SendToBack();
				this.clearBtn.Visible = true;
			}
		}
		public void addHistoryItem(double number1, string operation, double number2, double result)
		{
			this.label1.Hide();
			this.label1.SendToBack();

			HistoryItem historyItem = new HistoryItem(number1, operation, number2, result);
			historyItem.Dock = DockStyle.Top;
			historyItem.SendToBack();
			this.panel3.Controls.Add(historyItem);
			historyItem.setCorrectLocationForOperation();
			historyItem.setCorrectLocationForResult();
			if (this.panel3.Controls.Count == 1)
			{
				this.label1.Show();
				this.label1.BringToFront();
				this.clearBtn.Visible = false;
			}
			else
			{
				this.label1.Hide();
				this.label1.SendToBack();
				this.clearBtn.Visible = true;
			}
		}
		public void addHistoryItemV2(double number)
		{
			this.label1.Hide();
			this.label1.SendToBack();

			HistoryItem historyItem = new HistoryItem(number);
			historyItem.Dock = DockStyle.Top;
			historyItem.SendToBack();
			this.panel3.Controls.Add(historyItem);
			historyItem.setCorrectLocationForOperation();
			historyItem.setCorrectLocationForResult();
			if (this.panel3.Controls.Count == 1)
			{
				this.label1.Show();
				this.label1.BringToFront();
				this.clearBtn.Visible = false;
			}
			else
			{
				this.label1.Hide();
				this.label1.SendToBack();
				this.clearBtn.Visible = true;
			}
		}

		private void clearBtn_Click(object sender, EventArgs e)
		{

			ClearAllItem();
			Calculator.Instance.synchronizeHistoryWhenDelete(typeof(HistoryZoom).Name);
		}
		private void History_Load(object sender, EventArgs e)
		{
			if (this.panel3.Controls.Count == 1)
			{
				this.label1.Show();
				this.label1.BringToFront();
				this.clearBtn.Visible = false;
			}
			else
			{
				this.label1.Hide();
				this.label1.SendToBack();
				this.clearBtn.Visible = true;
			}
		}
		public void ClearAllItem()
		{
			this.panel3.Controls.Clear();
			this.label1.Show();
			this.label1.BringToFront();
			this.panel3.Controls.Add(this.label1);
			this.clearBtn.Visible = false;
		}
		public void DeleteOneItem(string operation, string result)
		{
			foreach (HistoryItem item in this.panel3.Controls)
			{
				if (item.getOperation() == operation && item.getResult() == result)
				{
					this.panel3.Controls.Remove(item);
					this.panel3.Refresh();
					if (this.panel3.Controls.Count <= 0)
					{
						ClearAllItem();
					}
					break;
				}
			}
		}
	}
}

