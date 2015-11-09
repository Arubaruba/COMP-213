namespace Exercise6._2
{
    partial class Splash
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
            this.autoshopNameLabel = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.closeButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // autoshopNameLabel
            // 
            this.autoshopNameLabel.AutoSize = true;
            this.autoshopNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F);
            this.autoshopNameLabel.Location = new System.Drawing.Point(13, 98);
            this.autoshopNameLabel.Name = "autoshopNameLabel";
            this.autoshopNameLabel.Size = new System.Drawing.Size(259, 29);
            this.autoshopNameLabel.TabIndex = 0;
            this.autoshopNameLabel.Text = "Pat’s auto repair shop";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(113, 200);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(137, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "View Inventory";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // closeButton
            // 
            this.closeButton.Location = new System.Drawing.Point(33, 200);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(61, 23);
            this.closeButton.TabIndex = 2;
            this.closeButton.Text = "Close";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // Splash
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.autoshopNameLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Splash";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Splash";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label autoshopNameLabel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button closeButton;
    }
}