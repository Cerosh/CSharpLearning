using System;
namespace TypesInCSharp
{
    public class Enums
    {
        enum WeekDays
        {
            Monday = 0,
            Tuesday = 1,
            Wednesday= 2,
            Thursday= 3,
            Friday= 4,
            Saturday= 5,
            Sunday= 6
        }
        public void enumMethod()
        {
            Console.WriteLine(">>>>Access an Enum<<<<<<<<<<<<<<");
            Console.WriteLine(WeekDays.Monday);
            Console.WriteLine(">>>>enum to int conversion<<<<<<");
            Console.WriteLine((int)WeekDays.Tuesday);
            Console.WriteLine(">>>>int to enum conversion<<<<<<<");
            Console.WriteLine((WeekDays)5);
        }
        
    }
}
