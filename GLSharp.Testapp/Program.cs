namespace GLSharp.Testapp
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Quaternion a = new Quaternion(1, 1, 0, 0);
            Quaternion b = new Quaternion(0, 1, -1, 1);
            Console.WriteLine($"{a}+{b}={a+b}");
            Console.WriteLine($"{a}*{b}={a*b}");

            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Frm3D());
        }
    }
}