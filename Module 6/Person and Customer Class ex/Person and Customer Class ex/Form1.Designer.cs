namespace Person_and_Customer_Class_ex
{
    partial class newCustomerForm
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
            this.inputSolicitationLabel = new System.Windows.Forms.Label();
            this.exitButton = new System.Windows.Forms.Button();
            this.customerInfoButton = new System.Windows.Forms.Button();
            this.customerDataGroupBox = new System.Windows.Forms.GroupBox();
            this.phoneTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.addressTextBox = new System.Windows.Forms.TextBox();
            this.addressLabel = new System.Windows.Forms.Label();
            this.preventSolicitationRadioButton = new System.Windows.Forms.RadioButton();
            this.allowSolicationRadioButton = new System.Windows.Forms.RadioButton();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.inputIDlLabel = new System.Windows.Forms.Label();
            this.inputNameLabel = new System.Windows.Forms.Label();
            this.customerDataGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // inputSolicitationLabel
            // 
            this.inputSolicitationLabel.AutoSize = true;
            this.inputSolicitationLabel.Location = new System.Drawing.Point(8, 189);
            this.inputSolicitationLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.inputSolicitationLabel.Name = "inputSolicitationLabel";
            this.inputSolicitationLabel.Size = new System.Drawing.Size(114, 17);
            this.inputSolicitationLabel.TabIndex = 2;
            this.inputSolicitationLabel.Text = "Can we call you?";
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(367, 151);
            this.exitButton.Margin = new System.Windows.Forms.Padding(4);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(113, 58);
            this.exitButton.TabIndex = 7;
            this.exitButton.Text = "E&xit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // customerInfoButton
            // 
            this.customerInfoButton.Location = new System.Drawing.Point(367, 43);
            this.customerInfoButton.Margin = new System.Windows.Forms.Padding(4);
            this.customerInfoButton.Name = "customerInfoButton";
            this.customerInfoButton.Size = new System.Drawing.Size(113, 58);
            this.customerInfoButton.TabIndex = 6;
            this.customerInfoButton.Text = "Show Customer Info";
            this.customerInfoButton.UseVisualStyleBackColor = true;
            this.customerInfoButton.Click += new System.EventHandler(this.customerInfoButton_Click);
            // 
            // customerDataGroupBox
            // 
            this.customerDataGroupBox.Controls.Add(this.phoneTextBox);
            this.customerDataGroupBox.Controls.Add(this.label1);
            this.customerDataGroupBox.Controls.Add(this.addressTextBox);
            this.customerDataGroupBox.Controls.Add(this.addressLabel);
            this.customerDataGroupBox.Controls.Add(this.preventSolicitationRadioButton);
            this.customerDataGroupBox.Controls.Add(this.allowSolicationRadioButton);
            this.customerDataGroupBox.Controls.Add(this.idTextBox);
            this.customerDataGroupBox.Controls.Add(this.nameTextBox);
            this.customerDataGroupBox.Controls.Add(this.inputSolicitationLabel);
            this.customerDataGroupBox.Controls.Add(this.inputIDlLabel);
            this.customerDataGroupBox.Controls.Add(this.inputNameLabel);
            this.customerDataGroupBox.Location = new System.Drawing.Point(19, 16);
            this.customerDataGroupBox.Margin = new System.Windows.Forms.Padding(4);
            this.customerDataGroupBox.Name = "customerDataGroupBox";
            this.customerDataGroupBox.Padding = new System.Windows.Forms.Padding(4);
            this.customerDataGroupBox.Size = new System.Drawing.Size(340, 248);
            this.customerDataGroupBox.TabIndex = 11;
            this.customerDataGroupBox.TabStop = false;
            this.customerDataGroupBox.Text = "Customer Data";
            // 
            // phoneTextBox
            // 
            this.phoneTextBox.Location = new System.Drawing.Point(149, 125);
            this.phoneTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.phoneTextBox.Name = "phoneTextBox";
            this.phoneTextBox.Size = new System.Drawing.Size(157, 22);
            this.phoneTextBox.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 128);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 17);
            this.label1.TabIndex = 12;
            this.label1.Text = "Customer Phone:";
            // 
            // addressTextBox
            // 
            this.addressTextBox.Location = new System.Drawing.Point(149, 91);
            this.addressTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.addressTextBox.Name = "addressTextBox";
            this.addressTextBox.Size = new System.Drawing.Size(157, 22);
            this.addressTextBox.TabIndex = 2;
            // 
            // addressLabel
            // 
            this.addressLabel.AutoSize = true;
            this.addressLabel.Location = new System.Drawing.Point(12, 94);
            this.addressLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.addressLabel.Name = "addressLabel";
            this.addressLabel.Size = new System.Drawing.Size(128, 17);
            this.addressLabel.TabIndex = 10;
            this.addressLabel.Text = "Customer Address:";
            // 
            // preventSolicitationRadioButton
            // 
            this.preventSolicitationRadioButton.AutoSize = true;
            this.preventSolicitationRadioButton.Location = new System.Drawing.Point(142, 200);
            this.preventSolicitationRadioButton.Margin = new System.Windows.Forms.Padding(4);
            this.preventSolicitationRadioButton.Name = "preventSolicitationRadioButton";
            this.preventSolicitationRadioButton.Size = new System.Drawing.Size(47, 21);
            this.preventSolicitationRadioButton.TabIndex = 5;
            this.preventSolicitationRadioButton.TabStop = true;
            this.preventSolicitationRadioButton.Text = "No";
            this.preventSolicitationRadioButton.UseVisualStyleBackColor = true;
            // 
            // allowSolicationRadioButton
            // 
            this.allowSolicationRadioButton.AutoSize = true;
            this.allowSolicationRadioButton.Location = new System.Drawing.Point(142, 172);
            this.allowSolicationRadioButton.Margin = new System.Windows.Forms.Padding(4);
            this.allowSolicationRadioButton.Name = "allowSolicationRadioButton";
            this.allowSolicationRadioButton.Size = new System.Drawing.Size(53, 21);
            this.allowSolicationRadioButton.TabIndex = 4;
            this.allowSolicationRadioButton.TabStop = true;
            this.allowSolicationRadioButton.Text = "Yes";
            this.allowSolicationRadioButton.UseVisualStyleBackColor = true;
            // 
            // idTextBox
            // 
            this.idTextBox.Location = new System.Drawing.Point(149, 59);
            this.idTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(157, 22);
            this.idTextBox.TabIndex = 1;
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(149, 27);
            this.nameTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(157, 22);
            this.nameTextBox.TabIndex = 0;
            // 
            // inputIDlLabel
            // 
            this.inputIDlLabel.AutoSize = true;
            this.inputIDlLabel.Location = new System.Drawing.Point(51, 63);
            this.inputIDlLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.inputIDlLabel.Name = "inputIDlLabel";
            this.inputIDlLabel.Size = new System.Drawing.Size(89, 17);
            this.inputIDlLabel.TabIndex = 1;
            this.inputIDlLabel.Text = "Customer ID:";
            // 
            // inputNameLabel
            // 
            this.inputNameLabel.AutoSize = true;
            this.inputNameLabel.Location = new System.Drawing.Point(81, 31);
            this.inputNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.inputNameLabel.Name = "inputNameLabel";
            this.inputNameLabel.Size = new System.Drawing.Size(49, 17);
            this.inputNameLabel.TabIndex = 0;
            this.inputNameLabel.Text = "Name:";
            // 
            // newCustomerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(506, 247);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.customerInfoButton);
            this.Controls.Add(this.customerDataGroupBox);
            this.Name = "newCustomerForm";
            this.Text = "Add New Customer";
            this.customerDataGroupBox.ResumeLayout(false);
            this.customerDataGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label inputSolicitationLabel;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button customerInfoButton;
        private System.Windows.Forms.GroupBox customerDataGroupBox;
        private System.Windows.Forms.RadioButton preventSolicitationRadioButton;
        private System.Windows.Forms.RadioButton allowSolicationRadioButton;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Label inputIDlLabel;
        private System.Windows.Forms.Label inputNameLabel;
        private System.Windows.Forms.TextBox phoneTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox addressTextBox;
        private System.Windows.Forms.Label addressLabel;
    }
}

