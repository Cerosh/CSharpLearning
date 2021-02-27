using System;
using static TypesInCSharp.TypeCasting;

namespace TypesInCSharp
{
    public class EmptyClass
    {

       

        static void Main(string[] args)
        {
            int myNum = 5;
            Console.WriteLine( $"Integer (whole number): {myNum}");

            double myDoubleNum = 5.99D;
            Console.WriteLine($"Floating point number: {myDoubleNum}");

            char myLetter = 'D';
            Console.WriteLine($"Character: {myLetter}");

            bool myBool = true;
            Console.WriteLine($"Boolean : {myBool}");
            string myText = "Hello";  
            Console.WriteLine($"String :{myText}");

            Console.WriteLine($"Automatic casting: int to double: {implicitCasting()}");

            Console.WriteLine($"Manual casting : double to int: {explicitCasting()}");
            Console.WriteLine($"convert bool to string: {Convert.ToString(conversionMethods())}");
            Console.WriteLine("Finding the type of variable: " + varType());

        }
    }
}
