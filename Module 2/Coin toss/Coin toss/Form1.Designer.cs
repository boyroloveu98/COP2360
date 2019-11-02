namespace Coin_toss
{
    partial class coinToss
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(coinToss));
            this.headsPictureBox = new System.Windows.Forms.PictureBox();
            this.tailsPictureBox = new System.Windows.Forms.PictureBox();
            this.exitButton = new System.Windows.Forms.Button();
            this.tossButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.headsPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tailsPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // headsPictureBox
            // 
            this.headsPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("headsPictureBox.Image")));
            this.headsPictureBox.Location = new System.Drawing.Point(26, 24);
            this.headsPictureBox.Name = "headsPictureBox";
            this.headsPictureBox.Size = new System.Drawing.Size(170, 170);
            this.headsPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.headsPictureBox.TabIndex = 0;
            this.headsPictureBox.TabStop = false;
            // 
            // tailsPictureBox
            // 
            this.tailsPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("tailsPictureBox.Image")));
            this.tailsPictureBox.Location = new System.Drawing.Point(253, 24);
            this.tailsPictureBox.Name = "tailsPictureBox";
            this.tailsPictureBox.Size = new System.Drawing.Size(170, 170);
            this.tailsPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.tailsPictureBox.TabIndex = 1;
            this.tailsPictureBox.TabStop = false;
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(253, 221);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 23);
            this.exitButton.TabIndex = 2;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // tossButton
            // 
            this.tossButton.Location = new System.Drawing.Point(121, 221);
            this.tossButton.Name = "tossButton";
            this.tossButton.Size = new System.Drawing.Size(75, 23);
            this.tossButton.TabIndex = 3;
            this.tossButton.Text = "Flip";
            this.tossButton.UseVisualStyleBackColor = true;
            this.tossButton.Click += new System.EventHandler(this.tossButton_Click);
            // 
            // coinToss
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(449, 280);
            this.Controls.Add(this.tossButton);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.tailsPictureBox);
            this.Controls.Add(this.headsPictureBox);
            this.Name = "coinToss";
            this.Text = "Coin Toss";
            ((System.ComponentModel.ISupportInitialize)(this.headsPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tailsPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox headsPictureBox;
        private System.Windows.Forms.PictureBox tailsPictureBox;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button tossButton;
    }
}

