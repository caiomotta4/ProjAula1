using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoExercicio08032021
{
    class Exercicio2
    {
        static void Main(string[] args)
        {
            float numerototal, votosbrancos, votosnulos, votosvalidos;
            float porbrancos, pornulos, porvalidos;

            do
            {
                do
                {
                    Console.Write("Digite o número total de eleitores do município: ");
                    numerototal = float.Parse(Console.ReadLine());
                } while (numerototal <= 0);

                do
                {
                    Console.Write("Digite o número de votos brancos: ");
                    votosbrancos = float.Parse(Console.ReadLine());
                } while (votosbrancos < 0);

                do
                {
                    Console.Write("Digite o número de votos nulos: ");
                    votosnulos = float.Parse(Console.ReadLine());
                } while (votosnulos < 0);

                do
                {
                    Console.Write("Digite o número de votos válidos: ");
                    votosvalidos = float.Parse(Console.ReadLine());
                } while (votosvalidos < 0);

                if ((votosbrancos + votosnulos + votosvalidos) != numerototal)
                {
                    Console.WriteLine("\nA soma dos votos precisa ser igual ao números de eleitores!");
                    Console.WriteLine("\n");
                }
            } while ((votosbrancos + votosnulos + votosvalidos) != numerototal);

            porbrancos = (votosbrancos / numerototal) * 100;
            pornulos = (votosnulos / numerototal) * 100;
            porvalidos = (votosvalidos / numerototal) * 100;

            Console.WriteLine("\nVotos Brancos: " + Math.Round(porbrancos, 2) + "%");
            Console.WriteLine("\nVotos Nulos: " + Math.Round(pornulos, 2) + "%");
            Console.WriteLine("\nVotos Válidos: " + Math.Round(porvalidos, 2) + "%");

            Console.ReadLine();
        }
    }
}