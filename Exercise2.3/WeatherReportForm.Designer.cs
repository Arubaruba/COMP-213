namespace Exercise2._3
{
    partial class WeatherReportForm
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
            this.customerName = new System.Windows.Forms.TextBox();
            this.sunnyWeather = new System.Windows.Forms.RadioButton();
            this.weatherSelectionGroup = new System.Windows.Forms.GroupBox();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.generateReport = new System.Windows.Forms.Button();
            this.help = new System.Windows.Forms.Label();
            this.enterNameTooltip = new System.Windows.Forms.ToolTip(this.components);
            this.errorLabel = new System.Windows.Forms.Label();
            this.weatherSelectionGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // customerName
            // 
            this.customerName.Location = new System.Drawing.Point(12, 40);
            this.customerName.Name = "customerName";
            this.customerName.Size = new System.Drawing.Size(248, 20);
            this.customerName.TabIndex = 0;
            this.enterNameTooltip.SetToolTip(this.customerName, "Your full name: ie. John Smith");
            // 
            // sunnyWeather
            // 
            this.sunnyWeather.AutoSize = true;
            this.sunnyWeather.Location = new System.Drawing.Point(6, 42);
            this.sunnyWeather.Name = "sunnyWeather";
            this.sunnyWeather.Size = new System.Drawing.Size(47, 17);
            this.sunnyWeather.TabIndex = 3;
            this.sunnyWeather.TabStop = true;
            this.sunnyWeather.Text = "Rain";
            this.sunnyWeather.UseVisualStyleBackColor = true;
            // 
            // weatherSelectionGroup
            // 
            this.weatherSelectionGroup.Controls.Add(this.radioButton3);
            this.weatherSelectionGroup.Controls.Add(this.radioButton2);
            this.weatherSelectionGroup.Controls.Add(this.radioButton1);
            this.weatherSelectionGroup.Controls.Add(this.sunnyWeather);
            this.weatherSelectionGroup.Location = new System.Drawing.Point(12, 66);
            this.weatherSelectionGroup.Name = "weatherSelectionGroup";
            this.weatherSelectionGroup.Size = new System.Drawing.Size(248, 76);
            this.weatherSelectionGroup.TabIndex = 5;
            this.weatherSelectionGroup.TabStop = false;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(67, 42);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(57, 17);
            this.radioButton3.TabIndex = 7;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "Cloudy";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(67, 19);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(52, 17);
            this.radioButton2.TabIndex = 6;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Snow";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(6, 19);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(55, 17);
            this.radioButton1.TabIndex = 5;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Sunny";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // generateReport
            // 
            this.generateReport.Location = new System.Drawing.Point(12, 148);
            this.generateReport.Name = "generateReport";
            this.generateReport.Size = new System.Drawing.Size(248, 23);
            this.generateReport.TabIndex = 6;
            this.generateReport.Text = "Generate Report (Enter)";
            this.generateReport.UseVisualStyleBackColor = true;
            this.generateReport.Click += new System.EventHandler(this.generateReport_Click);
            // 
            // help
            // 
            this.help.AutoSize = true;
            this.help.Location = new System.Drawing.Point(9, 9);
            this.help.Name = "help";
            this.help.Size = new System.Drawing.Size(390, 13);
            this.help.TabIndex = 7;
            this.help.Text = "Please enter your name and select a weather type then press \"Generate Report\".";
            // 
            // errorLabel
            // 
            this.errorLabel.AutoSize = true;
            this.errorLabel.ForeColor = System.Drawing.Color.DarkRed;
            this.errorLabel.Location = new System.Drawing.Point(12, 194);
            this.errorLabel.Name = "errorLabel";
            this.errorLabel.Size = new System.Drawing.Size(0, 13);
            this.errorLabel.TabIndex = 8;
            // 
            // WeatherReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(931, 559);
            this.Controls.Add(this.errorLabel);
            this.Controls.Add(this.help);
            this.Controls.Add(this.generateReport);
            this.Controls.Add(this.weatherSelectionGroup);
            this.Controls.Add(this.customerName);
            this.Name = "WeatherReportForm";
            this.Text = "Weather Report";
            this.weatherSelectionGroup.ResumeLayout(false);
            this.weatherSelectionGroup.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox customerName;
        private System.Windows.Forms.RadioButton sunnyWeather;
        private System.Windows.Forms.GroupBox weatherSelectionGroup;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.Button generateReport;
        private System.Windows.Forms.Label help;
        private System.Windows.Forms.ToolTip enterNameTooltip;
        private System.Windows.Forms.Label errorLabel;
    }
}

