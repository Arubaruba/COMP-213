namespace Exercise7._1
{
    partial class StudentInfo
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
            this.highSchoolLabel = new System.Windows.Forms.Label();
            this.highSchoolComboBox = new System.Windows.Forms.ComboBox();
            this.majorLabel = new System.Windows.Forms.Label();
            this.majorComboBox = new System.Windows.Forms.ComboBox();
            this.deansListCheckBox = new System.Windows.Forms.CheckBox();
            this.seniorRadioButton = new System.Windows.Forms.RadioButton();
            this.sophmoreRadioButton = new System.Windows.Forms.RadioButton();
            this.juniorRadioButton = new System.Windows.Forms.RadioButton();
            this.freshmanRadioButton = new System.Windows.Forms.RadioButton();
            this.studentNameTextBox = new System.Windows.Forms.TextBox();
            this.unitsCompletedNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.studentNameLabel = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printSchoolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addHighSchoolToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.okButton = new System.Windows.Forms.Button();
            this.printButton = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.unitsCompletedNumericUpDown)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // highSchoolLabel
            // 
            this.highSchoolLabel.AutoSize = true;
            this.highSchoolLabel.Location = new System.Drawing.Point(14, 161);
            this.highSchoolLabel.Name = "highSchoolLabel";
            this.highSchoolLabel.Size = new System.Drawing.Size(65, 13);
            this.highSchoolLabel.TabIndex = 24;
            this.highSchoolLabel.Text = "High School";
            // 
            // highSchoolComboBox
            // 
            this.highSchoolComboBox.FormattingEnabled = true;
            this.highSchoolComboBox.Items.AddRange(new object[] {
            "Franklin",
            "Highland",
            "Midtown",
            "West Highland"});
            this.highSchoolComboBox.Location = new System.Drawing.Point(104, 158);
            this.highSchoolComboBox.Name = "highSchoolComboBox";
            this.highSchoolComboBox.Size = new System.Drawing.Size(121, 21);
            this.highSchoolComboBox.Sorted = true;
            this.highSchoolComboBox.TabIndex = 23;
            // 
            // majorLabel
            // 
            this.majorLabel.AutoSize = true;
            this.majorLabel.Location = new System.Drawing.Point(273, 161);
            this.majorLabel.Name = "majorLabel";
            this.majorLabel.Size = new System.Drawing.Size(33, 13);
            this.majorLabel.TabIndex = 22;
            this.majorLabel.Text = "Major";
            // 
            // majorComboBox
            // 
            this.majorComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.majorComboBox.FormattingEnabled = true;
            this.majorComboBox.Items.AddRange(new object[] {
            "Accounting",
            "Business",
            "Computer Information Systems",
            "Marketing"});
            this.majorComboBox.Location = new System.Drawing.Point(312, 158);
            this.majorComboBox.Name = "majorComboBox";
            this.majorComboBox.Size = new System.Drawing.Size(160, 21);
            this.majorComboBox.TabIndex = 21;
            // 
            // deansListCheckBox
            // 
            this.deansListCheckBox.AutoSize = true;
            this.deansListCheckBox.Location = new System.Drawing.Point(14, 207);
            this.deansListCheckBox.Name = "deansListCheckBox";
            this.deansListCheckBox.Size = new System.Drawing.Size(78, 17);
            this.deansListCheckBox.TabIndex = 20;
            this.deansListCheckBox.Text = "Dean\'s List";
            this.toolTip1.SetToolTip(this.deansListCheckBox, "Put this student on the Dean\'s list");
            this.deansListCheckBox.UseVisualStyleBackColor = true;
            // 
            // seniorRadioButton
            // 
            this.seniorRadioButton.AutoSize = true;
            this.seniorRadioButton.Location = new System.Drawing.Point(399, 91);
            this.seniorRadioButton.Name = "seniorRadioButton";
            this.seniorRadioButton.Size = new System.Drawing.Size(55, 17);
            this.seniorRadioButton.TabIndex = 19;
            this.seniorRadioButton.TabStop = true;
            this.seniorRadioButton.Text = "Senior";
            this.seniorRadioButton.UseVisualStyleBackColor = true;
            this.seniorRadioButton.CheckedChanged += new System.EventHandler(this.seniorRadioButton_CheckedChanged);
            // 
            // sophmoreRadioButton
            // 
            this.sophmoreRadioButton.AutoSize = true;
            this.sophmoreRadioButton.Location = new System.Drawing.Point(399, 49);
            this.sophmoreRadioButton.Name = "sophmoreRadioButton";
            this.sophmoreRadioButton.Size = new System.Drawing.Size(73, 17);
            this.sophmoreRadioButton.TabIndex = 18;
            this.sophmoreRadioButton.TabStop = true;
            this.sophmoreRadioButton.Text = "Sophmore";
            this.sophmoreRadioButton.UseVisualStyleBackColor = true;
            this.sophmoreRadioButton.CheckedChanged += new System.EventHandler(this.sophmoreRadioButton_CheckedChanged);
            // 
            // juniorRadioButton
            // 
            this.juniorRadioButton.AutoSize = true;
            this.juniorRadioButton.Location = new System.Drawing.Point(276, 91);
            this.juniorRadioButton.Name = "juniorRadioButton";
            this.juniorRadioButton.Size = new System.Drawing.Size(53, 17);
            this.juniorRadioButton.TabIndex = 17;
            this.juniorRadioButton.TabStop = true;
            this.juniorRadioButton.Text = "Junior";
            this.juniorRadioButton.UseVisualStyleBackColor = true;
            this.juniorRadioButton.CheckedChanged += new System.EventHandler(this.juniorRadioButton_CheckedChanged);
            // 
            // freshmanRadioButton
            // 
            this.freshmanRadioButton.AutoSize = true;
            this.freshmanRadioButton.Location = new System.Drawing.Point(276, 49);
            this.freshmanRadioButton.Name = "freshmanRadioButton";
            this.freshmanRadioButton.Size = new System.Drawing.Size(71, 17);
            this.freshmanRadioButton.TabIndex = 13;
            this.freshmanRadioButton.TabStop = true;
            this.freshmanRadioButton.Text = "Freshman";
            this.freshmanRadioButton.UseVisualStyleBackColor = true;
            this.freshmanRadioButton.CheckedChanged += new System.EventHandler(this.freshmanRadioButton_CheckedChanged);
            // 
            // studentNameTextBox
            // 
            this.studentNameTextBox.Location = new System.Drawing.Point(104, 48);
            this.studentNameTextBox.Name = "studentNameTextBox";
            this.studentNameTextBox.Size = new System.Drawing.Size(121, 20);
            this.studentNameTextBox.TabIndex = 16;
            // 
            // unitsCompletedNumericUpDown
            // 
            this.unitsCompletedNumericUpDown.Location = new System.Drawing.Point(104, 91);
            this.unitsCompletedNumericUpDown.Name = "unitsCompletedNumericUpDown";
            this.unitsCompletedNumericUpDown.Size = new System.Drawing.Size(121, 20);
            this.unitsCompletedNumericUpDown.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Units Completed";
            // 
            // studentNameLabel
            // 
            this.studentNameLabel.AutoSize = true;
            this.studentNameLabel.Location = new System.Drawing.Point(12, 51);
            this.studentNameLabel.Name = "studentNameLabel";
            this.studentNameLabel.Size = new System.Drawing.Size(35, 13);
            this.studentNameLabel.TabIndex = 12;
            this.studentNameLabel.Text = "Name";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(486, 24);
            this.menuStrip1.TabIndex = 25;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.printSchoolsToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // printSchoolsToolStripMenuItem
            // 
            this.printSchoolsToolStripMenuItem.Name = "printSchoolsToolStripMenuItem";
            this.printSchoolsToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.printSchoolsToolStripMenuItem.Text = "Print Schools";
            this.printSchoolsToolStripMenuItem.Click += new System.EventHandler(this.printSchoolsToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addHighSchoolToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // addHighSchoolToolStripMenuItem
            // 
            this.addHighSchoolToolStripMenuItem.Name = "addHighSchoolToolStripMenuItem";
            this.addHighSchoolToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.addHighSchoolToolStripMenuItem.Text = "Add High School";
            this.addHighSchoolToolStripMenuItem.Click += new System.EventHandler(this.addHighSchoolToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // okButton
            // 
            this.okButton.Location = new System.Drawing.Point(399, 269);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(75, 23);
            this.okButton.TabIndex = 26;
            this.okButton.Text = "OK";
            this.toolTip1.SetToolTip(this.okButton, "Clear form and reset focus");
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // printButton
            // 
            this.printButton.Location = new System.Drawing.Point(12, 269);
            this.printButton.Name = "printButton";
            this.printButton.Size = new System.Drawing.Size(75, 23);
            this.printButton.TabIndex = 27;
            this.printButton.Text = "Print";
            this.toolTip1.SetToolTip(this.printButton, "Open print preview");
            this.printButton.UseVisualStyleBackColor = true;
            this.printButton.Click += new System.EventHandler(this.printButton_Click);
            // 
            // StudentInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(486, 304);
            this.Controls.Add(this.printButton);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.highSchoolLabel);
            this.Controls.Add(this.highSchoolComboBox);
            this.Controls.Add(this.majorLabel);
            this.Controls.Add(this.majorComboBox);
            this.Controls.Add(this.deansListCheckBox);
            this.Controls.Add(this.seniorRadioButton);
            this.Controls.Add(this.sophmoreRadioButton);
            this.Controls.Add(this.juniorRadioButton);
            this.Controls.Add(this.freshmanRadioButton);
            this.Controls.Add(this.studentNameTextBox);
            this.Controls.Add(this.unitsCompletedNumericUpDown);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.studentNameLabel);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "StudentInfo";
            this.Text = "Student Information";
            ((System.ComponentModel.ISupportInitialize)(this.unitsCompletedNumericUpDown)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label highSchoolLabel;
        private System.Windows.Forms.ComboBox highSchoolComboBox;
        private System.Windows.Forms.Label majorLabel;
        private System.Windows.Forms.ComboBox majorComboBox;
        private System.Windows.Forms.CheckBox deansListCheckBox;
        private System.Windows.Forms.RadioButton seniorRadioButton;
        private System.Windows.Forms.RadioButton sophmoreRadioButton;
        private System.Windows.Forms.RadioButton juniorRadioButton;
        private System.Windows.Forms.RadioButton freshmanRadioButton;
        private System.Windows.Forms.TextBox studentNameTextBox;
        private System.Windows.Forms.NumericUpDown unitsCompletedNumericUpDown;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label studentNameLabel;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.Button printButton;
        private System.Windows.Forms.ToolStripMenuItem printSchoolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addHighSchoolToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}

