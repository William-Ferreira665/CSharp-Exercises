using System;

namespace Challenge_Resolution
{
    class Program
    {
        static void Main(string[] args)
        {
            int idade;

            Console.WriteLine("Programa iniciado\n");
            Console.Write("Digite sua idade: ");
            idade = int.Parse(Console.ReadLine());

            if (idade >= 5 && idade <= 7){
            Console.WriteLine("Você está na categoria Infantil A 5 - 7 anos.");
            Console.WriteLine("\nCategorizador finalizado.");
            }
            else if (idade >= 8 && idade <= 10){
            Console.WriteLine("Você está na categoria Infantil B 8 - 10 anos.");
            Console.WriteLine("\nCategorizador finalizado.");
            }
            else if (idade >= 11 && idade <= 13){
            Console.WriteLine("Você está na categoria Junvenil A 11 - 13 anos.");
            Console.WriteLine("\nCategorizador finalizado.");
            }
            else if (idade >= 14 && idade <= 17){
            Console.WriteLine("Você está na categoria Juvenil B 14 - 17 anos.");
            Console.WriteLine("\nCategorizador finalizado.");
            }
            else if (idade >= 18){
            Console.WriteLine("Você está na categoria Sênior - maior de 18 anos.");
            Console.WriteLine("\nCategorizador finalizado.");
            }
            else{
            Console.WriteLine("Você está não se enquadra em nenhuma categoria, volte daqui um tempo! ");
            Console.WriteLine("\nPrograma finalizado.");
            }
        }
    }
}