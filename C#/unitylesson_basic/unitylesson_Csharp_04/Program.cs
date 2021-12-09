using System;

namespace unitylesson_Csharp_04
{
    class Program
    {
        static bool doPrintHelloWorld = true;
        static bool doPrintHelloWorld = true;
        static void Main(string[] args)
        {
            // 함수 호출시 함수이름(); 형태로 호출한다.
            if(doPrintHelloWorld == true)
            {
                PrintHelloWorld();
            }
            // parameter : 함수 호출시 입력변수
            string something = "Unity Hola !";
            if (doPrintHelloWorld == true)
            {
                PrintSomething(something);
            }
        }

        static void PrintHelloWorld()
        {
            Console.WriteLine("Hello World!");
        }

        static void PrintSomething(string )
        {
            Console.WriteLine("Hello World!");
        }


    }
}
