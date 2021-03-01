using System;
using System.Linq;

namespace ArraysInCSharp
{
    public class Arrays
    {
        String[] cars = { "Volvo", "BMW", "Ford", "Mazda" };
        int[] myNumbers = { 5, 1, 8, 9 };

        public void createArray()
        {
            String[] cars = { "Volvo", "BMW", "Ford", "Mazda" };
            foreach (var item in cars)
            {
                Console.WriteLine(item);
            }
        }
        public void accessingArray()
        {
            int[] scores = { 100, 123, 151, 171 };
            Console.WriteLine(scores[0]);
        }
        public void changeArrayElement(String carName)
        {
            cars[3] = carName;
            Console.WriteLine(cars[3]);
        }
        public void arrayLength()
        {
            Console.WriteLine(cars.Length);
        }
        public void sortArray()
        {
            
            Array.Sort(myNumbers);
            foreach (var item in myNumbers)
            {
                Console.WriteLine(item);
            }
        }
        public void otherArrayMethods()
        {
            Console.WriteLine("Max: " + myNumbers.Max());
            
            Console.WriteLine("Min: " + myNumbers.Min());
           
            Console.WriteLine("Sum: " + myNumbers.Sum());
            

        }
    }
}
