using System;
using System.Drawing;
using System.Windows.Forms;

namespace Calculate
{
    public partial class MemoryItem : UserControl
    {
        private double num, inp = 0;
        private bool hovered= false;
        public MemoryItem(double number)
        {
            InitializeComponent();
            num = number;
            this.label1.Text = $@"{number}";
        }

        public void Mplus(double number)
        {
            label1.Text = $@"{Convert.ToDouble(label1.Text) + number}";
        }

        public void Mminus(double number)
        {
            label1.Text = $@"{Convert.ToDouble(label1.Text) - number}";
        }

        private void panel1_Click(object sender, EventArgs e)
        {
            Calculator.Instance.input.Text = this.label1.Text;
        }

        public void getInput()
        {
            this.inp = inp;
        }

        private void mPlusBtn_Click(object sender, EventArgs e)
        {
            label1.Text = $@"{Convert.ToDouble(label1.Text) + inp}";
        }

        private void mMinusBtn_Click(object sender, EventArgs e)
        {
            label1.Text = $@"{Convert.ToDouble(label1.Text) - inp}";
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (!hovered)
            {
                this.panel1.BackColor = Color.Transparent;
                mcBtn.Visible = false;
                mPlusBtn.Visible = false;
                mMinusBtn.Visible = false;

            } else
            {
                this.panel1.BackColor = ColorTranslator.FromHtml("#EAEAEA");
                mcBtn.Visible = true;
                mPlusBtn.Visible = true;
                mMinusBtn.Visible = true;
            }
        }

        private void mcBtn_MouseLeave(object sender, EventArgs e)
        {
            hovered = false;
        }

        private void mcBtn_MouseEnter(object sender, EventArgs e)
        {
            hovered = true;
        }

        private void MemoryItem_MouseMove(object sender, MouseEventArgs e)
        {
            Control ctr = sender as Control;
            if (ctr.Name.Equals("panel1")  || ctr.Name.Equals("mcBtn") || ctr.Name.Equals("mPlusBtn") || ctr.Name.Equals("mMinusBtn"))
            {
                hovered = true;
            } else
            {
                hovered = false;
            }
        }
    }
}
