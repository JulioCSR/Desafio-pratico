
namespace DesafioFundamentos.Desafio1
{
    class Exercicio4
    {
        public void Executar4()
        {
            Console.WriteLine("Digite uma ou mais letras: ");
            var letras = Convert.ToString(Console.ReadLine());
            var contagem = letras.Length;

            Console.WriteLine($"A quantidade de caracteres é igual a: {contagem}");

            
        }
    }
}
