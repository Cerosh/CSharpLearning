using System;
namespace CSharpGenerics.Properties
{
    public class GenericMethod
    {
        public void Swap<T>(ref T a, ref T b)
        {
            T temp;
            temp = a;
            a = b;
            b = temp;
        }
    }
}
