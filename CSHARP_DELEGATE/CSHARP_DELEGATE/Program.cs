using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSHARP_DELEGATE
{
    class Program
    {
        delegate int TestDelegate(int a, int b);//함수를 값으로 가질수 있음.
        public static int Plus(int a, int b) { return a + b; }
        public static int Minus(int a, int b) { return a - b; }

        static void Main(string[] args)
        {
            TestDelegate calculate;// TestDelegate를 calculate로 선언
            calculate = new TestDelegate(Plus);// class마냥 new 선언 후 Plus 함수를 값으로 가짐.
            int result = calculate(20, 30);// result 값을 calculate(20, 30) 으로 Plus 더한값을 return해줌.
            Console.WriteLine(result);


        }
    }
}
