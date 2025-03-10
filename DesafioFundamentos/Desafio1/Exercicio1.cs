using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioFundamentos.Desafio1
{
    class Exercicio1
    {
        public void Executar1()
        {
            Console.WriteLine("Digite o seu nome: ");
            var nome = Convert.ToString(Console.ReadLine());

            Console.WriteLine("Digite um mensagem de boas vindas: ");
            var mensagem = Convert.ToString(Console.ReadLine());           
            

            Console.WriteLine($"Olá, {nome}! {mensagem}");
        }
    }
}
