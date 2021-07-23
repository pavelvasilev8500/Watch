using System;
using System.Windows.Forms;

namespace Watch.MVVM.Model
{
    static class MainModel
    {
        public static string SetTime()
        {
            return DateTime.Now.ToString("HH:mm:ss");
        }
        public static string SetDay()
        {
            return DateTime.Now.ToString("ddd");
        }

        public static string SetDate()
        {
            return DateTime.Now.ToString("dd MMM yyyy");
        }

        public static string SetBataryLevel()
        {
            return (SystemInformation.PowerStatus.BatteryLifePercent * 100).ToString() + "%";
        }

    }
}
