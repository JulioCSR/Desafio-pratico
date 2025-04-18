// See https://aka.ms/new-console-template for more information
using DesafioFundamentos.Desafio1;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography.X509Certificates;

public class Program
{
    public static void Main(string[] args)
    {
        bool continuar = true;

        while (continuar)
            {
            Console.WriteLine("\nMenu Principal.");
            Console.WriteLine("Escolhar o exercicio para execução: ");
            Console.WriteLine("0 - Para encerrar o programa");
            Console.WriteLine("1 - Exercicio 1");
            Console.WriteLine("2 - Exercicio 2");
            Console.WriteLine("3 - Exercicio 3");
            Console.WriteLine("4 - Exercicio 4");
            Console.WriteLine("5 - Exercicio 5");
            Console.WriteLine("6 - Exercicio 6\n");

            var numeroEscolhido = int.Parse(Console.ReadLine());

            switch (numeroEscolhido)
            {
                case 1:
                    new Exercicio1().Executar1();
                    break;
                case 2:
                    new Exercicio2().Executar2();
                    break;
                case 3:
                    new Exercicio3().Executar3();
                    break;
                case 4:
                    new Exercicio4().Executar4();
                    break;
                case 5:
                    new Exercicio5().Executar5();
                    break;
                case 6:
                    new Exercicio6().Executar6();
                    break;
                case 0:
                    continuar = false;
                    break;
                default:
                    Console.WriteLine("Escolha uma opção Valida!");
                    break;

            }
            if (continuar)
            {
                Console.WriteLine("\nPressione qualquer tecla para voltar ao menu...");
                Console.ReadKey();
                Console.Clear();
            }

        }

        Console.WriteLine("Programa encerrado.");


    }
}
