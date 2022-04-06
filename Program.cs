using System;

namespace AtividadeLP3
{
    class Program
    {
        static void Main(string[] args)
        {
            Individuo i1 = new Individuo("Daiki", 1.70, 80);

            System.Console.WriteLine(i1.Nome);
            System.Console.WriteLine(i1.Altura);
            System.Console.WriteLine(i1.Peso);
            System.Console.WriteLine(i1.IMC);
            System.Console.WriteLine(i1.Classificacao());

        }
    }
}
