namespace Words
{
    partial class RightAnswer
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
            this.components = new System.ComponentModel.Container();
            this.textBox_expression = new System.Windows.Forms.TextBox();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // textBox_expression
            // 
            this.textBox_expression.BackColor = System.Drawing.SystemColors.Info;
            this.textBox_expression.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox_expression.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_expression.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textBox_expression.Location = new System.Drawing.Point(0, 0);
            this.textBox_expression.Multiline = true;
            this.textBox_expression.Name = "textBox_expression";
            this.textBox_expression.ReadOnly = true;
            this.textBox_expression.Size = new System.Drawing.Size(323, 153);
            this.textBox_expression.TabIndex = 6;
            this.textBox_expression.TabStop = false;
            this.textBox_expression.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox_expression_KeyDown);
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // RightAnswer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(323, 153);
            this.Controls.Add(this.textBox_expression);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "RightAnswer";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "The right answer";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.RightAnswer_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_expression;
        private System.Windows.Forms.Timer timer;
    }
}