//Escreva um programa que leia a nota de um aluno e converta-a para conceito: A (nota >= 9), B (7 <= nota < 9), C (5 <= nota < 7), D (3 <= nota < 5) e F (nota < 3). 
using System;

class Exercicio8 {
    static void Main(string[] args) {
        Console.WriteLine("Converte Nota para Conceito");
        Console.Write("Digite a primeira nota do aluno: ");
        double nota1 = Convert.ToDouble(Console.ReadLine());
        Console.Write("Digite a segunda nota do aluno: ");
        double nota2 = Convert.ToDouble(Console.ReadLine());
        Console.Write("Digite a terceira nota do aluno: ");
        double nota3 = Convert.ToDouble(Console.ReadLine());

        double media = (nota1 + nota2 + nota3) / 3;

        if(media >= 9){
            Console.WriteLine("Você está Aprovado Sua nota é: A");
        }else if (media >= 7 && media < 9) {
            Console.WriteLine("Você está Aprovado! Sua nota é: B");
        } else if (media >= 5 && media < 7) {
            Console.WriteLine("Você está de Recuperação! Sua nota é: C");
        }else if (media >= 3 && media< 5) {
            Console.WriteLine("Você está de Recuperação! Sua nota é: D");
        } else if(media < 3) {
            Console.WriteLine("Você está Reprovado! Sua nota é: F");

        }
    }
}