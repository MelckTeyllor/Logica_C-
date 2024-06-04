// Escreva um programa que leia o valor de uma compra e a categoria do cliente (1 para comum, 2 para associado e 3 para VIP). Aplique os seguintes descontos: 

// Comum: Sem desconto 

// Associado: 10% de desconto 

// VIP: 20% de desconto 

// Informe o valor final da compra. 

using System;

class Exercicio13 {
    static void Main(string[] args) {
        Console.WriteLine("Programa para Calcular Desconto");
        Console.WriteLine("Digite o valor da compra: ");
        double valorCompra = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Digite a categoria do cliente [1]Comum - [2]Associado - [3]Vip: ");
        int categoria = Convert.ToInt32(Console.ReadLine());
        double valorFinalCompra;
        if(categoria == 1){
            Console.WriteLine("O valor final da compra é de : R$" + valorCompra);
        }else if(categoria == 2){
            valorFinalCompra = valorCompra * ((10/100 * valorCompra));
            Console.WriteLine("O valor final da compra é de : R$" + valorFinalCompra);
        }else if(categoria == 3){
            valorFinalCompra = valorCompra * ((20/100 * valorCompra));
            Console.WriteLine("O valor final da compra é de : R$" + valorFinalCompra);
        }else {
            Console.WriteLine("Categoria Inválida");
        }
        
        
    }
}