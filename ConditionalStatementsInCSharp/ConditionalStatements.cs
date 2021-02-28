using System;
namespace ConditionalStatementsInCSharp
{
    public class ConditionalStatements
    {
        public void ifStatment(int val1, int val2)
        {
            if (val1 > val2)
            {
                Console.WriteLine($"{val1} is greater than {val2}");
            }
        }

        public void ifElseStatement(int val1, int val2)
        {
            if (val1 > val2)
            {
                Console.WriteLine($"{val1} is greater than {val2}");
            }
            else
            {
                Console.WriteLine($"{val1} is Less than {val2}");
            }
        }

        public void ternaryOperator(int time)
        {
            String result = (time < 18) ? "Good day" : "Good evening";
            Console.WriteLine( result);
        }
        public void switchCase(int dayOfWeek)
        {
            switch (dayOfWeek)
            {
                case 1:
                    Console.WriteLine("Monday");
                    break;
                case 2:
                    Console.WriteLine("Tuesday");
                    break;
                case 3:
                    Console.WriteLine("Wednesday");
                    break;
                default:
                    Console.WriteLine("Not Defined day");
                    break;
            }
        }
    }
}
