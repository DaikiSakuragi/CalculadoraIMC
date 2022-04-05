using System;

namespace CalculadoraIMC
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entre com seu nome!");
            string nome = Console.ReadLine();

            Console.WriteLine("Entre com sua altura!");
            float altura = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine("Entre com seu peso!");
            float peso = Convert.ToSingle(Console.ReadLine());

            double IMC = peso / (altura * altura);

            Console.WriteLine("Você {0} de altura {1}cm e de peso {2}kg possui um IMC de: {3} ", nome, altura, peso, IMC); 

        }
    }
}
