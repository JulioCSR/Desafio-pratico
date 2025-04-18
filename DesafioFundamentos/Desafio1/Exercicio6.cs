
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Security.Cryptography;

namespace DesafioFundamentos.Desafio1
{
    class Exercicio6
    {
        //Crie um programa que solicita ao usuário a exibição da data atual em diferentes formatos:
        //- Formato completo(dia da semana, dia do mês, mês, ano, hora, minutos, segundos).
        //- Apenas a data no formato "01/03/2024".
        //- Apenas a hora no formato de 24 horas.
        //- A data com o mês por extenso.
        public void Executar6()
        {
            DateTime dataAtual = DateTime.Now;
            Console.WriteLine("Escola o formato da data atual: ");
            Console.WriteLine("1 - Completo");
            Console.WriteLine("2 - Apenas a data no formato 01/03/2024");
            Console.WriteLine("3 - A data com o mês por extenso");

            var opcao = int.Parse(Console.ReadLine());
            switch (opcao)
            {
                case 1:
                    Console.WriteLine(dataAtual.ToString("dddd, dd/MM/yyyy HH:mm:ss"));
                    break;
                case 2:
                    Console.WriteLine(dataAtual.ToString("dd/MM/yyyy"));
                    break;
                case 3:
                    Console.WriteLine(dataAtual.ToString("dd/MMMM/yyyy"));
                    break;
                default:
                    Console.WriteLine("Escolha uma opção Valida!");
                    break;
            }      

        }
    }
}
