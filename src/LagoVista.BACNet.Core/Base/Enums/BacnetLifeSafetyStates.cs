﻿namespace LagoVista.BACNet.Core
{
    public enum BacnetLifeSafetyStates
    {
        MIN_LIFE_SAFETY_STATE = 0,
        LIFE_SAFETY_STATE_QUIET = 0,
        LIFE_SAFETY_STATE_PRE_ALARM = 1,
        LIFE_SAFETY_STATE_ALARM = 2,
        LIFE_SAFETY_STATE_FAULT = 3,
        LIFE_SAFETY_STATE_FAULT_PRE_ALARM = 4,
        LIFE_SAFETY_STATE_FAULT_ALARM = 5,
        LIFE_SAFETY_STATE_NOT_READY = 6,
        LIFE_SAFETY_STATE_ACTIVE = 7,
        LIFE_SAFETY_STATE_TAMPER = 8,
        LIFE_SAFETY_STATE_TEST_ALARM = 9,
        LIFE_SAFETY_STATE_TEST_ACTIVE = 10,
        LIFE_SAFETY_STATE_TEST_FAULT = 11,
        LIFE_SAFETY_STATE_TEST_FAULT_ALARM = 12,
        LIFE_SAFETY_STATE_HOLDUP = 13,
        LIFE_SAFETY_STATE_DURESS = 14,
        LIFE_SAFETY_STATE_TAMPER_ALARM = 15,
        LIFE_SAFETY_STATE_ABNORMAL = 16,
        LIFE_SAFETY_STATE_EMERGENCY_POWER = 17,
        LIFE_SAFETY_STATE_DELAYED = 18,
        LIFE_SAFETY_STATE_BLOCKED = 19,
        LIFE_SAFETY_STATE_LOCAL_ALARM = 20,
        LIFE_SAFETY_STATE_GENERAL_ALARM = 21,
        LIFE_SAFETY_STATE_SUPERVISORY = 22,
        LIFE_SAFETY_STATE_TEST_SUPERVISORY = 23,
        MAX_LIFE_SAFETY_STATE = 24,
        /* Enumerated values 0-255 are reserved for definition by ASHRAE.  */
        /* Enumerated values 256-65535 may be used by others subject to  */
        /* procedures and constraints described in Clause 23. */
        /* do the max range inside of enum so that
           compilers will allocate adequate sized datatype for enum
           which is used to store decoding */
        LIFE_SAFETY_STATE_PROPRIETARY_MIN = 256,
        LIFE_SAFETY_STATE_PROPRIETARY_MAX = 65535
    }
}