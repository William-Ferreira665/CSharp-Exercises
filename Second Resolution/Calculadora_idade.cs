﻿using System;

namespace Second_Resolution
{
    class Program
    {
        static void Main(string[] args)
        {
        
        int anoIdade, anoAtual, idade, semanas;

            Console.WriteLine("Calculadora iniciada\n");

            Console.Write("Digite o seu ano de nascimento: ");
            anoIdade = int.Parse(Console.ReadLine());
            anoAtual = DateTime.Now.Year;

            idade = anoAtual - anoIdade;
            semanas = idade * 52;

            Console.WriteLine("\nSua idade atual em anos é de " + idade + " anos.");
            Console.WriteLine($"Sua idade atual em semanas é de {semanas} semanas.");

            Console.WriteLine("\nPrograma finalizado.");
        }
    }
}