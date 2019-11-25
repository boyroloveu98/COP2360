namespace Morse_Code_Translator
{
    partial class morseTranslationForm
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
            this.exitButoon = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.translateButton = new System.Windows.Forms.Button();
            this.instructionLabel = new System.Windows.Forms.Label();
            this.rawTextBox = new System.Windows.Forms.TextBox();
            this.translatedTextBox = new System.Windows.Forms.TextBox();
            this.translatedLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // exitButoon
            // 
            this.exitButoon.Location = new System.Drawing.Point(245, 162);
            this.exitButoon.Name = "exitButoon";
            this.exitButoon.Size = new System.Drawing.Size(75, 23);
            this.exitButoon.TabIndex = 3;
            this.exitButoon.Text = "E&xit";
            this.exitButoon.UseVisualStyleBackColor = true;
            this.exitButoon.Click += new System.EventHandler(this.exitButoon_Click);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(210, 133);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(75, 23);
            this.clearButton.TabIndex = 2;
            this.clearButton.Text = "&Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // translateButton
            // 
            this.translateButton.Location = new System.Drawing.Point(154, 162);
            this.translateButton.Name = "translateButton";
            this.translateButton.Size = new System.Drawing.Size(85, 23);
            this.translateButton.TabIndex = 1;
            this.translateButton.Text = "&Translate";
            this.translateButton.UseVisualStyleBackColor = true;
            this.translateButton.Click += new System.EventHandler(this.translateButton_Click);
            // 
            // instructionLabel
            // 
            this.instructionLabel.AutoSize = true;
            this.instructionLabel.Location = new System.Drawing.Point(29, 9);
            this.instructionLabel.Name = "instructionLabel";
            this.instructionLabel.Size = new System.Drawing.Size(446, 17);
            this.instructionLabel.TabIndex = 3;
            this.instructionLabel.Text = "Enter your text and hit translate to translate your text into Morse Code";
            // 
            // rawTextBox
            // 
            this.rawTextBox.Location = new System.Drawing.Point(32, 29);
            this.rawTextBox.Name = "rawTextBox";
            this.rawTextBox.Size = new System.Drawing.Size(443, 22);
            this.rawTextBox.TabIndex = 0;
            // 
            // translatedTextBox
            // 
            this.translatedTextBox.Location = new System.Drawing.Point(32, 82);
            this.translatedTextBox.Name = "translatedTextBox";
            this.translatedTextBox.Size = new System.Drawing.Size(443, 22);
            this.translatedTextBox.TabIndex = 5;
            this.translatedTextBox.Visible = false;
            // 
            // translatedLabel
            // 
            this.translatedLabel.AutoSize = true;
            this.translatedLabel.Location = new System.Drawing.Point(178, 62);
            this.translatedLabel.Name = "translatedLabel";
            this.translatedLabel.Size = new System.Drawing.Size(131, 17);
            this.translatedLabel.TabIndex = 6;
            this.translatedLabel.Text = "Your converted text";
            this.translatedLabel.Visible = false;
            // 
            // morseTranslationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(511, 219);
            this.Controls.Add(this.translatedLabel);
            this.Controls.Add(this.translatedTextBox);
            this.Controls.Add(this.rawTextBox);
            this.Controls.Add(this.instructionLabel);
            this.Controls.Add(this.translateButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.exitButoon);
            this.Name = "morseTranslationForm";
            this.Text = "Cooke\'s Morse translation form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button exitButoon;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button translateButton;
        private System.Windows.Forms.Label instructionLabel;
        private System.Windows.Forms.TextBox rawTextBox;
        private System.Windows.Forms.TextBox translatedTextBox;
        private System.Windows.Forms.Label translatedLabel;
    }
}

