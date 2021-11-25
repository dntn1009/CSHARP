using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Hero
{
    #region Constants and Fields
    private const int MAX_HP = 500;
    private int hp = 0;
    #endregion // region으로 변수 메서드 차례대로 정리하여 깔끔하게 가능
    #region Public Properties
    public int Gethp() { return hp; }//getset
    #endregion
    #region Methods
    public Hero()//기본 생성자
    {
        hp = MAX_HP;
    }
    public void LevelUP()
    {
        hp = MAX_HP;
    }
    public void Damage(int dmg)
    {
        if (hp - dmg > 0) hp -= dmg;// HP 깍음
        else { hp = 0; }// HP가 0이거나 -? 면 0으로 처리 die
    }
    #endregion
}

namespace CSHARP_BASIC2
{
    class Program
    {
        class Point
        {
            private int x, y;
            public Point(int _x, int _y)
            {
                x = _x;
                y = _y;
            }
            public void Print()
            {
                System.Console.WriteLine("({0},{1})", x, y);
            }
        }
        static void Add(int c, int d, out int sum)// ref int num => num이 레퍼런스 타입으로 바뀜 참조형식
        {
            sum = c + d; // out = 값을 전달만 하는 용도로 쓰임 주려는게 아님.
        }

        static void Main(string[] args)
        {
            Hero myhero = new Hero();//선언
            myhero.Damage(120);
            Console.WriteLine("현재 HP :" + myhero.Gethp());

            int num1 = 10, num2 = 20;
            int sum;
            Add(num1, num2, out sum);
            Console.WriteLine("{0} + {1} = {2}", num1, num2, sum);

            int i = 0;
            int[] arr = new int[5] { 10, 20, 30, 40, 50 };

            foreach (int n in arr)
            {
                Console.WriteLine("arr[{0}] : {1}", i, n);
                i++;
            }//for문 형식과 유사하지만 배열같은 단위를 이용할때 편함
            // arr안에 있는걸 for문 돌린다고 생각

            Point[] arr_p = new Point[3] { new Point(1, 1), new Point(2, 2), new Point(3, 3) };
            // class자체를 배열로 설정할때 각 배열마다 new 선언 해줘야함

            foreach(Point pt in arr_p)
            {
                pt.Print();
            }
        }
    }
}
