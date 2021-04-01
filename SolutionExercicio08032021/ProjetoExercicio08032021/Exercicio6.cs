using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoExercicio08032021
{
    class Exercicio6
    {
        static void Main(string[] args)
        {
            double fixo, vendas, total;

            Console.Write("Informe o salario fixo do funcionario:)
            fixo = double.Parse(Console.ReadLine());


            Console.Write("Informe o valor das vendas: R$");
            vendas = double.Parse(Console.ReadLine());


            if (vendas <= 1500)
                total = fixo + vendas * 0.03;
            else
                total = fixo + 1500 * 0.03 + (vendas - 1500) * 0.05;

            Console.Write("\nSalario total: R$" + total);
            Console.ReadKey();


        }

    }
}

