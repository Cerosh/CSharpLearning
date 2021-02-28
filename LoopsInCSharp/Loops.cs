using System;
namespace LoopsInCSharp
{
    public class Loops
    {
        public void whileLoop(int var1)
        {
            Console.WriteLine("Inside While Loop Method ");
            while (var1 < 5)
            {
                Console.WriteLine(var1);
                var1++;
            }
        }
        public void doWhileLoop(int var1)
        {
            Console.WriteLine("Inside Do While Loop Method ");
            do
            {
                Console.WriteLine(var1);
                var1++;
            } while (var1 < 5);
        }
        public void forLoop(int max)
        {
            Console.WriteLine("Inside For Loop Method ");
            for (int i = 0; i < max; i++)
            {
                Console.WriteLine(i);
            }
        }
        public void forEachLoop()
        {
            Console.WriteLine("Inside For Each Loop Method ");
            string[] cars = { "Volvo", "BMW", "Ford", "Mazda" };
            foreach (string item in cars)
            {
                Console.WriteLine(item);
            }
        }
        public void breakStatmentInLoop()
        {
            Console.WriteLine("Inside For Break statement Method ");
            for (int i = 0; i < 10; i++)
            {
                if (i == 4)
                {
                    break;
                }
                Console.WriteLine(i);
            }
        }

        public void continueStatementInLoop()
        {
            Console.WriteLine("Inside For Contniue Statement Method ");
            for (int i = 0; i < 10; i++)
            {
                if (i == 4)
                {
                    continue;
                }
                Console.WriteLine(i);
            }
        }
    }
}
