using System.Diagnostics;

namespace ConsoleApp1;

class Program
{
    // 문제: 간단한 메뉴 선택
    //    Q.사용자에게 간단한 메뉴를 보여주고, Console.ReadKey()를 이용하여 메뉴를 선택하게 한 후 해당 동작을 수행하는 프로그램을 작성하세요.
    //메뉴:
    //  1. 프로그램 시작
    //  2. 설정 변경
    //  3. 프로그램 종료
    // 사용자가 숫자 키(1, 2, 3)를 누르면 각 동작에 맞는 메시지를 출력하세요.
    static void Main(string[] args)
    {
        Console.WriteLine("메뉴를 선택하세요:");
        Console.WriteLine("1: 프로그램 시작");
        Console.WriteLine("2: 설정 변경");
        Console.WriteLine("3: 프로그램 종료");

        ConsoleKeyInfo keyInfo = Console.ReadKey(); // 사용자의 키보드 입력을 받은 문자를 처리
        Console.WriteLine(); // 줄바꿈

        switch (keyInfo.KeyChar)
        {
            case '1':
                Console.WriteLine("프로그램을 시작합니다.");
                break;
            case '2':
                Console.WriteLine("설정을 변경합니다.");
                break;
            case '3':
                Console.WriteLine("프로그램을 종료합니다.");
                break;
            default:
                Console.WriteLine("잘못된 선택입니다.");
                break;
        }
    }
}
