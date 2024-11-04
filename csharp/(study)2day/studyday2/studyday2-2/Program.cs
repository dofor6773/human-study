namespace study
{
    class Program
    {
        static void Main(string[] args)
        {
            // 문자 자료형
            //(char)
            char ch = 'a';
            Console.WriteLine(ch);

            //(string)
            string str = "Hello, World!";
            Console.WriteLine(str);


            // 이스케이프 문자
            // \' == '
            // \" == "
            // \\ = \(백슬래시)
            // \n == enter
            // \t == tap
            // \b = Backspace

            //(\' & \" & \\)
            string str1 = "\"안녕하세요\" 라고 말헀습니다. ";
            string str2 = "\'안녕하세요\' 라고 말했습니다. ";
            string str3 = "이것은 \"\\\" 백슬래시 입니다. ";
            Console.WriteLine(str1);
            Console.WriteLine(str2);
            Console.WriteLine(str3);

            //(\n & \t & \b)
            string str4 = "안\b녕\b하세요 \n라고 말했\t습니다. ";
            Console.WriteLine(str4);
        }
    }
}
