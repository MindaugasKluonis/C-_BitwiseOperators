using System;

namespace BinaryOperationsWithEnums
{
    [Flags]
    enum DaysOfWeekEnum
    {
        //DECIMAL         BINARY
        //None = 0, //    00000000
        Monday = 1, //    00000001
        Tuesday = 2, //   00000010
        Wednesday = 4, // 00000100
        Thursday = 8, //  00001000
        Friday = 16, //   00010000
        Saturday = 32, // 00100000
        Sunday = 64, //   01000000

        //It is posible to declare special days
        Weekend = 96, //  01100000
    }
}
