using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoExercicio08032021
{
    class Exercicio4
    {
        static void Main(string[] args)
        {
            double salario, comissao, vendas, totalvendas, salariofinal;

            Console.Write("Digite o salário fixo: ");
            salario = double.Parse(Console.ReadLine());

            Console.Write("Digite a comissão de cada carro: ");
            comissao = double.Parse(Console.ReadLine());

            Console.Write("Digite o número de carros vendidos: ");
            vendas = double.Parse(Console.ReadLine());

            Console.Write("Valor total de vendas: ");
            totalvendas = double.Parse(Console.ReadLine());

            salariofinal = salario + (comissao * vendas) + (totalvendas * 0.05);

            Console.WriteLine("O salário final: " + salariofinal);

            Console.ReadKey();
        }
    }
}