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
            this.rainingWeather = new System.Windows.Forms.RadioButton();
            this.weatherSelectionGroup = new System.Windows.Forms.GroupBox();
            this.cloudyWeather = new System.Windows.Forms.RadioButton();
            this.snowingWeather = new System.Windows.Forms.RadioButton();
            this.sunnyWeather = new System.Windows.Forms.RadioButton();
            this.generateReport = new System.Windows.Forms.Button();
            this.help = new System.Windows.Forms.Label();
            this.enterNameTooltip = new System.Windows.Forms.ToolTip(this.components);
            this.errorLabel = new System.Windows.Forms.Label();
            this.personalizedWeatherInfo = new System.Windows.Forms.Label();
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
            // rainingWeather
            // 
            this.rainingWeather.AutoSize = true;
            this.rainingWeather.Location = new System.Drawing.Point(6, 42);
            this.rainingWeather.Name = "rainingWeather";
            this.rainingWeather.Size = new System.Drawing.Size(61, 17);
            this.rainingWeather.TabIndex = 3;
            this.rainingWeather.TabStop = true;
            this.rainingWeather.Text = "Raining";
            this.rainingWeather.UseVisualStyleBackColor = true;
            // 
            // weatherSelectionGroup
            // 
            this.weatherSelectionGroup.Controls.Add(this.cloudyWeather);
            this.weatherSelectionGroup.Controls.Add(this.snowingWeather);
            this.weatherSelectionGroup.Controls.Add(this.sunnyWeather);
            this.weatherSelectionGroup.Controls.Add(this.rainingWeather);
            this.weatherSelectionGroup.Location = new System.Drawing.Point(12, 66);
            this.weatherSelectionGroup.Name = "weatherSelectionGroup";
            this.weatherSelectionGroup.Size = new System.Drawing.Size(248, 76);
            this.weatherSelectionGroup.TabIndex = 5;
            this.weatherSelectionGroup.TabStop = false;
            // 
            // cloudyWeather
            // 
            this.cloudyWeather.AutoSize = true;
            this.cloudyWeather.Location = new System.Drawing.Point(67, 42);
            this.cloudyWeather.Name = "cloudyWeather";
            this.cloudyWeather.Size = new System.Drawing.Size(57, 17);
            this.cloudyWeather.TabIndex = 7;
            this.cloudyWeather.TabStop = true;
            this.cloudyWeather.Text = "Cloudy";
            this.cloudyWeather.UseVisualStyleBackColor = true;
            // 
            // snowingWeather
            // 
            this.snowingWeather.AutoSize = true;
            this.snowingWeather.Location = new System.Drawing.Point(67, 19);
            this.snowingWeather.Name = "snowingWeather";
            this.snowingWeather.Size = new System.Drawing.Size(66, 17);
            this.snowingWeather.TabIndex = 6;
            this.snowingWeather.TabStop = true;
            this.snowingWeather.Text = "Snowing";
            this.snowingWeather.UseVisualStyleBackColor = true;
            // 
            // sunnyWeather
            // 
            this.sunnyWeather.AutoSize = true;
            this.sunnyWeather.Location = new System.Drawing.Point(6, 19);
            this.sunnyWeather.Name = "sunnyWeather";
            this.sunnyWeather.Size = new System.Drawing.Size(55, 17);
            this.sunnyWeather.TabIndex = 5;
            this.sunnyWeather.TabStop = true;
            this.sunnyWeather.Text = "Sunny";
            this.sunnyWeather.UseVisualStyleBackColor = true;
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
            // personalizedWeatherInfo
            // 
            this.personalizedWeatherInfo.AutoSize = true;
            this.personalizedWeatherInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.personalizedWeatherInfo.Location = new System.Drawing.Point(9, 238);
            this.personalizedWeatherInfo.Name = "personalizedWeatherInfo";
            this.personalizedWeatherInfo.Size = new System.Drawing.Size(0, 20);
            this.personalizedWeatherInfo.TabIndex = 9;
            // 
            // WeatherReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(931, 559);
            this.Controls.Add(this.personalizedWeatherInfo);
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
        private System.Windows.Forms.RadioButton rainingWeather;
        private System.Windows.Forms.GroupBox weatherSelectionGroup;
        private System.Windows.Forms.RadioButton sunnyWeather;
        private System.Windows.Forms.RadioButton snowingWeather;
        private System.Windows.Forms.RadioButton cloudyWeather;
        private System.Windows.Forms.Button generateReport;
        private System.Windows.Forms.Label help;
        private System.Windows.Forms.ToolTip enterNameTooltip;
        private System.Windows.Forms.Label errorLabel;
        private System.Windows.Forms.Label personalizedWeatherInfo;
    }
}

