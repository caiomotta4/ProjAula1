﻿using Model.Exercicio10;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjExercicio15032021
{
    class Exercicio10
    {
        static void Main(string[] args)
        {
            Estatisticas estatisticas = new Estatisticas();

            estatisticas.ReadData();
            estatisticas.DisplayStatistics();

            Console.ReadKey();
        }
    }
}