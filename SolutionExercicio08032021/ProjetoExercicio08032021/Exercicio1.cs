using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoExercicio08032021
{
    class Exercicio1
    {
        static void Main(string[] args)
        {
            int anos, meses, dias, total;

            Console.WriteLine("Informe qual a sua idade em anos, meses e dias.");

            Console.Write("Anos: ");
            anos = int.Parse(Console.ReadLine());

            Console.Write("Meses: ");
            meses = int.Parse(Console.ReadLine());

            Console.Write("Dias: ");
            dias = int.Parse(Console.ReadLine());

            total = (anos * 365) + (meses * 30) + dias;

            Console.WriteLine("\nVocê tem " + total + " dias de vida");
            Console.ReadKey();
        }
    }
}