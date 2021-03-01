using System;
using ArraysInCSharp;

namespace ArraysInCSharo
{
    class Program
    {
        static void Main(string[] args)
        {
            Arrays array = new Arrays();
            Console.WriteLine("Create Array");
            array.createArray();

            Console.WriteLine("Accessing Array");
            array.accessingArray();

            Console.WriteLine("Array Length");
            array.arrayLength();

            Console.WriteLine("Change Arrray element");
            array.changeArrayElement("Opel");

            Console.WriteLine("Min, Max and Sum");
            array.otherArrayMethods();

            Console.WriteLine("Sort Array");
            array.sortArray();
        }
    }
}
