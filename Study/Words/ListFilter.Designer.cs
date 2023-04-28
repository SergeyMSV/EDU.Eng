namespace Words
{
    partial class ListFilter
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button_Apply = new System.Windows.Forms.Button();
            this.button_Cancel = new System.Windows.Forms.Button();
            this.checkedListBox_Dictionaries = new System.Windows.Forms.CheckedListBox();
            this.panel_List = new System.Windows.Forms.Panel();
            this.panel_buttons = new System.Windows.Forms.Panel();
            this.panel_List.SuspendLayout();
            this.panel_buttons.SuspendLayout();
            this.SuspendLayout();
            // 
            // button_Apply
            // 
            this.button_Apply.Location = new System.Drawing.Point(145, 10);
            this.button_Apply.Name = "button_Apply";
            this.button_Apply.Size = new System.Drawing.Size(75, 23);
            this.button_Apply.TabIndex = 2;
            this.button_Apply.Text = "&OK";
            this.button_Apply.UseVisualStyleBackColor = true;
            this.button_Apply.Click += new System.EventHandler(this.button_Apply_Click);
            this.button_Apply.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ListFilter_KeyDown);
            // 
            // button_Cancel
            // 
            this.button_Cancel.Location = new System.Drawing.Point(226, 10);
            this.button_Cancel.Name = "button_Cancel";
            this.button_Cancel.Size = new System.Drawing.Size(75, 23);
            this.button_Cancel.TabIndex = 3;
            this.button_Cancel.Text = "&Cancel";
            this.button_Cancel.UseVisualStyleBackColor = true;
            this.button_Cancel.Click += new System.EventHandler(this.button_Cancel_Click);
            this.button_Cancel.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ListFilter_KeyDown);
            // 
            // checkedListBox_Dictionaries
            // 
            this.checkedListBox_Dictionaries.Dock = System.Windows.Forms.DockStyle.Fill;
            this.checkedListBox_Dictionaries.FormattingEnabled = true;
            this.checkedListBox_Dictionaries.Location = new System.Drawing.Point(4, 4);
            this.checkedListBox_Dictionaries.Name = "checkedListBox_Dictionaries";
            this.checkedListBox_Dictionaries.Size = new System.Drawing.Size(309, 184);
            this.checkedListBox_Dictionaries.TabIndex = 4;
            this.checkedListBox_Dictionaries.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ListFilter_KeyDown);
            // 
            // panel_List
            // 
            this.panel_List.Controls.Add(this.checkedListBox_Dictionaries);
            this.panel_List.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_List.Location = new System.Drawing.Point(0, 0);
            this.panel_List.Name = "panel_List";
            this.panel_List.Padding = new System.Windows.Forms.Padding(4);
            this.panel_List.Size = new System.Drawing.Size(317, 193);
            this.panel_List.TabIndex = 5;
            // 
            // panel_buttons
            // 
            this.panel_buttons.Controls.Add(this.button_Cancel);
            this.panel_buttons.Controls.Add(this.button_Apply);
            this.panel_buttons.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel_buttons.Location = new System.Drawing.Point(0, 193);
            this.panel_buttons.Name = "panel_buttons";
            this.panel_buttons.Size = new System.Drawing.Size(317, 43);
            this.panel_buttons.TabIndex = 6;
            // 
            // ListFilter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(317, 236);
            this.Controls.Add(this.panel_List);
            this.Controls.Add(this.panel_buttons);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ListFilter";
            this.ShowInTaskbar = false;
            this.Text = "List filter";
            this.TopMost = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ListFilter_FormClosing);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ListFilter_KeyDown);
            this.panel_List.ResumeLayout(false);
            this.panel_buttons.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_Apply;
        private System.Windows.Forms.Button button_Cancel;
        private System.Windows.Forms.CheckedListBox checkedListBox_Dictionaries;
        private System.Windows.Forms.Panel panel_List;
        private System.Windows.Forms.Panel panel_buttons;
    }
}