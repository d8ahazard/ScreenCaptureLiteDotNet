using System;
using ScreenCaptureLiteDotNet;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var sc = ScreenCapture.GetMonitors();
            Console.WriteLine("Monitors got!");
        }
    }
}
