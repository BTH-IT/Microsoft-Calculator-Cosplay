using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculate
{
    public partial class Memory : UserControl
    {
        public Control[] MemoryCtrls;
        public System.Windows.Forms.Label label;

        public Memory()
        {
            InitializeComponent();
            label = label2;
            if (panel3.Controls.Count <= 1)
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
            if (panel3.Controls.Count == 1)
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
