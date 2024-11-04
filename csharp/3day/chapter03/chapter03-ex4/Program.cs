using System.Diagnostics;

namespace ConsoleApp1;

class Program
{
    static void Main(string[] args)
    {
        // 문제 4: 모음 / 자음 판별
        // Q.사용자로부터 알파벳 문자를 입력받아 해당 문자가 모음(a, e, i, o, u)인지 자음인지 판별하는 프로그램을 작성
        // 대소문자 구분 없이 처리하고 Console.ReadKey()를 사용하세요.
        //   - 모음이면 '모음입니다' 출력
        //   - 자음이면 '자음입니다' 출력
        //   - 그 이외의 값은 '잘못된 입력입니다. 알파벳 문자를 입력하세요.' 출력

        Console.Write("알파벳 문자를 입력하세요: ");
        ConsoleKeyInfo charKey = Console.ReadKey();
        Console.WriteLine();  // 줄바꿈

        // 코드 작성
        char letter = charKey.KeyChar;
        switch (letter)
        {
            case 'a': case 'A':
            case 'e': case 'E':
            case 'i': case 'I':
            case 'o': case 'O':
            case 'u': case 'U':
                Console.WriteLine("모음입니다");
                break;
            default:
                //if ((letter >= 'a' && letter <= 'z') || (letter >= 'A' && letter <= 'Z'))
                if (char.IsLetter(letter))
                    Console.WriteLine("자음입니다");
                else
                    Console.WriteLine("잘못된 입력입니다. 알파벳 문자를 입력하세요.");
                break;
        }

    }
}
