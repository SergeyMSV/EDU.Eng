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
    public partial class ListFilter : Form
    {
        private ArrayList _selectedItems = new ArrayList();

        public ListFilter(ArrayList listOfItems)
        {
            InitializeComponent();

            Configuration conf = new Configuration();
            ArrayList categories = conf.GetProperties("card", "categories");

            checkedListBox_Dictionaries.Items.AddRange(listOfItems.ToArray());
        }

        public ArrayList SelectedItems
        {
            get
            {
                return _selectedItems;
            }
            set
            {
                _selectedItems.Clear();
                _selectedItems.AddRange(value);
            }
        }

        public string SelectItem
        {
            set
            {
                _selectedItems.Clear();
                _selectedItems.Add(value);
                checkedListBox_Dictionaries.SelectedItem = value;
            }
        }

        private void Cancel()
        {
            _selectedItems.Clear();

            Visible = false;
            //Close();
        }

        private void OK()
        {
            _selectedItems.Clear();
            _selectedItems.AddRange(checkedListBox_Dictionaries.CheckedItems);

            Visible = false;
            //Close();
        }

        private void button_Cancel_Click(object sender, EventArgs e)
        {
            Cancel();
        }

        private void button_Apply_Click(object sender, EventArgs e)
        {
            OK();
        }

        private void ListFilter_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Enter:
                    OK();
                    break;
                case Keys.Escape:
                    Cancel();
                    break;
                default: break;
            }
        }

        private void ListFilter_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            Visible = false;
        }
    }
}
