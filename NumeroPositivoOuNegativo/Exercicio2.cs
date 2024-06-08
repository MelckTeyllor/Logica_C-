using System;

class Exercicio2{
    static void Main(string[] args){    
        Console.WriteLine("Programa De Números Positivos e Negativos");
        Console.WriteLine("Digite um nummero inteiro para verificarmos se ele é positvo ou negativo:");
        int numero = int.Parse(Console.ReadLine());

        if (numero > 0){
            Console.WriteLine("Esse número é positivo");
        }else {
            Console.WriteLine("Esse número é negativo");
        }
    }
}