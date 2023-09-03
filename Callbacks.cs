using Celnet.ENet.Delegates;
using Celnet.ENet.Native;

namespace Celnet.ENet
{
    public class Callbacks
    {
        private ENetCallbacks nativeCallbacks;

        internal ENetCallbacks NativeData
        {
            get { return nativeCallbacks; }

            set { nativeCallbacks = value; }
        }

        public Callbacks(AllocCallback allocCallback, FreeCallback freeCallback, NoMemoryCallback noMemoryCallback)
        {
            nativeCallbacks.malloc = allocCallback;
            nativeCallbacks.free = freeCallback;
            nativeCallbacks.noMemory = noMemoryCallback;
        }
    }
}