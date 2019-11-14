namespace Present_Value
{
    partial class PresentValueForm
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
            this.futureValueLabel = new System.Windows.Forms.Label();
            this.futureValueTextBox = new System.Windows.Forms.TextBox();
            this.yearsLabel = new System.Windows.Forms.Label();
            this.yearsTextBox = new System.Windows.Forms.TextBox();
            this.interestRateLabel = new System.Windows.Forms.Label();
            this.interestRateTextBox = new System.Windows.Forms.TextBox();
            this.clearButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.calculateButton = new System.Windows.Forms.Button();
            this.presentValueLabel = new System.Windows.Forms.Label();
            this.presentValueTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // futureValueLabel
            // 
            this.futureValueLabel.Location = new System.Drawing.Point(28, 24);
            this.futureValueLabel.Name = "futureValueLabel";
            this.futureValueLabel.Size = new System.Drawing.Size(134, 59);
            this.futureValueLabel.TabIndex = 0;
            this.futureValueLabel.Text = "How much money would you like to have? ex $15000";
            // 
            // futureValueTextBox
            // 
            this.futureValueTextBox.Location = new System.Drawing.Point(168, 41);
            this.futureValueTextBox.Name = "futureValueTextBox";
            this.futureValueTextBox.Size = new System.Drawing.Size(100, 22);
            this.futureValueTextBox.TabIndex = 0;
            // 
            // yearsLabel
            // 
            this.yearsLabel.Location = new System.Drawing.Point(28, 114);
            this.yearsLabel.Name = "yearsLabel";
            this.yearsLabel.Size = new System.Drawing.Size(134, 77);
            this.yearsLabel.TabIndex = 2;
            this.yearsLabel.Text = "How many years will you let it sit? (nearest full year value)";
            // 
            // yearsTextBox
            // 
            this.yearsTextBox.Location = new System.Drawing.Point(168, 140);
            this.yearsTextBox.Name = "yearsTextBox";
            this.yearsTextBox.Size = new System.Drawing.Size(100, 22);
            this.yearsTextBox.TabIndex = 1;
            // 
            // interestRateLabel
            // 
            this.interestRateLabel.Location = new System.Drawing.Point(28, 213);
            this.interestRateLabel.Name = "interestRateLabel";
            this.interestRateLabel.Size = new System.Drawing.Size(134, 77);
            this.interestRateLabel.TabIndex = 4;
            this.interestRateLabel.Text = "What is the current interest rate? (ie 4% should be entered as \'4\')";
            // 
            // interestRateTextBox
            // 
            this.interestRateTextBox.Location = new System.Drawing.Point(168, 227);
            this.interestRateTextBox.Name = "interestRateTextBox";
            this.interestRateTextBox.Size = new System.Drawing.Size(100, 22);
            this.interestRateTextBox.TabIndex = 2;
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(314, 139);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(86, 23);
            this.clearButton.TabIndex = 4;
            this.clearButton.Text = "&Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(314, 226);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(86, 23);
            this.exitButton.TabIndex = 5;
            this.exitButton.Text = "E&xit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(314, 40);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(86, 23);
            this.calculateButton.TabIndex = 3;
            this.calculateButton.Text = "Calculate";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // presentValueLabel
            // 
            this.presentValueLabel.Location = new System.Drawing.Point(28, 311);
            this.presentValueLabel.Name = "presentValueLabel";
            this.presentValueLabel.Size = new System.Drawing.Size(372, 50);
            this.presentValueLabel.TabIndex = 6;
            this.presentValueLabel.Text = "This is how much you need to deposit today to reach your intended value goals.";
            this.presentValueLabel.Visible = false;
            // 
            // presentValueTextBox
            // 
            this.presentValueTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.presentValueTextBox.Location = new System.Drawing.Point(135, 364);
            this.presentValueTextBox.Name = "presentValueTextBox";
            this.presentValueTextBox.ReadOnly = true;
            this.presentValueTextBox.Size = new System.Drawing.Size(151, 30);
            this.presentValueTextBox.TabIndex = 7;
            this.presentValueTextBox.Text = " ";
            this.presentValueTextBox.Visible = false;
            this.presentValueTextBox.WordWrap = false;
            // 
            // PresentValueForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(439, 415);
            this.Controls.Add(this.presentValueTextBox);
            this.Controls.Add(this.presentValueLabel);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.interestRateTextBox);
            this.Controls.Add(this.interestRateLabel);
            this.Controls.Add(this.yearsTextBox);
            this.Controls.Add(this.yearsLabel);
            this.Controls.Add(this.futureValueTextBox);
            this.Controls.Add(this.futureValueLabel);
            this.Name = "PresentValueForm";
            this.Text = "Present Value";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label futureValueLabel;
        private System.Windows.Forms.TextBox futureValueTextBox;
        private System.Windows.Forms.Label yearsLabel;
        private System.Windows.Forms.TextBox yearsTextBox;
        private System.Windows.Forms.Label interestRateLabel;
        private System.Windows.Forms.TextBox interestRateTextBox;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.Label presentValueLabel;
        private System.Windows.Forms.TextBox presentValueTextBox;
    }
}

