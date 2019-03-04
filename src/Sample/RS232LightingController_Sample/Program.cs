using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VST.Device.LightingController;

namespace RS232LightingController_Sample
{
    class Program
    {
        static void Main(string[] args)
        {
            // 建立控制器物件，給予控制器名稱以及通道數
            var controller = new Rs232LightingController("VLP-2430-4", 4);

            // 打開指定的SerialPort通道
            controller.Open("COM4");

            // 初始化所有通道的狀態
            // 亮度:0, Strobe Mode:F1, ON/OFF:OFF
            controller.Initialize();

            // 設定亮度,將通道0設定亮度值為200
            controller.SetIntensity(0, 200);

            // 設定亮度,將通道1設定Strobe Mode為F1
            controller.SetStrobeMode(0, StrobeModes.F1);

            // ON/OFF，將通道1開啟
            controller.SetOnOff(0, true);

        }
    }
}
