namespace Homework1_Orderform
{
    partial class OrderForm
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
            this.orderGroupBox = new System.Windows.Forms.GroupBox();
            this.clearButton = new System.Windows.Forms.Button();
            this.buyButton = new System.Windows.Forms.Button();
            this.totalPriceTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.quantityTextBox = new System.Windows.Forms.TextBox();
            this.priceTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dailyTotalsGroupBox = new System.Windows.Forms.GroupBox();
            this.resetDailyTotalsButton = new System.Windows.Forms.Button();
            this.averageOrderAmountTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.totalDailyAmountTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.totalDailyQuantityTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.exitButton = new System.Windows.Forms.Button();
            this.orderGroupBox.SuspendLayout();
            this.dailyTotalsGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // orderGroupBox
            // 
            this.orderGroupBox.Controls.Add(this.clearButton);
            this.orderGroupBox.Controls.Add(this.buyButton);
            this.orderGroupBox.Controls.Add(this.totalPriceTextBox);
            this.orderGroupBox.Controls.Add(this.label3);
            this.orderGroupBox.Controls.Add(this.quantityTextBox);
            this.orderGroupBox.Controls.Add(this.priceTextBox);
            this.orderGroupBox.Controls.Add(this.label2);
            this.orderGroupBox.Controls.Add(this.label1);
            this.orderGroupBox.Location = new System.Drawing.Point(12, 12);
            this.orderGroupBox.Name = "orderGroupBox";
            this.orderGroupBox.Size = new System.Drawing.Size(200, 230);
            this.orderGroupBox.TabIndex = 0;
            this.orderGroupBox.TabStop = false;
            this.orderGroupBox.Text = "Order";
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(119, 199);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(75, 23);
            this.clearButton.TabIndex = 5;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // buyButton
            // 
            this.buyButton.Enabled = false;
            this.buyButton.Location = new System.Drawing.Point(9, 199);
            this.buyButton.Name = "buyButton";
            this.buyButton.Size = new System.Drawing.Size(104, 23);
            this.buyButton.TabIndex = 4;
            this.buyButton.Text = "Buy";
            this.buyButton.UseVisualStyleBackColor = true;
            this.buyButton.Click += new System.EventHandler(this.buyButton_Click);
            // 
            // totalPriceTextBox
            // 
            this.totalPriceTextBox.Location = new System.Drawing.Point(94, 128);
            this.totalPriceTextBox.Name = "totalPriceTextBox";
            this.totalPriceTextBox.ReadOnly = true;
            this.totalPriceTextBox.Size = new System.Drawing.Size(100, 20);
            this.totalPriceTextBox.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Total Price";
            // 
            // quantityTextBox
            // 
            this.quantityTextBox.Location = new System.Drawing.Point(94, 61);
            this.quantityTextBox.Name = "quantityTextBox";
            this.quantityTextBox.Size = new System.Drawing.Size(100, 20);
            this.quantityTextBox.TabIndex = 2;
            this.quantityTextBox.TextChanged += new System.EventHandler(this.updateTotalPrice);
            // 
            // priceTextBox
            // 
            this.priceTextBox.Location = new System.Drawing.Point(94, 30);
            this.priceTextBox.Name = "priceTextBox";
            this.priceTextBox.Size = new System.Drawing.Size(100, 20);
            this.priceTextBox.TabIndex = 1;
            this.priceTextBox.TextChanged += new System.EventHandler(this.updateTotalPrice);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Quantity";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Price";
            // 
            // dailyTotalsGroupBox
            // 
            this.dailyTotalsGroupBox.Controls.Add(this.resetDailyTotalsButton);
            this.dailyTotalsGroupBox.Controls.Add(this.averageOrderAmountTextBox);
            this.dailyTotalsGroupBox.Controls.Add(this.label6);
            this.dailyTotalsGroupBox.Controls.Add(this.totalDailyAmountTextBox);
            this.dailyTotalsGroupBox.Controls.Add(this.label5);
            this.dailyTotalsGroupBox.Controls.Add(this.totalDailyQuantityTextBox);
            this.dailyTotalsGroupBox.Controls.Add(this.label4);
            this.dailyTotalsGroupBox.Location = new System.Drawing.Point(219, 12);
            this.dailyTotalsGroupBox.Name = "dailyTotalsGroupBox";
            this.dailyTotalsGroupBox.Size = new System.Drawing.Size(284, 230);
            this.dailyTotalsGroupBox.TabIndex = 1;
            this.dailyTotalsGroupBox.TabStop = false;
            this.dailyTotalsGroupBox.Text = "Daily Totals";
            // 
            // resetDailyTotalsButton
            // 
            this.resetDailyTotalsButton.Location = new System.Drawing.Point(170, 199);
            this.resetDailyTotalsButton.Name = "resetDailyTotalsButton";
            this.resetDailyTotalsButton.Size = new System.Drawing.Size(103, 23);
            this.resetDailyTotalsButton.TabIndex = 5;
            this.resetDailyTotalsButton.Text = "Reset";
            this.resetDailyTotalsButton.UseVisualStyleBackColor = true;
            this.resetDailyTotalsButton.Click += new System.EventHandler(this.resetDailyTotalsButton_Click);
            // 
            // averageOrderAmountTextBox
            // 
            this.averageOrderAmountTextBox.Location = new System.Drawing.Point(132, 128);
            this.averageOrderAmountTextBox.Name = "averageOrderAmountTextBox";
            this.averageOrderAmountTextBox.ReadOnly = true;
            this.averageOrderAmountTextBox.Size = new System.Drawing.Size(141, 20);
            this.averageOrderAmountTextBox.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 131);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(115, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Average Order Amount";
            // 
            // totalDailyAmountTextBox
            // 
            this.totalDailyAmountTextBox.Location = new System.Drawing.Point(132, 30);
            this.totalDailyAmountTextBox.Name = "totalDailyAmountTextBox";
            this.totalDailyAmountTextBox.ReadOnly = true;
            this.totalDailyAmountTextBox.Size = new System.Drawing.Size(141, 20);
            this.totalDailyAmountTextBox.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 33);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Total Daily Amount";
            // 
            // totalDailyQuantityTextBox
            // 
            this.totalDailyQuantityTextBox.Location = new System.Drawing.Point(132, 61);
            this.totalDailyQuantityTextBox.Name = "totalDailyQuantityTextBox";
            this.totalDailyQuantityTextBox.ReadOnly = true;
            this.totalDailyQuantityTextBox.Size = new System.Drawing.Size(141, 20);
            this.totalDailyQuantityTextBox.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 64);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Total Daily Quantity";
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(428, 248);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 23);
            this.exitButton.TabIndex = 2;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // OrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(513, 280);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.dailyTotalsGroupBox);
            this.Controls.Add(this.orderGroupBox);
            this.Name = "OrderForm";
            this.Text = "Order Form";
            this.orderGroupBox.ResumeLayout(false);
            this.orderGroupBox.PerformLayout();
            this.dailyTotalsGroupBox.ResumeLayout(false);
            this.dailyTotalsGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox orderGroupBox;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button buyButton;
        private System.Windows.Forms.TextBox totalPriceTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox quantityTextBox;
        private System.Windows.Forms.TextBox priceTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox dailyTotalsGroupBox;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button resetDailyTotalsButton;
        private System.Windows.Forms.TextBox averageOrderAmountTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox totalDailyAmountTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox totalDailyQuantityTextBox;
        private System.Windows.Forms.Label label4;
    }
}

