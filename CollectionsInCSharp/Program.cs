using System;

namespace CollectionsInCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hash Tables");
            hashTables ht = new hashTables();
            ht.createAndAddElement();
            ht.collectionInitializer();
            Console.WriteLine("Dictionaries");
            Dictionary d = new Dictionary();
            d.createAndAddElement();
            d.collectionInitialiser();
            Console.WriteLine("Custom Type");
            CustomType ct = new CustomType();
            ct.customTypeCreation();


        }
    }
}
