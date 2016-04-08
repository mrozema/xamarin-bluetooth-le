using System;
using Plugin.BLE.Abstractions.Contracts;

namespace Plugin.BLE.Abstractions.Bluetooth.LE
{
    public class DeviceBondStateChangedEventArgs : EventArgs
    {
        public IDevice Device { get; set; }
        public DeviceBondState State { get; set; }

        public DeviceBondStateChangedEventArgs()
            : base()
        { }
    }
}