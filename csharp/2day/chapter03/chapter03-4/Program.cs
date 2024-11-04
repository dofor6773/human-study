// 형(type) 변환(conversion)
// 1. 암시적 형 변환
// 2. 명시적 형 변환
namespace ConsoleApp1;

class Program
{
    static void Main(string[] args)
    {
        byte b = 250;       // byte 데이터 범위 0 ~ 255
        short s = b;        // 암시적 형변환. short 데이터 범위 -32,000 ~ 32,000

        Console.WriteLine(s);

        short s1 = 25000;
        byte b1 = (byte)s1;     // 명시적 형변환(정수형끼리)

        Console.WriteLine(b1);

        ushort u = 65;    // 0 ~ 65,000
        // char 65는 A
        char c = (char)u;       // 0000 ~ ffff(65,000)(정수형 -> 문자형일 경우에는 명시적 형변환 허용)

        Console.WriteLine(c);  // A

        // 문제1
        byte byteValue = 10;
        char charValue = 'A';

        //컴파일 에러가 나오는 케이스
        //1. int intValue = byteValue;
        //2. int intValue = charValue;
        //3. short shortValue = charValue;
        //4. double doubleValue = byteValue;

        double doubleValue = (double)byteValue;
        //string str1 = charValue;  // 암시적 형변환 에러

        string str2 = "abc";
        //charValue = str1;         // 암시적 형변환 에러
    }
}
