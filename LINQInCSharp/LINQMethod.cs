using System;
using System.Collections.Generic;
using System.Linq;

namespace LINQInCSharp
{
    public class LINQMethod
    {
        IList<SelectMany> studentList = new List<SelectMany>() {
        new SelectMany() { StudentID = 1, StudentName = "John", Age = 13} ,
        new SelectMany() { StudentID = 2, StudentName = "Moin",  Age = 21 } ,
        new SelectMany() { StudentID = 3, StudentName = "Bill",  Age = 18 } ,
        new SelectMany() { StudentID = 4, StudentName = "Ram" , Age = 20} ,
        new SelectMany() { StudentID = 5, StudentName = "Ron" , Age = 15 }
    };
        public void simpleLinqMethod()
        {
            var teenagestudent = studentList.Where(s => s.Age >=12 && s.Age <=19).ToList<SelectMany>();
            foreach (var item in teenagestudent)
            {
                Console.WriteLine(item.StudentName);
            }
        }

        public void AgeSelectionMethod()
        {
            var selectedAge = studentList.Where(i => i.Age == 20);
            foreach (var item in selectedAge)
            {
                Console.WriteLine(item.StudentName);
            }
        }

        public void ProjectionMethod()
        {
            var studentId = studentList.Where(i => i.StudentID== 3).Select(student => new { FirstName = student.StudentName });
            foreach (var item in studentId)
            {
                Console.WriteLine(item.FirstName);
            }
        }
    }
}
