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
    public partial class History : UserControl
    {
		public static Action<string,string> HistoryAction;
        public History()
        {
            InitializeComponent();
            if (this.historyItemContainer.Controls.Count == 0 )
            {
               this.label1.Show(); 
               this.label1.BringToFront();
            }
            else
            {
				this.label1.Hide();
				this.label1.SendToBack();
			}	
		}

		private void historyItemContainer_SizeChanged(object sender, EventArgs e)
		{
			setWidthForChildControl();
		}

		private void setWidthForChildControl()
		{
			
			foreach (Control ctrl in historyItemContainer.Controls)
			{
				this.historyItemContainer.SuspendLayout();
				ctrl.Width = this.ClientSize.Width - ctrl.Margin.Left - ctrl.Margin.Right;
				ctrl.Height = 102;
				this.historyItemContainer.PerformLayout();
			}
			
		}

		public void addHistoryItem(double number1,string operation,double number2,double result)
        {
			if(HistoryAction != null && HistoryItem.OnHistoryItemSelected==null)
			{
				HistoryItem.OnHistoryItemSelected = HistoryAction;
			}	
			this.label1.Hide();
			this.label1.SendToBack();
			
			HistoryItem historyItem = new HistoryItem(number1, operation, number2, result); 
            this.historyItemContainer.Controls.Add(historyItem);
		
		}

		private void historyItemContainer_SizeChanged_1(object sender, EventArgs e)
		{
			setWidthForChildControl();
		}
	}
}
