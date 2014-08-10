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