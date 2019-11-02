namespace Distance_Converter
{
    partial class distanceConverterForm
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
            this.promptLabel = new System.Windows.Forms.Label();
            this.conversionTextBox = new System.Windows.Forms.TextBox();
            this.fromGroupBox = new System.Windows.Forms.GroupBox();
            this.fromListBox = new System.Windows.Forms.ListBox();
            this.toGroupBox = new System.Windows.Forms.GroupBox();
            this.toListBox = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.convertedValueLabel = new System.Windows.Forms.Label();
            this.convertButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.fromGroupBox.SuspendLayout();
            this.toGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // promptLabel
            // 
            this.promptLabel.AutoSize = true;
            this.promptLabel.Location = new System.Drawing.Point(33, 38);
            this.promptLabel.Name = "promptLabel";
            this.promptLabel.Size = new System.Drawing.Size(178, 17);
            this.promptLabel.TabIndex = 0;
            this.promptLabel.Text = "Enter a distance to convert";
            // 
            // conversionTextBox
            // 
            this.conversionTextBox.Location = new System.Drawing.Point(305, 38);
            this.conversionTextBox.Name = "conversionTextBox";
            this.conversionTextBox.Size = new System.Drawing.Size(100, 22);
            this.conversionTextBox.TabIndex = 1;
            // 
            // fromGroupBox
            // 
            this.fromGroupBox.Controls.Add(this.fromListBox);
            this.fromGroupBox.Location = new System.Drawing.Point(11, 146);
            this.fromGroupBox.Name = "fromGroupBox";
            this.fromGroupBox.Size = new System.Drawing.Size(173, 112);
            this.fromGroupBox.TabIndex = 2;
            this.fromGroupBox.TabStop = false;
            this.fromGroupBox.Text = "From";
            // 
            // fromListBox
            // 
            this.fromListBox.FormattingEnabled = true;
            this.fromListBox.ItemHeight = 16;
            this.fromListBox.Items.AddRange(new object[] {
            "Inches",
            "Feet",
            "Yards"});
            this.fromListBox.Location = new System.Drawing.Point(25, 32);
            this.fromListBox.Name = "fromListBox";
            this.fromListBox.Size = new System.Drawing.Size(120, 52);
            this.fromListBox.TabIndex = 0;
            // 
            // toGroupBox
            // 
            this.toGroupBox.Controls.Add(this.toListBox);
            this.toGroupBox.Location = new System.Drawing.Point(249, 146);
            this.toGroupBox.Name = "toGroupBox";
            this.toGroupBox.Size = new System.Drawing.Size(173, 112);
            this.toGroupBox.TabIndex = 3;
            this.toGroupBox.TabStop = false;
            this.toGroupBox.Text = "To";
            // 
            // toListBox
            // 
            this.toListBox.FormattingEnabled = true;
            this.toListBox.ItemHeight = 16;
            this.toListBox.Items.AddRange(new object[] {
            "Inches",
            "Feet",
            "Yards"});
            this.toListBox.Location = new System.Drawing.Point(25, 32);
            this.toListBox.Name = "toListBox";
            this.toListBox.Size = new System.Drawing.Size(120, 52);
            this.toListBox.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(75, 287);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Converted Distance:";
            // 
            // convertedValueLabel
            // 
            this.convertedValueLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.convertedValueLabel.Location = new System.Drawing.Point(246, 287);
            this.convertedValueLabel.Name = "convertedValueLabel";
            this.convertedValueLabel.Size = new System.Drawing.Size(176, 23);
            this.convertedValueLabel.TabIndex = 5;
            this.convertedValueLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // convertButton
            // 
            this.convertButton.Location = new System.Drawing.Point(133, 347);
            this.convertButton.Name = "convertButton";
            this.convertButton.Size = new System.Drawing.Size(88, 56);
            this.convertButton.TabIndex = 6;
            this.convertButton.Text = "&Convert";
            this.convertButton.UseVisualStyleBackColor = true;
            this.convertButton.Click += new System.EventHandler(this.convertButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(274, 347);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(88, 56);
            this.exitButton.TabIndex = 7;
            this.exitButton.Text = "E&xit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(108, 88);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(0, 0);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 84);
            this.listBox1.TabIndex = 9;
            // 
            // distanceConverterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(546, 415);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.convertButton);
            this.Controls.Add(this.convertedValueLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.toGroupBox);
            this.Controls.Add(this.fromGroupBox);
            this.Controls.Add(this.conversionTextBox);
            this.Controls.Add(this.promptLabel);
            this.Name = "distanceConverterForm";
            this.Text = "Matt Cooke\'s Distance Converter";
            this.fromGroupBox.ResumeLayout(false);
            this.toGroupBox.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label promptLabel;
        private System.Windows.Forms.TextBox conversionTextBox;
        private System.Windows.Forms.GroupBox fromGroupBox;
        private System.Windows.Forms.ListBox fromListBox;
        private System.Windows.Forms.GroupBox toGroupBox;
        private System.Windows.Forms.ListBox toListBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label convertedValueLabel;
        private System.Windows.Forms.Button convertButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox listBox1;
    }
}

