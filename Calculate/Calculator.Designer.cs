namespace Calculate
{
    partial class Calculator
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Calculator));
            this.sidebarTransition = new System.Windows.Forms.Timer(this.components);
            this.test = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.zeroBtn = new Guna.UI.WinForms.GunaAdvenceButton();
            this.plusOrMinusBtn = new Guna.UI.WinForms.GunaAdvenceButton();
            this.equalBtn = new Guna.UI.WinForms.GunaAdvenceButton();
            this.dotBtn = new Guna.UI.WinForms.GunaAdvenceButton();
            this.twoBtn = new Guna.UI.WinForms.GunaAdvenceButton();
            this.oneBtn = new Guna.UI.WinForms.GunaAdvenceButton();
            this.plusBtn = new Guna.UI.WinForms.GunaAdvenceButton();
            this.threeBtn = new Guna.UI.WinForms.GunaAdvenceButton();
            this.fiveBtn = new Guna.UI.WinForms.GunaAdvenceButton();
            this.fourBtn = new Guna.UI.WinForms.GunaAdvenceButton();
            this.minusBtn = new Guna.UI.WinForms.GunaAdvenceButton();
            this.sixBtn = new Guna.UI.WinForms.GunaAdvenceButton();
            this.eightBtn = new Guna.UI.WinForms.GunaAdvenceButton();
            this.sevenBtn = new Guna.UI.WinForms.GunaAdvenceButton();
            this.multiBtn = new Guna.UI.WinForms.GunaAdvenceButton();
            this.nineBtn = new Guna.UI.WinForms.GunaAdvenceButton();
            this.x2Btn = new Guna.UI.WinForms.GunaAdvenceButton();
            this.oneXBtn = new Guna.UI.WinForms.GunaAdvenceButton();
            this.divisionBtn = new Guna.UI.WinForms.GunaAdvenceButton();
            this.sqrtBtn = new Guna.UI.WinForms.GunaAdvenceButton();
            this.clearInputBtn = new Guna.UI.WinForms.GunaAdvenceButton();
            this.percentBtn = new Guna.UI.WinForms.GunaAdvenceButton();
            this.backspaceBtn = new Guna.UI.WinForms.GunaAdvenceButton();
            this.clearBtn = new Guna.UI.WinForms.GunaAdvenceButton();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.openMemoryBtn = new Guna.UI.WinForms.GunaAdvenceButton();
            this.msBtn = new Guna.UI.WinForms.GunaAdvenceButton();
            this.mMinusBtn = new Guna.UI.WinForms.GunaAdvenceButton();
            this.mPlusBtn = new Guna.UI.WinForms.GunaAdvenceButton();
            this.mrBtn = new Guna.UI.WinForms.GunaAdvenceButton();
            this.mcBtn = new Guna.UI.WinForms.GunaAdvenceButton();
            this.input = new Guna.UI2.WinForms.Guna2TextBox();
            this.displayCalculate = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.menuIcon = new Guna.UI.WinForms.GunaAdvenceButton();
            this.gunaAdvenceButton1 = new Guna.UI.WinForms.GunaAdvenceButton();
            this.titleHeader = new System.Windows.Forms.Label();
            this.historyIcon = new Guna.UI.WinForms.GunaAdvenceButton();
            this.leftPanel = new System.Windows.Forms.Panel();
            this.sidebarChild = new Guna.UI.WinForms.GunaShadowPanel();
            this.gunaAdvenceButton2 = new Guna.UI.WinForms.GunaAdvenceButton();
            this.sidebarItem1 = new Calculate.SidebarItem();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.memoryCheck = new System.Windows.Forms.Timer(this.components);
            this.test.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.sidebarChild.SuspendLayout();
            this.SuspendLayout();
            // 
            // sidebarTransition
            // 
            this.sidebarTransition.Interval = 10;
            this.sidebarTransition.Tick += new System.EventHandler(this.sidebarTransition_Tick);
            // 
            // test
            // 
            this.test.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.test.Controls.Add(this.tableLayoutPanel1);
            this.test.Controls.Add(this.tableLayoutPanel2);
            this.test.Controls.Add(this.input);
            this.test.Controls.Add(this.displayCalculate);
            this.test.Dock = System.Windows.Forms.DockStyle.Fill;
            this.test.Location = new System.Drawing.Point(0, 55);
            this.test.Name = "test";
            this.test.Size = new System.Drawing.Size(362, 484);
            this.test.TabIndex = 11;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.zeroBtn, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.plusOrMinusBtn, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.equalBtn, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.dotBtn, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.twoBtn, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.oneBtn, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.plusBtn, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.threeBtn, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.fiveBtn, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.fourBtn, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.minusBtn, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.sixBtn, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.eightBtn, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.sevenBtn, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.multiBtn, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.nineBtn, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.x2Btn, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.oneXBtn, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.divisionBtn, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.sqrtBtn, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.clearInputBtn, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.percentBtn, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.backspaceBtn, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.clearBtn, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 138);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(362, 346);
            this.tableLayoutPanel1.TabIndex = 9;
            // 
            // zeroBtn
            // 
            this.zeroBtn.AnimationHoverSpeed = 0.07F;
            this.zeroBtn.AnimationSpeed = 0.03F;
            this.zeroBtn.BackColor = System.Drawing.Color.Transparent;
            this.zeroBtn.BaseColor = System.Drawing.Color.White;
            this.zeroBtn.BorderColor = System.Drawing.Color.Gainsboro;
            this.zeroBtn.BorderSize = 1;
            this.zeroBtn.CheckedBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(234)))), ((int)(((byte)(234)))));
            this.zeroBtn.CheckedBorderColor = System.Drawing.Color.Black;
            this.zeroBtn.CheckedForeColor = System.Drawing.Color.White;
            this.zeroBtn.CheckedImage = ((System.Drawing.Image)(resources.GetObject("zeroBtn.CheckedImage")));
            this.zeroBtn.CheckedLineColor = System.Drawing.Color.DimGray;
            this.zeroBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.zeroBtn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.zeroBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.zeroBtn.FocusedColor = System.Drawing.Color.Empty;
            this.zeroBtn.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.zeroBtn.ForeColor = System.Drawing.Color.Black;
            this.zeroBtn.Image = null;
            this.zeroBtn.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.zeroBtn.ImageSize = new System.Drawing.Size(20, 20);
            this.zeroBtn.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.zeroBtn.Location = new System.Drawing.Point(93, 288);
            this.zeroBtn.Name = "zeroBtn";
            this.zeroBtn.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.zeroBtn.OnHoverBorderColor = System.Drawing.Color.Gainsboro;
            this.zeroBtn.OnHoverForeColor = System.Drawing.Color.Black;
            this.zeroBtn.OnHoverImage = null;
            this.zeroBtn.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.zeroBtn.OnPressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.zeroBtn.OnPressedDepth = 0;
            this.zeroBtn.Radius = 6;
            this.zeroBtn.Size = new System.Drawing.Size(84, 55);
            this.zeroBtn.TabIndex = 37;
            this.zeroBtn.Text = "0";
            this.zeroBtn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.zeroBtn.Click += new System.EventHandler(this.numbers_Only);
            // 
            // plusOrMinusBtn
            // 
            this.plusOrMinusBtn.AnimationHoverSpeed = 0.07F;
            this.plusOrMinusBtn.AnimationSpeed = 0.03F;
            this.plusOrMinusBtn.BackColor = System.Drawing.Color.Transparent;
            this.plusOrMinusBtn.BaseColor = System.Drawing.Color.White;
            this.plusOrMinusBtn.BorderColor = System.Drawing.Color.Gainsboro;
            this.plusOrMinusBtn.BorderSize = 1;
            this.plusOrMinusBtn.CheckedBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.plusOrMinusBtn.CheckedBorderColor = System.Drawing.Color.Gainsboro;
            this.plusOrMinusBtn.CheckedForeColor = System.Drawing.Color.Black;
            this.plusOrMinusBtn.CheckedImage = ((System.Drawing.Image)(resources.GetObject("plusOrMinusBtn.CheckedImage")));
            this.plusOrMinusBtn.CheckedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.plusOrMinusBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.plusOrMinusBtn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.plusOrMinusBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.plusOrMinusBtn.FocusedColor = System.Drawing.Color.Empty;
            this.plusOrMinusBtn.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.plusOrMinusBtn.ForeColor = System.Drawing.Color.Black;
            this.plusOrMinusBtn.Image = ((System.Drawing.Image)(resources.GetObject("plusOrMinusBtn.Image")));
            this.plusOrMinusBtn.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.plusOrMinusBtn.ImageSize = new System.Drawing.Size(50, 50);
            this.plusOrMinusBtn.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.plusOrMinusBtn.Location = new System.Drawing.Point(3, 288);
            this.plusOrMinusBtn.Name = "plusOrMinusBtn";
            this.plusOrMinusBtn.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.plusOrMinusBtn.OnHoverBorderColor = System.Drawing.Color.Gainsboro;
            this.plusOrMinusBtn.OnHoverForeColor = System.Drawing.Color.Black;
            this.plusOrMinusBtn.OnHoverImage = null;
            this.plusOrMinusBtn.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.plusOrMinusBtn.OnPressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.plusOrMinusBtn.OnPressedDepth = 0;
            this.plusOrMinusBtn.Radius = 6;
            this.plusOrMinusBtn.Size = new System.Drawing.Size(84, 55);
            this.plusOrMinusBtn.TabIndex = 36;
            this.plusOrMinusBtn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.plusOrMinusBtn.Click += new System.EventHandler(this.numbers_Only);
            // 
            // equalBtn
            // 
            this.equalBtn.AnimationHoverSpeed = 0.07F;
            this.equalBtn.AnimationSpeed = 0.03F;
            this.equalBtn.BackColor = System.Drawing.Color.Transparent;
            this.equalBtn.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(90)))), ((int)(((byte)(158)))));
            this.equalBtn.BorderColor = System.Drawing.Color.Black;
            this.equalBtn.CheckedBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(234)))), ((int)(((byte)(234)))));
            this.equalBtn.CheckedBorderColor = System.Drawing.Color.Black;
            this.equalBtn.CheckedForeColor = System.Drawing.Color.White;
            this.equalBtn.CheckedImage = ((System.Drawing.Image)(resources.GetObject("equalBtn.CheckedImage")));
            this.equalBtn.CheckedLineColor = System.Drawing.Color.DimGray;
            this.equalBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.equalBtn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.equalBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.equalBtn.FocusedColor = System.Drawing.Color.Empty;
            this.equalBtn.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.equalBtn.ForeColor = System.Drawing.Color.White;
            this.equalBtn.Image = ((System.Drawing.Image)(resources.GetObject("equalBtn.Image")));
            this.equalBtn.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.equalBtn.ImageSize = new System.Drawing.Size(15, 15);
            this.equalBtn.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.equalBtn.Location = new System.Drawing.Point(273, 288);
            this.equalBtn.Name = "equalBtn";
            this.equalBtn.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(106)))), ((int)(((byte)(167)))));
            this.equalBtn.OnHoverBorderColor = System.Drawing.Color.Black;
            this.equalBtn.OnHoverForeColor = System.Drawing.Color.White;
            this.equalBtn.OnHoverImage = null;
            this.equalBtn.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.equalBtn.OnPressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(106)))), ((int)(((byte)(167)))));
            this.equalBtn.OnPressedDepth = 0;
            this.equalBtn.Radius = 6;
            this.equalBtn.Size = new System.Drawing.Size(86, 55);
            this.equalBtn.TabIndex = 35;
            this.equalBtn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.equalBtn.Click += new System.EventHandler(this.equalBtn_Click);
            // 
            // dotBtn
            // 
            this.dotBtn.AnimationHoverSpeed = 0.07F;
            this.dotBtn.AnimationSpeed = 0.03F;
            this.dotBtn.BackColor = System.Drawing.Color.Transparent;
            this.dotBtn.BaseColor = System.Drawing.Color.White;
            this.dotBtn.BorderColor = System.Drawing.Color.Gainsboro;
            this.dotBtn.BorderSize = 1;
            this.dotBtn.CheckedBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.dotBtn.CheckedBorderColor = System.Drawing.Color.Gainsboro;
            this.dotBtn.CheckedForeColor = System.Drawing.Color.Black;
            this.dotBtn.CheckedImage = null;
            this.dotBtn.CheckedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.dotBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dotBtn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.dotBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dotBtn.FocusedColor = System.Drawing.Color.Empty;
            this.dotBtn.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dotBtn.ForeColor = System.Drawing.Color.Black;
            this.dotBtn.Image = null;
            this.dotBtn.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.dotBtn.ImageSize = new System.Drawing.Size(20, 20);
            this.dotBtn.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.dotBtn.Location = new System.Drawing.Point(183, 288);
            this.dotBtn.Name = "dotBtn";
            this.dotBtn.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.dotBtn.OnHoverBorderColor = System.Drawing.Color.Gainsboro;
            this.dotBtn.OnHoverForeColor = System.Drawing.Color.Black;
            this.dotBtn.OnHoverImage = null;
            this.dotBtn.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.dotBtn.OnPressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.dotBtn.OnPressedDepth = 0;
            this.dotBtn.Radius = 6;
            this.dotBtn.Size = new System.Drawing.Size(84, 55);
            this.dotBtn.TabIndex = 34;
            this.dotBtn.Text = ".";
            this.dotBtn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.dotBtn.Click += new System.EventHandler(this.numbers_Only);
            // 
            // twoBtn
            // 
            this.twoBtn.AnimationHoverSpeed = 0.07F;
            this.twoBtn.AnimationSpeed = 0.03F;
            this.twoBtn.BackColor = System.Drawing.Color.Transparent;
            this.twoBtn.BaseColor = System.Drawing.Color.White;
            this.twoBtn.BorderColor = System.Drawing.Color.Gainsboro;
            this.twoBtn.BorderSize = 1;
            this.twoBtn.CheckedBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(234)))), ((int)(((byte)(234)))));
            this.twoBtn.CheckedBorderColor = System.Drawing.Color.Black;
            this.twoBtn.CheckedForeColor = System.Drawing.Color.White;
            this.twoBtn.CheckedImage = ((System.Drawing.Image)(resources.GetObject("twoBtn.CheckedImage")));
            this.twoBtn.CheckedLineColor = System.Drawing.Color.DimGray;
            this.twoBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.twoBtn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.twoBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.twoBtn.FocusedColor = System.Drawing.Color.Empty;
            this.twoBtn.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.twoBtn.ForeColor = System.Drawing.Color.Black;
            this.twoBtn.Image = null;
            this.twoBtn.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.twoBtn.ImageSize = new System.Drawing.Size(20, 20);
            this.twoBtn.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.twoBtn.Location = new System.Drawing.Point(93, 231);
            this.twoBtn.Name = "twoBtn";
            this.twoBtn.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.twoBtn.OnHoverBorderColor = System.Drawing.Color.Gainsboro;
            this.twoBtn.OnHoverForeColor = System.Drawing.Color.Black;
            this.twoBtn.OnHoverImage = null;
            this.twoBtn.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.twoBtn.OnPressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.twoBtn.OnPressedDepth = 0;
            this.twoBtn.Radius = 6;
            this.twoBtn.Size = new System.Drawing.Size(84, 51);
            this.twoBtn.TabIndex = 33;
            this.twoBtn.Text = "2";
            this.twoBtn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.twoBtn.Click += new System.EventHandler(this.numbers_Only);
            // 
            // oneBtn
            // 
            this.oneBtn.AnimationHoverSpeed = 0.07F;
            this.oneBtn.AnimationSpeed = 0.03F;
            this.oneBtn.BackColor = System.Drawing.Color.Transparent;
            this.oneBtn.BaseColor = System.Drawing.Color.White;
            this.oneBtn.BorderColor = System.Drawing.Color.Gainsboro;
            this.oneBtn.BorderSize = 1;
            this.oneBtn.CheckedBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(234)))), ((int)(((byte)(234)))));
            this.oneBtn.CheckedBorderColor = System.Drawing.Color.Black;
            this.oneBtn.CheckedForeColor = System.Drawing.Color.White;
            this.oneBtn.CheckedImage = ((System.Drawing.Image)(resources.GetObject("oneBtn.CheckedImage")));
            this.oneBtn.CheckedLineColor = System.Drawing.Color.DimGray;
            this.oneBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.oneBtn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.oneBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.oneBtn.FocusedColor = System.Drawing.Color.Empty;
            this.oneBtn.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.oneBtn.ForeColor = System.Drawing.Color.Black;
            this.oneBtn.Image = null;
            this.oneBtn.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.oneBtn.ImageSize = new System.Drawing.Size(20, 20);
            this.oneBtn.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.oneBtn.Location = new System.Drawing.Point(3, 231);
            this.oneBtn.Name = "oneBtn";
            this.oneBtn.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.oneBtn.OnHoverBorderColor = System.Drawing.Color.Gainsboro;
            this.oneBtn.OnHoverForeColor = System.Drawing.Color.Black;
            this.oneBtn.OnHoverImage = null;
            this.oneBtn.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.oneBtn.OnPressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.oneBtn.OnPressedDepth = 0;
            this.oneBtn.Radius = 6;
            this.oneBtn.Size = new System.Drawing.Size(84, 51);
            this.oneBtn.TabIndex = 32;
            this.oneBtn.Text = "1";
            this.oneBtn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.oneBtn.Click += new System.EventHandler(this.numbers_Only);
            // 
            // plusBtn
            // 
            this.plusBtn.AnimationHoverSpeed = 0.07F;
            this.plusBtn.AnimationSpeed = 0.03F;
            this.plusBtn.BackColor = System.Drawing.Color.Transparent;
            this.plusBtn.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.plusBtn.BorderColor = System.Drawing.Color.Gainsboro;
            this.plusBtn.BorderSize = 1;
            this.plusBtn.CheckedBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.plusBtn.CheckedBorderColor = System.Drawing.Color.Gainsboro;
            this.plusBtn.CheckedForeColor = System.Drawing.Color.Black;
            this.plusBtn.CheckedImage = ((System.Drawing.Image)(resources.GetObject("plusBtn.CheckedImage")));
            this.plusBtn.CheckedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.plusBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.plusBtn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.plusBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.plusBtn.FocusedColor = System.Drawing.Color.Empty;
            this.plusBtn.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.plusBtn.ForeColor = System.Drawing.Color.Black;
            this.plusBtn.Image = ((System.Drawing.Image)(resources.GetObject("plusBtn.Image")));
            this.plusBtn.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.plusBtn.ImageSize = new System.Drawing.Size(30, 20);
            this.plusBtn.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.plusBtn.Location = new System.Drawing.Point(273, 231);
            this.plusBtn.Name = "plusBtn";
            this.plusBtn.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.plusBtn.OnHoverBorderColor = System.Drawing.Color.Gainsboro;
            this.plusBtn.OnHoverForeColor = System.Drawing.Color.Black;
            this.plusBtn.OnHoverImage = null;
            this.plusBtn.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.plusBtn.OnPressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.plusBtn.OnPressedDepth = 0;
            this.plusBtn.Radius = 6;
            this.plusBtn.Size = new System.Drawing.Size(86, 51);
            this.plusBtn.TabIndex = 31;
            this.plusBtn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.plusBtn.Click += new System.EventHandler(this.operators_Click);
            // 
            // threeBtn
            // 
            this.threeBtn.AnimationHoverSpeed = 0.07F;
            this.threeBtn.AnimationSpeed = 0.03F;
            this.threeBtn.BackColor = System.Drawing.Color.Transparent;
            this.threeBtn.BaseColor = System.Drawing.Color.White;
            this.threeBtn.BorderColor = System.Drawing.Color.Gainsboro;
            this.threeBtn.BorderSize = 1;
            this.threeBtn.CheckedBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(234)))), ((int)(((byte)(234)))));
            this.threeBtn.CheckedBorderColor = System.Drawing.Color.Black;
            this.threeBtn.CheckedForeColor = System.Drawing.Color.White;
            this.threeBtn.CheckedImage = ((System.Drawing.Image)(resources.GetObject("threeBtn.CheckedImage")));
            this.threeBtn.CheckedLineColor = System.Drawing.Color.DimGray;
            this.threeBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.threeBtn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.threeBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.threeBtn.FocusedColor = System.Drawing.Color.Empty;
            this.threeBtn.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.threeBtn.ForeColor = System.Drawing.Color.Black;
            this.threeBtn.Image = null;
            this.threeBtn.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.threeBtn.ImageSize = new System.Drawing.Size(20, 20);
            this.threeBtn.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.threeBtn.Location = new System.Drawing.Point(183, 231);
            this.threeBtn.Name = "threeBtn";
            this.threeBtn.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.threeBtn.OnHoverBorderColor = System.Drawing.Color.Gainsboro;
            this.threeBtn.OnHoverForeColor = System.Drawing.Color.Black;
            this.threeBtn.OnHoverImage = null;
            this.threeBtn.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.threeBtn.OnPressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.threeBtn.OnPressedDepth = 0;
            this.threeBtn.Radius = 6;
            this.threeBtn.Size = new System.Drawing.Size(84, 51);
            this.threeBtn.TabIndex = 30;
            this.threeBtn.Text = "3";
            this.threeBtn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.threeBtn.Click += new System.EventHandler(this.numbers_Only);
            // 
            // fiveBtn
            // 
            this.fiveBtn.AnimationHoverSpeed = 0.07F;
            this.fiveBtn.AnimationSpeed = 0.03F;
            this.fiveBtn.BackColor = System.Drawing.Color.Transparent;
            this.fiveBtn.BaseColor = System.Drawing.Color.White;
            this.fiveBtn.BorderColor = System.Drawing.Color.Gainsboro;
            this.fiveBtn.BorderSize = 1;
            this.fiveBtn.CheckedBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(234)))), ((int)(((byte)(234)))));
            this.fiveBtn.CheckedBorderColor = System.Drawing.Color.Black;
            this.fiveBtn.CheckedForeColor = System.Drawing.Color.White;
            this.fiveBtn.CheckedImage = ((System.Drawing.Image)(resources.GetObject("fiveBtn.CheckedImage")));
            this.fiveBtn.CheckedLineColor = System.Drawing.Color.DimGray;
            this.fiveBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.fiveBtn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.fiveBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fiveBtn.FocusedColor = System.Drawing.Color.Empty;
            this.fiveBtn.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fiveBtn.ForeColor = System.Drawing.Color.Black;
            this.fiveBtn.Image = null;
            this.fiveBtn.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.fiveBtn.ImageSize = new System.Drawing.Size(20, 20);
            this.fiveBtn.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.fiveBtn.Location = new System.Drawing.Point(93, 174);
            this.fiveBtn.Name = "fiveBtn";
            this.fiveBtn.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.fiveBtn.OnHoverBorderColor = System.Drawing.Color.Gainsboro;
            this.fiveBtn.OnHoverForeColor = System.Drawing.Color.Black;
            this.fiveBtn.OnHoverImage = null;
            this.fiveBtn.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.fiveBtn.OnPressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.fiveBtn.OnPressedDepth = 0;
            this.fiveBtn.Radius = 6;
            this.fiveBtn.Size = new System.Drawing.Size(84, 51);
            this.fiveBtn.TabIndex = 29;
            this.fiveBtn.Text = "5";
            this.fiveBtn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.fiveBtn.Click += new System.EventHandler(this.numbers_Only);
            // 
            // fourBtn
            // 
            this.fourBtn.AnimationHoverSpeed = 0.07F;
            this.fourBtn.AnimationSpeed = 0.03F;
            this.fourBtn.BackColor = System.Drawing.Color.Transparent;
            this.fourBtn.BaseColor = System.Drawing.Color.White;
            this.fourBtn.BorderColor = System.Drawing.Color.Gainsboro;
            this.fourBtn.BorderSize = 1;
            this.fourBtn.CheckedBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(234)))), ((int)(((byte)(234)))));
            this.fourBtn.CheckedBorderColor = System.Drawing.Color.Black;
            this.fourBtn.CheckedForeColor = System.Drawing.Color.White;
            this.fourBtn.CheckedImage = ((System.Drawing.Image)(resources.GetObject("fourBtn.CheckedImage")));
            this.fourBtn.CheckedLineColor = System.Drawing.Color.DimGray;
            this.fourBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.fourBtn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.fourBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fourBtn.FocusedColor = System.Drawing.Color.Empty;
            this.fourBtn.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fourBtn.ForeColor = System.Drawing.Color.Black;
            this.fourBtn.Image = null;
            this.fourBtn.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.fourBtn.ImageSize = new System.Drawing.Size(20, 20);
            this.fourBtn.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.fourBtn.Location = new System.Drawing.Point(3, 174);
            this.fourBtn.Name = "fourBtn";
            this.fourBtn.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.fourBtn.OnHoverBorderColor = System.Drawing.Color.Gainsboro;
            this.fourBtn.OnHoverForeColor = System.Drawing.Color.Black;
            this.fourBtn.OnHoverImage = null;
            this.fourBtn.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.fourBtn.OnPressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.fourBtn.OnPressedDepth = 0;
            this.fourBtn.Radius = 6;
            this.fourBtn.Size = new System.Drawing.Size(84, 51);
            this.fourBtn.TabIndex = 28;
            this.fourBtn.Text = "4";
            this.fourBtn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.fourBtn.Click += new System.EventHandler(this.numbers_Only);
            // 
            // minusBtn
            // 
            this.minusBtn.AnimationHoverSpeed = 0.07F;
            this.minusBtn.AnimationSpeed = 0.03F;
            this.minusBtn.BackColor = System.Drawing.Color.Transparent;
            this.minusBtn.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.minusBtn.BorderColor = System.Drawing.Color.Gainsboro;
            this.minusBtn.BorderSize = 1;
            this.minusBtn.CheckedBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.minusBtn.CheckedBorderColor = System.Drawing.Color.Gainsboro;
            this.minusBtn.CheckedForeColor = System.Drawing.Color.Black;
            this.minusBtn.CheckedImage = ((System.Drawing.Image)(resources.GetObject("minusBtn.CheckedImage")));
            this.minusBtn.CheckedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.minusBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.minusBtn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.minusBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.minusBtn.FocusedColor = System.Drawing.Color.Empty;
            this.minusBtn.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minusBtn.ForeColor = System.Drawing.Color.Black;
            this.minusBtn.Image = ((System.Drawing.Image)(resources.GetObject("minusBtn.Image")));
            this.minusBtn.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.minusBtn.ImageSize = new System.Drawing.Size(40, 40);
            this.minusBtn.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.minusBtn.Location = new System.Drawing.Point(273, 174);
            this.minusBtn.Name = "minusBtn";
            this.minusBtn.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.minusBtn.OnHoverBorderColor = System.Drawing.Color.Gainsboro;
            this.minusBtn.OnHoverForeColor = System.Drawing.Color.Black;
            this.minusBtn.OnHoverImage = null;
            this.minusBtn.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.minusBtn.OnPressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.minusBtn.OnPressedDepth = 0;
            this.minusBtn.Radius = 6;
            this.minusBtn.Size = new System.Drawing.Size(86, 51);
            this.minusBtn.TabIndex = 27;
            this.minusBtn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.minusBtn.Click += new System.EventHandler(this.operators_Click);
            // 
            // sixBtn
            // 
            this.sixBtn.AnimationHoverSpeed = 0.07F;
            this.sixBtn.AnimationSpeed = 0.03F;
            this.sixBtn.BackColor = System.Drawing.Color.Transparent;
            this.sixBtn.BaseColor = System.Drawing.Color.White;
            this.sixBtn.BorderColor = System.Drawing.Color.Gainsboro;
            this.sixBtn.BorderSize = 1;
            this.sixBtn.CheckedBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(234)))), ((int)(((byte)(234)))));
            this.sixBtn.CheckedBorderColor = System.Drawing.Color.Black;
            this.sixBtn.CheckedForeColor = System.Drawing.Color.White;
            this.sixBtn.CheckedImage = ((System.Drawing.Image)(resources.GetObject("sixBtn.CheckedImage")));
            this.sixBtn.CheckedLineColor = System.Drawing.Color.DimGray;
            this.sixBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sixBtn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.sixBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sixBtn.FocusedColor = System.Drawing.Color.Empty;
            this.sixBtn.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sixBtn.ForeColor = System.Drawing.Color.Black;
            this.sixBtn.Image = null;
            this.sixBtn.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.sixBtn.ImageSize = new System.Drawing.Size(20, 20);
            this.sixBtn.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.sixBtn.Location = new System.Drawing.Point(183, 174);
            this.sixBtn.Name = "sixBtn";
            this.sixBtn.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.sixBtn.OnHoverBorderColor = System.Drawing.Color.Gainsboro;
            this.sixBtn.OnHoverForeColor = System.Drawing.Color.Black;
            this.sixBtn.OnHoverImage = null;
            this.sixBtn.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.sixBtn.OnPressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.sixBtn.OnPressedDepth = 0;
            this.sixBtn.Radius = 6;
            this.sixBtn.Size = new System.Drawing.Size(84, 51);
            this.sixBtn.TabIndex = 26;
            this.sixBtn.Text = "6";
            this.sixBtn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.sixBtn.Click += new System.EventHandler(this.numbers_Only);
            // 
            // eightBtn
            // 
            this.eightBtn.AnimationHoverSpeed = 0.07F;
            this.eightBtn.AnimationSpeed = 0.03F;
            this.eightBtn.BackColor = System.Drawing.Color.Transparent;
            this.eightBtn.BaseColor = System.Drawing.Color.White;
            this.eightBtn.BorderColor = System.Drawing.Color.Gainsboro;
            this.eightBtn.BorderSize = 1;
            this.eightBtn.CheckedBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(234)))), ((int)(((byte)(234)))));
            this.eightBtn.CheckedBorderColor = System.Drawing.Color.Black;
            this.eightBtn.CheckedForeColor = System.Drawing.Color.White;
            this.eightBtn.CheckedImage = ((System.Drawing.Image)(resources.GetObject("eightBtn.CheckedImage")));
            this.eightBtn.CheckedLineColor = System.Drawing.Color.DimGray;
            this.eightBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.eightBtn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.eightBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.eightBtn.FocusedColor = System.Drawing.Color.Empty;
            this.eightBtn.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eightBtn.ForeColor = System.Drawing.Color.Black;
            this.eightBtn.Image = null;
            this.eightBtn.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.eightBtn.ImageSize = new System.Drawing.Size(20, 20);
            this.eightBtn.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.eightBtn.Location = new System.Drawing.Point(93, 117);
            this.eightBtn.Name = "eightBtn";
            this.eightBtn.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.eightBtn.OnHoverBorderColor = System.Drawing.Color.Gainsboro;
            this.eightBtn.OnHoverForeColor = System.Drawing.Color.Black;
            this.eightBtn.OnHoverImage = null;
            this.eightBtn.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.eightBtn.OnPressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.eightBtn.OnPressedDepth = 0;
            this.eightBtn.Radius = 6;
            this.eightBtn.Size = new System.Drawing.Size(84, 51);
            this.eightBtn.TabIndex = 25;
            this.eightBtn.Text = "8";
            this.eightBtn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.eightBtn.Click += new System.EventHandler(this.numbers_Only);
            // 
            // sevenBtn
            // 
            this.sevenBtn.AnimationHoverSpeed = 0.07F;
            this.sevenBtn.AnimationSpeed = 0.03F;
            this.sevenBtn.BackColor = System.Drawing.Color.Transparent;
            this.sevenBtn.BaseColor = System.Drawing.Color.White;
            this.sevenBtn.BorderColor = System.Drawing.Color.Gainsboro;
            this.sevenBtn.BorderSize = 1;
            this.sevenBtn.CheckedBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(234)))), ((int)(((byte)(234)))));
            this.sevenBtn.CheckedBorderColor = System.Drawing.Color.Black;
            this.sevenBtn.CheckedForeColor = System.Drawing.Color.White;
            this.sevenBtn.CheckedImage = ((System.Drawing.Image)(resources.GetObject("sevenBtn.CheckedImage")));
            this.sevenBtn.CheckedLineColor = System.Drawing.Color.DimGray;
            this.sevenBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sevenBtn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.sevenBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sevenBtn.FocusedColor = System.Drawing.Color.Empty;
            this.sevenBtn.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sevenBtn.ForeColor = System.Drawing.Color.Black;
            this.sevenBtn.Image = null;
            this.sevenBtn.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.sevenBtn.ImageSize = new System.Drawing.Size(20, 20);
            this.sevenBtn.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.sevenBtn.Location = new System.Drawing.Point(3, 117);
            this.sevenBtn.Name = "sevenBtn";
            this.sevenBtn.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.sevenBtn.OnHoverBorderColor = System.Drawing.Color.Gainsboro;
            this.sevenBtn.OnHoverForeColor = System.Drawing.Color.Black;
            this.sevenBtn.OnHoverImage = null;
            this.sevenBtn.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.sevenBtn.OnPressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.sevenBtn.OnPressedDepth = 0;
            this.sevenBtn.Radius = 6;
            this.sevenBtn.Size = new System.Drawing.Size(84, 51);
            this.sevenBtn.TabIndex = 24;
            this.sevenBtn.Text = "7";
            this.sevenBtn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.sevenBtn.Click += new System.EventHandler(this.numbers_Only);
            // 
            // multiBtn
            // 
            this.multiBtn.AnimationHoverSpeed = 0.07F;
            this.multiBtn.AnimationSpeed = 0.03F;
            this.multiBtn.BackColor = System.Drawing.Color.Transparent;
            this.multiBtn.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.multiBtn.BorderColor = System.Drawing.Color.Gainsboro;
            this.multiBtn.BorderSize = 1;
            this.multiBtn.CheckedBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.multiBtn.CheckedBorderColor = System.Drawing.Color.Gainsboro;
            this.multiBtn.CheckedForeColor = System.Drawing.Color.Black;
            this.multiBtn.CheckedImage = ((System.Drawing.Image)(resources.GetObject("multiBtn.CheckedImage")));
            this.multiBtn.CheckedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.multiBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.multiBtn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.multiBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.multiBtn.FocusedColor = System.Drawing.Color.Empty;
            this.multiBtn.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.multiBtn.ForeColor = System.Drawing.Color.Black;
            this.multiBtn.Image = ((System.Drawing.Image)(resources.GetObject("multiBtn.Image")));
            this.multiBtn.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.multiBtn.ImageSize = new System.Drawing.Size(30, 20);
            this.multiBtn.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.multiBtn.Location = new System.Drawing.Point(273, 117);
            this.multiBtn.Name = "multiBtn";
            this.multiBtn.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.multiBtn.OnHoverBorderColor = System.Drawing.Color.Gainsboro;
            this.multiBtn.OnHoverForeColor = System.Drawing.Color.Black;
            this.multiBtn.OnHoverImage = null;
            this.multiBtn.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.multiBtn.OnPressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.multiBtn.OnPressedDepth = 0;
            this.multiBtn.Radius = 6;
            this.multiBtn.Size = new System.Drawing.Size(86, 51);
            this.multiBtn.TabIndex = 23;
            this.multiBtn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.multiBtn.Click += new System.EventHandler(this.operators_Click);
            // 
            // nineBtn
            // 
            this.nineBtn.AnimationHoverSpeed = 0.07F;
            this.nineBtn.AnimationSpeed = 0.03F;
            this.nineBtn.BackColor = System.Drawing.Color.Transparent;
            this.nineBtn.BaseColor = System.Drawing.Color.White;
            this.nineBtn.BorderColor = System.Drawing.Color.Gainsboro;
            this.nineBtn.BorderSize = 1;
            this.nineBtn.CheckedBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(234)))), ((int)(((byte)(234)))));
            this.nineBtn.CheckedBorderColor = System.Drawing.Color.Black;
            this.nineBtn.CheckedForeColor = System.Drawing.Color.White;
            this.nineBtn.CheckedImage = ((System.Drawing.Image)(resources.GetObject("nineBtn.CheckedImage")));
            this.nineBtn.CheckedLineColor = System.Drawing.Color.DimGray;
            this.nineBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.nineBtn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.nineBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nineBtn.FocusedColor = System.Drawing.Color.Empty;
            this.nineBtn.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nineBtn.ForeColor = System.Drawing.Color.Black;
            this.nineBtn.Image = null;
            this.nineBtn.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nineBtn.ImageSize = new System.Drawing.Size(20, 20);
            this.nineBtn.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.nineBtn.Location = new System.Drawing.Point(183, 117);
            this.nineBtn.Name = "nineBtn";
            this.nineBtn.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.nineBtn.OnHoverBorderColor = System.Drawing.Color.Gainsboro;
            this.nineBtn.OnHoverForeColor = System.Drawing.Color.Black;
            this.nineBtn.OnHoverImage = null;
            this.nineBtn.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.nineBtn.OnPressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.nineBtn.OnPressedDepth = 0;
            this.nineBtn.Radius = 6;
            this.nineBtn.Size = new System.Drawing.Size(84, 51);
            this.nineBtn.TabIndex = 22;
            this.nineBtn.Text = "9";
            this.nineBtn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nineBtn.Click += new System.EventHandler(this.numbers_Only);
            // 
            // x2Btn
            // 
            this.x2Btn.AnimationHoverSpeed = 0.07F;
            this.x2Btn.AnimationSpeed = 0.03F;
            this.x2Btn.BackColor = System.Drawing.Color.Transparent;
            this.x2Btn.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.x2Btn.BorderColor = System.Drawing.Color.Gainsboro;
            this.x2Btn.BorderSize = 1;
            this.x2Btn.CheckedBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.x2Btn.CheckedBorderColor = System.Drawing.Color.Gainsboro;
            this.x2Btn.CheckedForeColor = System.Drawing.Color.Black;
            this.x2Btn.CheckedImage = ((System.Drawing.Image)(resources.GetObject("x2Btn.CheckedImage")));
            this.x2Btn.CheckedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.x2Btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.x2Btn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.x2Btn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.x2Btn.FocusedColor = System.Drawing.Color.Empty;
            this.x2Btn.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.x2Btn.ForeColor = System.Drawing.Color.Black;
            this.x2Btn.Image = ((System.Drawing.Image)(resources.GetObject("x2Btn.Image")));
            this.x2Btn.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.x2Btn.ImageSize = new System.Drawing.Size(50, 50);
            this.x2Btn.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.x2Btn.Location = new System.Drawing.Point(93, 60);
            this.x2Btn.Name = "x2Btn";
            this.x2Btn.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.x2Btn.OnHoverBorderColor = System.Drawing.Color.Gainsboro;
            this.x2Btn.OnHoverForeColor = System.Drawing.Color.Black;
            this.x2Btn.OnHoverImage = null;
            this.x2Btn.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.x2Btn.OnPressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.x2Btn.OnPressedDepth = 0;
            this.x2Btn.Radius = 6;
            this.x2Btn.Size = new System.Drawing.Size(84, 51);
            this.x2Btn.TabIndex = 21;
            this.x2Btn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.x2Btn.Click += new System.EventHandler(this.x2Btn_Click);
            // 
            // oneXBtn
            // 
            this.oneXBtn.AnimationHoverSpeed = 0.07F;
            this.oneXBtn.AnimationSpeed = 0.03F;
            this.oneXBtn.BackColor = System.Drawing.Color.Transparent;
            this.oneXBtn.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.oneXBtn.BorderColor = System.Drawing.Color.Gainsboro;
            this.oneXBtn.BorderSize = 1;
            this.oneXBtn.CheckedBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.oneXBtn.CheckedBorderColor = System.Drawing.Color.Gainsboro;
            this.oneXBtn.CheckedForeColor = System.Drawing.Color.Black;
            this.oneXBtn.CheckedImage = ((System.Drawing.Image)(resources.GetObject("oneXBtn.CheckedImage")));
            this.oneXBtn.CheckedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.oneXBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.oneXBtn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.oneXBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.oneXBtn.FocusedColor = System.Drawing.Color.Empty;
            this.oneXBtn.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.oneXBtn.ForeColor = System.Drawing.Color.Black;
            this.oneXBtn.Image = ((System.Drawing.Image)(resources.GetObject("oneXBtn.Image")));
            this.oneXBtn.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.oneXBtn.ImageSize = new System.Drawing.Size(40, 40);
            this.oneXBtn.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.oneXBtn.Location = new System.Drawing.Point(3, 60);
            this.oneXBtn.Name = "oneXBtn";
            this.oneXBtn.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.oneXBtn.OnHoverBorderColor = System.Drawing.Color.Gainsboro;
            this.oneXBtn.OnHoverForeColor = System.Drawing.Color.Black;
            this.oneXBtn.OnHoverImage = null;
            this.oneXBtn.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.oneXBtn.OnPressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.oneXBtn.OnPressedDepth = 0;
            this.oneXBtn.Radius = 6;
            this.oneXBtn.Size = new System.Drawing.Size(84, 51);
            this.oneXBtn.TabIndex = 20;
            this.oneXBtn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.oneXBtn.Click += new System.EventHandler(this.oneXBtn_Click);
            // 
            // divisionBtn
            // 
            this.divisionBtn.AnimationHoverSpeed = 0.07F;
            this.divisionBtn.AnimationSpeed = 0.03F;
            this.divisionBtn.BackColor = System.Drawing.Color.Transparent;
            this.divisionBtn.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.divisionBtn.BorderColor = System.Drawing.Color.Gainsboro;
            this.divisionBtn.BorderSize = 1;
            this.divisionBtn.CheckedBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.divisionBtn.CheckedBorderColor = System.Drawing.Color.Gainsboro;
            this.divisionBtn.CheckedForeColor = System.Drawing.Color.Black;
            this.divisionBtn.CheckedImage = ((System.Drawing.Image)(resources.GetObject("divisionBtn.CheckedImage")));
            this.divisionBtn.CheckedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.divisionBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.divisionBtn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.divisionBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.divisionBtn.FocusedColor = System.Drawing.Color.Empty;
            this.divisionBtn.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.divisionBtn.ForeColor = System.Drawing.Color.Black;
            this.divisionBtn.Image = ((System.Drawing.Image)(resources.GetObject("divisionBtn.Image")));
            this.divisionBtn.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.divisionBtn.ImageSize = new System.Drawing.Size(30, 20);
            this.divisionBtn.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.divisionBtn.Location = new System.Drawing.Point(273, 60);
            this.divisionBtn.Name = "divisionBtn";
            this.divisionBtn.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.divisionBtn.OnHoverBorderColor = System.Drawing.Color.Gainsboro;
            this.divisionBtn.OnHoverForeColor = System.Drawing.Color.Black;
            this.divisionBtn.OnHoverImage = null;
            this.divisionBtn.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.divisionBtn.OnPressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.divisionBtn.OnPressedDepth = 0;
            this.divisionBtn.Radius = 6;
            this.divisionBtn.Size = new System.Drawing.Size(86, 51);
            this.divisionBtn.TabIndex = 19;
            this.divisionBtn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.divisionBtn.Click += new System.EventHandler(this.operators_Click);
            // 
            // sqrtBtn
            // 
            this.sqrtBtn.AnimationHoverSpeed = 0.07F;
            this.sqrtBtn.AnimationSpeed = 0.03F;
            this.sqrtBtn.BackColor = System.Drawing.Color.Transparent;
            this.sqrtBtn.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.sqrtBtn.BorderColor = System.Drawing.Color.Gainsboro;
            this.sqrtBtn.BorderSize = 1;
            this.sqrtBtn.CheckedBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.sqrtBtn.CheckedBorderColor = System.Drawing.Color.Gainsboro;
            this.sqrtBtn.CheckedForeColor = System.Drawing.Color.Black;
            this.sqrtBtn.CheckedImage = ((System.Drawing.Image)(resources.GetObject("sqrtBtn.CheckedImage")));
            this.sqrtBtn.CheckedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.sqrtBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sqrtBtn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.sqrtBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sqrtBtn.FocusedColor = System.Drawing.Color.Empty;
            this.sqrtBtn.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sqrtBtn.ForeColor = System.Drawing.Color.Black;
            this.sqrtBtn.Image = ((System.Drawing.Image)(resources.GetObject("sqrtBtn.Image")));
            this.sqrtBtn.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.sqrtBtn.ImageSize = new System.Drawing.Size(50, 30);
            this.sqrtBtn.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.sqrtBtn.Location = new System.Drawing.Point(183, 60);
            this.sqrtBtn.Name = "sqrtBtn";
            this.sqrtBtn.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.sqrtBtn.OnHoverBorderColor = System.Drawing.Color.Gainsboro;
            this.sqrtBtn.OnHoverForeColor = System.Drawing.Color.Black;
            this.sqrtBtn.OnHoverImage = null;
            this.sqrtBtn.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.sqrtBtn.OnPressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.sqrtBtn.OnPressedDepth = 0;
            this.sqrtBtn.Radius = 6;
            this.sqrtBtn.Size = new System.Drawing.Size(84, 51);
            this.sqrtBtn.TabIndex = 18;
            this.sqrtBtn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.sqrtBtn.Click += new System.EventHandler(this.sqrtBtn_Click);
            // 
            // clearInputBtn
            // 
            this.clearInputBtn.AnimationHoverSpeed = 0.07F;
            this.clearInputBtn.AnimationSpeed = 0.03F;
            this.clearInputBtn.BackColor = System.Drawing.Color.Transparent;
            this.clearInputBtn.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.clearInputBtn.BorderColor = System.Drawing.Color.Gainsboro;
            this.clearInputBtn.BorderSize = 1;
            this.clearInputBtn.CheckedBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.clearInputBtn.CheckedBorderColor = System.Drawing.Color.Gainsboro;
            this.clearInputBtn.CheckedForeColor = System.Drawing.Color.White;
            this.clearInputBtn.CheckedImage = ((System.Drawing.Image)(resources.GetObject("clearInputBtn.CheckedImage")));
            this.clearInputBtn.CheckedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.clearInputBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.clearInputBtn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.clearInputBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.clearInputBtn.FocusedColor = System.Drawing.Color.Empty;
            this.clearInputBtn.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearInputBtn.ForeColor = System.Drawing.Color.Black;
            this.clearInputBtn.Image = null;
            this.clearInputBtn.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.clearInputBtn.ImageSize = new System.Drawing.Size(20, 20);
            this.clearInputBtn.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.clearInputBtn.Location = new System.Drawing.Point(93, 3);
            this.clearInputBtn.Name = "clearInputBtn";
            this.clearInputBtn.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.clearInputBtn.OnHoverBorderColor = System.Drawing.Color.Gainsboro;
            this.clearInputBtn.OnHoverForeColor = System.Drawing.Color.Black;
            this.clearInputBtn.OnHoverImage = null;
            this.clearInputBtn.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.clearInputBtn.OnPressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.clearInputBtn.OnPressedDepth = 0;
            this.clearInputBtn.Radius = 6;
            this.clearInputBtn.Size = new System.Drawing.Size(84, 51);
            this.clearInputBtn.TabIndex = 17;
            this.clearInputBtn.Text = "CE";
            this.clearInputBtn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.clearInputBtn.Click += new System.EventHandler(this.clearInputBtn_Click);
            // 
            // percentBtn
            // 
            this.percentBtn.AnimationHoverSpeed = 0.07F;
            this.percentBtn.AnimationSpeed = 0.03F;
            this.percentBtn.BackColor = System.Drawing.Color.Transparent;
            this.percentBtn.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.percentBtn.BorderColor = System.Drawing.Color.Gainsboro;
            this.percentBtn.BorderSize = 1;
            this.percentBtn.CheckedBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.percentBtn.CheckedBorderColor = System.Drawing.Color.Gainsboro;
            this.percentBtn.CheckedForeColor = System.Drawing.Color.Black;
            this.percentBtn.CheckedImage = null;
            this.percentBtn.CheckedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.percentBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.percentBtn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.percentBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.percentBtn.FocusedColor = System.Drawing.Color.Empty;
            this.percentBtn.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.percentBtn.ForeColor = System.Drawing.Color.Black;
            this.percentBtn.Image = null;
            this.percentBtn.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.percentBtn.ImageSize = new System.Drawing.Size(20, 20);
            this.percentBtn.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.percentBtn.Location = new System.Drawing.Point(3, 3);
            this.percentBtn.Name = "percentBtn";
            this.percentBtn.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.percentBtn.OnHoverBorderColor = System.Drawing.Color.Gainsboro;
            this.percentBtn.OnHoverForeColor = System.Drawing.Color.Black;
            this.percentBtn.OnHoverImage = null;
            this.percentBtn.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.percentBtn.OnPressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.percentBtn.OnPressedDepth = 0;
            this.percentBtn.Radius = 6;
            this.percentBtn.Size = new System.Drawing.Size(84, 51);
            this.percentBtn.TabIndex = 16;
            this.percentBtn.Text = "%";
            this.percentBtn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.percentBtn.Click += new System.EventHandler(this.percentBtn_Click);
            // 
            // backspaceBtn
            // 
            this.backspaceBtn.AnimationHoverSpeed = 0.07F;
            this.backspaceBtn.AnimationSpeed = 0.03F;
            this.backspaceBtn.BackColor = System.Drawing.Color.Transparent;
            this.backspaceBtn.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.backspaceBtn.BorderColor = System.Drawing.Color.Gainsboro;
            this.backspaceBtn.BorderSize = 1;
            this.backspaceBtn.CheckedBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(234)))), ((int)(((byte)(234)))));
            this.backspaceBtn.CheckedBorderColor = System.Drawing.Color.Black;
            this.backspaceBtn.CheckedForeColor = System.Drawing.Color.White;
            this.backspaceBtn.CheckedImage = ((System.Drawing.Image)(resources.GetObject("backspaceBtn.CheckedImage")));
            this.backspaceBtn.CheckedLineColor = System.Drawing.Color.DimGray;
            this.backspaceBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.backspaceBtn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.backspaceBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.backspaceBtn.FocusedColor = System.Drawing.Color.Empty;
            this.backspaceBtn.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backspaceBtn.ForeColor = System.Drawing.Color.Black;
            this.backspaceBtn.Image = ((System.Drawing.Image)(resources.GetObject("backspaceBtn.Image")));
            this.backspaceBtn.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.backspaceBtn.ImageSize = new System.Drawing.Size(20, 20);
            this.backspaceBtn.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.backspaceBtn.Location = new System.Drawing.Point(273, 3);
            this.backspaceBtn.Name = "backspaceBtn";
            this.backspaceBtn.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.backspaceBtn.OnHoverBorderColor = System.Drawing.Color.Gainsboro;
            this.backspaceBtn.OnHoverForeColor = System.Drawing.Color.Black;
            this.backspaceBtn.OnHoverImage = null;
            this.backspaceBtn.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.backspaceBtn.OnPressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.backspaceBtn.OnPressedDepth = 0;
            this.backspaceBtn.Radius = 6;
            this.backspaceBtn.Size = new System.Drawing.Size(86, 51);
            this.backspaceBtn.TabIndex = 15;
            this.backspaceBtn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.backspaceBtn.Click += new System.EventHandler(this.backspaceBtn_Click);
            // 
            // clearBtn
            // 
            this.clearBtn.AnimationHoverSpeed = 0.07F;
            this.clearBtn.AnimationSpeed = 0.03F;
            this.clearBtn.BackColor = System.Drawing.Color.Transparent;
            this.clearBtn.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.clearBtn.BorderColor = System.Drawing.Color.Gainsboro;
            this.clearBtn.BorderSize = 1;
            this.clearBtn.CheckedBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.clearBtn.CheckedBorderColor = System.Drawing.Color.Black;
            this.clearBtn.CheckedForeColor = System.Drawing.Color.White;
            this.clearBtn.CheckedImage = ((System.Drawing.Image)(resources.GetObject("clearBtn.CheckedImage")));
            this.clearBtn.CheckedLineColor = System.Drawing.Color.DimGray;
            this.clearBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.clearBtn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.clearBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.clearBtn.FocusedColor = System.Drawing.Color.Empty;
            this.clearBtn.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearBtn.ForeColor = System.Drawing.Color.Black;
            this.clearBtn.Image = null;
            this.clearBtn.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.clearBtn.ImageSize = new System.Drawing.Size(20, 20);
            this.clearBtn.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.clearBtn.Location = new System.Drawing.Point(183, 3);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.clearBtn.OnHoverBorderColor = System.Drawing.Color.Gainsboro;
            this.clearBtn.OnHoverForeColor = System.Drawing.Color.Black;
            this.clearBtn.OnHoverImage = null;
            this.clearBtn.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.clearBtn.OnPressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.clearBtn.OnPressedDepth = 0;
            this.clearBtn.Radius = 6;
            this.clearBtn.Size = new System.Drawing.Size(84, 51);
            this.clearBtn.TabIndex = 14;
            this.clearBtn.Text = "C";
            this.clearBtn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.clearBtn.Click += new System.EventHandler(this.clearBtn_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 6;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel2.Controls.Add(this.openMemoryBtn, 5, 0);
            this.tableLayoutPanel2.Controls.Add(this.msBtn, 4, 0);
            this.tableLayoutPanel2.Controls.Add(this.mMinusBtn, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.mPlusBtn, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.mrBtn, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.mcBtn, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 84);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(362, 54);
            this.tableLayoutPanel2.TabIndex = 18;
            // 
            // openMemoryBtn
            // 
            this.openMemoryBtn.AnimationHoverSpeed = 0.07F;
            this.openMemoryBtn.AnimationSpeed = 0.03F;
            this.openMemoryBtn.BackColor = System.Drawing.Color.Transparent;
            this.openMemoryBtn.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.openMemoryBtn.BorderColor = System.Drawing.Color.Black;
            this.openMemoryBtn.CheckedBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.openMemoryBtn.CheckedBorderColor = System.Drawing.Color.Transparent;
            this.openMemoryBtn.CheckedForeColor = System.Drawing.Color.DarkGray;
            this.openMemoryBtn.CheckedImage = ((System.Drawing.Image)(resources.GetObject("openMemoryBtn.CheckedImage")));
            this.openMemoryBtn.CheckedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.openMemoryBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.openMemoryBtn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.openMemoryBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.openMemoryBtn.FocusedColor = System.Drawing.Color.Empty;
            this.openMemoryBtn.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.openMemoryBtn.ForeColor = System.Drawing.Color.Black;
            this.openMemoryBtn.Image = ((System.Drawing.Image)(resources.GetObject("openMemoryBtn.Image")));
            this.openMemoryBtn.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.openMemoryBtn.ImageSize = new System.Drawing.Size(8, 8);
            this.openMemoryBtn.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.openMemoryBtn.Location = new System.Drawing.Point(303, 3);
            this.openMemoryBtn.Name = "openMemoryBtn";
            this.openMemoryBtn.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(234)))), ((int)(((byte)(234)))));
            this.openMemoryBtn.OnHoverBorderColor = System.Drawing.Color.Black;
            this.openMemoryBtn.OnHoverForeColor = System.Drawing.Color.Black;
            this.openMemoryBtn.OnHoverImage = null;
            this.openMemoryBtn.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.openMemoryBtn.OnPressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(234)))), ((int)(((byte)(234)))));
            this.openMemoryBtn.OnPressedDepth = 0;
            this.openMemoryBtn.Radius = 4;
            this.openMemoryBtn.Size = new System.Drawing.Size(56, 48);
            this.openMemoryBtn.TabIndex = 30;
            this.openMemoryBtn.Text = "M";
            this.openMemoryBtn.Click += new System.EventHandler(this.openMemoryBtn_Click);
            // 
            // msBtn
            // 
            this.msBtn.AnimationHoverSpeed = 0.07F;
            this.msBtn.AnimationSpeed = 0.03F;
            this.msBtn.BackColor = System.Drawing.Color.Transparent;
            this.msBtn.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.msBtn.BorderColor = System.Drawing.Color.Black;
            this.msBtn.CheckedBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.msBtn.CheckedBorderColor = System.Drawing.Color.Gainsboro;
            this.msBtn.CheckedForeColor = System.Drawing.Color.Black;
            this.msBtn.CheckedImage = null;
            this.msBtn.CheckedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.msBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.msBtn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.msBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.msBtn.FocusedColor = System.Drawing.Color.Empty;
            this.msBtn.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.msBtn.ForeColor = System.Drawing.Color.Black;
            this.msBtn.Image = null;
            this.msBtn.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.msBtn.ImageSize = new System.Drawing.Size(20, 20);
            this.msBtn.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.msBtn.Location = new System.Drawing.Point(243, 3);
            this.msBtn.Name = "msBtn";
            this.msBtn.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(234)))), ((int)(((byte)(234)))));
            this.msBtn.OnHoverBorderColor = System.Drawing.Color.Black;
            this.msBtn.OnHoverForeColor = System.Drawing.Color.Black;
            this.msBtn.OnHoverImage = null;
            this.msBtn.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.msBtn.OnPressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(234)))), ((int)(((byte)(234)))));
            this.msBtn.OnPressedDepth = 0;
            this.msBtn.Radius = 4;
            this.msBtn.Size = new System.Drawing.Size(54, 48);
            this.msBtn.TabIndex = 28;
            this.msBtn.Text = "MS";
            this.msBtn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.msBtn.Click += new System.EventHandler(this.msBtn_Click);
            // 
            // mMinusBtn
            // 
            this.mMinusBtn.AnimationHoverSpeed = 0.07F;
            this.mMinusBtn.AnimationSpeed = 0.03F;
            this.mMinusBtn.BackColor = System.Drawing.Color.Transparent;
            this.mMinusBtn.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.mMinusBtn.BorderColor = System.Drawing.Color.Black;
            this.mMinusBtn.CheckedBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.mMinusBtn.CheckedBorderColor = System.Drawing.Color.Gainsboro;
            this.mMinusBtn.CheckedForeColor = System.Drawing.Color.Black;
            this.mMinusBtn.CheckedImage = null;
            this.mMinusBtn.CheckedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.mMinusBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.mMinusBtn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.mMinusBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mMinusBtn.FocusedColor = System.Drawing.Color.Empty;
            this.mMinusBtn.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mMinusBtn.ForeColor = System.Drawing.Color.Black;
            this.mMinusBtn.Image = null;
            this.mMinusBtn.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.mMinusBtn.ImageSize = new System.Drawing.Size(20, 20);
            this.mMinusBtn.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.mMinusBtn.Location = new System.Drawing.Point(183, 3);
            this.mMinusBtn.Name = "mMinusBtn";
            this.mMinusBtn.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(234)))), ((int)(((byte)(234)))));
            this.mMinusBtn.OnHoverBorderColor = System.Drawing.Color.Black;
            this.mMinusBtn.OnHoverForeColor = System.Drawing.Color.Black;
            this.mMinusBtn.OnHoverImage = null;
            this.mMinusBtn.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.mMinusBtn.OnPressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(234)))), ((int)(((byte)(234)))));
            this.mMinusBtn.OnPressedDepth = 0;
            this.mMinusBtn.Radius = 4;
            this.mMinusBtn.Size = new System.Drawing.Size(54, 48);
            this.mMinusBtn.TabIndex = 27;
            this.mMinusBtn.Text = "M-";
            this.mMinusBtn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.mMinusBtn.Click += new System.EventHandler(this.mMinusBtn_Click);
            // 
            // mPlusBtn
            // 
            this.mPlusBtn.AnimationHoverSpeed = 0.07F;
            this.mPlusBtn.AnimationSpeed = 0.03F;
            this.mPlusBtn.BackColor = System.Drawing.Color.Transparent;
            this.mPlusBtn.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.mPlusBtn.BorderColor = System.Drawing.Color.Black;
            this.mPlusBtn.CheckedBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.mPlusBtn.CheckedBorderColor = System.Drawing.Color.Gainsboro;
            this.mPlusBtn.CheckedForeColor = System.Drawing.Color.Black;
            this.mPlusBtn.CheckedImage = null;
            this.mPlusBtn.CheckedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.mPlusBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.mPlusBtn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.mPlusBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mPlusBtn.FocusedColor = System.Drawing.Color.Empty;
            this.mPlusBtn.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mPlusBtn.ForeColor = System.Drawing.Color.Black;
            this.mPlusBtn.Image = null;
            this.mPlusBtn.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.mPlusBtn.ImageSize = new System.Drawing.Size(20, 20);
            this.mPlusBtn.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.mPlusBtn.Location = new System.Drawing.Point(123, 3);
            this.mPlusBtn.Name = "mPlusBtn";
            this.mPlusBtn.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(234)))), ((int)(((byte)(234)))));
            this.mPlusBtn.OnHoverBorderColor = System.Drawing.Color.Black;
            this.mPlusBtn.OnHoverForeColor = System.Drawing.Color.Black;
            this.mPlusBtn.OnHoverImage = null;
            this.mPlusBtn.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.mPlusBtn.OnPressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(234)))), ((int)(((byte)(234)))));
            this.mPlusBtn.OnPressedDepth = 0;
            this.mPlusBtn.Radius = 4;
            this.mPlusBtn.Size = new System.Drawing.Size(54, 48);
            this.mPlusBtn.TabIndex = 26;
            this.mPlusBtn.Text = "M+";
            this.mPlusBtn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.mPlusBtn.Click += new System.EventHandler(this.mPlusBtn_Click);
            // 
            // mrBtn
            // 
            this.mrBtn.AnimationHoverSpeed = 0.07F;
            this.mrBtn.AnimationSpeed = 0.03F;
            this.mrBtn.BackColor = System.Drawing.Color.Transparent;
            this.mrBtn.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.mrBtn.BorderColor = System.Drawing.Color.Black;
            this.mrBtn.CheckedBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.mrBtn.CheckedBorderColor = System.Drawing.Color.Transparent;
            this.mrBtn.CheckedForeColor = System.Drawing.Color.DarkGray;
            this.mrBtn.CheckedImage = null;
            this.mrBtn.CheckedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.mrBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.mrBtn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.mrBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mrBtn.FocusedColor = System.Drawing.Color.Empty;
            this.mrBtn.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mrBtn.ForeColor = System.Drawing.Color.Black;
            this.mrBtn.Image = null;
            this.mrBtn.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.mrBtn.ImageSize = new System.Drawing.Size(20, 20);
            this.mrBtn.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.mrBtn.Location = new System.Drawing.Point(63, 3);
            this.mrBtn.Name = "mrBtn";
            this.mrBtn.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(234)))), ((int)(((byte)(234)))));
            this.mrBtn.OnHoverBorderColor = System.Drawing.Color.Black;
            this.mrBtn.OnHoverForeColor = System.Drawing.Color.Black;
            this.mrBtn.OnHoverImage = null;
            this.mrBtn.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.mrBtn.OnPressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(234)))), ((int)(((byte)(234)))));
            this.mrBtn.OnPressedDepth = 0;
            this.mrBtn.Radius = 4;
            this.mrBtn.Size = new System.Drawing.Size(54, 48);
            this.mrBtn.TabIndex = 25;
            this.mrBtn.Text = "MR";
            this.mrBtn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.mrBtn.Click += new System.EventHandler(this.mrBtn_Click);
            // 
            // mcBtn
            // 
            this.mcBtn.AnimationHoverSpeed = 0.07F;
            this.mcBtn.AnimationSpeed = 0.03F;
            this.mcBtn.BackColor = System.Drawing.Color.Transparent;
            this.mcBtn.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.mcBtn.BorderColor = System.Drawing.Color.Black;
            this.mcBtn.CheckedBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.mcBtn.CheckedBorderColor = System.Drawing.Color.Transparent;
            this.mcBtn.CheckedForeColor = System.Drawing.Color.DarkGray;
            this.mcBtn.CheckedImage = null;
            this.mcBtn.CheckedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.mcBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.mcBtn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.mcBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mcBtn.FocusedColor = System.Drawing.Color.Empty;
            this.mcBtn.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mcBtn.ForeColor = System.Drawing.Color.Black;
            this.mcBtn.Image = null;
            this.mcBtn.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.mcBtn.ImageSize = new System.Drawing.Size(20, 20);
            this.mcBtn.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.mcBtn.Location = new System.Drawing.Point(3, 3);
            this.mcBtn.Name = "mcBtn";
            this.mcBtn.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(234)))), ((int)(((byte)(234)))));
            this.mcBtn.OnHoverBorderColor = System.Drawing.Color.Black;
            this.mcBtn.OnHoverForeColor = System.Drawing.Color.Black;
            this.mcBtn.OnHoverImage = null;
            this.mcBtn.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.mcBtn.OnPressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(234)))), ((int)(((byte)(234)))));
            this.mcBtn.OnPressedDepth = 0;
            this.mcBtn.Radius = 4;
            this.mcBtn.Size = new System.Drawing.Size(54, 48);
            this.mcBtn.TabIndex = 24;
            this.mcBtn.Text = "MC";
            this.mcBtn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.mcBtn.Click += new System.EventHandler(this.mcBtn_Click);
            // 
            // input
            // 
            this.input.BackColor = System.Drawing.Color.Transparent;
            this.input.BorderColor = System.Drawing.Color.Transparent;
            this.input.BorderThickness = 0;
            this.input.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.input.DefaultText = "0";
            this.input.DisabledState.BorderColor = System.Drawing.Color.Transparent;
            this.input.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.input.DisabledState.ForeColor = System.Drawing.Color.Black;
            this.input.DisabledState.Parent = this.input;
            this.input.DisabledState.PlaceholderForeColor = System.Drawing.Color.Black;
            this.input.Dock = System.Windows.Forms.DockStyle.Top;
            this.input.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.input.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.input.FocusedState.Parent = this.input;
            this.input.Font = new System.Drawing.Font("Calibri", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.input.ForeColor = System.Drawing.Color.Black;
            this.input.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.input.HoverState.Parent = this.input;
            this.input.Location = new System.Drawing.Point(0, 28);
            this.input.Margin = new System.Windows.Forms.Padding(4);
            this.input.Name = "input";
            this.input.PasswordChar = '\0';
            this.input.PlaceholderForeColor = System.Drawing.Color.Black;
            this.input.PlaceholderText = "";
            this.input.SelectedText = "";
            this.input.SelectionStart = 1;
            this.input.ShadowDecoration.Parent = this.input;
            this.input.Size = new System.Drawing.Size(362, 56);
            this.input.TabIndex = 6;
            this.input.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.input.TextChanged += new System.EventHandler(this.input_TextChanged);
            this.input.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.input_KeyPress);
            this.input.Leave += new System.EventHandler(this.input_Leave);
            this.input.MouseDown += new System.Windows.Forms.MouseEventHandler(this.input_MouseDown);
            // 
            // displayCalculate
            // 
            this.displayCalculate.AutoEllipsis = true;
            this.displayCalculate.BackColor = System.Drawing.Color.Transparent;
            this.displayCalculate.Dock = System.Windows.Forms.DockStyle.Top;
            this.displayCalculate.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.displayCalculate.ForeColor = System.Drawing.Color.Gray;
            this.displayCalculate.Location = new System.Drawing.Point(0, 0);
            this.displayCalculate.Name = "displayCalculate";
            this.displayCalculate.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.displayCalculate.Size = new System.Drawing.Size(362, 28);
            this.displayCalculate.TabIndex = 0;
            this.displayCalculate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.test);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(362, 539);
            this.panel1.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.menuIcon);
            this.panel3.Controls.Add(this.gunaAdvenceButton1);
            this.panel3.Controls.Add(this.titleHeader);
            this.panel3.Controls.Add(this.historyIcon);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(362, 55);
            this.panel3.TabIndex = 12;
            // 
            // menuIcon
            // 
            this.menuIcon.AnimationHoverSpeed = 0.07F;
            this.menuIcon.AnimationSpeed = 0.03F;
            this.menuIcon.BackColor = System.Drawing.Color.Transparent;
            this.menuIcon.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.menuIcon.BorderColor = System.Drawing.Color.Black;
            this.menuIcon.CheckedBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(234)))), ((int)(((byte)(234)))));
            this.menuIcon.CheckedBorderColor = System.Drawing.Color.Black;
            this.menuIcon.CheckedForeColor = System.Drawing.Color.White;
            this.menuIcon.CheckedImage = ((System.Drawing.Image)(resources.GetObject("menuIcon.CheckedImage")));
            this.menuIcon.CheckedLineColor = System.Drawing.Color.DimGray;
            this.menuIcon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.menuIcon.DialogResult = System.Windows.Forms.DialogResult.None;
            this.menuIcon.FocusedColor = System.Drawing.Color.Empty;
            this.menuIcon.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.menuIcon.ForeColor = System.Drawing.Color.White;
            this.menuIcon.Image = ((System.Drawing.Image)(resources.GetObject("menuIcon.Image")));
            this.menuIcon.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.menuIcon.ImageSize = new System.Drawing.Size(20, 20);
            this.menuIcon.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.menuIcon.Location = new System.Drawing.Point(10, 7);
            this.menuIcon.Name = "menuIcon";
            this.menuIcon.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(234)))), ((int)(((byte)(234)))));
            this.menuIcon.OnHoverBorderColor = System.Drawing.Color.Black;
            this.menuIcon.OnHoverForeColor = System.Drawing.Color.White;
            this.menuIcon.OnHoverImage = null;
            this.menuIcon.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.menuIcon.OnPressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(234)))), ((int)(((byte)(234)))));
            this.menuIcon.OnPressedDepth = 0;
            this.menuIcon.Radius = 4;
            this.menuIcon.Size = new System.Drawing.Size(40, 40);
            this.menuIcon.TabIndex = 11;
            this.menuIcon.Click += new System.EventHandler(this.menuIcon_Click);
            // 
            // gunaAdvenceButton1
            // 
            this.gunaAdvenceButton1.AnimationHoverSpeed = 0.07F;
            this.gunaAdvenceButton1.AnimationSpeed = 0.03F;
            this.gunaAdvenceButton1.BackColor = System.Drawing.Color.Transparent;
            this.gunaAdvenceButton1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.gunaAdvenceButton1.BorderColor = System.Drawing.Color.Black;
            this.gunaAdvenceButton1.CheckedBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(234)))), ((int)(((byte)(234)))));
            this.gunaAdvenceButton1.CheckedBorderColor = System.Drawing.Color.Black;
            this.gunaAdvenceButton1.CheckedForeColor = System.Drawing.Color.White;
            this.gunaAdvenceButton1.CheckedImage = ((System.Drawing.Image)(resources.GetObject("gunaAdvenceButton1.CheckedImage")));
            this.gunaAdvenceButton1.CheckedLineColor = System.Drawing.Color.DimGray;
            this.gunaAdvenceButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.gunaAdvenceButton1.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaAdvenceButton1.FocusedColor = System.Drawing.Color.Empty;
            this.gunaAdvenceButton1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaAdvenceButton1.ForeColor = System.Drawing.Color.White;
            this.gunaAdvenceButton1.Image = ((System.Drawing.Image)(resources.GetObject("gunaAdvenceButton1.Image")));
            this.gunaAdvenceButton1.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.gunaAdvenceButton1.ImageSize = new System.Drawing.Size(15, 15);
            this.gunaAdvenceButton1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.gunaAdvenceButton1.Location = new System.Drawing.Point(150, 7);
            this.gunaAdvenceButton1.Name = "gunaAdvenceButton1";
            this.gunaAdvenceButton1.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(234)))), ((int)(((byte)(234)))));
            this.gunaAdvenceButton1.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaAdvenceButton1.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaAdvenceButton1.OnHoverImage = null;
            this.gunaAdvenceButton1.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.gunaAdvenceButton1.OnPressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(234)))), ((int)(((byte)(234)))));
            this.gunaAdvenceButton1.OnPressedDepth = 0;
            this.gunaAdvenceButton1.Radius = 4;
            this.gunaAdvenceButton1.Size = new System.Drawing.Size(40, 40);
            this.gunaAdvenceButton1.TabIndex = 13;
            this.gunaAdvenceButton1.Click += new System.EventHandler(this.gunaAdvenceButton1_Click);
            // 
            // titleHeader
            // 
            this.titleHeader.BackColor = System.Drawing.Color.Transparent;
            this.titleHeader.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.titleHeader.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleHeader.Location = new System.Drawing.Point(52, 6);
            this.titleHeader.Name = "titleHeader";
            this.titleHeader.Size = new System.Drawing.Size(102, 40);
            this.titleHeader.TabIndex = 12;
            this.titleHeader.Text = "Standard";
            this.titleHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // historyIcon
            // 
            this.historyIcon.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.historyIcon.AnimationHoverSpeed = 0.07F;
            this.historyIcon.AnimationSpeed = 0.03F;
            this.historyIcon.BackColor = System.Drawing.Color.Transparent;
            this.historyIcon.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.historyIcon.BorderColor = System.Drawing.Color.Black;
            this.historyIcon.CheckedBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(234)))), ((int)(((byte)(234)))));
            this.historyIcon.CheckedBorderColor = System.Drawing.Color.Black;
            this.historyIcon.CheckedForeColor = System.Drawing.Color.White;
            this.historyIcon.CheckedImage = ((System.Drawing.Image)(resources.GetObject("historyIcon.CheckedImage")));
            this.historyIcon.CheckedLineColor = System.Drawing.Color.DimGray;
            this.historyIcon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.historyIcon.DialogResult = System.Windows.Forms.DialogResult.None;
            this.historyIcon.FocusedColor = System.Drawing.Color.Empty;
            this.historyIcon.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.historyIcon.ForeColor = System.Drawing.Color.White;
            this.historyIcon.Image = ((System.Drawing.Image)(resources.GetObject("historyIcon.Image")));
            this.historyIcon.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.historyIcon.ImageSize = new System.Drawing.Size(20, 20);
            this.historyIcon.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.historyIcon.Location = new System.Drawing.Point(318, 8);
            this.historyIcon.Name = "historyIcon";
            this.historyIcon.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(234)))), ((int)(((byte)(234)))));
            this.historyIcon.OnHoverBorderColor = System.Drawing.Color.Black;
            this.historyIcon.OnHoverForeColor = System.Drawing.Color.White;
            this.historyIcon.OnHoverImage = null;
            this.historyIcon.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.historyIcon.OnPressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(234)))), ((int)(((byte)(234)))));
            this.historyIcon.OnPressedDepth = 0;
            this.historyIcon.Radius = 4;
            this.historyIcon.Size = new System.Drawing.Size(40, 40);
            this.historyIcon.TabIndex = 14;
            this.historyIcon.Click += new System.EventHandler(this.historyIcon_Click);
            // 
            // leftPanel
            // 
            this.leftPanel.AutoScroll = true;
            this.leftPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.leftPanel.Location = new System.Drawing.Point(362, 0);
            this.leftPanel.Name = "leftPanel";
            this.leftPanel.Size = new System.Drawing.Size(75, 539);
            this.leftPanel.TabIndex = 1;
            this.leftPanel.Visible = false;
            // 
            // sidebarChild
            // 
            this.sidebarChild.BackColor = System.Drawing.Color.Transparent;
            this.sidebarChild.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.sidebarChild.Controls.Add(this.gunaAdvenceButton2);
            this.sidebarChild.Controls.Add(this.sidebarItem1);
            this.sidebarChild.Controls.Add(this.panel2);
            this.sidebarChild.Controls.Add(this.panel4);
            this.sidebarChild.Controls.Add(this.label1);
            this.sidebarChild.Controls.Add(this.panel5);
            this.sidebarChild.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidebarChild.Location = new System.Drawing.Point(0, 0);
            this.sidebarChild.Name = "sidebarChild";
            this.sidebarChild.Radius = 12;
            this.sidebarChild.ShadowColor = System.Drawing.Color.Black;
            this.sidebarChild.ShadowDepth = 60;
            this.sidebarChild.ShadowShift = 4;
            this.sidebarChild.Size = new System.Drawing.Size(0, 539);
            this.sidebarChild.TabIndex = 9;
            // 
            // gunaAdvenceButton2
            // 
            this.gunaAdvenceButton2.AnimationHoverSpeed = 0.07F;
            this.gunaAdvenceButton2.AnimationSpeed = 0.03F;
            this.gunaAdvenceButton2.BackColor = System.Drawing.Color.Transparent;
            this.gunaAdvenceButton2.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.gunaAdvenceButton2.BorderColor = System.Drawing.Color.Black;
            this.gunaAdvenceButton2.CheckedBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(234)))), ((int)(((byte)(234)))));
            this.gunaAdvenceButton2.CheckedBorderColor = System.Drawing.Color.Black;
            this.gunaAdvenceButton2.CheckedForeColor = System.Drawing.Color.White;
            this.gunaAdvenceButton2.CheckedImage = ((System.Drawing.Image)(resources.GetObject("gunaAdvenceButton2.CheckedImage")));
            this.gunaAdvenceButton2.CheckedLineColor = System.Drawing.Color.DimGray;
            this.gunaAdvenceButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.gunaAdvenceButton2.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaAdvenceButton2.FocusedColor = System.Drawing.Color.Empty;
            this.gunaAdvenceButton2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaAdvenceButton2.ForeColor = System.Drawing.Color.White;
            this.gunaAdvenceButton2.Image = ((System.Drawing.Image)(resources.GetObject("gunaAdvenceButton2.Image")));
            this.gunaAdvenceButton2.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.gunaAdvenceButton2.ImageSize = new System.Drawing.Size(20, 20);
            this.gunaAdvenceButton2.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.gunaAdvenceButton2.Location = new System.Drawing.Point(10, 7);
            this.gunaAdvenceButton2.Name = "gunaAdvenceButton2";
            this.gunaAdvenceButton2.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(234)))), ((int)(((byte)(234)))));
            this.gunaAdvenceButton2.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaAdvenceButton2.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaAdvenceButton2.OnHoverImage = null;
            this.gunaAdvenceButton2.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.gunaAdvenceButton2.OnPressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(234)))), ((int)(((byte)(234)))));
            this.gunaAdvenceButton2.OnPressedDepth = 0;
            this.gunaAdvenceButton2.Radius = 4;
            this.gunaAdvenceButton2.Size = new System.Drawing.Size(40, 40);
            this.gunaAdvenceButton2.TabIndex = 12;
            this.gunaAdvenceButton2.Click += new System.EventHandler(this.gunaAdvenceButton2_Click);
            // 
            // sidebarItem1
            // 
            this.sidebarItem1.BackColor = System.Drawing.Color.Transparent;
            this.sidebarItem1.BaseColor = System.Drawing.Color.Empty;
            this.sidebarItem1.Location = new System.Drawing.Point(18, 107);
            this.sidebarItem1.Margin = new System.Windows.Forms.Padding(2);
            this.sidebarItem1.Name = "sidebarItem1";
            this.sidebarItem1.Size = new System.Drawing.Size(172, 47);
            this.sidebarItem1.TabIndex = 6;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(10, 529);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(0, 10);
            this.panel2.TabIndex = 5;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(10, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(0, 10);
            this.panel4.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Calculator";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.panel5.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(10, 539);
            this.panel5.TabIndex = 0;
            // 
            // memoryCheck
            // 
            this.memoryCheck.Enabled = true;
            this.memoryCheck.Tick += new System.EventHandler(this.memoryCheck_Tick);
            // 
            // Calculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.ClientSize = new System.Drawing.Size(437, 539);
            this.Controls.Add(this.sidebarChild);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.leftPanel);
            this.Font = new System.Drawing.Font("Calibri", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(320, 539);
            this.Name = "Calculator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculator";
            this.Load += new System.EventHandler(this.Calculator_Load);
            this.Resize += new System.EventHandler(this.Calculator_Resize);
            this.test.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.sidebarChild.ResumeLayout(false);
            this.sidebarChild.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer sidebarTransition;
        private SidebarItem standardBtn;
        private System.Windows.Forms.Panel test;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private Guna.UI.WinForms.GunaAdvenceButton zeroBtn;
        private Guna.UI.WinForms.GunaAdvenceButton plusOrMinusBtn;
        private Guna.UI.WinForms.GunaAdvenceButton equalBtn;
        private Guna.UI.WinForms.GunaAdvenceButton dotBtn;
        private Guna.UI.WinForms.GunaAdvenceButton twoBtn;
        private Guna.UI.WinForms.GunaAdvenceButton oneBtn;
        private Guna.UI.WinForms.GunaAdvenceButton plusBtn;
        private Guna.UI.WinForms.GunaAdvenceButton threeBtn;
        private Guna.UI.WinForms.GunaAdvenceButton fiveBtn;
        private Guna.UI.WinForms.GunaAdvenceButton fourBtn;
        private Guna.UI.WinForms.GunaAdvenceButton minusBtn;
        private Guna.UI.WinForms.GunaAdvenceButton sixBtn;
        private Guna.UI.WinForms.GunaAdvenceButton eightBtn;
        private Guna.UI.WinForms.GunaAdvenceButton sevenBtn;
        private Guna.UI.WinForms.GunaAdvenceButton multiBtn;
        private Guna.UI.WinForms.GunaAdvenceButton nineBtn;
        private Guna.UI.WinForms.GunaAdvenceButton x2Btn;
        private Guna.UI.WinForms.GunaAdvenceButton oneXBtn;
        private Guna.UI.WinForms.GunaAdvenceButton divisionBtn;
        private Guna.UI.WinForms.GunaAdvenceButton sqrtBtn;
        private Guna.UI.WinForms.GunaAdvenceButton clearInputBtn;
        private Guna.UI.WinForms.GunaAdvenceButton percentBtn;
        private Guna.UI.WinForms.GunaAdvenceButton backspaceBtn;
        private Guna.UI.WinForms.GunaAdvenceButton clearBtn;
        public Guna.UI2.WinForms.Guna2TextBox input;
        public System.Windows.Forms.Label displayCalculate;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel leftPanel;
        private System.Windows.Forms.Panel panel3;
        private Guna.UI.WinForms.GunaAdvenceButton menuIcon;
        private Guna.UI.WinForms.GunaAdvenceButton gunaAdvenceButton1;
        private System.Windows.Forms.Label titleHeader;
        private Guna.UI.WinForms.GunaAdvenceButton historyIcon;
        public Guna.UI.WinForms.GunaShadowPanel sidebarChild;
        private SidebarItem sidebarItem1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel5;
        private Guna.UI.WinForms.GunaAdvenceButton gunaAdvenceButton2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private Guna.UI.WinForms.GunaAdvenceButton openMemoryBtn;
        private Guna.UI.WinForms.GunaAdvenceButton msBtn;
        private Guna.UI.WinForms.GunaAdvenceButton mMinusBtn;
        private Guna.UI.WinForms.GunaAdvenceButton mPlusBtn;
        private Guna.UI.WinForms.GunaAdvenceButton mrBtn;
        private Guna.UI.WinForms.GunaAdvenceButton mcBtn;
        private System.Windows.Forms.Timer memoryCheck;
    }
}