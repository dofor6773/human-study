namespace ConsoleApp1;

class Program
{
    static void Main(string[] args)
    {
        // 제어문(Control Statement)
        // 0. 관계 및 논리연산자
        //   - 관계연산자: >(크다), >=(크거나 같다), <=(작거나 같다), <(작다), ==(같다), !=(다르다)
        bool result1 = (10 > 20);
        Console.WriteLine(result1);  // false
        bool result2 = (10 < 20);
        Console.WriteLine(result2);  // true

        int value1 = 6;
        int n1 = value1 % 3; // n1은 0
        bool result3 = (n1 == 0);    // true
        Console.WriteLine(result3);  // true

        //  - 논리연산자: &&(AND), ||(OR), !(NOT)
        // ex) A AND(&&) B: AND연산자는 A와 B의 논리값이 하나라도 false이면 결과는 false
        // ex) A OR(||) B: OR연산자는 A와 B의 논리값이 하나라도 true이면 결과는 true
        int value2 = 10;
        int n3 = value2 % 3;   // 1
        int n4 = value2 % 5;   // 0

        bool orResult1 = (n3 == 0 || n4 == 0);   // false || true -> true
        Console.WriteLine("value는 3의 배수이거나 5의 배수이면 " + orResult1);

        bool andResult1 = (n3 == 0 && n4 == 0);  // false && true -> false
        Console.WriteLine("value는 3의 배수이고 5의 배수이면 " + andResult1);

        bool notResult1 = !(n3 == 0);  // !false -> true
        Console.WriteLine("value는 3의 배수가 아님: " + notResult1);

        int n11 = 6;
        int n12 = 10;
        bool result11 = (n11 % 3 == 0 || n12 % 3 == 0); // 6은 3의 배수이거나 10이 3의 배수이면 true
        Console.WriteLine("n11 또는(OR) n12는 3의 배수: " + result11);  // True
        bool result12 = (n11 % 3 == 0 && n12 % 3 == 0); // 6은 3의 배수이고 10이 3의 배수이면 false
        Console.WriteLine("n11값이 3의 배수이고(AND) n12는 3의 배수: " + result12);  // False

        // 문제1. 다음 조건을 만족하는 논리 연산을 사용하여 맞으면 'true' 출력 틀리면 'false' 출력
        //   조건: 변수 age가 70 이상이고 hasLicense가 true일 경우 'true' 틀리면 'false' 출력
        int age = 40;
        bool hasLicese = true;
        Console.WriteLine(age >= 70 && hasLicese);

        // 문제2: 아래 변수 isWeekend와 isHoliday 중 하나라도 true일 경우 true를 출력 아니면 false를 출력
        bool isWeekend = false;
        bool isHoliday = true;
        Console.WriteLine(isWeekend || isHoliday);

        // 문제3: 아래 변수를 사용하여 조건을 만족할 때 true 아니면 false 출력
        // temperature 20이상 30이하
        // isRainy(비가 올 경우)일 경우
        int temperature = 25;
        bool isRainy = false;
        Console.WriteLine(temperature >= 20 && temperature <= 30 && isRainy);
    }
}


