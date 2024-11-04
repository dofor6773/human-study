namespace study
{
    class Program
    {
        static void Main(string[] args)
        {
            // 기호   이름          반환 자료형
            // ==     같음              bool
            // !=     같지 않음         bool
            // <      작다              bool
            // <=     작거나 같음       bool
            // >      크다              bool
            // >=     크거나 같음       bool

            int a = 10;
            int b = 20;

            Console.WriteLine(a == b);
            Console.WriteLine(a != b);
            Console.WriteLine(a < b);
            Console.WriteLine(a <= b);
            Console.WriteLine(a > b);
            Console.WriteLine(a >= b);

            string str1 = "hello";
            string str2 = "world";

            Console.WriteLine(str1 == str2);
            Console.WriteLine(str2 != str1);
        }
    }
}
