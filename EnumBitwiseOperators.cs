using System;

namespace BinaryOperationsWithEnums
{
    class EnumBitwiseOperators
    {
        public DaysOfWeekEnum OperatorOR(DaysOfWeekEnum a, DaysOfWeekEnum b)
        {
            return a | b;
        }

        public DaysOfWeekEnum OperatorAND(DaysOfWeekEnum a, DaysOfWeekEnum b)
        {
            return a & b;
        }

        public DaysOfWeekEnum OperatorXOR(DaysOfWeekEnum a, DaysOfWeekEnum b)
        {
            return a ^ b;
        }

        public DaysOfWeekEnum OperatorNOT(DaysOfWeekEnum a)
        {
            return ~a;
        }

        //Useful methods with flags

        public DaysOfWeekEnum SetFlag(DaysOfWeekEnum a, DaysOfWeekEnum b)
        {
            return a | b; //uses OR operator so if flag is already set, nothing changes
        }

        public DaysOfWeekEnum UnsetFlag(DaysOfWeekEnum a, DaysOfWeekEnum b)
        {
            return a & (~b);// a AND NOT b removes b flag
        }

        // Works with "None" as well
        public bool HasFlag(DaysOfWeekEnum a, DaysOfWeekEnum b)
        {
            return (a & b) == b; // if a AND b has b
        }

        public DaysOfWeekEnum ToogleFlag(DaysOfWeekEnum a, DaysOfWeekEnum b)
        {
            return a ^ b; //XOR operator allows the "Toggle" functionality
        }
    }

}