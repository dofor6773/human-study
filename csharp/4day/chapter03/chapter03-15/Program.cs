namespace ConsoleApp1;

class Program
{
    static void Main(string[] args)
    {
        // break문: 블록 내의 1개의 while문만 빠져나감
        int i = 2;
        while (true)
        {
            int j = 1;

            while (true)
            {
                Console.WriteLine(i + " * " + j + " = " + (i * j));

                if (++j > 9)
                {
                    break;
                }
            }

            if (++i > 9)
            {
                break;
            }
        }

        // continue문: 블록 내의 1개의 while의 조건문으로 이동
        int sum = 0;
        int n = 1;

        while (n++ <= 1000)
        {
            Console.WriteLine($"n은 {n}");
            if (n % 2 != 0) // n이 홀수이면
            {
                continue;
            }

            sum += n;   // 짝수만 더해서 합한 값
        }

        // 1 ~ 1000까지 사이 수 중에서 2의 배수이고 3의 배수이고 5의 배수만 합산하는 프로그램
        while (n++ <= 1000)
        {
            // 첫번째 방법
            if (((n % 2) == 0) && ((n % 3) == 0) && ((n % 5) == 0)) sum += n;
            // 두번째 방법
            if ((n % 2) == 0)
            {
                if ((n % 3) == 0)
                {
                    if ((n % 5) == 0)
                    {
                        sum += n;


                    }
                }
            }
            // 세번째 방법
            if ((n % 2) != 0) continue;
            if ((n % 3) != 0) continue;
            if ((n % 5) != 0) continue;
            sum += n;

            Console.WriteLine("2의 배수이고 3의 배수이고 5의 배수인 수: " + n);
        }
    }
}
