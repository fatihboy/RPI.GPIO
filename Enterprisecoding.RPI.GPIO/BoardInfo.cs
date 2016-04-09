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

using Com.Enterprisecoding.RPI.GPIO.Enums;

namespace Com.Enterprisecoding.RPI.GPIO {
    public class BoardInfo {
        private string modelName;
        private string versionName;
        private short memoryValue;

        public PiModel Model;
        public PiVersion Revision;
        public PiMemory Memory;
        public PiMaker Maker;
        public bool OverVolted;

        public string ModelName {
            get {
                if (string.IsNullOrWhiteSpace(modelName)) {
                    modelName = Utilities.GetModelName(Model);
                }

                return modelName;
            }
        }

        public string RevisionName {
            get {
                if (string.IsNullOrWhiteSpace(versionName)) {
                    versionName = Utilities.GetVersionName(Revision);
                }

                return versionName;
            }
        }

        /// <summary>
        /// Memory value in MB
        /// </summary>
        public short MemoryValue  {
            get {
                if (memoryValue==0) {
                    memoryValue = Utilities.GetMemoryValue(Memory);
                }

                return memoryValue;
            }
        }
    }
}