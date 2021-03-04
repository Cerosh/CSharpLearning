using System;
using System.Collections.Generic;
using System.Linq;

namespace LINQInCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            LINQQuery linq = new LINQQuery();
            Console.WriteLine("Simpler Linq Query with a char in name");
            linq.simpleLinqQuery('e');
           
            LINQExamples eg = new LINQExamples();
            Console.WriteLine("Linq Query returning a array based on condition");
            eg.LINQArrayValues();
            Console.WriteLine("Linq Query returning first value based on condition");
            eg.LinkStringValues();
            Console.WriteLine("Linq Method returning a array based on condition");
            LINQMethod method = new LINQMethod();
            method.simpleLinqMethod();
            
            Console.WriteLine("Method And Query");
            method.AgeSelectionMethod();
            linq.ageSelectionQuery();

            Console.WriteLine("Projection Method");
            method.ProjectionMethod();
            linq.ProjectionMethod();

            Console.WriteLine("Using Method Syntax");
            List<string> MethodSyntax = StudentSelectMany.GetStudents().SelectMany(std => std.Programming).Distinct().ToList();
            var MethodWithNameAndProgram = StudentSelectMany.GetStudents()
                                        .SelectMany(std => std.Programming,
                                             (student, program) => new
                                             {
                                                 StudentName = student.Name,
                                                 ProgramName = program
                                             }).ToList();
            foreach (string program in MethodSyntax)
            {
                Console.WriteLine(program);
            }
            foreach (var item in MethodWithNameAndProgram)
            {
                Console.WriteLine(item.StudentName + " => " + item.ProgramName);
            }
            Console.WriteLine("Using Query Syntax");
            IEnumerable<string> QuerySyntax = (from std in StudentSelectMany.GetStudents()
                                              from program in std.Programming
                                              select program).Distinct().ToList();
            var QueryWithNameAndProgram = (from std in StudentSelectMany.GetStudents()
                               from program in std.Programming
                               select new
                               {
                                   StudentName = std.Name,
                                   ProgramName = program
                               }).ToList();
            foreach (string program in QuerySyntax)
            {
                Console.WriteLine(program);
            }
            foreach (var item in QueryWithNameAndProgram)
            {
                Console.WriteLine(item.StudentName + " => " + item.ProgramName);
            }
        }
    }
}
