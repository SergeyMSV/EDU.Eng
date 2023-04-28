namespace Words
{
    partial class Card
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
            this.checkedListBox_Category = new System.Windows.Forms.CheckedListBox();
            this.textBox_expression = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox_Status = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button_OK = new System.Windows.Forms.Button();
            this.button_Cancel = new System.Windows.Forms.Button();
            this.textBox_ExpressionComment = new System.Windows.Forms.TextBox();
            this.textBox_translation = new System.Windows.Forms.TextBox();
            this.textBox_TranslationComment = new System.Windows.Forms.TextBox();
            this.button_Apply = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // checkedListBox_Category
            // 
            this.checkedListBox_Category.FormattingEnabled = true;
            this.checkedListBox_Category.Location = new System.Drawing.Point(354, 25);
            this.checkedListBox_Category.Name = "checkedListBox_Category";
            this.checkedListBox_Category.Size = new System.Drawing.Size(156, 349);
            this.checkedListBox_Category.TabIndex = 5;
            this.checkedListBox_Category.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Card_KeyDown);
            // 
            // textBox_expression
            // 
            this.textBox_expression.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_expression.Location = new System.Drawing.Point(12, 25);
            this.textBox_expression.Multiline = true;
            this.textBox_expression.Name = "textBox_expression";
            this.textBox_expression.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox_expression.Size = new System.Drawing.Size(336, 80);
            this.textBox_expression.TabIndex = 1;
            this.textBox_expression.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Card_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Expression";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 192);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Translation";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(355, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Associate with";
            // 
            // comboBox_Status
            // 
            this.comboBox_Status.FormattingEnabled = true;
            this.comboBox_Status.Location = new System.Drawing.Point(56, 383);
            this.comboBox_Status.Name = "comboBox_Status";
            this.comboBox_Status.Size = new System.Drawing.Size(150, 21);
            this.comboBox_Status.TabIndex = 6;
            this.comboBox_Status.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Card_KeyDown);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 386);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Status";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Location = new System.Drawing.Point(13, 412);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(498, 4);
            this.panel1.TabIndex = 11;
            // 
            // button_OK
            // 
            this.button_OK.Location = new System.Drawing.Point(355, 422);
            this.button_OK.Name = "button_OK";
            this.button_OK.Size = new System.Drawing.Size(75, 23);
            this.button_OK.TabIndex = 8;
            this.button_OK.Text = "&OK";
            this.button_OK.UseVisualStyleBackColor = true;
            this.button_OK.Click += new System.EventHandler(this.button_OK_Click);
            this.button_OK.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Card_KeyDown);
            // 
            // button_Cancel
            // 
            this.button_Cancel.Location = new System.Drawing.Point(436, 422);
            this.button_Cancel.Name = "button_Cancel";
            this.button_Cancel.Size = new System.Drawing.Size(75, 23);
            this.button_Cancel.TabIndex = 9;
            this.button_Cancel.Text = "&Cancel";
            this.button_Cancel.UseVisualStyleBackColor = true;
            this.button_Cancel.Click += new System.EventHandler(this.button_Cancel_Click);
            this.button_Cancel.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Card_KeyDown);
            // 
            // textBox_ExpressionComment
            // 
            this.textBox_ExpressionComment.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_ExpressionComment.Location = new System.Drawing.Point(12, 111);
            this.textBox_ExpressionComment.Multiline = true;
            this.textBox_ExpressionComment.Name = "textBox_ExpressionComment";
            this.textBox_ExpressionComment.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox_ExpressionComment.Size = new System.Drawing.Size(336, 80);
            this.textBox_ExpressionComment.TabIndex = 2;
            this.textBox_ExpressionComment.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Card_KeyDown);
            // 
            // textBox_translation
            // 
            this.textBox_translation.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_translation.Location = new System.Drawing.Point(12, 208);
            this.textBox_translation.Multiline = true;
            this.textBox_translation.Name = "textBox_translation";
            this.textBox_translation.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox_translation.Size = new System.Drawing.Size(336, 80);
            this.textBox_translation.TabIndex = 3;
            this.textBox_translation.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Card_KeyDown);
            // 
            // textBox_TranslationComment
            // 
            this.textBox_TranslationComment.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_TranslationComment.Location = new System.Drawing.Point(12, 294);
            this.textBox_TranslationComment.Multiline = true;
            this.textBox_TranslationComment.Name = "textBox_TranslationComment";
            this.textBox_TranslationComment.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox_TranslationComment.Size = new System.Drawing.Size(336, 80);
            this.textBox_TranslationComment.TabIndex = 4;
            this.textBox_TranslationComment.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Card_KeyDown);
            // 
            // button_Apply
            // 
            this.button_Apply.Location = new System.Drawing.Point(274, 422);
            this.button_Apply.Name = "button_Apply";
            this.button_Apply.Size = new System.Drawing.Size(75, 23);
            this.button_Apply.TabIndex = 7;
            this.button_Apply.Text = "&Apply";
            this.button_Apply.UseVisualStyleBackColor = true;
            this.button_Apply.Click += new System.EventHandler(this.button_Apply_Click);
            this.button_Apply.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Card_KeyDown);
            // 
            // Card
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(523, 457);
            this.Controls.Add(this.button_Apply);
            this.Controls.Add(this.textBox_TranslationComment);
            this.Controls.Add(this.textBox_ExpressionComment);
            this.Controls.Add(this.button_Cancel);
            this.Controls.Add(this.button_OK);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.comboBox_Status);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox_translation);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_expression);
            this.Controls.Add(this.checkedListBox_Category);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Card";
            this.ShowInTaskbar = false;
            this.Text = "Card";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Card_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckedListBox checkedListBox_Category;
        private System.Windows.Forms.TextBox textBox_expression;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button_OK;
        private System.Windows.Forms.Button button_Cancel;
        private System.Windows.Forms.ComboBox comboBox_Status;
        private System.Windows.Forms.TextBox textBox_ExpressionComment;
        private System.Windows.Forms.TextBox textBox_translation;
        private System.Windows.Forms.TextBox textBox_TranslationComment;
        private System.Windows.Forms.Button button_Apply;
    }
}