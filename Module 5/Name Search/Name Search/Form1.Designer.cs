namespace Name_Search
{
    partial class nameSearchForm
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
            this.insturctionsLabel = new System.Windows.Forms.Label();
            this.userInputTextBox = new System.Windows.Forms.TextBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.wasFoundLabel = new System.Windows.Forms.Label();
            this.notFoundLabel = new System.Windows.Forms.Label();
            this.maleRadioButton = new System.Windows.Forms.RadioButton();
            this.femaleRadioButton = new System.Windows.Forms.RadioButton();
            this.allRadioButton = new System.Windows.Forms.RadioButton();
            this.genderSelectLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // insturctionsLabel
            // 
            this.insturctionsLabel.AutoSize = true;
            this.insturctionsLabel.Location = new System.Drawing.Point(12, 33);
            this.insturctionsLabel.Name = "insturctionsLabel";
            this.insturctionsLabel.Size = new System.Drawing.Size(440, 17);
            this.insturctionsLabel.TabIndex = 0;
            this.insturctionsLabel.Text = "Please enter a name to see if it was a popular name from 2000-2009";
            // 
            // userInputTextBox
            // 
            this.userInputTextBox.AcceptsReturn = true;
            this.userInputTextBox.Location = new System.Drawing.Point(471, 30);
            this.userInputTextBox.Name = "userInputTextBox";
            this.userInputTextBox.Size = new System.Drawing.Size(175, 22);
            this.userInputTextBox.TabIndex = 0;
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(181, 100);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(75, 23);
            this.searchButton.TabIndex = 2;
            this.searchButton.Text = "&Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(299, 100);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(75, 23);
            this.clearButton.TabIndex = 3;
            this.clearButton.Text = "&Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(420, 100);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 23);
            this.exitButton.TabIndex = 4;
            this.exitButton.Text = "E&xit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // wasFoundLabel
            // 
            this.wasFoundLabel.BackColor = System.Drawing.SystemColors.Info;
            this.wasFoundLabel.Location = new System.Drawing.Point(178, 160);
            this.wasFoundLabel.Name = "wasFoundLabel";
            this.wasFoundLabel.Size = new System.Drawing.Size(100, 93);
            this.wasFoundLabel.TabIndex = 5;
            this.wasFoundLabel.Text = "YES, That was popular during that time period";
            this.wasFoundLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.wasFoundLabel.Visible = false;
            // 
            // notFoundLabel
            // 
            this.notFoundLabel.BackColor = System.Drawing.SystemColors.Info;
            this.notFoundLabel.Location = new System.Drawing.Point(395, 160);
            this.notFoundLabel.Name = "notFoundLabel";
            this.notFoundLabel.Size = new System.Drawing.Size(100, 93);
            this.notFoundLabel.TabIndex = 6;
            this.notFoundLabel.Text = "No, That was not popular during that time period";
            this.notFoundLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.notFoundLabel.Visible = false;
            // 
            // maleRadioButton
            // 
            this.maleRadioButton.AutoSize = true;
            this.maleRadioButton.Location = new System.Drawing.Point(420, 58);
            this.maleRadioButton.Name = "maleRadioButton";
            this.maleRadioButton.Size = new System.Drawing.Size(59, 21);
            this.maleRadioButton.TabIndex = 4;
            this.maleRadioButton.Text = "Male";
            this.maleRadioButton.UseVisualStyleBackColor = true;
            // 
            // femaleRadioButton
            // 
            this.femaleRadioButton.AutoSize = true;
            this.femaleRadioButton.Location = new System.Drawing.Point(485, 58);
            this.femaleRadioButton.Name = "femaleRadioButton";
            this.femaleRadioButton.Size = new System.Drawing.Size(75, 21);
            this.femaleRadioButton.TabIndex = 5;
            this.femaleRadioButton.Text = "Female";
            this.femaleRadioButton.UseVisualStyleBackColor = true;
            // 
            // allRadioButton
            // 
            this.allRadioButton.AutoSize = true;
            this.allRadioButton.Checked = true;
            this.allRadioButton.Location = new System.Drawing.Point(566, 58);
            this.allRadioButton.Name = "allRadioButton";
            this.allRadioButton.Size = new System.Drawing.Size(58, 21);
            this.allRadioButton.TabIndex = 6;
            this.allRadioButton.TabStop = true;
            this.allRadioButton.Text = "Both";
            this.allRadioButton.UseVisualStyleBackColor = true;
            // 
            // genderSelectLabel
            // 
            this.genderSelectLabel.AutoSize = true;
            this.genderSelectLabel.Location = new System.Drawing.Point(12, 62);
            this.genderSelectLabel.Name = "genderSelectLabel";
            this.genderSelectLabel.Size = new System.Drawing.Size(288, 17);
            this.genderSelectLabel.TabIndex = 10;
            this.genderSelectLabel.Text = "Please select one or both genders to search";
            // 
            // nameSearchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(665, 257);
            this.Controls.Add(this.genderSelectLabel);
            this.Controls.Add(this.allRadioButton);
            this.Controls.Add(this.femaleRadioButton);
            this.Controls.Add(this.maleRadioButton);
            this.Controls.Add(this.notFoundLabel);
            this.Controls.Add(this.wasFoundLabel);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.userInputTextBox);
            this.Controls.Add(this.insturctionsLabel);
            this.Name = "nameSearchForm";
            this.Text = " Name Search";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label insturctionsLabel;
        private System.Windows.Forms.TextBox userInputTextBox;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Label wasFoundLabel;
        private System.Windows.Forms.Label notFoundLabel;
        private System.Windows.Forms.RadioButton maleRadioButton;
        private System.Windows.Forms.RadioButton femaleRadioButton;
        private System.Windows.Forms.RadioButton allRadioButton;
        private System.Windows.Forms.Label genderSelectLabel;
    }
}

