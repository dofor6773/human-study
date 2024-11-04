namespace study
{ 
    class Program
    {
        static void Main(string[] args)
        {
            // 콘솔 입출력
            //(Console.Wirte)
            Console.Write("Hello, ");
            Console.Write("World!");

            //(Console.WirteLine)
            Console.WriteLine("Hello, world!");
            Console.WriteLine("Hello, world!");

            Console.Write("안녕하세요");
            Console.Write("저는 C#을 배우고 있습니다.");
            Console.WriteLine("WriteLine 함수입니다.");
            Console.WriteLine("마지막에 엔터가 있습니다");

            //(Console.ReadLine)
            string input;
            input = Console.ReadLine();
            Console.WriteLine("입력받은 문자열: " + input);
        }
    }
}
