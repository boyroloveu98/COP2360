namespace Language_Translator
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
            this.languaagePrompt = new System.Windows.Forms.Label();
            this.italianButton = new System.Windows.Forms.Button();
            this.spanishButton = new System.Windows.Forms.Button();
            this.germanButton = new System.Windows.Forms.Button();
            this.translationLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // languaagePrompt
            // 
            this.languaagePrompt.AutoSize = true;
            this.languaagePrompt.Location = new System.Drawing.Point(156, 58);
            this.languaagePrompt.Name = "languaagePrompt";
            this.languaagePrompt.Size = new System.Drawing.Size(305, 17);
            this.languaagePrompt.TabIndex = 0;
            this.languaagePrompt.Text = "Select a language and I will say \'good morning\'!";
            // 
            // italianButton
            // 
            this.italianButton.Location = new System.Drawing.Point(60, 280);
            this.italianButton.Name = "italianButton";
            this.italianButton.Size = new System.Drawing.Size(75, 23);
            this.italianButton.TabIndex = 1;
            this.italianButton.Text = "Italian";
            this.italianButton.UseVisualStyleBackColor = true;
            this.italianButton.Click += new System.EventHandler(this.italianButton_Click);
            // 
            // spanishButton
            // 
            this.spanishButton.Location = new System.Drawing.Point(275, 280);
            this.spanishButton.Name = "spanishButton";
            this.spanishButton.Size = new System.Drawing.Size(75, 23);
            this.spanishButton.TabIndex = 2;
            this.spanishButton.Text = "Spanish";
            this.spanishButton.UseVisualStyleBackColor = true;
            this.spanishButton.Click += new System.EventHandler(this.spanishButton_Click);
            // 
            // germanButton
            // 
            this.germanButton.Location = new System.Drawing.Point(495, 280);
            this.germanButton.Name = "germanButton";
            this.germanButton.Size = new System.Drawing.Size(75, 23);
            this.germanButton.TabIndex = 3;
            this.germanButton.Text = "German";
            this.germanButton.UseVisualStyleBackColor = true;
            this.germanButton.Click += new System.EventHandler(this.germanButton_Click);
            // 
            // translationLabel
            // 
            this.translationLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.translationLabel.Location = new System.Drawing.Point(60, 126);
            this.translationLabel.Name = "translationLabel";
            this.translationLabel.Size = new System.Drawing.Size(510, 75);
            this.translationLabel.TabIndex = 2;
            this.translationLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(626, 357);
            this.Controls.Add(this.translationLabel);
            this.Controls.Add(this.germanButton);
            this.Controls.Add(this.spanishButton);
            this.Controls.Add(this.italianButton);
            this.Controls.Add(this.languaagePrompt);
            this.Name = "Form1";
            this.Text = "Language Translator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label languaagePrompt;
        private System.Windows.Forms.Button italianButton;
        private System.Windows.Forms.Button spanishButton;
        private System.Windows.Forms.Button germanButton;
        private System.Windows.Forms.Label translationLabel;
    }
}

