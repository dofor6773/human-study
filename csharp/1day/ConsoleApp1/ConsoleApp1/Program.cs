namespace ConsoleApp1;
class Program
{
    static void Main(string[] args)    // 함수(실행(entry-execution) 함수)
    {
        // 코드를 넣어 실습...
        // Console.WriteLine("Hello, World!");
        Console.WriteLine("안녕하세요~");
        Console.WriteLine("안녕하세요2~");
        Console.WriteLine("안녕하세요3~");

        string str1 = "aa";
        String str2 = "bb";

        Console.ReadKey();  // 화면 꺼지지 않게 하기

        int value1 = Convert.ToInt32("10");
        int value2 = Int32.Parse("10");

        string var6 = """
            abc
            def
            """;

        Random rand = new Random();
        rand.Next();

        int[][] a1;
    }
}

// See https://aka.ms/new-console-template for more information   한줄 주석
// Console.WriteLine("Hello, World!");  // 콘솔에 Hello, World! 출력
// Console.WriteLine("Hello, World2!"); // 콘솔에 Hello, World2! 출력
// ilasm 프로그램
