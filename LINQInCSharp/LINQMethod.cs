using System;
using System.Collections.Generic;
using System.Linq;

namespace LINQInCSharp
{
    public class LINQMethod
    {
        IList<Student> studentList = new List<Student>() {
        new Student() { StudentID = 1, StudentName = "John", Age = 13} ,
        new Student() { StudentID = 2, StudentName = "Moin",  Age = 21 } ,
        new Student() { StudentID = 3, StudentName = "Bill",  Age = 18 } ,
        new Student() { StudentID = 4, StudentName = "Ram" , Age = 20} ,
        new Student() { StudentID = 5, StudentName = "Ron" , Age = 15 }
    };
        public void simpleLinqMethod()
        {
            var teenagestudent = studentList.Where(s => s.Age >=12 && s.Age <=19).ToList<Student>();
            foreach (var item in teenagestudent)
            {
                Console.WriteLine(item.StudentName);
            }
        }
    }
}
