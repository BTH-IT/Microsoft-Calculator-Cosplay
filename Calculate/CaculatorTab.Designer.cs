namespace Calculate
{
	partial class CaculatorTab
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.historyPanel = new System.Windows.Forms.Panel();
			this.historyLine = new System.Windows.Forms.Panel();
			this.historyLabel = new Guna.UI.WinForms.GunaLabel();
			this.memoryPanel = new System.Windows.Forms.Panel();
			this.memoryLine = new System.Windows.Forms.Panel();
			this.memoryLabel = new Guna.UI.WinForms.GunaLabel();
			this.mainContent = new System.Windows.Forms.Panel();
			this.historyPanel.SuspendLayout();
			this.memoryPanel.SuspendLayout();
			this.SuspendLayout();
			// 
			// historyPanel
			// 
			this.historyPanel.Controls.Add(this.historyLine);
			this.historyPanel.Controls.Add(this.historyLabel);
			this.historyPanel.Location = new System.Drawing.Point(12, 12);
			this.historyPanel.Name = "historyPanel";
			this.historyPanel.Size = new System.Drawing.Size(116, 61);
			this.historyPanel.TabIndex = 0;
			// 
			// historyLine
			// 
			this.historyLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(90)))), ((int)(((byte)(158)))));
			this.historyLine.Location = new System.Drawing.Point(50, 42);
			this.historyLine.Name = "historyLine";
			this.historyLine.Size = new System.Drawing.Size(20, 3);
			this.historyLine.TabIndex = 1;
			// 
			// historyLabel
			// 
			this.historyLabel.AutoSize = true;
			this.historyLabel.Font = new System.Drawing.Font("Segoe UI", 12F);
			this.historyLabel.Location = new System.Drawing.Point(20, 11);
			this.historyLabel.Name = "historyLabel";
			this.historyLabel.Size = new System.Drawing.Size(75, 28);
			this.historyLabel.TabIndex = 0;
			this.historyLabel.Text = "History";
			this.historyLabel.Click += new System.EventHandler(this.OnTab_Click);
			// 
			// memoryPanel
			// 
			this.memoryPanel.Controls.Add(this.memoryLine);
			this.memoryPanel.Controls.Add(this.memoryLabel);
			this.memoryPanel.Location = new System.Drawing.Point(131, 12);
			this.memoryPanel.Name = "memoryPanel";
			this.memoryPanel.Size = new System.Drawing.Size(115, 61);
			this.memoryPanel.TabIndex = 1;
			// 
			// memoryLine
			// 
			this.memoryLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(90)))), ((int)(((byte)(158)))));
			this.memoryLine.Location = new System.Drawing.Point(44, 42);
			this.memoryLine.Name = "memoryLine";
			this.memoryLine.Size = new System.Drawing.Size(20, 3);
			this.memoryLine.TabIndex = 1;
			// 
			// memoryLabel
			// 
			this.memoryLabel.AutoSize = true;
			this.memoryLabel.Font = new System.Drawing.Font("Segoe UI", 12F);
			this.memoryLabel.Location = new System.Drawing.Point(3, 11);
			this.memoryLabel.Name = "memoryLabel";
			this.memoryLabel.Size = new System.Drawing.Size(86, 28);
			this.memoryLabel.TabIndex = 0;
			this.memoryLabel.Text = "Memory";
			this.memoryLabel.Click += new System.EventHandler(this.OnTab_Click);
			// 
			// mainContent
			// 
			this.mainContent.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.mainContent.AutoSize = true;
			this.mainContent.BackColor = System.Drawing.SystemColors.Control;
			this.mainContent.Location = new System.Drawing.Point(0, 79);
			this.mainContent.Name = "mainContent";
			this.mainContent.Size = new System.Drawing.Size(299, 356);
			this.mainContent.TabIndex = 2;
			// 
			// CaculatorTab
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.Control;
			this.ClientSize = new System.Drawing.Size(300, 439);
			this.Controls.Add(this.mainContent);
			this.Controls.Add(this.memoryPanel);
			this.Controls.Add(this.historyPanel);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "CaculatorTab";
			this.Text = "CaculatorTab";
			this.historyPanel.ResumeLayout(false);
			this.historyPanel.PerformLayout();
			this.memoryPanel.ResumeLayout(false);
			this.memoryPanel.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Panel historyPanel;
		private Guna.UI.WinForms.GunaLabel historyLabel;
		private System.Windows.Forms.Panel historyLine;
		private System.Windows.Forms.Panel memoryPanel;
		private System.Windows.Forms.Panel memoryLine;
		private Guna.UI.WinForms.GunaLabel memoryLabel;
		private System.Windows.Forms.Panel mainContent;
	}
}