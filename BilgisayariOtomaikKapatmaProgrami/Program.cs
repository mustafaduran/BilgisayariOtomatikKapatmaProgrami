namespace BilgisayariOtomatikKapatmaProgrami
{
    internal static class Program
    {
        public static LanguageClass Lang;
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Lang = new LanguageClass();
            Application.Run(new MainForm());
           
        }
    }
}