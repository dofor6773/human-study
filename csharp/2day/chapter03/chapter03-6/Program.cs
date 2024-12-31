namespace ConsoleApp1;

class Program
{
    static void Main(string[] args)
    {
        string productName1 = "테이크이지";
        string productName2 = "시티브리즈 우먼";
        string productName3 = "필루미네트";

        int productPrice1 = 5000;
        int productPrice2 = 5500;
        int productPrice3 = 6000;
        int productPrice4 = 10000;

        // 배열(array)
        int[] productPrices = new int[10000];
        string[] productNames = new string[4];

        // 배열 start number는 0부터
        productPrices[0] = 5000;
        productPrices[1] = 5500;
        productPrices[2] = 6000;
        productPrices[3] = 10000;
        //productPrices[4] = 12000;       // runtime 에러(실행중에 에러가 발생) -> 0~3번까지만 허용
        productPrices[5] = 13000;       // runtime 에러(실행중에 에러가 발생) -> 0~3번까지만 허용

        //productPrice;  // 빌드(build) 에러

        int i = 0;
        productPrices[i] = 5200;
        //productPricei = 5200;

        Console.WriteLine(productPrices[0]);     // 5200

        int book = productPrices[1] + productPrices[2];   // 5500 + 6000 = 11500
        Console.WriteLine(book);     // 11500

        // 배열 선언 및 초기화
        int[] products = new int[5] { 1, 2, 3, 4, 5 };
        int[] products2 = { 1, 2, 3, 4, 5 };

        Console.WriteLine(products[0]);     // 1
        Console.WriteLine(products[1]);     // 2
        Console.WriteLine(products2[0]);    // 1

        // 문자열에 대한 배열
        string text = "Hello World";
        char ch1 = text[0];     // H
        char ch2 = text[1];     // e
        char ch11 = text[10];   // d
        //char ch12 = text[11];   // error -> text변수 문자열 11개까지(0~10)만 저장이 되어 있음

        Console.WriteLine(ch1);
        Console.WriteLine(ch2);
        Console.WriteLine(ch11);

        // 배열의 기본값(int, float의 경우 0, string은 null)
        int[] students = new int[60];
        Console.WriteLine(students[0]);  // 출력 결과: 0
        float[] sosu = new float[60];
        Console.WriteLine(sosu[0]);      // 출력 결과: 0

        // 다차원배열
        int[,] arr2 = new int[60,60];   // 60 * 60 int공간을 가진 2차원 배열
        int[,,] arr3 = new int[60, 60, 60];   // 60 * 60 * 60 int공간을 가진 3차원 배열

        int[,] arr4 = new int[7, 3]
        {
            {1, 2, 3}, 
            {4, 5, 6},
            {4, 5, 6},
            {4, 5, 6},
            {4, 5, 6},
            {4, 5, 6},
            {4, 5, 6},
        };
        Console.WriteLine(arr4[0, 1]);   // 출력 결과 2
        Console.WriteLine(arr4[1, 0]);   // 출력 결과 4
        Console.WriteLine(arr4[2, 1]);   // 출력 결과 5

        // 가변 배열(배열의 배열)
        int[][] arr5 = new int[5][];     // 5개의 열을 가진 가변 배열
        arr5[0] = new int[10];      // 0번째 index의 10개의 열을 가진 배열
        arr5[1] = new int[9];      // 1번째 index의 9개의 열을 가진 배열

        // 문제1: 아래 코드 arr6의 평균값을 출력하는 코드를 작성해 보시오.(소수점까지 표시)
        int[] arr6 = { 1, 2, 3, 4, 5, 6 };
        Console.WriteLine((arr6[0] + arr6[1] + arr6[2] + arr6[3] + arr6[4] + arr6[5]) / (double) arr6.Length);
    }
}
