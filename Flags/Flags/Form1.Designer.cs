namespace Flags
{
    partial class Flags
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Flags));
            this.instructionLabel = new System.Windows.Forms.Label();
            this.countryLabel = new System.Windows.Forms.Label();
            this.coffeeImage = new System.Windows.Forms.PictureBox();
            this.movieNight = new System.Windows.Forms.PictureBox();
            this.calvinHobbesExplorer = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.coffeeImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.movieNight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.calvinHobbesExplorer)).BeginInit();
            this.SuspendLayout();
            // 
            // instructionLabel
            // 
            this.instructionLabel.AutoSize = true;
            this.instructionLabel.Location = new System.Drawing.Point(349, 67);
            this.instructionLabel.Name = "instructionLabel";
            this.instructionLabel.Size = new System.Drawing.Size(277, 17);
            this.instructionLabel.TabIndex = 0;
            this.instructionLabel.Text = "Click a flag to see the name of the country.";
            // 
            // countryLabel
            // 
            this.countryLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.countryLabel.Location = new System.Drawing.Point(349, 293);
            this.countryLabel.Name = "countryLabel";
            this.countryLabel.Size = new System.Drawing.Size(277, 100);
            this.countryLabel.TabIndex = 1;
            // 
            // coffeeImage
            // 
            this.coffeeImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.coffeeImage.Image = ((System.Drawing.Image)(resources.GetObject("coffeeImage.Image")));
            this.coffeeImage.Location = new System.Drawing.Point(43, 115);
            this.coffeeImage.Name = "coffeeImage";
            this.coffeeImage.Size = new System.Drawing.Size(216, 149);
            this.coffeeImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.coffeeImage.TabIndex = 2;
            this.coffeeImage.TabStop = false;
            this.coffeeImage.Click += new System.EventHandler(this.coffeeImage_Click);
            // 
            // movieNight
            // 
            this.movieNight.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.movieNight.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.movieNight.Image = ((System.Drawing.Image)(resources.GetObject("movieNight.Image")));
            this.movieNight.Location = new System.Drawing.Point(371, 115);
            this.movieNight.Name = "movieNight";
            this.movieNight.Size = new System.Drawing.Size(245, 149);
            this.movieNight.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.movieNight.TabIndex = 3;
            this.movieNight.TabStop = false;
            this.movieNight.Click += new System.EventHandler(this.movieNight_Click);
            // 
            // calvinHobbesExplorer
            // 
            this.calvinHobbesExplorer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.calvinHobbesExplorer.Image = ((System.Drawing.Image)(resources.GetObject("calvinHobbesExplorer.Image")));
            this.calvinHobbesExplorer.Location = new System.Drawing.Point(726, 115);
            this.calvinHobbesExplorer.Name = "calvinHobbesExplorer";
            this.calvinHobbesExplorer.Size = new System.Drawing.Size(230, 149);
            this.calvinHobbesExplorer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.calvinHobbesExplorer.TabIndex = 4;
            this.calvinHobbesExplorer.TabStop = false;
            this.calvinHobbesExplorer.Click += new System.EventHandler(this.calvinHobbesExplorer_Click);
            // 
            // Flags
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 402);
            this.Controls.Add(this.calvinHobbesExplorer);
            this.Controls.Add(this.movieNight);
            this.Controls.Add(this.coffeeImage);
            this.Controls.Add(this.countryLabel);
            this.Controls.Add(this.instructionLabel);
            this.Name = "Flags";
            this.Text = "Flags";
            ((System.ComponentModel.ISupportInitialize)(this.coffeeImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.movieNight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.calvinHobbesExplorer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label instructionLabel;
        private System.Windows.Forms.Label countryLabel;
        private System.Windows.Forms.PictureBox coffeeImage;
        private System.Windows.Forms.PictureBox movieNight;
        private System.Windows.Forms.PictureBox calvinHobbesExplorer;
    }
}

