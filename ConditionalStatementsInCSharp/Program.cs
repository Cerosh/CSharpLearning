using System;

namespace ConditionalStatementsInCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            ConditionalStatements cs = new ConditionalStatements();
            cs.ifStatment(20, 15);
            cs.ifElseStatement(15, 20);
            cs.ternaryOperator(15);
            cs.switchCase(2);
        }
    }
}
