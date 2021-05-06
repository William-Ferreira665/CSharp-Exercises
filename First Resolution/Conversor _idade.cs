using System;

namespace Resolutions
{
    class Program
    {
        static void Main(string[] args)
        {
            int anos, meses, dias;
            double horas, minutos;
            
            Console.WriteLine("Conversor de idade iniciado\n");
            Console.Write("Escreva a sua idade: ");
            anos = int.Parse(Console.ReadLine());

            meses = anos * 12;
            dias = anos * 365;
            horas = dias * 24;
            minutos = horas * 60;

            Console.WriteLine("Essa é sua idade em meses: " + meses);
            Console.WriteLine("Essa é sua idade em dias: " + dias);
            Console.WriteLine("Essa é sua idade em horas: " + horas);
            Console.WriteLine("Essa é sua idade em minutos: " + minutos);

            Console.WriteLine("Fim do programa");
        
            
        }
    }
}
