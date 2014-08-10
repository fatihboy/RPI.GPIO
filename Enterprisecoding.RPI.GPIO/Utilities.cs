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
