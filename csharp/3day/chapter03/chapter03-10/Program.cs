namespace ConsoleApp1;

class Program
{
    static void Main(string[] args)
    {
        ConsoleKeyInfo keyInfo = Console.ReadKey(); // 사용자의 키보드 입력을 받은 문자를 처리
        Console.WriteLine(); // 줄바꿈
        // 입력받은 문자 출력
        Console.WriteLine(keyInfo.KeyChar);  // 사용자 키보드 입력한 거 출력

        // 제어문
        // switch문법
        /*
         * switch(인스턴스)    인스턴스: 변수이름 
         * {
         *     case 상수식1:
         *         구문1;
         *         break;
         *     case 상수식2:
         *         구문2;
         *         break;
         *         .
         *         .
         *         .
         *     default:    // 생략이 가능
         *         구문n;
         *         break;
         * }
         * 
         */

        char ch = 'F';      // Female
        switch (ch)
        {
            case 'M':
            case '남':
            case 'm':
                Console.WriteLine("남성");
                break;
            case 'F':
                Console.WriteLine("여성");
                break;
            default:
                Console.WriteLine("알 수 없음");
                break;
        }
        if (ch == 'M')
            Console.WriteLine("남성");
        else if(ch == 'F')
            Console.WriteLine("여성");
        else 
            Console.WriteLine("알 수 없음");

        // ----------------------------------------------------------------------------
        string text = "C#";
        switch (text)
        {
            case "C#":
            case "VB.NET":
                Console.WriteLine(".NET 호환 언어");
                break;

            case "Java":
                Console.WriteLine("JVM 언어");
                break;

            default:
                Console.WriteLine("알 수 없음");
                break;
        }
    }
}
