using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace CSHARP_GENERIC3
{
    //LinkedList => 노드를 노드와연결시키는 list prev , next가 있는데
    //prev가 없는 링크리스트는 첫번째 노드임
    //첫번째는 Head(First), 마지막은 Tail(Last)이라고 함.
    class Program
    {
        public static void TestLinkedList()
        {
            LinkedList<string> genLL = new LinkedList<string>();//링크리스트 객체 생성
            genLL.AddLast("4등"); //마지막 노드 생성
            genLL.AddFirst("1등");//첫번쨰 노드 생성
            genLL.AddAfter(genLL.Find("1등"), "2등");//1등 노드 앞에 연결
            genLL.AddBefore(genLL.Find("4등"), "3등");//4등 노드 뒤에 연결
            Console.WriteLine("[LinkedList]");
            genLL.Remove("1등");
            foreach(string str in genLL)
            {
                Console.WriteLine("Value = {0}", str);
            }

        }
        static void Main(string[] args)
        {
            TestLinkedList();
        }
    }
}
