using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace CSHARP_QUQUE
{
    // 데이터를 보관하는 역할
    // 큐라는 공간
    // (DEQUQUE)data0 <--- data1/data2/data3 <--- data4(ENQUQUE)
    // 가장 먼저 들어온 데이터가 먼저 빠져나간다.
    //FIFO구조 선입 선출

    class Program
    {
        static void Main(string[] args)
        {
            Queue que = new Queue();
            que.Enqueue(10);
            que.Enqueue(20);
            que.Enqueue(30);
            que.Dequeue();
            que.Enqueue(4.4);
            que.Dequeue();
            que.Enqueue("ABC");
            while(que.Count > 0)
            {
                Console.WriteLine(que.Dequeue());
            }
        }
    }
}
