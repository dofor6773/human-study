namespace ConsoleApp1;

class Program
{
    static void Main(string[] args)
    {
        // 제어문 중의 반복문인 for, foreach
        // for문 문법
        //   for(초기화; 조건식; 반복식) 
        //     구문;
        //
        //   중괄호 사용은 구문이 1개이상일 경우 사용
        //
        //   for(초기화; 조건식; 반복식) 구문;
        int n;
        for (n = 1; n <= 9; n++)        // 1 ~ 9까지 출력하는 코드
        {
            Console.WriteLine(n);
        }
        // 실행순서 
        //   1. n = 1    cf) 한번만 실행
        //   2. n <= 9 true이면
        //   3. Console.WriteLine(n);
        //   4. n++
        //   5. n <= 9 true이면
        //   6. Console.WriteLine(n);
        //   7. n++
        //   8. n <= 9 true이면
        //   9. Console.WriteLine(n);
        //      .
        //      .
        //   만약 false이면 for문을 나간다.

        for(int a = 1; a <= 9; a++)
        {
            Console.WriteLine(a); 
        }

        // for문의 초기화, 조건문, 반복식은 생략이 가능
        //    1. 초기화 생략  -> for( ; 조건문; 반복식)
        for(; n <= 9; n++)
        {
            Console.WriteLine(n);
        }
        //    2. 초기화와 조건문을 생략
        for(; ; n++)        // break문을 만날때까지 무한 반복
        {
            if (n > 9) break;       // n이 9이상이면 for문을 나간다.

            Console.WriteLine(n);
        }
        //    3. 초기화와 조건문과 반복식이 생략 -> // break문을 만날때까지 무한 반복
        for (;;)   // == while(true)
        {

        }
    
    }
}