namespace Project1
{
    partial class UserInterface
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
            this.uxMonthLabel = new System.Windows.Forms.Label();
            this.uxYearLabel = new System.Windows.Forms.Label();
            this.uxMonthTextBox = new System.Windows.Forms.TextBox();
            this.uxYearTextBox = new System.Windows.Forms.TextBox();
            this.uxOpenFileButton = new System.Windows.Forms.Button();
            this.uxGenerateReportButton = new System.Windows.Forms.Button();
            this.uxSaveButton = new System.Windows.Forms.Button();
            this.uxIncomeTextBox = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.uxIncomeLabel = new System.Windows.Forms.Label();
            this.uxExpenseLabel = new System.Windows.Forms.Label();
            this.uxDisplayScreen = new System.Windows.Forms.WebBrowser();
            this.SuspendLayout();
            // 
            // uxMonthLabel
            // 
            this.uxMonthLabel.AutoSize = true;
            this.uxMonthLabel.Location = new System.Drawing.Point(12, 119);
            this.uxMonthLabel.Name = "uxMonthLabel";
            this.uxMonthLabel.Size = new System.Drawing.Size(40, 13);
            this.uxMonthLabel.TabIndex = 0;
            this.uxMonthLabel.Text = "Month:";
            // 
            // uxYearLabel
            // 
            this.uxYearLabel.AutoSize = true;
            this.uxYearLabel.Location = new System.Drawing.Point(12, 148);
            this.uxYearLabel.Name = "uxYearLabel";
            this.uxYearLabel.Size = new System.Drawing.Size(32, 13);
            this.uxYearLabel.TabIndex = 1;
            this.uxYearLabel.Text = "Year:";
            // 
            // uxMonthTextBox
            // 
            this.uxMonthTextBox.Location = new System.Drawing.Point(106, 119);
            this.uxMonthTextBox.Name = "uxMonthTextBox";
            this.uxMonthTextBox.Size = new System.Drawing.Size(100, 20);
            this.uxMonthTextBox.TabIndex = 2;
            // 
            // uxYearTextBox
            // 
            this.uxYearTextBox.Location = new System.Drawing.Point(106, 145);
            this.uxYearTextBox.Name = "uxYearTextBox";
            this.uxYearTextBox.Size = new System.Drawing.Size(100, 20);
            this.uxYearTextBox.TabIndex = 3;
            // 
            // uxOpenFileButton
            // 
            this.uxOpenFileButton.Enabled = false;
            this.uxOpenFileButton.Location = new System.Drawing.Point(58, 22);
            this.uxOpenFileButton.Name = "uxOpenFileButton";
            this.uxOpenFileButton.Size = new System.Drawing.Size(100, 45);
            this.uxOpenFileButton.TabIndex = 4;
            this.uxOpenFileButton.Text = "Open Existing File";
            this.uxOpenFileButton.UseVisualStyleBackColor = true;
            // 
            // uxGenerateReportButton
            // 
            this.uxGenerateReportButton.Location = new System.Drawing.Point(32, 321);
            this.uxGenerateReportButton.Name = "uxGenerateReportButton";
            this.uxGenerateReportButton.Size = new System.Drawing.Size(95, 75);
            this.uxGenerateReportButton.TabIndex = 5;
            this.uxGenerateReportButton.Text = "Generate";
            this.uxGenerateReportButton.UseVisualStyleBackColor = true;
            // 
            // uxSaveButton
            // 
            this.uxSaveButton.Enabled = false;
            this.uxSaveButton.Location = new System.Drawing.Point(133, 321);
            this.uxSaveButton.Name = "uxSaveButton";
            this.uxSaveButton.Size = new System.Drawing.Size(95, 75);
            this.uxSaveButton.TabIndex = 6;
            this.uxSaveButton.Text = "Save Report";
            this.uxSaveButton.UseVisualStyleBackColor = true;
            // 
            // uxIncomeTextBox
            // 
            this.uxIncomeTextBox.Location = new System.Drawing.Point(106, 171);
            this.uxIncomeTextBox.Name = "uxIncomeTextBox";
            this.uxIncomeTextBox.Size = new System.Drawing.Size(100, 20);
            this.uxIncomeTextBox.TabIndex = 7;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(106, 197);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 8;
            // 
            // uxIncomeLabel
            // 
            this.uxIncomeLabel.AutoSize = true;
            this.uxIncomeLabel.Location = new System.Drawing.Point(12, 174);
            this.uxIncomeLabel.Name = "uxIncomeLabel";
            this.uxIncomeLabel.Size = new System.Drawing.Size(72, 13);
            this.uxIncomeLabel.TabIndex = 9;
            this.uxIncomeLabel.Text = "Total Income:";
            // 
            // uxExpenseLabel
            // 
            this.uxExpenseLabel.AutoSize = true;
            this.uxExpenseLabel.Location = new System.Drawing.Point(12, 204);
            this.uxExpenseLabel.Name = "uxExpenseLabel";
            this.uxExpenseLabel.Size = new System.Drawing.Size(83, 13);
            this.uxExpenseLabel.TabIndex = 10;
            this.uxExpenseLabel.Text = "Total Expenses:";
            // 
            // uxDisplayScreen
            // 
            this.uxDisplayScreen.Location = new System.Drawing.Point(388, 34);
            this.uxDisplayScreen.MinimumSize = new System.Drawing.Size(20, 20);
            this.uxDisplayScreen.Name = "uxDisplayScreen";
            this.uxDisplayScreen.Size = new System.Drawing.Size(326, 362);
            this.uxDisplayScreen.TabIndex = 11;
            // 
            // UserInterface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.uxDisplayScreen);
            this.Controls.Add(this.uxExpenseLabel);
            this.Controls.Add(this.uxIncomeLabel);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.uxIncomeTextBox);
            this.Controls.Add(this.uxSaveButton);
            this.Controls.Add(this.uxGenerateReportButton);
            this.Controls.Add(this.uxOpenFileButton);
            this.Controls.Add(this.uxYearTextBox);
            this.Controls.Add(this.uxMonthTextBox);
            this.Controls.Add(this.uxYearLabel);
            this.Controls.Add(this.uxMonthLabel);
            this.Name = "UserInterface";
            this.Text = "Expense Checker";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label uxMonthLabel;
        private System.Windows.Forms.Label uxYearLabel;
        private System.Windows.Forms.TextBox uxMonthTextBox;
        private System.Windows.Forms.TextBox uxYearTextBox;
        private System.Windows.Forms.Button uxOpenFileButton;
        private System.Windows.Forms.Button uxGenerateReportButton;
        private System.Windows.Forms.Button uxSaveButton;
        private System.Windows.Forms.TextBox uxIncomeTextBox;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label uxIncomeLabel;
        private System.Windows.Forms.Label uxExpenseLabel;
        private System.Windows.Forms.WebBrowser uxDisplayScreen;
    }
}

