using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSHARP_BASIC
{
    class Program
    {
        // C언어는 아스키코드, C샵은 유니코드를 사용한다.
        struct Monster
        {
            public int hp;
        }
        class Hero
        {
            public int hp;
            /*public Hero() // 생성자 개념
              {
                hp= 100;
              }
            */ // hero.hp = 100 선언하지않아도 자동으로  hp = 100을 할당시켜준다. HEAP 영역에
        }
        // 구조체와 클래스의 차이점은 구조체는 바로 int hp의 메모리영역을 설정해주지만
        // 클래스는 int hp를 바로 선언해주지않는다 C의 포인터를 이용한 구조체 개념이다.
        static void Main(string[] args)
        {
            Monster mon;
            mon.hp = 100;// 구조체는 바로 설정이 가능 (영역이 잡혀있기때문에)
            Hero hero = new Hero(); // 클래스는 새로 설정을 해줘야 영역이 잡힌다.
            hero.hp = 100;
            object obj; // 모든 자료형을 대입해서 사용할 수 있다.
            int num = 10;
            float pi = 3.14f;
            obj = num;
            obj = pi;
            obj = 1234;
            num = (int)obj;// obj의 값을 num에 넣고싶으면 num의 자료형인 int를 옆에 붙여줘야 한다.


        }
    }
}
