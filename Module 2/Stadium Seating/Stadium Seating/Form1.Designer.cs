namespace Stadium_Seating
{
    partial class stadiumRevForm
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
            this.ticketsSoldGroupBox = new System.Windows.Forms.GroupBox();
            this.classCSeatQtyInput = new System.Windows.Forms.TextBox();
            this.classBSeatQtyInput = new System.Windows.Forms.TextBox();
            this.classASeatQtyInput = new System.Windows.Forms.TextBox();
            this.classCSeatQtyLabel = new System.Windows.Forms.Label();
            this.classBSeatQtyLabel = new System.Windows.Forms.Label();
            this.classASeatQtyLabel = new System.Windows.Forms.Label();
            this.revenueGeneratedGroupBox = new System.Windows.Forms.GroupBox();
            this.totalRevLabel = new System.Windows.Forms.Label();
            this.totalRevDisplay = new System.Windows.Forms.Label();
            this.classCRevDisplay = new System.Windows.Forms.Label();
            this.classBRevDisplay = new System.Windows.Forms.Label();
            this.classARevDisplay = new System.Windows.Forms.Label();
            this.classCRevLabel = new System.Windows.Forms.Label();
            this.classsBRevLabel = new System.Windows.Forms.Label();
            this.classARevLabel = new System.Windows.Forms.Label();
            this.clearButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.calcRevButton = new System.Windows.Forms.Button();
            this.ticketsSoldGroupBox.SuspendLayout();
            this.revenueGeneratedGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // ticketsSoldGroupBox
            // 
            this.ticketsSoldGroupBox.Controls.Add(this.classCSeatQtyInput);
            this.ticketsSoldGroupBox.Controls.Add(this.classBSeatQtyInput);
            this.ticketsSoldGroupBox.Controls.Add(this.classASeatQtyInput);
            this.ticketsSoldGroupBox.Controls.Add(this.classCSeatQtyLabel);
            this.ticketsSoldGroupBox.Controls.Add(this.classBSeatQtyLabel);
            this.ticketsSoldGroupBox.Controls.Add(this.classASeatQtyLabel);
            this.ticketsSoldGroupBox.Location = new System.Drawing.Point(69, 77);
            this.ticketsSoldGroupBox.Name = "ticketsSoldGroupBox";
            this.ticketsSoldGroupBox.Size = new System.Drawing.Size(332, 246);
            this.ticketsSoldGroupBox.TabIndex = 0;
            this.ticketsSoldGroupBox.TabStop = false;
            this.ticketsSoldGroupBox.Text = "Tickets Sold";
            this.ticketsSoldGroupBox.Enter += new System.EventHandler(this.ticketsSoldGroupBox_Enter);
            // 
            // classCSeatQtyInput
            // 
            this.classCSeatQtyInput.Location = new System.Drawing.Point(111, 171);
            this.classCSeatQtyInput.Name = "classCSeatQtyInput";
            this.classCSeatQtyInput.Size = new System.Drawing.Size(162, 22);
            this.classCSeatQtyInput.TabIndex = 3;
            // 
            // classBSeatQtyInput
            // 
            this.classBSeatQtyInput.Location = new System.Drawing.Point(111, 127);
            this.classBSeatQtyInput.Name = "classBSeatQtyInput";
            this.classBSeatQtyInput.Size = new System.Drawing.Size(162, 22);
            this.classBSeatQtyInput.TabIndex = 2;
            // 
            // classASeatQtyInput
            // 
            this.classASeatQtyInput.Location = new System.Drawing.Point(111, 75);
            this.classASeatQtyInput.Name = "classASeatQtyInput";
            this.classASeatQtyInput.Size = new System.Drawing.Size(162, 22);
            this.classASeatQtyInput.TabIndex = 1;
            // 
            // classCSeatQtyLabel
            // 
            this.classCSeatQtyLabel.AutoSize = true;
            this.classCSeatQtyLabel.Location = new System.Drawing.Point(6, 174);
            this.classCSeatQtyLabel.Name = "classCSeatQtyLabel";
            this.classCSeatQtyLabel.Size = new System.Drawing.Size(59, 17);
            this.classCSeatQtyLabel.TabIndex = 9;
            this.classCSeatQtyLabel.Text = "Class C:";
            // 
            // classBSeatQtyLabel
            // 
            this.classBSeatQtyLabel.AutoSize = true;
            this.classBSeatQtyLabel.Location = new System.Drawing.Point(6, 127);
            this.classBSeatQtyLabel.Name = "classBSeatQtyLabel";
            this.classBSeatQtyLabel.Size = new System.Drawing.Size(59, 17);
            this.classBSeatQtyLabel.TabIndex = 8;
            this.classBSeatQtyLabel.Text = "Class B:";
            // 
            // classASeatQtyLabel
            // 
            this.classASeatQtyLabel.AutoSize = true;
            this.classASeatQtyLabel.Location = new System.Drawing.Point(6, 78);
            this.classASeatQtyLabel.Name = "classASeatQtyLabel";
            this.classASeatQtyLabel.Size = new System.Drawing.Size(59, 17);
            this.classASeatQtyLabel.TabIndex = 7;
            this.classASeatQtyLabel.Text = "Class A:";
            // 
            // revenueGeneratedGroupBox
            // 
            this.revenueGeneratedGroupBox.Controls.Add(this.totalRevLabel);
            this.revenueGeneratedGroupBox.Controls.Add(this.totalRevDisplay);
            this.revenueGeneratedGroupBox.Controls.Add(this.classCRevDisplay);
            this.revenueGeneratedGroupBox.Controls.Add(this.classBRevDisplay);
            this.revenueGeneratedGroupBox.Controls.Add(this.classARevDisplay);
            this.revenueGeneratedGroupBox.Controls.Add(this.classCRevLabel);
            this.revenueGeneratedGroupBox.Controls.Add(this.classsBRevLabel);
            this.revenueGeneratedGroupBox.Controls.Add(this.classARevLabel);
            this.revenueGeneratedGroupBox.Location = new System.Drawing.Point(527, 77);
            this.revenueGeneratedGroupBox.Name = "revenueGeneratedGroupBox";
            this.revenueGeneratedGroupBox.Size = new System.Drawing.Size(332, 246);
            this.revenueGeneratedGroupBox.TabIndex = 1;
            this.revenueGeneratedGroupBox.TabStop = false;
            this.revenueGeneratedGroupBox.Text = "Revenue Generated";
            // 
            // totalRevLabel
            // 
            this.totalRevLabel.AutoSize = true;
            this.totalRevLabel.Location = new System.Drawing.Point(6, 216);
            this.totalRevLabel.Name = "totalRevLabel";
            this.totalRevLabel.Size = new System.Drawing.Size(44, 17);
            this.totalRevLabel.TabIndex = 7;
            this.totalRevLabel.Text = "Total:";
            // 
            // totalRevDisplay
            // 
            this.totalRevDisplay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.totalRevDisplay.Location = new System.Drawing.Point(116, 210);
            this.totalRevDisplay.Name = "totalRevDisplay";
            this.totalRevDisplay.Size = new System.Drawing.Size(165, 23);
            this.totalRevDisplay.TabIndex = 4;
            // 
            // classCRevDisplay
            // 
            this.classCRevDisplay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.classCRevDisplay.Location = new System.Drawing.Point(116, 168);
            this.classCRevDisplay.Name = "classCRevDisplay";
            this.classCRevDisplay.Size = new System.Drawing.Size(165, 23);
            this.classCRevDisplay.TabIndex = 3;
            // 
            // classBRevDisplay
            // 
            this.classBRevDisplay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.classBRevDisplay.Location = new System.Drawing.Point(116, 126);
            this.classBRevDisplay.Name = "classBRevDisplay";
            this.classBRevDisplay.Size = new System.Drawing.Size(165, 23);
            this.classBRevDisplay.TabIndex = 1;
            // 
            // classARevDisplay
            // 
            this.classARevDisplay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.classARevDisplay.Location = new System.Drawing.Point(116, 78);
            this.classARevDisplay.Name = "classARevDisplay";
            this.classARevDisplay.Size = new System.Drawing.Size(165, 23);
            this.classARevDisplay.TabIndex = 0;
            // 
            // classCRevLabel
            // 
            this.classCRevLabel.AutoSize = true;
            this.classCRevLabel.Location = new System.Drawing.Point(6, 174);
            this.classCRevLabel.Name = "classCRevLabel";
            this.classCRevLabel.Size = new System.Drawing.Size(59, 17);
            this.classCRevLabel.TabIndex = 6;
            this.classCRevLabel.Text = "Class C:";
            // 
            // classsBRevLabel
            // 
            this.classsBRevLabel.AutoSize = true;
            this.classsBRevLabel.Location = new System.Drawing.Point(6, 127);
            this.classsBRevLabel.Name = "classsBRevLabel";
            this.classsBRevLabel.Size = new System.Drawing.Size(59, 17);
            this.classsBRevLabel.TabIndex = 5;
            this.classsBRevLabel.Text = "Class B:";
            // 
            // classARevLabel
            // 
            this.classARevLabel.AutoSize = true;
            this.classARevLabel.Location = new System.Drawing.Point(6, 78);
            this.classARevLabel.Name = "classARevLabel";
            this.classARevLabel.Size = new System.Drawing.Size(59, 17);
            this.classARevLabel.TabIndex = 5;
            this.classARevLabel.Text = "Class A:";
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(424, 354);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(97, 68);
            this.clearButton.TabIndex = 5;
            this.clearButton.Text = "Clea&r";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(536, 354);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(107, 68);
            this.exitButton.TabIndex = 6;
            this.exitButton.Text = "E&xit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // calcRevButton
            // 
            this.calcRevButton.Location = new System.Drawing.Point(309, 354);
            this.calcRevButton.Name = "calcRevButton";
            this.calcRevButton.Size = new System.Drawing.Size(92, 68);
            this.calcRevButton.TabIndex = 4;
            this.calcRevButton.Text = "&Calculate Revenue";
            this.calcRevButton.UseVisualStyleBackColor = true;
            this.calcRevButton.Click += new System.EventHandler(this.calcRevButton_Click);
            // 
            // stadiumRevForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(924, 496);
            this.Controls.Add(this.calcRevButton);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.revenueGeneratedGroupBox);
            this.Controls.Add(this.ticketsSoldGroupBox);
            this.Name = "stadiumRevForm";
            this.Text = "Stadium Seating";
            this.ticketsSoldGroupBox.ResumeLayout(false);
            this.ticketsSoldGroupBox.PerformLayout();
            this.revenueGeneratedGroupBox.ResumeLayout(false);
            this.revenueGeneratedGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox ticketsSoldGroupBox;
        private System.Windows.Forms.GroupBox revenueGeneratedGroupBox;
        private System.Windows.Forms.TextBox classCSeatQtyInput;
        private System.Windows.Forms.TextBox classBSeatQtyInput;
        private System.Windows.Forms.TextBox classASeatQtyInput;
        private System.Windows.Forms.Label classCSeatQtyLabel;
        private System.Windows.Forms.Label classBSeatQtyLabel;
        private System.Windows.Forms.Label classASeatQtyLabel;
        private System.Windows.Forms.Label totalRevLabel;
        private System.Windows.Forms.Label totalRevDisplay;
        private System.Windows.Forms.Label classCRevDisplay;
        private System.Windows.Forms.Label classBRevDisplay;
        private System.Windows.Forms.Label classARevDisplay;
        private System.Windows.Forms.Label classCRevLabel;
        private System.Windows.Forms.Label classsBRevLabel;
        private System.Windows.Forms.Label classARevLabel;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button calcRevButton;
    }
}

