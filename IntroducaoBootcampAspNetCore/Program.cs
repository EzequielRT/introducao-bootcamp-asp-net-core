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
            //Lists();
            ProgramacaoOrientadaAObjetos();
        }

        #region ProgramacaoOrientadaAObjetos
        public class Veiculo
        {
            public string Modelo { get; set; }
            public string Marca { get; set; }
            public int Ano { get; set; }
            public decimal Valor { get; set; }
            public string Placa { get; protected set; }

            public virtual void MostrarRequisitosParaDirigir()
            {
                Console.WriteLine("Uma carteira de motorista.");
            }

        }

        public class Onibus : Veiculo
        {
            public string LinhaDoOnibus { get; set; }

            public override void MostrarRequisitosParaDirigir()
            { 
                Placa = "";
                Console.WriteLine("Habilitação D.");
            }
        }

        public class Moto : Veiculo
        {
            public string PropriedadeUnicaDeMoto { get; set; }

            public override void MostrarRequisitosParaDirigir()
            {
                Console.WriteLine("Habilitação A.");
            }
        }

        public class Carro : Veiculo
        {
            public override void MostrarRequisitosParaDirigir()
            {
                Placa = "";
                Console.WriteLine("Habilitação B.");
            }
        }

        public static void ProgramacaoOrientadaAObjetos()
        {
            var listaVeiculos = new List<Veiculo>();
            listaVeiculos.Add(new Onibus());
            listaVeiculos.Add(new Moto());
            listaVeiculos.Add(new Carro());

            foreach (var veiculo in listaVeiculos)
            {
                veiculo.MostrarRequisitosParaDirigir();
            }

            Console.WriteLine("---------- DevCars - Venda de Carros ----------");

            ExibirMensagemPrincipal();

            var opcao = Console.ReadLine();

            while (opcao != "0")
            {
                switch (opcao)
                {
                    case "1":
                        var veiculo = CadastrarVeiculo();
                        listaVeiculos.Add(veiculo);
                        break;
                    case "2":
                        ListarVeiculos(listaVeiculos);
                        break;
                    case "3":
                        ComprarVeiculo(listaVeiculos);
                        break;
                    default:
                        break;
                }

                ExibirMensagemPrincipal();
                opcao = Console.ReadLine();
            }
        }

        public static void ExibirMensagemPrincipal()
        {
            Console.WriteLine("Digite sua opção: ");
            Console.WriteLine("1 - Cadastro");
            Console.WriteLine("2 - Listagem");
            Console.WriteLine("3 - Compra");
            Console.WriteLine("0 - Sair");
        }

        public static Veiculo CadastrarVeiculo()
        {
            var veiculo = new Veiculo();

            Console.WriteLine("Digite a Marca: ");
            veiculo.Marca = Console.ReadLine();

            Console.WriteLine("Digite o Modelo: ");
            veiculo.Modelo = Console.ReadLine();

            Console.WriteLine("Digite o Ano: ");
            veiculo.Ano = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o Valor: ");
            veiculo.Valor = decimal.Parse(Console.ReadLine());

            return veiculo;
        }

        public static void ListarVeiculos(List<Veiculo> veiculos)
        {            
            for (var i = 0; i < veiculos.Count; i++)
            {
                Console.WriteLine($"{i} - Marca: {veiculos[i].Marca}, Modelo: {veiculos[i].Modelo}, Ano: {veiculos[i].Ano}, Valor: R${veiculos[i].Valor}");
            }
        }

        public static void ComprarVeiculo(List<Veiculo> veiculos)
        {
            ListarVeiculos(veiculos);

            Console.WriteLine("Escolha uma opção de Veiculo: ");

            var opcao = int.Parse(Console.ReadLine());

            var veiculo = veiculos[opcao];

            veiculos.Remove(veiculo);
        }

        #endregion

        #region Lists
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

        #endregion

        #region While
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

        #endregion

        #region For
        public static void For()
        {
            var valores = Console.ReadLine(); // "1 2 3 4 5"
            var valoresArray = valores.Split(" "); // [ "1", "2", "3", "4", "5"]  

            for (var i = 0; i < valoresArray.Length; i++)
            {
                Console.Write(valoresArray[i] + " ");
            }
        }

        #endregion

        #region SwitchCase
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

        #endregion

        #region ElseIf
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

        #endregion

        #region TiposDeDados
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

        #endregion
    }
}
