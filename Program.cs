using System;

namespace AtividadeLP3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entre com seu nome!");
            string? nome = Console.ReadLine();

            Console.WriteLine("Entre com sua altura!");
            float altura = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine("Entre com seu peso!");
            float peso = Convert.ToSingle(Console.ReadLine());

            double IMC = peso / (altura * altura);

            double pesox = 24.99 * (altura * altura);
            double pesoy = 18.50 * (altura * altura);

            double ganhar = pesoy - peso;
            double perder = peso - pesox;

            Console.WriteLine("Você {0} de altura {1}cm e de peso {2}kg possui um IMC de: {3} ", nome, altura, peso, IMC); 

            if(IMC <= 17.00)
            {
                Console.WriteLine("Muito abaixo do peso");
                Console.WriteLine("Você precisa ganhar cerca de {0}kg para alcançar o peso ideal", ganhar);
            }
            else if(IMC >= 17.00 && IMC <= 18.49)
            {
                Console.WriteLine("Abaixo do peso");
                Console.WriteLine("Você precisa ganhar cerca de {0}kg para alcançar o peso ideal", ganhar); 
            }
            else if(IMC >= 18.50 && IMC <= 24.99)
            {
                Console.WriteLine("peso ideal");
            }
            else if(IMC >= 25 && IMC <= 29.99)
            {
                Console.WriteLine("Acima do peso");
                Console.WriteLine("Você precisa perder cerca de {0}kg para alcançar o peso ideal", perder);
            }
            else if(IMC >= 30 && IMC <= 34.99)
            {
                Console.WriteLine("Obesidade I");
                Console.WriteLine("Você precisa perder cerca de {0}kg para alcançar o peso ideal", perder);
            }
            else if(IMC >= 35 && IMC <= 39.99)
            {
                Console.WriteLine("Obesidade II (severa)");
                Console.WriteLine("Você precisa perder cerca de {0}kg para alcançar o peso ideal", perder);
            }
            else
            {
                Console.WriteLine("Obesidade III (mórbida)");
                Console.WriteLine("Você precisa perder cerca de {0}kg para alcançar o peso ideal", perder);
            }
        }
    }
}
