using Com.Enterprisecoding.RPI.GPIO.Enums;
using System.Runtime.InteropServices;

namespace Com.Enterprisecoding.RPI.GPIO {
    public static class WiringPi {
        public delegate void ISRCallback();

        public static class Core {
            [DllImport("libwiringPi.so", EntryPoint = "wiringPiSetup")]
            public static extern int Setup();

            [DllImport("libwiringPi.so", EntryPoint = "wiringPiSetupSys")]
            public static extern int SetupSys();

            [DllImport("libwiringPi.so", EntryPoint = "wiringPiSetupGpio")]
            public static extern int SetupGpio();

            [DllImport("libwiringPi.so", EntryPoint = "wiringPiSetupPhys")]
            public static extern int SetupPhys();


            [DllImport("libwiringPi.so", EntryPoint = "pinModeAlt")]
            public static extern void PinModeAlt(int pin, int mode);

            [DllImport("libwiringPi.so", EntryPoint = "pinMode")]
            private static extern void PinMode(int pin, int mode);

            public static void PinMode(int pin, PinMode mode) {
                PinMode(pin, (int)mode);
            }

            [DllImport("libwiringPi.so", EntryPoint = "pullUpDnControl")]
            public static extern void PullUpDnControl(int pin, int pud);

            [DllImport("libwiringPi.so", EntryPoint = "digitalRead")]
            private static extern int DigitalReadInt(int pin);

            private static DigitalValue DigitalRead(int pin) {
                return (DigitalValue)DigitalReadInt(pin);
            }

            [DllImport("libwiringPi.so", EntryPoint = "digitalWrite")]
            private static extern void DigitalWrite(int pin, int value);

            public static void DigitalWrite(int pin, DigitalValue value) {
                DigitalWrite(pin, (int)value);
            }

            [DllImport("libwiringPi.so", EntryPoint = "pwmWrite")]
            public static extern void PWMWrite(int pin, int value);

            [DllImport("libwiringPi.so", EntryPoint = "analogRead")]
            public static extern int AnalogRead(int pin);

            [DllImport("libwiringPi.so", EntryPoint = "analogWrite")]
            public static extern void AnalogWrite(int pin, int value);

            [DllImport("libwiringPi.so", EntryPoint = "wiringPiFindNode")]
            public static extern WiringPiNode FindNode(int pin);

            [DllImport("libwiringPi.so", EntryPoint = "wiringPiNewNode")]
            public static extern WiringPiNode NewNode(int pinBase, int numPins);
        }

        public static class OnBoardHardware {
            [DllImport("libwiringPi.so", EntryPoint = "piBoardRev")]
            public static extern int PiBoardRev();

            [DllImport("libwiringPi.so", EntryPoint = "piBoardId")]
            private static unsafe extern void PiBoardId(out int* model, out int* rev, out int* mem, out int* maker, out int* overVolted);

            public static unsafe BoardInfo PiBoardInfo() {
                int* model, rev, mem, maker, overVolted;

                PiBoardId(out model, out rev, out mem, out maker, out overVolted);

                var boardInfo = new BoardInfo {
                    Model = (PiModel)(int)model,
                    Revision = (PiVersion)(int)rev,
                    Memory = (int)mem,
                    Maker = (PiMaker)(int)maker,
                    OverVolted = (int)overVolted == 1
                };

                return boardInfo;
            }

            [DllImport("libwiringPi.so", EntryPoint = "wpiPinToGpio")]
            public static extern int WpiPinToGpio(int wpiPin);

            [DllImport("libwiringPi.so", EntryPoint = "physPinToGpio")]
            public static extern int PhysPinToGpio(int physPin);

            [DllImport("libwiringPi.so", EntryPoint = "setPadDrive")]
            public static extern void SetPadDrive(int group, int value);

            [DllImport("libwiringPi.so", EntryPoint = "getAlt")]
            public static extern int GetAlt(int pin);

            [DllImport("libwiringPi.so", EntryPoint = "pwmToneWrite")]
            public static extern void PwmToneWrite(int pin, int freq);

            [DllImport("libwiringPi.so", EntryPoint = "digitalWriteByte")]
            public static extern void DigitalWriteByte(int value);

            [DllImport("libwiringPi.so", EntryPoint = "pwmSetMode")]
            public static extern void PwmSetMode(int mode);

            [DllImport("libwiringPi.so", EntryPoint = "pwmSetRange")]
            public static extern void PwmSetRange(uint range);

            [DllImport("libwiringPi.so", EntryPoint = "pwmSetClock")]
            public static extern void PwmSetClock(int divisor);

            [DllImport("libwiringPi.so", EntryPoint = "gpioClockSet")]
            public static extern void GpioClockSet(int pin, int freq);
        }

        public static class Interrupts {
            [DllImport("libwiringPi.so", EntryPoint = "waitForInterrupt")]
            public static extern int WaitForInterrupt(int pin, int mS);

            [DllImport("libwiringPi.so", EntryPoint = "wiringPiISR")]
            public static extern int WiringPiISR(int pin, int mode, ISRCallback callback);
        }

        public static class Threads {
            [DllImport("libwiringPi.so", EntryPoint = "piLock")]
            public static extern void PiLock(int key);

            [DllImport("libwiringPi.so", EntryPoint = "piUnlock")]
            public static extern void PiUnlock(int key);

            [DllImport("libwiringPi.so", EntryPoint = "piHiPri")]
            public static extern int PiHiPri(int pri);
        }
    }
}