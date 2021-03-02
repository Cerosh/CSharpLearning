using System;
namespace InterfacesInCSharp
{
    class ExplicitInterfaceImplementation : IFileInterface
    {

        void IFileInterface.ReadFile()
        {
            Console.WriteLine("Reading file from explicit interface");
        }

        void IFileInterface.WriteFile(string text)
        {
            Console.WriteLine(text);
        }

    }

}
