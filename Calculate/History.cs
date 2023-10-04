using System;
using System.Windows.Forms;

namespace Calculate
{
    public partial class History : UserControl
    {
        public History()
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
            ClearAllItems();
            Calculator.Instance.synchronizeHistoryWhenDelete(typeof(History).Name);
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
        public void ClearAllItems()
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
                        ClearAllItems();
                    }
                    break;
                }
            }
        }
    }
}
