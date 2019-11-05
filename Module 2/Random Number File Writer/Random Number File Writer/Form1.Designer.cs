namespace Random_Number_File_Writer
{
    partial class randomFileWriterForm
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
            this.numInputTextBox = new System.Windows.Forms.TextBox();
            this.numInputPromptLabel = new System.Windows.Forms.Label();
            this.generateRandomNumsButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.saveRandomListOfNumbers = new System.Windows.Forms.SaveFileDialog();
            this.SuspendLayout();
            // 
            // numInputTextBox
            // 
            this.numInputTextBox.Location = new System.Drawing.Point(129, 62);
            this.numInputTextBox.Name = "numInputTextBox";
            this.numInputTextBox.Size = new System.Drawing.Size(100, 22);
            this.numInputTextBox.TabIndex = 0;
            // 
            // numInputPromptLabel
            // 
            this.numInputPromptLabel.AutoSize = true;
            this.numInputPromptLabel.Location = new System.Drawing.Point(12, 25);
            this.numInputPromptLabel.Name = "numInputPromptLabel";
            this.numInputPromptLabel.Size = new System.Drawing.Size(360, 17);
            this.numInputPromptLabel.TabIndex = 1;
            this.numInputPromptLabel.Text = "Enter how many Random digits we should add to the file";
            // 
            // generateRandomNumsButton
            // 
            this.generateRandomNumsButton.AutoSize = true;
            this.generateRandomNumsButton.Location = new System.Drawing.Point(12, 99);
            this.generateRandomNumsButton.Name = "generateRandomNumsButton";
            this.generateRandomNumsButton.Size = new System.Drawing.Size(139, 65);
            this.generateRandomNumsButton.TabIndex = 2;
            this.generateRandomNumsButton.Text = "Generate Numbers";
            this.generateRandomNumsButton.UseVisualStyleBackColor = true;
            this.generateRandomNumsButton.Click += new System.EventHandler(this.generateRandomNumsButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(196, 99);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(139, 65);
            this.exitButton.TabIndex = 4;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // randomFileWriterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(393, 208);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.generateRandomNumsButton);
            this.Controls.Add(this.numInputPromptLabel);
            this.Controls.Add(this.numInputTextBox);
            this.Name = "randomFileWriterForm";
            this.Text = "Random Number File Writer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox numInputTextBox;
        private System.Windows.Forms.Label numInputPromptLabel;
        private System.Windows.Forms.Button generateRandomNumsButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.SaveFileDialog saveRandomListOfNumbers;
    }
}

