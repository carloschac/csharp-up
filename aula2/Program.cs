using System;

namespace Aula2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe uma largura:");
            //Console.WriteLine("Hello World!");
            //double area = CalculaArea(35.0, 3.0);
            CalculaArea(35, 3);
            string largura = Console.ReadLine();
        }

         static double CalculaArea(double largura, double altura)
        {
            //double area = largura * altura;
            return largura * largura;
            
        }
    }
}
