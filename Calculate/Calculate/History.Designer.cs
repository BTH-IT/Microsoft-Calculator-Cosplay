namespace Calculate
{
    partial class History
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
			this.gunaGradient2Panel1 = new Guna.UI.WinForms.GunaGradient2Panel();
			this.historyItemContainer = new System.Windows.Forms.FlowLayoutPanel();
			this.label1 = new System.Windows.Forms.Label();
			this.gunaGradient2Panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// gunaGradient2Panel1
			// 
			this.gunaGradient2Panel1.AutoSize = true;
			this.gunaGradient2Panel1.BackColor = System.Drawing.Color.Transparent;
			this.gunaGradient2Panel1.Controls.Add(this.historyItemContainer);
			this.gunaGradient2Panel1.Controls.Add(this.label1);
			this.gunaGradient2Panel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.gunaGradient2Panel1.GradientColor1 = System.Drawing.Color.White;
			this.gunaGradient2Panel1.GradientColor2 = System.Drawing.Color.White;
			this.gunaGradient2Panel1.Location = new System.Drawing.Point(0, 0);
			this.gunaGradient2Panel1.Name = "gunaGradient2Panel1";
			this.gunaGradient2Panel1.Radius = 20;
			this.gunaGradient2Panel1.Size = new System.Drawing.Size(413, 351);
			this.gunaGradient2Panel1.TabIndex = 0;
			// 
			// historyItemContainer
			// 
			this.historyItemContainer.AutoScroll = true;
			this.historyItemContainer.AutoSize = true;
			this.historyItemContainer.BackColor = System.Drawing.Color.Transparent;
			this.historyItemContainer.Dock = System.Windows.Forms.DockStyle.Fill;
			this.historyItemContainer.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
			this.historyItemContainer.Location = new System.Drawing.Point(0, 0);
			this.historyItemContainer.Name = "historyItemContainer";
			this.historyItemContainer.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.historyItemContainer.Size = new System.Drawing.Size(413, 351);
			this.historyItemContainer.TabIndex = 1;
			this.historyItemContainer.WrapContents = false;
			this.historyItemContainer.SizeChanged += new System.EventHandler(this.historyItemContainer_SizeChanged_1);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(13, 21);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(211, 28);
			this.label1.TabIndex = 0;
			this.label1.Text = "There\'s no history yet";
			// 
			// History
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Transparent;
			this.Controls.Add(this.gunaGradient2Panel1);
			this.Name = "History";
			this.Size = new System.Drawing.Size(413, 351);
			this.gunaGradient2Panel1.ResumeLayout(false);
			this.gunaGradient2Panel1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaGradient2Panel gunaGradient2Panel1;
        private System.Windows.Forms.Label label1;
		private System.Windows.Forms.FlowLayoutPanel historyItemContainer;
	}
}
