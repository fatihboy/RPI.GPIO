﻿/*************************************************************************************************
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
using System.Collections.Generic;

namespace Com.Enterprisecoding.RPI.GPIO
{
    public static class Utilities {
        private static Dictionary<PiModel, string> piModelNames = new Dictionary<PiModel, string> {
            {PiModel.A, "Model A"},
            {PiModel.B, "Model B"},
            {PiModel.AP, "Model A+"},
            {PiModel.BP, "Model B+"},
            {PiModel.P2, "Model Pi 2"},
            {PiModel.Alpha, "Model Alpha"},
            {PiModel.CM, "Model CM"},
            {PiModel.M07, "Model 07"},
            {PiModel.P3, "Model P3"},
            {PiModel.ZERO, "Model Zero"}
        };

        private static Dictionary<PiVersion, string> piVersionNames = new Dictionary<PiVersion, string> {
            {PiVersion.v1, "1"},
            {PiVersion.v1_1, "1.1"},
            {PiVersion.v1_2, "1.2"},
            {PiVersion.v2, "2"},
        };

        private static Dictionary<PiMemory, short> piMemoryValues = new Dictionary<PiMemory, short> {
            {PiMemory.M256, 256},
            {PiMemory.M512, 512},
            {PiMemory.G1, 1024}
        };

        public static string GetModelName(PiModel model) {
            return piModelNames[model];
        }

        public static string GetVersionName(PiVersion version) {
            return piVersionNames[version];
        }

        public static short GetMemoryValue(PiMemory memory)  {
            return piMemoryValues[memory];
        }
    }
}
