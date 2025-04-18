
using System.Linq;
using System.Security;

namespace DesafioFundamentos.Desafio1
{
    class Exercicio5
    {
        public void Executar5()
        {
            string placaVeiculo;
            Console.WriteLine("Digite a placa do seu veículo:");
            placaVeiculo = Console.ReadLine().ToUpper();
            var contagemObjestos = placaVeiculo.ToString().Length;
            if (contagemObjestos != 7) 
            {
                Console.WriteLine("Placa inválida!");
                return;
            }

            List<char> alfabeto = new List<char>("ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray());

            char primeiraLetra = char.ToUpper(placaVeiculo[0]);
            char segundaLetra = char.ToUpper(placaVeiculo[1]);
            char terceiraLetra = char.ToUpper(placaVeiculo[2]);





            if (!alfabeto.Contains(primeiraLetra) || !alfabeto.Contains(segundaLetra) || !alfabeto.Contains(terceiraLetra))
            {
                Console.WriteLine("Placa inválida!");
                return;
            }
            else
            {
                Console.WriteLine("Placa válida!");
                return;
            }
            
        }
    }
    
}
