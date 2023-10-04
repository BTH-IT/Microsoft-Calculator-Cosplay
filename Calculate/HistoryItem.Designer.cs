namespace Calculate
{
	partial class HistoryItem
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

		#region Component Designer generated code

		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HistoryItem));
			this.panel1 = new System.Windows.Forms.Panel();
			this.label1 = new System.Windows.Forms.Label();
			this.operation = new System.Windows.Forms.Label();
			this.gunaContextMenuStrip1 = new Guna.UI.WinForms.GunaContextMenuStrip();
			this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.timer1 = new System.Windows.Forms.Timer(this.components);
			this.panel1.SuspendLayout();
			this.gunaContextMenuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.AutoSize = true;
			this.panel1.BackColor = System.Drawing.Color.Transparent;
			this.panel1.Controls.Add(this.label1);
			this.panel1.Controls.Add(this.operation);
			this.panel1.Cursor = System.Windows.Forms.Cursors.Default;
			this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Padding = new System.Windows.Forms.Padding(0, 0, 10, 0);
			this.panel1.Size = new System.Drawing.Size(400, 102);
			this.panel1.TabIndex = 0;
			this.panel1.Click += new System.EventHandler(this.panel1_Click);
			this.panel1.MouseEnter += new System.EventHandler(this.panel1_MouseEnter);
			this.panel1.MouseLeave += new System.EventHandler(this.panel1_MouseLeave);
			this.panel1.MouseHover += new System.EventHandler(this.panel1_MouseHover);
			// 
			// label1
			// 
			this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(332, 62);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(55, 29);
			this.label1.TabIndex = 1;
			this.label1.Text = "132";
			// 
			// operation
			// 
			this.operation.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.operation.AutoEllipsis = true;
			this.operation.AutoSize = true;
			this.operation.BackColor = System.Drawing.Color.Transparent;
			this.operation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
			this.operation.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(139)))), ((int)(((byte)(139)))));
			this.operation.Location = new System.Drawing.Point(270, 26);
			this.operation.MaximumSize = new System.Drawing.Size(600, 0);
			this.operation.Name = "operation";
			this.operation.Size = new System.Drawing.Size(117, 25);
			this.operation.TabIndex = 0;
			this.operation.Text = "100 + 100 =";
			this.operation.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.operation.Resize += new System.EventHandler(this.operation_Resize);
			// 
			// gunaContextMenuStrip1
			// 
			this.gunaContextMenuStrip1.AutoSize = false;
			this.gunaContextMenuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
			this.gunaContextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.gunaContextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.deleteToolStripMenuItem});
			this.gunaContextMenuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow;
			this.gunaContextMenuStrip1.Name = "gunaContextMenuStrip1";
			this.gunaContextMenuStrip1.RenderStyle.ArrowColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.gunaContextMenuStrip1.RenderStyle.BorderColor = System.Drawing.Color.Gainsboro;
			this.gunaContextMenuStrip1.RenderStyle.ColorTable = null;
			this.gunaContextMenuStrip1.RenderStyle.RoundedEdges = true;
			this.gunaContextMenuStrip1.RenderStyle.SelectionArrowColor = System.Drawing.Color.White;
			this.gunaContextMenuStrip1.RenderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.gunaContextMenuStrip1.RenderStyle.SelectionForeColor = System.Drawing.Color.Black;
			this.gunaContextMenuStrip1.RenderStyle.SeparatorColor = System.Drawing.Color.Gainsboro;
			this.gunaContextMenuStrip1.RenderStyle.TextRenderingHint = Guna.UI.WinForms.DrawingTextRenderingHint.SystemDefault;
			this.gunaContextMenuStrip1.ShowItemToolTips = false;
			this.gunaContextMenuStrip1.Size = new System.Drawing.Size(110, 40);
			this.gunaContextMenuStrip1.Closing += new System.Windows.Forms.ToolStripDropDownClosingEventHandler(this.gunaContextMenuStrip1_Closing);
			// 
			// deleteToolStripMenuItem
			// 
			this.deleteToolStripMenuItem.AutoSize = false;
			this.deleteToolStripMenuItem.Font = new System.Drawing.Font("Calibri", 12F);
			this.deleteToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("deleteToolStripMenuItem.Image")));
			this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
			this.deleteToolStripMenuItem.Size = new System.Drawing.Size(110, 28);
			this.deleteToolStripMenuItem.Text = "Delete";
			this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
			// 
			// timer1
			// 
			this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
			// 
			// HistoryItem
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSize = true;
			this.BackColor = System.Drawing.Color.Transparent;
			this.ContextMenuStrip = this.gunaContextMenuStrip1;
			this.Controls.Add(this.panel1);
			this.Name = "HistoryItem";
			this.Size = new System.Drawing.Size(400, 102);
			this.Load += new System.EventHandler(this.HistoryItem_Load);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.gunaContextMenuStrip1.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Panel panel1;
		private Guna.UI.WinForms.GunaContextMenuStrip gunaContextMenuStrip1;
		private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
		private System.Windows.Forms.Label operation;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Timer timer1;
	}
}
