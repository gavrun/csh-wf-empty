using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace csh_wf_empty
{


    // The entry point of the application
    internal class Program
    {
        [STAThread] //application uses a single-threaded apartment model
        public static void Main()
        {
            Application.EnableVisualStyles(); // Enable visual styles for the application
            Application.SetCompatibleTextRenderingDefault(false); // Use default text rendering

            // Start the application with MainForm as the main form
            Application.Run(new MainForm()); 
        }
    }
}
