//Escreva um programa que leia um ano e verifique se ele é bissexto. Um ano é bissexto se for divisível por 4, mas não por 100, exceto se for divisível por 400. 
using System;

class Exercicio6{
    static void Main(string[] args){
        int ano;
        Console.Write("Digite um ano: ");
        ano = int.Parse(Console.ReadLine());
        if(ano % 4 == 0 && ano % 100!= 0 || ano % 400 == 0){
            Console.WriteLine("O ano " + ano + " é bissexto");
        }else{
            Console.WriteLine("O ano " + ano + " não é bissexto");
        }
        
    }
}