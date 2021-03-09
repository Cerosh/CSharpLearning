using System;
using System.Collections.Generic;

namespace CSharpGenerics
{
    public class GenericDictionary
    {
        Dictionary<int, string> dObj = new Dictionary<int, string>(5);
        public void AddToGenericDictionary()
        {
            dObj.Add(1, "Tom");
            dObj.Add(2, "John");
            dObj.Add(3, "Maria");
            dObj.Add(4, "Max");
            dObj.Add(5, "Ram");

        }
        public void displayDictionary()
        {
            for (int i = 1; i <= dObj.Count; i++)
            {
                Console.WriteLine(dObj[i]);
            }

        }
    }
}