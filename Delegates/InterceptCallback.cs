using System;

namespace Celnet.ENet.Delegates
{
    public delegate int InterceptCallback(ref Event @event, ref Address address, IntPtr receivedData,
        int receivedDataLength);
}