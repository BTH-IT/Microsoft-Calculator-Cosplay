namespace Calculate
{
    partial class SidebarItem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SidebarItem));
            this.button = new Guna.UI.WinForms.GunaAdvenceButton();
            this.active = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.active)).BeginInit();
            this.SuspendLayout();
            // 
            // button
            // 
            this.button.AnimationHoverSpeed = 0.07F;
            this.button.AnimationSpeed = 0.03F;
            this.button.BackColor = System.Drawing.Color.Transparent;
            this.button.BaseColor = System.Drawing.Color.Transparent;
            this.button.BorderColor = System.Drawing.Color.Black;
            this.button.CheckedBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.button.CheckedBorderColor = System.Drawing.Color.Black;
            this.button.CheckedForeColor = System.Drawing.Color.Black;
            this.button.CheckedImage = ((System.Drawing.Image)(resources.GetObject("button.CheckedImage")));
            this.button.CheckedLineColor = System.Drawing.Color.DimGray;
            this.button.DialogResult = System.Windows.Forms.DialogResult.None;
            this.button.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button.FocusedColor = System.Drawing.Color.Empty;
            this.button.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button.ForeColor = System.Drawing.Color.Black;
            this.button.Image = ((System.Drawing.Image)(resources.GetObject("button.Image")));
            this.button.ImageOffsetX = 10;
            this.button.ImageSize = new System.Drawing.Size(20, 20);
            this.button.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.button.Location = new System.Drawing.Point(0, 0);
            this.button.Name = "button";
            this.button.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.button.OnHoverBorderColor = System.Drawing.Color.Black;
            this.button.OnHoverForeColor = System.Drawing.Color.Black;
            this.button.OnHoverImage = null;
            this.button.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.button.OnPressedColor = System.Drawing.Color.Transparent;
            this.button.OnPressedDepth = 0;
            this.button.Radius = 6;
            this.button.Size = new System.Drawing.Size(283, 50);
            this.button.TabIndex = 3;
            this.button.Text = "Standard";
            // 
            // active
            // 
            this.active.Image = ((System.Drawing.Image)(resources.GetObject("active.Image")));
            this.active.Location = new System.Drawing.Point(3, 12);
            this.active.Name = "active";
            this.active.Size = new System.Drawing.Size(7, 25);
            this.active.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.active.TabIndex = 4;
            this.active.TabStop = false;
            // 
            // SidebarItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.active);
            this.Controls.Add(this.button);
            this.Name = "SidebarItem";
            this.Size = new System.Drawing.Size(283, 50);
            ((System.ComponentModel.ISupportInitialize)(this.active)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaAdvenceButton button;
        private System.Windows.Forms.PictureBox active;
    }
}
