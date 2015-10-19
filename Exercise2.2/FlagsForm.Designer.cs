namespace Exercise2._2
{
    partial class FlagsForm
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
            this.countryFlagPictureBox = new System.Windows.Forms.PictureBox();
            this.countryNameLabel = new System.Windows.Forms.Label();
            this.printButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.countriesGroupBox = new System.Windows.Forms.GroupBox();
            this.kenyaRadioButton = new System.Windows.Forms.RadioButton();
            this.indiaRadioButton = new System.Windows.Forms.RadioButton();
            this.canadaRadioButton = new System.Windows.Forms.RadioButton();
            this.usRadioButton = new System.Windows.Forms.RadioButton();
            this.showCountryLabelCheckBox = new System.Windows.Forms.CheckBox();
            this.showFormTitleCheckBox = new System.Windows.Forms.CheckBox();
            this.showProgrammerNameCheckBox = new System.Windows.Forms.CheckBox();
            this.formTitleLabel = new System.Windows.Forms.Label();
            this.developerNameLabel = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.countryFlagPictureBox)).BeginInit();
            this.countriesGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // countryFlagPictureBox
            // 
            this.countryFlagPictureBox.BackgroundImage = global::Exercise2._2.FlagImages.us;
            this.countryFlagPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.countryFlagPictureBox.Location = new System.Drawing.Point(256, 61);
            this.countryFlagPictureBox.Name = "countryFlagPictureBox";
            this.countryFlagPictureBox.Size = new System.Drawing.Size(200, 136);
            this.countryFlagPictureBox.TabIndex = 1;
            this.countryFlagPictureBox.TabStop = false;
            // 
            // countryNameLabel
            // 
            this.countryNameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.countryNameLabel.AutoSize = true;
            this.countryNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.countryNameLabel.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.countryNameLabel.Location = new System.Drawing.Point(335, 210);
            this.countryNameLabel.Name = "countryNameLabel";
            this.countryNameLabel.Size = new System.Drawing.Size(46, 29);
            this.countryNameLabel.TabIndex = 5;
            this.countryNameLabel.Text = "US";
            this.countryNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // printButton
            // 
            this.printButton.Location = new System.Drawing.Point(387, 356);
            this.printButton.Name = "printButton";
            this.printButton.Size = new System.Drawing.Size(75, 23);
            this.printButton.TabIndex = 8;
            this.printButton.Text = "Print";
            this.printButton.UseVisualStyleBackColor = true;
            this.printButton.Click += new System.EventHandler(this.printButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(306, 356);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 9;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // countriesGroupBox
            // 
            this.countriesGroupBox.Controls.Add(this.kenyaRadioButton);
            this.countriesGroupBox.Controls.Add(this.indiaRadioButton);
            this.countriesGroupBox.Controls.Add(this.canadaRadioButton);
            this.countriesGroupBox.Controls.Add(this.usRadioButton);
            this.countriesGroupBox.Location = new System.Drawing.Point(12, 61);
            this.countriesGroupBox.Name = "countriesGroupBox";
            this.countriesGroupBox.Size = new System.Drawing.Size(159, 75);
            this.countriesGroupBox.TabIndex = 10;
            this.countriesGroupBox.TabStop = false;
            this.countriesGroupBox.Text = "Countries";
            // 
            // kenyaRadioButton
            // 
            this.kenyaRadioButton.AutoSize = true;
            this.kenyaRadioButton.Location = new System.Drawing.Point(98, 44);
            this.kenyaRadioButton.Name = "kenyaRadioButton";
            this.kenyaRadioButton.Size = new System.Drawing.Size(55, 17);
            this.kenyaRadioButton.TabIndex = 3;
            this.kenyaRadioButton.Text = "Kenya";
            this.kenyaRadioButton.UseVisualStyleBackColor = true;
            this.kenyaRadioButton.CheckedChanged += new System.EventHandler(this.kenyaRadioButton_CheckedChanged);
            // 
            // indiaRadioButton
            // 
            this.indiaRadioButton.AutoSize = true;
            this.indiaRadioButton.Location = new System.Drawing.Point(98, 20);
            this.indiaRadioButton.Name = "indiaRadioButton";
            this.indiaRadioButton.Size = new System.Drawing.Size(48, 17);
            this.indiaRadioButton.TabIndex = 2;
            this.indiaRadioButton.Text = "India";
            this.indiaRadioButton.UseVisualStyleBackColor = true;
            this.indiaRadioButton.CheckedChanged += new System.EventHandler(this.indiaRadioButton_CheckedChanged);
            // 
            // canadaRadioButton
            // 
            this.canadaRadioButton.AutoSize = true;
            this.canadaRadioButton.Location = new System.Drawing.Point(7, 44);
            this.canadaRadioButton.Name = "canadaRadioButton";
            this.canadaRadioButton.Size = new System.Drawing.Size(62, 17);
            this.canadaRadioButton.TabIndex = 1;
            this.canadaRadioButton.Text = "Canada";
            this.canadaRadioButton.UseVisualStyleBackColor = true;
            this.canadaRadioButton.CheckedChanged += new System.EventHandler(this.canadaRadioButton_CheckedChanged);
            // 
            // usRadioButton
            // 
            this.usRadioButton.AutoSize = true;
            this.usRadioButton.Checked = true;
            this.usRadioButton.Location = new System.Drawing.Point(7, 21);
            this.usRadioButton.Name = "usRadioButton";
            this.usRadioButton.Size = new System.Drawing.Size(40, 17);
            this.usRadioButton.TabIndex = 0;
            this.usRadioButton.TabStop = true;
            this.usRadioButton.Text = "US";
            this.usRadioButton.UseVisualStyleBackColor = true;
            this.usRadioButton.CheckedChanged += new System.EventHandler(this.usRadioButton_CheckedChanged);
            // 
            // showCountryLabelCheckBox
            // 
            this.showCountryLabelCheckBox.AutoSize = true;
            this.showCountryLabelCheckBox.Checked = true;
            this.showCountryLabelCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.showCountryLabelCheckBox.Location = new System.Drawing.Point(12, 337);
            this.showCountryLabelCheckBox.Name = "showCountryLabelCheckBox";
            this.showCountryLabelCheckBox.Size = new System.Drawing.Size(152, 17);
            this.showCountryLabelCheckBox.TabIndex = 11;
            this.showCountryLabelCheckBox.Text = "Show Country Name Label";
            this.showCountryLabelCheckBox.UseVisualStyleBackColor = true;
            this.showCountryLabelCheckBox.CheckedChanged += new System.EventHandler(this.showCountryLabelCheckBox_CheckedChanged);
            // 
            // showFormTitleCheckBox
            // 
            this.showFormTitleCheckBox.AutoSize = true;
            this.showFormTitleCheckBox.Checked = true;
            this.showFormTitleCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.showFormTitleCheckBox.Location = new System.Drawing.Point(11, 314);
            this.showFormTitleCheckBox.Name = "showFormTitleCheckBox";
            this.showFormTitleCheckBox.Size = new System.Drawing.Size(72, 17);
            this.showFormTitleCheckBox.TabIndex = 12;
            this.showFormTitleCheckBox.Text = "Form Title";
            this.showFormTitleCheckBox.UseVisualStyleBackColor = true;
            this.showFormTitleCheckBox.CheckedChanged += new System.EventHandler(this.showFormTitleCheckBox_CheckedChanged);
            // 
            // showProgrammerNameCheckBox
            // 
            this.showProgrammerNameCheckBox.AutoSize = true;
            this.showProgrammerNameCheckBox.Checked = true;
            this.showProgrammerNameCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.showProgrammerNameCheckBox.Location = new System.Drawing.Point(11, 360);
            this.showProgrammerNameCheckBox.Name = "showProgrammerNameCheckBox";
            this.showProgrammerNameCheckBox.Size = new System.Drawing.Size(113, 17);
            this.showProgrammerNameCheckBox.TabIndex = 13;
            this.showProgrammerNameCheckBox.Text = "Programmer Name";
            this.showProgrammerNameCheckBox.UseVisualStyleBackColor = true;
            this.showProgrammerNameCheckBox.CheckedChanged += new System.EventHandler(this.showProgrammerNameCheckBox_CheckedChanged);
            // 
            // formTitleLabel
            // 
            this.formTitleLabel.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.formTitleLabel.AutoEllipsis = true;
            this.formTitleLabel.AutoSize = true;
            this.formTitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.formTitleLabel.Location = new System.Drawing.Point(14, 18);
            this.formTitleLabel.Name = "formTitleLabel";
            this.formTitleLabel.Size = new System.Drawing.Size(168, 29);
            this.formTitleLabel.TabIndex = 14;
            this.formTitleLabel.Text = "National Flags";
            // 
            // developerNameLabel
            // 
            this.developerNameLabel.AutoSize = true;
            this.developerNameLabel.Location = new System.Drawing.Point(301, 30);
            this.developerNameLabel.Name = "developerNameLabel";
            this.developerNameLabel.Size = new System.Drawing.Size(155, 13);
            this.developerNameLabel.TabIndex = 15;
            this.developerNameLabel.TabStop = true;
            this.developerNameLabel.Text = "Developed by Andreas Stocker";
            this.developerNameLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.developerNameLabel_LinkClicked);
            // 
            // FlagsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(472, 388);
            this.Controls.Add(this.developerNameLabel);
            this.Controls.Add(this.formTitleLabel);
            this.Controls.Add(this.showProgrammerNameCheckBox);
            this.Controls.Add(this.showFormTitleCheckBox);
            this.Controls.Add(this.showCountryLabelCheckBox);
            this.Controls.Add(this.countriesGroupBox);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.printButton);
            this.Controls.Add(this.countryNameLabel);
            this.Controls.Add(this.countryFlagPictureBox);
            this.Name = "FlagsForm";
            this.Text = "Flags";
            ((System.ComponentModel.ISupportInitialize)(this.countryFlagPictureBox)).EndInit();
            this.countriesGroupBox.ResumeLayout(false);
            this.countriesGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox countryFlagPictureBox;
        private System.Windows.Forms.Label countryNameLabel;
        private System.Windows.Forms.Button printButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.GroupBox countriesGroupBox;
        private System.Windows.Forms.RadioButton kenyaRadioButton;
        private System.Windows.Forms.RadioButton indiaRadioButton;
        private System.Windows.Forms.RadioButton canadaRadioButton;
        private System.Windows.Forms.RadioButton usRadioButton;
        private System.Windows.Forms.CheckBox showCountryLabelCheckBox;
        private System.Windows.Forms.CheckBox showFormTitleCheckBox;
        private System.Windows.Forms.CheckBox showProgrammerNameCheckBox;
        private System.Windows.Forms.Label formTitleLabel;
        private System.Windows.Forms.LinkLabel developerNameLabel;
    }
}

