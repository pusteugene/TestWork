using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestWork
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Operation operation = new Operation();
            Console.WriteLine(operation.Addition());
            Console.WriteLine(operation.Divide());
            Console.WriteLine(operation.Multiplication());
            Console.WriteLine(operation.Subtraction());
        }
    }
}
