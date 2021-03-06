﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercise4._3
{
    public partial class Account : Form
    {
         enum TransactionType {Deposit, Check, ServiceCharge};

        TransactionType transactionType = TransactionType.Deposit;
        Decimal total = 0;
        public Account()
        {
            InitializeComponent();
            updateTotal();
        }

        private void updateTotal()
        {
            totalTextBox.Text = total.ToString("C");
        }

        private void depositRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            transactionType = TransactionType.Deposit;
        }

        private void checkRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            transactionType = TransactionType.Check;
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void amountTextBox_TextChanged(object sender, EventArgs e)
        {
            // Simple enable and disable the "add" button depending on whether the amount text box contains a valid decimal
            try
            {
                Decimal.Parse(amountTextBox.Text);
                addButton.Enabled = true;
            }
            catch
            {
                addButton.Enabled = false;
            }
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            Decimal amount = Decimal.Parse(amountTextBox.Text);

            if (transactionType != TransactionType.ServiceCharge)
            {
                total += amount;
            }
            else
            {
                total -= amount;
            }

            updateTotal();

            amountTextBox.Text = "";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void serviceRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            transactionType = TransactionType.ServiceCharge;
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            total = 0;
            updateTotal();
        }
    }
}
