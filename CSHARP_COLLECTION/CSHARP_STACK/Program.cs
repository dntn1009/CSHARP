using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace CSHARP_STACK
{
    //STACK
    //넣는 순서대로 쌓임 PUSH
    //가장 늦게 들어온 순서부터 제거 POP


    class Program
    {
        static void Main(string[] args)
        {
            Stack stack = new Stack();
            stack.Push(10);
            stack.Push(20);
            stack.Push(30);
            stack.Pop();
            stack.Push(4.4);
            stack.Pop();
            stack.Push("ABC");
            while(stack.Count > 0)
            {
                Console.WriteLine(stack.Pop());
            }
        }
    }
}
