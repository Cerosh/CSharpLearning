using System;

namespace DelegatesInCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            DelegatesExample obj = new DelegatesExample();
            DelegatesExample.AddDelegate sum10 = new DelegatesExample.AddDelegate(obj.Add);
            DelegatesExample.GreetingsDelegate greet = new DelegatesExample.GreetingsDelegate(DelegatesExample.Greetings);
            sum10(100, 100);
            Console.WriteLine(greet("Cerosh"));


            DelegatesExample.AddDelegate sum20  = delegate (int x, int y){
                Console.WriteLine($"The sum of {x} and {y} us {x+y}.");
            };
            sum20(100, 100);
            DelegatesExample.GreetingsDelegate greet20 = delegate (String value)
            {
                return value;
            };
            Console.WriteLine(greet20("Cerosh"));


            DelegatesExample.GreetingsDelegate greet30 = (values) => { return values;};
            Console.WriteLine($"Hello {greet30("Cerosh")}!!!");
            DelegatesExample.AddDelegate sum30 = (x, y) => { Console.WriteLine($"The sum of {x} and {y} is {x+y}" ); };
            sum30(100, 100);


            Func<String, String> greet35 = delegate (String value) {

                return value;
	};
            Console.WriteLine(greet35("Cerosh"));

            Func<int, int, int> sum35 = delegate (int x, int y){

                return x + y;
	};
            Console.WriteLine($"The sum is {sum35(100,100)}");
    
        }
    }
}
