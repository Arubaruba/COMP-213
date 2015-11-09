using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercise6._2
{
    public partial class Splash : Form
    {
        public Splash()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // We close this form allowing the 
            Close();
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            // We don't just close the form we exit entire app (preventing the AutoShop form from being created)
            Application.Exit();
        }
    }
}
