﻿using System;

namespace Third_Resolution
{
    class Program
    {
        static void Main(string[] args)
        {

            double salario, salarioAjustado, valorAumento;

            Console.WriteLine("Calculadora salarial iniciada\n");

            Console.Write("Digite seu salário atual: ");
            salario = double.Parse(Console.ReadLine());


            if(salario < 500){
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Você tem direito ao aumento.");
                Console.ForegroundColor = ConsoleColor.White;
                salarioAjustado = salario * 1.3;
                valorAumento = salario * 0.3;
                Console.WriteLine("Seu salário teve um aumento de {0:C2}", valorAumento);
                Console.WriteLine("Agora seu salário é de {0:C2}", salarioAjustado);
                Console.WriteLine("Programa finalizado.");
            }else{
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Você não tem direito ao aumento.");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Programa finalizado.");
            }

        }
    }
}
            
