using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSHARP_GENERAL
{
    class List<T>// class를 T로 선언
    {
        private T[] arr;
        public List() { arr = new T[2]; }// 생성자로 arr에 T[2] 선언
        public int Length { get { return arr.Length; } }//함수 Length 선언 arr 배열의 길이를 알려줌
        public void InitArray(int index, T value) { arr[index] = value; }// arr의 index번호안에 value값 넣음
        public T GetValue(int index) { return arr[index]; }// 해당index의 값을 가져옴.
    }

    class Program
    {
        static void Print<T>(T value)//<T> 어떠한 자료형도 다받아들이겠다. T value = T를 value로 선언
        {
            Console.WriteLine(value);
        }

        static void CopyArray<T>(T[] src, T[] dest)
        {
            src.CopyTo(dest, 0); // 배열 복사
        }

        static void Main(string[] args)
        {
            string name = "정수현";
            int age = 38;
            float height = 178.5f;
            double weight = 76.5d;
            Print<string>(name);
            Print<int>(age);
            Print<float>(height);
            Print<double>(weight);

            List<int> list1 = new List<int>();// class T를 int로 설정하여 불러옴
            List<float> list2 = new List<float>();// class T를 float로 설정하여 불러옴
            List<string> list3 = new List<string>();// class T를 string로 설정하여 불러옴
            list1.InitArray(0, 58);
            list1.InitArray(1, 30);
            list2.InitArray(0, 75.2f);
            list2.InitArray(0, 65.5f);
            list3.InitArray(0, "아모개");
            list3.InitArray(1, "정수현");
            for(int i = 0; i < list1.Length; i++)
            {
                Print("이름 : " + list3.GetValue(i));
                Print("나이 : " + list1.GetValue(i));
                Print("몸무게 : " + list2.GetValue(i));
            }

            int[] srcInt = { 1, 2, 3, 4, 5 };
            int[] tagInt = new int[srcInt.Length];
            string[] srcStr = { "hello", "sbs", "game", "academy"  };
            string[] tagStr = new string[srcStr.Length];
            CopyArray<int>(srcInt, tagInt);
            CopyArray<string>(srcStr, tagStr);
            for (int i = 0; i < srcInt.Length; i++) Print(tagInt[i]);
            for (int i = 0; i < srcStr.Length; i++) Print(tagStr[i]);
        }
    }
}
