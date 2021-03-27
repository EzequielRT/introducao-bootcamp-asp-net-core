using System;

namespace IntroducaoBootcampAspNetCore
{
    class Program
    {
        static void Main(string[] args)
        {

            //TiposDeDados();
            ElseIf();
        }        

        public static void ElseIf()
        {
            Console.WriteLine("Digite uma opção entre 1 e 3: ");
            var opcao = Console.ReadLine();

            if (opcao == "1")
            {
                Console.WriteLine("Opção 1 selecionada");
            } 
            else if (opcao == "2")
            {
                Console.WriteLine("Opção 2 selecionada");
            }
            else if (opcao == "3")
            {
                Console.WriteLine("Opção 2 selecionada");
            }
            else
            {
                Console.WriteLine("Opção inválida");
            }
        }

        public static void TiposDeDados()
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
