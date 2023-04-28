using System;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Words
{
    public partial class List : Form
    {
        public class ListDataProperty
        {
            public ArrayList Property = new ArrayList();
        }

        Stack _CategoriesBack = new Stack();
        Stack _CategoriesForward = new Stack();

        ArrayList _data;

        string _listSortedColumnName = "";
        SortOrder _listSortOrder;

        Configuration config = new Configuration();

        Find _findDlg = new Find();

        ListFilter _dictFilter;

        public List()
        {
            InitializeComponent();

            button_FindNext.Enabled = false;

            InitiallingDictionaryFilter();
            InitiallingStatusFilter();

            _findDlg.EventUpdate += new Find.findUpdate(_findDlg_EventUpdate);
        }

        #region loading data
        private void _Load()
        {
            int _positionInList = 0;

            if (dataGridView_List.SelectedCells.Count > 0)
                _positionInList = dataGridView_List.SelectedCells[0].RowIndex;

            if (_dictFilter.SelectedItems.Count > 0)
            {
                if (_dictFilter.SelectedItems.Count == 1)
                    toolStripStatusLabel_Filter.Text = _dictFilter.SelectedItems[0].ToString();
                else
                    toolStripStatusLabel_Filter.Text = "Complex";
            }
            else
                toolStripStatusLabel_Filter.Text = "Inactive";

            try
            {
                _listSortedColumnName = dataGridView_List.SortedColumn.Name;
                _listSortOrder = dataGridView_List.SortOrder;
            }
            catch { }

            Dictionary dict = new Dictionary();
            _data = dict.GetItems();

            DataTable dataTable = new DataTable();

            dataTable.Columns.Add("Expression");
            dataTable.Columns.Add("Comment on the expression");
            dataTable.Columns.Add("Translation");
            dataTable.Columns.Add("Comment on the translation");
            dataTable.Columns.Add("Status");
            dataTable.Columns.Add("Counter");
            dataTable.Columns.Add("Index");

            int index = 0;

            foreach (DictionaryItem item in _data)
            {
                bool addRow = DictionaryFilter_CheckProperties(item);

                if (StatusFilter_CheckProperties(item) == false)
                    addRow = false;

                if (addRow == true)
                {
                    DataRow row = dataTable.NewRow();

                    row["Expression"] = item.Expression;
                    row["Comment on the expression"] = item.CommentExpression;
                    row["Translation"] = item.Translation;
                    row["Comment on the translation"] = item.CommentTranslation;
                    row["Status"] = item.Status;
                    row["Counter"] = item.Counter;

                    row["Index"] = index.ToString();

                    dataTable.Rows.Add(row);
                }

                index++;
            }

            dataGridView_List.DataSource = dataTable;

            dataGridView_List.Columns["Index"].Visible = false;
            //-dataGridView_List.Columns["Status"].Visible = false;
            dataGridView_List.Columns["Counter"].Visible = false;

            foreach (DataGridViewColumn col in dataGridView_List.Columns)
            {
                if (_listSortedColumnName == col.Name)
                {
                    switch (_listSortOrder)
                    {
                        case SortOrder.Ascending:
                            dataGridView_List.Sort(col, ListSortDirection.Ascending);
                            break;
                        case SortOrder.Descending:
                            dataGridView_List.Sort(col, ListSortDirection.Descending);
                            break;
                        default: break;
                    }
                }
            }

            toolStripStatusLabel_Count.Text = dataGridView_List.Rows.Count.ToString();

            if (_positionInList > dataGridView_List.Rows.Count - 1)
                _positionInList = dataGridView_List.Rows.Count - 1;

            if (dataGridView_List.Rows.Count > 0 && _positionInList == -1)
                _positionInList = 0;

            try
            {
                dataGridView_List.Rows[_positionInList].Cells[0].Selected = true;
                ShowCategory(Convert.ToInt32(dataGridView_List["index", dataGridView_List.SelectedCells[0].RowIndex].Value));
            }
            catch
            {
                try
                {
                    ((DataTable)dataGridView_Categories.DataSource).Rows.Clear();
                }
                catch { }
            }
        }
        #endregion

        private void ShowCategory(int index)
        {
            DataTable dataTable_Categories = new DataTable();
            dataTable_Categories.Columns.Add("Categories");

            foreach (string item in ((DictionaryItem)_data[index]).Properties)
            {
                DataRow row = dataTable_Categories.NewRow();

                row["Categories"] = item;

                dataTable_Categories.Rows.Add(row);
            }

            dataGridView_Categories.DataSource = dataTable_Categories;
            dataGridView_Categories.Columns["Categories"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        private void Add()
        {
            Card card = new Card(_dictFilter.SelectedItems);
            card.ShowDialog();
            _Load();
        }

        private void toolStripButton_Add_Click(object sender, EventArgs e)
        {
            Add();
        }

        private void EditItem()
        {
            if (dataGridView_List.SelectedCells.Count != 0)
            {
                Card card = new Card((object)_data[Convert.ToInt32(dataGridView_List["index", dataGridView_List.SelectedCells[0].RowIndex].Value)]);
                card.ShowDialog();
                _Load();
            }
        }

        private void dataGridView_List_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0) return;

            EditItem();
        }

        private void toolStripButton_Edit_Click(object sender, EventArgs e)
        {
            EditItem();
        }

        private void dataGridView_List_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                ShowCategory(Convert.ToInt32(dataGridView_List["index", dataGridView_List.SelectedCells[0].RowIndex].Value));
            }
            catch { }
         }

        private void Drop()
        {
            if (DialogResult.Yes == MessageBox.Show("Are you sure that you want to delete this entry?", "Confirmation", MessageBoxButtons.YesNo))
            {

                Dictionary dict = new Dictionary();

                dict.RemoveItem((DictionaryItem)_data[Convert.ToInt32(dataGridView_List["index", dataGridView_List.SelectedCells[0].RowIndex].Value)]);
                _Load();
            }
        }

        private void toolStripButton_Drop_Click(object sender, EventArgs e)
        {
            Drop();
        }

        #region keys
        private bool _keyDownIsHandled = false;
        private void List_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Modifiers == Keys.Control)
            {
                switch(e.KeyCode)
                {
                    case Keys.A:
                        Add();
                        break;
                    case Keys.E:
                        EditItem();
                        break;
                    case Keys.D:
                        Drop();
                        break;
                    case Keys.F:
                        if (textBox_Find.Text != "")
                            _findDlg_EventUpdate(textBox_Find.Text);
                        else
                            textBox_Find.Focus();
                       
                        break;
                    case Keys.S:
                        comboBox_StatusFilter.Focus();
                        break;
                    case Keys.T:
                        DictionaryFilter();
                        break;
                }
            }
            else if (e.KeyCode == Keys.Enter)
            {
                e.Handled = true;
                EditItem();
            }

            if (e.Control == true ||
                e.Alt == true ||
                e.KeyCode == Keys.Enter ||
                e.KeyCode == Keys.Escape)
            {
                _keyDownIsHandled = true;
            }
            else
                _keyDownIsHandled = false;
        }
        #endregion

        #region simple HTML-report
        private void toolStripButton_HTML_Report_Click(object sender, EventArgs e)
        {
            //string path = @"Report.html";
            string path = toolStripStatusLabel_Filter.Text + ".html";
            string report = "";

            report += "<HTML>\xd\xa<meta http-equiv=\"Content-Type\" content=\"text/html; charset=Windows-1251\">\xd\xa<HEAD></HEAD>\xd\xa<BODY>";

            foreach (DataGridViewRow row in dataGridView_List.Rows)
            {
                report += "<B>";
                report += row.Cells["Expression"].Value.ToString();
                report += "</B>";
                report += " - ";
                report += row.Cells["Translation"].Value.ToString();
                report += "<BR>";

                report += "<I>";
                if (row.Cells["Comment on the expression"].Value.ToString() != "")
                {
                    report += row.Cells["Comment on the expression"].Value.ToString().Replace("\r\n", "<BR>");
                    report += "<BR>";
                }
                if (row.Cells["Comment on the translation"].Value.ToString() != "")
                {
                    report += row.Cells["Comment on the translation"].Value.ToString().Replace("\r\n", "<BR>");
                    report += "<BR>";
                }
                report += "</I>";
            }


            report += "</BODY>\xd\xa</HTML>";

            if (File.Exists(path))
                File.Delete(path);

            File.AppendAllText(path, report, System.Text.ASCIIEncoding.Default);
        }
        #endregion

        #region reports word-cards and format A5
        private void toolStripButton_WordCards_Click(object sender, EventArgs e)
        {
            //Report _reportDlg = new Report(GetSortedDataTableFrom_dataGridView_List());
            //_reportDlg.Show();
        }

        private void toolStripButton_ListA5_Click(object sender, EventArgs e)
        {
            //Report _reportDlg = new Report(new WordsA5(), GetSortedDataTableFrom_dataGridView_List());
            //_reportDlg.Show();
        }

        private DataTable GetSortedDataTableFrom_dataGridView_List()
        {
            if (dataGridView_List.SortedColumn != null)
            {
                string prms = dataGridView_List.SortedColumn.Name;

                if (dataGridView_List.SortOrder == SortOrder.Ascending)
                    prms += " ASC";
                else if (dataGridView_List.SortOrder == SortOrder.Descending)
                    prms += " DESC";

                return ((DataTable)dataGridView_List.DataSource).Select("", prms).CopyToDataTable().Copy();
            }

            return ((DataTable)dataGridView_List.DataSource).Copy();
        }

        #endregion

        #region find
        private void button_FindNext_Click(object sender, EventArgs e)
        {
            _findDlg_EventUpdate(textBox_Find.Text);
        }
        private void textBox_Find_TextChanged(object sender, EventArgs e)
        {
            _findDlg_EventUpdate(textBox_Find.Text);

            button_FindNext.Enabled = textBox_Find.Text != "";
        }
        private void toolStripButton_Find_Click(object sender, EventArgs e)
        {
            _findDlg.Show();
        }

        Point _findStrIndex;
        Point _findStrLastPosition;
        string _findStr;
        private void _findDlg_EventUpdate(string str)
        {
            Utils.DataGrigView_FindStringInCells(dataGridView_List, 4, ref _findStrIndex, ref _findStrLastPosition, ref _findStr, str);
        }

        int _findCharIndex;
        int _findLastPosition;
        char _findChar;
        private void dataGridView_List_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;

            if (_keyDownIsHandled == false)
                Utils.DataGrigView_FindFirstSymbolInCell(dataGridView_List, ref _findCharIndex, ref _findLastPosition, ref _findChar, e.KeyChar);
        }
        #endregion

        #region dictionary filter
        private void InitiallingDictionaryFilter()
        {
            _dictFilter = new ListFilter(config.GetProperties("card", "categories"));
        }
        private void DictionaryFilter()
        {
            ArrayList prevList = new ArrayList(_dictFilter.SelectedItems);

            _dictFilter.ShowDialog();

            if (ArrayList_Equals(prevList, _dictFilter.SelectedItems) == false)
                DictionaryFilter_PushBack(prevList);

            _Load();
        }
        private bool DictionaryFilter_CheckProperties(DictionaryItem item)
        {
            if (_dictFilter.SelectedItems.Count != 0) // show all of them
            {
                foreach (string pr in item.Properties)
                {
                    foreach (string cat in _dictFilter.SelectedItems)
                    {
                        if (pr == cat) return true;
                    }
                }
            }
            else
                return true;

            return false;
        }

        private void dataGridView_Categories_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0) return;

            ArrayList prevFilter = new ArrayList(_dictFilter.SelectedItems);

            _dictFilter.SelectItem = dataGridView_Categories.SelectedCells[0].Value.ToString();

            if (ArrayList_Equals(prevFilter, _dictFilter.SelectedItems) == false)
            {
                _CategoriesBack.Push(new ArrayList(prevFilter));
                toolStripButton_Categories_Back.Enabled = true;

                _CategoriesForward.Clear();
                toolStripButton_Categories_Forward.Enabled = false;
            }

            _Load();
        }

        private void DictionaryFilter_PushBack(ArrayList list)
        {
            _CategoriesBack.Push(new ArrayList(list));
            toolStripButton_Categories_Back.Enabled = true;

            _CategoriesForward.Clear();
            toolStripButton_Categories_Forward.Enabled = false;
        }

        private void toolStripButton_Categories_Back_Click(object sender, EventArgs e)
        {
            _CategoriesForward.Push(new ArrayList(_dictFilter.SelectedItems));
            toolStripButton_Categories_Forward.Enabled = true;

            _dictFilter.SelectedItems = (ArrayList)_CategoriesBack.Pop();

            if (_CategoriesBack.Count == 0)
                toolStripButton_Categories_Back.Enabled = false;

            _Load();
        }

        private void toolStripButton_Categories_Forward_Click(object sender, EventArgs e)
        {
            _CategoriesBack.Push(new ArrayList(_dictFilter.SelectedItems));
            toolStripButton_Categories_Back.Enabled = true;

            _dictFilter.SelectedItems = (ArrayList)_CategoriesForward.Pop();

            if (_CategoriesForward.Count == 0)
                toolStripButton_Categories_Forward.Enabled = false;

            _Load();
        }
        #endregion

        #region status filter
        private void InitiallingStatusFilter()
        {
            comboBox_StatusFilter.Items.Add("All");
            comboBox_StatusFilter.Items.AddRange(config.GetProperties("card", "status").ToArray());

            comboBox_StatusFilter.Text = comboBox_StatusFilter.Items[0].ToString();
        }
        private void comboBox_StatusFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            _Load();
        }
        private bool StatusFilter_CheckProperties(DictionaryItem item)
        {
            return comboBox_StatusFilter.Text == "All" || comboBox_StatusFilter.Text == item.Status;
        }

        private void toolStripButton_Filter_Click(object sender, EventArgs e)
        {
            DictionaryFilter();
        }
        #endregion

        #region additional functions
        private bool ArrayList_Equals(ArrayList a, ArrayList b)
        {
            bool equal = false;

            if (a.Count == b.Count)
            {
                equal = true;

                for (int i = 0; i < a.Count; i++)
                {
                    if (a[i].Equals(b[i]) == false)
                    {
                        equal = false;
                        break;
                    }
                }
            }

            return equal;
        }
        #endregion
    }
}
