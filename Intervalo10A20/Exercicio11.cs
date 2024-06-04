//Escreva um programa que leia um número e verifique se ele está no intervalo de 10 a 20 (inclusive).
using System;

class Exercicio11 {
    static void Main(string[] args) {
        Console.Write("Digite um número: ");
        int numero = int.Parse(Console.ReadLine());
        if(numero >= 10 && numero <= 20){
            Console.WriteLine("O número " + numero + " está no intervalo de 10 a 20");
        }else{
            Console.WriteLine("O número " + numero + " não está no intervalo de 10 a 20");
        }
    }
}