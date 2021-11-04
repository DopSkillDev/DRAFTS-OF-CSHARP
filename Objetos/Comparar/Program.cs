using System;

namespace Comparar
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" ==== Comparando Objeto ==== ");

            var compararA = new Comparar("Espelho 1");
            var compararB = new Comparar("Espelho 1");

            Console.Write("O que esperamos é : ");
            Console.WriteLine(compararA == compararB);
            
            Console.Write("O que realmente esperamos é : ");
            Console.WriteLine(compararA.Espelho == compararB.Espelho);
        }
    }

    public class Comparar
    {
        public string Espelho { get; set; }
        public Comparar(string espelho)
        {
            Espelho = espelho;
           
        }
    }
}