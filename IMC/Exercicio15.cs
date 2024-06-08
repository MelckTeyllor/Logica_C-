using System;
using System.Globalization;

class Program
{
    static void Main()
    {
        // Configuração da cultura para garantir o uso de ponto como separador decimal
        CultureInfo culture = CultureInfo.InvariantCulture;

        // Leitura do peso
        Console.Write("Digite seu peso (kg): ");
        if (!double.TryParse(Console.ReadLine(), NumberStyles.Any, culture, out double peso))
        {
            Console.WriteLine("Valor de peso inválido.");
            return;
        }

        // Leitura da altura
        Console.Write("Digite sua altura (m): ");
        if (!double.TryParse(Console.ReadLine(), NumberStyles.Any, culture, out double altura))
        {
            Console.WriteLine("Valor de altura inválido.");
            return;
        }

        // Cálculo do IMC
        double imc = peso / (altura * altura);

        // Exibição do IMC
        Console.WriteLine($"Seu IMC é: {imc:F2}");

        // Determinação da categoria do IMC
        if (imc < 18.5)
        {
            Console.WriteLine("Categoria: Abaixo do peso");
        }
        else if (imc >= 18.5 && imc < 24.9)
        {
            Console.WriteLine("Categoria: Peso normal");
        }
        else if (imc >= 25 && imc < 29.9)
        {
            Console.WriteLine("Categoria: Sobrepeso");
        }
        else if (imc >= 30 && imc < 34.9)
        {
            Console.WriteLine("Categoria: Obesidade grau I");
        }
        else if (imc >= 35 && imc < 39.9)
        {
            Console.WriteLine("Categoria: Obesidade grau II");
        }
        else
        {
            Console.WriteLine("Categoria: Obesidade grau III");
        }
    }
}
