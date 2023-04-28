using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Words
{
    public partial class RightAnswer : Form
    {
        float time;

        public RightAnswer(string answer)
        {
            InitializeComponent();
            textBox_expression.Text = answer;

            timer.Enabled = true;
            time = 50;
        }

        private void _KeyDown(KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                timer.Enabled = false;
                Close();
            }
        }

        private void RightAnswer_KeyDown(object sender, KeyEventArgs e)
        {
            _KeyDown(e);
        }

        private void textBox_expression_KeyDown(object sender, KeyEventArgs e)
        {
            _KeyDown(e);
        }

        private void button_OK_KeyDown(object sender, KeyEventArgs e)
        {
            _KeyDown(e);
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            time--;

            if (time < 10)
            {
                Opacity = (float)time / 10;
            }

            if (time == 0)
            {
                timer.Enabled = false;
                Close();
            }
        }
    }
}
