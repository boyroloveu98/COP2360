﻿namespace My_First_Project
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
            this.calculateTaxButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // calculateTaxButton
            // 
            this.calculateTaxButton.Location = new System.Drawing.Point(137, 63);
            this.calculateTaxButton.Name = "calculateTaxButton";
            this.calculateTaxButton.Size = new System.Drawing.Size(75, 23);
            this.calculateTaxButton.TabIndex = 1;
            this.calculateTaxButton.Text = "Click Me";
            this.calculateTaxButton.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 161);
            this.Controls.Add(this.calculateTaxButton);
            this.Name = "Form1";
            this.Text = "My First Program";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button calculateTaxButton;
    }
}

