using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;// 일반화(GENERIC) 선언이 된 콜렉션

namespace CSHARP_GENERIC
{
    //제너릭 콜렉션
    //아이템만 저장할수 있는 콜렉션
    //몬스터만 저장할수 있는 콜렉션 저장소
    //우리는 보통 제네릭 콜렉션을 사용함.
    class Program
    {
        public static void TestDictionary()
        {
            Dictionary<string, string> genDic = new Dictionary<string, string>();// HASHTABLE 의 일반화 버전.
            //containskey 를 if문으로 해줘야 key 값이 없을시에 key 값에 넣어주기 가능하기떄문에 해줘야함.
            genDic.Add("txt", "notepad.exe");// <string, string> = <Key, Value>
            genDic.Add("bmp", "paint.exe");
            genDic.Add("mp3", "wmplayer.exe");
            Console.WriteLine("[Dictionary]");
            foreach(KeyValuePair<string, string> kvp in genDic)
            {
                Console.WriteLine("Key = {0}, Value = {1}", kvp.Key, kvp.Value);
            }//genDic를 for문으로 돌리기 빡셈
             //씨샵은 foreach문이 제일 편함 나도 전회사에서 많이 씀.
            
        }
        static void Main(string[] args)
        {
            TestDictionary();
        }
    }
}
