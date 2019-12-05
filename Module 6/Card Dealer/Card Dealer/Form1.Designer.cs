namespace Card_Dealer
{
    partial class Form1
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
            this.cardsLeftLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dealButton = new System.Windows.Forms.Button();
            this.valueLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.numCardsTextBox = new System.Windows.Forms.TextBox();
            this.dealtCardsListBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // cardsLeftLabel
            // 
            this.cardsLeftLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cardsLeftLabel.Location = new System.Drawing.Point(169, 277);
            this.cardsLeftLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.cardsLeftLabel.Name = "cardsLeftLabel";
            this.cardsLeftLabel.Size = new System.Drawing.Size(106, 28);
            this.cardsLeftLabel.TabIndex = 23;
            this.cardsLeftLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 283);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(128, 17);
            this.label4.TabIndex = 22;
            this.label4.Text = "Cards Left in Deck:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 27);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(168, 17);
            this.label2.TabIndex = 21;
            this.label2.Text = "Number of Cards to Deal:";
            // 
            // dealButton
            // 
            this.dealButton.Location = new System.Drawing.Point(107, 55);
            this.dealButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dealButton.Name = "dealButton";
            this.dealButton.Size = new System.Drawing.Size(100, 28);
            this.dealButton.TabIndex = 20;
            this.dealButton.Text = "Deal Cards";
            this.dealButton.UseVisualStyleBackColor = true;
            this.dealButton.Click += new System.EventHandler(this.dealButton_Click);
            // 
            // valueLabel
            // 
            this.valueLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.valueLabel.Location = new System.Drawing.Point(169, 229);
            this.valueLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.valueLabel.Name = "valueLabel";
            this.valueLabel.Size = new System.Drawing.Size(106, 28);
            this.valueLabel.TabIndex = 19;
            this.valueLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(57, 235);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 17);
            this.label1.TabIndex = 18;
            this.label1.Text = "Value of Hand:";
            // 
            // numCardsTextBox
            // 
            this.numCardsTextBox.Location = new System.Drawing.Point(203, 23);
            this.numCardsTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.numCardsTextBox.Name = "numCardsTextBox";
            this.numCardsTextBox.Size = new System.Drawing.Size(77, 22);
            this.numCardsTextBox.TabIndex = 17;
            // 
            // dealtCardsListBox
            // 
            this.dealtCardsListBox.FormattingEnabled = true;
            this.dealtCardsListBox.ItemHeight = 16;
            this.dealtCardsListBox.Location = new System.Drawing.Point(28, 97);
            this.dealtCardsListBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dealtCardsListBox.Name = "dealtCardsListBox";
            this.dealtCardsListBox.Size = new System.Drawing.Size(249, 116);
            this.dealtCardsListBox.TabIndex = 16;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(308, 329);
            this.Controls.Add(this.cardsLeftLabel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dealButton);
            this.Controls.Add(this.valueLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numCardsTextBox);
            this.Controls.Add(this.dealtCardsListBox);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Card Dealer";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label cardsLeftLabel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button dealButton;
        private System.Windows.Forms.Label valueLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox numCardsTextBox;
        private System.Windows.Forms.ListBox dealtCardsListBox;
    }
}

