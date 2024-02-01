using System;
using static System.Console;

namespace Hello
{
    class MainApp
    {
        static void Main(string[] args)
        {
            // 프로그램 실행이 시작되는 곳
            if (args.Length == 0) // .은 ~의 로 해석하는게 이해하기 편함.
            {
                Console.WriteLine("사용법 : Hello.exe <이름>");
                return;
            }

            WriteLine("Hello, {0}", args[0]); // Hello, World를 프롬프트에 출력
        }
    }
}
