
namespace DesafioFundamentos.Desafio1
{
    class Exercicio3
    {
        public void Executar3()
        {
            Console.WriteLine("Digite o primeiro valor: ");

            double valor1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo valor");

            double valor2 = double.Parse(Console.ReadLine());

            var soma = valor1 + valor2;
            var subtracao = valor1 - valor2;
            var multiplicacao = valor1 * valor2;
            Console.WriteLine($"A soma entre os números {valor1} e {valor2} é igual a {soma}.");
            Console.WriteLine($"A subtração entre os números {valor1} e {valor2} é igual a {subtracao}.");
            Console.WriteLine($"A multiplicação entre os números {valor1} e {valor2} é igual a {multiplicacao}.");

            if (valor2 != 0)
            {
                var divisao = valor1 / valor2;
                Console.WriteLine($"A divisão entre os números {valor1} e {valor2} é igual a {divisao}.");


            }
            else
            {
                Console.WriteLine($"A divisão entre os números {valor1} e {valor2} não é possivel.");

            }
            var media = soma / 2;
            
            Console.WriteLine($"A média entre os números {valor1} e {valor2} é igual a {media}.");


        }
        



       
    }
}
