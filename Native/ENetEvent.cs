using System;
using System.Runtime.InteropServices;

namespace Celnet.ENet.Native
{
    [StructLayout(LayoutKind.Sequential)]
    internal struct ENetEvent
    {
        public EventType type;
        public IntPtr peer;
        public byte channelID;
        public uint data;
        public IntPtr packet;
    }
}