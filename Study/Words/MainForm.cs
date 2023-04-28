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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            SelectionOfDictionary();
        }

        int _positionInList;
        private void SelectionOfDictionary()
        {
            if (dataGridView.SelectedCells.Count > 0)
                _positionInList = dataGridView.SelectedCells[0].RowIndex;

            Configuration conf = new Configuration();
            ArrayList categories = conf.GetProperties("card", "categories");

            DataTable dataTable = new DataTable();

            dataTable.Columns.Add("Dictionary");
            dataTable.Columns.Add("Last time");
            dataTable.Columns.Add("Right");
            dataTable.Columns.Add("Wrong");
            dataTable.Columns.Add("Total");

            dataGridView.DataSource = dataTable;

            foreach (string st in categories)
            {
                DataRow row = dataTable.NewRow();
                row["Dictionary"] = st;
                row["Last time"] = DateTime.Now;
                row["Total"] = 0;
                dataTable.Rows.Add(row);
            }

            Dictionary dict = new Dictionary();
            ArrayList items = dict.GetItems();
            foreach (DictionaryItem item in items)
            {
                foreach (string prop in ((DictionaryItem)item).Properties)
                {
                    foreach (DataGridViewRow row in dataGridView.Rows)
                    {
                        if (row.Cells["Dictionary"].Value.ToString() == prop)
                            row.Cells["Total"].Value = Convert.ToInt32(row.Cells["Total"].Value) + 1;
                    }
                }
            }

            dataGridView.Columns["Last time"].CellTemplate.Style.ForeColor = Color.Gray;
            dataGridView.Columns["Total"].CellTemplate.Style.Alignment = DataGridViewContentAlignment.MiddleRight;

            foreach (DataGridViewColumn cl in dataGridView.Columns)
                cl.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

            if (_positionInList > dataGridView.Rows.Count - 1)
                _positionInList = dataGridView.Rows.Count - 1;

            if (dataGridView.Rows.Count > 0 && _positionInList == -1)
                _positionInList = 0;

            try
            {
                dataGridView.Rows[_positionInList].Cells[0].Selected = true;
            }
            catch { }
        }

        private void button_Dictionary_Click(object sender, EventArgs e)
        {
            List list = new List();
            list.ShowDialog();

            //SelectionOfDictionary(); // [srg] 2010 06 27 it slows closing the dictionary form down
        }

        void SelectDictionady()
        {
            Learn learn = new Learn(dataGridView.Rows[dataGridView.SelectedCells[0].RowIndex].Cells["Dictionary"].Value.ToString(),
                checkBox_Direction.Checked, checkBox_LearnCheck.Checked);
            learn.ShowDialog();
        }

        private void dataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0) return;

            SelectDictionady();
        }

        private void button_Next_Click(object sender, EventArgs e)
        {
            SelectDictionady();
        }

        private void dataGridView_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.Handled = true;
                SelectDictionady();
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
