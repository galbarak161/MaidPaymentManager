namespace MaidPaymentManager
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Create an instance of the NewWorkValidator
            INewWorkValidator newWorkValidator = new NewWorkValidator();

            // Pass it to MainForm
            Application.Run(new MainForm(newWorkValidator));
        }
    }
}