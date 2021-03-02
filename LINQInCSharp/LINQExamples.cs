using System;
using System.Linq;

namespace LINQInCSharp
{
    public class LINQExamples
    {
        Student[] studentArray = {
                    new Student() { StudentID = 1, StudentName = "John", Age = 18 } ,
                    new Student() { StudentID = 2, StudentName = "Steve",  Age = 21 } ,
                    new Student() { StudentID = 3, StudentName = "Bill",  Age = 25 } ,
                    new Student() { StudentID = 4, StudentName = "Ram" , Age = 20 } ,
                    new Student() { StudentID = 5, StudentName = "Ron" , Age = 31 } ,
                    new Student() { StudentID = 6, StudentName = "Chris",  Age = 17 } ,
                    new Student() { StudentID = 7, StudentName = "Rob", Age = 19  } ,
                };

        public void LINQArrayValues()
        {
            Student[] TeenageStudents = studentArray.Where(i => i.Age >= 12 && i.Age <= 19).ToArray();
            foreach (var item in TeenageStudents)
            {
                Console.WriteLine(item.StudentName);
            }
        }

        public void LinkStringValues()
        {
            Student NameWithChar = studentArray.Where(c => c.StudentName.Contains('a')).FirstOrDefault();
            Console.WriteLine(NameWithChar.StudentID);
        }
    }
    class Student
    {
        public int StudentID { get; set; }
        public String StudentName { get; set; }
        public int Age { get; set; }
    }

}
