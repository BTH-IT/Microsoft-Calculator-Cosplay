using Guna.UI.WinForms;
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
	public partial class CaculatorTab : Form
	{
		public bool isHistorySelected = true;
		public HistoryZoom history = new HistoryZoom();	
		public MemoryZoom memory = new MemoryZoom();	
		public CaculatorTab()
		{
			InitializeComponent();
			history.Dock = DockStyle.Fill;
			memory.Dock = DockStyle.Fill;	
			this.mainContent.Controls.Add(history);
			this.mainContent.Controls.Add(memory);
			selectTab();
		}

		private void selectTab()
		{
			if(isHistorySelected == true)
			{
				this.historyLine.Show();	
				this.memoryLine.Hide();
				history.Show();
				memory.Hide();	
			}
			else
			{
				this.memoryLine.Show();
				this.historyLine.Hide();
				memory.memoryValidation();
				memory.Show();	
				history.Hide();
			}
		}

		private void OnTab_Click(object sender, EventArgs e)
		{
			var panel = (GunaLabel)sender;
			string panelName= panel.Name;	
			switch (panelName)
			{
				case "memoryLabel":
					if(isHistorySelected)
					{
						isHistorySelected = false;
						selectTab();
					}
					break;
				case "historyLabel":
					if(!isHistorySelected)
					{
						isHistorySelected= true;
						selectTab();
					}
					break;
			}
		}
	}
}
