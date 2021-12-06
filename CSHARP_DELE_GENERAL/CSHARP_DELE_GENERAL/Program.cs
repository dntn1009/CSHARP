using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

delegate T TestDelegate<T>(T a, T b);

/*
 private EventHandler _Event;
event를 위에 붙이면
아래와 같이 변한다.
public event EventHandler Event
{
    add
    {
        lock(this) { _Event += value; }
    }

    remove
    {
        lock(this) { _Event -= value; }
    }
}
*/
//함수를 추가하거나 제거하는 기능이기 때문에 get set 과 비슷하지만 add 와 remove를 사용한다.
//델리게이트와 사용하는건 똑같으나 메서드로서 동작함.
// 프로퍼티 변수는 프라이빗이니까 접근 금지지만 사용하는 것만 보면 일반 변수쓰는 것과 똑같다.
//델리게이트를 변수로만 사용할건지 메소드로서 동작하게 할건지는 앞의 event 선언에 따라 달라진다.\

//interface는 메소드만 만들수 있다. 그래서 변수를 만들때 evnet를 이용한다.
namespace CSHARP_DELE_GENERAL
{
    class Calculator
    {
        public int Plus(int a, int b) { return a + b; }
        public float Plus(float a, float b) { return a + b; }
        public int Minus(int a, int b) { return a - b; }
        public float Minus(float a, float b) { return a - b; }
        public int Multiply(int a, int b) { return a * b; }
        public float Multiply(float a, float b) { return a * b; }
    }

    class Program
    {
        public static void Calculator<T>(T a, T b, TestDelegate<T> callback)
        {
            Console.WriteLine(callback(a, b));
        }
        static void Main(string[] args)
        {
            Calculator cal = new Calculator();//class calculator
            Calculator(10, 20, cal.Plus);// public static void Calculator<T>(T a, T b, TestDelegate<T> callback)
            Calculator(54.6f, 95.32f, cal.Plus);
            Calculator(200.5f, 120.10f, cal.Minus);
            Calculator(36.5f, 42.3f, cal.Multiply);
        }
    }
}
