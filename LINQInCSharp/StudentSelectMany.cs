using System;
using System.Collections.Generic;

namespace LINQInCSharp
{
    public class StudentSelectMany
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public List<string> Programming
        {
            get; set;
        }
        public static List<StudentSelectMany> GetStudents()

        {
            return new List<StudentSelectMany>() {
                new StudentSelectMany(){ID = 1, Name = "James", Email = "James@j.com", Programming = new List<string>() { "C#", "Jave", "C++"}},
                new StudentSelectMany(){ID = 2, Name = "Sam", Email = "Sara@j.com", Programming = new List<string>() { "WCF", "SQL Server", "C#" }},
                new StudentSelectMany(){ID = 3, Name = "Patrik", Email = "Patrik@j.com", Programming = new List<string>() { "MVC", "Jave", "LINQ"}},
                new StudentSelectMany(){ID = 4, Name = "Sara", Email = "Sara@j.com", Programming = new List<string>() { "ADO.NET", "C#", "LINQ" }}
            };
        }
    }
}
