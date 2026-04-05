using System;
using System.Collections.Generic;
using System.Text;

namespace SpacecraftApp
{
    internal partial class Program
    {
        public static void Log(string message)
        {
            string timestamp = DateTime.Now.ToString("HH:mm:ss");
            Console.WriteLine($"[{timestamp}] {message}");

        }
    }

}
