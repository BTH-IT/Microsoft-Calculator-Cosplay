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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(History));
            this.historyItemContainer = new Guna.UI.WinForms.GunaGradient2Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.clearBtn = new Guna.UI.WinForms.GunaAdvenceButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.historyItemContainer.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // historyItemContainer
            // 
            this.historyItemContainer.BackColor = System.Drawing.Color.Transparent;
            this.historyItemContainer.Controls.Add(this.panel3);
            this.historyItemContainer.Controls.Add(this.panel2);
            this.historyItemContainer.Controls.Add(this.panel1);
            this.historyItemContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.historyItemContainer.GradientColor1 = System.Drawing.Color.White;
            this.historyItemContainer.GradientColor2 = System.Drawing.Color.White;
            this.historyItemContainer.Location = new System.Drawing.Point(0, 0);
            this.historyItemContainer.Name = "historyItemContainer";
            this.historyItemContainer.Radius = 20;
            this.historyItemContainer.Size = new System.Drawing.Size(413, 351);
            this.historyItemContainer.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.AutoScroll = true;
            this.panel3.Controls.Add(this.label1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 25);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(413, 284);
            this.panel3.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(413, 34);
            this.label1.TabIndex = 1;
            this.label1.Text = "There\'s no history yet";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.clearBtn);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 309);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(413, 42);
            this.panel2.TabIndex = 2;
            // 
            // clearBtn
            // 
            this.clearBtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.clearBtn.AnimationHoverSpeed = 0.07F;
            this.clearBtn.AnimationSpeed = 0.03F;
            this.clearBtn.BackColor = System.Drawing.Color.Transparent;
            this.clearBtn.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.clearBtn.BorderColor = System.Drawing.Color.Black;
            this.clearBtn.CheckedBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(234)))), ((int)(((byte)(234)))));
            this.clearBtn.CheckedBorderColor = System.Drawing.Color.Black;
            this.clearBtn.CheckedForeColor = System.Drawing.Color.White;
            this.clearBtn.CheckedImage = ((System.Drawing.Image)(resources.GetObject("clearBtn.CheckedImage")));
            this.clearBtn.CheckedLineColor = System.Drawing.Color.DimGray;
            this.clearBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.clearBtn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.clearBtn.FocusedColor = System.Drawing.Color.Empty;
            this.clearBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.clearBtn.ForeColor = System.Drawing.Color.White;
            this.clearBtn.Image = ((System.Drawing.Image)(resources.GetObject("clearBtn.Image")));
            this.clearBtn.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.clearBtn.ImageSize = new System.Drawing.Size(20, 20);
            this.clearBtn.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.clearBtn.Location = new System.Drawing.Point(304, 2);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(234)))), ((int)(((byte)(234)))));
            this.clearBtn.OnHoverBorderColor = System.Drawing.Color.Black;
            this.clearBtn.OnHoverForeColor = System.Drawing.Color.White;
            this.clearBtn.OnHoverImage = null;
            this.clearBtn.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.clearBtn.OnPressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(234)))), ((int)(((byte)(234)))));
            this.clearBtn.OnPressedDepth = 0;
            this.clearBtn.Radius = 4;
            this.clearBtn.Size = new System.Drawing.Size(73, 40);
            this.clearBtn.TabIndex = 14;
            this.clearBtn.Click += new System.EventHandler(this.clearBtn_Click);
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(413, 25);
            this.panel1.TabIndex = 1;
            // 
            // History
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.historyItemContainer);
            this.Name = "History";
            this.Size = new System.Drawing.Size(413, 351);
            this.Load += new System.EventHandler(this.History_Load);
            this.historyItemContainer.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaGradient2Panel historyItemContainer;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private Guna.UI.WinForms.GunaAdvenceButton clearBtn;
    }
}
