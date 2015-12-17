namespace HW4_Exercise8._3
{
    partial class SeatingPrice
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
            this.seatingPositionComboBox = new System.Windows.Forms.ComboBox();
            this.seatingPositionLabel = new System.Windows.Forms.Label();
            this.priceLabel = new System.Windows.Forms.Label();
            this.priceTextBox = new System.Windows.Forms.TextBox();
            this.buyTicketButton = new System.Windows.Forms.Button();
            this.priceButton = new System.Windows.Forms.Button();
            this.printSummaryButton = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // seatingPositionComboBox
            // 
            this.seatingPositionComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.seatingPositionComboBox.FormattingEnabled = true;
            this.seatingPositionComboBox.Items.AddRange(new object[] {
            "Orchestra",
            "Mezzanine",
            "General",
            "Balcony"});
            this.seatingPositionComboBox.Location = new System.Drawing.Point(211, 26);
            this.seatingPositionComboBox.Name = "seatingPositionComboBox";
            this.seatingPositionComboBox.Size = new System.Drawing.Size(121, 21);
            this.seatingPositionComboBox.TabIndex = 0;
            this.seatingPositionComboBox.SelectedIndexChanged += new System.EventHandler(this.seatingPositionComboBox_SelectedIndexChanged);
            // 
            // seatingPositionLabel
            // 
            this.seatingPositionLabel.AutoSize = true;
            this.seatingPositionLabel.Location = new System.Drawing.Point(12, 26);
            this.seatingPositionLabel.Name = "seatingPositionLabel";
            this.seatingPositionLabel.Size = new System.Drawing.Size(83, 13);
            this.seatingPositionLabel.TabIndex = 1;
            this.seatingPositionLabel.Text = "Seating Position";
            // 
            // priceLabel
            // 
            this.priceLabel.AutoSize = true;
            this.priceLabel.Location = new System.Drawing.Point(12, 69);
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.Size = new System.Drawing.Size(31, 13);
            this.priceLabel.TabIndex = 2;
            this.priceLabel.Text = "Price";
            // 
            // priceTextBox
            // 
            this.priceTextBox.Location = new System.Drawing.Point(211, 66);
            this.priceTextBox.Name = "priceTextBox";
            this.priceTextBox.ReadOnly = true;
            this.priceTextBox.Size = new System.Drawing.Size(121, 20);
            this.priceTextBox.TabIndex = 3;
            // 
            // buyTicketButton
            // 
            this.buyTicketButton.Location = new System.Drawing.Point(257, 110);
            this.buyTicketButton.Name = "buyTicketButton";
            this.buyTicketButton.Size = new System.Drawing.Size(75, 23);
            this.buyTicketButton.TabIndex = 4;
            this.buyTicketButton.Text = "Buy Ticket";
            this.toolTip1.SetToolTip(this.buyTicketButton, "Buy a ticket at the displayed price");
            this.buyTicketButton.UseVisualStyleBackColor = true;
            this.buyTicketButton.Click += new System.EventHandler(this.buyTicketButton_Click);
            // 
            // priceButton
            // 
            this.priceButton.Location = new System.Drawing.Point(12, 110);
            this.priceButton.Name = "priceButton";
            this.priceButton.Size = new System.Drawing.Size(75, 23);
            this.priceButton.TabIndex = 5;
            this.priceButton.Text = "Prices";
            this.toolTip1.SetToolTip(this.priceButton, "Show the prices of different seats");
            this.priceButton.UseVisualStyleBackColor = true;
            this.priceButton.Click += new System.EventHandler(this.priceButton_Click);
            // 
            // printSummaryButton
            // 
            this.printSummaryButton.Location = new System.Drawing.Point(97, 110);
            this.printSummaryButton.Name = "printSummaryButton";
            this.printSummaryButton.Size = new System.Drawing.Size(93, 23);
            this.printSummaryButton.TabIndex = 6;
            this.printSummaryButton.Text = "Print Summary";
            this.toolTip1.SetToolTip(this.printSummaryButton, "Show a summary of tickets bought");
            this.printSummaryButton.UseVisualStyleBackColor = true;
            this.printSummaryButton.Click += new System.EventHandler(this.printSummaryButton_Click);
            // 
            // SeatingPrice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 145);
            this.Controls.Add(this.printSummaryButton);
            this.Controls.Add(this.priceButton);
            this.Controls.Add(this.buyTicketButton);
            this.Controls.Add(this.priceTextBox);
            this.Controls.Add(this.priceLabel);
            this.Controls.Add(this.seatingPositionLabel);
            this.Controls.Add(this.seatingPositionComboBox);
            this.Name = "SeatingPrice";
            this.Text = "Seating Price";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox seatingPositionComboBox;
        private System.Windows.Forms.Label seatingPositionLabel;
        private System.Windows.Forms.Label priceLabel;
        private System.Windows.Forms.TextBox priceTextBox;
        private System.Windows.Forms.Button buyTicketButton;
        private System.Windows.Forms.Button priceButton;
        private System.Windows.Forms.Button printSummaryButton;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}

