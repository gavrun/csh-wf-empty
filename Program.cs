using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace csh_wf_empty
{
    // Custom form derived from the base class 
    public class MainForm : Form
    {
        // Button control element
        private Button button1; 

        // Custom delegate definition
        public delegate void CustomEventHandler(object sender, EventArgs e);

        // Custom event based on the delegate
        public event CustomEventHandler CustomEvent;

        public MainForm()
        {
            // Initialize the form and properties of the form (the main application window)
            this.Text = "WinForms Example"; 
            this.Width = 300; 
            this.Height = 200;

            // Initialize the button control and properties
            button1 = new Button();
            button1.Text = "Click Me!"; 
            button1.Width = 100; 
            button1.Height = 50; 
            button1.Top = 50; 
            button1.Left = 100;

            // Attach the event handler to the button built-in Click event
            button1.Click += new EventHandler(Button1_Click);

            // Attach a handler to the custom event
            this.CustomEvent += new CustomEventHandler(OnCustomEvent);

            // Add the button to the form's controls collection 
            this.Controls.Add(button1);
        }

        // Event handler method for the button's Click event
        private void Button1_Click(object sender, EventArgs e)
        {
            // Trigger the custom event (only triggered if it has subscribers)
            CustomEvent?.Invoke(this, EventArgs.Empty);

            MessageBox.Show("Hello, world!", "Button Clicked", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // Handler method for the custom event
        private void OnCustomEvent(object sender, EventArgs e)
        {
            // Show a message box indicating the custom event was triggered
            MessageBox.Show("Custom event triggered!", "Custom Event", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }


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
