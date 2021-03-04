using System;
using System.Linq;

namespace LINQInCSharp
{
    public class LINQExamples
    {
        SelectMany[] studentArray = {
                    new SelectMany() { StudentID = 1, StudentName = "John", Age = 18 } ,
                    new SelectMany() { StudentID = 2, StudentName = "Steve",  Age = 21 } ,
                    new SelectMany() { StudentID = 3, StudentName = "Bill",  Age = 25 } ,
                    new SelectMany() { StudentID = 4, StudentName = "Ram" , Age = 20 } ,
                    new SelectMany() { StudentID = 5, StudentName = "Ron" , Age = 31 } ,
                    new SelectMany() { StudentID = 6, StudentName = "Chris",  Age = 17 } ,
                    new SelectMany() { StudentID = 7, StudentName = "Rob", Age = 19  } ,
                };

        public void LINQArrayValues()
        {
            SelectMany[] TeenageStudents = studentArray.Where(i => i.Age >= 12 && i.Age <= 19).ToArray();
            foreach (var item in TeenageStudents)
            {
                Console.WriteLine(item.StudentName);
            }
        }

        public void LinkStringValues()
        {
            SelectMany NameWithChar = studentArray.Where(c => c.StudentName.Contains('a')).FirstOrDefault();
            Console.WriteLine(NameWithChar.StudentID);
        }
    }
    class SelectMany
    {
        public int StudentID { get; set; }
        public String StudentName { get; set; }
        public int Age { get; set; }
    }

}
