//Escreva um programa que leia um número e informe se ele é positivo ou negativo. Se for positivo, calcule a raiz quadrada; se for negativo, informe o número ao quadrado. 
using System;

class PositivoNEgativa{
    static void Main(string[] args){
        Console.WriteLine("Número Negativo ou Positivo?");
        Console.WriteLine("Digite um número inteiro?");
        int numero = Convert.ToInt32( Console.ReadLine());

        if (numero > 0){
            double raizQuadrada = Math.Sqrt(numero);
            Console.WriteLine("A raiz quadrada do número é: " + raizQuadrada);

        }else if (numero < 0){
           int quadrado = numero * numero;
            Console.WriteLine("O quadrado do número é: " + quadrado);
       } else {
            Console.WriteLine("O número é zero.");
       }
    }
}