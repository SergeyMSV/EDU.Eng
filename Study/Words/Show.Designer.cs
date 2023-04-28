namespace Words
{
    partial class Show
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
            this.textBox_comment = new System.Windows.Forms.TextBox();
            this.button_Check = new System.Windows.Forms.Button();
            this.textBox_translation = new System.Windows.Forms.TextBox();
            this.textBox_expression = new System.Windows.Forms.TextBox();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox_comment
            // 
            this.textBox_comment.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBox_comment.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_comment.Location = new System.Drawing.Point(195, 121);
            this.textBox_comment.Multiline = true;
            this.textBox_comment.Name = "textBox_comment";
            this.textBox_comment.ReadOnly = true;
            this.textBox_comment.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox_comment.Size = new System.Drawing.Size(371, 108);
            this.textBox_comment.TabIndex = 7;
            this.textBox_comment.TabStop = false;
            // 
            // button_Check
            // 
            this.button_Check.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.button_Check.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_Check.Location = new System.Drawing.Point(493, 345);
            this.button_Check.Name = "button_Check";
            this.button_Check.Size = new System.Drawing.Size(75, 23);
            this.button_Check.TabIndex = 9;
            this.button_Check.Text = "&Check";
            this.button_Check.UseVisualStyleBackColor = true;
            // 
            // textBox_translation
            // 
            this.textBox_translation.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBox_translation.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_translation.Location = new System.Drawing.Point(195, 235);
            this.textBox_translation.Multiline = true;
            this.textBox_translation.Name = "textBox_translation";
            this.textBox_translation.Size = new System.Drawing.Size(371, 103);
            this.textBox_translation.TabIndex = 8;
            // 
            // textBox_expression
            // 
            this.textBox_expression.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBox_expression.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_expression.Location = new System.Drawing.Point(195, 12);
            this.textBox_expression.Multiline = true;
            this.textBox_expression.Name = "textBox_expression";
            this.textBox_expression.ReadOnly = true;
            this.textBox_expression.Size = new System.Drawing.Size(371, 103);
            this.textBox_expression.TabIndex = 6;
            this.textBox_expression.TabStop = false;
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.dataGridView.BackgroundColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dataGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(12, 12);
            this.dataGridView.MultiSelect = false;
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowHeadersVisible = false;
            this.dataGridView.RowTemplate.ReadOnly = true;
            this.dataGridView.Size = new System.Drawing.Size(177, 352);
            this.dataGridView.TabIndex = 10;
            // 
            // Show
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(578, 376);
            this.Controls.Add(this.textBox_comment);
            this.Controls.Add(this.button_Check);
            this.Controls.Add(this.textBox_translation);
            this.Controls.Add(this.textBox_expression);
            this.Controls.Add(this.dataGridView);
            this.Name = "Show";
            this.Text = "Show";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_comment;
        private System.Windows.Forms.Button button_Check;
        private System.Windows.Forms.TextBox textBox_translation;
        private System.Windows.Forms.TextBox textBox_expression;
        private System.Windows.Forms.DataGridView dataGridView;
    }
}