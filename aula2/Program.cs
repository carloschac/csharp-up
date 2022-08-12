using System;

namespace Aula2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe uma largura:");
            double largura = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Informe uma altura:");
            double altura = Convert.ToDouble(Console.ReadLine());
            double area = CalculaArea(largura,altura);
            Console.WriteLine("A area equivale a:");
            Console.WriteLine(area);
            
        }

         static double CalculaArea(double largura, double altura)
        {
            //double area = largura * altura;
            return largura * altura;
            
        }
    }
}
