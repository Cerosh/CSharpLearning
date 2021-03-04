/*
Query Syntax starts with from clause and can be end with Select or GroupBy clause.
Use various other opertors like filtering, joining, grouping, sorting operators to construct the desired result.
Implicitly typed variable - var can be used to hold the result of the LINQ query.
 */
using System;
using System.Collections.Generic;
using System.Linq;

namespace LINQInCSharp
{
    public class LINQQuery
    {
        
        IList<SelectMany> studentList = new List<SelectMany>() {
        new SelectMany() { StudentID = 1, StudentName = "John", Age = 13} ,
        new SelectMany() { StudentID = 2, StudentName = "Moin",  Age = 21 } ,
        new SelectMany() { StudentID = 3, StudentName = "Bill",  Age = 18 } ,
        new SelectMany() { StudentID = 4, StudentName = "Ram" , Age = 20} ,
        new SelectMany() { StudentID = 5, StudentName = "Ron" , Age = 15 }
    };
        public void simpleLinqQuery(char c) {
            string[] names = { "Bill", "Steve", "James", "Mohan" };
            var myLinkQuery = from name in names
                              where name.Contains(c)
                              select name;

            foreach (var item in myLinkQuery)
            {
                Console.WriteLine(item);
            }
        }
        public void ageSelectionQuery()
        {
            var selectedAge = from stud in studentList
                              where stud.Age == 20
                              select stud;
            foreach (var item in selectedAge)
            {
                Console.WriteLine(item.StudentName);
            }
        }
        public void ProjectionMethod()
        {
            var studentId = from stud in studentList
                            where stud.StudentID == 3
                            select new { FirstName = stud.StudentName };
            foreach (var item in studentId)
            {
                Console.WriteLine(item.FirstName);
            }
        }

    }
}
