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
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Com.Enterprisecoding.RPI.GPIO {
    public static class Utilities {
        private static Dictionary<PiModel, string> piModelNames = new Dictionary<PiModel, string> {
            {PiModel.A, "Model A"},
            {PiModel.B, "Model B"},
            {PiModel.BP, "Model B+"},
            {PiModel.CM, "Model CM"},
            {PiModel.Unknown, "Unknown Model"}
        };

        private static Dictionary<PiVersion, string> piVersionNames = new Dictionary<PiVersion, string> {
            {PiVersion.v1, "1"},
            {PiVersion.v1_1, "1.1"},
            {PiVersion.v1_2, "1.2"},
            {PiVersion.v2, "2"},
            {PiVersion.Unknown, "Unknown"}
        };

        public static string GetModelName(PiModel model) {
            return piModelNames[model];
        }
        public static string GetVersionName(PiVersion version) {
            return piVersionNames[version];
        }
    }
}
