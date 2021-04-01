using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoExercicio08032021
{
    class Exercicio3
    {
        static void Main(string[] args)
        {
            float custofabrica, custofinal, imposto, distribuidor;

            Console.Write("Digite o custo de fábrica: ");
            custofabrica = float.Parse(Console.ReadLine());

            distribuidor = (custofabrica / 100) * 28;
            imposto = (custofabrica / 100) * 45;

            custofinal = custofabrica + distribuidor + imposto;

            Console.WriteLine("\nCusto final para o consumidor: " + custofinal);

            Console.ReadKey();
        }
    }
}