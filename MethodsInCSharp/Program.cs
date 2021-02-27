using System;

namespace MethodsInCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            MethodOverloading mo = new MethodOverloading();
            mo.Add();
            mo.Add(4, 5);
            Console.Read();
        }
    }
}
