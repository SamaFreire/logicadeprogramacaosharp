using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace DeclaracaodeVariaveiseConstantes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Exercicio 1
            int idade = 25;
            const double PI = 3.14159;
            Console.WriteLine($"idade: {idade}");
            Console.WriteLine($"PI: {PI}");




            //Exercicio 2
            string nome = "Maria";
            const int numeroMaximo = 100;

            Console.WriteLine($"Nome: {nome}");

            if (numeroMaximo == 100)
            {
                Console.WriteLine($"Numero Maximo: {numeroMaximo}");
            }
            





            Console.ReadLine();
        }
     
    }
}
 