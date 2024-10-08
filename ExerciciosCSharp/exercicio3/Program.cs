namespace exercicio3;
using System;
internal class Program
{
    static void Main(string[] args)
    {
        double num1;
        double num2;

        do {
            Console.WriteLine("Insira um número: ");
            num1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Insira outro número (diferente de 0): ");
            num2 = double.Parse(Console.ReadLine());

        } while (num2 == 0 || num1 == 0);

        double soma = num1 + num2;
        double sub = num1 - num2;
        double multi = num1 * num2;
        double div = num1 / num2;
        double media = soma / 2;

        Console.WriteLine("A soma dos números inseridos é: " + soma + "\nA subtração dos números inseridos é: " + sub + "\nA multiplicação dos números inseridos é: " + multi + "\nA divisão do primeiros pelo segundo número é: " + div + "\nA média dos números inseridos é: " + media);


    }
}
