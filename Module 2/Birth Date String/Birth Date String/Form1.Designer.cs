namespace Birth_Date_String
{
    partial class birthDateForm
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
            this.datOfWeekPromptLabel = new System.Windows.Forms.Label();
            this.monthPromptLabel = new System.Windows.Forms.Label();
            this.dayOfMonthPromptLabel = new System.Windows.Forms.Label();
            this.yearPromptLabel = new System.Windows.Forms.Label();
            this.dayOfWeekTextBox = new System.Windows.Forms.TextBox();
            this.monthTextBox = new System.Windows.Forms.TextBox();
            this.dayOfMonthTextBox = new System.Windows.Forms.TextBox();
            this.yearTextBox = new System.Windows.Forms.TextBox();
            this.showDateButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.dataOutputLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // datOfWeekPromptLabel
            // 
            this.datOfWeekPromptLabel.AutoSize = true;
            this.datOfWeekPromptLabel.Location = new System.Drawing.Point(217, 113);
            this.datOfWeekPromptLabel.Name = "datOfWeekPromptLabel";
            this.datOfWeekPromptLabel.Size = new System.Drawing.Size(169, 17);
            this.datOfWeekPromptLabel.TabIndex = 0;
            this.datOfWeekPromptLabel.Text = "Enter the day of the week";
            // 
            // monthPromptLabel
            // 
            this.monthPromptLabel.AutoSize = true;
            this.monthPromptLabel.Location = new System.Drawing.Point(198, 161);
            this.monthPromptLabel.Name = "monthPromptLabel";
            this.monthPromptLabel.Size = new System.Drawing.Size(188, 17);
            this.monthPromptLabel.TabIndex = 1;
            this.monthPromptLabel.Text = "Enter the name of the month";
            // 
            // dayOfMonthPromptLabel
            // 
            this.dayOfMonthPromptLabel.AutoSize = true;
            this.dayOfMonthPromptLabel.Location = new System.Drawing.Point(151, 216);
            this.dayOfMonthPromptLabel.Name = "dayOfMonthPromptLabel";
            this.dayOfMonthPromptLabel.Size = new System.Drawing.Size(235, 17);
            this.dayOfMonthPromptLabel.TabIndex = 2;
            this.dayOfMonthPromptLabel.Text = "Enter The numeric day of the month";
            // 
            // yearPromptLabel
            // 
            this.yearPromptLabel.AutoSize = true;
            this.yearPromptLabel.Location = new System.Drawing.Point(288, 258);
            this.yearPromptLabel.Name = "yearPromptLabel";
            this.yearPromptLabel.Size = new System.Drawing.Size(98, 17);
            this.yearPromptLabel.TabIndex = 3;
            this.yearPromptLabel.Text = "Enter the year";
            // 
            // dayOfWeekTextBox
            // 
            this.dayOfWeekTextBox.Location = new System.Drawing.Point(431, 110);
            this.dayOfWeekTextBox.Name = "dayOfWeekTextBox";
            this.dayOfWeekTextBox.Size = new System.Drawing.Size(252, 22);
            this.dayOfWeekTextBox.TabIndex = 4;
            // 
            // monthTextBox
            // 
            this.monthTextBox.Location = new System.Drawing.Point(431, 156);
            this.monthTextBox.Name = "monthTextBox";
            this.monthTextBox.Size = new System.Drawing.Size(252, 22);
            this.monthTextBox.TabIndex = 5;
            // 
            // dayOfMonthTextBox
            // 
            this.dayOfMonthTextBox.Location = new System.Drawing.Point(431, 211);
            this.dayOfMonthTextBox.Name = "dayOfMonthTextBox";
            this.dayOfMonthTextBox.Size = new System.Drawing.Size(252, 22);
            this.dayOfMonthTextBox.TabIndex = 6;
            // 
            // yearTextBox
            // 
            this.yearTextBox.Location = new System.Drawing.Point(431, 258);
            this.yearTextBox.Name = "yearTextBox";
            this.yearTextBox.Size = new System.Drawing.Size(252, 22);
            this.yearTextBox.TabIndex = 7;
            // 
            // showDateButton
            // 
            this.showDateButton.Location = new System.Drawing.Point(220, 368);
            this.showDateButton.Name = "showDateButton";
            this.showDateButton.Size = new System.Drawing.Size(66, 44);
            this.showDateButton.TabIndex = 8;
            this.showDateButton.Text = "Show Date";
            this.showDateButton.UseVisualStyleBackColor = true;
            this.showDateButton.Click += new System.EventHandler(this.showDateButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(380, 368);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(66, 44);
            this.clearButton.TabIndex = 9;
            this.clearButton.Text = "clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(540, 368);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(66, 44);
            this.exitButton.TabIndex = 10;
            this.exitButton.Text = "Exit button";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // dataOutputLabel
            // 
            this.dataOutputLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dataOutputLabel.Location = new System.Drawing.Point(220, 295);
            this.dataOutputLabel.Name = "dataOutputLabel";
            this.dataOutputLabel.Size = new System.Drawing.Size(386, 39);
            this.dataOutputLabel.TabIndex = 11;
            this.dataOutputLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // birthDateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(844, 673);
            this.Controls.Add(this.dataOutputLabel);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.showDateButton);
            this.Controls.Add(this.yearTextBox);
            this.Controls.Add(this.dayOfMonthTextBox);
            this.Controls.Add(this.monthTextBox);
            this.Controls.Add(this.dayOfWeekTextBox);
            this.Controls.Add(this.yearPromptLabel);
            this.Controls.Add(this.dayOfMonthPromptLabel);
            this.Controls.Add(this.monthPromptLabel);
            this.Controls.Add(this.datOfWeekPromptLabel);
            this.Name = "birthDateForm";
            this.Text = "Birth Date String";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label datOfWeekPromptLabel;
        private System.Windows.Forms.Label monthPromptLabel;
        private System.Windows.Forms.Label dayOfMonthPromptLabel;
        private System.Windows.Forms.Label yearPromptLabel;
        private System.Windows.Forms.TextBox dayOfWeekTextBox;
        private System.Windows.Forms.TextBox monthTextBox;
        private System.Windows.Forms.TextBox dayOfMonthTextBox;
        private System.Windows.Forms.TextBox yearTextBox;
        private System.Windows.Forms.Button showDateButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Label dataOutputLabel;
    }
}

