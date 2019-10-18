namespace Hello_World
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
            this.myButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // myButton
            // 
            this.myButton.BackColor = System.Drawing.Color.Gray;
            this.myButton.Location = new System.Drawing.Point(99, 103);
            this.myButton.Name = "myButton";
            this.myButton.Size = new System.Drawing.Size(80, 50);
            this.myButton.TabIndex = 0;
            this.myButton.Text = "display Message";
            this.myButton.UseVisualStyleBackColor = false;
            this.myButton.Click += new System.EventHandler(this.myButton_Click);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(282, 253);
            this.Controls.Add(this.myButton);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button myButton;
    }
}

