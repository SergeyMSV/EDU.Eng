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
    public partial class Find : Form
    {
        public delegate void findUpdate(string str);
        public event findUpdate EventUpdate;

        public Find()
        {
            InitializeComponent();
        }

        private void textBox_TextChanged(object sender, EventArgs e)
        {
            if (EventUpdate != null)
                EventUpdate(textBox.Text);

            button_FindNext.Enabled = textBox.Text != "";
        }

        private void button_Cancel_Click(object sender, EventArgs e)
        {
            Visible = false;
        }

        private void button_FindNext_Click(object sender, EventArgs e)
        {
            if (EventUpdate != null)
                EventUpdate(textBox.Text);
        }

        private void Find_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            Visible = false;
        }

        private void Find_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                e.Handled = true;
                Visible = false;
            }
            else if (e.KeyCode == Keys.F3)
            {
                if (EventUpdate != null)
                    EventUpdate(textBox.Text);
            }
        }
    }
}
