namespace study
{
    class Program
    {
        static void Main(string[] args)
        {
            // +    더하기     양변을 더합니다
            // -    빼기       좌면에서 우변을 뺍니다
            // *    곱하기     양변을 곱합니다
            // /    나누기     좌변을 우변으로 나눈 몫
            // %    나머지     좌변을 우변으로 나눈 나머지
            // ++   증가       피연산자를 1만큼 증가 
            // --   감소       피연산자를 1만큼 감소

            // +, -, *, /, %
            int a = 10;
            int a1 = 10;
            int a2 = 10;
            int a3 = 10;
            int b = 3;


            Console.WriteLine(a + b);   // 13
            Console.WriteLine(a - b);   // 7
            Console.WriteLine(a * b);   // 30
            Console.WriteLine(a / b);   // 3
            Console.WriteLine(a % b);   // 1

            Console.WriteLine("-------");

            // ++, --
            int c = a++;
            int c1 = ++a1;
            int d = a2--;
            int d1 = --a3;

            Console.WriteLine(a);   // 11
            Console.WriteLine(c);   // 10

            Console.WriteLine(a1);   // 11
            Console.WriteLine(c1);  // 11

            Console.WriteLine(a2);   // 9
            Console.WriteLine(d);   // 10

            Console.WriteLine(a3);   // 9
            Console.WriteLine(d1);  // 9
        }
    }
}
