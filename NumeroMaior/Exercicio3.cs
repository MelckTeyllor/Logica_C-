using System;

class Exercicio3 {
    static void Main(string[] args) {
        Console.WriteLine("Programa pra identificar o maior número digitado");
        Console.WriteLine("Digite o primeiro número:");
        int numero1 = int.Parse(Console.ReadLine());
        Console.WriteLine("Digite o segundo número:");
        int numero2 = int.Parse(Console.ReadLine());

        if (numero1 > numero2) {
            Console.WriteLine(numero1 + " é o maior número");
        }else {
            Console.WriteLine(numero2 + " é o maior número");
        }

    }
}