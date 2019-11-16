namespace Random_Card
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.getCardButton = new System.Windows.Forms.Button();
            this.cardPictureBox = new System.Windows.Forms.PictureBox();
            this.cardImageList = new System.Windows.Forms.ImageList(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.cardPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // getCardButton
            // 
            this.getCardButton.Location = new System.Drawing.Point(96, 126);
            this.getCardButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.getCardButton.Name = "getCardButton";
            this.getCardButton.Size = new System.Drawing.Size(100, 44);
            this.getCardButton.TabIndex = 3;
            this.getCardButton.Text = "Get Random Card";
            this.getCardButton.UseVisualStyleBackColor = true;
            this.getCardButton.Click += new System.EventHandler(this.getCardButton_Click);
            // 
            // cardPictureBox
            // 
            this.cardPictureBox.Image = global::Random_Card.Properties.Resources.Backface_Blue;
            this.cardPictureBox.Location = new System.Drawing.Point(112, 16);
            this.cardPictureBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cardPictureBox.Name = "cardPictureBox";
            this.cardPictureBox.Size = new System.Drawing.Size(70, 90);
            this.cardPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.cardPictureBox.TabIndex = 2;
            this.cardPictureBox.TabStop = false;
            // 
            // cardImageList
            // 
            this.cardImageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("cardImageList.ImageStream")));
            this.cardImageList.TransparentColor = System.Drawing.Color.Transparent;
            this.cardImageList.Images.SetKeyName(0, "2_Spades.bmp");
            this.cardImageList.Images.SetKeyName(1, "2_Hearts.bmp");
            this.cardImageList.Images.SetKeyName(2, "2_Diamonds.bmp");
            this.cardImageList.Images.SetKeyName(3, "2_Clubs.bmp");
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(291, 185);
            this.Controls.Add(this.getCardButton);
            this.Controls.Add(this.cardPictureBox);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Random Card";
            ((System.ComponentModel.ISupportInitialize)(this.cardPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button getCardButton;
        private System.Windows.Forms.PictureBox cardPictureBox;
        private System.Windows.Forms.ImageList cardImageList;
    }
}

