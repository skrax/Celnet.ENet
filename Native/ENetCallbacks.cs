using System.Runtime.InteropServices;
using Celnet.ENet.Delegates;

namespace Celnet.ENet.Native
{
    [StructLayout(LayoutKind.Sequential)]
    internal struct ENetCallbacks
    {
        public AllocCallback malloc;
        public FreeCallback free;
        public NoMemoryCallback noMemory;
    }
}