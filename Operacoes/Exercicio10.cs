//Escreva um programa que leia dois números e uma operação (adição, subtração, multiplicação ou divisão) e realize a operação correspondente.

using System;

class Exercicio10
{
    static void Main(string[] args)
    {
        Console.WriteLine("Programa para Realizar Operações Matemáticas");
        Console.Write("Digite o Primeiro Número: ");
        int numero1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Digite o Segundo Número: ");
        int numero2 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Escolha a operação([1]Soma - [2]Subtração - [3]Multiplicação: - [4]Divisão ");

        int operacao = Convert.ToInt32(Console.ReadLine());
        int soma = numero1 + numero2;
        int subtracao = numero1 - numero2;
        int multiplicacao = numero1 * numero2;
        int divisao = numero1 / numero2;


        switch (operacao)

        {
            case 1:
                Console.WriteLine("Operação Soma");
                Console.Write(numero1 + " " + "+ " + numero2 + " = " + soma);
                break;
            case 2:
                Console.WriteLine("Operação Subtração");
                Console.Write(numero1 + " " + "- " + numero2 + " = " + subtracao);
                break;
            case 3:
                Console.WriteLine("Operação Multiplicação");
                Console.Write(numero1 + " " + "X " + numero2 + " = " + multiplicacao);
                break;
            case 4:
                Console.WriteLine("Operação Divisão");
                Console.Write(numero1 + " " + ": " + numero2 + " = " + divisao);
                break;
            default:
                Console.Write("Código Invalido");
    break;
        }
    }
}