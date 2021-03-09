using System;
using CSharpGenerics.Properties;

namespace CSharpGenerics
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            GenericClass<int> intObj = new GenericClass<int>();
            intObj.Add(1);
            intObj.Add(2);
            intObj.Add(3);
            intObj.Add(4);
            intObj.Add(5);
            intObj.Add('C');
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(intObj[i]);
            }
            GenericClass<string> strObj = new GenericClass<string>();
            strObj.Add("hello");
            strObj.Add("hello");
            strObj.Add("hello");
            strObj.Add("hello");
            strObj.Add("hello");
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(strObj[i]);
            }
            GenericMethod methodObj = new GenericMethod();
            int a = 40, b = 60;
            string x = "hello", y = "world";
            Console.WriteLine($"Integers before swap: {a}, {b} and String before swap:{x}, {y} ");
            methodObj.Swap<int>(ref a, ref b);
            methodObj.Swap<String>(ref x, ref y);
            Console.WriteLine($"Integers after swap: {a}, {b} and String after swap: {x}, {y}");


            GenericDictionary dictObj = new GenericDictionary();
            dictObj.AddToGenericDictionary();
            dictObj.displayDictionary();
        }
    }
}
