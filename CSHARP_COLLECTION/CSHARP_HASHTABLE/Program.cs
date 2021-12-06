using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace CSHARP_HASHTABLE
{
    class Program
    {
        // 데이터를 저장하는 것은 맞지만 키와 데이터를 한쌍으로 가지고있음.
        // .ini와 같은 느낌으로 보면 된다.

        static void Main(string[] args)
        {
            Hashtable ht = new Hashtable();
            if(!ht.ContainsKey("오렌지"))// 오렌지라는 키값이 있는지 if문으로 확인
            {
                ht.Add("오렌지", "Orange"); // 없으면 오렌지 키에 Orange 값 저장
            }
            if (!ht.ContainsKey("바나나"))
            {
                ht.Add("바나나", "Banana");
            }
            if (!ht.ContainsKey("사과"))
            {
                ht.Add("사과", "Apple");
            }
            foreach(String s in ht.Keys)
            {
                Console.WriteLine(s);
                Console.WriteLine(ht[s]);
            }
            Console.WriteLine(ht["오렌지"]);
            Console.WriteLine(ht["바나나"]);
            Console.WriteLine(ht["사과"]);

        }
    }
}
