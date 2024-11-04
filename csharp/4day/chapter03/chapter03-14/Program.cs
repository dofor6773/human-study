namespace ConsoleApp1;

class Program
{
    static void Main(string[] args)
    {
        // 반복문(while, for) -> 프로그램의 꽃
        // while문 문법
        //   while (조건식)
        //     구문;
        //   
        //   while (조건식) 구문;
        // 
        //  cf) if문과 마찬가지로 1개 이상의 구문을 실행하려면 중괄호({})를 사용 

        // 1 ~ 1000까지 합한 값
        int sum = 0;
        int n = 1;      // 시작값

        while (n <= 1000)
        {
            sum += n;   // sum = sum + n;

            //Console.WriteLine(n + " : " + sum);
            Console.WriteLine($"{n} : {sum}");

            n++;
        }
        Console.WriteLine(sum);  // 500500

        Console.WriteLine("------------------------------------------------------------------");
        // 1 ~ 1000까지 짝수만 합한 값
        sum = 0;
        n = 1;      // 시작값

        while (n <= 1000)
        {
            if (n % 2 == 0)
            {     // 짝수이면
                sum += n;
                Console.WriteLine(n + " : " + sum);
            }
            

            n++;
        }
        Console.WriteLine(sum);  // 250500

        Console.WriteLine("------------------------------------------------------------------");
        // do ~ while문 (do문이 1번은 실행되는 while문)
        //   do {
        //       구문1;
        //       구문2;
        //   } while(조건식); 
        //
        sum = 0;
        n = 0;

        do
        {
            if (n % 2 == 0)
                sum += n;

        } while (++n <= 1000);
    }
}
