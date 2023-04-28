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
    public partial class Card : Form
    {
        Configuration config = new Configuration();
        Dictionary dictionary = new Dictionary();

        DictionaryItem _beingReplacedItem;

        public Card()
        {
            InitializeComponent();

            Init();
        }

        public Card(object item)
        {
            InitializeComponent();

            Init((DictionaryItem)item);
        }

        private ArrayList _properties = new ArrayList();

        public Card(ArrayList properties)
        {
            _properties = new ArrayList(properties);

            InitializeComponent();

            Init();
        }

        private void Init()
        {
            textBox_expression.Text = "";
            textBox_translation.Text = "";
            textBox_ExpressionComment.Text = "";
            textBox_TranslationComment.Text = "";
            comboBox_Status.Items.Clear();
            checkedListBox_Category.Items.Clear();

            ArrayList data = config.GetProperties("card", "status");

            foreach (object item in data)
            {
                comboBox_Status.Items.Add(item);
            }

            comboBox_Status.Text = comboBox_Status.Items[0].ToString();

            data = config.GetProperties("card", "categories");

            foreach (object item in data)
            {
                checkedListBox_Category.Items.Add(item);
            }

            for (short i = 0; i < checkedListBox_Category.Items.Count; i++)
            {
                if (_properties.Contains(checkedListBox_Category.Items[i]))
                {
                    checkedListBox_Category.SetItemCheckState(i, CheckState.Checked);
                }
            }

            textBox_expression.Focus();
        }

        private void Init(DictionaryItem Item)
        {
            _beingReplacedItem = (DictionaryItem)Item;

            textBox_expression.Text = Item.Expression;
            textBox_translation.Text = Item.Translation;
            textBox_ExpressionComment.Text = Item.CommentExpression;
            textBox_TranslationComment.Text = Item.CommentTranslation;
            comboBox_Status.Items.Clear();
            checkedListBox_Category.Items.Clear();

            ArrayList data = config.GetProperties("card", "status");

            foreach (object item in data)
            {
                comboBox_Status.Items.Add(item);
            }

            //comboBox_Status.Text = comboBox_Status.Items[0].ToString();

            comboBox_Status.Text = Item.Status;

            data = config.GetProperties("card", "categories");

            foreach (object item in data)
            {
                checkedListBox_Category.Items.Add(item);
            }

            foreach(string pr in Item.Properties)
            {
                int i = 0;
                foreach (string str in checkedListBox_Category.Items)
                {
                    if (pr == str)
                    {
                        checkedListBox_Category.SetItemCheckState(i, CheckState.Checked);
                        break;
                    }
                    i++;
                }
            }
            

            textBox_expression.Focus();
        }

        private DictionaryItem CreateDictionaryItem()
        {
            ArrayList list = new ArrayList();

            foreach (string property in checkedListBox_Category.CheckedItems)
            {
                list.Add(property);
            }

            return new DictionaryItem(textBox_expression.Text, textBox_translation.Text,
                textBox_ExpressionComment.Text, textBox_TranslationComment.Text,
                comboBox_Status.Text, "0", list);
        }

        private void Replace()
        {
            dictionary.ReplaceItem(CreateDictionaryItem(), _beingReplacedItem);
        }

        private void Add()
        {
            if (textBox_expression.Text != "")
            {
                dictionary.AddItem(CreateDictionaryItem());
            }
        }

        private void Apply()
        {
            if (_beingReplacedItem != null)
            {
                Replace();
            }
            else
            {
                Add();
                Init();
            }
        }

        private void button_OK_Click(object sender, EventArgs e)
        {
            Apply();

            Close();
        }

        private void button_Cancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button_Apply_Click(object sender, EventArgs e)
        {
            Apply();
        }

        private void Card_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                Close();
            }
        }
    }
}
