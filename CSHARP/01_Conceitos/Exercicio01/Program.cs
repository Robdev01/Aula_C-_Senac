using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe seu nome: ");
            string nome = Console.ReadLine(); 

            Console.WriteLine("informe sua Idade: ");
            int idade = int.Parse(Console.ReadLine());

            Console.WriteLine("Informe sua altura:");
            double altura = double.Parse(Console.ReadLine());

            Console.WriteLine("informe seu peso: ");
            double peso = double.Parse(Console.ReadLine());


            double imc = peso / (altura * altura);

            Console.WriteLine($"{nome} seu imc é {imc} ");

            Console.ReadKey();


        }
    }
}
