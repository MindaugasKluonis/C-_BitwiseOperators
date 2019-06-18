using System;

namespace BinaryOperationsWithEnums
{
    class Program
    {
        static void Main(string[] args)
        {
            EnumBitwiseOperators enumBitwise = new EnumBitwiseOperators();

            Employee john = new Employee
            {
                Name = "John",
                AvailableForWorkDays = DaysOfWeekEnum.Monday | DaysOfWeekEnum.Wednesday | DaysOfWeekEnum.Weekend // bitwise OR operator to store multiple enum values
            };

            Employee sarah = new Employee
            {
                Name = "Sarah",
                AvailableForWorkDays = DaysOfWeekEnum.Monday | DaysOfWeekEnum.Tuesday | DaysOfWeekEnum.Friday
            };

            Console.WriteLine("John can only work " + john.AvailableForWorkDays);
            Console.WriteLine("Sarah can only work " + sarah.AvailableForWorkDays);

            DaysOfWeekEnum daysCoveredByEitherEmployee = enumBitwise.OperatorOR(john.AvailableForWorkDays, sarah.AvailableForWorkDays);// days that are covered by either employee
            Console.WriteLine("Days covered by either employee: " + daysCoveredByEitherEmployee);

            DaysOfWeekEnum daysCoveredByBothEmployees = enumBitwise.OperatorAND(john.AvailableForWorkDays, sarah.AvailableForWorkDays);// days that are covered by both employee's
            Console.WriteLine("Days covered by both employee's: " + daysCoveredByBothEmployees);

            DaysOfWeekEnum daysCoveredByAtLeastOneButNotBoth = enumBitwise.OperatorXOR(john.AvailableForWorkDays, sarah.AvailableForWorkDays);
            Console.WriteLine("Days covered by one but not both: " + daysCoveredByAtLeastOneButNotBoth);

            //Add Saturday to sarah
            sarah.AvailableForWorkDays = enumBitwise.SetFlag(sarah.AvailableForWorkDays, DaysOfWeekEnum.Saturday);
            Console.WriteLine("Sarah got Saturday :(            " + sarah.AvailableForWorkDays);

            //John got weekend off lol
            john.AvailableForWorkDays = enumBitwise.UnsetFlag(john.AvailableForWorkDays, DaysOfWeekEnum.Weekend);
            Console.WriteLine("John got weekend off(yay)            " + john.AvailableForWorkDays);

            Console.ReadKey(true);
        }
    }
}
