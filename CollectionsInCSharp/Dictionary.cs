using System;
using System.Collections.Generic;

namespace CollectionsInCSharp
{
    public class Dictionary
    {
        public void createAndAddElement()
        {
            IDictionary<int,String> dict = new Dictionary<int, String>();
            dict.Add(1, "One");
            dict.Add(2, "Two");
            dict.Add(3, "Three");
            foreach (KeyValuePair<int, String>  kvp in dict)
            {
                Console.WriteLine("Key: {0}, Value: {1}", kvp.Key, kvp.Value);
            }

        }

        public void collectionInitialiser()
        {
            var cities = new Dictionary<string, string>
            {
                {"UK", "London, Manchester, Birmingham"},
                {"USA", "Chicago, New York, Washington"},
                {"India", "Mumbai, New Delhi, Pune"}
            };
            foreach (var item in cities)
            {
                Console.WriteLine("Key: {0}, Value: {1}",
                item.Key, item.Value);
            }
        }
    }
}
