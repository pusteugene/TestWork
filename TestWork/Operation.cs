using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestWork
{
    public class Operation
    {
        public int A { get; set; }
        public int B { get; set; }

        public int Addition() { return A + B; }
        public int Subtraction() { return A - B; }
        public int Multiplication() { return A * B; }
        public int Divide() { return A / B; }
    }
}
