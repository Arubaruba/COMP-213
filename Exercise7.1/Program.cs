using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Exercise7._1
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            using (var ds = new DataSet1())
            {
                
                int count = ds.University.Count;
                ds.University.AddUniversityRow(1, "MIT");
                count = ds.University.Count;
                ds.University.AddUniversityRow(1, "MIT");
            }

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
