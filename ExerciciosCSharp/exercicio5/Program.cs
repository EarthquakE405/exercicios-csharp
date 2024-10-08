namespace exercicio5;
using System;

internal class Program
{
    static void Main(string[] args)
    {
        bool erroletras = false, erronum = false;
        string placa;

        do
        {
            Console.WriteLine("Insira a placa que será avaliada: ");
            placa = Console.ReadLine();

            if(placa.Length != 7)
            {
                Console.WriteLine("Erro. A placa deve conter exatamente 7 caracteres, tente novamente!");
            }
             
        }while(placa.Length != 7);

        string primeiros = placa.Substring(0, 3);
        string ultimos = placa.Substring(3, 4);

        for (int i = 0; i< primeiros.Length; i++)
        {
            char c = primeiros[i];

            if (!char.IsLetter(c)){
                erroletras = true; 
            }
        }

        for (int i = 0; i<ultimos.Length; i++)
        {
            char ch = ultimos[i];

            if (!char.IsDigit(ch)){
                erronum = true;
            }
        }

        if (erroletras || erronum)
        {
            Console.WriteLine("Falso");
        }
        else
        {
            Console.WriteLine("Verdadeiro");
        }


    }
}
