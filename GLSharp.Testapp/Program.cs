using System.Numerics;

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
            Random rnd = new Random();
            for(int i = 0; i < 10; i++)
            {
                var q = new Quaternion(rnd.Next(-100, 100), rnd.Next(-100, 100), rnd.Next(-100, 100), rnd.Next(-100,100));
                Console.WriteLine($"{q} -> {q * q.GetInverse()}");
            }
            Vector3 x = new Vector3(1, 0, 0);
            Quaternion rot = Quaternion.Rotation(new Vector3(0, 0, 10), (float)Math.PI / 2f);
            Vector3 x_ = rot * x;
            Console.WriteLine($"{x} -> {x_}");

            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new FrmQuaternion());
        }
    }
}