using  System;

class Exercicio4 {
    static void Main(string[] args) {
        Console.WriteLine("Programa pra saber se é possivel formar um triângulo");

        Console.WriteLine("Digite o tamanho do lado A:");
        int ladoA = int.Parse(Console.ReadLine());
        Console.WriteLine("Digite o tamanho do lado B:");
        int ladoB = int.Parse(Console.ReadLine());
        Console.WriteLine("Digite o tamanho do lado C:");
        int ladoC = int.Parse(Console.ReadLine());

        if (ladoA + ladoB  > ladoC && ladoB + ladoC > ladoA && ladoC + ladoA > ladoB) {
            Console.WriteLine("É possivel formar um triângulo");
        } else{
            Console.WriteLine("Não é possivel formar um triângulo");
        }
    }

}