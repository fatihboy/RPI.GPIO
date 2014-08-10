/*************************************************************************************************
 *                   Enterprisecoding Raspberry Pi GPIO Library                                  *
 *                        (http://enterprisecoding.com)                                          *
 *                                                                                               *
 * This class library is written by Fatih Boy to act as a wrapper for Gordon Hendersons WiringPi *
 * I take no responsibility for this wrapper class providing proper functionality and give no    *
 * warranty of any kind, nor it's use or fitness for any purpose. You use this wrapper at your   *
 * own risk.                                                                                     *
 *                                                                                               *
 * This code is released as Open Source under GNU LGPL license, please ensure that you have a    *
 * copy of the license and understand the usage terms and conditions.                            *
 *                                                                                               *
 * I take no credit for the underlying functionality that this wrapper provides.                 *
 *                                                                                               *
 * Latest version can be found at https://github.com/fatihboy/RPI.GPIO                           *
 *************************************************************************************************/

using Com.Enterprisecoding.RPI.GPIO;
using Com.Enterprisecoding.RPI.GPIO.Enums;
using System;
using System.Reflection;

namespace Enterprisecoding.RPI.GPIO.LedTest {
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

            int result = WiringPi.Core.Setup();

            if (result == -1) {
                Console.WriteLine("WiringPi init failed!");
                return;
            }

            WiringPi.Core.PinMode(0, PinMode.Output);

            Console.WriteLine("Looping Pin 0...");
            for (; ; ) {
                WiringPi.Core.DigitalWrite(0, DigitalValue.High);
                System.Threading.Thread.Sleep(1000);

                WiringPi.Core.DigitalWrite(0, DigitalValue.Low);
                System.Threading.Thread.Sleep(1000);
            }
        }
    }
}
