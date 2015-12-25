namespace Exercise6._2
{
    partial class AutoShop
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.calculateToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.clearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.calculateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.jobNumberLabel = new System.Windows.Forms.Label();
            this.customerNameLabel = new System.Windows.Forms.Label();
            this.amountChargedLabel = new System.Windows.Forms.Label();
            this.jobNumberTextBox = new System.Windows.Forms.TextBox();
            this.customerNameTextBox = new System.Windows.Forms.TextBox();
            this.amountChargedTextBox = new System.Windows.Forms.TextBox();
            this.hoursOfLaborTextBox = new System.Windows.Forms.TextBox();
            this.hoursOfLaborLabel = new System.Windows.Forms.Label();
            this.subtotalTextBox = new System.Windows.Forms.TextBox();
            this.subtotalLabel = new System.Windows.Forms.Label();
            this.salesTaxTextBox = new System.Windows.Forms.TextBox();
            this.salesTaxLabel = new System.Windows.Forms.Label();
            this.calculateButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.totalTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.summaryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.calculateToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(293, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.summaryToolStripMenuItem,
            this.toolStripSeparator1,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(92, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.calculateToolStripMenuItem1,
            this.clearToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // calculateToolStripMenuItem1
            // 
            this.calculateToolStripMenuItem1.Name = "calculateToolStripMenuItem1";
            this.calculateToolStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.C)));
            this.calculateToolStripMenuItem1.Size = new System.Drawing.Size(161, 22);
            this.calculateToolStripMenuItem1.Text = "Calculate";
            this.calculateToolStripMenuItem1.Click += new System.EventHandler(this.calculateToolStripMenuItem1_Click);
            // 
            // clearToolStripMenuItem
            // 
            this.clearToolStripMenuItem.Name = "clearToolStripMenuItem";
            this.clearToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.L)));
            this.clearToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.clearToolStripMenuItem.Text = "Clear";
            this.clearToolStripMenuItem.Click += new System.EventHandler(this.clearToolStripMenuItem_Click);
            // 
            // calculateToolStripMenuItem
            // 
            this.calculateToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.calculateToolStripMenuItem.Name = "calculateToolStripMenuItem";
            this.calculateToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.calculateToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F1;
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // jobNumberLabel
            // 
            this.jobNumberLabel.AutoSize = true;
            this.jobNumberLabel.Location = new System.Drawing.Point(12, 35);
            this.jobNumberLabel.Name = "jobNumberLabel";
            this.jobNumberLabel.Size = new System.Drawing.Size(64, 13);
            this.jobNumberLabel.TabIndex = 1;
            this.jobNumberLabel.Text = "Job Number";
            // 
            // customerNameLabel
            // 
            this.customerNameLabel.AutoSize = true;
            this.customerNameLabel.Location = new System.Drawing.Point(12, 61);
            this.customerNameLabel.Name = "customerNameLabel";
            this.customerNameLabel.Size = new System.Drawing.Size(82, 13);
            this.customerNameLabel.TabIndex = 2;
            this.customerNameLabel.Text = "Customer Name";
            // 
            // amountChargedLabel
            // 
            this.amountChargedLabel.AutoSize = true;
            this.amountChargedLabel.Location = new System.Drawing.Point(12, 87);
            this.amountChargedLabel.Name = "amountChargedLabel";
            this.amountChargedLabel.Size = new System.Drawing.Size(128, 13);
            this.amountChargedLabel.TabIndex = 3;
            this.amountChargedLabel.Text = "Amount Charged for Parts";
            // 
            // jobNumberTextBox
            // 
            this.jobNumberTextBox.Location = new System.Drawing.Point(180, 32);
            this.jobNumberTextBox.Name = "jobNumberTextBox";
            this.jobNumberTextBox.Size = new System.Drawing.Size(100, 20);
            this.jobNumberTextBox.TabIndex = 4;
            // 
            // customerNameTextBox
            // 
            this.customerNameTextBox.Location = new System.Drawing.Point(180, 58);
            this.customerNameTextBox.Name = "customerNameTextBox";
            this.customerNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.customerNameTextBox.TabIndex = 5;
            // 
            // amountChargedTextBox
            // 
            this.amountChargedTextBox.Location = new System.Drawing.Point(180, 84);
            this.amountChargedTextBox.Name = "amountChargedTextBox";
            this.amountChargedTextBox.Size = new System.Drawing.Size(100, 20);
            this.amountChargedTextBox.TabIndex = 6;
            // 
            // hoursOfLaborTextBox
            // 
            this.hoursOfLaborTextBox.Location = new System.Drawing.Point(180, 110);
            this.hoursOfLaborTextBox.Name = "hoursOfLaborTextBox";
            this.hoursOfLaborTextBox.Size = new System.Drawing.Size(100, 20);
            this.hoursOfLaborTextBox.TabIndex = 8;
            // 
            // hoursOfLaborLabel
            // 
            this.hoursOfLaborLabel.AutoSize = true;
            this.hoursOfLaborLabel.Location = new System.Drawing.Point(12, 113);
            this.hoursOfLaborLabel.Name = "hoursOfLaborLabel";
            this.hoursOfLaborLabel.Size = new System.Drawing.Size(77, 13);
            this.hoursOfLaborLabel.TabIndex = 7;
            this.hoursOfLaborLabel.Text = "Hours of Labor";
            // 
            // subtotalTextBox
            // 
            this.subtotalTextBox.Location = new System.Drawing.Point(180, 169);
            this.subtotalTextBox.Name = "subtotalTextBox";
            this.subtotalTextBox.ReadOnly = true;
            this.subtotalTextBox.Size = new System.Drawing.Size(100, 20);
            this.subtotalTextBox.TabIndex = 10;
            // 
            // subtotalLabel
            // 
            this.subtotalLabel.AutoSize = true;
            this.subtotalLabel.Location = new System.Drawing.Point(12, 172);
            this.subtotalLabel.Name = "subtotalLabel";
            this.subtotalLabel.Size = new System.Drawing.Size(46, 13);
            this.subtotalLabel.TabIndex = 9;
            this.subtotalLabel.Text = "Subtotal";
            // 
            // salesTaxTextBox
            // 
            this.salesTaxTextBox.Location = new System.Drawing.Point(180, 195);
            this.salesTaxTextBox.Name = "salesTaxTextBox";
            this.salesTaxTextBox.ReadOnly = true;
            this.salesTaxTextBox.Size = new System.Drawing.Size(100, 20);
            this.salesTaxTextBox.TabIndex = 12;
            // 
            // salesTaxLabel
            // 
            this.salesTaxLabel.AutoSize = true;
            this.salesTaxLabel.Location = new System.Drawing.Point(12, 198);
            this.salesTaxLabel.Name = "salesTaxLabel";
            this.salesTaxLabel.Size = new System.Drawing.Size(54, 13);
            this.salesTaxLabel.TabIndex = 11;
            this.salesTaxLabel.Text = "Sales Tax";
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(12, 267);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(75, 23);
            this.calculateButton.TabIndex = 13;
            this.calculateButton.Text = "Calculate";
            this.toolTip1.SetToolTip(this.calculateButton, "Calculate Charges");
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(205, 267);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(75, 23);
            this.clearButton.TabIndex = 14;
            this.clearButton.Text = "Clear";
            this.toolTip1.SetToolTip(this.clearButton, "Reset Fields");
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // totalTextBox
            // 
            this.totalTextBox.Location = new System.Drawing.Point(180, 221);
            this.totalTextBox.Name = "totalTextBox";
            this.totalTextBox.ReadOnly = true;
            this.totalTextBox.Size = new System.Drawing.Size(100, 20);
            this.totalTextBox.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 221);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Total";
            // 
            // summaryToolStripMenuItem
            // 
            this.summaryToolStripMenuItem.Name = "summaryToolStripMenuItem";
            this.summaryToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.summaryToolStripMenuItem.Text = "Summary";
            this.summaryToolStripMenuItem.Click += new System.EventHandler(this.summaryToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(149, 6);
            // 
            // AutoShop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(293, 303);
            this.Controls.Add(this.totalTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.salesTaxTextBox);
            this.Controls.Add(this.salesTaxLabel);
            this.Controls.Add(this.subtotalTextBox);
            this.Controls.Add(this.subtotalLabel);
            this.Controls.Add(this.hoursOfLaborTextBox);
            this.Controls.Add(this.hoursOfLaborLabel);
            this.Controls.Add(this.amountChargedTextBox);
            this.Controls.Add(this.customerNameTextBox);
            this.Controls.Add(this.jobNumberTextBox);
            this.Controls.Add(this.amountChargedLabel);
            this.Controls.Add(this.customerNameLabel);
            this.Controls.Add(this.jobNumberLabel);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "AutoShop";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pat\'s Auto Repair Shop";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem calculateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem calculateToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem clearToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Label jobNumberLabel;
        private System.Windows.Forms.Label customerNameLabel;
        private System.Windows.Forms.Label amountChargedLabel;
        private System.Windows.Forms.TextBox jobNumberTextBox;
        private System.Windows.Forms.TextBox customerNameTextBox;
        private System.Windows.Forms.TextBox amountChargedTextBox;
        private System.Windows.Forms.TextBox hoursOfLaborTextBox;
        private System.Windows.Forms.Label hoursOfLaborLabel;
        private System.Windows.Forms.TextBox subtotalTextBox;
        private System.Windows.Forms.Label subtotalLabel;
        private System.Windows.Forms.TextBox salesTaxTextBox;
        private System.Windows.Forms.Label salesTaxLabel;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.TextBox totalTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ToolStripMenuItem summaryToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
    }
}

