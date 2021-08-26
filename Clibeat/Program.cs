using System;
using System.Threading;

namespace Clibeat
{
    class Program
    {

        static void WriteXY(string text, int x, int y)
        {
            var OrigLeft = Console.CursorLeft;
            var OrigTop = Console.CursorTop;
            
            Console.SetCursorPosition(x, y);
            Console.Write(text);
            Console.SetCursorPosition(OrigLeft, OrigTop);
        }

        static void Main(string[] args)
        {
            var VerString = "0.0.1 dev";
            Stopwatch GlobalTime = new Stopwatch();
            GlobalTime.Start();

            Console.WriteLine("Welcome to Clibeat v"+VerString+"!");
            Console.WriteLine("Mizu, 2021");
            // We'll insert file loading here
            Thread.Sleep(500);
            Console.Clear();

            
        }
    }
}
