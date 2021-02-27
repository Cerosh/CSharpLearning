using System;
namespace TypesInCSharp
{
    public class TypeCasting
    {
        int myInt = 10;
        double myDouble = 5.25;
        bool myBool = true;

        public static double implicitCasting()
        {
            int myInt = 9;
            double myDouble = myInt;
            return myDouble;
        }
        public static int explicitCasting()
        {
            double myDouble = 9.78;
            int myInt = (int)myDouble;
            return myInt;
        }
        public static bool conversionMethods()
        {
            bool myBool = true;
            return myBool;
        }

        public static string varType()
        {
            var myValue = 270;
            return myValue.GetType().Name;
        }
    }
}
