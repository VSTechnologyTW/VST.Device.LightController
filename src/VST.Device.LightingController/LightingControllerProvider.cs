using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VST.Device.LightingController
{
    public static class LightingControllerProvider
    {
        public static List<string> ModelList { get; private set; }

        static LightingControllerProvider()
        {
            ModelList = new List<string>()
            {
                "VLP-4830-2S",
                "VLP-4830-3S",
                "VLP-2430-4",
                "VLP-2460-4",
                "VLP-2430-2e",
                "VLP-2430-3e",
                "VLP-2430-4e",
                "VLP-2460-4e",
                "VLP-2430-2eN",
                "VLP-2430-3eN",
                "VLP-2430-4eN",
                "VLP-2460-4eN",
                "VLP-2430-2",
                "VLP-2430-3",
            };
        }

        public static ILightingController GetController(string modelName)
        {
            if (!ModelList.Contains(modelName)) return null;
            switch (modelName)
            {
                case "VLP-4830-2S":
                    return new Rs232LightingController("VLP-4830-2S", 2);
                case "VLP-4830-3S":
                    return new Rs232LightingController("VLP-4830-3S", 3);
                case "VLP-2430-4":
                    return new Rs232LightingController("VLP-2430-4", 4);
                case "VLP-2460-4":
                    return new Rs232LightingController("VLP-2460-4", 4);
                case "VLP-2430-2e":
                    return new EthernetLightingController("VLP-2430-2e", 2);
                case "VLP-2430-3e":
                    return new EthernetLightingController("VLP-2430-3e", 3);
                case "VLP-2430-4e":
                    return new EthernetLightingController("VLP-2430-4e", 4);
                case "VLP-2460-4e":
                    return new EthernetLightingController("VLP-2460-4e", 4);
                case "VLP-2430-2eN":
                    return new EthernetLightingController("VLP-2430-2eN", 2);
                case "VLP-2430-3eN":
                    return new EthernetLightingController("VLP-2430-3eN", 3);
                case "VLP-2430-4eN":
                    return new EthernetLightingController("VLP-2430-4eN", 4);
                case "VLP-2460-4eN":
                    return new EthernetLightingController("VLP-2460-4eN", 4);
                case "VLP-2430-2":
                    return new Rs232LightingController("VLP-2430-2", 2);
                case "VLP-2430-3":
                    return new Rs232LightingController("VLP-2430-3", 3);
                default:
                    throw new NotSupportedException("未知的控制器型號");
            }
        }
    }
}
