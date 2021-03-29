using System;
using System.Collections.Generic;
using System.Linq;

namespace IntroducaoBootcampAspNetCore
{
    class Program
    {
        static void Main(string[] args)
        {

            //TiposDeDados();
            //ElseIf();
            //SwitchCase();
            //For();
            //While();
            Lists();
        }

        public static void Lists()
        {
            var notasTurmas = new List<int> { 10, 5, 2, 3, 10, 4, 3, 2, 9, 10, 6, 7, 10, 2, 3, 4, 5, 7 };

            var anyNota1 = notasTurmas.Any(n => n == 1);
            var firstNota10 = notasTurmas.First(n => n == 10);
            var singleNota9 = notasTurmas.Single(n => n == 9);
            var orderedNotas = notasTurmas.OrderBy(n => n);
            var max = notasTurmas.Max();
            var min = notasTurmas.Min();
            var sum = notasTurmas.Sum();
            var mediaNotas = notasTurmas.Average();

            foreach (var nota in notasTurmas)
            {
                Console.WriteLine(nota);
            }
        }

        public static void While()
        {
            var valores = Console.ReadLine(); // "1 2 3 4 5"
            var valoresArray = valores.Split(" "); // [ "1", "2", "3", "4", "5"]  

            var contador = 0;

            while (contador < valoresArray.Length)
            {
                Console.Write(valoresArray[contador] + " ");

                contador++;
            }

        }

        public static void For()
        {
            var valores = Console.ReadLine(); // "1 2 3 4 5"
            var valoresArray = valores.Split(" "); // [ "1", "2", "3", "4", "5"]  

            for (var i = 0; i < valoresArray.Length; i++)
            {
                Console.Write(valoresArray[i] + " ");
            }
        }

        public static void SwitchCase()
        {
            Console.WriteLine("Digite uma opção entre 1 e 3: ");
            var opcao = Console.ReadLine();
            switch (opcao)
            {
                case "1":
                    Console.WriteLine("Opção 1 selecionada");
                    break;
                case "2":
                    Console.WriteLine("Opção 2 selecionada");
                    break;
                case "3":
                    Console.WriteLine("Opção 3 selecionada");
                    break;
                default:
                    Console.WriteLine("Opção inválida");
                    break;
            }
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
