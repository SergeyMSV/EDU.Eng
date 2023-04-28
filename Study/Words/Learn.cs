using System;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Words
{
    public partial class Learn : Form
    {
        string _activeDictionary = "";
        string _activeColumn = "";
        bool _Learn;
        int _displayIndex;
        int _time;
        Color _textbox_transmittionPrevBackColor;

        public Learn(string dictionary, bool eng, bool learn)
        {
            InitializeComponent();

            dataGridView.CellFormatting += new DataGridViewCellFormattingEventHandler(dataGridView_CellFormatting);

            _activeDictionary = dictionary;
            _Learn = learn;


            if (eng == true)
                _activeColumn = "Expression";
            else
                _activeColumn = "Translation";

            _Load();

            DisplayItem(false);
        }

        private void _Load()
        {
            Dictionary dict = new Dictionary();
            ArrayList data = dict.GetItems();

            DataTable dataTable = new DataTable();

            dataTable.Columns.Add("Expression");
            dataTable.Columns.Add("Comment on the expression");
            dataTable.Columns.Add("Translation");
            dataTable.Columns.Add("Comment on the translation");
            dataTable.Columns.Add("Status");
            dataTable.Columns.Add("Counter");
            dataTable.Columns.Add("Index");

            dataGridView.DataSource = dataTable;

            foreach (DictionaryItem item in data)
            {
                foreach (string st in item.Properties)
                {
                    if (st == _activeDictionary)
                    {
                        DataRow row = dataTable.NewRow();

                        row["Expression"] = item.Expression;
                        row["Comment on the expression"] = item.CommentExpression;
                        row["Translation"] = item.Translation;
                        row["Comment on the translation"] = item.CommentTranslation;
                        row["Status"] = item.Status;
                        row["Counter"] = item.Counter;

                        dataTable.Rows.Add(row);
                        break;
                    }
                }
            }

            foreach (DataGridViewColumn cl in dataGridView.Columns)
            {
                if (cl.Name == _activeColumn)
                {
                    cl.Visible = true;
                    cl.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                }
                else
                    cl.Visible = false;
            }
        }

        void dataGridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView.Rows)
            {
                if (row.Cells["Status"].Value.ToString() != "Active")
                {
                    //row.Cells[_activeColumn].Style.BackColor = Color.LightGray;
                    row.Cells[_activeColumn].Style.ForeColor = Color.Gray;
                }
            }
        }

        private void DisplayItem(bool next)
        {
            if (next == true)
            {
                for (int i = 0; i < dataGridView.Rows.Count; i++)
                {
                    _displayIndex++;

                    if (dataGridView.Rows.Count <= _displayIndex)
                        _displayIndex = 0;

                    if (dataGridView.Rows[_displayIndex].Cells["Status"].Value.ToString() == "Active")
                    {
                        foreach (DataGridViewRow row in dataGridView.Rows)
                            row.Selected = false;

                        dataGridView.Rows[_displayIndex].Selected = true;
                        dataGridView.CurrentCell = dataGridView[_activeColumn, dataGridView.Rows[_displayIndex].Index];
                        break;
                    }
                }
            }

            try
            {
                if (_activeColumn == "Expression")
                {
                    textBox_expression.Text = dataGridView.Rows[_displayIndex].Cells["Expression"].Value.ToString();
                    textBox_comment.Text = dataGridView.Rows[_displayIndex].Cells["Comment on the expression"].Value.ToString();
                }
                else
                {
                    textBox_expression.Text = dataGridView.Rows[_displayIndex].Cells["Translation"].Value.ToString();
                    textBox_comment.Text = dataGridView.Rows[_displayIndex].Cells["Comment on the translation"].Value.ToString();
                }
            }
            catch
            {
                textBox_expression.Text = "";
                textBox_comment.Text = "";

                _displayIndex = 0;
                textBox_expression.Clear();
            }

            textBox_translation.Clear();
            textBox_translation.Focus();
        }

        private void Check()
        {
            if (dataGridView.Rows.Count == 0) return;

            string text = textBox_translation.Text.Trim();
            string answer = "";

            for (; ; )
            {
                int index = text.IndexOfAny(" \n\r".ToCharArray());
                if (index == -1)
                {
                    answer += text;
                    break;
                }
                answer += text.Substring(0, index);
                text = text.Substring(index).Trim();
                if (text.Length == 0) break;
                answer += " ";
            }

            if ((_activeColumn == "Expression" && answer.ToLower() == dataGridView.Rows[_displayIndex].Cells["Translation"].Value.ToString().ToLower()) ||
                (_activeColumn == "Translation" && answer.ToLower() == dataGridView.Rows[_displayIndex].Cells["Expression"].Value.ToString().ToLower()))
            {
                timer.Enabled = true;
                _time = 5;

                _textbox_transmittionPrevBackColor = textBox_translation.BackColor;
                textBox_translation.BackColor = Color.Yellow;
            }
            else
            {
                if (_activeColumn == "Expression")
                {
                    RightAnswer dlg = new RightAnswer(dataGridView.Rows[_displayIndex].Cells["Translation"].Value.ToString());
                    dlg.ShowDialog();
                }
                else
                {
                    RightAnswer dlg = new RightAnswer(dataGridView.Rows[_displayIndex].Cells["Expression"].Value.ToString().ToLower());
                    dlg.ShowDialog();
                }

                textBox_translation.Focus();
            }
        }

        private void button_Check_Click(object sender, EventArgs e)
        {
            Check();
        }

        bool _supressKey = false;
        private void textBox_translation_KeyDown(object sender, KeyEventArgs e)
        {
            _supressKey = false;

            if (e.KeyCode == Keys.Escape)
            {
                textBox_translation.Clear();
            }
            else if (e.Modifiers == Keys.Control && e.KeyCode == Keys.Enter)
            {
                _supressKey = true;
                Check();
            }
        }

        private void textBox_translation_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (_supressKey == true)
                e.Handled = true;
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            if (_time == 0)
            {
                textBox_translation.BackColor = _textbox_transmittionPrevBackColor;
                DisplayItem(true);
                textBox_translation.Text = "";
                timer.Enabled = false;
            }
            else
                _time--;
        }

        private void dataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0) return;

            _displayIndex = e.RowIndex;
            DisplayItem(false);
        }

        private void dataGridView_Sorted(object sender, EventArgs e)
        {
            DisplayItem(false);
        }

        private void dataGridView_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                for (int i = 0; i < dataGridView.Rows.Count; i++)
                {
                    if (dataGridView.SelectedCells[0] == dataGridView.Rows[i].Cells[_activeColumn])
                    {
                        e.Handled = true;
                        _displayIndex = i;
                        DisplayItem(false);
                    }
                }
            }
        }

        int _findCharIndex;
        int _findLastPosition;
        char _findChar;
        private void dataGridView_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
            Utils.DataGrigView_FindFirstSymbolInCell(dataGridView, ref _findCharIndex, ref _findLastPosition, ref _findChar, e.KeyChar);
        }
    }
}
