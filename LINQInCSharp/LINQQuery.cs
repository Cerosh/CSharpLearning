/*
Query Syntax starts with from clause and can be end with Select or GroupBy clause.
Use various other opertors like filtering, joining, grouping, sorting operators to construct the desired result.
Implicitly typed variable - var can be used to hold the result of the LINQ query.
 */
using System;
using System.Linq;

namespace LINQInCSharp
{
    public class LINQQuery
    {
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

    }
}
