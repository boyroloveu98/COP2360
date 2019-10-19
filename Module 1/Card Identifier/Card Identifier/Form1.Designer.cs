namespace Card_Identifier
{
    partial class formBody
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formBody));
            this.cardAceSpades = new System.Windows.Forms.PictureBox();
            this.cardKingSpades = new System.Windows.Forms.PictureBox();
            this.cardQueenSpades = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cardJackSpades = new System.Windows.Forms.PictureBox();
            this.card10Spades = new System.Windows.Forms.PictureBox();
            this.cardName = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.cardAceSpades)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardKingSpades)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardQueenSpades)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardJackSpades)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.card10Spades)).BeginInit();
            this.SuspendLayout();
            // 
            // cardAceSpades
            // 
            this.cardAceSpades.Image = ((System.Drawing.Image)(resources.GetObject("cardAceSpades.Image")));
            this.cardAceSpades.Location = new System.Drawing.Point(611, 50);
            this.cardAceSpades.Name = "cardAceSpades";
            this.cardAceSpades.Size = new System.Drawing.Size(100, 140);
            this.cardAceSpades.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.cardAceSpades.TabIndex = 0;
            this.cardAceSpades.TabStop = false;
            this.cardAceSpades.Click += new System.EventHandler(this.cardAceSpades_Click);
            // 
            // cardKingSpades
            // 
            this.cardKingSpades.Image = ((System.Drawing.Image)(resources.GetObject("cardKingSpades.Image")));
            this.cardKingSpades.Location = new System.Drawing.Point(465, 50);
            this.cardKingSpades.Name = "cardKingSpades";
            this.cardKingSpades.Size = new System.Drawing.Size(100, 140);
            this.cardKingSpades.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.cardKingSpades.TabIndex = 1;
            this.cardKingSpades.TabStop = false;
            this.cardKingSpades.Click += new System.EventHandler(this.cardKingSpades_Click);
            // 
            // cardQueenSpades
            // 
            this.cardQueenSpades.Image = ((System.Drawing.Image)(resources.GetObject("cardQueenSpades.Image")));
            this.cardQueenSpades.Location = new System.Drawing.Point(320, 50);
            this.cardQueenSpades.Name = "cardQueenSpades";
            this.cardQueenSpades.Size = new System.Drawing.Size(100, 140);
            this.cardQueenSpades.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.cardQueenSpades.TabIndex = 2;
            this.cardQueenSpades.TabStop = false;
            this.cardQueenSpades.Click += new System.EventHandler(this.cardQueenSpades_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(230, 226);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(306, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Click any card to see it\'s name";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cardJackSpades
            // 
            this.cardJackSpades.Image = ((System.Drawing.Image)(resources.GetObject("cardJackSpades.Image")));
            this.cardJackSpades.Location = new System.Drawing.Point(175, 50);
            this.cardJackSpades.Name = "cardJackSpades";
            this.cardJackSpades.Size = new System.Drawing.Size(100, 140);
            this.cardJackSpades.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.cardJackSpades.TabIndex = 4;
            this.cardJackSpades.TabStop = false;
            this.cardJackSpades.Click += new System.EventHandler(this.cardJackSpades_Click);
            // 
            // card10Spades
            // 
            this.card10Spades.Image = ((System.Drawing.Image)(resources.GetObject("card10Spades.Image")));
            this.card10Spades.Location = new System.Drawing.Point(24, 50);
            this.card10Spades.Name = "card10Spades";
            this.card10Spades.Size = new System.Drawing.Size(100, 140);
            this.card10Spades.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.card10Spades.TabIndex = 5;
            this.card10Spades.TabStop = false;
            this.card10Spades.Click += new System.EventHandler(this.card10Spades_Click);
            // 
            // cardName
            // 
            this.cardName.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.cardName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cardName.Location = new System.Drawing.Point(257, 315);
            this.cardName.Name = "cardName";
            this.cardName.Size = new System.Drawing.Size(279, 52);
            this.cardName.TabIndex = 6;
            this.cardName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // formBody
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(760, 424);
            this.Controls.Add(this.cardName);
            this.Controls.Add(this.card10Spades);
            this.Controls.Add(this.cardJackSpades);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cardQueenSpades);
            this.Controls.Add(this.cardKingSpades);
            this.Controls.Add(this.cardAceSpades);
            this.Name = "formBody";
            this.Text = "Matt Cooke\'s Card Identifier";
            ((System.ComponentModel.ISupportInitialize)(this.cardAceSpades)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardKingSpades)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardQueenSpades)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardJackSpades)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.card10Spades)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox cardAceSpades;
        private System.Windows.Forms.PictureBox cardKingSpades;
        private System.Windows.Forms.PictureBox cardQueenSpades;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox cardJackSpades;
        private System.Windows.Forms.PictureBox card10Spades;
        private System.Windows.Forms.Label cardName;
    }
}

