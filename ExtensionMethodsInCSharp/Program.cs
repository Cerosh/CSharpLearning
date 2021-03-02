/*
Extension methods are additional custom methods which were originally not included with the class.
Extension methods can be added to custom, .NET Framework or third party classes, structs or interfaces.
The first parameter of the extension method must be of the type for which the extension method is applicable,
preceded by the this keyword.
Extension methods can be used anywhere in the application by including the namespace of the extension method.
 */
using System;
namespace ExtensionMethodsInCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 10;
            Console.WriteLine(x.IsGreaterThan(11));
            Console.WriteLine(x.IsGreaterThan(9));

            string[] language = {"Ruby", "C", "C++", "Java","Perl", "C#", "Python", "PHP"};
            Console.WriteLine(language.ExistInArray("JScript"));
            Console.WriteLine(language.ExistInArray("C#"));
        }
    }
}
