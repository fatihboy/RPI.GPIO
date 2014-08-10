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

using System.Runtime.InteropServices;

namespace Com.Enterprisecoding.RPI.GPIO {
    [StructLayout(LayoutKind.Sequential)]
    public class WiringPiNode {
        public int pinBase;
        public int pinMax;

        public int fd;
        public uint data0;
        public uint data1;
        public uint data2;
        public uint data3;

        [DllImport("libwiringPi.so", EntryPoint = "pinMode")]
        public static extern void PinMode(WiringPiNode node, int pin, int mode);

        [DllImport("libwiringPi.so", EntryPoint = "pullUpDnControl")]
        public static extern void PullUpDnControl(WiringPiNode node, int pin, int mode);

        [DllImport("libwiringPi.so", EntryPoint = "digitalRead")]
        public static extern int DigitalRead(WiringPiNode node, int pin);

        [DllImport("libwiringPi.so", EntryPoint = "digitalWrite")]
        public static extern void DigitalWrite(WiringPiNode node, int pin, int value);

        [DllImport("libwiringPi.so", EntryPoint = "pwmWrite")]
        public static extern void PwmWrite(WiringPiNode node, int pin, int value);

        [DllImport("libwiringPi.so", EntryPoint = "analogRead")]
        public static extern int AnalogRead(WiringPiNode node, int pin);

        [DllImport("libwiringPi.so", EntryPoint = "analogWrite")]
        public static extern void AnalogWrite(WiringPiNode node, int pin, int value);

        public WiringPiNode next;
    }
}