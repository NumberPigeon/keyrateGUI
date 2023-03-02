using System.Runtime.InteropServices;


namespace KeyRateGUI
{
    internal class KeyRateController
    {
        // the struct of Win32 API FILTERKEYS 
        // Reference: https://learn.microsoft.com/en-us/windows/win32/api/winuser/ns-winuser-filterkeys
        [StructLayout(LayoutKind.Sequential)]
        public struct FILTERKEYS
        {
            public uint cbSize;
            public uint dwFlags;
            public uint iWaitMSec;
            public uint iDelayMSec;
            public uint iRepeatMSec;
            public uint iBounceMSec;
        }
        // the flags of Win32 API FILTERKEYS
        public static uint FKF_FILTERKEYSON = 0x00000001;
        public static uint FKF_AVAILABLE = 0x00000002;

        // Win32 API to set filter key settings
        // Reference:https://learn.microsoft.com/en-us/windows/win32/api/winuser/nf-winuser-systemparametersinfoa
        [DllImport("user32.dll")]
        public static extern int SystemParametersInfoA(uint uiAction, uint uiParam, ref FILTERKEYS lpvParam, uint fWinIni);
        // the action of Win32 API SystemParametersInfoA to set filterkeys
        public static uint SPI_SETFILTERKEYS = 0x0033;

        public static bool SetFilterKeys(uint delayMSec, uint repeatMSec)
        {
            FILTERKEYS filterKeys = new FILTERKEYS();
            filterKeys.cbSize = (uint)Marshal.SizeOf(filterKeys);
            filterKeys.dwFlags = FKF_FILTERKEYSON | FKF_AVAILABLE;
            filterKeys.iDelayMSec = delayMSec;
            filterKeys.iRepeatMSec = repeatMSec;
            return SystemParametersInfoA(SPI_SETFILTERKEYS, 0, ref filterKeys, 0) != 0;
        }

        public static bool ResetFilterKeys()
        {
            FILTERKEYS filterKeys = new FILTERKEYS();
            filterKeys.cbSize = (uint)Marshal.SizeOf(filterKeys);
            return SystemParametersInfoA(SPI_SETFILTERKEYS, 0, ref filterKeys, 0) != 0;
        }
    }
}
