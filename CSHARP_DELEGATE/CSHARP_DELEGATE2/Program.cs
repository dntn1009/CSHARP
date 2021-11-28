using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSHARP_DELEGATE2
{
    delegate int TestDelegate(int a, int b);
    class Calculator
    {
        public int Plus(int a, int b) { return a + b; }
        public int Minus(int a, int b) { return a - b; }
        public int Multiply(int a, int b) { return a * b; }
    }

    class Program
    {
        public static void Calculator(int a, int b, TestDelegate callback)
        {
            Console.WriteLine(callback(a, b));
        }// 함수에 callback을 넣어서 printf(delegate)만듬

        static void Main(string[] args)
        {

            Calculator cal = new Calculator();
            Calculator(10, 20, cal.Plus);
            Calculator(10, 20, cal.Minus);
            Calculator(10, 20, cal.Multiply);
        }
    }
}
