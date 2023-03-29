using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }

        static void Menu()
        {
            try
            {
                Console.Clear();
                Console.WriteLine("O que deseja fazer ?");
                Console.WriteLine("1 - Adição");
                Console.WriteLine("2 - Subtração");
                Console.WriteLine("3 - Divisão");
                Console.WriteLine("4 - Multiplicação");
                Console.WriteLine("5 - Sair");

                short opcao = short.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case 1: Soma(); break;
                    case 2: subtracao(); break;
                    case 3: Divisao(); break;
                    case 4: Multiplicacao(); break;
                    case 5:
                        Console.Clear();
                        Console.WriteLine("Obrigado !");
                        System.Environment.Exit(0); break;
                    default: Menu(); break;
                }
            }
            catch (System.Exception)
            {

                Menu();
            }
        }

        static void Soma()
        {
            Console.Clear();
            Console.Write("Primeiro Valor: ");
            float v1 = float.Parse(Console.ReadLine());

            Console.Clear();
            Console.Write("Segundo Valor: ");
            float v2 = float.Parse(Console.ReadLine());

            //float result = v1 + v2;

            Console.Clear();
            Console.WriteLine($"O Resultado da soma de {v1} e {v2} é {v1 + v2}");
            Console.WriteLine("Aperter ENTER para voltar ao Menu Iniciar !");
            Console.ReadKey();
            Menu();
        }

        static void subtracao()
        {
            Console.Clear();
            Console.Write("Primeiro Valor: ");
            float v1 = float.Parse(Console.ReadLine());

            Console.Clear();
            Console.Write("Segundo Valor: ");
            float v2 = float.Parse(Console.ReadLine());

            //float result = v1 + v2;

            Console.Clear();
            Console.WriteLine($"O Resultado da subtração de {v1} e {v2} é {v1 - v2}");
            Console.WriteLine("Aperter ENTER para voltar ao Menu Iniciar !");
            Console.ReadKey();
            Menu();
        }

        static void Divisao()
        {
            Console.Clear();
            Console.Write("Primeiro Valor: ");
            float v1 = float.Parse(Console.ReadLine());

            Console.Clear();
            Console.Write("Segundo Valor: ");
            float v2 = float.Parse(Console.ReadLine());



            Console.Clear();
            Console.WriteLine($"O Resultado da divisão de {v1} e {v2} é {v1 / v2}");
            Console.WriteLine("Aperter ENTER para voltar ao Menu Iniciar !");
            Console.ReadKey();
            Menu();
        }

        static void Multiplicacao()
        {
            Console.Clear();
            Console.Write("Primeiro Valor: ");
            float v1 = float.Parse(Console.ReadLine());

            Console.Clear();
            Console.Write("Segundo Valor: ");
            float v2 = float.Parse(Console.ReadLine());

            //float result = v1 + v2;

            Console.Clear();
            Console.WriteLine($"O Resultado da multiplicação de {v1} e {v2} é {v1 * v2}");
            Console.WriteLine("Aperter ENTER para voltar ao Menu Iniciar !");
            Console.ReadKey();
            Menu();
        }
    }
}