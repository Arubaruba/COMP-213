using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Exercise6._2
{
    public partial class Splash : Form
    {
        public Splash()
        {
            InitializeComponent();

            var timer = new Timer();
            timer.Interval = 700;
            timer.Tick += new EventHandler(onTimer);
            timer.Start();
        }

        private void onTimer(Object myObject, EventArgs myEventArgs)
        {
            Close();
        }
    }
}
