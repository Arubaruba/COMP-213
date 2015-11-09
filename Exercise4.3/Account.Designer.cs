namespace Exercise4._3
{
    partial class Account
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
            this.paymentTypesGroupBox = new System.Windows.Forms.GroupBox();
            this.serviceRadioButton = new System.Windows.Forms.RadioButton();
            this.depositRadioButton = new System.Windows.Forms.RadioButton();
            this.checkRadioButton = new System.Windows.Forms.RadioButton();
            this.amountLabel = new System.Windows.Forms.Label();
            this.totalLabel = new System.Windows.Forms.Label();
            this.amountTextBox = new System.Windows.Forms.TextBox();
            this.totalTextBox = new System.Windows.Forms.TextBox();
            this.addButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.paymentTypesGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // paymentTypesGroupBox
            // 
            this.paymentTypesGroupBox.Controls.Add(this.serviceRadioButton);
            this.paymentTypesGroupBox.Controls.Add(this.depositRadioButton);
            this.paymentTypesGroupBox.Controls.Add(this.checkRadioButton);
            this.paymentTypesGroupBox.Location = new System.Drawing.Point(13, 13);
            this.paymentTypesGroupBox.Name = "paymentTypesGroupBox";
            this.paymentTypesGroupBox.Size = new System.Drawing.Size(468, 72);
            this.paymentTypesGroupBox.TabIndex = 0;
            this.paymentTypesGroupBox.TabStop = false;
            this.paymentTypesGroupBox.Text = "Payment Types";
            // 
            // serviceRadioButton
            // 
            this.serviceRadioButton.AutoSize = true;
            this.serviceRadioButton.Location = new System.Drawing.Point(270, 29);
            this.serviceRadioButton.Name = "serviceRadioButton";
            this.serviceRadioButton.Size = new System.Drawing.Size(98, 17);
            this.serviceRadioButton.TabIndex = 2;
            this.serviceRadioButton.TabStop = true;
            this.serviceRadioButton.Text = "Service Charge";
            this.serviceRadioButton.UseVisualStyleBackColor = true;
            this.serviceRadioButton.CheckedChanged += new System.EventHandler(this.serviceRadioButton_CheckedChanged);
            // 
            // depositRadioButton
            // 
            this.depositRadioButton.AutoSize = true;
            this.depositRadioButton.Location = new System.Drawing.Point(141, 29);
            this.depositRadioButton.Name = "depositRadioButton";
            this.depositRadioButton.Size = new System.Drawing.Size(61, 17);
            this.depositRadioButton.TabIndex = 1;
            this.depositRadioButton.TabStop = true;
            this.depositRadioButton.Text = "Deposit";
            this.depositRadioButton.UseVisualStyleBackColor = true;
            this.depositRadioButton.CheckedChanged += new System.EventHandler(this.depositRadioButton_CheckedChanged);
            // 
            // checkRadioButton
            // 
            this.checkRadioButton.AutoSize = true;
            this.checkRadioButton.Location = new System.Drawing.Point(7, 29);
            this.checkRadioButton.Name = "checkRadioButton";
            this.checkRadioButton.Size = new System.Drawing.Size(56, 17);
            this.checkRadioButton.TabIndex = 0;
            this.checkRadioButton.TabStop = true;
            this.checkRadioButton.Text = "Check";
            this.checkRadioButton.UseVisualStyleBackColor = true;
            // 
            // amountLabel
            // 
            this.amountLabel.AutoSize = true;
            this.amountLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.amountLabel.Location = new System.Drawing.Point(16, 167);
            this.amountLabel.Name = "amountLabel";
            this.amountLabel.Size = new System.Drawing.Size(43, 13);
            this.amountLabel.TabIndex = 0;
            this.amountLabel.Text = "Amount";
            this.amountLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // totalLabel
            // 
            this.totalLabel.AutoSize = true;
            this.totalLabel.Location = new System.Drawing.Point(16, 203);
            this.totalLabel.Name = "totalLabel";
            this.totalLabel.Size = new System.Drawing.Size(31, 13);
            this.totalLabel.TabIndex = 3;
            this.totalLabel.Text = "Total";
            // 
            // amountTextBox
            // 
            this.amountTextBox.Location = new System.Drawing.Point(70, 164);
            this.amountTextBox.Name = "amountTextBox";
            this.amountTextBox.Size = new System.Drawing.Size(100, 20);
            this.amountTextBox.TabIndex = 1;
            this.amountTextBox.TextChanged += new System.EventHandler(this.amountTextBox_TextChanged);
            // 
            // totalTextBox
            // 
            this.totalTextBox.Location = new System.Drawing.Point(70, 200);
            this.totalTextBox.Name = "totalTextBox";
            this.totalTextBox.ReadOnly = true;
            this.totalTextBox.Size = new System.Drawing.Size(100, 20);
            this.totalTextBox.TabIndex = 4;
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(176, 162);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(75, 23);
            this.addButton.TabIndex = 2;
            this.addButton.Text = "Add";
            this.toolTip1.SetToolTip(this.addButton, "Add a new transaction");
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(406, 276);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 23);
            this.exitButton.TabIndex = 6;
            this.exitButton.Text = "Exit";
            this.toolTip1.SetToolTip(this.exitButton, "Exit this Application");
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(13, 276);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(75, 23);
            this.clearButton.TabIndex = 5;
            this.clearButton.Text = "Clear";
            this.toolTip1.SetToolTip(this.clearButton, "Reset the total amount");
            this.clearButton.UseCompatibleTextRendering = true;
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // Account
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(493, 311);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.totalTextBox);
            this.Controls.Add(this.amountTextBox);
            this.Controls.Add(this.totalLabel);
            this.Controls.Add(this.amountLabel);
            this.Controls.Add(this.paymentTypesGroupBox);
            this.Name = "Account";
            this.Text = "Account";
            this.paymentTypesGroupBox.ResumeLayout(false);
            this.paymentTypesGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox paymentTypesGroupBox;
        private System.Windows.Forms.Label amountLabel;
        private System.Windows.Forms.Label totalLabel;
        private System.Windows.Forms.TextBox amountTextBox;
        private System.Windows.Forms.TextBox totalTextBox;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.RadioButton serviceRadioButton;
        private System.Windows.Forms.RadioButton depositRadioButton;
        private System.Windows.Forms.RadioButton checkRadioButton;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}