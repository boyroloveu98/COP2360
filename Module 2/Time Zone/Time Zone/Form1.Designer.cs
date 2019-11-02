namespace Time_Zone
{
    partial class timeZoneForm
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
            this.okButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.promptLabel = new System.Windows.Forms.Label();
            this.outputDescriptionlabel = new System.Windows.Forms.Label();
            this.timeZoneLabel = new System.Windows.Forms.Label();
            this.cityListBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // okButton
            // 
            this.okButton.Location = new System.Drawing.Point(47, 225);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(75, 26);
            this.okButton.TabIndex = 2;
            this.okButton.Text = "&OK";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(183, 225);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 26);
            this.exitButton.TabIndex = 3;
            this.exitButton.Text = "E&xit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // promptLabel
            // 
            this.promptLabel.AutoSize = true;
            this.promptLabel.Location = new System.Drawing.Point(10, 25);
            this.promptLabel.Name = "promptLabel";
            this.promptLabel.Size = new System.Drawing.Size(295, 17);
            this.promptLabel.TabIndex = 2;
            this.promptLabel.Text = "Select  a city and I will give you the time zone.";
            // 
            // outputDescriptionlabel
            // 
            this.outputDescriptionlabel.AutoSize = true;
            this.outputDescriptionlabel.Location = new System.Drawing.Point(9, 186);
            this.outputDescriptionlabel.Name = "outputDescriptionlabel";
            this.outputDescriptionlabel.Size = new System.Drawing.Size(80, 17);
            this.outputDescriptionlabel.TabIndex = 5;
            this.outputDescriptionlabel.Text = "Time Zone:";
            // 
            // timeZoneLabel
            // 
            this.timeZoneLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.timeZoneLabel.Location = new System.Drawing.Point(95, 180);
            this.timeZoneLabel.Name = "timeZoneLabel";
            this.timeZoneLabel.Size = new System.Drawing.Size(210, 23);
            this.timeZoneLabel.TabIndex = 4;
            this.timeZoneLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cityListBox
            // 
            this.cityListBox.FormattingEnabled = true;
            this.cityListBox.ItemHeight = 16;
            this.cityListBox.Items.AddRange(new object[] {
            "Denver",
            "Honolulu",
            "Minneapolis",
            "New York",
            "San Francisco"});
            this.cityListBox.Location = new System.Drawing.Point(89, 65);
            this.cityListBox.Name = "cityListBox";
            this.cityListBox.Size = new System.Drawing.Size(120, 84);
            this.cityListBox.TabIndex = 0;
            // 
            // timeZoneForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(358, 300);
            this.Controls.Add(this.cityListBox);
            this.Controls.Add(this.timeZoneLabel);
            this.Controls.Add(this.outputDescriptionlabel);
            this.Controls.Add(this.promptLabel);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.okButton);
            this.Name = "timeZoneForm";
            this.Text = "Time Zone";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Label promptLabel;
        private System.Windows.Forms.Label outputDescriptionlabel;
        private System.Windows.Forms.Label timeZoneLabel;
        private System.Windows.Forms.ListBox cityListBox;
    }
}

