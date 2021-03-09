using System;
namespace CSharpGenerics
{
    public class GenericClass<T>
    {
        T[] Obj = new T[5];
        int count = 0;
        public void Add(T item)
        {
            if (count + 1 < 6)
            {
                Obj[count] = item;
            }
            count++;
        }
        public T this[int index]
        {
            get { return Obj[index]; }
            set { Obj[index] = value; }
        }
    }
}
