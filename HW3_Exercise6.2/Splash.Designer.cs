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
            this.SuspendLayout();
            // 
            // autoshopNameLabel
            // 
            this.autoshopNameLabel.AutoSize = true;
            this.autoshopNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F);
            this.autoshopNameLabel.Location = new System.Drawing.Point(12, 109);
            this.autoshopNameLabel.Name = "autoshopNameLabel";
            this.autoshopNameLabel.Size = new System.Drawing.Size(259, 29);
            this.autoshopNameLabel.TabIndex = 0;
            this.autoshopNameLabel.Text = "Pat’s auto repair shop";
            // 
            // Splash
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
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
    }
}