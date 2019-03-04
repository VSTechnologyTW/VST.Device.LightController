using System;
using System.Collections.Generic;
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

            // 更改數值後並不會立刻生效，必須在下一次開啟的指令，才會更新實際的亮度
            controller.SetIntensity(0, 200);
            controller.SetOnOff(0, true);

            // 或者啟用AutoUpdate,此功能預設是關閉的
            controller.AutoUpdate = true;
            controller.SetIntensity(1, 0);

        }
    }
}
