//  Escreva um programa que leia três notas de um aluno e calcule a média. Informe se o aluno está aprovado (média >= 7), em recuperação (5 <= média < 7) ou reprovado (média < 5). 
using System ;

class Exercicio5 {
    static void Main(string[] args){
        Console.WriteLine("Programa para Calcular Média do Aluno");

        Console.WriteLine("Digite a primeira Nota do Aluno: ");
        double nota1 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Digite a segunda Nota do Aluno: ");
        double nota2 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Digite a terceira Nota do Aluno: ");
        double nota3 = Convert.ToDouble(Console.ReadLine());

        double media = (nota1 + nota2 + nota3) / 3;

        if(media >=7){
            Console.WriteLine("Parabens, você está aprovado! Sua nota é: " + Math.Round(media, 2));
        }else if(media >=5 && media <= 7){
            Console.WriteLine("Você está em recuperação! Sua nota é: " + Math.Round(media, 2));
        } else if (media <5 ){
            Console.WriteLine("Você está reprovado Sua nota é: " + Math.Round(media, 2));
        }


    }
}