/*
1. Interface can contain declarations of method, properties, indexers, and events.
2. Interface cannot include private, protected, or internal members.All the members are public by default.
3. Interface cannot contain fields, and auto-implemented properties.
4. A class or a struct can implement one or more interfaces implicitly or explicitly. Use public modifier when implementing interface implicitly,
whereas don't use it in case of explicit implementation.Implement interface explicitly using InterfaceName.MemberName.
5. An interface can inherit one or more interfaces.
*/
using System;
namespace InterfacesInCSharp
{
    public class ImplementingInterface : IFileInterface
    {
        public void ReadFile()
        {
            Console.WriteLine("Reading File");
        }

        public void WriteFile(string text)
        {
            Console.WriteLine(text);
        }

       

        static void Main(string[] args)
        {
            ImplementingInterface II = new ImplementingInterface();
            Console.WriteLine();
            II.WriteFile("Writing to file");
            II.ReadFile();

            IFileInterface EI = new ExplicitInterfaceImplementation();
            EI.WriteFile("Writing to file explicitly");
            EI.ReadFile();
            

        }
    }
}
