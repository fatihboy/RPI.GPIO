using Com.Enterprisecoding.RPI.GPIO.Enums;
using System;
using System.Reflection;

namespace Com.Enterprisecoding.RPI.GPIO.Test {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Enterprisecoding Raspberry Pi GPIO Library v{0}", Assembly.GetEntryAssembly().GetName().Version);
            Console.WriteLine("Copyright (c) 2014-{0} Fatih Boy", DateTime.Now.Year);
            Console.WriteLine("This is free software with ABSOLUTELY NO WARRANTY.");
            Console.WriteLine();

            var boardInfo = WiringPi.OnBoardHardware.PiBoardInfo();

            if (boardInfo.Model == PiModel.Unknown) {
                Console.WriteLine("Your Raspberry Pi has an unknown model type. Please report this to");
                Console.WriteLine("    fatih@enterprisecoding.com");
                Console.WriteLine("with a copy of your /proc/cpuinfo if possible");
            }
            else {
                Console.WriteLine("Raspberry Pi Details:");
                Console.WriteLine("  Type: {0}, Revision: {1}, Memory: {2}MB, Maker: {3} {4}",
                    boardInfo.ModelName, boardInfo.RevisionName, boardInfo.Memory, boardInfo.Maker, boardInfo.OverVolted ? "[OV]" : "");
            }
            
            Console.WriteLine();
            Console.WriteLine("Application will loop through pin 15. Make sure nothing connected!");
            Console.Write("Press escape to cancel or any other to continue...");

            var key = Console.ReadKey();

            if (key.Key == ConsoleKey.Escape) {
                return;
            }

            Console.WriteLine();
            LoopPin15();
        }

        private static void LoopPin15() {
            int result = WiringPi.Core.Setup();

            if (result == -1) {
                Console.WriteLine("WiringPi init failed!");
                return;
            }

            WiringPi.Core.PinMode(15, PinMode.Output);

            Console.WriteLine("Looping Pin 15...");
            for (; ; ) {
                WiringPi.Core.DigitalWrite(15, DigitalValue.High);
                System.Threading.Thread.Sleep(1000);

                WiringPi.Core.DigitalWrite(15, DigitalValue.Low);
                System.Threading.Thread.Sleep(1000);
            }
        }
    }
}