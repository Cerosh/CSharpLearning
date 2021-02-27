using System;
namespace MethodsInCSharp
{
    public class MethodOverloading
    {
        public void Add()
        {
            Console.WriteLine("This is a empty argument method");
        }

        public void Add(int num1, int num2)
        {
            int result = num1 + num2;
            Console.WriteLine("The sum of arguments is: "+ result);
        }
    }
}
