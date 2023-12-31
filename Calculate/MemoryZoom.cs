﻿using System;
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
    public partial class MemoryZoom : UserControl
    {
        public Control[] MemoryCtrls;
        public Label label;
        private static MemoryZoom instance;

        public static MemoryZoom Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new MemoryZoom();
                }

                return MemoryZoom.instance;
            }
            private set { MemoryZoom.instance = value; }
        }

        public MemoryZoom()
        {
            InitializeComponent();
            label = label2;
            if (this.panel3.Controls.Count <= 1)
            {
                this.label2.Show();
                this.label2.BringToFront();
                this.clearBtn.Visible = false;
            }
            else
            {
                this.label2.Hide();
                this.label2.SendToBack();
                this.clearBtn.Visible = true;
            }
        }
        public void loadMemoryItem(Control[] MemoryCtrls)
        {
            this.MemoryCtrls = MemoryCtrls;
            panel3.Controls.Clear();
            panel3.Controls.AddRange(this.MemoryCtrls);
        }
        public void memoryValidation()
        {
            if (panel3.Controls.Count == 0)
            {
                label2 = label;
                panel3.Controls.Add(label2);
            }
        }

        public void clearMemory()
        {
            panel3.Controls.Clear();
            memoryValidation();

            this.label2.Show();
            this.label2.BringToFront();
            this.panel3.Controls.Add(this.label2);
            this.clearBtn.Visible = false;
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            this.panel3.Controls.Clear();
            this.label2.Show();
            this.label2.BringToFront();
            this.panel3.Controls.Add(this.label2);
            this.clearBtn.Visible = false;
        }

        private void Memory_Load(object sender, EventArgs e)
        {
            memoryValidation();

            if (this.panel3.Controls.Count == 1)
            {
                this.label2.Show();
                this.label2.BringToFront();
                this.clearBtn.Visible = false;
            }
            else
            {
                this.label2.Hide();
                this.label2.SendToBack();
                this.clearBtn.Visible = true;
            }
        }
    }
}
