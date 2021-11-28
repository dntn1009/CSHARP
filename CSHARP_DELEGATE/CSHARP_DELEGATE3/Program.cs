using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSHARP_DELEGATE3
{
    delegate int TestDelegate(int a, int b);

    class Calculator
    {
        public int Plus(int a, int b)
        {
            Console.WriteLine("{0} + {1} = {2}", a, b, a + b);
            return a + b;
        }
        public int Minus(int a, int b)
        {
            Console.WriteLine("{0} - {1} = {2}", a, b, a - b);
            return a - b;
        }
        public int Multiply(int a, int b)
        {
            Console.WriteLine("{0} * {1} = {2}", a, b, a * b);
            return a * b;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Calculator cal = new Calculator();
            TestDelegate del = cal.Plus;
            del += cal.Minus;
            del += cal.Multiply;
            del(10, 20);
            del -= cal.Plus;
            del -= cal.Minus;
            del(20, 30);
        }
    }
}
