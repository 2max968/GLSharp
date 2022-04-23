using System;
using System.Collections.Generic;
using System.Text;

namespace GLSharp
{
    internal class Util
    {
        public static void Leackage(IDisposable disp)
        {
            Console.WriteLine("[Memory Leak] Object of type '{0}' is still alive.", disp.GetType().Name);
        }
    }
}
