namespace ConsoleApp1;

class Program
{
    static void Main(string[] args)
    {
        ConsoleKeyInfo keyInfo = Console.ReadKey(); // 사용자의 키보드 입력을 받은 문자를 처리
        Console.WriteLine(); // 줄바꿈
        // 입력받은 문자 출력
        Console.WriteLine("입력한 값: " + keyInfo.KeyChar);  // 사용자 키보드 입력한 거 출력

        switch (keyInfo.KeyChar)
        {
            case 'M':
            case 'm':
            case '남':
                Console.WriteLine("남성");
                break;
            case 'F':
            case 'f':
            case '여':
                Console.WriteLine("여성");
                break;
            default:
                Console.WriteLine("알 수 없음");
                break;
        }
    }
}
