//Escreva um programa que leia um número e verifique se ele é maior que 100. Se não for, informe o dobro desse número. 
using System;

class Exercicio12{
    static void Main(string[] args){
        Console.WriteLine("Número maior que 100");
        Console.Write("Digite um número: ");
        int numero = int.Parse(Console.ReadLine());
        if(numero > 100){
            Console.WriteLine("O número " + numero + " é maior que 100");
        } else if(numero == 100){
            Console.WriteLine("O número " + numero + " é igual a 100");
        }
        else {
            Console.WriteLine("O número " + numero + " não é maior que 100");
            Console.WriteLine("O dobro de " + numero + " é " + (numero * 2));
            
        }
    }
}