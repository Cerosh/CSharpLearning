using System;
using System.Collections;

namespace CollectionsInCSharp
{
    public class hashTables
    {



        public void createAndAddElement()
        {
            Hashtable table = new Hashtable();
            table.Add(1, "One");
            table.Add(2, "Two");
            table.Add(3, "Three");

        }
        public void collectionInitializer() {
            var cities = new Hashtable(){
            {"UK", "London, Manchester, Birmingham"},
            {"USA", "Chicago, New York, Washington"},
            {"India", "Mumbai, New Delhi, Pune"}
            };
            foreach (DictionaryEntry city in cities)
            
                Console.WriteLine("Key: {0}, Value: {1}", city.Key, city.Value);
            }
        }
    }