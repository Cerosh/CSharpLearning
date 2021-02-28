using System;

namespace LoopsInCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Loops loop = new Loops();
            loop.whileLoop(6);
            loop.doWhileLoop(6);
            loop.forLoop(5);
            loop.forEachLoop();
            loop.breakStatmentInLoop();
            loop.continueStatementInLoop();
        }
    }
}
