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
			this.panel1 = new System.Windows.Forms.Panel();
			this.label1 = new System.Windows.Forms.Label();
			this.operation = new System.Windows.Forms.Label();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.panel1.Controls.Add(this.label1);
			this.panel1.Controls.Add(this.operation);
			this.panel1.Cursor = System.Windows.Forms.Cursors.Default;
			this.panel1.Location = new System.Drawing.Point(136, 3);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(261, 91);
			this.panel1.TabIndex = 0;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(203, 51);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(55, 29);
			this.label1.TabIndex = 1;
			this.label1.Text = "132";
			// 
			// operation
			// 
			this.operation.AutoSize = true;
			this.operation.BackColor = System.Drawing.Color.Transparent;
			this.operation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
			this.operation.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(139)))), ((int)(((byte)(139)))));
			this.operation.Location = new System.Drawing.Point(158, 14);
			this.operation.Name = "operation";
			this.operation.Size = new System.Drawing.Size(100, 25);
			this.operation.TabIndex = 0;
			this.operation.Text = " 66 + 66 =";
			this.operation.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// HistoryItem
			// 
			this.AllowDrop = true;
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Transparent;
			this.Controls.Add(this.panel1);
			this.Name = "HistoryItem";
			this.Size = new System.Drawing.Size(400, 102);
			this.Click += new System.EventHandler(this.HistoryItem_Click);
			this.MouseLeave += new System.EventHandler(this.HistoryItem_MouseLeave);
			this.MouseHover += new System.EventHandler(this.HistoryItem_MouseHover);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label operation;
		private System.Windows.Forms.Label label1;
	}
}
