using System;
namespace ExtensionMethodsInCSharp
{
    public static class ExtensionMethod
    {
        public static bool IsGreaterThan(this int i, int value)
        {
            return i > value;
        }

        public static bool ExistInArray(this string[] language, string value)
        {
            return Array.Exists(language, element => element == value);
        }
    }
}
