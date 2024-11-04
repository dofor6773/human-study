using System.Diagnostics;

namespace ConsoleApp1;

class Program
{
    // 문제: 숫자 키 입력 받아 요일 출력
    //    Q.사용자로부터 1에서 7 사이의 숫자를 Console.ReadKey() 로 입력받아 해당 숫자에 맞는 요일을 출력하는 switch문을 작성하세요.
    // 1: "월요일"
    // 2: "화요일"
    // 3: "수요일"
    // 4: "목요일"
    // 5: "금요일"
    // 6: "토요일"
    // 7: "일요일"
    //그 외의 숫자가 입력되면 "잘못된 입력"을 출력하세요.
    static void Main(string[] args)
    {
        ConsoleKeyInfo keyInfo = Console.ReadKey(); // 사용자의 키보드 입력을 받은 문자를 처리
        Console.WriteLine(); // 줄바꿈
        // 입력받은 문자 출력
        Console.WriteLine("입력한 값: " + keyInfo.KeyChar);  // 사용자 키보드 입력한 거 출력

        // 문자
        switch(keyInfo.KeyChar)
        {
            case '1': Console.WriteLine("월요일"); break;
            case '2': Console.WriteLine("화요일"); break;
            case '3': Console.WriteLine("수요일"); break;
            case '4': Console.WriteLine("목요일"); break;
            case '5': Console.WriteLine("금요일"); break;
            case '6': Console.WriteLine("토요일"); break;
            case '7': Console.WriteLine("일요일"); break;
            default: Console.WriteLine("잘못된 입력"); break;
        }
        // 문자 -> 숫자
        int keyDigit = int.Parse(keyInfo.KeyChar.ToString());
        switch(keyDigit)
        {
            case 1: Console.WriteLine("월요일"); break;
            case 2: Console.WriteLine("화요일"); break;
            case 3: Console.WriteLine("수요일"); break;
            case 4: Console.WriteLine("목요일"); break;
            case 5: Console.WriteLine("금요일"); break;
            case 6: Console.WriteLine("토요일"); break;
            case 7: Console.WriteLine("일요일"); break;
            default: Console.WriteLine("잘못된 입력"); break;
        }
        // 숫자 -> 문자 혹은 문자열
        string keyStr1 = keyDigit.ToString();   // 문자열
        Console.WriteLine("keyStr1: " + keyStr1);
        char keyChar1 = keyDigit.ToString()[0]; // 문자
        Console.WriteLine("keyChar1: " + keyChar1);

        switch (keyStr1)
        {
            case "1": Console.WriteLine("월요일"); break;
            case "2": Console.WriteLine("화요일"); break;
            case "3": Console.WriteLine("수요일"); break;
            case "4": Console.WriteLine("목요일"); break;
            case "5": Console.WriteLine("금요일"); break;
            case "6": Console.WriteLine("토요일"); break;
            case "7": Console.WriteLine("일요일"); break;
            default: Console.WriteLine("잘못된 입력"); break;
        }

    }
}
