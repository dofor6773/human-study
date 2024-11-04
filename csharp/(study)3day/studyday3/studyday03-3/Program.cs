namespace study
{
    class Program
    {
        static void Main(string[] args)
        {
            bool t = true;
            bool f = false;

            // AND 연산자
            // true and true == true
            // true and false == false
            // false and true == false
            // false and false == false

            Console.WriteLine(t && t);
            Console.WriteLine(t && f);
            Console.WriteLine(f && t);
            Console.WriteLine(f && f);

            // OR 연산자 ||
            // true or true == true
            // true or false == true
            // false or true == true
            // false or false == false

            Console.WriteLine(t || t);
            Console.WriteLine(t || f);
            Console.WriteLine(f || t);
            Console.WriteLine(f || f);

            // XOR 연산자 ^
            // true XOR true == false
            // true XOR false == true
            // false XOR true == true
            // false XOR false == false

            Console.WriteLine(t ^ t);
            Console.WriteLine(t ^ f);
            Console.WriteLine(f ^ t);
            Console.WriteLine(f ^ f);

            // NOT 연산자 !
            // true -> false
            // false -> true

            Console.WriteLine(!f);
            Console.WriteLine(!t);
        }
    }
}
