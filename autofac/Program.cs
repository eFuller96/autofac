using System;

namespace autofac
{
    class Program
    {
        static void Main(string[] args)
        {
            var myProgram = new SomeProgram();
            myProgram.DoThings();
            Console.ReadLine();
        }
    }
}
