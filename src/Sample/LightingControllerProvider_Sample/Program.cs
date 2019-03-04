using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VST.Device.LightingController;

namespace LightingControllerProvider_Sample
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {

                // 向LightingControllerProvider查詢型號，若輸入未知型號會發出NoSupported Exception
                var controller = LightingControllerProvider.GetController("VLP-2430-4eN");

                // 打開指定的TcpClient通道
                controller.Open("192.168.11.20");

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
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }
    }
}
