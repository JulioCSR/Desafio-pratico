
namespace DesafioFundamentos.Desafio1
{
    class Exercicio2
    {
        public void Executar2()
        {
            Console.WriteLine("Digite o seu nome: ");
            var nome = Convert.ToString(Console.ReadLine());

            Console.WriteLine("Digite o seu sobrenome: ");
            var sobrenome = Convert.ToString(Console.ReadLine());
            
            Console.WriteLine($"Meu nome é, {nome} {sobrenome}.");
        }
    }
}
