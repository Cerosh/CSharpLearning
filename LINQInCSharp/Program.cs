using System;

namespace LINQInCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            LINQQuery linq = new LINQQuery();
            Console.WriteLine("Simpler Linq Query with a char in name");
            linq.simpleLinqQuery('e');

            LINQExamples eg = new LINQExamples();
            Console.WriteLine("Linq Query returning a array based on condition");
            eg.LINQArrayValues();
            Console.WriteLine("Linq Query returning first value based on condition");
            eg.LinkStringValues();
            Console.WriteLine("Linq Method returning a array based on condition");
            LINQMethod method = new LINQMethod();
            method.simpleLinqMethod();
        }
    }
}
