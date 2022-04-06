class Individuo
{
    public double Nome { get; set; }
    public double Altura { get; set; }
    public double Peso { get; set; }
    public double IMC { get => Peso / (Altura * Altura); }
    public double Pesox { get => 24.99 / (Altura * Altura); }
    public double Pesoy { get => 18.50 / (Altura * Altura); }
    public double Ganhar { get => Pesoy - Peso; }
    public double Perder { get => Peso - Pesox; }
    public Individuo(double nome, double altura, double peso)
    {
        Nome = nome;
        Altura = altura;
        Peso = peso;
    } 

    public string Classificacao()
    {
            if(IMC <= 17.00)
            {
                return "Muito abaixo do peso. Você precisa ganhar cerca de {0}kg para alcançar o peso ideal" + Ganhar;
            }
            else if(IMC >= 17.00 && IMC <= 18.49)
            {
                return "Abaixo do peso. Você precisa ganhar cerca de {0}kg para alcançar o peso ideal" + Ganhar;
            }
            else if(IMC >= 18.50 && IMC <= 24.99)
            {
                return "peso ideal";
            }
            else if(IMC >= 25 && IMC <= 29.99)
            {
                return "Acima do peso. Você precisa perder cerca de {0}kg para alcançar o peso ideal" + Perder;
            }
            else if(IMC >= 30 && IMC <= 34.99)
            {
            
                return "Obesidade I. Você precisa perder cerca de {0}kg para alcançar o peso ideal" + Perder;
            }
            else if(IMC >= 35 && IMC <= 39.99)
            {
                return "Obesidade II (severa). Você precisa perder cerca de {0}kg para alcançar o peso ideal" + Perder;
            }
            
                return "Obesidade III (mórbida). Você precisa perder cerca de {0}kg para alcançar o peso ideal" + Perder;
    }
}