﻿namespace LagoVista.BACNet.Core
{
    public enum BacnetBvlcV6Results : ushort
    {
        SUCCESSFUL_COMPLETION = 0x0000,
        ADDRESS_RESOLUTION_NAK = 0x0030,
        VIRTUAL_ADDRESS_RESOLUTION_NAK = 0x0060,
        REGISTER_FOREIGN_DEVICE_NAK = 0X0090,
        DISTRIBUTE_BROADCAST_TO_NETWORK_NAK = 0x00B0
    }
}