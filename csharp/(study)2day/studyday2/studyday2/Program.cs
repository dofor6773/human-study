namespace study
{
    class Program
    {
        static void Main(string[] args)
        {
            // 정수 자료형
            sbyte sbyteNum;     // -128 ~ 127 부호 있는 8비트
            byte byteNum;       // 0 ~ 255 부호 없는 8비트

            short shortNum;     // -32,786 ~ 32,767 부호 있는 16비트
            ushort ushortNum;   // 0~ 65,535 부호 없는 16비트

            int intNum;         // -2,147,483,648 ~ 21억 부호 있는 32비트
            uint uintNum;       // 0 ~ 42억 부호 없는 32비트      

            long longNum;       // 부호 있는 64비트
            ulong ulongNum;     // 부호 없는 64비트

            //ex
            short num1;                 // int형 변수 num 선언
            num1 = 300;                 // num에 123 저장
            Console.WriteLine(num1);    // num 출력

            uint num2;
            num2 = 300000000;

            Console.WriteLine(num2);
        }
    }
}