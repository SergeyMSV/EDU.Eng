namespace Words
{
    partial class MainForm
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
            this.button_Dictionary = new System.Windows.Forms.Button();
            this.checkBox_Direction = new System.Windows.Forms.CheckBox();
            this.button_Next = new System.Windows.Forms.Button();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.checkBox_LearnCheck = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // button_Dictionary
            // 
            this.button_Dictionary.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button_Dictionary.Location = new System.Drawing.Point(12, 257);
            this.button_Dictionary.Name = "button_Dictionary";
            this.button_Dictionary.Size = new System.Drawing.Size(75, 23);
            this.button_Dictionary.TabIndex = 5;
            this.button_Dictionary.Text = "&Dictionary...";
            this.button_Dictionary.UseVisualStyleBackColor = true;
            this.button_Dictionary.Click += new System.EventHandler(this.button_Dictionary_Click);
            // 
            // checkBox_Direction
            // 
            this.checkBox_Direction.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBox_Direction.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkBox_Direction.AutoSize = true;
            this.checkBox_Direction.Checked = true;
            this.checkBox_Direction.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_Direction.Location = new System.Drawing.Point(344, 258);
            this.checkBox_Direction.Name = "checkBox_Direction";
            this.checkBox_Direction.Size = new System.Drawing.Size(30, 23);
            this.checkBox_Direction.TabIndex = 2;
            this.checkBox_Direction.Text = "&En";
            this.checkBox_Direction.UseVisualStyleBackColor = true;
            // 
            // button_Next
            // 
            this.button_Next.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button_Next.Location = new System.Drawing.Point(415, 257);
            this.button_Next.Name = "button_Next";
            this.button_Next.Size = new System.Drawing.Size(75, 23);
            this.button_Next.TabIndex = 4;
            this.button_Next.Text = "&Next >>";
            this.button_Next.UseVisualStyleBackColor = true;
            this.button_Next.Click += new System.EventHandler(this.button_Next_Click);
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView.BackgroundColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dataGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(12, 12);
            this.dataGridView.MultiSelect = false;
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowTemplate.ReadOnly = true;
            this.dataGridView.Size = new System.Drawing.Size(478, 239);
            this.dataGridView.TabIndex = 1;
            this.dataGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellDoubleClick);
            this.dataGridView.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dataGridView_KeyDown);
            this.dataGridView.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dataGridView_KeyPress);
            // 
            // checkBox_LearnCheck
            // 
            this.checkBox_LearnCheck.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBox_LearnCheck.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkBox_LearnCheck.AutoSize = true;
            this.checkBox_LearnCheck.Enabled = false;
            this.checkBox_LearnCheck.Location = new System.Drawing.Point(380, 257);
            this.checkBox_LearnCheck.Name = "checkBox_LearnCheck";
            this.checkBox_LearnCheck.Size = new System.Drawing.Size(29, 23);
            this.checkBox_LearnCheck.TabIndex = 3;
            this.checkBox_LearnCheck.Text = "&Ln";
            this.checkBox_LearnCheck.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(502, 293);
            this.Controls.Add(this.checkBox_LearnCheck);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.button_Next);
            this.Controls.Add(this.checkBox_Direction);
            this.Controls.Add(this.button_Dictionary);
            this.MinimumSize = new System.Drawing.Size(384, 327);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Words";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_Dictionary;
        private System.Windows.Forms.CheckBox checkBox_Direction;
        private System.Windows.Forms.Button button_Next;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.CheckBox checkBox_LearnCheck;

    }
}

