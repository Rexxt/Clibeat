using System;
using System.Diagnostics;
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
            var scene = "MainMenu";

            var VerString = "0.0.1 dev";
            long BPM = 120;
            double MsPB = 1.0 / BPM * 60000;
            var GameStart = 0;
            double GameTick = 0;
            var Updates = 0;
            long LastUpdate = 0;

            Stopwatch GlobalTime = new Stopwatch();
            GlobalTime.Start();

            Console.WriteLine("Welcome to Clibeat v"+VerString+"!");
            Console.WriteLine("Mizu, 2021");
            // We'll insert file loading here
            Thread.Sleep(500);
            Console.Clear();

            while(true)
            {
                var DT = GlobalTime.ElapsedMilliseconds - LastUpdate;
                LastUpdate = GlobalTime.ElapsedMilliseconds;
                Updates++;
                Console.Clear();
                WriteXY("DT" + DT.ToString(), 0, 0);
                double SDT = DT / 1000.0;
                WriteXY("SDT" + SDT.ToString(), 0, 1);
                WriteXY("UPS" + (1/SDT).ToString(), 0, 2);
                WriteXY("AUPS" + (Updates/(GlobalTime.ElapsedMilliseconds/1000.0)).ToString(), 0, 3);

                GameTick = (GlobalTime.ElapsedMilliseconds - GameStart) / MsPB;
                WriteXY("Tick" + GameTick, 0, 5);
            }
        }
    }
}
