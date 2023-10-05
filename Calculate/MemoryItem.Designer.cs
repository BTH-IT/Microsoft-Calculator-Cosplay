namespace Calculate
{
    partial class MemoryItem
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.mMinusBtn = new Guna.UI.WinForms.GunaAdvenceButton();
            this.mPlusBtn = new Guna.UI.WinForms.GunaAdvenceButton();
            this.mcBtn = new Guna.UI.WinForms.GunaAdvenceButton();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.mMinusBtn);
            this.panel1.Controls.Add(this.mPlusBtn);
            this.panel1.Controls.Add(this.mcBtn);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Cursor = System.Windows.Forms.Cursors.Default;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(400, 102);
            this.panel1.TabIndex = 1;
            this.panel1.Click += new System.EventHandler(this.panel1_Click);
            this.panel1.MouseEnter += new System.EventHandler(this.mcBtn_MouseEnter);
            this.panel1.MouseLeave += new System.EventHandler(this.mcBtn_MouseLeave);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MemoryItem_MouseMove);
            // 
            // mMinusBtn
            // 
            this.mMinusBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.mMinusBtn.AnimationHoverSpeed = 0.07F;
            this.mMinusBtn.AnimationSpeed = 0.03F;
            this.mMinusBtn.BackColor = System.Drawing.Color.Transparent;
            this.mMinusBtn.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.mMinusBtn.BorderColor = System.Drawing.Color.Gainsboro;
            this.mMinusBtn.BorderSize = 1;
            this.mMinusBtn.CheckedBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.mMinusBtn.CheckedBorderColor = System.Drawing.Color.Gainsboro;
            this.mMinusBtn.CheckedForeColor = System.Drawing.Color.Black;
            this.mMinusBtn.CheckedImage = null;
            this.mMinusBtn.CheckedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.mMinusBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.mMinusBtn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.mMinusBtn.FocusedColor = System.Drawing.Color.Empty;
            this.mMinusBtn.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mMinusBtn.ForeColor = System.Drawing.Color.Black;
            this.mMinusBtn.Image = null;
            this.mMinusBtn.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.mMinusBtn.ImageSize = new System.Drawing.Size(20, 20);
            this.mMinusBtn.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.mMinusBtn.Location = new System.Drawing.Point(336, 66);
            this.mMinusBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.mMinusBtn.Name = "mMinusBtn";
            this.mMinusBtn.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.mMinusBtn.OnHoverBorderColor = System.Drawing.Color.Gainsboro;
            this.mMinusBtn.OnHoverForeColor = System.Drawing.Color.Black;
            this.mMinusBtn.OnHoverImage = null;
            this.mMinusBtn.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.mMinusBtn.OnPressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(234)))), ((int)(((byte)(234)))));
            this.mMinusBtn.OnPressedDepth = 0;
            this.mMinusBtn.Radius = 4;
            this.mMinusBtn.Size = new System.Drawing.Size(60, 31);
            this.mMinusBtn.TabIndex = 17;
            this.mMinusBtn.Text = "M-";
            this.mMinusBtn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.mMinusBtn.Click += new System.EventHandler(this.mMinusBtn_Click);
            this.mMinusBtn.MouseEnter += new System.EventHandler(this.mcBtn_MouseEnter);
            this.mMinusBtn.MouseLeave += new System.EventHandler(this.mcBtn_MouseLeave);
            // 
            // mPlusBtn
            // 
            this.mPlusBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.mPlusBtn.AnimationHoverSpeed = 0.07F;
            this.mPlusBtn.AnimationSpeed = 0.03F;
            this.mPlusBtn.BackColor = System.Drawing.Color.Transparent;
            this.mPlusBtn.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.mPlusBtn.BorderColor = System.Drawing.Color.Gainsboro;
            this.mPlusBtn.BorderSize = 1;
            this.mPlusBtn.CheckedBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.mPlusBtn.CheckedBorderColor = System.Drawing.Color.Gainsboro;
            this.mPlusBtn.CheckedForeColor = System.Drawing.Color.Black;
            this.mPlusBtn.CheckedImage = null;
            this.mPlusBtn.CheckedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.mPlusBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.mPlusBtn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.mPlusBtn.FocusedColor = System.Drawing.Color.Empty;
            this.mPlusBtn.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mPlusBtn.ForeColor = System.Drawing.Color.Black;
            this.mPlusBtn.Image = null;
            this.mPlusBtn.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.mPlusBtn.ImageSize = new System.Drawing.Size(20, 20);
            this.mPlusBtn.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.mPlusBtn.Location = new System.Drawing.Point(268, 66);
            this.mPlusBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.mPlusBtn.Name = "mPlusBtn";
            this.mPlusBtn.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.mPlusBtn.OnHoverBorderColor = System.Drawing.Color.Gainsboro;
            this.mPlusBtn.OnHoverForeColor = System.Drawing.Color.Black;
            this.mPlusBtn.OnHoverImage = null;
            this.mPlusBtn.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.mPlusBtn.OnPressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(234)))), ((int)(((byte)(234)))));
            this.mPlusBtn.OnPressedDepth = 0;
            this.mPlusBtn.Radius = 4;
            this.mPlusBtn.Size = new System.Drawing.Size(60, 31);
            this.mPlusBtn.TabIndex = 16;
            this.mPlusBtn.Text = "M+";
            this.mPlusBtn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.mPlusBtn.Click += new System.EventHandler(this.mPlusBtn_Click);
            this.mPlusBtn.MouseEnter += new System.EventHandler(this.mcBtn_MouseEnter);
            this.mPlusBtn.MouseLeave += new System.EventHandler(this.mcBtn_MouseLeave);
            // 
            // mcBtn
            // 
            this.mcBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.mcBtn.AnimationHoverSpeed = 0.07F;
            this.mcBtn.AnimationSpeed = 0.03F;
            this.mcBtn.BackColor = System.Drawing.Color.Transparent;
            this.mcBtn.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.mcBtn.BorderColor = System.Drawing.Color.Gainsboro;
            this.mcBtn.BorderSize = 1;
            this.mcBtn.CheckedBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.mcBtn.CheckedBorderColor = System.Drawing.Color.Gainsboro;
            this.mcBtn.CheckedForeColor = System.Drawing.Color.Black;
            this.mcBtn.CheckedImage = null;
            this.mcBtn.CheckedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.mcBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.mcBtn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.mcBtn.FocusedColor = System.Drawing.Color.Empty;
            this.mcBtn.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mcBtn.ForeColor = System.Drawing.Color.Black;
            this.mcBtn.Image = null;
            this.mcBtn.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.mcBtn.ImageSize = new System.Drawing.Size(20, 20);
            this.mcBtn.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.mcBtn.Location = new System.Drawing.Point(200, 66);
            this.mcBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.mcBtn.Name = "mcBtn";
            this.mcBtn.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.mcBtn.OnHoverBorderColor = System.Drawing.Color.Gainsboro;
            this.mcBtn.OnHoverForeColor = System.Drawing.Color.Black;
            this.mcBtn.OnHoverImage = null;
            this.mcBtn.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.mcBtn.OnPressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(234)))), ((int)(((byte)(234)))));
            this.mcBtn.OnPressedDepth = 0;
            this.mcBtn.Radius = 4;
            this.mcBtn.Size = new System.Drawing.Size(60, 31);
            this.mcBtn.TabIndex = 15;
            this.mcBtn.Text = "MC";
            this.mcBtn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.mcBtn.MouseEnter += new System.EventHandler(this.mcBtn_MouseEnter);
            this.mcBtn.MouseLeave += new System.EventHandler(this.mcBtn_MouseLeave);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(357, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "132";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label1.MouseEnter += new System.EventHandler(this.mcBtn_MouseEnter);
            this.label1.MouseLeave += new System.EventHandler(this.mcBtn_MouseLeave);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // MemoryItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "MemoryItem";
            this.Size = new System.Drawing.Size(400, 102);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MemoryItem_MouseMove);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Label label1;
        public Guna.UI.WinForms.GunaAdvenceButton mMinusBtn;
        public Guna.UI.WinForms.GunaAdvenceButton mPlusBtn;
        public Guna.UI.WinForms.GunaAdvenceButton mcBtn;
        private System.Windows.Forms.Timer timer1;
    }
}
