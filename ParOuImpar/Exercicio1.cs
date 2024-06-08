using System;

class Exercicio1 {
     static void Main(string[] args)
    {
     Console.WriteLine("Exercicio de números pares ou impares");
     Console.WriteLine("Digite um Número:");
     int numero = Convert.ToInt32(Console.ReadLine());
     string resposta;
     if(numero % 2 == 0){
        resposta = "Esse número é par";
     }else {
        resposta = "Esse número é impar";
     }
     Console.WriteLine(resposta);
    }
  }
