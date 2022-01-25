using System;

namespace Compara
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" ==== Comparando Objeto ==== ");

            var compararA = new ComparaObjeto("Espelho 1");
            var compararB = new ComparaObjeto("Espelho 1");

            Console.Write("O que esperamos é : ");
            Console.WriteLine(compararA == compararB);
            
            Console.Write("O que realmente esperamos é : ");
            Console.WriteLine(compararA.Espelho == compararB.Espelho);
        }
    }
    
    public class ComparaObjeto
    {
        public string Espelho { get; set; }
        public CompararObjeto(string espelho)
        {
            Espelho = espelho;
        }
    }
}
