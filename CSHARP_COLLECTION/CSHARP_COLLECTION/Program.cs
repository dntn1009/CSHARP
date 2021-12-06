using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace CSHARP_COLLECTION
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList list = new ArrayList();
            list.Add(10);
            list.Add(20);
            list.Add(30);
            list.RemoveAt(1);
            list.Insert(1, 36.5f);
            list.Add("룰루랄라");
            for(int i = 0; i < list.Count; i++)
            {
                Console.WriteLine(list[i]);
            }
        }
    }
    //STACK
    //OBJECT 형식이라 박싱 언박싱으로 나눔
}
