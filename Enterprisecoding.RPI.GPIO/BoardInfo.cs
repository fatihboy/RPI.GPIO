using Com.Enterprisecoding.RPI.GPIO.Enums;

namespace Com.Enterprisecoding.RPI.GPIO {
    public class BoardInfo {
        private string modelName;
        private string versionName;

        public PiModel Model;
        public PiVersion Revision;
        public int Memory;
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
    }
}