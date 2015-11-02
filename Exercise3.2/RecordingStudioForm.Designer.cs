using System.Data;
namespace Exercise3._2
{
    partial class recordingStudioForm
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
            this.table3 = new System.Data.DataTable();
            this.set1 = new System.Data.DataSet();
            this.table1 = new System.Data.DataTable();
            this.table2 = new System.Data.DataTable();
            this.set = new System.Data.DataSet();
            this.newSessionGroupBox = new System.Windows.Forms.GroupBox();
            this.sessionCostTextBox = new System.Windows.Forms.TextBox();
            this.sessionCostLabel = new System.Windows.Forms.Label();
            this.clearButton = new System.Windows.Forms.Button();
            this.addSessionButton = new System.Windows.Forms.Button();
            this.timeSpentTextBox = new System.Windows.Forms.TextBox();
            this.timeSpentLabel = new System.Windows.Forms.Label();
            this.groupNameTextBox = new System.Windows.Forms.TextBox();
            this.groupNameLabel = new System.Windows.Forms.Label();
            this.dataSet1 = new System.Data.DataSet();
            this.exitButton = new System.Windows.Forms.Button();
            this.sessionTotalsGroupBox = new System.Windows.Forms.GroupBox();
            this.numberOfChargesTextBox = new System.Windows.Forms.TextBox();
            this.numberOfChargesLabel = new System.Windows.Forms.Label();
            this.averageChargeTextBox = new System.Windows.Forms.TextBox();
            this.averageChargeLabel = new System.Windows.Forms.Label();
            this.totalChargeTextBox = new System.Windows.Forms.TextBox();
            this.totalChargeLabel = new System.Windows.Forms.Label();
            this.resetButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.table3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.set1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.table1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.table2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.set)).BeginInit();
            this.newSessionGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            this.sessionTotalsGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // table3
            // 
            this.table3.TableName = "patients";
            // 
            // set1
            // 
            this.set1.DataSetName = "office";
            this.set1.Tables.AddRange(new System.Data.DataTable[] {
            this.table3});
            // 
            // table1
            // 
            this.table1.TableName = "patients";
            // 
            // table2
            // 
            this.table2.TableName = "medications";
            // 
            // set
            // 
            this.set.DataSetName = "office";
            this.set.Tables.AddRange(new System.Data.DataTable[] {
            this.table1,
            this.table2});
            // 
            // newSessionGroupBox
            // 
            this.newSessionGroupBox.Controls.Add(this.sessionCostTextBox);
            this.newSessionGroupBox.Controls.Add(this.sessionCostLabel);
            this.newSessionGroupBox.Controls.Add(this.clearButton);
            this.newSessionGroupBox.Controls.Add(this.addSessionButton);
            this.newSessionGroupBox.Controls.Add(this.timeSpentTextBox);
            this.newSessionGroupBox.Controls.Add(this.timeSpentLabel);
            this.newSessionGroupBox.Controls.Add(this.groupNameTextBox);
            this.newSessionGroupBox.Controls.Add(this.groupNameLabel);
            this.newSessionGroupBox.Location = new System.Drawing.Point(13, 13);
            this.newSessionGroupBox.Name = "newSessionGroupBox";
            this.newSessionGroupBox.Size = new System.Drawing.Size(238, 216);
            this.newSessionGroupBox.TabIndex = 0;
            this.newSessionGroupBox.TabStop = false;
            this.newSessionGroupBox.Text = "New Session";
            // 
            // sessionCostTextBox
            // 
            this.sessionCostTextBox.Location = new System.Drawing.Point(120, 129);
            this.sessionCostTextBox.Name = "sessionCostTextBox";
            this.sessionCostTextBox.ReadOnly = true;
            this.sessionCostTextBox.Size = new System.Drawing.Size(112, 20);
            this.sessionCostTextBox.TabIndex = 7;
            // 
            // sessionCostLabel
            // 
            this.sessionCostLabel.AutoSize = true;
            this.sessionCostLabel.Location = new System.Drawing.Point(6, 132);
            this.sessionCostLabel.Name = "sessionCostLabel";
            this.sessionCostLabel.Size = new System.Drawing.Size(68, 13);
            this.sessionCostLabel.TabIndex = 6;
            this.sessionCostLabel.Text = "Session Cost";
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(6, 187);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(105, 23);
            this.clearButton.TabIndex = 5;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // addSessionButton
            // 
            this.addSessionButton.Enabled = false;
            this.addSessionButton.Location = new System.Drawing.Point(120, 187);
            this.addSessionButton.Name = "addSessionButton";
            this.addSessionButton.Size = new System.Drawing.Size(112, 23);
            this.addSessionButton.TabIndex = 4;
            this.addSessionButton.Text = "Add Session";
            this.addSessionButton.UseVisualStyleBackColor = true;
            this.addSessionButton.Click += new System.EventHandler(this.addSessionButton_Click);
            // 
            // timeSpentTextBox
            // 
            this.timeSpentTextBox.Location = new System.Drawing.Point(120, 69);
            this.timeSpentTextBox.Name = "timeSpentTextBox";
            this.timeSpentTextBox.Size = new System.Drawing.Size(112, 20);
            this.timeSpentTextBox.TabIndex = 3;
            this.timeSpentTextBox.TextChanged += new System.EventHandler(this.timeSpentTextBox_TextChanged);
            // 
            // timeSpentLabel
            // 
            this.timeSpentLabel.AutoSize = true;
            this.timeSpentLabel.Location = new System.Drawing.Point(6, 72);
            this.timeSpentLabel.Name = "timeSpentLabel";
            this.timeSpentLabel.Size = new System.Drawing.Size(98, 13);
            this.timeSpentLabel.TabIndex = 2;
            this.timeSpentLabel.Text = "Time Spent (Hours)";
            // 
            // groupNameTextBox
            // 
            this.groupNameTextBox.Location = new System.Drawing.Point(120, 32);
            this.groupNameTextBox.Name = "groupNameTextBox";
            this.groupNameTextBox.Size = new System.Drawing.Size(112, 20);
            this.groupNameTextBox.TabIndex = 1;
            // 
            // groupNameLabel
            // 
            this.groupNameLabel.AutoSize = true;
            this.groupNameLabel.Location = new System.Drawing.Point(6, 35);
            this.groupNameLabel.Name = "groupNameLabel";
            this.groupNameLabel.Size = new System.Drawing.Size(67, 13);
            this.groupNameLabel.TabIndex = 0;
            this.groupNameLabel.Text = "Group Name";
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "NewDataSet";
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(258, 259);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(104, 23);
            this.exitButton.TabIndex = 1;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // sessionTotalsGroupBox
            // 
            this.sessionTotalsGroupBox.Controls.Add(this.numberOfChargesTextBox);
            this.sessionTotalsGroupBox.Controls.Add(this.numberOfChargesLabel);
            this.sessionTotalsGroupBox.Controls.Add(this.averageChargeTextBox);
            this.sessionTotalsGroupBox.Controls.Add(this.averageChargeLabel);
            this.sessionTotalsGroupBox.Controls.Add(this.totalChargeTextBox);
            this.sessionTotalsGroupBox.Controls.Add(this.totalChargeLabel);
            this.sessionTotalsGroupBox.Location = new System.Drawing.Point(258, 13);
            this.sessionTotalsGroupBox.Name = "sessionTotalsGroupBox";
            this.sessionTotalsGroupBox.Size = new System.Drawing.Size(228, 216);
            this.sessionTotalsGroupBox.TabIndex = 2;
            this.sessionTotalsGroupBox.TabStop = false;
            this.sessionTotalsGroupBox.Text = "Session Totals";
            // 
            // numberOfChargesTextBox
            // 
            this.numberOfChargesTextBox.Location = new System.Drawing.Point(114, 105);
            this.numberOfChargesTextBox.Name = "numberOfChargesTextBox";
            this.numberOfChargesTextBox.Size = new System.Drawing.Size(108, 20);
            this.numberOfChargesTextBox.TabIndex = 13;
            // 
            // numberOfChargesLabel
            // 
            this.numberOfChargesLabel.AutoSize = true;
            this.numberOfChargesLabel.Location = new System.Drawing.Point(6, 108);
            this.numberOfChargesLabel.Name = "numberOfChargesLabel";
            this.numberOfChargesLabel.Size = new System.Drawing.Size(98, 13);
            this.numberOfChargesLabel.TabIndex = 12;
            this.numberOfChargesLabel.Text = "Number of Charges";
            // 
            // averageChargeTextBox
            // 
            this.averageChargeTextBox.Location = new System.Drawing.Point(114, 69);
            this.averageChargeTextBox.Name = "averageChargeTextBox";
            this.averageChargeTextBox.Size = new System.Drawing.Size(108, 20);
            this.averageChargeTextBox.TabIndex = 11;
            // 
            // averageChargeLabel
            // 
            this.averageChargeLabel.AutoSize = true;
            this.averageChargeLabel.Location = new System.Drawing.Point(6, 72);
            this.averageChargeLabel.Name = "averageChargeLabel";
            this.averageChargeLabel.Size = new System.Drawing.Size(84, 13);
            this.averageChargeLabel.TabIndex = 10;
            this.averageChargeLabel.Text = "Average Charge";
            // 
            // totalChargeTextBox
            // 
            this.totalChargeTextBox.Location = new System.Drawing.Point(114, 32);
            this.totalChargeTextBox.Name = "totalChargeTextBox";
            this.totalChargeTextBox.Size = new System.Drawing.Size(108, 20);
            this.totalChargeTextBox.TabIndex = 9;
            // 
            // totalChargeLabel
            // 
            this.totalChargeLabel.AutoSize = true;
            this.totalChargeLabel.Location = new System.Drawing.Point(6, 35);
            this.totalChargeLabel.Name = "totalChargeLabel";
            this.totalChargeLabel.Size = new System.Drawing.Size(68, 13);
            this.totalChargeLabel.TabIndex = 8;
            this.totalChargeLabel.Text = "Total Charge";
            // 
            // resetButton
            // 
            this.resetButton.Location = new System.Drawing.Point(368, 259);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(118, 23);
            this.resetButton.TabIndex = 3;
            this.resetButton.Text = "Reset";
            this.resetButton.UseVisualStyleBackColor = true;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // recordingStudioForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(498, 294);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.sessionTotalsGroupBox);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.newSessionGroupBox);
            this.Name = "recordingStudioForm";
            this.Text = "Recording Studio";
            ((System.ComponentModel.ISupportInitialize)(this.table3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.set1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.table1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.table2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.set)).EndInit();
            this.newSessionGroupBox.ResumeLayout(false);
            this.newSessionGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            this.sessionTotalsGroupBox.ResumeLayout(false);
            this.sessionTotalsGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox newSessionGroupBox;
        private System.Windows.Forms.TextBox sessionCostTextBox;
        private System.Windows.Forms.Label sessionCostLabel;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button addSessionButton;
        private System.Windows.Forms.TextBox timeSpentTextBox;
        private System.Windows.Forms.Label timeSpentLabel;
        private System.Windows.Forms.TextBox groupNameTextBox;
        private System.Windows.Forms.Label groupNameLabel;
        private DataTable table1;
        private DataTable table2;
        private DataSet set;
        private DataSet dataSet1;
        private DataTable table3;
        private DataSet set1;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.GroupBox sessionTotalsGroupBox;
        private System.Windows.Forms.TextBox totalChargeTextBox;
        private System.Windows.Forms.Label totalChargeLabel;
        private System.Windows.Forms.TextBox numberOfChargesTextBox;
        private System.Windows.Forms.Label numberOfChargesLabel;
        private System.Windows.Forms.TextBox averageChargeTextBox;
        private System.Windows.Forms.Label averageChargeLabel;
        private System.Windows.Forms.Button resetButton;
    }
}

