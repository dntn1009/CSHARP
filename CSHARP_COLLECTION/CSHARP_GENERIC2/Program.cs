using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSHARP_GENERIC2
{
    class SortedListGenericClass
    {
        //딕셔너리와의 차이점은 정렬을 함.
        // 키값을 기준으로 정리를함.
        // 1 -> 3 -> 2 로 저장을 하게되면 자동으로 정렬이 되어서 1 , 2 ,3 으로 저장이됨.
        public void TestSortedListGeneric()
        {
            SortedList<int, string> colorSort = new SortedList<int, string>();
            colorSort.Add(1, "Red");
            colorSort.Add(3, "Green");
            colorSort.Add(2, "Blue");
            foreach (KeyValuePair<int, string> color in colorSort)
                Console.WriteLine("Key {0} Color {1}", color.Key, color.Value);
                Console.WriteLine("현재 리스트 크기 : {0}", colorSort.Capacity);//Capacity 추가가 되어있는 메모리의 크기 즉, 몇개의 요소를 넣을수 있는지 묻는 공간
                                                                         //원래 저장된 공간의 +  1 = capcity
                colorSort.TrimExcess(); // 트림 액세스는 공간을 지워주는 역할 => 사용하지 않는 공간들을 지워준다.
                                        // 
                Console.WriteLine("현재 리스트 크기 : {0}, 요소의 갯수 : {1}", colorSort.Capacity, colorSort.Count);
                colorSort.Remove(2);
                colorSort.TrimExcess();
                Console.WriteLine("현재 리스트 크기 : {0}, 요소의 갯수 : {1}", colorSort.Capacity, colorSort.Count);
        }
       

    }

    class Program
    {
        static void Main(string[] args)
        {
            SortedListGenericClass sortedList = new SortedListGenericClass();
            sortedList.TestSortedListGeneric();
        }
    }

}
