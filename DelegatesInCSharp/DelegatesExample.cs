/*Delegate can hold the reference of a method and then calls that method for execution. We can call the method using the object
 * of the class if it is a non-static method or we can call the method through class name if it is a static method.We can also 
 * call a method in C# by using delegates. Calling a C# method using delegate will be faster in execution as compared to the first process 
 * A delegate in C# is a user-defined type and hence before invoking a method using delegate, we must have to define that delegate first.
 * The signature of the delegate must match the signature of the method, the delegate points to otherwise we will get a compiler error. 
 * This is the reason why delegates are called as type-safe function pointers.
 * */
using System;
namespace DelegatesInCSharp
{
    public class DelegatesExample
    {
        public delegate void AddDelegate(int x, int y);
        public delegate string GreetingsDelegate(String name);

        public void Add(int x, int y)
        {
            Console.WriteLine($"The sum of {x} and {y}  is {x+y}");
        }

        public static string Greetings(String name)
        {
            return $"Hello {name}!!!";
        }

          
        

        
    }
}
 