using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CSHARP__CtoFtoC
{
    // C++과 다른 적용법
    // class 사용법
    class Program
    {
        static void Main(string[] args)
        {
            int select = 0;
            float temp = 0;
            Console.Write("1. 섭씨->화씨\n");
            Console.Write("2. 화씨->섭씨\n");
            select = int.Parse(Console.ReadLine());
            switch (select)
            {
                case 1:
                    Console.Write("변환할 섭씨 온도를 입력해주세요.\n");
                    temp = float.Parse(Console.ReadLine());
                    temp = Temperature.CtoF(temp);
                    Console.Write("변환한 온도는 화씨 {0:f2} 입니다. \n", temp);
                    break;
                case 2:
                    Console.Write("변환할 화씨 온도를 입력해주세요.\n");
                    temp = float.Parse(Console.ReadLine());
                    temp = Temperature.FtoC(temp);
                    Console.Write("변환한 온도는 섭씨 {0:f2} 입니다. \n", temp);
                    break;
                default:
                    break;
            }
        }
    }
}
