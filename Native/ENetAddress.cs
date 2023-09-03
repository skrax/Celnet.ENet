using System.Runtime.InteropServices;

namespace Celnet.ENet.Native
{
    [StructLayout(LayoutKind.Explicit, Size = 18)]
    internal struct ENetAddress
    {
        [FieldOffset(16)] public ushort port;
    }
}