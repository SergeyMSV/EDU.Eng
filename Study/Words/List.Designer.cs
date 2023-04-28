namespace Words
{
    partial class List
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(List));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView_List = new System.Windows.Forms.DataGridView();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton_Add = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton_Edit = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton_Drop = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton_Filter = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton_Find = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton_HTML_Report = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton_WordCards = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton_ListA5 = new System.Windows.Forms.ToolStripButton();
            this.dataGridView_Categories = new System.Windows.Forms.DataGridView();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.panel_categories = new System.Windows.Forms.Panel();
            this.toolStrip_Categories = new System.Windows.Forms.ToolStrip();
            this.toolStripButton_Categories_Back = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton_Categories_Forward = new System.Windows.Forms.ToolStripButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBox_StatusFilter = new System.Windows.Forms.ComboBox();
            this.groupBox_Find = new System.Windows.Forms.GroupBox();
            this.button_FindNext = new System.Windows.Forms.Button();
            this.textBox_Find = new System.Windows.Forms.TextBox();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel_Filter = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel_Count = new System.Windows.Forms.ToolStripStatusLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_List)).BeginInit();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Categories)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panel_categories.SuspendLayout();
            this.toolStrip_Categories.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox_Find.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView_List
            // 
            this.dataGridView_List.AllowUserToAddRows = false;
            this.dataGridView_List.AllowUserToDeleteRows = false;
            this.dataGridView_List.BackgroundColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dataGridView_List.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView_List.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_List.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView_List.Location = new System.Drawing.Point(0, 0);
            this.dataGridView_List.MultiSelect = false;
            this.dataGridView_List.Name = "dataGridView_List";
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dataGridView_List.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView_List.RowTemplate.ReadOnly = true;
            this.dataGridView_List.Size = new System.Drawing.Size(475, 308);
            this.dataGridView_List.TabIndex = 0;
            this.dataGridView_List.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_List_CellDoubleClick);
            this.dataGridView_List.KeyDown += new System.Windows.Forms.KeyEventHandler(this.List_KeyDown);
            this.dataGridView_List.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dataGridView_List_KeyPress);
            this.dataGridView_List.SelectionChanged += new System.EventHandler(this.dataGridView_List_SelectionChanged);
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton_Add,
            this.toolStripButton_Edit,
            this.toolStripButton_Drop,
            this.toolStripButton_Filter,
            this.toolStripButton_Find,
            this.toolStripButton_HTML_Report,
            this.toolStripButton_WordCards,
            this.toolStripButton_ListA5});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolStrip1.Size = new System.Drawing.Size(641, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            this.toolStrip1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.List_KeyDown);
            // 
            // toolStripButton_Add
            // 
            this.toolStripButton_Add.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton_Add.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton_Add.Image")));
            this.toolStripButton_Add.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_Add.Name = "toolStripButton_Add";
            this.toolStripButton_Add.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton_Add.Text = "Add Ctrl+A";
            this.toolStripButton_Add.Click += new System.EventHandler(this.toolStripButton_Add_Click);
            // 
            // toolStripButton_Edit
            // 
            this.toolStripButton_Edit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton_Edit.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton_Edit.Image")));
            this.toolStripButton_Edit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_Edit.Name = "toolStripButton_Edit";
            this.toolStripButton_Edit.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton_Edit.Text = "Correct Ctrl+E";
            this.toolStripButton_Edit.Click += new System.EventHandler(this.toolStripButton_Edit_Click);
            // 
            // toolStripButton_Drop
            // 
            this.toolStripButton_Drop.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton_Drop.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton_Drop.Image")));
            this.toolStripButton_Drop.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_Drop.Name = "toolStripButton_Drop";
            this.toolStripButton_Drop.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton_Drop.Text = "Delete Ctrl+D";
            this.toolStripButton_Drop.Click += new System.EventHandler(this.toolStripButton_Drop_Click);
            // 
            // toolStripButton_Filter
            // 
            this.toolStripButton_Filter.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton_Filter.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton_Filter.Image")));
            this.toolStripButton_Filter.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_Filter.Name = "toolStripButton_Filter";
            this.toolStripButton_Filter.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton_Filter.Text = "Filter Ctrl+T";
            this.toolStripButton_Filter.Click += new System.EventHandler(this.toolStripButton_Filter_Click);
            // 
            // toolStripButton_Find
            // 
            this.toolStripButton_Find.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton_Find.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton_Find.Image")));
            this.toolStripButton_Find.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_Find.Name = "toolStripButton_Find";
            this.toolStripButton_Find.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton_Find.Text = "Find Ctrl+F";
            this.toolStripButton_Find.Visible = false;
            this.toolStripButton_Find.Click += new System.EventHandler(this.toolStripButton_Find_Click);
            // 
            // toolStripButton_HTML_Report
            // 
            this.toolStripButton_HTML_Report.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton_HTML_Report.Image = global::Words.Properties.Resources.floppy;
            this.toolStripButton_HTML_Report.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_HTML_Report.Name = "toolStripButton_HTML_Report";
            this.toolStripButton_HTML_Report.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton_HTML_Report.Text = "Export to HTML-Report";
            this.toolStripButton_HTML_Report.Click += new System.EventHandler(this.toolStripButton_HTML_Report_Click);
            // 
            // toolStripButton_WordCards
            // 
            this.toolStripButton_WordCards.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton_WordCards.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton_WordCards.Image")));
            this.toolStripButton_WordCards.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_WordCards.Name = "toolStripButton_WordCards";
            this.toolStripButton_WordCards.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton_WordCards.Text = "Word-Cards";
            this.toolStripButton_WordCards.Click += new System.EventHandler(this.toolStripButton_WordCards_Click);
            // 
            // toolStripButton_ListA5
            // 
            this.toolStripButton_ListA5.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton_ListA5.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton_ListA5.Image")));
            this.toolStripButton_ListA5.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_ListA5.Name = "toolStripButton_ListA5";
            this.toolStripButton_ListA5.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton_ListA5.Text = "for copybook A5";
            this.toolStripButton_ListA5.Click += new System.EventHandler(this.toolStripButton_ListA5_Click);
            // 
            // dataGridView_Categories
            // 
            this.dataGridView_Categories.AllowUserToAddRows = false;
            this.dataGridView_Categories.AllowUserToDeleteRows = false;
            this.dataGridView_Categories.AllowUserToResizeColumns = false;
            this.dataGridView_Categories.AllowUserToResizeRows = false;
            this.dataGridView_Categories.BackgroundColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dataGridView_Categories.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView_Categories.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Categories.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView_Categories.Location = new System.Drawing.Point(0, 25);
            this.dataGridView_Categories.MultiSelect = false;
            this.dataGridView_Categories.Name = "dataGridView_Categories";
            this.dataGridView_Categories.RowHeadersVisible = false;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dataGridView_Categories.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView_Categories.RowTemplate.ReadOnly = true;
            this.dataGridView_Categories.Size = new System.Drawing.Size(158, 182);
            this.dataGridView_Categories.TabIndex = 2;
            this.dataGridView_Categories.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_Categories_CellDoubleClick);
            this.dataGridView_Categories.KeyDown += new System.Windows.Forms.KeyEventHandler(this.List_KeyDown);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 25);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.dataGridView_List);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.panel_categories);
            this.splitContainer1.Panel2.Controls.Add(this.groupBox1);
            this.splitContainer1.Panel2.Controls.Add(this.groupBox_Find);
            this.splitContainer1.Panel2.Padding = new System.Windows.Forms.Padding(0, 0, 4, 0);
            this.splitContainer1.Size = new System.Drawing.Size(641, 308);
            this.splitContainer1.SplitterDistance = 475;
            this.splitContainer1.TabIndex = 3;
            this.splitContainer1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.List_KeyDown);
            // 
            // panel_categories
            // 
            this.panel_categories.Controls.Add(this.dataGridView_Categories);
            this.panel_categories.Controls.Add(this.toolStrip_Categories);
            this.panel_categories.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_categories.Location = new System.Drawing.Point(0, 101);
            this.panel_categories.Name = "panel_categories";
            this.panel_categories.Size = new System.Drawing.Size(158, 207);
            this.panel_categories.TabIndex = 5;
            // 
            // toolStrip_Categories
            // 
            this.toolStrip_Categories.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip_Categories.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton_Categories_Back,
            this.toolStripButton_Categories_Forward});
            this.toolStrip_Categories.Location = new System.Drawing.Point(0, 0);
            this.toolStrip_Categories.Name = "toolStrip_Categories";
            this.toolStrip_Categories.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolStrip_Categories.Size = new System.Drawing.Size(158, 25);
            this.toolStrip_Categories.TabIndex = 3;
            this.toolStrip_Categories.Text = "toolStrip_Categories";
            // 
            // toolStripButton_Categories_Back
            // 
            this.toolStripButton_Categories_Back.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton_Categories_Back.Enabled = false;
            this.toolStripButton_Categories_Back.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton_Categories_Back.Image")));
            this.toolStripButton_Categories_Back.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_Categories_Back.Name = "toolStripButton_Categories_Back";
            this.toolStripButton_Categories_Back.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton_Categories_Back.Text = "Back";
            this.toolStripButton_Categories_Back.Click += new System.EventHandler(this.toolStripButton_Categories_Back_Click);
            // 
            // toolStripButton_Categories_Forward
            // 
            this.toolStripButton_Categories_Forward.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton_Categories_Forward.Enabled = false;
            this.toolStripButton_Categories_Forward.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton_Categories_Forward.Image")));
            this.toolStripButton_Categories_Forward.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_Categories_Forward.Name = "toolStripButton_Categories_Forward";
            this.toolStripButton_Categories_Forward.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton_Categories_Forward.Text = "Forward";
            this.toolStripButton_Categories_Forward.Click += new System.EventHandler(this.toolStripButton_Categories_Forward_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboBox_StatusFilter);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 51);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(158, 50);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Status filter";
            // 
            // comboBox_StatusFilter
            // 
            this.comboBox_StatusFilter.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox_StatusFilter.FormattingEnabled = true;
            this.comboBox_StatusFilter.Location = new System.Drawing.Point(6, 19);
            this.comboBox_StatusFilter.Name = "comboBox_StatusFilter";
            this.comboBox_StatusFilter.Size = new System.Drawing.Size(144, 21);
            this.comboBox_StatusFilter.TabIndex = 0;
            this.comboBox_StatusFilter.SelectedIndexChanged += new System.EventHandler(this.comboBox_StatusFilter_SelectedIndexChanged);
            // 
            // groupBox_Find
            // 
            this.groupBox_Find.Controls.Add(this.button_FindNext);
            this.groupBox_Find.Controls.Add(this.textBox_Find);
            this.groupBox_Find.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox_Find.Location = new System.Drawing.Point(0, 0);
            this.groupBox_Find.Name = "groupBox_Find";
            this.groupBox_Find.Size = new System.Drawing.Size(158, 51);
            this.groupBox_Find.TabIndex = 0;
            this.groupBox_Find.TabStop = false;
            this.groupBox_Find.Text = "Find";
            // 
            // button_FindNext
            // 
            this.button_FindNext.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_FindNext.Image = global::Words.Properties.Resources.find16;
            this.button_FindNext.Location = new System.Drawing.Point(127, 17);
            this.button_FindNext.Name = "button_FindNext";
            this.button_FindNext.Size = new System.Drawing.Size(23, 23);
            this.button_FindNext.TabIndex = 2;
            this.button_FindNext.UseVisualStyleBackColor = true;
            this.button_FindNext.Click += new System.EventHandler(this.button_FindNext_Click);
            // 
            // textBox_Find
            // 
            this.textBox_Find.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_Find.Location = new System.Drawing.Point(6, 19);
            this.textBox_Find.Name = "textBox_Find";
            this.textBox_Find.Size = new System.Drawing.Size(115, 20);
            this.textBox_Find.TabIndex = 1;
            this.textBox_Find.TextChanged += new System.EventHandler(this.textBox_Find_TextChanged);
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripStatusLabel_Filter,
            this.toolStripStatusLabel2,
            this.toolStripStatusLabel_Count});
            this.statusStrip.Location = new System.Drawing.Point(0, 333);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(641, 22);
            this.statusStrip.TabIndex = 4;
            this.statusStrip.Text = "statusStrip1";
            this.statusStrip.KeyDown += new System.Windows.Forms.KeyEventHandler(this.List_KeyDown);
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(35, 17);
            this.toolStripStatusLabel1.Text = "Filter:";
            // 
            // toolStripStatusLabel_Filter
            // 
            this.toolStripStatusLabel_Filter.Name = "toolStripStatusLabel_Filter";
            this.toolStripStatusLabel_Filter.Size = new System.Drawing.Size(32, 17);
            this.toolStripStatusLabel_Filter.Text = "None";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(40, 17);
            this.toolStripStatusLabel2.Text = "Count:";
            // 
            // toolStripStatusLabel_Count
            // 
            this.toolStripStatusLabel_Count.Name = "toolStripStatusLabel_Count";
            this.toolStripStatusLabel_Count.Size = new System.Drawing.Size(13, 17);
            this.toolStripStatusLabel_Count.Text = "0";
            // 
            // List
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(641, 355);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.statusStrip);
            this.Name = "List";
            this.ShowInTaskbar = false;
            this.Text = "List";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.List_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_List)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Categories)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.ResumeLayout(false);
            this.panel_categories.ResumeLayout(false);
            this.panel_categories.PerformLayout();
            this.toolStrip_Categories.ResumeLayout(false);
            this.toolStrip_Categories.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox_Find.ResumeLayout(false);
            this.groupBox_Find.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_List;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton_Add;
        private System.Windows.Forms.DataGridView dataGridView_Categories;
        private System.Windows.Forms.ToolStripButton toolStripButton_Filter;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ToolStripButton toolStripButton_Drop;
        private System.Windows.Forms.ToolStripButton toolStripButton_Edit;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel_Filter;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel_Count;
        private System.Windows.Forms.ToolStripButton toolStripButton_Find;
        private System.Windows.Forms.ToolStripButton toolStripButton_HTML_Report;
        private System.Windows.Forms.ToolStrip toolStrip_Categories;
        private System.Windows.Forms.ToolStripButton toolStripButton_Categories_Back;
        private System.Windows.Forms.ToolStripButton toolStripButton_Categories_Forward;
        private System.Windows.Forms.ToolStripButton toolStripButton_WordCards;
        private System.Windows.Forms.Panel panel_categories;
        private System.Windows.Forms.GroupBox groupBox_Find;
        private System.Windows.Forms.Button button_FindNext;
        private System.Windows.Forms.TextBox textBox_Find;
        private System.Windows.Forms.ToolStripButton toolStripButton_ListA5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox comboBox_StatusFilter;
    }
}