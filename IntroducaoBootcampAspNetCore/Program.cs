using System;

namespace IntroducaoBootcampAspNetCore
{
    class Program
    {
        static void Main(string[] args)
        {
            var umaString = "essa é uma string";
            var numeroInt = 5;
            var numeroFloat = 5.4f;
            var numeroDouble = 5.4;
            var numeroDecimal = 5.3m;
            var array = new int[3] { 1, 2, 3 };
            var caractere = 'a';
            var data = new DateTime(2000, 11, 11);
            var boolean = true;

            Console.WriteLine($"{umaString}");
            Console.WriteLine($"{numeroInt}");
            Console.WriteLine($"{numeroFloat}");
            Console.WriteLine($"{numeroDouble}");
            Console.WriteLine($"{numeroDecimal}");
            Console.WriteLine($"{array}");
            Console.WriteLine($"{caractere}");
            Console.WriteLine($"{data}");
            Console.WriteLine($"{boolean}");

        }
    }
}
