using System;

namespace AtividadeLP3
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Digite seu Nome: ");
            string nome = Console.ReadLine();

            Console.WriteLine("Digite sua Altura: ");
            double altura = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine("Digite seu peso: ");
            double peso = Convert.ToSingle(Console.ReadLine());

            Individuo i1 = new Individuo(nome, altura, peso);

            System.Console.WriteLine(i1.IMC);
            System.Console.WriteLine(i1.Classificacao());

        }
    }
}
